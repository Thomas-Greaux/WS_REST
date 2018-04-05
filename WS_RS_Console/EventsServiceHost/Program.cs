using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace EventsServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(WS_RS_VelibLabServices.VelibLabServices));
                host.Open();
                Console.WriteLine("Service hosted at ");
                Console.ReadLine();
                host.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
