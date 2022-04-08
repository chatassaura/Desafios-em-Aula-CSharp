namespace Atividades
{
    partial class frm_votacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_candidato = new System.Windows.Forms.Label();
            this.cb_candidatos = new System.Windows.Forms.ComboBox();
            this.btn_votar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.lbl_jose = new System.Windows.Forms.Label();
            this.lbl_pedro = new System.Windows.Forms.Label();
            this.lbl_ricardo = new System.Windows.Forms.Label();
            this.lbl_voto_r = new System.Windows.Forms.Label();
            this.lbl_voto_p = new System.Windows.Forms.Label();
            this.lbl_voto_j = new System.Windows.Forms.Label();
            this.lbl_vitor = new System.Windows.Forms.Label();
            this.lbl_voto_v = new System.Windows.Forms.Label();
            this.lbl_vencedor = new System.Windows.Forms.Label();
            this.lbl_votos = new System.Windows.Forms.Label();
            this.lbl_candidatos_lista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_candidato
            // 
            this.lbl_candidato.AutoSize = true;
            this.lbl_candidato.Location = new System.Drawing.Point(47, 38);
            this.lbl_candidato.Name = "lbl_candidato";
            this.lbl_candidato.Size = new System.Drawing.Size(55, 13);
            this.lbl_candidato.TabIndex = 0;
            this.lbl_candidato.Text = "Candidato";
            // 
            // cb_candidatos
            // 
            this.cb_candidatos.FormattingEnabled = true;
            this.cb_candidatos.Items.AddRange(new object[] {
            "Pedro",
            "José",
            "Ricardo",
            "Vitor"});
            this.cb_candidatos.Location = new System.Drawing.Point(108, 35);
            this.cb_candidatos.Name = "cb_candidatos";
            this.cb_candidatos.Size = new System.Drawing.Size(134, 21);
            this.cb_candidatos.TabIndex = 1;
            this.cb_candidatos.Text = "Selecione o Candidato";
            // 
            // btn_votar
            // 
            this.btn_votar.BackColor = System.Drawing.Color.Green;
            this.btn_votar.Location = new System.Drawing.Point(108, 62);
            this.btn_votar.Name = "btn_votar";
            this.btn_votar.Size = new System.Drawing.Size(91, 36);
            this.btn_votar.TabIndex = 2;
            this.btn_votar.Text = "Votar";
            this.btn_votar.UseVisualStyleBackColor = false;
            this.btn_votar.Click += new System.EventHandler(this.btn_votar_click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.Red;
            this.btn_finalizar.Location = new System.Drawing.Point(32, 104);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(268, 40);
            this.btn_finalizar.TabIndex = 3;
            this.btn_finalizar.Text = "Encerrar Votação";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // lbl_jose
            // 
            this.lbl_jose.AutoSize = true;
            this.lbl_jose.Location = new System.Drawing.Point(87, 165);
            this.lbl_jose.Name = "lbl_jose";
            this.lbl_jose.Size = new System.Drawing.Size(0, 13);
            this.lbl_jose.TabIndex = 4;
            // 
            // lbl_pedro
            // 
            this.lbl_pedro.AutoSize = true;
            this.lbl_pedro.Location = new System.Drawing.Point(148, 165);
            this.lbl_pedro.Name = "lbl_pedro";
            this.lbl_pedro.Size = new System.Drawing.Size(0, 13);
            this.lbl_pedro.TabIndex = 5;
            // 
            // lbl_ricardo
            // 
            this.lbl_ricardo.AutoSize = true;
            this.lbl_ricardo.Location = new System.Drawing.Point(209, 165);
            this.lbl_ricardo.Name = "lbl_ricardo";
            this.lbl_ricardo.Size = new System.Drawing.Size(0, 13);
            this.lbl_ricardo.TabIndex = 6;
            // 
            // lbl_voto_r
            // 
            this.lbl_voto_r.AutoSize = true;
            this.lbl_voto_r.Location = new System.Drawing.Point(220, 192);
            this.lbl_voto_r.Name = "lbl_voto_r";
            this.lbl_voto_r.Size = new System.Drawing.Size(13, 13);
            this.lbl_voto_r.TabIndex = 9;
            this.lbl_voto_r.Text = "0";
            // 
            // lbl_voto_p
            // 
            this.lbl_voto_p.AutoSize = true;
            this.lbl_voto_p.Location = new System.Drawing.Point(157, 192);
            this.lbl_voto_p.Name = "lbl_voto_p";
            this.lbl_voto_p.Size = new System.Drawing.Size(13, 13);
            this.lbl_voto_p.TabIndex = 8;
            this.lbl_voto_p.Text = "0";
            // 
            // lbl_voto_j
            // 
            this.lbl_voto_j.AutoSize = true;
            this.lbl_voto_j.Location = new System.Drawing.Point(92, 192);
            this.lbl_voto_j.Name = "lbl_voto_j";
            this.lbl_voto_j.Size = new System.Drawing.Size(13, 13);
            this.lbl_voto_j.TabIndex = 7;
            this.lbl_voto_j.Text = "0";
            // 
            // lbl_vitor
            // 
            this.lbl_vitor.AutoSize = true;
            this.lbl_vitor.Location = new System.Drawing.Point(272, 165);
            this.lbl_vitor.Name = "lbl_vitor";
            this.lbl_vitor.Size = new System.Drawing.Size(0, 13);
            this.lbl_vitor.TabIndex = 10;
            // 
            // lbl_voto_v
            // 
            this.lbl_voto_v.AutoSize = true;
            this.lbl_voto_v.Location = new System.Drawing.Point(277, 192);
            this.lbl_voto_v.Name = "lbl_voto_v";
            this.lbl_voto_v.Size = new System.Drawing.Size(13, 13);
            this.lbl_voto_v.TabIndex = 11;
            this.lbl_voto_v.Text = "0";
            // 
            // lbl_vencedor
            // 
            this.lbl_vencedor.AutoSize = true;
            this.lbl_vencedor.Location = new System.Drawing.Point(53, 230);
            this.lbl_vencedor.Name = "lbl_vencedor";
            this.lbl_vencedor.Size = new System.Drawing.Size(0, 13);
            this.lbl_vencedor.TabIndex = 12;
            // 
            // lbl_votos
            // 
            this.lbl_votos.AutoSize = true;
            this.lbl_votos.Location = new System.Drawing.Point(15, 192);
            this.lbl_votos.Name = "lbl_votos";
            this.lbl_votos.Size = new System.Drawing.Size(34, 13);
            this.lbl_votos.TabIndex = 14;
            this.lbl_votos.Text = "Votos";
            // 
            // lbl_candidatos_lista
            // 
            this.lbl_candidatos_lista.AutoSize = true;
            this.lbl_candidatos_lista.Location = new System.Drawing.Point(15, 165);
            this.lbl_candidatos_lista.Name = "lbl_candidatos_lista";
            this.lbl_candidatos_lista.Size = new System.Drawing.Size(55, 13);
            this.lbl_candidatos_lista.TabIndex = 13;
            this.lbl_candidatos_lista.Text = "Candidato";
            // 
            // frm_votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(326, 264);
            this.Controls.Add(this.lbl_votos);
            this.Controls.Add(this.lbl_candidatos_lista);
            this.Controls.Add(this.lbl_vencedor);
            this.Controls.Add(this.lbl_voto_v);
            this.Controls.Add(this.lbl_vitor);
            this.Controls.Add(this.lbl_voto_r);
            this.Controls.Add(this.lbl_voto_p);
            this.Controls.Add(this.lbl_voto_j);
            this.Controls.Add(this.lbl_ricardo);
            this.Controls.Add(this.lbl_pedro);
            this.Controls.Add(this.lbl_jose);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_votar);
            this.Controls.Add(this.cb_candidatos);
            this.Controls.Add(this.lbl_candidato);
            this.Name = "frm_votacao";
            this.Text = "Sistema de Votação ";
            this.Load += new System.EventHandler(this.frm_votacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_candidato;
        private System.Windows.Forms.ComboBox cb_candidatos;
        private System.Windows.Forms.Button btn_votar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label lbl_jose;
        private System.Windows.Forms.Label lbl_pedro;
        private System.Windows.Forms.Label lbl_ricardo;
        private System.Windows.Forms.Label lbl_voto_r;
        private System.Windows.Forms.Label lbl_voto_p;
        private System.Windows.Forms.Label lbl_voto_j;
        private System.Windows.Forms.Label lbl_vitor;
        private System.Windows.Forms.Label lbl_voto_v;
        private System.Windows.Forms.Label lbl_vencedor;
        private System.Windows.Forms.Label lbl_votos;
        private System.Windows.Forms.Label lbl_candidatos_lista;
    }
}