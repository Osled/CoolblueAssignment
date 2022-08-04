using System.Net.Http;

namespace CoolblueItemInsurance
{
   
   public static class ApiHelper
    {
        /// <summary>
        /// Collecting the APi Using HttpClient to apply API search method
        /// </summary>
        public static HttpClient ApiClient { get; set; }
        static HttpClient httpClient = new HttpClient();
        
        public static void InitializeClient()
        {

            ApiClient = new HttpClient();
        }

    }
}
