namespace LegacyAppTesting.ConsoleApp.Tests.Unit
{
    public class TestBoredClientFactory: BoredClientFactory
    {
        public void SetClient(IBoredClient boredClient)
        {
            SetClientInternalForTestingOnly(boredClient);
        }
    }
}