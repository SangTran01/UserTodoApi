using System.Text.Json.Serialization;

namespace UserTodoApi.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("website")]
        public string Website { get; set; }
    }

    //public class Address
    //{
    //    public string street { get; set; }
    //    public string suite { get; set; }
    //    public string city { get; set; }
    //    public string zipcode { get; set; }
    //    public Geo geo { get; set; }
    //}

    //public class Geo
    //{
    //    public string lat { get; set; }
    //    public string lng { get; set; }
    //}

    //public class Company
    //{
    //    public string name { get; set; }
    //    public string catchPhrase { get; set; }
    //    public string bs { get; set; }
    //}

}
