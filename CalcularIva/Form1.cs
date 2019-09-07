using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblvalorfinal.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double valorFinal;
            valorFinal = Convert.ToDouble(txtvalor.Text);

            valorFinal = (valorFinal * 0.19) + valorFinal;

            lblvalorfinal.Text = valorFinal.ToString();
            lblvalorfinal.Visible = true;
        }
    }
}
