using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderSecurityOption
    {
        public bool LoginWarning { get; set; }
        public int LoginValidation { get; set; }
        public bool TradeWarning { get; set; }
        public int TradeValidation { get; set; }
        public bool WithdrawWarning { get; set; }
        public int WithdrawValidation { get; set; }
        public bool AddAccountWarning { get; set; }
        public int AddAccountValidation { get; set; }
        public bool ChangeDetailsWarning { get; set; }
        public int ChangeDetailsValidation { get; set; }
        public int ChangePasswordValidation { get; set; }
        public bool IsGoogleAuthEnabled { get; set; }
        public bool IsSmsValidationEnabled { get; set; }
    }
}