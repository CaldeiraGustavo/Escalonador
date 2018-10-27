using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aed_So_Interdisciplinar
{


  public class Processo : Dado
    {
        private int pid;
        private int nCiclos;
        private int prioridade;
        private int numCiclosExec;
        private string nomeProcesso;
        private string statusProcesso = "Pronto" ;


        public Processo(int pid, string nomeProcesso, int prioridade, int nCiclos)
        {
            this.pid = pid;
            this.nomeProcesso = nomeProcesso;
            this.prioridade = prioridade;
            this.nCiclos = nCiclos;
        }


        public int getNCiclos() { return this.nCiclos; }
      

        public void setNCiclos(int temp) { this.nCiclos = temp; }
     

        public int getPrioridade() { return this.prioridade; }
       

        public void InclementCicloExecut() { this.numCiclosExec += 1; }
    

        public int getNUmClicosExecutados() { return this.numCiclosExec; }
    

       public override string Imprimir()
        {  
            return this.pid + " - " + this.nomeProcesso + "\t\t\t\t\t\t\t"   +   this.prioridade +  "   "  + this.nCiclos  + "   " + this.numCiclosExec + "  " + this.statusProcesso +  "\n";
        }

        public void ativarStatusExec() { this.statusProcesso = "Executando...."; }
    

        public void desativarStatusExec() { this.statusProcesso = "Pronto"; }
      



    }
}
