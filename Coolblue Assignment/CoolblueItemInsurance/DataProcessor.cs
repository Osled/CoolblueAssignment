using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;


namespace CoolblueItemInsurance
{
    
   public  class DataProcessor
    {

        /// <summary>
        /// using the following URL for each data and apply the search ID to the function. 
        /// url Products = https://www.npoint.io/docs/eed1401b570f01972c9b
        /// The funtion converts the Json to a string to be able to read it.
        /// Both following funtions use the same method.
        /// </summary>
        /// <param name="id"> Is the given int of id that is set by the user and applied to the funtion to specify which data needs to be collected. </param>
        /// <returns></returns>

       // [TestCase("5")]
    
        public static async Task<ItemModel> LoadData(int id)
        {

            /// <summary>
            ///  Define a new variable that hosts the URL.
            ///  Run the HttpClient funtion to collect the data of the hosted link.
            /// </summary>
            string urlProducts = "https://api.npoint.io/eed1401b570f01972c9b";
            HttpClient api = new HttpClient();

            try
            {

                var apiProducts = await api.GetAsync(urlProducts);
                string responseProducts = await apiProducts.Content.ReadAsStringAsync();
                List<ItemModel> results = JsonConvert.DeserializeObject<List<ItemModel>>(responseProducts);
                var Value = new ItemModel();

                //  Try searching for the api, if the API is collected correctly from the Http then apply a Jsoncoverter and collect the data as a list.
                //  the for loop applies the id parameter to collect the corsponding data then store it and return it.

                for (var i = 0; i < results.Count; i++)
                {
                    if (results[i].Id.Equals(id) )
                    {
                            Value = results[i];
                    }
                }
                return Value;

            }

            //  if the data fails to be collected Catch will use throw method and send a Debug reason of why it failed.

            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

            //  Finally will dispose of the Api collected.

            finally
            {
                api.Dispose();
            }

        }

        /// <summary>
        /// using the following URL for each data and apply the search ID to the function. 
        /// url ProductTypes =  https://www.npoint.io/docs/9217f1e291b1bc24edb6
        /// The funtion converts the Json to a string to be able to read it.
        /// Both following funtions use the same method.
        /// </summary>
        /// <param name="typeId"> Is the given int of typeId that is set by the user and applied to the funtion to specify which data needs to be collected.</param>
        /// <returns></returns>
        
        public static async Task<TypeModel> LoadDataType(int typeId)
        {

         
            string urlProductType = "https://api.npoint.io/9217f1e291b1bc24edb6";

            HttpClient api = new HttpClient();

            try
            {
                var apiProductsType = await api.GetAsync(urlProductType);
                string responseProductsType = await apiProductsType.Content.ReadAsStringAsync();
                List<TypeModel> resultsType = JsonConvert.DeserializeObject<List<TypeModel>>(responseProductsType);

                var Value = new TypeModel();
                for (var i = 0; i < resultsType.Count; i++)
                {
                    if (resultsType[i].Id.Equals(typeId))
                    {
                        Value = resultsType[i];
                    }
                }
                return Value;

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                
                throw;
            }
            finally
            {
                api.Dispose();
            }
            
        }
         
    }
}
