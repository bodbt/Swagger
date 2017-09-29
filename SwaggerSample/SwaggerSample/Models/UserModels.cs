using Newtonsoft.Json;

namespace SwaggerSample.Models
{
    public class RegisterUserRequestModel
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("telNo")]
        public string TelNo { get; set; }
    }

    public class RegisterUserResponseModel
    {
        [JsonProperty("result")]
        public ResultMessageModel Result { get; set; }

    }

    public class FindUserResponseModel
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("telNo")]
        public string TelNo { get; set; }
    }
}