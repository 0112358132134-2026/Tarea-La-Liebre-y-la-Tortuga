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
    public partial class Instrucciones : Form
    {
        public Instrucciones()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabInicio forma4 = new TabInicio();
            forma4.ShowDialog();
        }
    }
}
