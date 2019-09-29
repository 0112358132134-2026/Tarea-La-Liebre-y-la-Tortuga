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
    public partial class Tablero2 : Form
    {
        public static object imagen;
        object cuadroBlanco = @"C:\Users\Pcuevas2026\Desktop\cuadroblanco3.png";
        Random r = new Random();
        int posx1 = 0, posy1 = 0;

        public Tablero2()
        {
            InitializeComponent();
        }

        public void llenarTablero()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataTablero2[i, j].Value = cuadroBlanco;
                }
            }
        }

        public void llenarPersonaje()
        {
            dataTablero2[1, 1].Value = imagen;
        }

        public void Mover(int PosX, int PosY)
        {
            dataTablero2[PosX, PosY].Value = imagen;
        }

        private void Tablero2_Load(object sender, EventArgs e)
        {
            dataTablero2.Columns[0].Width = 100;
            dataTablero2.Columns[1].Width = 100;
            dataTablero2.Columns[2].Width = 100;
            dataTablero2.Columns[3].Width = 100;
            dataTablero2.RowTemplate.Height = 50;

            dataTablero2.Rows.Add(4);
            dataTablero2.ClearSelection();

            llenarTablero();
            llenarPersonaje();
        }

        private void data2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            switch (this.dataTablero2.Columns[e.ColumnIndex].Name)
            {
                case "Columna1":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (Exception exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "Columna2":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (Exception exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "Columna3":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (Exception exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
                case "Columna4":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (Exception exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
            }
        }

        private void dataTablero2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    txtPrueba.Text = "Hola mundo XD";
                    if (posx1 == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        dataTablero2[posx1, posy1].Value = cuadroBlanco;
                        posx1 -= 1;
                        Mover(posx1, posy1);
                    }
                    break;
                case Keys.D:
                    txtPrueba.Text = "Hola mundo XD";
                    if (posx1 == 3)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        dataTablero2[posx1, posy1].Value = cuadroBlanco;
                        posx1 += 1;
                        Mover(posx1, posy1);
                    }
                    break;
                case Keys.S:
                    txtPrueba.Text = "Hola mundo XD";
                    if (posy1 == 3)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        dataTablero2[posx1, posy1].Value = cuadroBlanco;
                        posy1 += 1;
                        Mover(posx1, posy1);
                    }
                    break;
                case Keys.W:
                    txtPrueba.Text = "Hola mundo XD";
                    if (posy1 == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        dataTablero2[posx1, posy1].Value = cuadroBlanco;
                        posy1 -= 1;
                        Mover(posx1, posy1);
                    }
                    break;
            }
        }
    }
}
