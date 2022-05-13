using ServiceReference1;
using System;
using System.Threading.Tasks;

namespace IS_lab5_SOAPCS
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("My First SOAP Client!");
            MyFirstSOAPInterfaceClient client = new
            MyFirstSOAPInterfaceClient();
            string text = await
            client.getHelloWorldAsStringAsync("Karol");
            Console.WriteLine(text);
            long text1 = await client.getDaysBetweenDatesAsync("20 12 2022","22 12 2022");
            Console.WriteLine(text1);
        }
    }

}
