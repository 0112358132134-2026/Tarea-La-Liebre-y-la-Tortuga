namespace Práctica_Proyecto
{
    partial class Tablero31
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero31));
            this.dataTablero3 = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblGalletitas = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnComandos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblGalletas = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTablero3
            // 
            this.dataTablero3.AllowUserToOrderColumns = true;
            this.dataTablero3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataTablero3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataTablero3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTablero3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTablero3.ColumnHeadersHeight = 100;
            this.dataTablero3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTablero3.ColumnHeadersVisible = false;
            this.dataTablero3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4,
            this.Columna5});
            this.dataTablero3.Location = new System.Drawing.Point(25, 27);
            this.dataTablero3.MultiSelect = false;
            this.dataTablero3.Name = "dataTablero3";
            this.dataTablero3.RowHeadersVisible = false;
            this.dataTablero3.RowHeadersWidth = 100;
            this.dataTablero3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTablero3.Size = new System.Drawing.Size(500, 500);
            this.dataTablero3.TabIndex = 0;
            this.dataTablero3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataTablero3_CellFormatting);
            this.dataTablero3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTablero3_KeyUp);
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "";
            this.Columna1.Name = "Columna1";
            this.Columna1.Width = 21;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "";
            this.Columna2.Name = "Columna2";
            this.Columna2.Width = 21;
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "";
            this.Columna3.Name = "Columna3";
            this.Columna3.Width = 21;
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "";
            this.Columna4.Name = "Columna4";
            this.Columna4.Width = 21;
            // 
            // Columna5
            // 
            this.Columna5.HeaderText = "";
            this.Columna5.Name = "Columna5";
            this.Columna5.Width = 21;
            // 
            // lblGalletitas
            // 
            this.lblGalletitas.AutoSize = true;
            this.lblGalletitas.BackColor = System.Drawing.Color.Transparent;
            this.lblGalletitas.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalletitas.Location = new System.Drawing.Point(584, 137);
            this.lblGalletitas.Name = "lblGalletitas";
            this.lblGalletitas.Size = new System.Drawing.Size(0, 23);
            this.lblGalletitas.TabIndex = 1;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(633, 215);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(0, 23);
            this.lblPuntos.TabIndex = 2;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(407, 12);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(118, 23);
            this.btnEstado.TabIndex = 3;
            this.btnEstado.Text = "Estado del Avatar";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnComandos
            // 
            this.btnComandos.Location = new System.Drawing.Point(576, 352);
            this.btnComandos.Name = "btnComandos";
            this.btnComandos.Size = new System.Drawing.Size(118, 23);
            this.btnComandos.TabIndex = 4;
            this.btnComandos.Text = "Comandos";
            this.btnComandos.UseVisualStyleBackColor = true;
            this.btnComandos.Click += new System.EventHandler(this.btnComandos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Estado del Avatar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(576, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Terminar Partida";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblGalletas
            // 
            this.lblGalletas.AutoSize = true;
            this.lblGalletas.BackColor = System.Drawing.Color.Transparent;
            this.lblGalletas.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalletas.Location = new System.Drawing.Point(609, 136);
            this.lblGalletas.Name = "lblGalletas";
            this.lblGalletas.Size = new System.Drawing.Size(133, 23);
            this.lblGalletas.TabIndex = 7;
            this.lblGalletas.Text = "/ 6 Galletitas";
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(538, 250);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(56, 23);
            this.lblVidas.TabIndex = 14;
            this.lblVidas.Text = "Vidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Puntos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(634, 179);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 15;
            // 
            // Tablero31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(736, 545);
            this.ControlBox = false;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGalletas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnComandos);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblGalletitas);
            this.Controls.Add(this.dataTablero3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tablero31";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tablero31_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTablero3;
        private System.Windows.Forms.DataGridViewImageColumn Columna1;
        private System.Windows.Forms.DataGridViewImageColumn Columna2;
        private System.Windows.Forms.DataGridViewImageColumn Columna3;
        private System.Windows.Forms.DataGridViewImageColumn Columna4;
        private System.Windows.Forms.DataGridViewImageColumn Columna5;
        private System.Windows.Forms.Label lblGalletitas;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnComandos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblGalletas;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
    }
}