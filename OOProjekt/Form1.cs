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
        editItemForm refEditForm;
        // Make a public accessible ListView
        public ListView MainListView;
        public List<itemStock> itemStockList;

        #region customUI

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

        private void BtnNew_MouseEnter(object sender, EventArgs e)
        {
            // Invert the colors by changing the background color to blue and text in the button to silver and the border on the button to silver
            btnNew.BackColor = Color.DodgerBlue;
            btnNew.ForeColor = Color.Silver;
            btnNew.FlatAppearance.BorderColor = Color.Silver;
        }

        private void BtnNew_MouseLeave(object sender, EventArgs e)
        {
            btnNew.BackColor = Color.Silver;
            btnNew.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnNew.ForeColor = Color.DodgerBlue;
        }

        private void BtnSell_MouseEnter(object sender, EventArgs e)
        {
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

        #endregion customUI

        private void Form1_Load(object sender, EventArgs e)
        {
            refItemForm = new addItemForm(this);
            refEditForm = new editItemForm(this);
            MainListView = lvBoks;
            itemStockList = new List<itemStock>();
        }

        #region ExternalFormVisability
        private void BtnNew_Click(object sender, EventArgs e)
        {
            refItemForm.Show();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            refEditForm.Show();
            
        }

        #endregion FormReferences

        // Removes selected items if possible
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Make an int called selectCount and store the selected 
            int selectCount = lvBoks.SelectedItems.Count;

            // If the user has not selected anything from the listView
            if (selectCount == 0)
            {
                // Prompts the user with a message, informing him that he needs to select an item, make a warning icon and an ok button on the messagebox too
                MessageBox.Show("Please select an item from the list above", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (selectCount > 0)
            {
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
        private void BtnSell_Click(object sender, EventArgs e)
        {
            
        }

        private void LvBoks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If one item has been selected
            if (lvBoks.SelectedItems.Count == 1)
            {
                // Make the edit button clickable
                btnEdit.Enabled = true;
                btnEdit.BackColor = Color.Silver;
                btnEdit.FlatAppearance.BorderColor = Color.DodgerBlue;
                btnEdit.ForeColor = Color.DodgerBlue;
            }
            else
            {
                // Make the button unclickable
                btnEdit.Enabled = false;
                btnEdit.FlatAppearance.BorderColor = Color.DimGray;
            }
        }

        // When a key is pressed while inside the search textbox
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (ListViewItem item in lvBoks.Items)
            {

                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    if (!subitem.Text.Contains(txtSearch.Text))
                    {
                        item.Remove();
                    }
                }
            }
        }
    }
}
