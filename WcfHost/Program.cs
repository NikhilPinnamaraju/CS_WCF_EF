using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Wcfbooks;
namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcHost = new ServiceHost(typeof(Wcfbooks.Books));
            svcHost.Open();
            Console.WriteLine("service started..");
            Console.ReadLine();
            Console.WriteLine("service stopped");
        }
    }
}
