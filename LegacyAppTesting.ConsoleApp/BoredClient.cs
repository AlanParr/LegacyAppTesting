using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LegacyAppTesting.ConsoleApp
{
    public class BoredClient
    {
        public async Task<BoredResponse> FindSomethingToDo()
        {
            //Get activity.
            var client = new HttpClient();
            var result = await client.GetAsync("http://www.boredapi.com/api/activity/");
            var bodyString = await result.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BoredResponse>(bodyString);
        }
    }
}