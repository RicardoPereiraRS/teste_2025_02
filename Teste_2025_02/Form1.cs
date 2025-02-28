using System;
using System.Data.SqlTypes;
using System.Web;
using System.Xml;

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


        // Qustão 1:

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
            MessageBox.Show("Valor total da variável SOMA: " + soma.ToString());
        }

        // Questão 2:

        void VerificarSeNumEFibonacci()
        {
            if (!int.TryParse(txtNumero.Text, out int numeroParaVerificar))
            {
                MessageBox.Show("Verifique o número digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n1 = 0;
            int n2 = 1;
            int proximo;

            Console.WriteLine("Sequência de Fibonacci:");
            Console.Write(n1 + " " + n2 + " ");

            while (true)
            {
                proximo = n1 + n2;

                if (numeroParaVerificar == proximo)
                {
                    MessageBox.Show("O número digitado pertence a sequencia Fibonacci.");
                    break;
                }
                if (proximo > numeroParaVerificar)
                {
                    MessageBox.Show("O número digitado não pertence a sequencia Fibonacci.");
                    break;
                }
                n1 = n2;
                n2 = proximo;
            }
        }

        // Questão 3:

        private void ExercicioXmlJson()
        {
            // Este exercício pode ter ficado incompleto, pois enviei o link do repositório do GIT
            // e finalizei a etapa antes de concluir a codificação e fiquei sem acesso ao que era 
            // solicitado no exercício.


            listBox1.Items.Clear();

            string stringDados = File.ReadAllText("dados.xml");
            stringDados = ("<root>" + stringDados + "</root>").Replace(".", ",");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(stringDados);
            XmlNodeList rowNodes = xmlDoc.SelectNodes("//row");
            List<Row> rows = new List<Row>();

            foreach (XmlNode rowNode in rowNodes)
            {
                Row row = new Row
                {
                    Dia = int.Parse(rowNode["dia"].InnerText),
                    Valor = double.Parse(rowNode["valor"].InnerText)
                };
                rows.Add(row);
            }

            double valorMaximo = rows.Max(item => item.Valor);
            double somaTotal = rows.Sum(item => item.Valor);
            double valorDia1 = rows.Where(item => item.Dia == 1).First().Valor;
            double valorUltimoDia = rows.Where(item => item.Dia == 30).First().Valor;

            listBox1.Items.Add("Valor máximo: " + valorMaximo.ToString());
            listBox1.Items.Add("Soma total: " + somaTotal.ToString());
            listBox1.Items.Add("Valor do dia 1: " + valorDia1.ToString());
            listBox1.Items.Add("Valor do último dia: " + valorUltimoDia.ToString());

        }

        // Questão 4:
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

        // Questão 5:
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

        private void button3_Click(object sender, EventArgs e)
        {
            Somar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarSeNumEFibonacci();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ExercicioXmlJson();
        }
    }
}
