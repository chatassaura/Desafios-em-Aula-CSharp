namespace Atividades
{
    partial class frm_cnh
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
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_verifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(45, 47);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(106, 13);
            this.lbl_idade.TabIndex = 0;
            this.lbl_idade.Text = "Idade do requisitante";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(112, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 13);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Permissão CNH";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(157, 44);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 2;
            // 
            // btn_verifica
            // 
            this.btn_verifica.Location = new System.Drawing.Point(118, 80);
            this.btn_verifica.Name = "btn_verifica";
            this.btn_verifica.Size = new System.Drawing.Size(75, 23);
            this.btn_verifica.TabIndex = 3;
            this.btn_verifica.Text = "Verificar";
            this.btn_verifica.UseVisualStyleBackColor = true;
            this.btn_verifica.Click += new System.EventHandler(this.btn_verifica_Click);
            // 
            // frm_cnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 128);
            this.Controls.Add(this.btn_verifica);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_idade);
            this.Name = "frm_cnh";
            this.Text = "frm_cnh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button btn_verifica;
    }
}