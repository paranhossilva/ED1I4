using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19_01_2021
{
    class Garagens
    {
        private List<Garagem> garagens = new List<Garagem>();
        private bool jornadaAtiva;

        public List<Garagem> ListaGaragens { get => garagens; set => garagens = value; }

        public void incluir(Garagem garagem)
        {
            garagens.Add(garagem);
        }

        public void iniciarJornada()
        {
            jornadaAtiva = true;
        }

        public List<Transporte> encerarJornada()
        {
            List<Transporte> ret = new List<Transporte>();

            return ret;
        }
    }
}
