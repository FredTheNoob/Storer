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

namespace OOProjekt
{
    public partial class Form1 : Form
    {
        addItemForm refItemForm;
        editItemForm refEditForm;
        // Make a public accessible ListView
        public ListView MainListView;
        public List<itemStock> itemStockList;

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
        }

        #region EksternFormSynlighed
        private void BtnNew_Click(object sender, EventArgs e)
        {
            // Hvis knappen trykkes på skal den indlæste form vises til brugeren
            refItemForm.Show();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            refEditForm.Show();
            
        }

        #endregion EksternFormSynlighed

        // Fjerner valgte ting hvis muligt
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Lav en int kaldet selectCount og gem de valgte ting fra listViewet
            int selectCount = lvBoks.SelectedItems.Count;

            // Hvis brugeren ikke har valgt noget fra listviewet
            if (selectCount == 0)
            {
                // Viser brugeren en MessageBox som informerer personen om at brugeren skal vælge en ting - lav deruover et warning symbol og en ok-knap på messageboksen
                MessageBox.Show("Please select an item from the list above", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (selectCount > 0)
            {
                // Viser brugeren en MessageBox som spørger om personen har lyst til at fjerne de valgte ting fra listviewet og set ikonet af messageboksen til et infoikon
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove " + selectCount + " item(s)?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // Hvis brugeren trykker ja
                if (dialogResult == DialogResult.Yes)
                {
                    // Hvis brugeren kun har valgt en ting i listviewet
                    if (selectCount == 1)
                    {
                        // Fjern 1 valgt ting fra listviewet
                        lvBoks.SelectedItems[0].Remove();
                    }
                    // Hvis brugeren har valgt mere end en ting
                    else if (selectCount > 1)
                    {
                        // Fjern hver ting inde i listviewet
                        foreach (ListViewItem eachItem in lvBoks.SelectedItems)
                        {
                            // Fjern de valgte ting
                            lvBoks.Items.Remove(eachItem);
                        }
                    }
                }
            }
        }
        private void BtnSell_Click(object sender, EventArgs e)
        {
            
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

        // Når der trykkes på en knap mens brugeren er inde i textboksen
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Filter the text
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MainListView.SelectedItems)
            {
                int CurrentAmount = int.Parse(item.SubItems[1].Text);
                int NewAmount = CurrentAmount + (int)nudAddAmount.Value;
                item.SubItems[1].Text = NewAmount.ToString();
                itemStockList[item.Index].Amount = NewAmount;
            }
        }
    }
}
