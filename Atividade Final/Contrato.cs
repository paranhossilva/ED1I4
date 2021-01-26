using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Final
{
    class Contrato
    {
        private int id;
        private DateTime saida, retorno;
        private List<Equipamento> equipamentos;
        private bool liberado;

        public bool Liberado { get => liberado; set => liberado = value; }
        public int Id { get => id; }
        public List<Equipamento> Equipamentos { get => equipamentos; set => equipamentos = value; }

        public Contrato(int id, DateTime saida, DateTime retorno, List<Equipamento> equipamentos)
        {
            this.id = id;
            this.saida = saida;
            this.retorno = retorno;
            this.equipamentos = equipamentos;
            liberado = false;
        }

        public string toString()
        {
            string ret;

            ret = "ID:       " + id +
                  "\nSaída:    " + saida.ToString("dd/MM/aaaa") +
                  "\nRetorno:  " + retorno.ToString("dd/MM/aaaa") +
                  "\nLiberado: " + liberado.ToString() +
                  "\nEquipamantos:\n";

            foreach (Equipamento item in equipamentos)
            {
                ret += item.toString();
            }

            return ret;
        }
    }
}
