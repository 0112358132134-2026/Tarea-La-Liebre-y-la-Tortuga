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
    public partial class Preguntas : Form
    {
        public Preguntas()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (comboBoxPreguntas.Text == "París, La gran murallas China")
            {
                MessageBox.Show("¡Correcto!");
                Tablero21.puntos2 += 10;
                Tablero31.puntos3 += 10;
                Tablero4.puntos4 += 10;
                Tablero5.puntos5 += 10;
                Tablero21.cabesitasItsTrue = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrecto");
                Tablero21.puntos2 -= 20;
                Tablero31.puntos3 -= 20;
                Tablero4.puntos4 -= 20;
                Tablero5.puntos5 -= 20;
                Tablero21.cabesitasItsTrue = false;
                this.Close();
                //
                this.Hide();
                Tablero1 forma8 = new Tablero1();
                forma8.Show();
            }
        }
    }
}
