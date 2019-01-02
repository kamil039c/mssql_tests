namespace CRM_Tests
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GridVw = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwadrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(490, 35);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Dodaj element";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GridVw
            // 
            this.GridVw.AllowUserToAddRows = false;
            this.GridVw.AllowUserToResizeColumns = false;
            this.GridVw.AllowUserToResizeRows = false;
            this.GridVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.x,
            this.y,
            this.kwadrat});
            this.GridVw.Location = new System.Drawing.Point(12, 53);
            this.GridVw.MultiSelect = false;
            this.GridVw.Name = "GridVw";
            this.GridVw.ReadOnly = true;
            this.GridVw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridVw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridVw.Size = new System.Drawing.Size(490, 166);
            this.GridVw.TabIndex = 2;
            this.GridVw.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.GridVw_UserDeletedRow);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // x
            // 
            this.x.HeaderText = "X";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.HeaderText = "Y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // kwadrat
            // 
            this.kwadrat.HeaderText = "Kwadrat";
            this.kwadrat.Name = "kwadrat";
            this.kwadrat.ReadOnly = true;
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(12, 225);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(490, 23);
            this.BtnRead.TabIndex = 3;
            this.BtnRead.Text = "Odczyt z DB";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 254);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.GridVw);
            this.Controls.Add(this.BtnAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 293);
            this.Name = "Form1";
            this.Text = "MSSQL_TEST";
            ((System.ComponentModel.ISupportInitialize)(this.GridVw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView GridVw;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwadrat;
        private System.Windows.Forms.Button BtnRead;
    }
}

