namespace Calculadora_interfeces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {

            int valor1, valor2;
            //Entrada de datos
            valor1 = int.Parse(txt_Valor1.Text);
            valor2 = int.Parse(txt_Valor2.Text);
            //Proceso
            int resultado = valor1 + valor2;
            int Resta = valor1 - valor2;
            int Multiplicacion = valor1 * valor2;
            int Division = valor1 / valor2;

            //Salida de datos
            txt_Resultado.Text = resultado.ToString();
            txt_Resta.Text = Resta.ToString();
            txt_Multiplicacion.Text = Multiplicacion.ToString();
            txt_Division.Text = Division.ToString();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Valor1.Clear();
            txt_Valor2.Clear();
            txt_Resultado.Clear();
            txt_Resta.Clear();
            txt_Multiplicacion.Clear();
            txt_Division.Clear();

        }

        private void btn_Leave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}