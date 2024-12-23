using System;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendPostRequest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var postData = new PostData
            {
                Name = "John Doe",
                Age = 30,
                Address = "46 Odunfa St"
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            
            var json = JsonConvert.SerializeObject(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("posts", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var postResponse = JsonConvert.DeserializeObject<PostResponse>(responseContent);
                Console.WriteLine("Id: " + postResponse.Id);

                //Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }
    }

    // public class PostData
    // {
    //     public string Name { get; set; }
    //     public int Age { get; set; }
    //     public string Address { get; set; }
    // }

    // public class PostResponse
    // {
    //     public int Id { get; set; }
    // }
j}