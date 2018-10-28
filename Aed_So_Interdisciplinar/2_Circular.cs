using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aed_So_Interdisciplinar
{
    class Circular : Escalonador
    {
        public Fila[] fila;
        static int quantum = 5000;

        public override void AdicionarProcessos(Processo[] processos)
        {
            fila = new Fila[20];
            IncializarFilas();
            foreach (Processo i in processos)
            {
                fila[i.getPrioridade() - 1].Inserir(i);
 
            }
        }

        public  void IncializarFilas()
        {
            for(int i =0; i<fila.Length; i++)
            {
                fila[i] = new Fila();
            }
        }


        static int cont = 0;
        public override void Executar()
        {
            while (!fila[cont].filaVazia())
            {
                Processo processo = fila[cont].Desenfileirar();

                processo.ativarStatusExec();

                Thread.Sleep(quantum);

                processo.setNCiclos(processo.getNCiclos() - 1);

                processo.InclementCicloExecut();


                if (processo.getNUmClicosExecutados() >= 4) ReduzirPriori(processo);
                else if (processo.getNCiclos() == 0) fila[cont].Retirar();
                else fila[cont].proximo();

            }
            cont++;


            if (cont >= fila.Length) throw new System.OverflowException();
        }



        private void ReduzirPriori(Processo processo)
        {
            fila[processo.getPrioridade() - 1].Retirar();
            fila[processo.getPrioridade()].Inserir(processo);
        }


      public override string Imprimir()
        {
            string  arq = " ";
            foreach (Fila t in fila)
            {
                arq += t.Imprimir();
            }         
            return arq;
        }

       

    }
}
