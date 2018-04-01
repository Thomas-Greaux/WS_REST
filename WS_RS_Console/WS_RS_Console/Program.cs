using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_RS_Console
{
    class Program
    {
        const string end = "end";
        const string help = "help";
        const string prompt = "/> ";
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
                    case help: execute_help(); break;
                    default: Console.WriteLine("Commande non reconnue, 'help' pour avoir la liste des commandes"); break;
                }
            }
        }

        static void execute_help()
        {
            Console.Write("Liste des commandes:\nhelp: prints this help\nend: ends this program\n");
        }
    }
}
