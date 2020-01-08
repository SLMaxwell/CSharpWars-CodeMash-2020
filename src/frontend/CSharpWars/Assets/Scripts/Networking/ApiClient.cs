using System.Collections.Generic;
using Assets.Scripts.Model;
using RestSharp;

namespace Assets.Scripts.Networking
{
    public static class ApiClient
    {
        private static readonly string _baseUrl = "http://localhost:5000/api";
        //private static readonly string _baseUrl = "http://csharpwars-api.azurefd.net/api";

        public static Arena GetArena() {
          var client = new RestClient(_baseUrl);
          var request = new RestRequest(resource:"arena", Method.GET);
          var response = client.Execute<Arena>(request);
          return response.Data;
        }

        public static List<Bot> GetBots() {
          var client = new RestClient(_baseUrl);
          var request = new RestRequest(resource:"bots", Method.GET);
          var response = client.Execute<List<Bot>>(request);
          return response.Data;
        }
    }
}