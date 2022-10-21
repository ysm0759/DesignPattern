using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Design_Pattern.Bridge.Interface;

namespace Design_Pattern.Bridge
{
    public class CustomersData : DataObject
    {

        readonly List<string> customers = new List<string>();
        int current = 0;
        string city;


        public CustomersData(string city)
        {
            this.city = city;
            customers.Add("Sungmin");
            customers.Add("Jisu");
            customers.Add("Hyegyo");
            customers.Add("Mina");
            customers.Add("Joy");

        }


        public override void AddRecord(string customer)
        {
            customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            customers.Remove(customer);
        }

        public override string GetCurrentRecord()
        {
            return customers[current];
        }

        public override void NextRecord()
        {
            if(current <= customers.Count -1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void ShowAllRecords()
        {
            Console.WriteLine("Customer City: " + city);
            foreach (string customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }

        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }
    }
}
