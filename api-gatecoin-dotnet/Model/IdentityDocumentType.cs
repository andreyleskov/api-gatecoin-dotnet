using GatecoinServiceInterface.Response;

namespace GatecoinServiceInterface.Model
{
    public class IdentityDocumentType : CommonResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
}