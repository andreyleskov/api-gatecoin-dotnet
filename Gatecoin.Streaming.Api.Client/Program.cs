using System;
using Gatecoin.Streaming.Dto;
using Newtonsoft.Json;

namespace Gatecoin.Streaming.Api.Client
{
    internal class Program
    {
        private static void Main()
        {
            var builder = new StreamingClientBuilder();

            using (var client = builder.BuildClient<TradeDto>())
            {
                client.Start().Wait();

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