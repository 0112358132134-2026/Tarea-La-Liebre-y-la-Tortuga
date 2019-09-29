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
    public partial class Tablero5 : Form
    {
        public static object imagen;
        public static string nombre;
        Random r = new Random();
        object cuadroBlanco = @"C:\Users\Pcuevas2026\Desktop\Tablero5\cuadroblancoTab5.png";
        object galleta = @"C:\Users\Pcuevas2026\Desktop\Tablero5\galletaTab5.png";
        object portal = @"C:\Users\Pcuevas2026\Desktop\Tablero5\portalTab5.png";
        object Trez = @"C:\Users\Pcuevas2026\Desktop\Tablero5\PusheenRex.png";

        int posx = 0, posy = 0;
        public static int contadorGalletas5 = 0;

        public static int puntos5 = 0;
        int contSumar = 0;

        public Tablero5()
        {
            InitializeComponent();
        }

        public void llenarTablero()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataTablero5[i, j].Value = cuadroBlanco;
                }
            }
        }

        public void llenarPersonaje()
        {
            dataTablero5[0, 0].Value = imagen;
        }

        public void Mover(int PosX, int PosY)
        {
            dataTablero5[PosX, PosY].Value = imagen;
        }

        public void llenarGalleta()
        {
            int ContadorGalletas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 10);
                j = r.Next(0, 10);
                if ((dataTablero5[i, j].Value == cuadroBlanco) && ContadorGalletas < 6)
                {
                    dataTablero5[i, j].Value = galleta;
                    ContadorGalletas++;
                }
            } while (ContadorGalletas < 6);
        }

        public void llenarTrez()
        {
            int ContadorCabesitas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 10);
                j = r.Next(0, 10);
                if ((dataTablero5[i, j].Value == cuadroBlanco) && ContadorCabesitas < 12)
                {
                    dataTablero5[i, j].Value = Trez;
                    ContadorCabesitas++;
                }
            } while (ContadorCabesitas < 12);
        }

        public void llenarTrezSolo1()
        {
            int ContadorCabesitas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 10);
                j = r.Next(0, 10);
                if ((dataTablero5[i, j].Value == cuadroBlanco) && ContadorCabesitas < 1)
                {
                    dataTablero5[i, j].Value = Trez;
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
                i = r.Next(0, 10);
                j = r.Next(0, 10);
                if ((dataTablero5[i, j].Value == cuadroBlanco) && ContadorPortal < 1)
                {
                    dataTablero5[i, j].Value = portal;
                    ContadorPortal++;
                }
            } while (ContadorPortal < 1);
        }

        private void Tablero5_Load(object sender, EventArgs e)
        {
            dataTablero5.Rows.Add(10);
            dataTablero5.ClearSelection();

            llenarTablero();
            llenarPersonaje();
            llenarGalleta();
            PonerPortal();
            llenarTrez();

            labelCokie.Text = 0.ToString();
            labelPuntos.Text = 0.ToString();
            lblName.Text = nombre;
        }

        private void dataTablero5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dataTablero5.Columns[e.ColumnIndex].Name)
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
                case "Columna5":
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
                case "Columna6":
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
                case "Columna7":
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
                case "Columna8":
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
                case "Columna9":
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
                case "Columna10":
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

        private void btnComandos_Click(object sender, EventArgs e)
        {
            Comandos forma8 = new Comandos();
            forma8.ShowDialog();
        }

        private void btnEstadoA_Click(object sender, EventArgs e)
        {
            EstadoAvatar forma8 = new EstadoAvatar();
            forma8.ShowDialog();
        }

        private void btnTerminarP_Click(object sender, EventArgs e)
        {
            string puntosTotales = " ";
            puntosTotales += Tablero1.puntos1 + Tablero21.puntos2 + Tablero31.puntos3 + Tablero4.puntos4 + puntos5;
            MessageBox.Show("Tus puntos obtenidos son: " + puntosTotales);
            //
            contadorGalletas5 = 0;
            puntos5 = 0;
            Tablero1.contadorGalletas1 = 0;
            Tablero1.puntos1 = 0;
            Tablero21.contadorGalletas2 = 0;
            Tablero21.puntos2 = 0;
            Tablero31.contadorGalletas3 = 0;
            Tablero31.puntos3 = 0;
            Tablero4.contadorGalletas4 = 0;
            Tablero4.puntos4 = 0;
            this.Hide();
            TabInicio forma7 = new TabInicio();
            forma7.ShowDialog();
        }

        private void dataTablero5_KeyUp(object sender, KeyEventArgs e)
        {
            labelPuntos.Text = puntos5.ToString();
            switch (e.KeyData)
            {
                case Keys.A:
                    if (posx == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero5[posx - 1, posy].Value == galleta)
                        {
                            contadorGalletas5++;
                            puntos5 += 15;
                            contSumar++;
                            labelCokie.Text = contadorGalletas5.ToString();
                            labelPuntos.Text = puntos5.ToString();
                        }
                        if (dataTablero5[posx - 1, posy].Value == Trez)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarTrezSolo1();
                        }

                        if ((dataTablero5[posx - 1, posy].Value == portal) && (contadorGalletas5 == 6))
                        {
                            puntos5 += 1000;
                            string puntosTotales = " ";
                            puntosTotales += Tablero1.puntos1 + Tablero21.puntos2 + Tablero31.puntos3 + Tablero4.puntos4 + puntos5;
                            MessageBox.Show("¡Haz ganado!, tu puntuación ha sido de: " + puntosTotales);
                            this.Hide();
                            TabInicio forma6 = new TabInicio();
                            forma6.Show();
                            //
                            contadorGalletas5 = 0;
                            puntos5 = 0;
                            Tablero1.contadorGalletas1 = 0;
                            Tablero1.puntos1 = 0;
                            Tablero21.contadorGalletas2 = 0;
                            Tablero21.puntos2 = 0;
                            Tablero31.contadorGalletas3 = 0;
                            Tablero31.puntos3 = 0;
                            Tablero4.contadorGalletas4 = 0;
                            Tablero4.puntos4 = 0;
                        }
                        else
                        {
                            if ((dataTablero5[posx - 1, posy].Value == portal) && (contadorGalletas5 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos5 -= 5;
                                labelPuntos.Text = puntos5.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero5[posx - 1, posy].Value != portal) || ((dataTablero5[posx - 1, posy].Value == portal) && (contadorGalletas5 != 6)))
                        {
                            dataTablero5[posx, posy].Value = cuadroBlanco;
                            posx -= 1;
                            Mover(posx, posy);
                        }
                    }
                    break;
                case Keys.D:
                    if (posx == 9)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero5[posx + 1, posy].Value == galleta)
                        {
                            contadorGalletas5++;
                            puntos5 += 15;
                            contSumar++;
                            labelCokie.Text = contadorGalletas5.ToString();
                            labelPuntos.Text = puntos5.ToString();
                        }
                        if (dataTablero5[posx + 1, posy].Value == Trez)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarTrezSolo1();
                        }

                        if ((dataTablero5[posx + 1, posy].Value == portal) && (contadorGalletas5 == 6))
                        {
                            puntos5 += 1000;
                            string puntosTotales = " ";
                            puntosTotales += Tablero1.puntos1 + Tablero21.puntos2 + Tablero31.puntos3 + Tablero4.puntos4 + puntos5;
                            MessageBox.Show("¡Haz ganado!, tu puntuación ha sido de: " + puntosTotales);
                            this.Hide();
                            TabInicio forma6 = new TabInicio();
                            forma6.Show();
                            //
                            contadorGalletas5 = 0;
                            puntos5 = 0;
                            Tablero1.contadorGalletas1 = 0;
                            Tablero1.puntos1 = 0;
                            Tablero21.contadorGalletas2 = 0;
                            Tablero21.puntos2 = 0;
                            Tablero31.contadorGalletas3 = 0;
                            Tablero31.puntos3 = 0;
                            Tablero4.contadorGalletas4 = 0;
                            Tablero4.puntos4 = 0;
                        }
                        else
                        {
                            if ((dataTablero5[posx + 1, posy].Value == portal) && (contadorGalletas5 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos5 -= 5;
                                labelPuntos.Text = puntos5.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero5[posx + 1, posy].Value != portal) || ((dataTablero5[posx + 1, posy].Value == portal) && (contadorGalletas5 != 6)))
                        {
                            dataTablero5[posx, posy].Value = cuadroBlanco;
                            posx += 1;
                            Mover(posx, posy);
                        }
                    }
                    break;
                case Keys.S:
                    if (posy == 9)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero5[posx, posy + 1].Value == galleta)
                        {
                            contadorGalletas5++;
                            puntos5 += 15;
                            contSumar++;
                            labelCokie.Text = contadorGalletas5.ToString();
                            labelPuntos.Text = puntos5.ToString();
                        }
                        if (dataTablero5[posx, posy + 1].Value == Trez)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarTrezSolo1();
                        }

                        if ((dataTablero5[posx, posy + 1].Value == portal) && (contadorGalletas5 == 6))
                        {
                            puntos5 += 1000;
                            string puntosTotales = " ";
                            puntosTotales += Tablero1.puntos1 + Tablero21.puntos2 + Tablero31.puntos3 + Tablero4.puntos4 + puntos5;
                            MessageBox.Show("¡Haz ganado!, tu puntuación ha sido de: " + puntosTotales);
                            this.Hide();
                            TabInicio forma6 = new TabInicio();
                            forma6.Show();
                            //
                            contadorGalletas5 = 0;
                            puntos5 = 0;
                            Tablero1.contadorGalletas1 = 0;
                            Tablero1.puntos1 = 0;
                            Tablero21.contadorGalletas2 = 0;
                            Tablero21.puntos2 = 0;
                            Tablero31.contadorGalletas3 = 0;
                            Tablero31.puntos3 = 0;
                            Tablero4.contadorGalletas4 = 0;
                            Tablero4.puntos4 = 0;
                        }
                        else
                        {
                            if ((dataTablero5[posx, posy + 1].Value == portal) && (contadorGalletas5 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos5 -= 5;
                                labelPuntos.Text = puntos5.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero5[posx, posy + 1].Value != portal) || ((dataTablero5[posx, posy + 1].Value == portal) && (contadorGalletas5 != 6)))
                        {
                            dataTablero5[posx, posy].Value = cuadroBlanco;
                            posy += 1;
                            Mover(posx, posy);
                        }
                    }
                    break;
                case Keys.W:
                    if (posy == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero5[posx, posy - 1].Value == galleta)
                        {
                            contadorGalletas5++;
                            puntos5 += 15;
                            contSumar++;
                            labelCokie.Text = contadorGalletas5.ToString();
                            labelPuntos.Text = puntos5.ToString();
                        }
                        if (dataTablero5[posx, posy - 1].Value == Trez)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarTrezSolo1();
                        }

                        if ((dataTablero5[posx, posy - 1].Value == portal) && (contadorGalletas5 == 6))
                        {
                            puntos5 += 1000;
                            string puntosTotales = " ";
                            puntosTotales += Tablero1.puntos1 + Tablero21.puntos2 + Tablero31.puntos3 + Tablero4.puntos4 + puntos5;
                            MessageBox.Show("¡Haz ganado!, tu puntuación ha sido de: " + puntosTotales);
                            this.Hide();
                            TabInicio forma6 = new TabInicio();
                            forma6.Show();
                            //
                            contadorGalletas5 = 0;
                            puntos5 = 0;
                            Tablero1.contadorGalletas1 = 0;
                            Tablero1.puntos1 = 0;
                            Tablero21.contadorGalletas2 = 0;
                            Tablero21.puntos2 = 0;
                            Tablero31.contadorGalletas3 = 0;
                            Tablero31.puntos3 = 0;
                            Tablero4.contadorGalletas4 = 0;
                            Tablero4.puntos4 = 0;
                        }
                        else
                        {
                            if ((dataTablero5[posx, posy - 1].Value == portal) && (contadorGalletas5 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos5 -= 5;
                                labelPuntos.Text = puntos5.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero5[posx, posy - 1].Value != portal) || ((dataTablero5[posx, posy - 1].Value == portal) && (contadorGalletas5 != 6)))
                        {
                            dataTablero5[posx, posy].Value = cuadroBlanco;
                            posy -= 1;
                            Mover(posx, posy);
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
