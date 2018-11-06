using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public enum DocumentStatus
    {
        NotPresent = 0,
        Present = 1,
        Validated = 2
    }
}