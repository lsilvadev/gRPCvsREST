using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    class RestClient
    {
        public async Task<string> GetMessage ()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));            
            return await client.GetStringAsync("http://localhost:3000/restapi/message/Rest API");
        }
    }
}