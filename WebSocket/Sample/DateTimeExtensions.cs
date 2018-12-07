using System;
using System.Globalization;
using GatecoinServiceInterface.WebSocket.Client;

namespace GatecoinServiceInterface.WebSocket.Sample
{
    /// <summary>
    /// This extension and conversion is used in Streaming
    /// </summary>
    public static class DateTimeExtensions
    {
        public static string ToUnixTimeString(this DateTime? dateTime)
        {
            return dateTime.ToUnixTime().ToString("F0", CultureInfo.InvariantCulture);
        }

        public static string ToUnixTimeString(this DateTime dateTime)
        {
            return dateTime.ToUnixTime().ToString("F0", CultureInfo.InvariantCulture);
        }

        public static double ToUnixTime(this DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return 0;
            }

            return dateTime.Value.TotalSeconds();
        }

        public static double ToUnixTime(this DateTime dateTime)
        {
            return dateTime.TotalSeconds();
        }

        private static double TotalSeconds(this DateTime dateTime)
        {
            return (dateTime.ToUniversalTime() - Unix.Epoch).TotalSeconds;
        }
    }
}