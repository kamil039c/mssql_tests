namespace CRM_Tests
{
    partial class fmGrid
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
            this.GridTable = new System.Windows.Forms.DataGridView();
            this.LabelSelectInfo = new System.Windows.Forms.Label();
            this.BtnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTable
            // 
            this.GridTable.AllowUserToAddRows = false;
            this.GridTable.AllowUserToDeleteRows = false;
            this.GridTable.AllowUserToResizeColumns = false;
            this.GridTable.AllowUserToResizeRows = false;
            this.GridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTable.Location = new System.Drawing.Point(12, 11);
            this.GridTable.MultiSelect = false;
            this.GridTable.Name = "GridTable";
            this.GridTable.ReadOnly = true;
            this.GridTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridTable.Size = new System.Drawing.Size(444, 444);
            this.GridTable.TabIndex = 0;
            this.GridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTable_CellClick);
            // 
            // LabelSelectInfo
            // 
            this.LabelSelectInfo.AutoSize = true;
            this.LabelSelectInfo.Location = new System.Drawing.Point(12, 461);
            this.LabelSelectInfo.Name = "LabelSelectInfo";
            this.LabelSelectInfo.Size = new System.Drawing.Size(0, 13);
            this.LabelSelectInfo.TabIndex = 1;
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Location = new System.Drawing.Point(315, 461);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(141, 23);
            this.BtnDodaj.TabIndex = 2;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // fmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 492);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.LabelSelectInfo);
            this.Controls.Add(this.GridTable);
            this.MaximumSize = new System.Drawing.Size(484, 531);
            this.MinimumSize = new System.Drawing.Size(484, 531);
            this.Name = "fmGrid";
            this.Text = "fmGrid";
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridTable;
        private System.Windows.Forms.Label LabelSelectInfo;
        private System.Windows.Forms.Button BtnDodaj;
    }
}