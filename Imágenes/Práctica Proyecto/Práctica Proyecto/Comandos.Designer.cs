namespace Práctica_Proyecto
{
    partial class Comandos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comandos));
            this.lblComandos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComandos
            // 
            this.lblComandos.BackColor = System.Drawing.Color.Transparent;
            this.lblComandos.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandos.ForeColor = System.Drawing.Color.Black;
            this.lblComandos.Location = new System.Drawing.Point(12, 49);
            this.lblComandos.Name = "lblComandos";
            this.lblComandos.Size = new System.Drawing.Size(494, 354);
            this.lblComandos.TabIndex = 0;
            this.lblComandos.Text = resources.GetString("lblComandos.Text");
            this.lblComandos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(524, 448);
            this.Controls.Add(this.lblComandos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comandos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblComandos;
    }
}