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
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbSorter = new System.Windows.Forms.ComboBox();
            this.btnSøg = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblSorter = new System.Windows.Forms.Label();
            this.lstvBoks1 = new System.Windows.Forms.ListView();
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(129, 33);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(221, 24);
            this.cbKategori.TabIndex = 0;
            // 
            // cbSorter
            // 
            this.cbSorter.FormattingEnabled = true;
            this.cbSorter.Location = new System.Drawing.Point(553, 33);
            this.cbSorter.Name = "cbSorter";
            this.cbSorter.Size = new System.Drawing.Size(221, 24);
            this.cbSorter.TabIndex = 1;
            // 
            // btnSøg
            // 
            this.btnSøg.Location = new System.Drawing.Point(853, 13);
            this.btnSøg.Name = "btnSøg";
            this.btnSøg.Size = new System.Drawing.Size(74, 62);
            this.btnSøg.TabIndex = 2;
            this.btnSøg.Text = "Søg";
            this.btnSøg.UseVisualStyleBackColor = true;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(42, 36);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 17);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Category";
            // 
            // lblSorter
            // 
            this.lblSorter.AutoSize = true;
            this.lblSorter.Location = new System.Drawing.Point(490, 36);
            this.lblSorter.Name = "lblSorter";
            this.lblSorter.Size = new System.Drawing.Size(34, 17);
            this.lblSorter.TabIndex = 4;
            this.lblSorter.Text = "Sort";
            // 
            // lstvBoks1
            // 
            this.lstvBoks1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnName,
            this.clnCategory,
            this.clnPlu,
            this.clnPrice});
            this.lstvBoks1.Location = new System.Drawing.Point(208, 199);
            this.lstvBoks1.Name = "lstvBoks1";
            this.lstvBoks1.Size = new System.Drawing.Size(540, 307);
            this.lstvBoks1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstvBoks1.TabIndex = 5;
            this.lstvBoks1.UseCompatibleStateImageBehavior = false;
            this.lstvBoks1.View = System.Windows.Forms.View.Tile;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 650);
            this.Controls.Add(this.lstvBoks1);
            this.Controls.Add(this.lblSorter);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.btnSøg);
            this.Controls.Add(this.cbSorter);
            this.Controls.Add(this.cbKategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Storer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbSorter;
        private System.Windows.Forms.Button btnSøg;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblSorter;
        private System.Windows.Forms.ListView lstvBoks1;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnCategory;
        private System.Windows.Forms.ColumnHeader clnPlu;
        private System.Windows.Forms.ColumnHeader clnPrice;
    }
}

