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
    public partial class frm_cnh : Form
    {
        public frm_cnh()
        {
            InitializeComponent();
        }
        private void btn_verifica_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txt_idade.Text);
            if(idade >= 18)
            {
                MessageBox.Show("Processo para tirar CNH Liberado!");
            }
            else
            {
                MessageBox.Show("CNH Negado!");
            }
        }
    }
}
