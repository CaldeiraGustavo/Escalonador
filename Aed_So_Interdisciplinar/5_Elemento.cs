using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aed_So_Interdisciplinar
{
    class Elemento
    {
        public Processo processo;
        public Elemento prox;

        public Elemento(Processo processo)
        {
            this.processo = processo;
        }
    }
}
