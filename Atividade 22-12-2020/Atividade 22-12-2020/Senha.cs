using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_22_12_2020
{
    class Senha
    {
        private int id;
        private DateTime dataGerac, horaGerac, dataAtend, horaAtend;

        public Senha(int id)
        {
            this.id = id;
            dataGerac = DateTime.Today;
            horaGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            return id + " - " + dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm:ss");
        }

        public string dadosCompletos()
        {
            dataAtend = DateTime.Today;
            horaAtend = DateTime.Now;

            return dadosParciais() + " - " + dataAtend.ToString("dd/MM/yyyy") + " - " + horaAtend.ToString("HH:mm:ss");
        }
    }
}
