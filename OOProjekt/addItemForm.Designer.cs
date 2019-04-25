namespace OOProjekt
{
    partial class addItemForm
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
            this.lblAddItem = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddItemPlu = new System.Windows.Forms.Label();
            this.lblAddItemPrice = new System.Windows.Forms.Label();
            this.lblAddItemAmount = new System.Windows.Forms.Label();
            this.lblAddItemCategory = new System.Windows.Forms.Label();
            this.lblAddItemName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddItemAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.cmbItemCategory.Size = new System.Drawing.Size(235, 21);
            this.cmbItemCategory.TabIndex = 35;
            // 
            // nudItemPlu
            // 
            this.nudItemPlu.Location = new System.Drawing.Point(101, 354);
            this.nudItemPlu.Name = "nudItemPlu";
            this.nudItemPlu.Size = new System.Drawing.Size(120, 20);
            this.nudItemPlu.TabIndex = 34;
            // 
            // nudItemPrice
            // 
            this.nudItemPrice.Location = new System.Drawing.Point(101, 297);
            this.nudItemPrice.Name = "nudItemPrice";
            this.nudItemPrice.Size = new System.Drawing.Size(120, 20);
            this.nudItemPrice.TabIndex = 33;
            // 
            // nudAddItemAmount
            // 
            this.nudAddItemAmount.Location = new System.Drawing.Point(101, 172);
            this.nudAddItemAmount.Name = "nudAddItemAmount";
            this.nudAddItemAmount.Size = new System.Drawing.Size(120, 20);
            this.nudAddItemAmount.TabIndex = 32;
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItem.Location = new System.Drawing.Point(31, 44);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(278, 29);
            this.lblAddItem.TabIndex = 31;
            this.lblAddItem.Text = "Add an item to your stock";
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
            this.lblAddItemPlu.Location = new System.Drawing.Point(12, 354);
            this.lblAddItemPlu.Name = "lblAddItemPlu";
            this.lblAddItemPlu.Size = new System.Drawing.Size(28, 13);
            this.lblAddItemPlu.TabIndex = 40;
            this.lblAddItemPlu.Text = "PLU";
            // 
            // lblAddItemPrice
            // 
            this.lblAddItemPrice.AutoSize = true;
            this.lblAddItemPrice.Location = new System.Drawing.Point(12, 299);
            this.lblAddItemPrice.Name = "lblAddItemPrice";
            this.lblAddItemPrice.Size = new System.Drawing.Size(31, 13);
            this.lblAddItemPrice.TabIndex = 39;
            this.lblAddItemPrice.Text = "Price";
            // 
            // lblAddItemAmount
            // 
            this.lblAddItemAmount.AutoSize = true;
            this.lblAddItemAmount.Font = new System.Drawing.Font("Roboto Thin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemAmount.Location = new System.Drawing.Point(9, 174);
            this.lblAddItemAmount.Name = "lblAddItemAmount";
            this.lblAddItemAmount.Size = new System.Drawing.Size(52, 15);
            this.lblAddItemAmount.TabIndex = 38;
            this.lblAddItemAmount.Text = "Amount";
            // 
            // lblAddItemCategory
            // 
            this.lblAddItemCategory.AutoSize = true;
            this.lblAddItemCategory.Location = new System.Drawing.Point(10, 239);
            this.lblAddItemCategory.Name = "lblAddItemCategory";
            this.lblAddItemCategory.Size = new System.Drawing.Size(49, 13);
            this.lblAddItemCategory.TabIndex = 37;
            this.lblAddItemCategory.Text = "Category";
            // 
            // lblAddItemName
            // 
            this.lblAddItemName.AutoSize = true;
            this.lblAddItemName.Font = new System.Drawing.Font("Roboto Thin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemName.Location = new System.Drawing.Point(12, 115);
            this.lblAddItemName.Name = "lblAddItemName";
            this.lblAddItemName.Size = new System.Drawing.Size(42, 15);
            this.lblAddItemName.TabIndex = 36;
            this.lblAddItemName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(105, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 48);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // addItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddItemPlu);
            this.Controls.Add(this.lblAddItemPrice);
            this.Controls.Add(this.lblAddItemAmount);
            this.Controls.Add(this.lblAddItemCategory);
            this.Controls.Add(this.lblAddItemName);
            this.Controls.Add(this.cmbItemCategory);
            this.Controls.Add(this.nudItemPlu);
            this.Controls.Add(this.nudItemPrice);
            this.Controls.Add(this.nudAddItemAmount);
            this.Controls.Add(this.lblAddItem);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addItemForm";
            this.Text = "addItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddItemAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddItemPlu;
        private System.Windows.Forms.Label lblAddItemPrice;
        private System.Windows.Forms.Label lblAddItemAmount;
        private System.Windows.Forms.Label lblAddItemCategory;
        private System.Windows.Forms.Label lblAddItemName;
        private System.Windows.Forms.Button btnAdd;
    }
}