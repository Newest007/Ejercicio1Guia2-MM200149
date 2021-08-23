using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Guia2_MM200149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnSecretaria.Checked == true)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMDescuento.Enabled = false;
            txtSNeto.Enabled = false;
        }

        private void rbtnGerente_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnGerente.Checked == true)
            {

            }
        }

        private void rbtnSubgerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSubgerente.Checked == true)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario, descuento, total;
            salario = Convert.ToDouble(txtSBruto.Text);

            if(rbtnGerente.Enabled == true)
            {
                descuento = 0.2;
                total = salario - (salario * descuento);

                txtMDescuento.Text = descuento.ToString();
                txtSNeto.Text = total.ToString();


            }

            if(rbtnSubgerente.Enabled == true)
            {
                descuento = 0.15;
                total = salario - (salario * descuento);

                txtMDescuento.Text = descuento.ToString();
                txtSNeto.Text = total.ToString();
            }

            //secretaria 5%


        }
    }
}
