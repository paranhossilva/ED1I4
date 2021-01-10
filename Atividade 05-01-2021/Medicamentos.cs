using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05_01_2021
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        public Medicamentos()
        {
            listaMedicamentos = new List<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            if (medicamento.qtdDisponivel() == 0)
            {
                listaMedicamentos.Remove(medicamento);

                return true;
            }
            else
                return false;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento ret = new Medicamento();

            foreach (Medicamento item in listaMedicamentos)
            {
                if (item.Equals(medicamento))
                {
                    ret = item;
                }
            }

            return ret;
        }
    }
}
