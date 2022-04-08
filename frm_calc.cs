using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades
{
    public partial class frm_calc : Form
    {
        public frm_calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txt_num1.Text);
            Double num2 = Convert.ToDouble(txt_num2.Text);
            Double total = num1 + num2;
            txt_resultado.Text = total.ToString();

        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_subtrair_click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txt_num1.Text);
            Double num2 = Convert.ToDouble(txt_num2.Text);
            Double total = num1 - num2;
            txt_resultado.Text = total.ToString();
        }

        private void btn_multiplicar_click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txt_num1.Text);
            Double num2 = Convert.ToDouble(txt_num2.Text);
            Double total = num1 * num2;
            txt_resultado.Text = total.ToString();
        }

        private void btn_dividir_click(object sender, EventArgs e)
        {
            Double num1 = Convert.ToDouble(txt_num1.Text);
            Double num2 = Convert.ToDouble(txt_num2.Text);
            Double total = num1 / num2;
            txt_resultado.Text = total.ToString();
        }
    }
}
