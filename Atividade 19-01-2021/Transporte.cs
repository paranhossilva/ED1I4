using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19_01_2021
{
    class Transporte
    {
        private Veiculo veiculo;
        private int qtdTransportada;

        #region Getters

        public Veiculo Veiculo
        {
            get { return veiculo; }
        }

        public int QtdTransportada
        {
            get { return qtdTransportada; }
        }

        #endregion

        public Transporte(Veiculo veiculo, int qtd)
        {
            this.veiculo = veiculo;
            this.qtdTransportada = qtd;
        }
    }
}
