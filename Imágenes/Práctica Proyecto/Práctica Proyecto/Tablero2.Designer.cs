namespace Práctica_Proyecto
{
    partial class Tablero2
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
            this.dataTablero2 = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTablero2
            // 
            this.dataTablero2.AllowUserToDeleteRows = false;
            this.dataTablero2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataTablero2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataTablero2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTablero2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTablero2.ColumnHeadersHeight = 100;
            this.dataTablero2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTablero2.ColumnHeadersVisible = false;
            this.dataTablero2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4});
            this.dataTablero2.Location = new System.Drawing.Point(22, 22);
            this.dataTablero2.MultiSelect = false;
            this.dataTablero2.Name = "dataTablero2";
            this.dataTablero2.ReadOnly = true;
            this.dataTablero2.RowHeadersVisible = false;
            this.dataTablero2.RowHeadersWidth = 100;
            this.dataTablero2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTablero2.Size = new System.Drawing.Size(480, 480);
            this.dataTablero2.TabIndex = 3;
            this.dataTablero2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data2_CellFormatting);
            this.dataTablero2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTablero2_KeyUp);
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "";
            this.Columna1.Name = "Columna1";
            this.Columna1.ReadOnly = true;
            this.Columna1.Width = 21;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "";
            this.Columna2.Name = "Columna2";
            this.Columna2.ReadOnly = true;
            this.Columna2.Width = 21;
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "";
            this.Columna3.Name = "Columna3";
            this.Columna3.ReadOnly = true;
            this.Columna3.Width = 21;
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "";
            this.Columna4.Name = "Columna4";
            this.Columna4.ReadOnly = true;
            this.Columna4.Width = 21;
            // 
            // txtPrueba
            // 
            this.txtPrueba.Location = new System.Drawing.Point(524, 74);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.ReadOnly = true;
            this.txtPrueba.Size = new System.Drawing.Size(100, 20);
            this.txtPrueba.TabIndex = 4;
            // 
            // Tablero2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 516);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.dataTablero2);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tablero2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tablero2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTablero2;
        private System.Windows.Forms.DataGridViewImageColumn Columna1;
        private System.Windows.Forms.DataGridViewImageColumn Columna2;
        private System.Windows.Forms.DataGridViewImageColumn Columna3;
        private System.Windows.Forms.DataGridViewImageColumn Columna4;
        private System.Windows.Forms.TextBox txtPrueba;
    }
}