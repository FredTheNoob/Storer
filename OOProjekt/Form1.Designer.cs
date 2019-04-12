namespace OOProjekt
{
    partial class Form1
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
            this.lstvBox1 = new System.Windows.Forms.ListView();
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvBox1
            // 
            this.lstvBox1.BackColor = System.Drawing.Color.Silver;
            this.lstvBox1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnName,
            this.clnCategory,
            this.clnPlu,
            this.clnPrice});
            this.lstvBox1.Location = new System.Drawing.Point(27, 143);
            this.lstvBox1.Name = "lstvBox1";
            this.lstvBox1.Size = new System.Drawing.Size(972, 476);
            this.lstvBox1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstvBox1.TabIndex = 5;
            this.lstvBox1.UseCompatibleStateImageBehavior = false;
            this.lstvBox1.View = System.Windows.Forms.View.Tile;
            // 
            // clnName
            // 
            this.clnName.Text = "Product Name";
            // 
            // clnCategory
            // 
            this.clnCategory.Text = "Category";
            // 
            // clnPlu
            // 
            this.clnPlu.Text = "PLU";
            // 
            // clnPrice
            // 
            this.clnPrice.Text = "Price";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Location = new System.Drawing.Point(857, 115);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(798, 115);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(467, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 17);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Welcome USER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1028, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(992, -4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "✖";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Silver;
            this.btnMinimize.Location = new System.Drawing.Point(961, -4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 29);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.Text = "−";
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1027, 650);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstvBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Storer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstvBox1;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnCategory;
        private System.Windows.Forms.ColumnHeader clnPlu;
        private System.Windows.Forms.ColumnHeader clnPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label btnMinimize;
    }
}

