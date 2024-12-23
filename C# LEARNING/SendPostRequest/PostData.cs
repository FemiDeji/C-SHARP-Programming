using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace SendPostRequest
{
    public class PostData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}   