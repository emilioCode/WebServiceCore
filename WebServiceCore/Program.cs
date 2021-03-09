using System;
using ServiceReference1;

namespace WebServiceCore
{
    class Program
    {
        static void Main(string[] args)
        {
            consumeWebServiceHello("Miguel & Michael");
        }

        private static void consumeWebServiceHello(string name)
        {
            HelloEndpointClient client = new HelloEndpointClient();
            helloRequest request = new helloRequest { Name = name };
            SayHelloBody body = new SayHelloBody(request);
            SayHello sayHello = new SayHello { Body = body };
            SayHelloResponse response = client.SayHello(sayHello);

            Console.WriteLine(response.Body.HelloResponse.Message);
        }
    }
}
