using System.Threading.Tasks;

namespace LegacyAppTesting.ConsoleApp
{
    public interface IBoredClient
    {
        Task<BoredResponse> FindSomethingToDo();
    }
}