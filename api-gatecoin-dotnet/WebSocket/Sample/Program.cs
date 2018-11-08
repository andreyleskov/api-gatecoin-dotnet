using System;
using System.Threading.Tasks;
using GatecoinServiceInterface.WebSocket.Client;
using GatecoinServiceInterface.WebSocket.Model;
using Newtonsoft.Json;

namespace GatecoinServiceInterface.WebSocket.Sample
{
    public class Program
    {
        public async Task Start()
        {
            var builder = new StreamingClientFactory();

            using (var client = await builder.CreateTradeClient())
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