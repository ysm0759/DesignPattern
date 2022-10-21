using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Bridge
{
    public class BridgeMain
    {
        public static void Main(string[] args)
        {
            // Create RefinedAbstraction
            var customers = new Customers();
            // Set ConcreteImplementor
            customers.Data = new CustomersData("Korea");
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("PSY");
            customers.ShowAll();
            // Wait for user
            Console.ReadKey();
        }
    }
}
