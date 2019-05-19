using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.IO;

namespace OOProjekt
{
    public partial class Form1 : Form
    {
        addItemForm refItemForm;
        editItemForm refEditForm;
        // Lav et offentligt tilgængeligt listView
        public ListView MainListView;
        public List<itemStock> itemStockList;
        // Lav en string kaldet saveFilePath som finder stien af filen og tilføj et filnavn og typen json
        string saveFilePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\save.json";
        // Lav et DataTable til at gemme de værdier der er i listViewet til senere brug i søge funktionen
        private DataTable dt;
        private DataView dv;


        public Form1()
        {
            InitializeComponent();
        }


        #region customUI

        // Kald på et windows native så man kan flytte rundt på vinduet vha. topbaren
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Hvis knappen exit er trykket på skal programmet lukkes
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // Minimer vinduet når der trykkes på knappen
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            // Når musen kører over knappen skal farven ændres til rød
            btnExit.BackColor = Color.Red;
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            // Når musen køres over knappen ændres farven til DimGray
            btnMinimize.BackColor = Color.DimGray;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Dette gør at vinduet kan flyttes rundt
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            // Når musen køres væk fra exit-knappen skal farven laves tilbage til samme farve som topbaren
            btnExit.BackColor = pictureBox1.BackColor;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            // Samme som ovenstående bare for minimer knappen
            btnMinimize.BackColor = pictureBox1.BackColor;
        }

        private void BtnNew_MouseEnter(object sender, EventArgs e)
        {
            // Indsæt farverne ved at ændre baggrundsfarven til blå og teksten i knappen til sølv og kanten på knappen til sølv
            btnNew.BackColor = Color.DodgerBlue;
            btnNew.ForeColor = Color.Silver;
            btnNew.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnNew_MouseLeave(object sender, EventArgs e)
        {
            // Inverter farverne tilbage til det som det var til at starte med
            btnNew.BackColor = Color.Silver;
            btnNew.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnNew.ForeColor = Color.DodgerBlue;
        }

        private void BtnSell_MouseEnter(object sender, EventArgs e)
        {
            // Det samme som ved BtnNew_MouseEnter eventet
            btnSell.BackColor = Color.DodgerBlue;
            btnSell.ForeColor = Color.Silver;
            btnSell.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnSell_MouseLeave(object sender, EventArgs e)
        {
            btnSell.BackColor = Color.Silver;
            btnSell.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSell.ForeColor = Color.DodgerBlue;
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.ForeColor = Color.Silver;
            btnAdd.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Silver;
            btnAdd.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnAdd.ForeColor = Color.DodgerBlue;
        }

        private void BtnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.ForeColor = Color.Silver;
            btnEdit.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Silver;
            btnEdit.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnEdit.ForeColor = Color.DodgerBlue;
        }

        private void BtnRemove_MouseEnter(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.DodgerBlue;
            btnRemove.ForeColor = Color.Silver;
            btnRemove.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.Silver;
            btnRemove.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRemove.ForeColor = Color.DodgerBlue;
        }

        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.ForeColor = Color.Silver;
            btnSave.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Silver;
            btnSave.ForeColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderColor = Color.DodgerBlue;
        }

        #endregion custom Brugerflade

        // Når formen indlæser er det første der skal gøres være:
        private void Form1_Load(object sender, EventArgs e)
        {
            // Opret form2 og form3
            refItemForm = new addItemForm(this);
            refEditForm = new editItemForm(this);
            // Definer hvilken variabel listViewet skal gemmes i (lvBoks)
            MainListView = lvBoks;
            // Definer klassen itemStock.cs
            itemStockList = new List<itemStock>();
            // Kald på de definerede metoder
            loadUserData();

            reloadListView();

            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Category");
            dt.Columns.Add("Price");
            dt.Columns.Add("PLU");

            // Vi vil gerne filtrere listView så brugeren kan se hvad han søger efter

            fillTheDataTable(itemStockList);
            dv = new DataView(dt);

            fillTheListview(dv);
        }

        #region EksternFormSynlighed

        // Når man på knappen viser den "ItemForm" for brugeren
        private void BtnNew_Click(object sender, EventArgs e)
        {
            refItemForm.Show();
        }

        // Når man på knappen viser den "EditForm" for brugeren
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            refEditForm.Show();
        }

        #endregion EksternFormSynlighed

        // Fjerner valgte ting hvis muligt
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Lav en int kaldet selectCount og gem de valgte ting fra listViewet
            int selectCount = MainListView.SelectedItems.Count;

            // Hvis brugeren ikke har valgt noget fra listviewet
            if (selectCount == 0)
            {
                // Viser brugeren en MessageBox som informerer personen om at brugeren skal vælge en ting - lav deruover et warning symbol og en ok-knap på messageboksen
                MessageBox.Show("Please select an item from the list above", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (selectCount > 0)
            {
                // Viser brugeren en MessageBox som spørger om personen har lyst til at fjerne de valgte ting fra listviewet og sæt ikonet af messageboksen til et infoikon
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove " + selectCount + " item(s)?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // Hvis brugeren trykker ja
                if (dialogResult == DialogResult.Yes)
                {
                    // Fjern hver ting inde i listviewet
                    foreach (ListViewItem eachItem in lvBoks.SelectedItems)
                    {
                        // Fjern de valgte ting
                        //MainListView.Items.Remove(eachItem);
                        itemStockList.Remove(itemStockList[eachItem.Index]);
                    }

                    reloadListView();
                }
            }
        }


        private void LvBoks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hvis 1 ting er valgt
            if (lvBoks.SelectedItems.Count == 1)
            {
                // Så lav edit-knappen funktionel for brugeren
                btnEdit.Enabled = true;
                btnEdit.BackColor = Color.Silver;
                btnEdit.FlatAppearance.BorderColor = Color.DodgerBlue;
                btnEdit.ForeColor = Color.DodgerBlue;
            }
            else
            {
                // Sikrer at brugeren ikke kan vælge flere ting på en gang, ved at gøre den ufunktionel
                btnEdit.Enabled = false;
                btnEdit.FlatAppearance.BorderColor = Color.DimGray;
            }
        }

        // Når teksten i tekstboksen ændres
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%[0]%'", txtSearch.Text);

            fillTheListview(dv);
        }

        #region Add og Sell Knapper
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MainListView.SelectedItems)
            {
                int NewAmount = itemStockList[item.Index].Amount + (int)nudAddAmount.Value;
                itemStockList[item.Index].Amount = NewAmount;
            }

            reloadListView();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MainListView.SelectedItems)
            {
                int NewAmount = itemStockList[item.Index].Amount - (int)nudAddAmount.Value;
                itemStockList[item.Index].Amount = NewAmount;
            }

            reloadListView();
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Kald på metoden saveUserData her
            saveUserData();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveUserData();
        }

        ////////////////
        /// METODER ///
        //////////////

        public void saveUserData()
        {
            // Her omformer vi listViewet til en json kompatibel string af vores itemStockList som defineret i klassen
            string json = JsonConvert.SerializeObject(itemStockList, Formatting.Indented);

            // Hvis filen eksisterer
            if (File.Exists(saveFilePath))
                // Slet filen
                File.Delete(saveFilePath);
            

            // Ved at bruge system.IO lav en variabel kaldet saveWriter og sæt dens værdi til stringen filePath
            StreamWriter saveWriter = new StreamWriter(saveFilePath);

            // Her skrives der hvad filen skal indeholde
            saveWriter.Write(json);

            // Luk filadgangen så andre programmer kan bruge filen
            saveWriter.Close();
        }

        public void loadUserData()
        {
            // Forsøg at gøre følgende:
            try
            {
                // Lav en streamReader som indlæser den gemte fil (save.json) 
                System.IO.StreamReader fileReader = new System.IO.StreamReader(saveFilePath);

                // Sikrer at filen bliver læst til slut og gem dette til stringen json
                string json = fileReader.ReadToEnd();

                // Brug json metoder til at indlæse den gemte fil til vores liste
                itemStockList = JsonConvert.DeserializeObject<List<itemStock>>(json);

                fileReader.Close();
            }
            // Hvis der opstår en fejl
            catch (Exception)
            {
                // Informér brugeren om, at der skete en fejl ved indlæsningen af filen
                MessageBox.Show("Error loading saved data: Either you do not have any saved data or it is corrupt", "Error loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reloadListView()
        {
            // Fjern alle varerne inde i listViewet
            MainListView.Items.Clear();

            // For hvert itemStock i vores itemStockList
            foreach (itemStock item in itemStockList)
            {
                // Tilføj 
                item.AddToListView(MainListView);
            }
        }
        
        // Overfør data fra listView til DataTable
        private void fillTheDataTable(List<itemStock> itemStockList)
        {
            foreach (itemStock item in itemStockList)
            {
                dt.Rows.Add(item.Name, item.Amount, item.Category, item.Price, item.PLU);
            }
        }

        // Fyld listViewet op igen fra DataViewet
        private void fillTheListview(DataView dv)
        {
            // Start med at fjerne alle items fra listViewet så der kun vises det der søges efter
            MainListView.Items.Clear();

            foreach (DataRow row in dv.ToTable().Rows)
            {
                MainListView.Items.Add(new ListViewItem(new string[] { row[0].ToString(), row[1].ToString(), (string)row[2], row[3].ToString(), row[4].ToString() }));
            }
        }
    }
}
