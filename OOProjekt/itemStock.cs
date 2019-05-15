using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // Lav en metode med midlertidige navne, når kaldt
        public void Setup(string _Name, int _PLU, string _Category, float _Price, int _Amount, int _ID)
        {
            // Sæt ovenstående variabler til de midlertidige
            Name = _Name;
            PLU = _PLU;
            Category = _Category;
            Price = _Price;
            Amount = _Amount;
            ID = _ID;
        }
        public void Sell(int _amount)
        {
            // Når metoden kaldes: Tag kolonnen amount of fjern 1
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
        public void AddToListView(ListView _listView)
        {
            // Brug navnet på produktet i første kolonne (name) herunder laves alle kolonnerne til vores listViewitems undtagen PLU!
            ListViewItem listViewItemGUI = new ListViewItem(this.Name);

            listViewItemGUI.SubItems.Add(this.Amount.ToString());

            listViewItemGUI.SubItems.Add(this.Category);

            listViewItemGUI.SubItems.Add(this.Price.ToString());
            
            // Hvis PLU ikke er 0
            if (this.PLU != 0)
                // Skriv da PLUen ind som normalt
                listViewItemGUI.SubItems.Add(this.PLU.ToString());
            else
                // Udskift 0 med "No PLU"
                listViewItemGUI.SubItems.Add("No PLU");
            
            // Tilføj de indtastede værdier i listViewet
            _listView.Items.Add(listViewItemGUI);

            // Lav noget backend som sætter mængden af varer til ID variablen
            this.ID = _listView.Items.Count;
        }

        public bool PLUexists(ListView _listView)
        {
            // Lav en string kaldet StringPLU og sæt dens værdi til PLU
            string StringPLU = this.PLU.ToString();
            // Lav en foreach løkke som tjekker for hver item i listviewet
            foreach (ListViewItem item in _listView.Items)
            {
                // Hvis kolonne 4 (PLU)s tekst er det samme som stringen StringPLU
                if (item.SubItems[4].Text == StringPLU)
                    // Hvis teksten ikke er det samme som 0
                    if (item.SubItems[4].Text != "0")
                        // Send "sand" tilbage til kalder
                        return true;
            }
            // send "falsk" tilbage til kalder
            return false;
        }

    }
}
