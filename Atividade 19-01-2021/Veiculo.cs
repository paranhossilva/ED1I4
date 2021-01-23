using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19_01_2021
{
    class Veiculo
    {
        private int id, lotacao;
        private string placa;

        #region Getters Setters

        public int Lotacao
        {
            get { return lotacao; }
            set { lotacao = value; }
        }

        public int Id
        {
            get { return id; }
        }
        
        public string Placa
        {
            get { return placa; }
        }

        #endregion

        public Veiculo(int id, string placa, int lotacao)
        {
            this.id = id;
            this.placa = placa;
            this.lotacao = lotacao;
        }
    }
}
