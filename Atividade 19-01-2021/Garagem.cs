using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19_01_2021
{
    class Garagem
    {
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;

        public Stack<Veiculo> Veiculos
        {
            get { return veiculos; }
            set { veiculos = value; }
        }

        public Garagem(int id, string local)
        {
            this.id = id;
            this.local = local;
            veiculos = new Stack<Veiculo>();
        }

        private int qtdVeiculos()
        {
            return veiculos.Count();
        }

        private int potencialTransporte()
        {
            int ret = 0;

            foreach (Veiculo item in veiculos)
            {
                ret += item.Lotacao;
            }

            return ret;
        }
    }
}
