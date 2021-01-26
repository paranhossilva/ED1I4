using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Final
{
    class Contratos
    {
        List<Contrato> contratos = new List<Contrato>();

        public List<Contrato> ListaContratos { get => contratos; set => contratos = value; }

        public void inserir(Contrato contrato)
        {
            this.contratos.Add(contrato);
        }

        public string exibir()
        {
            string ret = "";

            foreach (Contrato item in contratos)
            {
                ret += item.toString() + "\n----------------------------------------\n";
            }

            return ret;
        }

        public string exibirLiberados()
        {
            string ret = "";

            foreach (Contrato item in contratos)
            {
                if(item.Liberado)
                    ret += item.toString() + "\n----------------------------------------\n";
            }

            return ret;
        }
    }
}
