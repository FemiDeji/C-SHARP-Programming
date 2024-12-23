using System;
using System.Data;
using System.IO;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace DemoConsole
{
    internal class Program 
    {
        static void Main(string[] args)
         {
            using(var client = new RestClient("https://jsonplaceholder.typicode.com/posts"))
            {
                var payload = new JObject();
                payload.Add("title", "some cool post title");
                payload.Add("body", "some cool body content");
                var request = new RestRequest();
                request.AddStringBody(payload.ToString(), DataFormat.Json);

                var result = client.PostAsync(request).Result;
            }
            
        }
    }
}
