using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Final
{
    class Equipamento
    {
        private int id;
        private string tipo;
        private bool avariado, locado;

        public bool Avariado { get => avariado; set => avariado = value; }
        public bool Locado { get => locado; set => locado = value; }
        public string Tipo { get => tipo; }
        public int Id { get => id; }

        public Equipamento(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
            avariado = false;
            locado = false;
        }

        public string toString()
        {
            string ret;

            ret = "ID:   " + id +
                  "\nTipo: " + tipo + "\n";

            return ret;
        }
    }
}
