using System;
using System.Threading.Tasks;
using GatecoinServiceInterface.WebSocket.Client;
using GatecoinServiceInterface.WebSocket.Model;
using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Sample
{
    public class Run
    {
        public static async Task Start()
        {
            var builder = new StreamingClientBuilder("put url here");

            using (var client = await builder.BuildTraderClient().Start())
            {
                void TradeHandler(TradeDto arg) => Console.WriteLine(JsonConvert.SerializeObject(arg));

                var subscription = client.SubscribeAll(TradeHandler);
                var subscriptionBtcUsd = client.Subscribe("BTCUSD", TradeHandler);

                Console.WriteLine("Waiting for events");
                Console.ReadLine();

                subscription.Dispose();
                subscriptionBtcUsd.Dispose();
            }
        }
    }
}