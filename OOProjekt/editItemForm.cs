﻿using System;
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
        #warning: TODO: ADD COMMENTS

        Form1 refMainForm;
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

        #region CustomUI

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //////////////////////
        /// EVENTHANDLERS ///
        ////////////////////

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
            SelectedName.Text = txtName.Text;
            SelectedAmount.Text = nudAddItemAmount.Value.ToString();
            SelectedCategory.Text = cmbItemCategory.Text;
            SelectedPrice.Text = nudItemPrice.Value.ToString();
            SelectedPLU.Text = nudItemPlu.Value.ToString();
            this.Hide();
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

        ////////////////
        /// METHODS ///
        //////////////

        // Define a method to clear the content within the form
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
            SelectedName = refMainForm.MainListView.SelectedItems[0].SubItems[0];
            SelectedAmount = refMainForm.MainListView.SelectedItems[0].SubItems[1];
            SelectedCategory = refMainForm.MainListView.SelectedItems[0].SubItems[2];
            SelectedPrice = refMainForm.MainListView.SelectedItems[0].SubItems[3];
            SelectedPLU = refMainForm.MainListView.SelectedItems[0].SubItems[4];
            #endregion Defining Listview subitems

            txtName.Text = SelectedName.Text;
            nudAddItemAmount.Value = int.Parse(SelectedAmount.Text);
            cmbItemCategory.Text = SelectedCategory.Text;
            nudItemPlu.Value = int.Parse(SelectedPLU.Text);
            nudItemPrice.Value = int.Parse(SelectedPrice.Text);

        }
    }
}
