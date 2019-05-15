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
        // Define that these variables are part of subitems in the listView
        ListViewItem.ListViewSubItem SelectedName;
        ListViewItem.ListViewSubItem SelectedAmount;
        ListViewItem.ListViewSubItem SelectedCategory;
        ListViewItem.ListViewSubItem SelectedPrice;
        ListViewItem.ListViewSubItem SelectedPLU;



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
            
            SelectedName.Text = txtName.Text;
            SelectedAmount.Text = nudAddItemAmount.Value.ToString();
            SelectedCategory.Text = cmbItemCategory.Text;
            SelectedPrice.Text = nudItemPrice.Value.ToString();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // Minimer vinduet
            this.WindowState = FormWindowState.Minimized;
        }

        ////////////////
        /// METODER ///
        //////////////

        // Definer en metoden som fjerne alt indhold i formen
        private void clear()
        {
            txtName.Clear();
            nudAddItemAmount.ResetText();
            cmbItemCategory.ResetText();
            nudItemPrice.ResetText();
            nudItemPlu.ResetText();
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            #region Defining Listview subitems
            // Take the selected subitem in the 1st coloumn (name) and put it into a variable called SelectedName
            SelectedName = refMainForm.MainListView.SelectedItems[0].SubItems[0];
            // Same as above (--||--)
            SelectedAmount = refMainForm.MainListView.SelectedItems[0].SubItems[1];
            // C# starts counting from 0, therefore this coloumn will be coloumn number 3 (category)
            SelectedCategory = refMainForm.MainListView.SelectedItems[0].SubItems[2];
            SelectedPrice = refMainForm.MainListView.SelectedItems[0].SubItems[3];
            SelectedPLU = refMainForm.MainListView.SelectedItems[0].SubItems[4];
            #endregion Defining Listview subitems

            // Get the contents from the selected added subitem and insert its text value into the forms textbox called txtName
            txtName.Text = SelectedName.Text;
            // Get the numeric up downs value and parse its value into a text property for the SelectedAmount to use
            nudAddItemAmount.Value = int.Parse(SelectedAmount.Text);
            cmbItemCategory.Text = SelectedCategory.Text;
            nudItemPrice.Value = int.Parse(SelectedPrice.Text);

            // If the PLU text does not say "No PLU"
            if (SelectedPLU.Text != "No PLU")
            {
                // Save the value from the numeric up down into the text property for the SelectedPLU to use
                nudItemPlu.Value = int.Parse(SelectedPLU.Text);
            }   
        }

    }
}
