using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [DataContract]
    public class Account
    {
        [DataMember]
        private int Id;

        [DataMember]
        private int money=0;

        public Account(int id)
        {
            Id = id;
        }

        public int getMoney()
        {
            return money;
        }

        public void addMoney(int mon)
        {
            money += mon;
        }

        public void deleteMoney(int mon)
        {
            money -= mon;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }
    }
}
