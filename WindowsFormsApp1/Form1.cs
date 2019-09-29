using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IMC imc = new IMC();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            imc.setPeso(double.Parse(txtpeso.Text));
            imc.setEstatura(double.Parse(txtestatura.Text));
            lblresultado.Text = "Su indice de masa corporal es: " + imc.resultado().ToString();
            lblresultado.Visible = true;
        }
    }
}
