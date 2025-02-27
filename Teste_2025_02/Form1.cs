using System.Web;

namespace Teste_2025_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CalcularPercentualRepresentacao()
        {
            List<decimal> listaDeValores = new List<decimal> { 67836.43m, 36678.66m, 29229.88m, 27165.48m, 19849.53m };
            List<string> listaDeEstados = new List<string> { "SP", "RJ", "MG", "ES", "Outros" };

            decimal valorTotal = listaDeValores.Sum();

            int contador = 0;

            foreach (decimal valor in listaDeValores)
            {
                decimal percentual = CalcularPercentual(valorTotal, valor);
                listBox1.Items.Add(listaDeEstados[contador] + " - " + percentual.ToString("n4") + " %");
                contador++;
            }
        }

        private decimal CalcularPercentual(decimal valorTotal, decimal valorParcial)
        {
            return (100m * valorParcial) / valorTotal;
        }


        private static void InverterCaracteresDeString()
        {
            string info = "Esta string será exibida de forma invertida.";
            int tamanhoString = info.Length;
            string resultado = String.Empty;

            for (int i = tamanhoString - 1; i >= 0; i--)
            {
                resultado += info[i];
            }

            MessageBox.Show(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InverterCaracteresDeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcularPercentualRepresentacao();
        }
    }
}
