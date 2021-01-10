using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05_01_2021
{
    class Lote
    {
        private int id, qtd;
        private DateTime venc;

        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }


        public Lote() : this(0, 0, default) { }

        public Lote(int id, int qtd, DateTime venc)
        {
            this.id = id;
            this.qtd = qtd;
            this.venc = venc;
        }

        public string toString(){
            return id + " - " + qtd + " - " + venc;
        }
    } 
}
