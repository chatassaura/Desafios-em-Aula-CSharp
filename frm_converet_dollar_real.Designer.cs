namespace Atividades
{
    partial class frm_converet_dollar_real
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
            this.rb_real = new System.Windows.Forms.RadioButton();
            this.rb_dollar = new System.Windows.Forms.RadioButton();
            this.lbl_esccolha = new System.Windows.Forms.Label();
            this.lbl_info_valores = new System.Windows.Forms.Label();
            this.lbl_escolha = new System.Windows.Forms.Label();
            this.txt_escolhido = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_convertido = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_real
            // 
            this.rb_real.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_real.AutoSize = true;
            this.rb_real.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_real.Location = new System.Drawing.Point(102, 53);
            this.rb_real.Name = "rb_real";
            this.rb_real.Size = new System.Drawing.Size(82, 22);
            this.rb_real.TabIndex = 0;
            this.rb_real.TabStop = true;
            this.rb_real.Text = "Real(R$)";
            this.rb_real.UseVisualStyleBackColor = true;
            this.rb_real.CheckedChanged += new System.EventHandler(this.rb_real_CheckedChanged);
            // 
            // rb_dollar
            // 
            this.rb_dollar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_dollar.AutoSize = true;
            this.rb_dollar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_dollar.Location = new System.Drawing.Point(191, 53);
            this.rb_dollar.Name = "rb_dollar";
            this.rb_dollar.Size = new System.Drawing.Size(83, 22);
            this.rb_dollar.TabIndex = 1;
            this.rb_dollar.TabStop = true;
            this.rb_dollar.Text = "Dollar($)";
            this.rb_dollar.UseVisualStyleBackColor = true;
            this.rb_dollar.CheckedChanged += new System.EventHandler(this.rb_dollar_CheckedChanged);
            // 
            // lbl_esccolha
            // 
            this.lbl_esccolha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_esccolha.AutoSize = true;
            this.lbl_esccolha.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esccolha.Location = new System.Drawing.Point(37, 227);
            this.lbl_esccolha.Name = "lbl_esccolha";
            this.lbl_esccolha.Size = new System.Drawing.Size(0, 18);
            this.lbl_esccolha.TabIndex = 2;
            this.lbl_esccolha.Click += new System.EventHandler(this.lbl_esccolha_Click);
            // 
            // lbl_info_valores
            // 
            this.lbl_info_valores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info_valores.AutoSize = true;
            this.lbl_info_valores.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_valores.Location = new System.Drawing.Point(110, 95);
            this.lbl_info_valores.Name = "lbl_info_valores";
            this.lbl_info_valores.Size = new System.Drawing.Size(132, 18);
            this.lbl_info_valores.TabIndex = 3;
            this.lbl_info_valores.Text = "Informe os valores: ";
            // 
            // lbl_escolha
            // 
            this.lbl_escolha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_escolha.AutoSize = true;
            this.lbl_escolha.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_escolha.Location = new System.Drawing.Point(110, 22);
            this.lbl_escolha.Name = "lbl_escolha";
            this.lbl_escolha.Size = new System.Drawing.Size(163, 18);
            this.lbl_escolha.TabIndex = 4;
            this.lbl_escolha.Text = "O que deseja converter: ";
            // 
            // txt_escolhido
            // 
            this.txt_escolhido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_escolhido.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_escolhido.Location = new System.Drawing.Point(113, 219);
            this.txt_escolhido.Name = "txt_escolhido";
            this.txt_escolhido.Size = new System.Drawing.Size(208, 26);
            this.txt_escolhido.TabIndex = 5;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resultado.Enabled = false;
            this.txt_resultado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(75, 355);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(236, 26);
            this.txt_resultado.TabIndex = 8;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(99, 334);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(167, 18);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.Text = "Resultado da conversão: ";
            // 
            // btn_calc
            // 
            this.btn_calc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calc.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(100, 274);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(211, 34);
            this.btn_calc.TabIndex = 11;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calcular_click);
            // 
            // lbl_convertido
            // 
            this.lbl_convertido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_convertido.AutoSize = true;
            this.lbl_convertido.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_convertido.Location = new System.Drawing.Point(24, 334);
            this.lbl_convertido.Name = "lbl_convertido";
            this.lbl_convertido.Size = new System.Drawing.Size(0, 18);
            this.lbl_convertido.TabIndex = 12;
            // 
            // txt_cambio
            // 
            this.txt_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cambio.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cambio.Location = new System.Drawing.Point(113, 163);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(208, 26);
            this.txt_cambio.TabIndex = 14;
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.Location = new System.Drawing.Point(12, 166);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(95, 18);
            this.lbl_cambio.TabIndex = 13;
            this.lbl_cambio.Text = "Valor Câmbio";
            // 
            // frm_converet_dollar_real
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(362, 412);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.lbl_cambio);
            this.Controls.Add(this.lbl_convertido);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_escolhido);
            this.Controls.Add(this.lbl_escolha);
            this.Controls.Add(this.lbl_info_valores);
            this.Controls.Add(this.lbl_esccolha);
            this.Controls.Add(this.rb_dollar);
            this.Controls.Add(this.rb_real);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "frm_converet_dollar_real";
            this.Text = "CONVERSÃO $ e R$";
            this.Load += new System.EventHandler(this.frm_converet_dollar_real_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_real;
        private System.Windows.Forms.RadioButton rb_dollar;
        private System.Windows.Forms.Label lbl_esccolha;
        private System.Windows.Forms.Label lbl_info_valores;
        private System.Windows.Forms.Label lbl_escolha;
        private System.Windows.Forms.TextBox txt_escolhido;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_convertido;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.Label lbl_cambio;
    }
}