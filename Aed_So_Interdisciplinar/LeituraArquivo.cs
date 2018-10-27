using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aed_So_Interdisciplinar
{
    class LeituraArquivo
    {


        private Escalonador escalonador;

        private Processo[] processo;

        private string nomeArquivoProcesso;

        public LeituraArquivo(String nomeArquivoProcessos)
        {
            this.nomeArquivoProcesso = nomeArquivoProcessos;
            escalonador = new Circular();
        }


        public Processo[] LeituraArquivoProcessos()
        {
            processo = new Processo[216];
            StreamReader arqProcessos;
            String l;
            String[] aux;

            arqProcessos = new StreamReader(nomeArquivoProcesso);
            try
            {
                

                l = arqProcessos.ReadLine();
                int i = 0;

                while (l != null)
                {
                    aux = l.Split(';');

                    processo[i] = new Processo(int.Parse(aux[0]), aux[1], int.Parse(aux[2]), int.Parse(aux[3]));

                    l = arqProcessos.ReadLine();
                    i++;
                }

            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }

            

            return processo;
        }
    }
}
