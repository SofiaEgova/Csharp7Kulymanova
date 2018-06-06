using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [DataContract]
    public class Client
    {
        [DataMember]
        private int Id;

        [DataMember]
        private List<Account> accounts = new List<Account>();

        [DataMember]
        public string name;

        public Client(int id, string n)
        {
            Id = id;
            name = n;
        }

        public void addAccount(Account ac)
        {
            accounts.Add(ac);
        }
        
        public List<Account> getAccounts()
        {
            return accounts;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public Account getAccount(int Id)
        {
            return accounts[Id];
        }

        public string getName()
        {
            return name;
        }
    }
}
