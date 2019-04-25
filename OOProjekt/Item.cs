using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjekt
{
    class Item
    {
        string Name { get; set; }
        int PLU { get; set; }
        string Category { get; set; }
        float Pice { get; set; }
        int Amount { get; set; }

        private void Sell(int _amount)
        {
            Amount -= _amount;
        }
    }
}
