using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.DimGray;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = pictureBox1.BackColor;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = pictureBox1.BackColor;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //// Create a new instance of the listbox object called lvItem and insert the first item into column 0 called "apple" (the name column)
            //ListViewItem lvItem = new ListViewItem("Apple");
            //// Move onto the subitem of apple and find column 1 (tabindex 1) and then insert the value 4 into this column (the amount column)
            //lvItem.SubItems.Add("4");
            //// Move onto the subitem of apple and find column 2 (tabindex 2) and then insert the string: fruits into this column (the category column)
            //lvItem.SubItems.Add("Fruits");
            //// Move onto the subitem of apple and find column 3 (tabindex 3) and then insert the string: $0.50 into this column (the price column)
            //lvItem.SubItems.Add("$0.50");
            //// Move onto the subitem of apple and find column 4 (tabindex 4) and then insert the string: 137 into this column (the PLU column)
            //lvItem.SubItems.Add("137");
            //// Add the items into the listview of the variable lvItem
            //lvBoks.Items.Add(lvItem);
            refItemForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refItemForm = new addItemForm(this);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Make an int called selectCount and store the selected 
            int selectCount = lvBoks.SelectedItems.Count;

            // If the user only has selected 1 item from the listView
            if (selectCount == 1)
            {
                // Remove 1 item from the array selected in the 
                lvBoks.SelectedItems[0].Remove();
            }
            // If the user has selected more than 1 item
            else if (selectCount > 1)
            {
                // Remove each item inside the listView
                foreach (ListViewItem eachItem in lvBoks.SelectedItems)
                {
                    // Remove the selected items
                    lvBoks.Items.Remove(eachItem);
                }
            }
        }
    }
}
