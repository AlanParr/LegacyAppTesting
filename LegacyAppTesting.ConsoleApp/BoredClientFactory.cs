namespace LegacyAppTesting.ConsoleApp
{
    public class BoredClientFactory
    {
        //Static override instance.
        private static IBoredClient _overriddenClient;

        //Protected so only available to classes that inherit from this one.
        protected void SetClientInternalForTestingOnly(IBoredClient boredClient)
        {
            _overriddenClient = boredClient;
        }
        public IBoredClient GetClient()
        {
            //Return either our overridden instance or instantiate a new one as we were before.
            return _overriddenClient ?? new BoredClient();
        }
    }
}