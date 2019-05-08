using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjekt
{
    public class itemStock
    {
        public string Name { get; set; }
        public int PLU { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
        public int Id { get; set; }

        public void Sell(int _amount)
        {
            Amount -= _amount;
        }
    }
}
