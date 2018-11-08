using System;

namespace GatecoinServiceInterface.Response
{
    public class RegisterUserResponse : CommonResponse
    {
        public bool IsSuccess { get; set; }
        public string ApiKey { get; set; }
        public string PublicKey { get; set; }
        public string Alias { get; set; }
        public string DefaultCurrency { get; set; }
        public string DefaultLanguage { get; set; }
        public int VerifLevel { get; set; }
        public bool UserHasUnreadTickets { get; set; }
        public DateTime LastLogonTime { get; set; }
        public bool IsPendingUnlockSecret { get; set; }
    }
}