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

        // Here we are hiding all the custom UI code (this code just changes colors)
        #region CustomUI

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
            // Make the form able to be moved around by using natives
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = pictureBox1.BackColor;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            // When the user moves the mouse from the exit button again the color will be changed to the same as the picturebox color
            btnExit.BackColor = pictureBox1.BackColor;
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

        #endregion CustomUI

        // BtnAdd settings!
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Create a new instance of the listbox object called lvItem and insert the first item into column 0 called "apple" (the name column)
            ListViewItem lvItem = new ListViewItem(txtName.Text);
            // Creating a new item in our itemStock class
            itemStock product = new itemStock();
            product.Name = txtName.Text;
            // Move onto the subitem of the given data from the user given in the nudAddItemAmount and insert the value into the column of the listView (the amount column)
            lvItem.SubItems.Add(nudAddItemAmount.Value.ToString());
            product.Amount = (int)nudAddItemAmount.Value;
            // If the category typed does NOT exist the a new category gets added
            if (!cmbItemCategory.Items.Contains(cmbItemCategory.Text))
            {
                cmbItemCategory.Items.Add(cmbItemCategory.Text);
            }
            // Move onto the subitem of the given data from the user given in the cmbItemCategory and insert the value/string into the column of the listView (the Category column)
            lvItem.SubItems.Add(cmbItemCategory.Text);
            product.Category = cmbItemCategory.Text;
            // Move onto the subitem of the given data from the user given in the nudItemPrice and insert the value into the column of the listView (the Price column)
            lvItem.SubItems.Add(nudItemPrice.Value.ToString());
            product.Price = (float)nudItemPrice.Value;
            // Same as above (--||--)

            // If the value in the numeric up down is 0
            if (nudItemPlu.Value == 0)
            {
                // Add "No PLU" to the coloumn PLU
                lvItem.SubItems.Add("No PLU");
                // Refer to form1 and add the item into the listView
                refForm1.MainListView.Items.Add(lvItem);
                product.ID = refForm1.MainListView.Items.Count;
                refForm1.itemStockList.Add(product);
            }
            else
            {
                // Add the items into the listview of the variable lvItem
                lvItem.SubItems.Add(nudItemPlu.Value.ToString());

                bool alreadyExists = false;

                // For each ListViewItem inside of the listView
                foreach (ListViewItem item in refForm1.MainListView.Items)
                    // if the subitems text in the fourth coloumn (PLU) is the same as the value of the numeric up down
                    if (item.SubItems[4].Text == nudItemPlu.Value.ToString())
                    {
                        alreadyExists = true;
                        break;
                    }

                // If the PLU has already been entered before
                if (alreadyExists)
                {
                    MessageBox.Show("Another product already has this PLU", "Warning: PLU exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // If not add the item
                    refForm1.MainListView.Items.Add(lvItem);
                    product.ID = refForm1.MainListView.Items.Count;
                }  
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Hide the form temporarily
            this.Hide();
            // Call the method called clear to clear/reset all the content/text from the form
            clearFields();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // Minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        ////////////////
        /// METHODS ///
        //////////////

        // Define a method to clear the content within the form
        private void clearFields()
        {
            txtName.Clear();
            nudAddItemAmount.Value = 0;
            cmbItemCategory.Text = "";
            nudItemPrice.Value = 0;
            nudItemPlu.Value = 0;
        }
    }
}
