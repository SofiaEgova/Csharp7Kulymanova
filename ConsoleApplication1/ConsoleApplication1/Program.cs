using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bank> banks = new List<Bank>();
            banks.Add(new Bank());
            banks[0].createClient("Vasya");
            banks[0].createAccount(0);
            banks[0].createAccount(0);
            banks[0].addMoneyAccount(0, 200);
            banks[0].changeMoneysAccount(0, 1, 50);

            banks.Add(new Bank());
            banks[1].createClient("Petya");
            banks[1].createAccount(0);
            banks[1].addMoneyAccount(0, 1000);

            banks[0].changeMoneysAccountBanks(banks[1], 0, 0, 50);

            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Bank>));
            using (FileStream fs = new FileStream("banks.json", FileMode.Create))
            {
                formatter.WriteObject(fs, banks);
                Console.WriteLine("Объект сериализован");
            }
        }
    }
}
