namespace Atividades
{
    partial class frm_cadastro_pessoas
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
            this.grp_cadastrar = new System.Windows.Forms.GroupBox();
            this.grp_consultar = new System.Windows.Forms.GroupBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_cad_nome = new System.Windows.Forms.Label();
            this.txt_cad_nome = new System.Windows.Forms.TextBox();
            this.btn_cad_nome = new System.Windows.Forms.Button();
            this.lst_cad_nome = new System.Windows.Forms.ListBox();
            this.btn_con_nome = new System.Windows.Forms.Button();
            this.txt_con_nome = new System.Windows.Forms.TextBox();
            this.lbl_con_nome = new System.Windows.Forms.Label();
            this.grp_cadastrar.SuspendLayout();
            this.grp_consultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_cadastrar
            // 
            this.grp_cadastrar.Controls.Add(this.lst_cad_nome);
            this.grp_cadastrar.Controls.Add(this.btn_cad_nome);
            this.grp_cadastrar.Controls.Add(this.txt_cad_nome);
            this.grp_cadastrar.Controls.Add(this.lbl_cad_nome);
            this.grp_cadastrar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_cadastrar.Location = new System.Drawing.Point(27, 55);
            this.grp_cadastrar.Name = "grp_cadastrar";
            this.grp_cadastrar.Size = new System.Drawing.Size(274, 254);
            this.grp_cadastrar.TabIndex = 0;
            this.grp_cadastrar.TabStop = false;
            this.grp_cadastrar.Text = "Cadastrar";
            // 
            // grp_consultar
            // 
            this.grp_consultar.Controls.Add(this.btn_con_nome);
            this.grp_consultar.Controls.Add(this.txt_con_nome);
            this.grp_consultar.Controls.Add(this.lbl_con_nome);
            this.grp_consultar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_consultar.Location = new System.Drawing.Point(27, 332);
            this.grp_consultar.Name = "grp_consultar";
            this.grp_consultar.Size = new System.Drawing.Size(274, 131);
            this.grp_consultar.TabIndex = 1;
            this.grp_consultar.TabStop = false;
            this.grp_consultar.Text = "Consultar";
            this.grp_consultar.Enter += new System.EventHandler(this.grp_consultar_Enter);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(65, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(204, 37);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Cadastro de Usuário";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // lbl_cad_nome
            // 
            this.lbl_cad_nome.AutoSize = true;
            this.lbl_cad_nome.Location = new System.Drawing.Point(26, 44);
            this.lbl_cad_nome.Name = "lbl_cad_nome";
            this.lbl_cad_nome.Size = new System.Drawing.Size(56, 29);
            this.lbl_cad_nome.TabIndex = 0;
            this.lbl_cad_nome.Text = "Nome";
            // 
            // txt_cad_nome
            // 
            this.txt_cad_nome.Location = new System.Drawing.Point(84, 36);
            this.txt_cad_nome.Name = "txt_cad_nome";
            this.txt_cad_nome.Size = new System.Drawing.Size(158, 37);
            this.txt_cad_nome.TabIndex = 1;
            // 
            // btn_cad_nome
            // 
            this.btn_cad_nome.Location = new System.Drawing.Point(31, 89);
            this.btn_cad_nome.Name = "btn_cad_nome";
            this.btn_cad_nome.Size = new System.Drawing.Size(211, 33);
            this.btn_cad_nome.TabIndex = 2;
            this.btn_cad_nome.Text = "Salvar";
            this.btn_cad_nome.UseVisualStyleBackColor = true;
            this.btn_cad_nome.Click += new System.EventHandler(this.btn_cad_nome_Click);
            // 
            // lst_cad_nome
            // 
            this.lst_cad_nome.FormattingEnabled = true;
            this.lst_cad_nome.ItemHeight = 29;
            this.lst_cad_nome.Location = new System.Drawing.Point(31, 137);
            this.lst_cad_nome.Name = "lst_cad_nome";
            this.lst_cad_nome.Size = new System.Drawing.Size(211, 91);
            this.lst_cad_nome.TabIndex = 3;
            // 
            // btn_con_nome
            // 
            this.btn_con_nome.Location = new System.Drawing.Point(31, 83);
            this.btn_con_nome.Name = "btn_con_nome";
            this.btn_con_nome.Size = new System.Drawing.Size(211, 30);
            this.btn_con_nome.TabIndex = 5;
            this.btn_con_nome.Text = "Pesquisar";
            this.btn_con_nome.UseVisualStyleBackColor = true;
            this.btn_con_nome.Click += new System.EventHandler(this.btn_con_nome_Click);
            // 
            // txt_con_nome
            // 
            this.txt_con_nome.Location = new System.Drawing.Point(84, 40);
            this.txt_con_nome.Name = "txt_con_nome";
            this.txt_con_nome.Size = new System.Drawing.Size(158, 37);
            this.txt_con_nome.TabIndex = 4;
            // 
            // lbl_con_nome
            // 
            this.lbl_con_nome.AutoSize = true;
            this.lbl_con_nome.Location = new System.Drawing.Point(26, 43);
            this.lbl_con_nome.Name = "lbl_con_nome";
            this.lbl_con_nome.Size = new System.Drawing.Size(56, 29);
            this.lbl_con_nome.TabIndex = 3;
            this.lbl_con_nome.Text = "Nome";
            // 
            // frm_cadastro_pessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 489);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.grp_consultar);
            this.Controls.Add(this.grp_cadastrar);
            this.Name = "frm_cadastro_pessoas";
            this.Text = "frm_cadastro_pessoas";
            this.grp_cadastrar.ResumeLayout(false);
            this.grp_cadastrar.PerformLayout();
            this.grp_consultar.ResumeLayout(false);
            this.grp_consultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_cadastrar;
        private System.Windows.Forms.GroupBox grp_consultar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ListBox lst_cad_nome;
        private System.Windows.Forms.Button btn_cad_nome;
        private System.Windows.Forms.TextBox txt_cad_nome;
        private System.Windows.Forms.Label lbl_cad_nome;
        private System.Windows.Forms.Button btn_con_nome;
        private System.Windows.Forms.TextBox txt_con_nome;
        private System.Windows.Forms.Label lbl_con_nome;
    }
}