using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19_01_2021
{
    class Veiculos
    {
        private List<Veiculo> veiculos = new List<Veiculo>();

        public void incluir(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }
    }
}
