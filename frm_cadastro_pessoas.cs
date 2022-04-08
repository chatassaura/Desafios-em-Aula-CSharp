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
    public partial class frm_cadastro_pessoas : Form
    {
        public frm_cadastro_pessoas()
        {
            InitializeComponent();
        }

        private void btn_cad_nome_Click(object sender, EventArgs e)
        {
            string nome = txt_cad_nome.Text;
            nome = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
            lst_cad_nome.Items.Add(nome);
            MessageBox.Show("Cadastro realizado com sucesso!");
            txt_cad_nome.Text = "";
        }

        private void btn_con_nome_Click(object sender, EventArgs e)
        {
            string nome = txt_con_nome.Text;
            nome = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
            int totalRegistros = lst_cad_nome.Items.Count;
            for (int i =0; i < totalRegistros; i++)
            {
                if (lst_cad_nome.Items[i].ToString().Equals(nome))
                {
                    MessageBox.Show("Nome encontrado nos cadastros!");
                }
                else if(lst_cad_nome.Items[i].ToString().Equals(nome) && i.Equals(totalRegistros-1))
                {
                    MessageBox.Show("Este nome não existe nos cadastros!");
                }
            }
            txt_con_nome.Text = "";
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void grp_consultar_Enter(object sender, EventArgs e)
        {

        }
    }
}
