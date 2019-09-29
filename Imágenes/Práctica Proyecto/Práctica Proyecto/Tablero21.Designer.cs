namespace Práctica_Proyecto
{
    partial class Tablero21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero21));
            this.dataTablero21 = new System.Windows.Forms.DataGridView();
            this.Columna22 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna23 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna24 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna21 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblGalletitas = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.btnComandos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnTerminarP = new System.Windows.Forms.Button();
            this.btnEstadoAv = new System.Windows.Forms.Button();
            this.lblGalletas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero21)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTablero21
            // 
            this.dataTablero21.AllowUserToOrderColumns = true;
            this.dataTablero21.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataTablero21.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataTablero21.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTablero21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTablero21.ColumnHeadersHeight = 100;
            this.dataTablero21.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTablero21.ColumnHeadersVisible = false;
            this.dataTablero21.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna22,
            this.Columna23,
            this.Columna24,
            this.Columna21});
            this.dataTablero21.Location = new System.Drawing.Point(22, 25);
            this.dataTablero21.MultiSelect = false;
            this.dataTablero21.Name = "dataTablero21";
            this.dataTablero21.RowHeadersVisible = false;
            this.dataTablero21.RowHeadersWidth = 100;
            this.dataTablero21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTablero21.Size = new System.Drawing.Size(480, 480);
            this.dataTablero21.TabIndex = 0;
            this.dataTablero21.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataTablero21.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // Columna22
            // 
            this.Columna22.HeaderText = "";
            this.Columna22.Name = "Columna22";
            this.Columna22.Width = 21;
            // 
            // Columna23
            // 
            this.Columna23.HeaderText = "";
            this.Columna23.Name = "Columna23";
            this.Columna23.Width = 21;
            // 
            // Columna24
            // 
            this.Columna24.HeaderText = "";
            this.Columna24.Name = "Columna24";
            this.Columna24.Width = 21;
            // 
            // Columna21
            // 
            this.Columna21.HeaderText = "";
            this.Columna21.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Columna21.Name = "Columna21";
            this.Columna21.Width = 21;
            // 
            // lblGalletitas
            // 
            this.lblGalletitas.AutoSize = true;
            this.lblGalletitas.BackColor = System.Drawing.Color.Transparent;
            this.lblGalletitas.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalletitas.Location = new System.Drawing.Point(547, 97);
            this.lblGalletitas.Name = "lblGalletitas";
            this.lblGalletitas.Size = new System.Drawing.Size(0, 23);
            this.lblGalletitas.TabIndex = 1;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(611, 175);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(0, 23);
            this.lblPuntos.TabIndex = 2;
            // 
            // btnComandos
            // 
            this.btnComandos.Location = new System.Drawing.Point(544, 311);
            this.btnComandos.Name = "btnComandos";
            this.btnComandos.Size = new System.Drawing.Size(123, 23);
            this.btnComandos.TabIndex = 3;
            this.btnComandos.Text = "Comandos";
            this.btnComandos.UseVisualStyleBackColor = true;
            this.btnComandos.Click += new System.EventHandler(this.btnComandos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(544, 340);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(123, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir Tablero";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnTerminarP
            // 
            this.btnTerminarP.Location = new System.Drawing.Point(544, 369);
            this.btnTerminarP.Name = "btnTerminarP";
            this.btnTerminarP.Size = new System.Drawing.Size(123, 23);
            this.btnTerminarP.TabIndex = 5;
            this.btnTerminarP.Text = "Terminar Partida";
            this.btnTerminarP.UseVisualStyleBackColor = true;
            this.btnTerminarP.Click += new System.EventHandler(this.btnTerminarP_Click);
            // 
            // btnEstadoAv
            // 
            this.btnEstadoAv.Location = new System.Drawing.Point(379, 12);
            this.btnEstadoAv.Name = "btnEstadoAv";
            this.btnEstadoAv.Size = new System.Drawing.Size(123, 23);
            this.btnEstadoAv.TabIndex = 6;
            this.btnEstadoAv.Text = "Estado del Avatar";
            this.btnEstadoAv.UseVisualStyleBackColor = true;
            this.btnEstadoAv.Click += new System.EventHandler(this.btnEstadoAv_Click);
            // 
            // lblGalletas
            // 
            this.lblGalletas.AutoSize = true;
            this.lblGalletas.BackColor = System.Drawing.Color.Transparent;
            this.lblGalletas.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalletas.Location = new System.Drawing.Point(570, 97);
            this.lblGalletas.Name = "lblGalletas";
            this.lblGalletas.Size = new System.Drawing.Size(133, 23);
            this.lblGalletas.TabIndex = 7;
            this.lblGalletas.Text = "/ 6 Galletitas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puntos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(617, 134);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 23);
            this.labelName.TabIndex = 10;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(515, 214);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(61, 23);
            this.lblVidas.TabIndex = 11;
            this.lblVidas.Text = "Vidas:";
            // 
            // Tablero21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 518);
            this.ControlBox = false;
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGalletas);
            this.Controls.Add(this.btnEstadoAv);
            this.Controls.Add(this.btnTerminarP);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnComandos);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblGalletitas);
            this.Controls.Add(this.dataTablero21);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tablero21";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tablero21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTablero21;
        private System.Windows.Forms.DataGridViewImageColumn Columna22;
        private System.Windows.Forms.DataGridViewImageColumn Columna23;
        private System.Windows.Forms.DataGridViewImageColumn Columna24;
        private System.Windows.Forms.DataGridViewImageColumn Columna21;
        private System.Windows.Forms.Label lblGalletitas;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Button btnComandos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnTerminarP;
        private System.Windows.Forms.Button btnEstadoAv;
        private System.Windows.Forms.Label lblGalletas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblVidas;
    }
}