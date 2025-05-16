namespace App_Calculadora
{
    partial class Form_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_apresentacao = new Label();
            lbl_cima = new Label();
            lbl_valor = new Label();
            btn_Um = new Button();
            btn_dois = new Button();
            btn_tres = new Button();
            btn_seis = new Button();
            btn_cinco = new Button();
            btn_quatro = new Button();
            btn_sete = new Button();
            btn_oito = new Button();
            btn_nove = new Button();
            btn_subtracao = new Button();
            btn_zero = new Button();
            btn_divicao = new Button();
            btn_soma = new Button();
            btn_multiplicacao = new Button();
            btn_resultado = new Button();
            btn_virgula = new Button();
            btn_raiz = new Button();
            btn_apagarTudo = new Button();
            btn_apagar = new Button();
            SuspendLayout();
            // 
            // lbl_apresentacao
            // 
            lbl_apresentacao.AutoSize = true;
            lbl_apresentacao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_apresentacao.Location = new Point(25, 25);
            lbl_apresentacao.Margin = new Padding(16);
            lbl_apresentacao.Name = "lbl_apresentacao";
            lbl_apresentacao.Size = new Size(144, 21);
            lbl_apresentacao.TabIndex = 0;
            lbl_apresentacao.Text = "Minha Calculadora";
            // 
            // lbl_cima
            // 
            lbl_cima.AutoSize = true;
            lbl_cima.Location = new Point(25, 62);
            lbl_cima.Name = "lbl_cima";
            lbl_cima.Size = new Size(19, 21);
            lbl_cima.TabIndex = 1;
            lbl_cima.Text = "...";
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Location = new Point(25, 92);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(0, 21);
            lbl_valor.TabIndex = 2;
            // 
            // btn_Um
            // 
            btn_Um.BackColor = Color.FromArgb(202, 202, 202);
            btn_Um.FlatAppearance.BorderSize = 0;
            btn_Um.FlatStyle = FlatStyle.Flat;
            btn_Um.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_Um.Location = new Point(25, 311);
            btn_Um.Name = "btn_Um";
            btn_Um.Size = new Size(48, 48);
            btn_Um.TabIndex = 7;
            btn_Um.Text = "1";
            btn_Um.UseVisualStyleBackColor = false;
            btn_Um.Click += btn_Um_Click;
            // 
            // btn_dois
            // 
            btn_dois.BackColor = Color.FromArgb(202, 202, 202);
            btn_dois.FlatAppearance.BorderSize = 0;
            btn_dois.FlatStyle = FlatStyle.Flat;
            btn_dois.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_dois.Location = new Point(79, 311);
            btn_dois.Name = "btn_dois";
            btn_dois.Size = new Size(48, 48);
            btn_dois.TabIndex = 8;
            btn_dois.Text = "2";
            btn_dois.UseVisualStyleBackColor = false;
            btn_dois.Click += btn_dois_Click;
            // 
            // btn_tres
            // 
            btn_tres.BackColor = Color.FromArgb(202, 202, 202);
            btn_tres.FlatAppearance.BorderSize = 0;
            btn_tres.FlatStyle = FlatStyle.Flat;
            btn_tres.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_tres.Location = new Point(133, 311);
            btn_tres.Name = "btn_tres";
            btn_tres.Size = new Size(48, 48);
            btn_tres.TabIndex = 9;
            btn_tres.Text = "3";
            btn_tres.UseVisualStyleBackColor = false;
            btn_tres.Click += btn_tres_Click;
            // 
            // btn_seis
            // 
            btn_seis.BackColor = Color.FromArgb(202, 202, 202);
            btn_seis.FlatAppearance.BorderSize = 0;
            btn_seis.FlatStyle = FlatStyle.Flat;
            btn_seis.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_seis.Location = new Point(133, 257);
            btn_seis.Name = "btn_seis";
            btn_seis.Size = new Size(48, 48);
            btn_seis.TabIndex = 6;
            btn_seis.Text = "6";
            btn_seis.UseVisualStyleBackColor = false;
            btn_seis.Click += btn_seis_Click;
            // 
            // btn_cinco
            // 
            btn_cinco.BackColor = Color.FromArgb(202, 202, 202);
            btn_cinco.FlatAppearance.BorderSize = 0;
            btn_cinco.FlatStyle = FlatStyle.Flat;
            btn_cinco.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_cinco.Location = new Point(79, 257);
            btn_cinco.Name = "btn_cinco";
            btn_cinco.Size = new Size(48, 48);
            btn_cinco.TabIndex = 5;
            btn_cinco.Text = "5";
            btn_cinco.UseVisualStyleBackColor = false;
            btn_cinco.Click += btn_cinco_Click;
            // 
            // btn_quatro
            // 
            btn_quatro.BackColor = Color.FromArgb(202, 202, 202);
            btn_quatro.FlatAppearance.BorderSize = 0;
            btn_quatro.FlatStyle = FlatStyle.Flat;
            btn_quatro.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_quatro.Location = new Point(25, 257);
            btn_quatro.Name = "btn_quatro";
            btn_quatro.Size = new Size(48, 48);
            btn_quatro.TabIndex = 4;
            btn_quatro.Text = "4";
            btn_quatro.UseVisualStyleBackColor = false;
            btn_quatro.Click += btn_quatro_Click;
            // 
            // btn_sete
            // 
            btn_sete.BackColor = Color.FromArgb(202, 202, 202);
            btn_sete.FlatAppearance.BorderSize = 0;
            btn_sete.FlatStyle = FlatStyle.Flat;
            btn_sete.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_sete.Location = new Point(25, 203);
            btn_sete.Name = "btn_sete";
            btn_sete.Size = new Size(48, 48);
            btn_sete.TabIndex = 1;
            btn_sete.Text = "7";
            btn_sete.UseVisualStyleBackColor = false;
            btn_sete.Click += btn_sete_Click;
            // 
            // btn_oito
            // 
            btn_oito.BackColor = Color.FromArgb(202, 202, 202);
            btn_oito.FlatAppearance.BorderSize = 0;
            btn_oito.FlatStyle = FlatStyle.Flat;
            btn_oito.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_oito.Location = new Point(79, 203);
            btn_oito.Name = "btn_oito";
            btn_oito.Size = new Size(48, 48);
            btn_oito.TabIndex = 2;
            btn_oito.Text = "8";
            btn_oito.UseVisualStyleBackColor = false;
            btn_oito.Click += btn_oito_Click;
            // 
            // btn_nove
            // 
            btn_nove.BackColor = Color.FromArgb(202, 202, 202);
            btn_nove.FlatAppearance.BorderSize = 0;
            btn_nove.FlatStyle = FlatStyle.Flat;
            btn_nove.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_nove.Location = new Point(133, 203);
            btn_nove.Name = "btn_nove";
            btn_nove.Size = new Size(48, 48);
            btn_nove.TabIndex = 3;
            btn_nove.Text = "9";
            btn_nove.UseVisualStyleBackColor = false;
            btn_nove.Click += btn_nove_Click;
            // 
            // btn_subtracao
            // 
            btn_subtracao.BackColor = Color.FromArgb(202, 202, 202);
            btn_subtracao.FlatAppearance.BorderSize = 0;
            btn_subtracao.FlatStyle = FlatStyle.Flat;
            btn_subtracao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_subtracao.Location = new Point(187, 257);
            btn_subtracao.Name = "btn_subtracao";
            btn_subtracao.Size = new Size(48, 48);
            btn_subtracao.TabIndex = 13;
            btn_subtracao.Text = "-";
            btn_subtracao.UseVisualStyleBackColor = false;
            // 
            // btn_zero
            // 
            btn_zero.BackColor = Color.FromArgb(202, 202, 202);
            btn_zero.FlatAppearance.BorderSize = 0;
            btn_zero.FlatStyle = FlatStyle.Flat;
            btn_zero.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_zero.Location = new Point(79, 365);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(48, 48);
            btn_zero.TabIndex = 10;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = false;
            // 
            // btn_divicao
            // 
            btn_divicao.BackColor = Color.FromArgb(202, 202, 202);
            btn_divicao.FlatAppearance.BorderSize = 0;
            btn_divicao.FlatStyle = FlatStyle.Flat;
            btn_divicao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_divicao.Location = new Point(187, 203);
            btn_divicao.Name = "btn_divicao";
            btn_divicao.Size = new Size(48, 48);
            btn_divicao.TabIndex = 14;
            btn_divicao.Text = "/";
            btn_divicao.UseVisualStyleBackColor = false;
            // 
            // btn_soma
            // 
            btn_soma.BackColor = Color.FromArgb(202, 202, 202);
            btn_soma.FlatAppearance.BorderSize = 0;
            btn_soma.FlatStyle = FlatStyle.Flat;
            btn_soma.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_soma.Location = new Point(241, 203);
            btn_soma.Name = "btn_soma";
            btn_soma.Size = new Size(48, 48);
            btn_soma.TabIndex = 12;
            btn_soma.Text = "+";
            btn_soma.UseVisualStyleBackColor = false;
            btn_soma.Click += btn_soma_Click;
            // 
            // btn_multiplicacao
            // 
            btn_multiplicacao.BackColor = Color.FromArgb(202, 202, 202);
            btn_multiplicacao.FlatAppearance.BorderSize = 0;
            btn_multiplicacao.FlatStyle = FlatStyle.Flat;
            btn_multiplicacao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_multiplicacao.Location = new Point(241, 257);
            btn_multiplicacao.Name = "btn_multiplicacao";
            btn_multiplicacao.Size = new Size(48, 48);
            btn_multiplicacao.TabIndex = 15;
            btn_multiplicacao.Text = "*";
            btn_multiplicacao.UseVisualStyleBackColor = false;
            // 
            // btn_resultado
            // 
            btn_resultado.BackColor = Color.FromArgb(202, 202, 202);
            btn_resultado.FlatAppearance.BorderSize = 0;
            btn_resultado.FlatStyle = FlatStyle.Flat;
            btn_resultado.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_resultado.Location = new Point(241, 365);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(48, 48);
            btn_resultado.TabIndex = 17;
            btn_resultado.Text = "=";
            btn_resultado.UseVisualStyleBackColor = false;
            btn_resultado.Click += btn_resultado_Click;
            // 
            // btn_virgula
            // 
            btn_virgula.BackColor = Color.FromArgb(202, 202, 202);
            btn_virgula.FlatAppearance.BorderSize = 0;
            btn_virgula.FlatStyle = FlatStyle.Flat;
            btn_virgula.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_virgula.Location = new Point(25, 365);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(48, 48);
            btn_virgula.TabIndex = 11;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = false;
            // 
            // btn_raiz
            // 
            btn_raiz.BackColor = Color.FromArgb(202, 202, 202);
            btn_raiz.FlatAppearance.BorderSize = 0;
            btn_raiz.FlatStyle = FlatStyle.Flat;
            btn_raiz.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_raiz.Location = new Point(241, 311);
            btn_raiz.Name = "btn_raiz";
            btn_raiz.Size = new Size(48, 48);
            btn_raiz.TabIndex = 16;
            btn_raiz.Text = "√";
            btn_raiz.UseVisualStyleBackColor = false;
            // 
            // btn_apagarTudo
            // 
            btn_apagarTudo.BackColor = Color.FromArgb(202, 202, 202);
            btn_apagarTudo.FlatAppearance.BorderSize = 0;
            btn_apagarTudo.FlatStyle = FlatStyle.Flat;
            btn_apagarTudo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_apagarTudo.Location = new Point(188, 149);
            btn_apagarTudo.Name = "btn_apagarTudo";
            btn_apagarTudo.Size = new Size(48, 48);
            btn_apagarTudo.TabIndex = 18;
            btn_apagarTudo.Text = "CE";
            btn_apagarTudo.UseVisualStyleBackColor = false;
            btn_apagarTudo.Click += btn_apagarTudo_Click_1;
            // 
            // btn_apagar
            // 
            btn_apagar.BackColor = Color.FromArgb(202, 202, 202);
            btn_apagar.FlatAppearance.BorderSize = 0;
            btn_apagar.FlatStyle = FlatStyle.Flat;
            btn_apagar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_apagar.Location = new Point(241, 149);
            btn_apagar.Name = "btn_apagar";
            btn_apagar.Size = new Size(48, 48);
            btn_apagar.TabIndex = 19;
            btn_apagar.Text = "C";
            btn_apagar.UseVisualStyleBackColor = false;
            btn_apagar.Click += btn_apagar_Click_1;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(314, 433);
            Controls.Add(btn_apagar);
            Controls.Add(btn_apagarTudo);
            Controls.Add(btn_raiz);
            Controls.Add(btn_virgula);
            Controls.Add(btn_resultado);
            Controls.Add(btn_multiplicacao);
            Controls.Add(btn_soma);
            Controls.Add(btn_divicao);
            Controls.Add(btn_zero);
            Controls.Add(btn_subtracao);
            Controls.Add(btn_nove);
            Controls.Add(btn_oito);
            Controls.Add(btn_sete);
            Controls.Add(btn_quatro);
            Controls.Add(btn_cinco);
            Controls.Add(btn_seis);
            Controls.Add(btn_tres);
            Controls.Add(btn_dois);
            Controls.Add(btn_Um);
            Controls.Add(lbl_valor);
            Controls.Add(lbl_cima);
            Controls.Add(lbl_apresentacao);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(4);
            MaximumSize = new Size(640, 480);
            MinimumSize = new Size(330, 412);
            Name = "Form_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_apresentacao;
        private Label lbl_cima;
        private Label lbl_valor;
        private Button btn_Um;
        private Button btn_dois;
        private Button btn_tres;
        private Button btn_seis;
        private Button btn_cinco;
        private Button btn_quatro;
        private Button btn_sete;
        private Button btn_oito;
        private Button btn_nove;
        private Button btn_subtracao;
        private Button btn_zero;
        private Button btn_divicao;
        private Button btn_soma;
        private Button btn_multiplicacao;
        private Button btn_resultado;
        private Button btn_virgula;
        private Button btn_raiz;
        private Button btn_apagarTudo;
        private Button btn_apagar;
    }
}
