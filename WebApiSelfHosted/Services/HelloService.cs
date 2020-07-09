using System;

namespace WebApiSelfHosted.Services
{
    public class HelloService : IHelloService
    {
        public string GetMessage()
        {
            return "Hello from Self-Hosted WebApi !!!";
        }
    }
}
