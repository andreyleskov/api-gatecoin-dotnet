using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GatecoinServiceInterface.Client;
using GatecoinServiceInterface.WebSocket.Client;
using GatecoinServiceInterface.WebSocket.Model;
using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Sample
{
    public static class Run
    {
        public static string Root = "https://streaming.gtcprojects.com";
        public static string PublicKey = "<PUBLIC-KEY-HERE>";
        public static string PrivateKey = "<PRIVATE-KEY-HERE>";

        private static string CurrencyPair = "BTCUSD";
        private static readonly object LockObject = new object();

        public static void RunAll()
        {
            var tasks = new List<Task>();

            tasks.Add(Run.StartPublicStreamingForTrader());

            tasks.Add(Run.StartPrivateStreamingForTrader(PublicKey, PrivateKey));

            Task.WaitAll(tasks.ToArray());

            WriteLine(ConsoleColor.White, "Finished. Press enter to exit");
            Console.ReadLine();
        }

        public static async Task StartPublicStreamingForTrader()
        {
            var builder = new StreamingClientBuilder(Root);

            using (var client = builder.BuildTraderClient())
            using(client.SubscribeAll(PublicTradeBroadcastHandler))
            using(client.Subscribe(CurrencyPair, PublicTradeCurrencyPairHandler))
            {
                client.Disconnected += OnClientOnDisconnected;

                await client.Start();
                
                WriteLine(ConsoleColor.White, "Waiting for public events for 1 minute");

                Thread.Sleep(60000);
                
                await client.Stop();

                WriteLine(ConsoleColor.White, "Stop listening public events");
            }
        }

        public static async Task StartPrivateStreamingForTrader(string publicKey, string privateKey)
        {
            var urlHub = $"{Root}{Channels.GetPrivateChannelHub<TradeDto>()}";
            var timeStamp = DateTime.UtcNow;

            var builder = new StreamingClientBuilder(Root);

            builder
                .WithAccessToken(
                    token =>
                    {
                        token.DateTime = timeStamp;
                        token.SignedMessage = ServiceSignature.CreateToken($"{urlHub}{timeStamp.ToUnixTimeString()}", privateKey);
                        token.PublicKey = publicKey;
                    });


            using (var client = builder.BuildTraderClient())
            using (client.SubscribeAll(PrivateTradeBroadcastHandler))
            using (client.Subscribe(CurrencyPair, PrivateTradeCurrencyPairHandler))
            {
                client.Disconnected += OnClientOnDisconnected;

                await client.Start();

                WriteLine(ConsoleColor.Blue, "Waiting for private events for 2 minute");

                Thread.Sleep(120000);
                
                await client.Stop();

                WriteLine(ConsoleColor.Blue, "Stop private public events");
            }
        }

        private static void OnClientOnDisconnected(object sender, DisconnectEventArgs<TradeDto> args)
        {
            if (args.Exception != null)
            {
                WriteLine(ConsoleColor.Red, $"Disconected. Error: {args.Exception.Message}");
                WriteLine(ConsoleColor.Red, "Trying to reconnect after 15 seconds...");

                Thread.Sleep(15000);

                try
                {
                    args.Client.Start();
                    WriteLine(ConsoleColor.Red, "Connected.");
                }
                catch (Exception ex)
                {
                    WriteLine(ConsoleColor.Red, $"Was not able to connect. {ex.Message}");
                }
            }
            else
            {
                WriteLine(ConsoleColor.Red, $"Disconected by the user.");
            }
        }

        private static void PublicTradeBroadcastHandler(TradeDto arg) => WriteLine(ConsoleColor.Green, $"Public Trade Broadcast Channel: {JsonConvert.SerializeObject(arg)}");
        private static void PublicTradeCurrencyPairHandler(TradeDto arg) => WriteLine(ConsoleColor.Green, $"Public Trade CurrencyPair Channel: {JsonConvert.SerializeObject(arg)}");

        private static void PrivateTradeBroadcastHandler(TradeDto arg) => WriteLine(ConsoleColor.DarkMagenta, $"Private Trade Broadcast Channel: {JsonConvert.SerializeObject(arg)}");
        private static void PrivateTradeCurrencyPairHandler(TradeDto arg) => WriteLine(ConsoleColor.DarkMagenta, $"Private Trade CurrencyPair Channel: {JsonConvert.SerializeObject(arg)}");

        private static void WriteLine(ConsoleColor color, string format)
        {
            lock (LockObject)
            {
                var before = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(format);
                Console.ForegroundColor = before;
            }
        }
    }
}