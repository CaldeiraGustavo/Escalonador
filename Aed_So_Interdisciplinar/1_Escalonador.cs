using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aed_So_Interdisciplinar
{ 
   public abstract class Escalonador
    {
       

        public abstract void AdicionarProcessos(Processo[] processos);
        public abstract void Executar();
        public abstract string Imprimir();
    }
}
