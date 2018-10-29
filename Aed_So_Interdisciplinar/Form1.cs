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
        Escalonador escalonador = new Circular();

        Thread atualizarInterface;
        Thread Execucao;
        Thread semaforo;

        Processo[] allProcess;
        

        public btnInserir()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            LeituraArquivo();
            
        }
        
        public void LeituraArquivo()
        {
            LeituraArquivo arq;
            MessageBox.Show("Selecione o arquivo de processos");
            DialogResult processos = openFileDialog1.ShowDialog();
            arq = new LeituraArquivo(openFileDialog1.FileName);

            allProcess = arq.LeituraArquivoProcessos();

            foreach (Processo t in allProcess)
            {

                listViewProcessos.Items.Add(new ListViewItem(new string[4] { Convert.ToString(t.getPrioridade()), t.getNomeProcesso(), Convert.ToString(t.getPID()), Convert.ToString(t.getNUmClicosExecutados()) }));
            }

            escalonador.AdicionarProcessos(allProcess);
        }

       

        private void btnIniciarExecao_Click(object sender, EventArgs e)
        {
           
        }

        

        
    }
}
