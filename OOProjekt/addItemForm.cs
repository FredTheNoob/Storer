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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Make a method to clear the content within the form
        private void clear()
        {
            txtAddBoks.Clear();
            nudAddItemAmount.ResetText();
            cmbAddItemCategory.ResetText();
            nudAddItemPrice.ResetText();
            nudAddItemPlu.ResetText();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Hide the form temporarily
            this.Hide();
            // Call the method called clear to clear/reset all the content/text from the form
            clear();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // Minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            // Change the background color of the label to red
            btnExit.BackColor = Color.Red;
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.DimGray;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Make the form able to be moved around
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = pictureBox1.BackColor;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = pictureBox1.BackColor;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Create a new instance of the listbox object called lvItem and insert the first item into column 0 called "apple" (the name column)
            ListViewItem lvItem = new ListViewItem("Apple");
            // Move onto the subitem of apple and find column 1 (tabindex 1) and then insert the value 4 into this column (the amount column)
            lvItem.SubItems.Add("4");
            // Move onto the subitem of apple and find column 2 (tabindex 2) and then insert the string: fruits into this column (the category column)
            lvItem.SubItems.Add("Fruits");
            // Move onto the subitem of apple and find column 3 (tabindex 3) and then insert the string: $0.50 into this column (the price column)
            lvItem.SubItems.Add("$0.50");
            // Move onto the subitem of apple and find column 4 (tabindex 4) and then insert the string: 137 into this column (the PLU column)
            lvItem.SubItems.Add("137");
            // Add the items into the listview of the variable lvItem
            refForm1.MainListView.Items.Add(lvItem);
        }

    }
}
