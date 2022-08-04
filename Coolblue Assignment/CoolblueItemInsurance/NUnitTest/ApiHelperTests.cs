using CoolblueItemInsurance;
using System.Net.Http;
using NUnit.Framework;

namespace CoolblueItemInsurance.API
{
    [TestFixture]
    public class ApiHelperTests
    {
       
        public static HttpClient ApiClient { get; set; }
        static HttpClient httpClient = new HttpClient();
        [Test]
        public static void InitializeClient()
        {

            ApiClient = new HttpClient();
        }
       
    }
}
