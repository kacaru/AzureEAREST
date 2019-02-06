using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using RestSharp;

namespace Azure_EA_Cost
{
        #error Before starting make sure you have your azure enrollment number and api key. Enter these in the below region.
    class Program
    {


        #region User sets these fields.
        //static string dateFilter = DateTime.Today.ToString("yyyy" + "-" + "MM" + "-" + "dd");//Filter format is YYYY-MM-DD
        static string dateFilter = "2018-12-9";//For manual running.
        static string enrollNumber = "xxxxxx";//Azure EA Enrollment Number
        static string apiKey = "xxxxxx";//API Key
   
        #endregion

        static void Main(string[] args)
        {
          
            GetJson("https://consumption.azure.com/v3/enrollments/" + enrollNumber + "/usagedetailsbycustomdate?startTime=" + dateFilter + "&endTime=" + dateFilter);
            //Console.ReadLine();
        }

        static void GetJson(string url)
        {

            var client = new RestClient(url); //Instantiate a new REST Client
            var request = new RestRequest(Method.GET);//REST GET


            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");//Content Type
            request.AddHeader("Authorization", "Bearer " + apiKey); //Auth Header
            IRestResponse response = client.Execute(request); //Execute

            string jsonResponse = response.Content; //Get content of the response.
            //Console.WriteLine(costContent);

            Console.WriteLine("Data Received, Deserializing...");
            ProcessJson(jsonResponse); //Hand the content off to processed/deserialized.
        }

        static void ProcessJson(string jsonReponse)
        {
            //Deserialize
            Response costResponse = JsonConvert.DeserializeObject<Response>(jsonReponse);

            //Most requests will have multiple pages of data.
            string nextPage = costResponse.nextLink;//Get the value of the nextLink field.
            //Console.WriteLine(costResponse.nextLink);//Check value of the nextLink

            //Loop through the data pulling the values that I want.
            foreach (var item in costResponse.data)
            {

                Console.WriteLine(item.cost);
                /*
                if (item.subscriptionGuid == "xxxxxx") //if only concerned with one subscription or you can filter on any of the returned fields.
                {
                    Console.WriteLine(item.cost);
                   
                }
                */

            }

            //Console.WriteLine("Cost spent on this day {0}", totalCost);

            if (nextPage != null)
            {
                Console.WriteLine("There is another page of data.");
                GetJson(nextPage);
            }
            else
            {
                Console.WriteLine("There are no more pages, complete.");
          
                Console.ReadLine();
                
             

            }

        }
    }
}
