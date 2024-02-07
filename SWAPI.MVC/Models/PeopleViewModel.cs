using System.Text.Json.Serialization;

namespace SWAPI.MVC.Models
{
    public class PeopleViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("height")]
        public string Height { get; set; } = string.Empty;

        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; } = string.Empty;

        [JsonPropertyName("mass")]
        public string Mass { get; set; } = string.Empty;

        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        
        public string Id
        {
            get 
            {
                //https://swapi.dev/api/people/1/
                //["https:","swappi.dev.api","people","1"]
                return Url
                        .Split("/", StringSplitOptions.RemoveEmptyEntries)
                        .LastOrDefault()!;
            }
        }
    }
}
