API Client CSharp
=================

GatecoinServiceInterface is a toolkit for accessing the Http API, in C#
Usage example: 

```
using System;
using System.Linq;

using GatecoinServiceInterface.Client;
using GatecoinServiceInterface.Model;
using GatecoinServiceInterface.Response;
using GatecoinServiceInterface.Request;

namespace GatecoinApiClientExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string publicApiKey = "PUBLIC_API_KEY";
            const string privateApiKey = "PRIVATE_API_KEY";

            var GatecoinClient = new ServiceClient();
            GatecoinClient.SetApiKey(publicApiKey, privateApiKey);

            var balances = GatecoinClient.Get<BalancesResponse>("/Balance/Balances").Balances;
            var availableHkdBalance = 
                balances.SingleOrDefault(b => b.Currency == "HKD").AvailableBalance;

            var buyBtcOrder = new AddOrder()
            {
                Code = "BTCHKD",
                Way = "Bid",
                Amount = 0.25m,
                Price = 50000m,
            };

            var placedOrderId = GatecoinClient.Post<AddOrderResponse>("/Trade/Orders/", buyBtcOrder).ClOrderId;
            Console.WriteLine($"Sucessfully created Order {placedOrderId}");

            var cancelOrder = GatecoinClient.Delete<CommonResponse>($"/Trade/Orders/{placedOrderId}");
            if (cancelOrder.ResponseStatus.Message == "OK") 
            {
                Console.WriteLine($"Sucessfully cancelled order {placedOrderId}");
            }
        }
    }
}
```

API Streaming client
=================

This is a set of classes that enables clients to use public websocket Gatecoin channels.

Using currency pairs, the client can subscribe to special events from Gatecoin exchange.
Events are defined by the following DTO data types:

* TraderDto
* TickerDto
* MarketDepthDto

To subscribe to all events, the ```SubscribeAll``` method should be invoked.<br>
To ***unsubscribe*** from all events the ```Dispose``` method should be invoked.
 


```
public static async Task Start()
{
    var builder = new StreamingClientBuilder("https://streaming.gatecoin.com");

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
```
