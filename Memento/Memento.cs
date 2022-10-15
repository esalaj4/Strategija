using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6_4
{
    class Memento
    {
        public Memento(string ownerName, string ownerAdress, decimal balance)
        {
            OwnerName = ownerName;
            OwnerAdress = ownerAdress;
            Balance = balance;
        }

        public string OwnerName { get;private set; }
        public string OwnerAdress { get;private set; }
        public decimal Balance { get;private set; }
    }
}
