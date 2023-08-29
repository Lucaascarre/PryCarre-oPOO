using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCarreñoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClassPersonaje objeto = new ClassPersonaje();

            objeto.Nombre=txtNombre.Text;
            objeto.fuerza = Convert.ToInt32 (txtFuerza.Text);
            objeto.destreza = int.Parse(txtDestreza.Text);


            lblInfo.Text += objeto.Nombre + "-";
            objeto.fuerza + "-" +
            objeto.destreza + "-" + 

        }


    }
}
