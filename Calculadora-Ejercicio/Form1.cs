using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_Ejercicio
{
    public partial class Form1 : Form
    {
        static Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdResultado_Click(object sender, EventArgs e)
        {
            if (cbxOperaciones.Text == "Suma")
            {
                lblRes.Text = (op.Suma(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
            else if (cbxOperaciones.Text == "Resta")
            {
                lblRes.Text = (op.Resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
            else if (cbxOperaciones.Text == "Multiplicación")
            {
                lblRes.Text = (op.Mult(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
            else if (cbxOperaciones.Text == "División")
            {
                lblRes.Text = (op.Div(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
        }

       
    }
}
