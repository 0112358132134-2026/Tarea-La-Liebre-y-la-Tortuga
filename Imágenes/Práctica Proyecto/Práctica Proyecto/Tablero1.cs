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
    public partial class Tablero1 : Form
    {
        public static object imagen;
        public static string nombre;
        Random r = new Random();
        object cuadroBlanco = @"C:\Users\Pcuevas2026\Desktop\cuadroblanco.png";
        object galleta = @"C:\Users\Pcuevas2026\Desktop\galleta.png";
        object portal = @"C:\Users\Pcuevas2026\Desktop\portal.png";

        int posx = 0, posy = 0;
        //Sumatoria de galletas recolectadas
        public static int contadorGalletas1 = 0;

        public static int puntos1 = 0;
        int contSumar = 0;
        //La última variable es para mostrar el mensaje de "¡Ya puedes ingresar al portal!"

        public Tablero1()
        {
            InitializeComponent();
        }

        public void llenarTablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataTablero1[i, j].Value = cuadroBlanco;
                }
            }
        }

        public void llenarPersonaje()
        {
            dataTablero1[0, 0].Value = imagen;
        }

        public void Mover(int PosX, int PosY)
        {
            dataTablero1[PosX, PosY].Value = imagen;
        }

        public void llenarGalleta()
        {
            int ContadorGalletas = 0;
            int i, j;
            do
            {
                i = r.Next(0, 3);
                j = r.Next(0, 3);
                if ((dataTablero1[i, j].Value == cuadroBlanco) && ContadorGalletas <= 6)
                {
                    dataTablero1[i, j].Value = galleta;
                    ContadorGalletas++;
                }
            } while (ContadorGalletas <= 6);
        }

        public void PonerPortal()
        {
            dataTablero1[2, 2].Value = portal;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTablero1.Columns[0].Width = 200;
            dataTablero1.Columns[1].Width = 200;
            dataTablero1.Columns[2].Width = 200;

            dataTablero1.Rows.Add(3);
            dataTablero1.ClearSelection();

            dataTablero1.RowTemplate.Height = 50;

            llenarTablero();
            llenarPersonaje();
            llenarGalleta();
            PonerPortal();
            lblContGalleta.Text = 0.ToString();
            labelPuntos.Text = 0.ToString();
            lblName.Text = nombre;
        }

        private void data2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dataTablero1.Columns[e.ColumnIndex].Name)
            {
                case "Column1":
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
                case "Column2":
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
                case "Column3":
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

        private void btnEstadoA_Click(object sender, EventArgs e)
        {
            EstadoAvatar forma8 = new EstadoAvatar();
            forma8.ShowDialog();
        }

        private void btnTerminarP_Click(object sender, EventArgs e)
        {
            string puntosTotales = " ";
            puntosTotales += puntos1;
            MessageBox.Show("Tus puntos obtenidos son: " + puntosTotales);
            //
            contadorGalletas1 = 0;
            puntos1 = 0;
            Tablero21.contadorGalletas2 = 0;
            Tablero21.puntos2 = 0;
            Tablero31.contadorGalletas3 = 0;
            Tablero31.puntos3 = 0;
            Tablero4.contadorGalletas4 = 0;
            Tablero4.puntos4 = 0;
            //
            this.Hide();
            TabInicio forma7 = new TabInicio();
            forma7.ShowDialog();            
        }

        private void btnComandos_Click(object sender, EventArgs e)
        {
            Comandos forma8 = new Comandos();
            forma8.ShowDialog();
        }

        private void dataTablero1_KeyUp(object sender, KeyEventArgs e)
        {       
            switch (e.KeyData)
            {
                case Keys.A:
                    if (posx == 0)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        //Contador:
                        if (dataTablero1[posx -1, posy].Value == galleta)
                        {
                            contadorGalletas1 ++;
                            puntos1 += 15;
                            //
                            contSumar++;
                            lblContGalleta.Text = contadorGalletas1.ToString();
                            labelPuntos.Text = puntos1.ToString();
                        }
                        if (dataTablero1[posx - 1, posy].Value == portal)
                        {
                            puntos1 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero21 forma6 = new Tablero21();
                            forma6.Show();
                        }
                        dataTablero1[posx, posy].Value = cuadroBlanco;
                        posx -= 1;
                        Mover(posx, posy);
                    }
                    break;
                case Keys.D:
                    if (posx == 2)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero1[posx +1, posy].Value == galleta)
                        {
                            contadorGalletas1 ++;
                            puntos1 += 15;
                            //
                            contSumar++;
                            lblContGalleta.Text = contadorGalletas1.ToString();
                            labelPuntos.Text = puntos1.ToString();
                        }

                        if ((dataTablero1[posx + 1, posy].Value == portal) && (contadorGalletas1 == 6))
                        {
                            puntos1 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero21 forma6 = new Tablero21();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero1[posx + 1, posy].Value == portal) && (contadorGalletas1 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos1 -= 5;
                                labelPuntos.Text = puntos1.ToString();
                            }                      
                        }
                        if (dataTablero1[posx + 1, posy].Value != portal)
                        {
                            dataTablero1[posx, posy].Value = cuadroBlanco;
                            posx += 1;
                            Mover(posx, posy);
                        }
                    }
                    break;
                case Keys.S:
                    if(posy == 2)
                    {
                        MessageBox.Show("No te puedes salir del tablero");
                    }
                    else
                    {
                        if (dataTablero1[posx, posy + 1].Value == galleta)
                        {
                            contadorGalletas1 ++;
                            puntos1 += 15;
                            //
                            contSumar++;
                            lblContGalleta.Text = contadorGalletas1.ToString();
                            labelPuntos.Text = puntos1.ToString();
                        }

                        if ((dataTablero1[posx, posy + 1].Value == portal) && (contadorGalletas1 == 6))
                        {
                            puntos1 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero21 forma6 = new Tablero21();
                            forma6.Show();
                        }
                        else
                        {
                            if ((dataTablero1[posx, posy + 1].Value == portal) && (contadorGalletas1 != 6))
                            {
                                MessageBox.Show("Recolecta todas las galletitas.");
                                puntos1 -= 5;
                                labelPuntos.Text = puntos1.ToString();
                            }
                        }
                        if (dataTablero1[posx, posy + 1].Value != portal)
                        {
                            dataTablero1[posx, posy].Value = cuadroBlanco;
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
                        if (dataTablero1[posx, posy - 1].Value == galleta)
                        {
                            contadorGalletas1 ++;
                            puntos1 += 15;
                            //
                            contSumar++;
                            lblContGalleta.Text = contadorGalletas1.ToString();
                            labelPuntos.Text = puntos1.ToString();
                        }

                        if (dataTablero1[posx, posy - 1].Value == portal)
                        {
                            puntos1 += 50;
                            MessageBox.Show("¡Viajando al otro nivel!");
                            this.Hide();
                            Tablero21 forma6 = new Tablero21();
                            forma6.Show();
                        }
                        dataTablero1[posx, posy].Value = cuadroBlanco;
                        posy -= 1;
                        Mover(posx, posy);
                    }
                    break;

                    //Teclas normales

                    /*
                    case Keys.Left:
                        if (posx == 0)
                        {
                            MessageBox.Show("No te puedes salir del tablero");
                        }
                        else
                        {
                            dataTablero1[posx, posy].Value = cuadroBlanco;
                            posx -= 1;
                            Mover(posx, posy);
                        }
                        break;
                    case Keys.Right:
                        if (posx == 2)
                        {
                            MessageBox.Show("No te puedes salir del tablero");
                        }
                        else
                        {
                            dataTablero1[posx, posy].Value = cuadroBlanco;
                            posx += 1;
                            Mover(posx, posy);
                        }
                        break;
                    case Keys.Down:
                        if (posy == 2)
                        {
                            MessageBox.Show("No te puedes salir del tablero");
                        }
                        else
                        {
                            dataTablero1[posx, posy].Value = cuadroBlanco;
                            posy += 1;
                            Mover(posx, posy);
                        }
                        break;
                    case Keys.Up:
                        if (posy == 0)
                        {
                            MessageBox.Show("No te puedes salir del tablero");
                        }
                        else
                        {
                            dataTablero1[posx, posy].Value = cuadroBlanco;
                            posy -= 1;
                            Mover(posx, posy);
                        }
                        break;
                        */
            }
            if (contSumar == 6)
            {
                MessageBox.Show("¡Ya puedes ingresar al portal!");
                contSumar++;
            }
        }
    }
}
