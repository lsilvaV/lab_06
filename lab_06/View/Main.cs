using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_06.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorCompra = 0;
            decimal valorPago = 0;
            decimal troco = 0;

            valorCompra = Convert.ToDecimal(tbxCompra.Text);
            valorPago = Convert.ToDecimal(tbxDinheiro.Text);

            troco = valorPago - valorCompra;

            lblResultado.Text = troco.ToString();

            int moeda100 = (int)troco / 1;
            lblResultado100.Text = moeda100.ToString();

            int moeda050 = (int)(troco / 0.50m);
            lblResultado050.Text = moeda050.ToString();

            int moeda025 = (int)(troco / 0.25m);
            lblResultado025.Text = moeda025.ToString();

            int moeda010 = (int)(troco / 0.10m);
            lblResultado010.Text = moeda010.ToString();

            int moeda005 = (int)(troco / 0.05m);
            lblResultado005.Text = moeda005.ToString();

            int moeda001 = (int)(troco / 0.01m);
            lblResultado001.Text = moeda001.ToString();



        }
    }
}
