namespace GatecoinServiceInterface.Response
{
    public class EnableGoogleAuthResponse : CommonResponse
    {
        public string SecretKey { get; set; }
        public string QRCode { get; set; }
    }
}