using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Atividade_10_11_2020
{
    class Vendedor
    {
        private static int id;
        private static string nome;
        private static double percComissao;
        private static List<Venda> asVendas = new List<Venda>();

        #region Getter & Setters

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }
        public List<Venda> AsVendas { get => asVendas; set => asVendas = value; }

        #endregion

        public void registrarVenda(Venda venda)
        {
            if (AsVendas.Count < 31)
            {
                AsVendas.Add(venda);

                Console.WriteLine("Venda cadastrada");
            }
            else
                Console.WriteLine("Todos dias já foram cadastrados");            
        }

        public double valorVendas()
        {
            double ret = 0;

            foreach (Venda item in AsVendas)
            {
                ret += item.Valor * item.Qtd;
            }

            return ret;
        }

        public double valorComissao()
        {
            return valorVendas() * PercComissao;
        }
    }
}
