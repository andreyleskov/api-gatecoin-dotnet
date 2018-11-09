API Client CSharp
=================

GatecoinServiceInterface is a toolkit for accessing the Http API, in C#


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
```
