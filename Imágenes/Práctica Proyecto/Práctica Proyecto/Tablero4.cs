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
    public partial class Tablero4 : Form
    {
        public static object imagen;
        public static string nombre;
        public static int puntos4;
        Random r = new Random();
        object cuadroBlanco = @"C:\Users\Pcuevas2026\Desktop\Tablero3\cuadroblancoTab3.png";
        object galleta = @"C:\Users\Pcuevas2026\Desktop\Tablero3\galletaTab3.png";
        object portal = @"C:\Users\Pcuevas2026\Desktop\Tablero3\portalTab3.png";
        object dinosaur = @"C:\Users\Pcuevas2026\Desktop\Tablero4\DinosaurTb4.png";

        int posx = 0, posy = 0, contSumar = 0;
        public static int contadorGalletas4 = 0;

        public Tablero4()
        {
            InitializeComponent();
        }

        public void llenarTablero()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    dataTablero4[i, j].Value = cuadroBlanco;
                }
            }
        }

        public void llenarPersonaje()
        {
            dataTablero4[0, 0].Value = imagen;
        }

        public void Mover(int PosX, int PosY)
        {
            dataTablero4[PosX, PosY].Value = imagen;
        }

        public void llenarGalleta()
        {
            int ContadorGalletas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 6);
                j = r.Next(0, 6);
                if ((dataTablero4[i, j].Value == cuadroBlanco) && ContadorGalletas < 6)
                {
                    dataTablero4[i, j].Value = galleta;
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
                i = r.Next(0, 6);
                j = r.Next(0, 6);
                if ((dataTablero4[i, j].Value == cuadroBlanco) && ContadorRawr < 7)
                {
                    dataTablero4[i, j].Value = dinosaur;
                    ContadorRawr++;
                }
            } while (ContadorRawr < 7);
        }

        public void llenarDinosaurSolo1()
        {
            int ContadorDinosaur = 0;
            int i, j;
            do
            {
                i = r.Next(0, 4);
                j = r.Next(0, 4);
                if ((dataTablero4[i, j].Value == cuadroBlanco) && ContadorDinosaur < 1)
                {
                    dataTablero4[i, j].Value = dinosaur;
                    ContadorDinosaur++;
                }
            } while (ContadorDinosaur < 1);
        }

        public void PonerPortal()
        {
            int ContadorPortal = 0;
            int i, j;
            do
            {
                i = r.Next(0, 6);
                j = r.Next(0, 6);
                if ((dataTablero4[i, j].Value == cuadroBlanco) && ContadorPortal < 1)
                {
                    dataTablero4[i, j].Value = portal;
                    ContadorPortal++;
                }
            } while (ContadorPortal < 1);
        }

        private void Tablero4_Load(object sender, EventArgs e)
        {
            dataTablero4.Rows.Add(6);
            dataTablero4.ClearSelection();

            llenarTablero();
            llenarPersonaje();
            llenarGalleta();
            PonerPortal();
            llenarRawr();

            lblContador.Text = 0.ToString();
            labelpuntos.Text = 0.ToString();
            labelName4.Text = nombre;
            //lblName.Text = nombre;
        }

        private void buttonEstaA_Click(object sender, EventArgs e)
        {
            EstadoAvatar forma8 = new EstadoAvatar();
            forma8.ShowDialog();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            string puntosTotales = " ";
            puntosTotales += Tablero1.puntos1 + Tablero21.puntos2 + Tablero31.puntos3 + puntos4;
            MessageBox.Show("Tus puntos obtenidos son: " + puntosTotales);
            //
            Tablero1.contadorGalletas1 = 0;
            Tablero1.puntos1 = 0;
            Tablero21.contadorGalletas2 = 0;
            Tablero21.puntos2 = 0;
            Tablero31.contadorGalletas3 = 0;
            Tablero31.puntos3 = 0;
            contadorGalletas4 = 0;
            puntos4 = 0;
            //
            this.Hide();
            TabInicio forma7 = new TabInicio();
            forma7.ShowDialog();
           
        }

        private void buttonComand_Click(object sender, EventArgs e)
        {
            Comandos forma8 = new Comandos();
            forma8.ShowDialog();
        }

        private void dataTablero4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            switch (this.dataTablero4.Columns[e.ColumnIndex].Name)
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
            }
        }

        private void dataTablero4_KeyUp(object sender, KeyEventArgs e)
        {
            labelpuntos.Text = puntos4.ToString();
            switch (e.KeyData)
            {
                case Keys.A:
                    if (posx == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero4[posx - 1, posy].Value == galleta)
                        {
                            contadorGalletas4++;
                            puntos4 += 15;
                            contSumar++;
                            lblContador.Text = contadorGalletas4.ToString();
                            labelpuntos.Text = puntos4.ToString();
                        }
                        if (dataTablero4[posx - 1, posy].Value == dinosaur)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarDinosaurSolo1();
                        }

                        if ((dataTablero4[posx - 1, posy].Value == portal) && (contadorGalletas4 == 6))
                        {
                            puntos4 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero5 forma6 = new Tablero5();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero4[posx - 1, posy].Value == portal) && (contadorGalletas4 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos4 -= 5;
                                labelpuntos.Text = puntos4.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero4[posx - 1, posy].Value != portal) || ((dataTablero4[posx - 1, posy].Value == portal) && (contadorGalletas4 != 6)))
                        {
                            dataTablero4[posx, posy].Value = cuadroBlanco;
                            posx -= 1;
                            Mover(posx, posy);
                        }                 
                    }
                    break;
                case Keys.D:
                    if (posx == 5)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero4[posx + 1, posy].Value == galleta)
                        {
                            contadorGalletas4++;
                            puntos4 += 15;
                            contSumar++;
                            lblContador.Text = contadorGalletas4.ToString();
                            labelpuntos.Text = puntos4.ToString();
                        }
                        if (dataTablero4[posx + 1, posy].Value == dinosaur)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarDinosaurSolo1();
                        }

                        if ((dataTablero4[posx + 1, posy].Value == portal) && (contadorGalletas4 == 6))
                        {
                            puntos4 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero5 forma6 = new Tablero5();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero4[posx + 1, posy].Value == portal) && (contadorGalletas4 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos4 -= 5;
                                labelpuntos.Text = puntos4.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero4[posx + 1, posy].Value != portal) || ((dataTablero4[posx + 1, posy].Value == portal) && (contadorGalletas4 != 6)))
                        {
                            dataTablero4[posx, posy].Value = cuadroBlanco;
                            posx += 1;
                            Mover(posx, posy);
                        }
                    }
                    break;
                case Keys.S:
                    if (posy == 5)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero4[posx, posy + 1].Value == galleta)
                        {
                            contadorGalletas4++;
                            puntos4 += 15;
                            contSumar++;
                            lblContador.Text = contadorGalletas4.ToString();
                            labelpuntos.Text = puntos4.ToString();
                        }
                        if (dataTablero4[posx, posy + 1].Value == dinosaur)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarDinosaurSolo1();
                        }

                        if ((dataTablero4[posx, posy + 1].Value == portal) && (contadorGalletas4 == 6))
                        {
                            puntos4 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero5 forma6 = new Tablero5();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero4[posx, posy + 1].Value == portal) && (contadorGalletas4 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos4 -= 5;
                                labelpuntos.Text = puntos4.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero4[posx, posy + 1].Value != portal) || ((dataTablero4[posx, posy + 1].Value == portal) && (contadorGalletas4 != 6)))
                        {
                            dataTablero4[posx, posy].Value = cuadroBlanco;
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

                        if (dataTablero4[posx, posy - 1].Value == galleta)
                        {
                            contadorGalletas4++;
                            puntos4 += 15;
                            contSumar++;
                            lblContador.Text = contadorGalletas4.ToString();
                            labelpuntos.Text = puntos4.ToString();
                        }
                        if (dataTablero4[posx, posy - 1].Value == dinosaur)
                        {
                            Preguntas forma7 = new Preguntas();
                            forma7.Show();
                            llenarDinosaurSolo1();
                        }

                        if ((dataTablero4[posx, posy - 1].Value == portal) && (contadorGalletas4 == 6))
                        {
                            puntos4 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero5 forma6 = new Tablero5();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero4[posx, posy - 1].Value == portal) && (contadorGalletas4 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos4 -= 5;
                                labelpuntos.Text = puntos4.ToString();
                                PonerPortal();
                            }
                        }
                        if ((dataTablero4[posx, posy - 1].Value != portal) || ((dataTablero4[posx, posy - 1].Value == portal) && (contadorGalletas4 != 6)))
                        {
                            dataTablero4[posx, posy].Value = cuadroBlanco;
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
