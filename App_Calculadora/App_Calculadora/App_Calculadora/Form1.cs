namespace App_Calculadora
{
    public partial class Form_Principal : Form
    {
        private const int _tamanhoValor = 5;
        private Calculadora calc = new Calculadora();
        private double valor1, valor2;
        private string operacaoSelecionada;

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void btn_Um_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                // lbl_valor.Text = lbl_valor.Text + "1";
                lbl_valor.Text += "1";
            }
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "2";
            }
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "3";
            }
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "4";
            }
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "5";
            }
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "6";
            }
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "7";
            }
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "8";
            }
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            if (lbl_valor.Text.Length < _tamanhoValor)
            {
                lbl_valor.Text += "9";
            }
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(lbl_valor.Text);
            operacaoSelecionada = "Soma";

            lbl_cima.Text = $"{valor1} + ";

            lbl_valor.Text = "";
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            switch (operacaoSelecionada)
            {
                case "Soma":
                    valor2 = Convert.ToDouble(lbl_valor.Text);
                    lbl_cima.Text = $"{valor1} + {valor2} =";
                    lbl_valor.Text = calc.Soma(valor1, valor2).ToString();
                    break;
            }
        }


        private void btn_apagar_Click_1(object sender, EventArgs e)
        {
            lbl_valor.Text = "";
            lbl_cima.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacaoSelecionada = "";

        }

        private void btn_apagarTudo_Click_1(object sender, EventArgs e)
        {
            lbl_valor.Text = "";
        }
    }
}






   
