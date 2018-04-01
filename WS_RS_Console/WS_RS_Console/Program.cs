using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WS_RS_VelibLabServices;

namespace WS_RS_Console
{
    class Program
    {
        const string listCities = "listCities";
        const string end = "end";
        const string help = "help";
        const string prompt = "/> ";

        //VelibLabServicesClient client = new VelibLabServicesClient();
        static VelibLabServices client = new VelibLabServices();

        static void Main(string[] args)
        {
            Console.WriteLine("Type help for help");
            String cmd = "";
            while(cmd != end)
            {
                Console.Write(prompt);
                cmd = Console.ReadLine();
                switch(cmd)
                {
                    case listCities: execute_listCities(); break;
                    case help: execute_help(); break;
                    default: Console.WriteLine("Commande non reconnue, 'help' pour avoir la liste des commandes"); break;
                }
            }
        }

        static void execute_listCities()
        {
            List<City> cities = client.GetCities();
            foreach (City city in cities)
            {
                Console.WriteLine(city.Name);
            }
        }

        static void execute_help()
        {
            Console.Write("Liste des commandes:\n" +
                "listCities:\tlists all the cities\n" +
                "help:\t\tprints this help\n" +
                "end:\t\tends this program\n");
        }
    }
}
