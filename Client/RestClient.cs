using System;
using System.Net.Http;

namespace Client
{
    class RestClient
    {
        public static void GetMessageFor()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string message = "";

            for(int i=0; i<500; i++)
            {
                message = GetMessage();
            }
            
            watch.Stop();
            var milliseconds = watch.ElapsedMilliseconds;

            Console.WriteLine(message + " | " + milliseconds + " ms" );
        }

        private static string GetMessage ()
        {
            string result = "";

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage {
                                    RequestUri = new Uri("http://localhost:3000/restapi/message/Rest API"),
                                    Method = HttpMethod.Get
                                };
                
                var task = client.SendAsync(request)
                .ContinueWith((taskwithmsg) =>
                {
                    var response = taskwithmsg.Result;
                    result = response.Content.ReadAsStringAsync().Result;
                });

                task.Wait();
            }

            return result;
        }
    }
}