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
        public List<itemStock> itemStockList = new List<itemStock>();
        public addItemForm(Form1 Form1)
        {
            refForm1 = Form1;
            InitializeComponent();
        }

        // Her skjuler vi alt selvlavet brugerflade i en region
        #region customUI

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
            // Opret en ny ting i vores itemStock klasse
            itemStock product = new itemStock();

            // Få de værdier brugeren skriver gemt i vores product klasse
            product.Name = txtName.Text;

            product.Amount = (int)nudAddItemAmount.Value;

            product.Category = cmbItemCategory.Text;

            product.Price = (float)nudItemPrice.Value;

            product.PLU = (int)nudItemPlu.Value;

            // Referer til vores itemstock klasse og find PLUexists - dette er en bool som enten er sand eller falsk. Tjek herefter om PLU nummeret brugeren har skrevet eksisterer i listViewet i forvejen. Hvis ja
            if (product.PLUexists(refForm1.MainListView))
                // Hvis en MessageBox som informerer brugeren om, at PLU nummeret allerede findes i listViewet. Lav et warning ikon og en ok knap
                MessageBox.Show("Another product with this PLU already exist", "PLU Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Hvis PLU-nummeret ikke er det samme som det der står i listViewet
            else
                // Få product til at tilføje alle brugerens givne værdier i listViewet på form1
                product.AddToListView(refForm1.MainListView);


            // Hvis den indtastede kategori IKKE eksisterer så tilføj en ny kategori
            if (!cmbItemCategory.Items.Contains(cmbItemCategory.Text))
            {
                cmbItemCategory.Items.Add(cmbItemCategory.Text);
            }
            itemStockList.Add(product);

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Gem formen midlertidigt for brugeren
            this.Hide();
            // Kald på metoden kaldet clearFields for at rydde/fjerne alt indhold i formen
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
