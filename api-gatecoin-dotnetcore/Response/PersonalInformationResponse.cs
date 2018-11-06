using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class PersonalInformationResponse : CommonResponse
    {
        public PersonalInformation personalInfo { get; set; }
    }
}