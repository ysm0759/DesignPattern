using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Singleton
{
    /// <summary>
    /// sealed Keyword
    /// 오버라이딩 할 수 없게 막는 키워드
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();


        private readonly List<Server> servers;
        private readonly Random random = new Random();

   
        private Singleton()
        {
            servers = new List<Server>
            {
                new Server{name = "Server1" , IP = "111.111.111.111"},
                new Server{name = "Server2" , IP = "222.222.222.222"},
                new Server{name = "Server3" , IP = "333.333.333.333"},
                new Server{name = "Server4" , IP = "444.444.444.444"}
            };
        }
        public static Singleton GetInstance()
        {
            return instance;
        }

        public Server NextServer
        {
            get
            {
               
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }


    }

    public class Server
    {
        public String name { get; set; }
        public String IP { get; set; }
    }
}
