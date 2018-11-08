using GatecoinServiceInterface.WebSocket.Sample;

namespace StreamingClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run.Start().Wait();
        }
    }
}