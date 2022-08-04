using Newtonsoft.Json;

namespace CoolblueItemInsurance
{
    /// <summary>
    ///  Get and set the information of the items using their name as presented in the Json data base of the Products Type.
    /// </summary>
    public class TypeModel
    {
        /// <summary>
        /// JsonProperty is used to seak out the right name while the variable is set with highercase or different name.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("canBeInsured")]
        public bool CanBeInsured { get; set; }
    }
}
