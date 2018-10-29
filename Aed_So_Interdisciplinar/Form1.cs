using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aed_So_Interdisciplinar
{
    public partial class btnInserir : Form
    {

        Processo[] allProcess;
        static Escalonador escalonador = new Circular();
        Thread t1 = new Thread(AtivarExecucaoEscalonador);
        static bool a = true;
        static bool n = true;

        public btnInserir()
        {
            InitializeComponent();
        }

        static public void Thread_Principal()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeituraArquivo();
            timer1.Enabled = true;
        }
        
        public void LeituraArquivo()
        {
            LeituraArquivo arq;
            MessageBox.Show("Selecione o arquivo de processos");
            DialogResult processos = openFileDialog1.ShowDialog();
            arq = new LeituraArquivo(openFileDialog1.FileName);

            allProcess = arq.LeituraArquivoProcessos();

            escalonador.AdicionarProcessos(allProcess);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {       
            richTextBox1.Text = escalonador.Imprimir();
        }

        private void btnIniciarExecao_Click(object sender, EventArgs e)
        {
            t1.Start();
        }

        static public void AtivarExecucaoEscalonador()
        {
            try
            {
                while (n)
                {
                    escalonador.Executar();
                }
            }
            catch (System.OverflowException)
            {
                Thread t2 = new Thread(desativarExecucaoEscalonador);
                t2.Start();
            }
        }

        static public void desativarExecucaoEscalonador()
        {
            n = false;
        }
    }
}
