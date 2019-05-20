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
    public partial class editItemForm : Form
    {
        Form1 refMainForm;
        itemStock selectedItem;

        public editItemForm(Form1 Form1)
        {
            refMainForm = Form1;
            InitializeComponent();
        }

        #region custom Brugerflade

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

  
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            // Ændrer baggrundsfarven på labellen til rød
            btnExit.BackColor = Color.Red;
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.DimGray;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Gør at formen kan flyttes rundt ved brug af natives
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = pictureBox1.BackColor;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            // Når brugeren bevæger musen væk fra knappen ændres farven tilbage til farven på topbaren
            btnExit.BackColor = pictureBox1.BackColor;
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
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Hide the form temporarily
            this.Hide();
        }

        #endregion custom Brugerflade

        // BtnAdd indstillinger
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Sæt tekstboksene i formen til det samme som værdierne på varen
            selectedItem.Name = txtName.Text;
            selectedItem.Amount = (int)nudAddItemAmount.Value;
            selectedItem.Category = cmbItemCategory.Text;
            selectedItem.Price = (int)nudItemPrice.Value;
            selectedItem.PLU = (int)nudItemPlu.Value;

            // Der hvor C# står lige nu skal den gemme formen for brugeren
            this.Hide();
            // Genindlæs listViewet vha. vores metode reloadListView
            refMainForm.reloadListView(refMainForm.itemStockList);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // Minimer vinduet
            this.WindowState = FormWindowState.Minimized;
        }


        ////////////////
        /// METODER ///
        //////////////

        // Definer en metoden som fjerne alt indhold i formen (editItemForm)
        private void clear()
        {
            txtName.Clear();
            nudAddItemAmount.ResetText();
            cmbItemCategory.ResetText();
            nudItemPrice.ResetText();
            nudItemPlu.ResetText();
        }

        public void setupEdit()
        {
            // Sæt mængden af valgte varer (1) til variablen selectedItem
            selectedItem = refMainForm.itemStockList[refMainForm.MainListView.SelectedItems[0].Index];

            // Indsæt værdierne i formen fra klassen itemstock
            txtName.Text = selectedItem.Name;
            nudAddItemAmount.Value = selectedItem.Amount;
            cmbItemCategory.Text = selectedItem.Category;
            nudItemPrice.Value = (decimal)selectedItem.Price;
            nudItemPlu.Value = selectedItem.PLU;
        }
    }
}
