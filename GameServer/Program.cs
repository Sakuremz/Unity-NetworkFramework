using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Server";

            GameServer.Sever.Start(50 , 26950);

            Console.ReadKey();
        }
    }
}
