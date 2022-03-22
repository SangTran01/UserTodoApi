using Newtonsoft.Json;

namespace UserTodoApi.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        //public Address address { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }
        //public Company company { get; set; }
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
