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
        public void AddToListView(ListView _listView)
        {
            #warning missing comments
            // Lav en ny instans af listboks objektet kaldet lvItem og sæt textboksen til denne kolonne
            ListViewItem listViewItemGUI = new ListViewItem(this.Name);
            // Gå videre til subitemet af den givne data fra brugeren indtastet i nudAddItemAmount og insert denne værdi i den kolonne i listview kaldet "Amount"
            listViewItemGUI.SubItems.Add(this.Amount.ToString());
            // Gå videre til subitemet af den givne data fra brugeren indtastet i cmbItemCatekory og indsæt denne værdi/string i en kolonne i listview kaldet "Category"
            listViewItemGUI.SubItems.Add(this.Category);
            // Det samme som ovenover bare med Price kolonnen
            listViewItemGUI.SubItems.Add(this.Price.ToString());
            // Hvis værdien i vores numeric up down er 0
            if (this.PLU != 0)
                listViewItemGUI.SubItems.Add(this.PLU.ToString());
            else
                listViewItemGUI.SubItems.Add("No PLU");

            _listView.Items.Add(listViewItemGUI);

            this.ID = _listView.Items.Count;
        }

        public bool PLUexists(ListView _listView)
        {
            #warning missing comments
            string StringPLU = this.PLU.ToString();
            foreach (ListViewItem item in _listView.Items)
            {
                if (item.SubItems[4].Text == StringPLU)
                    if (item.SubItems[4].Text != "0")
                        return true;
            }
            return false;
        }

    }
}
