using Newtonsoft.Json;

namespace SwaggerSample.Models
{
    public class ResultMessageModel
    {
        [JsonProperty("message")]
        public string Message { get; set; }

    }
}