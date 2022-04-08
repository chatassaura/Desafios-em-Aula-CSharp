namespace Atividades
{
    partial class frm_Temperatura
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
            this.btn_conversão = new System.Windows.Forms.Button();
            this.cb_conversao = new System.Windows.Forms.ComboBox();
            this.lbl_conversao = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_converter = new System.Windows.Forms.Label();
            this.cb_converter = new System.Windows.Forms.ComboBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_tipo_resultado = new System.Windows.Forms.Label();
            this.gb_Resultado = new System.Windows.Forms.GroupBox();
            this.gb_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_conversão
            // 
            this.btn_conversão.Location = new System.Drawing.Point(70, 139);
            this.btn_conversão.Name = "btn_conversão";
            this.btn_conversão.Size = new System.Drawing.Size(87, 23);
            this.btn_conversão.TabIndex = 0;
            this.btn_conversão.Text = "Converter";
            this.btn_conversão.UseVisualStyleBackColor = true;
            this.btn_conversão.Click += new System.EventHandler(this.btn_converter_click);
            // 
            // cb_conversao
            // 
            this.cb_conversao.FormattingEnabled = true;
            this.cb_conversao.Items.AddRange(new object[] {
            "Graus Celsius",
            "Graus Fahrenheit",
            "Kelvin"});
            this.cb_conversao.Location = new System.Drawing.Point(258, 52);
            this.cb_conversao.Name = "cb_conversao";
            this.cb_conversao.Size = new System.Drawing.Size(121, 21);
            this.cb_conversao.TabIndex = 1;
            this.cb_conversao.SelectedIndexChanged += new System.EventHandler(this.cb_conversao_SelectedIndexChanged);
            // 
            // lbl_conversao
            // 
            this.lbl_conversao.AutoSize = true;
            this.lbl_conversao.Location = new System.Drawing.Point(255, 36);
            this.lbl_conversao.Name = "lbl_conversao";
            this.lbl_conversao.Size = new System.Drawing.Size(135, 13);
            this.lbl_conversao.TabIndex = 2;
            this.lbl_conversao.Text = "Será convertido para qual :";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(65, 113);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 3;
            this.txt_valor.Text = "0";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(50, 97);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(141, 13);
            this.lbl_valor.TabIndex = 4;
            this.lbl_valor.Text = "Digite o valor para converter";
            // 
            // lbl_converter
            // 
            this.lbl_converter.AutoSize = true;
            this.lbl_converter.Location = new System.Drawing.Point(32, 36);
            this.lbl_converter.Name = "lbl_converter";
            this.lbl_converter.Size = new System.Drawing.Size(178, 13);
            this.lbl_converter.TabIndex = 6;
            this.lbl_converter.Text = "Qual Temperatura deseja Converter:";
            this.lbl_converter.Click += new System.EventHandler(this.label3_Click);
            // 
            // cb_converter
            // 
            this.cb_converter.FormattingEnabled = true;
            this.cb_converter.Items.AddRange(new object[] {
            "Graus Celsius",
            "Graus Fahrenheit",
            "Kelvin"});
            this.cb_converter.Location = new System.Drawing.Point(53, 52);
            this.cb_converter.Name = "cb_converter";
            this.cb_converter.Size = new System.Drawing.Size(121, 21);
            this.cb_converter.TabIndex = 5;
            this.cb_converter.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(255, 97);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Enabled = false;
            this.txt_resultado.Location = new System.Drawing.Point(6, 41);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(66, 20);
            this.txt_resultado.TabIndex = 7;
            // 
            // lbl_tipo_resultado
            // 
            this.lbl_tipo_resultado.AutoSize = true;
            this.lbl_tipo_resultado.Location = new System.Drawing.Point(78, 44);
            this.lbl_tipo_resultado.Name = "lbl_tipo_resultado";
            this.lbl_tipo_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_tipo_resultado.TabIndex = 9;
            this.lbl_tipo_resultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_Resultado
            // 
            this.gb_Resultado.Controls.Add(this.txt_resultado);
            this.gb_Resultado.Controls.Add(this.lbl_tipo_resultado);
            this.gb_Resultado.Location = new System.Drawing.Point(218, 88);
            this.gb_Resultado.Name = "gb_Resultado";
            this.gb_Resultado.Size = new System.Drawing.Size(172, 86);
            this.gb_Resultado.TabIndex = 10;
            this.gb_Resultado.TabStop = false;
            this.gb_Resultado.Text = "Resultado: ";
            this.gb_Resultado.Enter += new System.EventHandler(this.gb_Resultado_Enter);
            // 
            // frm_Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 186);
            this.Controls.Add(this.gb_Resultado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_converter);
            this.Controls.Add(this.cb_converter);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_conversao);
            this.Controls.Add(this.cb_conversao);
            this.Controls.Add(this.btn_conversão);
            this.Name = "frm_Temperatura";
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.frm_Temperatura_Load);
            this.gb_Resultado.ResumeLayout(false);
            this.gb_Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conversão;
        private System.Windows.Forms.ComboBox cb_conversao;
        private System.Windows.Forms.Label lbl_conversao;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_converter;
        private System.Windows.Forms.ComboBox cb_converter;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_tipo_resultado;
        private System.Windows.Forms.GroupBox gb_Resultado;
    }
}