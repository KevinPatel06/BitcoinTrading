using RestSharp;
using System;

namespace BitcoinTrading
{
    class Program
    {
        static void Main(string[] args)
        {
            string api = "https://blockchain.info/ticker";
            getBitcoinData();
        }

        public static void getBitcoinData()
        {
            var client = new RestClient("https://blockchain.info/ticker");
            var request = new RestRequest("");
            var response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawReceived = response.Content; 
            }
            
        }
    }
}
