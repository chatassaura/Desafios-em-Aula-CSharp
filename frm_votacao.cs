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
     public partial class frm_votacao : Form
    {
        int total_pedro = 0;
        int total_jose = 0;
        int total_ricardo = 0;
        int total_vitor = 0;
        int mais_votado = 0;
        string vencedor = "";

        public frm_votacao()
        {
            InitializeComponent();
        }
        private void btn_votar_click(object sender, EventArgs e)
        {
            if(cb_candidatos.SelectedIndex == 0)
            {
                total_pedro += 1;
            }
            else if (cb_candidatos.SelectedIndex == 1)
            {
                total_jose += 1;
            }
            else if (cb_candidatos.SelectedIndex == 2)
            {
                total_ricardo += 1;
            }
            else if (cb_candidatos.SelectedIndex == 3)
            {
                total_vitor += 1;
            }
            else
            {
                MessageBox.Show("Selecione um candidato");
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (total_jose > mais_votado)
            {
                mais_votado = total_jose;
                vencedor = cb_candidatos.Items[0].ToString();
            }

            if (total_pedro > mais_votado)
            {
                mais_votado = total_pedro;
                vencedor = cb_candidatos.Items[1].ToString();
            }

            if (total_ricardo > mais_votado)
            {
                mais_votado = total_ricardo;
                vencedor = cb_candidatos.Items[2].ToString();
            }

            if (total_vitor > mais_votado)
            {
                mais_votado = total_vitor;
                vencedor = cb_candidatos.Items[3].ToString();
            }

            lbl_voto_j.Text = total_jose.ToString();
            lbl_voto_p.Text = total_pedro.ToString();
            lbl_voto_r.Text = total_ricardo.ToString();
            lbl_voto_v.Text = total_vitor.ToString();
            lbl_vencedor.Text = "O Candidato vencedor foi " + vencedor + " com " + mais_votado + " votos. ";
        }

        private void frm_votacao_Load(object sender, EventArgs e)
        {
            lbl_jose.Text = cb_candidatos.Items[0].ToString();
            lbl_pedro.Text = cb_candidatos.Items[1].ToString();
            lbl_ricardo.Text = cb_candidatos.Items[2].ToString();
            lbl_vitor.Text = cb_candidatos.Items[3].ToString();
        }
    }
}
