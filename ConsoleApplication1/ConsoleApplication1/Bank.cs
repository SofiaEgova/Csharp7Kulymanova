using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [DataContract]
    public class Bank
    {
        [DataMember]
        private List<Client> clients = new List<Client>();

        [DataMember]
        private int idClient=0;

        [DataMember]
        private int idAccount=0;

        public void createClient(string name)
        {
            clients.Add(new Client(idClient++, name));
        }

        public void deleteClient(Client client)
        {
            clients.Remove(client);
        }

        public void createAccount(int id)
        {
            var cl = clients.FirstOrDefault(x => x.getId() == id);
            if (cl != null)
            {
                cl.addAccount(new Account(idAccount++));
            }
        }

        public void addMoneyAccount(int accountId,int money)
        {
            Account c=null;
            foreach (var cl in clients)
            {
                c = cl.getAccounts().FirstOrDefault(x => x.getId() == accountId);
                if (c != null) break;
            }
            if (c != null) c.addMoney(money);
        }

        public void changeMoneysAccount(int accountIdFrom, int accountIdTo, int money)
        {
            Account cF = null;
            Account cT = null;
            foreach (var cl in clients)
            {
                cF = cl.getAccounts().FirstOrDefault(x => x.getId() == accountIdFrom);
                cT = cl.getAccounts().FirstOrDefault(x => x.getId() == accountIdTo);
                if (cF != null&& cT != null) break;
            }
            if (cF != null && cT != null)
            {
                cF.deleteMoney(money);
                cT.addMoney(money);
            }
        }

        public void changeMoneysAccountBanks(Bank b,int accountIdFrom, int accountIdTo, int money)
        {
            Account cF = null;
            Account cT = null;
            foreach (var cl in clients)
            {
                cF = cl.getAccounts().FirstOrDefault(x => x.getId() == accountIdFrom);
                if (cF != null) break;
            }
            foreach (var cl in b.clients)
            {
                cT = cl.getAccounts().FirstOrDefault(x => x.getId() == accountIdTo);
                if (cT != null) break;
            }
            if (cF != null && cT != null)
            {
                cF.deleteMoney(money);
                cT.addMoney(money);
            }
        }

        public Client getClient(string s)
        {
            return clients.FirstOrDefault(x => x.getName() == s);
        }
    }
}
