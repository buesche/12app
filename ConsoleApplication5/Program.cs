using RestSharp;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApplication5
{
    public class Class1
    {
        //private const string URL = "http://desktop.12app.ch/api/articles/22368360";

        static void Main(string[] args)
        {
            var dict = new Dictionary<DateTime, String>();
            var requestIds = new String[]{ "22368360","22368361", "25490838" };

            foreach(var rId in requestIds)
            {
                var client = new RestClient("http://desktop.12app.ch/api");
                var request = new RestRequest("articles/{id}", Method.GET);
                request.AddUrlSegment("id", rId);
                IRestResponse response = client.Execute(request);
                var art = JsonConvert.DeserializeObject<RootObject>(response.Content);
                if (art.article != null)
                {
                    dict.Add(Convert.ToDateTime(art.article.refresh), String.Format("http://desktop.12app.ch/articles/{0}", rId));
                }
            }

            //IRestResponse<RootObject> response2 = client.Execute<>(request);

            foreach(var eintrag in dict)
            {
                Console.WriteLine("Artikel vom "+eintrag.Key.ToShortDateString() + " mit URL "+eintrag.Value );

            }

            Console.ReadKey();
        }
    }
}
