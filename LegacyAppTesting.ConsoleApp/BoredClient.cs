using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LegacyAppTesting.ConsoleApp
{
    public class BoredClient
    {
        public async Task FindSomethingToDo()
        {
            //Get activity.
            var client = new HttpClient();
            var result = await client.GetAsync("http://www.boredapi.com/api/activity/");
            var body = await result.Content.ReadAsStringAsync();
            //Create result and return.
        }
    }
}