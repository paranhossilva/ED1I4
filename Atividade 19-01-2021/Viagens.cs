using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19_01_2021
{
    class Viagens
    {
        private Queue<Viagem> viagens;

        public void incluir(Viagem viagem)
        {
            viagens.Enqueue(viagem);
        }
    }
}
