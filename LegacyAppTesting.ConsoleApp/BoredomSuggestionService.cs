using System.Threading.Tasks;

namespace LegacyAppTesting.ConsoleApp
{
    public class BoredomSuggestionService
    {
        private readonly IBoredClient _client;

        public BoredomSuggestionService()
        {
            _client = new BoredClientFactory().GetClient();
        }
        public async Task<BoredResponse> FindSomethingToDo()
        {
            return await _client.FindSomethingToDo();
        }
    }
}