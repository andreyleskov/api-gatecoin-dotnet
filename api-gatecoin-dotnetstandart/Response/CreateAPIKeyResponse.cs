namespace GatecoinServiceInterface.Response
{
    public class CreateAPIKeyResponse : CommonResponse
    {
        public string PublicKey { get; set; }
        public string Key { get; set; }
    }
}