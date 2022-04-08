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
    public partial class frm_Temperatura : Form
    {
        public frm_Temperatura()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_converter_click(object sender, EventArgs e)
        {
            Double conversao_result = 0;
            if(cb_converter.SelectedIndex == 0)
            {
                if(cb_conversao.SelectedIndex == 1)
                {
                    conversao_result = (Convert.ToDouble(txt_valor.Text) * 9 )/ 5 + 32; 
                    txt_resultado.Text = conversao_result.ToString("0.00");
                    lbl_tipo_resultado.Text = cb_conversao.Text;
                }
                else if(cb_conversao.SelectedIndex == 2)
                {
                    conversao_result = Convert.ToDouble(txt_valor.Text) + 273.15;
                    txt_resultado.Text = conversao_result.ToString("0.00");
                    lbl_tipo_resultado.Text = cb_conversao.Text;
                }
                else
                {
                    MessageBox.Show("Impossivel converter");
                }
            }
            else if (cb_converter.SelectedIndex == 1)
            {
                if (cb_conversao.SelectedIndex == 0)
                {
                    conversao_result = ((Convert.ToDouble(txt_valor.Text) -32) * 5)/9;
                    txt_resultado.Text = conversao_result.ToString("0.00");
                    lbl_tipo_resultado.Text = cb_conversao.Text;
                }
                else if (cb_conversao.SelectedIndex == 2)
                {
                    conversao_result = ((Convert.ToDouble(txt_valor.Text)-32)*5)/9 + 273.15;
                    txt_resultado.Text = conversao_result.ToString("0.000");
                    lbl_tipo_resultado.Text = cb_conversao.Text;
                }
                else
                {
                    MessageBox.Show("Impossivel converter");
                }
            }
            else if (cb_converter.SelectedIndex == 2)
            {
                if (cb_conversao.SelectedIndex == 0)
                {
                    conversao_result = Convert.ToDouble(txt_valor.Text) - 273.15;
                    txt_resultado.Text = conversao_result.ToString("0.00");
                    lbl_tipo_resultado.Text = cb_conversao.Text;
                }
                else if (cb_conversao.SelectedIndex == 1)
                {
                    conversao_result = ((Convert.ToDouble(txt_valor.Text) - 273.15) * 9) / 5 + 32;
                    txt_resultado.Text = conversao_result.ToString("0.00");
                    lbl_tipo_resultado.Text = cb_conversao.Text;
                }
                else
                {
                    MessageBox.Show("Impossivel converter");
                }
            }
        }

        private void frm_Temperatura_Load(object sender, EventArgs e)
        {
            cb_converter.SelectedIndex = 0;
            cb_conversao.SelectedIndex = 1;
            lbl_tipo_resultado.Text = cb_conversao.Text;
        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void gb_Resultado_Enter(object sender, EventArgs e)
        {

        }

        private void cb_conversao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
