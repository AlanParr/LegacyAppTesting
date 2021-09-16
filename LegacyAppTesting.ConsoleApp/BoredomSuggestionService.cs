using System.Threading.Tasks;

namespace LegacyAppTesting.ConsoleApp
{
    public class BoredomSuggestionService
    {
        private BoredClient _client;

        public BoredomSuggestionService()
        {
            _client = new BoredClient();
        }
        public async Task<BoredResponse> FindSomethingToDo()
        {
            return await _client.FindSomethingToDo();
        }
    }
}