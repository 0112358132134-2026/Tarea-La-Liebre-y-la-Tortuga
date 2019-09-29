using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_Proyecto
{
    public partial class EstadoAvatar : Form
    {
        public static string nombre;
        public EstadoAvatar()
        {
            InitializeComponent();
        }

        private void EstadoAvatar_Load(object sender, EventArgs e)
        {
            labelNombreA.Text = nombre;
            lblSumaGalletas.Text += Tablero1.contadorGalletas1 + Tablero21.contadorGalletas2 + Tablero31.contadorGalletas3 + Tablero4.contadorGalletas4 + Tablero5.contadorGalletas5;
            lblPuntos.Text += Tablero1.puntos1 + Tablero21.puntos2 + Tablero31.puntos3 + Tablero4.puntos4 + Tablero5.puntos5;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
