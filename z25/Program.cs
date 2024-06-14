using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsuranceClient[] insuranceClients = new InsuranceClient[]
            {
                new InsuranceClient("John Doe", "Car", 2500),
                new InsuranceClient("Jane Smith", "Health", 1500),
                new InsuranceClient("Bob Johnson", "Car", 1800),
                new InsuranceClient("Alice Brown", "Home", 3000),
                new InsuranceClient("Tom White", "Car", 2200)
            };
            Console.WriteLine("кто из клиентов страховой компании застраховал автомобиль на сумму, превышающую 2000 руб");
           foreach(var client in insuranceClients)
            {
               if(client.InsuranceType == "Car" && client.InsuranceAmount>2000)
                {
                    Console.WriteLine(client.GetClientInfo());
                }
            }
            int count = 0;
            foreach(var elem in insuranceClients)
            {
                if (elem.InsuranceType == "Car")
                {
                    count++;
                }
            }
            Console.WriteLine($"\nсколько клиентов имеют автомобильную страховку: {count}");
            Console.ReadLine();
        }
    }
}
