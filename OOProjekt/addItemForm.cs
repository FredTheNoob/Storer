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
    public partial class addItemForm : Form
    {
        Form1 refForm1;
        public addItemForm(Form1 Form1)
        {
            refForm1 = Form1;
            InitializeComponent();
        }

        // Her skjuler vi alt selvlavet brugerflade i en region
        #region custom Brugerflade

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            // Samme som ovenstående (--||--)
            btnMinimize.BackColor = pictureBox1.BackColor;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            // Når musen køres væk fra exit-knappen skal farven laves tilbage til samme farve som topbaren
            btnExit.BackColor = pictureBox1.BackColor;
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            // Indsæt farverne ved at ændre baggrundsfarven til blå og teksten i knappen til sølv og kanten på knappen til sølv
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.ForeColor = Color.Silver;
            btnAdd.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            // Inverter farverne tilbage til det som det var til at starte med
            btnAdd.BackColor = Color.Silver;
            btnAdd.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnAdd.ForeColor = Color.DodgerBlue;
        }

        #endregion custom Brugerflade

        // BtnAdd indstillinger
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Lav en ny instans af listboks objektet kaldet lvItem og sæt textboksen til denne kolonne
            ListViewItem lvItem = new ListViewItem(txtName.Text);
            // Opret en ny ting i vores itemStock klasse
            itemStock product = new itemStock();
            // Gå videre til subitemet af den givne data fra brugeren indtastet i nudAddItemAmount og insert denne værdi i den kolonne i listview kaldet "Amount"
            lvItem.SubItems.Add(nudAddItemAmount.Value.ToString());
            product.Amount = (int)nudAddItemAmount.Value;
            // Hvis den indtastede kategori IKKE eksisterer så tilføj en ny kategori
            if (!cmbItemCategory.Items.Contains(cmbItemCategory.Text))
            {
                cmbItemCategory.Items.Add(cmbItemCategory.Text);
            }
            // Gå videre til subitemet af den givne data fra brugeren indtastet i cmbItemCatekory og indsæt denne værdi/string i en kolonne i listview kaldet "Category"
            lvItem.SubItems.Add(cmbItemCategory.Text);
            // Det samme som ovenover bare med Price kolonnen
            lvItem.SubItems.Add(nudItemPrice.Value.ToString());
            // Det samme som ovenover (--||--)

            // Hvis værdien i vores numeric up down er 0
            if (nudItemPlu.Value == 0)
            {
                // Tilføj "No PLU" til kolonnen PLU
                lvItem.SubItems.Add("No PLU");
                // Referer til form1 og tilføj tingen til listviewet
                refForm1.MainListView.Items.Add(lvItem);
            }
            else
            {
                // Tilføj tingene ind i listviewet af variablen defineret som lvItem
                lvItem.SubItems.Add(nudItemPlu.Value.ToString());

                // Lav en bool og sæt dens standardværdi til false
                bool alreadyExists = false;

                // For hvert ListViewItem inde i listviewet
                foreach (ListViewItem item in refForm1.MainListView.Items)
                    // Hvis teksten på subitemsene i 4. kolonne (PLU) er det samme som værdien af vores numeric up down
                    if (item.SubItems[4].Text == nudItemPlu.Value.ToString())
                    {
                        alreadyExists = true;
                        break;
                    }

                // Hvis PLU-værdien allerede er blevet indtastet før
                if (alreadyExists)
                    MessageBox.Show("Another product already has this PLU", "Warning: PLU exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    // Hvis ikke, tilføj tingen
                    refForm1.MainListView.Items.Add(lvItem);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Gem formen midlertidigt for brugeren
            this.Hide();
            // Kald på metoden kaldes clearFields for at rydde/fjerne alt indhold i formen
            clearFields();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // Minimer vinduet
            this.WindowState = FormWindowState.Minimized;
        }

        ////////////////
        /// METODER ///
        //////////////

        // Definer en metoder som kan fjerne alt indhold i formen
        private void clearFields()
        {
            txtName.Clear();
            // Sæt alle værdierne tilbage til standard
            nudAddItemAmount.Value = 0;
            cmbItemCategory.Text = "";
            nudItemPrice.Value = 0;
            nudItemPlu.Value = 0;
        }
    }
}
