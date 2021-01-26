using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Final
{
    class Equipamentos
    {
        private List<Equipamento> equipamentos = new List<Equipamento>();

        public List<Equipamento> ListaEquips { get => equipamentos; set => equipamentos = value; }

        public void inserir (Equipamento equipamento)
        {
            this.equipamentos.Add(equipamento);
        }
    }
}
