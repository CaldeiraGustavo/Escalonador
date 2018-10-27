using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aed_So_Interdisciplinar
{
    class Fila : Estrutura
    {

        private Elemento atual, anterior;


        public Fila()
        {
            this.atual = new Elemento(null);

            this.anterior = this.atual;

            this.atual.prox = this.atual;

        }

        public override void Inserir(Processo processo)
        {
            Elemento novo = new Elemento(processo);

            this.anterior.prox = novo;
            novo.prox = this.atual;

            if (this.anterior == this.atual) this.atual = novo;
            else this.anterior = novo;

        }

        public override string Imprimir()
        {
            Elemento aux = atual.prox;
            string j = " ";
            while (aux.prox.processo != null)
            {
               j+= aux.prox.processo.Imprimir();

                aux = aux.prox;
            }
            return j;
        }

        public override Elemento Retirar()
        {
            Elemento aux = this.atual.prox;
            this.anterior.prox = aux.prox;

            if (this.atual == this.anterior) this.atual.prox = this.anterior;
            else aux.prox = null;
            return aux;
        }


        public bool filaVazia()
        {
            if (this.atual == this.anterior) return true;
            else return false;

        }


        public Processo Desenfileirar()
        {
           Processo processo = atual.processo;
            proximo();
            return processo;
        }

        public void proximo()
        {

            this.atual = this.atual.prox;

            this.anterior = this.anterior.prox;


            if (this.atual.processo == null)
            {

                this.atual = this.atual.prox;

                this.anterior = this.anterior.prox;
            }
        }



    }
}

