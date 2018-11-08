namespace GatecoinServiceInterface.Response
{
    public class GetNetworkStatsResponse : CommonResponse
    {
        public decimal Blocks_Mined { get; set; }
        public decimal Time_Between_Blocks { get; set; }
        public decimal Bitcoins_Mined { get; set; }
        public decimal Total_Transaction_Fees { get; set; }
        public int No_of_Transactions { get; set; }
        public decimal Total_Output_Volume { get; set; }
        public decimal Difficulty { get; set; }
        public decimal Hash_Rate { get; set; }
    }
}