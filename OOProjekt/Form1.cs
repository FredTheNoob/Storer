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
        public ListView MainListView;

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

        public void reloadMainList()
        {
            lvBoks = MainListView;
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
            // Prompt the user with a message asking whether or not he wants to remove the selected items in the listView and set the icon of the messagebox to a infoicon
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove " + selectCount + " item(s)?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // If the user presses yes
            if (dialogResult == DialogResult.Yes)
            {
                // If the user only has selected 1 item from the listView
                if (selectCount == 1)
                {
                    // Remove 1 item from the array selected in the listView
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
}
