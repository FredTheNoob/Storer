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
        public int ID { get; set; }

        public void Setup(string _Name, int _PLU, string _Category, float _Price, int _Amount, int _ID)
        {
            Name = _Name;
            PLU = _PLU;
            Category = _Category;
            Price = _Price;
            Amount = _Amount;
            ID = _ID;
        }
        public void Sell(int _amount)
        {
            Amount -= _amount;
        }
        public void Add(int _amount)
        {
            Amount += _amount;
        }
        public float GetValue()
        {
            return Price * Amount;
        }
    }
}
