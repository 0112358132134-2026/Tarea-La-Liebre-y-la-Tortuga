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
    public partial class Tablero31 : Form
    {
        public static object imagen;
        public static int puntos3;
        public static string nombre;
        Random r = new Random();
        object cuadroBlanco = @"C:\Users\Pcuevas2026\Desktop\Tablero3\cuadroblancoTab3.png";
        object galleta = @"C:\Users\Pcuevas2026\Desktop\Tablero3\galletaTab3.png";
        object portal = @"C:\Users\Pcuevas2026\Desktop\Tablero3\portalTab3.png";
        object rawr = @"C:\Users\Pcuevas2026\Desktop\Tablero3\rawrTab3.png";

        int posx = 0, posy = 0, contSumar = 0;
        public static int contadorGalletas3 = 0;

        public Tablero31()
        {
            InitializeComponent();
        }

        public void llenarTablero()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataTablero3[i, j].Value = cuadroBlanco;
                }
            }
        }

        public void llenarPersonaje()
        {
            dataTablero3[0, 0].Value = imagen;
        }

        public void Mover(int Posx, int Posy)
        {
            dataTablero3[Posx, Posy].Value = imagen;
        }

        public void llenarGalleta()
        {
            int ContadorGalletas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 5);
                j = r.Next(0, 5);
                if ((dataTablero3[i, j].Value == cuadroBlanco) && ContadorGalletas < 6)
                {
                    dataTablero3[i, j].Value = galleta;
                    ContadorGalletas++;
                }
            } while (ContadorGalletas < 6);
        }

        public void llenarRawr()
        {
            int ContadorRawr = 0;
            int i, j;
            do
            {
                i = r.Next(0, 5);
                j = r.Next(0, 5);
                if ((dataTablero3[i, j].Value == cuadroBlanco) && ContadorRawr < 4)
                {
                    dataTablero3[i, j].Value = rawr;
                    ContadorRawr++;
                }
            } while(ContadorRawr < 4);
        }

        public void llenarRawrSolo1()
        {
            int ContadorRawr = 0;
            int i, j;
            do
            {
                i = r.Next(0, 4);
                j = r.Next(0, 4);
                if ((dataTablero3[i, j].Value == cuadroBlanco) && ContadorRawr < 1)
                {
                    dataTablero3[i, j].Value = rawr;
                    ContadorRawr++;
                }
            } while (ContadorRawr < 1);
        }

        public void PonerPortal()
        {
            int ContadorPortal = 0;
            int i, j;
            do
            {
                i = r.Next(0, 5);
                j = r.Next(0, 5);
                if ((dataTablero3[i, j].Value == cuadroBlanco) && ContadorPortal < 1)
                {
                    dataTablero3[i, j].Value = portal;
                    ContadorPortal++;
                }
            } while (ContadorPortal < 1);
        }

        private void Tablero31_Load(object sender, EventArgs e)
        {
            dataTablero3.Rows.Add(5);
            dataTablero3.ClearSelection();

            llenarTablero();
            llenarPersonaje();
            llenarGalleta();
            PonerPortal();
            llenarRawr();

            lblGalletitas.Text = 0.ToString();
            lblPuntos.Text = 0.ToString();
            lblName.Text = nombre;

        }

        private void btnComandos_Click(object sender, EventArgs e)
        {
            Comandos forma8 = new Comandos();
            forma8.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string puntosTotales = " ";
            puntosTotales += Tablero1.puntos1 + Tablero21.puntos2 + puntos3;
            MessageBox.Show("Tus puntos obtenidos son: " + puntosTotales);
            //
            contadorGalletas3 = 0;
            puntos3 = 0;
            Tablero1.contadorGalletas1 = 0;
            Tablero1.puntos1 = 0;
            Tablero21.contadorGalletas2 = 0;
            Tablero21.puntos2 = 0;
            Tablero4.contadorGalletas4 = 0;
            Tablero4.puntos4 = 0;
            //
            this.Hide();
            TabInicio forma7 = new TabInicio();
            forma7.ShowDialog();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            EstadoAvatar forma8 = new EstadoAvatar();
            forma8.ShowDialog();
        }

        private void dataTablero3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dataTablero3.Columns[e.ColumnIndex].Name)
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
            }
        }

        private void dataTablero3_KeyUp(object sender, KeyEventArgs e)
        {
            lblPuntos.Text = puntos3.ToString();
            switch (e.KeyData)
            {
                case Keys.A:
                    if (posx == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero3[posx - 1, posy].Value == galleta)
                        {
                            contadorGalletas3++;
                            puntos3 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas3.ToString();
                            lblPuntos.Text = puntos3.ToString();
                        }
                        if (dataTablero3[posx - 1, posy].Value == rawr)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarRawrSolo1();
                        }

                        if ((dataTablero3[posx - 1, posy].Value == portal) && (contadorGalletas3 == 6))
                        {
                            puntos3 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero4 forma6 = new Tablero4();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero3[posx - 1, posy].Value == portal) && (contadorGalletas3 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos3 -= 5;
                                lblPuntos.Text = puntos3.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero3[posx - 1, posy].Value != portal) || ((dataTablero3[posx - 1, posy].Value == portal) && (contadorGalletas3 != 6)))
                        {
                            dataTablero3[posx, posy].Value = cuadroBlanco;
                            posx -= 1;
                            Mover(posx, posy);
                        }                   
                    }
                    break;
                case Keys.D:
                    if (posx == 4)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero3[posx + 1, posy].Value == galleta)
                        {
                            contadorGalletas3++;
                            puntos3 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas3.ToString();
                            lblPuntos.Text = puntos3.ToString();
                        }
                        if (dataTablero3[posx + 1, posy].Value == rawr)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarRawrSolo1();
                        }

                        if ((dataTablero3[posx + 1, posy].Value == portal) && (contadorGalletas3 == 6))
                        {
                            puntos3 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero4 forma6 = new Tablero4();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero3[posx + 1, posy].Value == portal) && (contadorGalletas3 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos3 -= 5;
                                lblPuntos.Text = puntos3.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero3[posx + 1, posy].Value != portal) || ((dataTablero3[posx + 1, posy].Value == portal) && (contadorGalletas3 != 6)))
                        {
                            dataTablero3[posx, posy].Value = cuadroBlanco;
                            posx += 1;
                            Mover(posx, posy);
                        }
                    }
                    break;
                case Keys.S:
                    if (posy == 4)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero3[posx, posy + 1].Value == galleta)
                        {
                            contadorGalletas3++;
                            puntos3 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas3.ToString();
                            lblPuntos.Text = puntos3.ToString();
                        }
                        if (dataTablero3[posx, posy + 1].Value == rawr)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarRawrSolo1();
                        }

                        if ((dataTablero3[posx, posy + 1].Value == portal) && (contadorGalletas3 == 6))
                        {
                            puntos3 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero4 forma6 = new Tablero4();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero3[posx, posy + 1].Value == portal) && (contadorGalletas3 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos3 -= 5;
                                lblPuntos.Text = puntos3.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero3[posx, posy + 1].Value != portal) || ((dataTablero3[posx, posy + 1].Value == portal) && (contadorGalletas3 != 6)))
                        {
                            dataTablero3[posx, posy].Value = cuadroBlanco;
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

                        if (dataTablero3[posx, posy - 1].Value == galleta)
                        {
                            contadorGalletas3++;
                            puntos3 += 15;
                            contSumar++;
                            lblGalletitas.Text = contadorGalletas3.ToString();
                            lblPuntos.Text = puntos3.ToString();
                        }
                        if (dataTablero3[posx, posy - 1].Value == rawr)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarRawrSolo1();
                        }

                        if ((dataTablero3[posx, posy - 1].Value == portal) && (contadorGalletas3 == 6))
                        {
                            puntos3 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero4 forma6 = new Tablero4();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero3[posx, posy - 1].Value == portal) && (contadorGalletas3 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos3 -= 5;
                                lblPuntos.Text = puntos3.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero3[posx, posy - 1].Value != portal) || ((dataTablero3[posx, posy - 1].Value == portal) && (contadorGalletas3 != 6)))
                        {
                            dataTablero3[posx, posy].Value = cuadroBlanco;
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
