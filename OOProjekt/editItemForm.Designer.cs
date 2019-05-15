namespace OOProjekt
{
    partial class editItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.nudItemPlu = new System.Windows.Forms.NumericUpDown();
            this.nudItemPrice = new System.Windows.Forms.NumericUpDown();
            this.nudAddItemAmount = new System.Windows.Forms.NumericUpDown();
            this.lblEditItem = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddItemPlu = new System.Windows.Forms.Label();
            this.lblAddItemPrice = new System.Windows.Forms.Label();
            this.lblAddItemAmount = new System.Windows.Forms.Label();
            this.lblAddItemCategory = new System.Windows.Forms.Label();
            this.lblAddItemName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddItemAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Silver;
            this.btnMinimize.Location = new System.Drawing.Point(277, -3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 24);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.Text = "−";
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.btnMinimize.Enter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.btnMinimize.Leave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(300, -3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 24);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "✖";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(74, 236);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(187, 21);
            this.cmbItemCategory.TabIndex = 32;
            // 
            // nudItemPlu
            // 
            this.nudItemPlu.Location = new System.Drawing.Point(74, 354);
            this.nudItemPlu.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudItemPlu.Name = "nudItemPlu";
            this.nudItemPlu.Size = new System.Drawing.Size(120, 20);
            this.nudItemPlu.TabIndex = 34;
            // 
            // nudItemPrice
            // 
            this.nudItemPrice.Location = new System.Drawing.Point(74, 297);
            this.nudItemPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudItemPrice.Name = "nudItemPrice";
            this.nudItemPrice.Size = new System.Drawing.Size(120, 20);
            this.nudItemPrice.TabIndex = 33;
            // 
            // nudAddItemAmount
            // 
            this.nudAddItemAmount.Location = new System.Drawing.Point(74, 172);
            this.nudAddItemAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAddItemAmount.Name = "nudAddItemAmount";
            this.nudAddItemAmount.Size = new System.Drawing.Size(120, 20);
            this.nudAddItemAmount.TabIndex = 31;
            // 
            // lblEditItem
            // 
            this.lblEditItem.AutoSize = true;
            this.lblEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditItem.Location = new System.Drawing.Point(18, 43);
            this.lblEditItem.Name = "lblEditItem";
            this.lblEditItem.Size = new System.Drawing.Size(304, 29);
            this.lblEditItem.TabIndex = 31;
            this.lblEditItem.Text = "Edit an item in your stock";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 21);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // lblAddItemPlu
            // 
            this.lblAddItemPlu.AutoSize = true;
            this.lblAddItemPlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemPlu.Location = new System.Drawing.Point(39, 354);
            this.lblAddItemPlu.Name = "lblAddItemPlu";
            this.lblAddItemPlu.Size = new System.Drawing.Size(34, 16);
            this.lblAddItemPlu.TabIndex = 40;
            this.lblAddItemPlu.Text = "PLU";
            // 
            // lblAddItemPrice
            // 
            this.lblAddItemPrice.AutoSize = true;
            this.lblAddItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemPrice.Location = new System.Drawing.Point(34, 297);
            this.lblAddItemPrice.Name = "lblAddItemPrice";
            this.lblAddItemPrice.Size = new System.Drawing.Size(39, 16);
            this.lblAddItemPrice.TabIndex = 39;
            this.lblAddItemPrice.Text = "Price";
            // 
            // lblAddItemAmount
            // 
            this.lblAddItemAmount.AutoSize = true;
            this.lblAddItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemAmount.Location = new System.Drawing.Point(20, 172);
            this.lblAddItemAmount.Name = "lblAddItemAmount";
            this.lblAddItemAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAddItemAmount.TabIndex = 38;
            this.lblAddItemAmount.Text = "Amount";
            // 
            // lblAddItemCategory
            // 
            this.lblAddItemCategory.AutoSize = true;
            this.lblAddItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemCategory.Location = new System.Drawing.Point(10, 237);
            this.lblAddItemCategory.Name = "lblAddItemCategory";
            this.lblAddItemCategory.Size = new System.Drawing.Size(63, 16);
            this.lblAddItemCategory.TabIndex = 37;
            this.lblAddItemCategory.Text = "Category";
            // 
            // lblAddItemName
            // 
            this.lblAddItemName.AutoSize = true;
            this.lblAddItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemName.Location = new System.Drawing.Point(28, 116);
            this.lblAddItemName.Name = "lblAddItemName";
            this.lblAddItemName.Size = new System.Drawing.Size(45, 16);
            this.lblAddItemName.TabIndex = 36;
            this.lblAddItemName.Text = "Name";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Location = new System.Drawing.Point(105, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 48);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.BtnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.BtnEdit_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(328, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 450);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 450);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox4.Location = new System.Drawing.Point(2, 448);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(330, 2);
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // editItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblAddItemPlu);
            this.Controls.Add(this.lblAddItemPrice);
            this.Controls.Add(this.lblAddItemAmount);
            this.Controls.Add(this.lblAddItemCategory);
            this.Controls.Add(this.lblAddItemName);
            this.Controls.Add(this.cmbItemCategory);
            this.Controls.Add(this.nudItemPlu);
            this.Controls.Add(this.nudItemPrice);
            this.Controls.Add(this.nudAddItemAmount);
            this.Controls.Add(this.lblEditItem);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editItemForm";
            this.Text = "addItemForm";
            this.Load += new System.EventHandler(this.EditItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddItemAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.NumericUpDown nudItemPlu;
        private System.Windows.Forms.NumericUpDown nudItemPrice;
        private System.Windows.Forms.NumericUpDown nudAddItemAmount;
        private System.Windows.Forms.Label lblEditItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddItemPlu;
        private System.Windows.Forms.Label lblAddItemPrice;
        private System.Windows.Forms.Label lblAddItemAmount;
        private System.Windows.Forms.Label lblAddItemCategory;
        private System.Windows.Forms.Label lblAddItemName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}