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
    public partial class Eleccion : Form
    {
        public Eleccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSexo.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar género y nombre para poder avanzar");
            }
            else 
            if (comboBoxSexo.Text == "Hombre")
            {
                this.Hide();
                Tablero1.imagen = @"C:\Users\Pcuevas2026\Desktop\Pugsheen.png";
                Tablero21.imagen = @"C:\Users\Pcuevas2026\Desktop\PugsheenTab2.png";
                Tablero31.imagen = @"C:\Users\Pcuevas2026\Desktop\Tablero3\PugsheenTab3.png";
                Tablero4.imagen = @"C:\Users\Pcuevas2026\Desktop\Tablero3\PugsheenTab3.png";
                Tablero5.imagen = @"C:\Users\Pcuevas2026\Desktop\Tablero5\PugsheenTab5.png";
                Tablero1.nombre = txtNombre.Text;
                Tablero21.nombre = txtNombre.Text;
                Tablero31.nombre = txtNombre.Text;
                Tablero4.nombre = txtNombre.Text;
                EstadoAvatar.nombre = txtNombre.Text;
                Tablero1 forma5 = new Tablero1();
                forma5.Show();
            }else if (comboBoxSexo.Text == "Mujer")
            {
                this.Hide();
                Tablero1.imagen = @"C:\Users\Pcuevas2026\Desktop\Pusheen.png";
                Tablero21.imagen = @"C:\Users\Pcuevas2026\Desktop\PusheenTab2.png";
                Tablero31.imagen = @"C:\Users\Pcuevas2026\Desktop\Tablero3\PusheenTab3.png";
                Tablero4.imagen = @"C:\Users\Pcuevas2026\Desktop\Tablero3\PusheenTab3.png";
                Tablero5.imagen = @"C:\Users\Pcuevas2026\Desktop\Tablero5\PusheenTab5.png";
                Tablero1.nombre = txtNombre.Text;
                Tablero21.nombre = txtNombre.Text;
                Tablero31.nombre = txtNombre.Text;
                Tablero4.nombre = txtNombre.Text;
                EstadoAvatar.nombre = txtNombre.Text;
                Tablero1 forma5 = new Tablero1();
                forma5.Show();
            }
        }
    }
}
