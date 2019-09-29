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
    public partial class Tablero21 : Form
    {
        public static object imagen;
        public static int puntos2;
        public static bool cabesitasItsTrue;
        public static string nombre;
        Random r = new Random();
        object cuadroBlanco = @"C:\Users\Pcuevas2026\Desktop\cuadroblanco3.png";
        object galleta = @"C:\Users\Pcuevas2026\Desktop\galletaTab2.png";
        object portal = @"C:\Users\Pcuevas2026\Desktop\portalTab2.png";
        object cabesitas = @"C:\Users\Pcuevas2026\Desktop\cabesitas.png";

        int posx1 = 0, posy1 = 0, contSumar = 0;
        public static int contadorGalletas2 = 0;

        public Tablero21()
        {
            InitializeComponent();
        }

        public void llenarTablero()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataTablero21[i, j].Value = cuadroBlanco;
                }
            }
        }

        public void llenarPersonaje()
        {
            dataTablero21[0, 0].Value = imagen;
        }

        public void Mover(int PosX1, int PosY1)
        {
            dataTablero21[PosX1, PosY1].Value = imagen;
        }

        public void llenarGalleta()
        {
            int ContadorGalletas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 4);
                j = r.Next(0, 4);
                if ((dataTablero21[i, j].Value == cuadroBlanco) && ContadorGalletas < 6)
                {
                    dataTablero21[i, j].Value = galleta;
                    ContadorGalletas++;
                }
            } while (ContadorGalletas < 6);
        }

        public void llenarCabesitas()
        {
            int ContadorCabesitas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 4);
                j = r.Next(0, 4);
                if ((dataTablero21[i, j].Value == cuadroBlanco) && ContadorCabesitas < 1)
                {
                    dataTablero21[i, j].Value = cabesitas;
                    ContadorCabesitas++;
                }
            } while (ContadorCabesitas < 1);
        }
        
        public void PonerPortal()
        {
            int ContadorPortal = 0;
            int i, j;
            do
            {
                i = r.Next(0, 4);
                j = r.Next(0, 4);
                if ((dataTablero21[i, j].Value == cuadroBlanco) && ContadorPortal < 1)
                {
                    dataTablero21[i, j].Value = portal;
                    ContadorPortal++;
                }
            } while (ContadorPortal < 1);
            //dataTablero21[2, 2].Value = portal;
        }

        private void Tablero21_Load(object sender, EventArgs e)
        {
            dataTablero21.Rows.Add(4);
            dataTablero21.ClearSelection();

            llenarTablero();
            llenarPersonaje();
            llenarGalleta();
            PonerPortal();
            llenarCabesitas();

            lblGalletitas.Text = 0.ToString();
            lblPuntos.Text = 0.ToString();
            labelName.Text = nombre;
        }

        private void btnTerminarP_Click(object sender, EventArgs e)
        {
            string puntosTotales = " ";
            puntosTotales += Tablero1.puntos1 + puntos2;
            MessageBox.Show("Tus puntos obtenidos son: " + puntosTotales);
            //
            contadorGalletas2 = 0;
            puntos2 = 0;
            Tablero1.contadorGalletas1 = 0;
            Tablero1.puntos1 = 0;
            Tablero31.contadorGalletas3 = 0;
            Tablero31.puntos3 = 0;
            Tablero4.contadorGalletas4 = 0;
            Tablero4.puntos4 = 0;
            this.Hide();
            TabInicio forma7 = new TabInicio();
            forma7.ShowDialog();          
        }

        private void btnComandos_Click(object sender, EventArgs e)
        {
            Comandos forma8 = new Comandos();
            forma8.ShowDialog();
        }

        private void btnEstadoAv_Click(object sender, EventArgs e)
        {
            EstadoAvatar forma8 = new EstadoAvatar();
            forma8.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dataTablero21.Columns[e.ColumnIndex].Name)
            {
                case "Columna21":
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
                case "Columna22":
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
                case "Columna23":
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
                case "Columna24":
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

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            lblPuntos.Text = puntos2.ToString();
            switch (e.KeyData)
            {
                case Keys.A:
                    if (posx1 == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero21[posx1 - 1, posy1].Value == galleta)
                        {
                            contadorGalletas2++;
                            puntos2 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas2.ToString();
                            lblPuntos.Text = puntos2.ToString();
                        }
                        //Verifica si toca al monstruo:
                        if (dataTablero21[posx1 - 1, posy1].Value == cabesitas)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarCabesitas();
                        }

                        if ((dataTablero21[posx1 - 1, posy1].Value == portal) && (contadorGalletas2 == 6))
                        {
                            puntos2 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero31 forma6 = new Tablero31();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero21[posx1 - 1, posy1].Value == portal) && (contadorGalletas2 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos2 -= 5;
                                lblPuntos.Text = puntos2.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero21[posx1 - 1, posy1].Value != portal) || ((dataTablero21[posx1 - 1, posy1].Value == portal) && (contadorGalletas2 != 6)) || (dataTablero21[posx1 - 1, posy1].Value == cabesitas) && cabesitasItsTrue == true)
                        {
                            dataTablero21[posx1, posy1].Value = cuadroBlanco;
                            posx1 -= 1;
                            Mover(posx1, posy1);
                        }
                    }
                    break;
                case Keys.D:
                    if (posx1 == 3)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero21[posx1 +1, posy1].Value == galleta)
                        {
                            contadorGalletas2++;
                            puntos2 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas2.ToString();
                            lblPuntos.Text = puntos2.ToString();
                        }
                        if (dataTablero21[posx1 + 1, posy1].Value == cabesitas)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarCabesitas();
                        }

                        if ((dataTablero21[posx1 + 1, posy1].Value == portal) && (contadorGalletas2 == 6))
                        {
                            puntos2 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero31 forma6 = new Tablero31();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero21[posx1 + 1, posy1].Value == portal) && (contadorGalletas2 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos2 -= 5;
                                lblPuntos.Text = puntos2.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero21[posx1 + 1, posy1].Value != portal) || ((dataTablero21[posx1 + 1, posy1].Value == portal) && (contadorGalletas2 != 6)) || (dataTablero21[posx1 + 1, posy1].Value == cabesitas) && cabesitasItsTrue == true)
                        {
                            dataTablero21[posx1, posy1].Value = cuadroBlanco;
                            posx1 += 1;
                            Mover(posx1, posy1);
                        }
                    }
                    break;
                case Keys.S:
                    if (posy1 == 3)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero21[posx1, posy1 + 1].Value == galleta)
                        {
                            contadorGalletas2++;
                            puntos2 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas2.ToString();
                            lblPuntos.Text = puntos2.ToString();
                        }
                        if (dataTablero21[posx1, posy1 + 1].Value == cabesitas)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarCabesitas();
                        }

                        if ((dataTablero21[posx1, posy1 +1].Value == portal) && (contadorGalletas2 == 6))
                        {
                            puntos2 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero31 forma6 = new Tablero31();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero21[posx1, posy1 + 1].Value == portal) && (contadorGalletas2 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos2 -= 5;
                                lblPuntos.Text = puntos2.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero21[posx1, posy1 + 1].Value != portal) || ((dataTablero21[posx1, posy1 + 1].Value == portal) && (contadorGalletas2 != 6)) || (dataTablero21[posx1, posy1 + 1].Value == cabesitas) && cabesitasItsTrue == true)
                        {
                            dataTablero21[posx1, posy1].Value = cuadroBlanco;
                            posy1 += 1;
                            Mover(posx1, posy1);
                        }
                    }
                    break;
                case Keys.W:
                    if (posy1 == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero21[posx1, posy1 - 1].Value == galleta)
                        {
                            contadorGalletas2++;
                            puntos2 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas2.ToString();
                            lblPuntos.Text = puntos2.ToString();
                        }
                        if (dataTablero21[posx1, posy1 - 1].Value == cabesitas)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarCabesitas();
                        }

                        if ((dataTablero21[posx1, posy1 - 1].Value == portal) && (contadorGalletas2 == 6))
                        {
                            puntos2 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero31 forma6 = new Tablero31();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero21[posx1, posy1 - 1].Value == portal) && (contadorGalletas2 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos2 -= 5;
                                lblPuntos.Text = puntos2.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero21[posx1, posy1 - 1].Value != portal) || ((dataTablero21[posx1, posy1 - 1].Value == portal) && (contadorGalletas2 != 6)) || (dataTablero21[posx1, posy1 - 1].Value == cabesitas) && cabesitasItsTrue == true)
                        {
                            dataTablero21[posx1, posy1].Value = cuadroBlanco;
                            posy1 -= 1;
                            Mover(posx1, posy1);
                        }
                    }
                    break;
            }
            if (contSumar == 6)
            {
                MessageBox.Show("¡Ya puedes ingresar al portal!");
                contSumar++;
            }
        }
    }
}
