namespace SMS
{
    partial class Index
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
            this.categoryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.companyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.itemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.stockInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.stockOutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchLinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // categoryLinkLabel
            // 
            this.categoryLinkLabel.AutoSize = true;
            this.categoryLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLinkLabel.Location = new System.Drawing.Point(159, 29);
            this.categoryLinkLabel.Name = "categoryLinkLabel";
            this.categoryLinkLabel.Size = new System.Drawing.Size(110, 18);
            this.categoryLinkLabel.TabIndex = 0;
            this.categoryLinkLabel.TabStop = true;
            this.categoryLinkLabel.Text = "Category Setup";
            this.categoryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CategoryLinkLabel_LinkClicked);
            // 
            // companyLinkLabel
            // 
            this.companyLinkLabel.AutoSize = true;
            this.companyLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLinkLabel.Location = new System.Drawing.Point(159, 66);
            this.companyLinkLabel.Name = "companyLinkLabel";
            this.companyLinkLabel.Size = new System.Drawing.Size(114, 18);
            this.companyLinkLabel.TabIndex = 1;
            this.companyLinkLabel.TabStop = true;
            this.companyLinkLabel.Text = "Company Setup";
            this.companyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CompanyLinkLabel_LinkClicked);
            // 
            // itemLinkLabel
            // 
            this.itemLinkLabel.AutoSize = true;
            this.itemLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLinkLabel.Location = new System.Drawing.Point(159, 96);
            this.itemLinkLabel.Name = "itemLinkLabel";
            this.itemLinkLabel.Size = new System.Drawing.Size(78, 18);
            this.itemLinkLabel.TabIndex = 2;
            this.itemLinkLabel.TabStop = true;
            this.itemLinkLabel.Text = "Item Setup";
            // 
            // stockInLinkLabel
            // 
            this.stockInLinkLabel.AutoSize = true;
            this.stockInLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInLinkLabel.Location = new System.Drawing.Point(159, 126);
            this.stockInLinkLabel.Name = "stockInLinkLabel";
            this.stockInLinkLabel.Size = new System.Drawing.Size(62, 18);
            this.stockInLinkLabel.TabIndex = 3;
            this.stockInLinkLabel.TabStop = true;
            this.stockInLinkLabel.Text = "Stock In";
            // 
            // stockOutLinkLabel
            // 
            this.stockOutLinkLabel.AutoSize = true;
            this.stockOutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutLinkLabel.Location = new System.Drawing.Point(159, 158);
            this.stockOutLinkLabel.Name = "stockOutLinkLabel";
            this.stockOutLinkLabel.Size = new System.Drawing.Size(75, 18);
            this.stockOutLinkLabel.TabIndex = 4;
            this.stockOutLinkLabel.TabStop = true;
            this.stockOutLinkLabel.Text = "Stock Out";
            // 
            // searchLinkLabel
            // 
            this.searchLinkLabel.AutoSize = true;
            this.searchLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLinkLabel.Location = new System.Drawing.Point(159, 185);
            this.searchLinkLabel.Name = "searchLinkLabel";
            this.searchLinkLabel.Size = new System.Drawing.Size(202, 18);
            this.searchLinkLabel.TabIndex = 5;
            this.searchLinkLabel.TabStop = true;
            this.searchLinkLabel.Text = "Search & View Items Summary";
            // 
            // viewLinkLabel
            // 
            this.viewLinkLabel.AutoSize = true;
            this.viewLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLinkLabel.Location = new System.Drawing.Point(159, 219);
            this.viewLinkLabel.Name = "viewLinkLabel";
            this.viewLinkLabel.Size = new System.Drawing.Size(225, 18);
            this.viewLinkLabel.TabIndex = 6;
            this.viewLinkLabel.TabStop = true;
            this.viewLinkLabel.Text = "View Between Two Dates Report";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewLinkLabel);
            this.Controls.Add(this.searchLinkLabel);
            this.Controls.Add(this.stockOutLinkLabel);
            this.Controls.Add(this.stockInLinkLabel);
            this.Controls.Add(this.itemLinkLabel);
            this.Controls.Add(this.companyLinkLabel);
            this.Controls.Add(this.categoryLinkLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel categoryLinkLabel;
        private System.Windows.Forms.LinkLabel companyLinkLabel;
        private System.Windows.Forms.LinkLabel itemLinkLabel;
        private System.Windows.Forms.LinkLabel stockInLinkLabel;
        private System.Windows.Forms.LinkLabel stockOutLinkLabel;
        private System.Windows.Forms.LinkLabel searchLinkLabel;
        private System.Windows.Forms.LinkLabel viewLinkLabel;
    }
}