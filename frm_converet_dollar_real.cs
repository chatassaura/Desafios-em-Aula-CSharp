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
    public partial class frm_converet_dollar_real : Form
    {
        public frm_converet_dollar_real()
        {
            InitializeComponent();
        }

        private void frm_converet_dollar_real_Load(object sender, EventArgs e)
        {

        }

        private void lbl_esccolha_Click(object sender, EventArgs e)
        {

        }

        private void rb_real_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_real.Checked == true)
            {
                lbl_esccolha.Text = "Real";
                lbl_convertido.Text = "Dollar";
            }
        }

        private void rb_dollar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_dollar.Checked == true)
            {
                lbl_esccolha.Text = "Dollar";
                lbl_convertido.Text = "Real";
            }
 
        }

        private void btn_calcular_click(object sender, EventArgs e)
        {
            Double total_conversao = 0;

            if (rb_dollar.Checked == true)
            {
                total_conversao = Convert.ToDouble(txt_escolhido.Text) / Convert.ToDouble(txt_cambio.Text);
            }
            else
            {
                total_conversao = Convert.ToDouble(txt_escolhido.Text) * Convert.ToDouble(txt_cambio.Text);
            }
            


            txt_resultado.Text = total_conversao.ToString("0.00");
        }
    }
}
