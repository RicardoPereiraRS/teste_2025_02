using System;
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


        // Qust�o 1:

        private void Somar()
        {
            listBox1.Items.Clear();
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
                listBox1.Items.Add("SOMA = " + soma.ToString());

            }
            MessageBox.Show("Valor total da vari�vel SOMA: " + soma.ToString());
        }

        // Quest�o 2:

        void VerificarSeNumEFibonacci()
        {

            int numeroParaVerificar = int.Parse(txtNumero.Text);

            int n1 = 0;
            int n2 = 1;
            int proximo;

            Console.WriteLine("Sequ�ncia de Fibonacci:");
            Console.Write(n1 + " " + n2 + " ");

            while (true)
            {
                proximo = n1 + n2;

                if (numeroParaVerificar == proximo)
                {
                    MessageBox.Show("O n�mero digitado pertence a sequencia Fibonacci.");
                    break;
                }
                if (proximo > numeroParaVerificar )
                {
                    MessageBox.Show("O n�mero digitado n�o pertence a sequencia Fibonacci.");
                    break;
                }
                n1 = n2;
                n2 = proximo;
            }
        }

        // Quest�o 4:
        private void CalcularPercentualRepresentacao()
        {
            listBox1.Items.Clear();

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

        // Quest�o 5:
        private static void InverterCaracteresDeString()
        {
            string info = "Esta string ser� exibida de forma invertida.";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Somar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarSeNumEFibonacci();
        }
    }
}
