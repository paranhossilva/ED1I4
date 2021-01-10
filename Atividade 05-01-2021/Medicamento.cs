using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05_01_2021
{
    class Medicamento
    {
        private int id;
        private string nome, laboratorio;
        Queue<Lote> lotes;

        public Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        public Medicamento() : this(0, "", "") { }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }

        public int qtdDisponivel()
        {
            int ret = 0;

            foreach (Lote item in lotes)
            {
                ret += item.Qtd;
            }

            return ret;
        }

        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public bool vender(int qtd)
        {
            if (qtd <= qtdDisponivel())
            {
                do
                {
                    if (lotes.Peek().Qtd > qtd)
                    {
                        lotes.Peek().Qtd -= qtd;
                        qtd = 0;
                    }
                    else
                    {
                        if (lotes.Peek().Qtd == qtd)
                        {
                            lotes.Dequeue();
                            qtd = 0;
                        }
                        else
                        {
                            qtd -= lotes.Dequeue().Qtd;
                        }
                    }
                } while (qtd > 0);

                return true;
            }
            else
                return false;
        }

        public string toString()
        {
            return id + " - " + nome + " - " + laboratorio + " - " + qtdDisponivel();
        }

        override
        public bool Equals(object obj)
        {
            return this.id.Equals(((Medicamento)obj).id);
        }
    }
}
