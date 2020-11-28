using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_10_11_2020
{
    class Vendedores
    {
        private static List<Vendedor> osVededores = new List<Vendedor>();
        private static int max = 10, qtd;
        
        #region Getter & Setters
        
        public List<Vendedor> OsVededores { get => osVededores; set => osVededores = value; }
        public int Max { get => max; set => max = value; }
        public int Qtd { get => qtd; set => qtd = value; }

        #endregion

        public bool addVendedor(Vendedor v)
        {
            bool ret = OsVededores.Count < max;

            if (ret)
                OsVededores.Add(v); 

            return ret;            
        }

        public bool delVendedor(Vendedor v)
        {
            int i = OsVededores.IndexOf(v);

            bool ret = OsVededores[i].AsVendas.Count > 0 && OsVededores.Contains(v);

            if (!ret)
                OsVededores.RemoveAt(i);

            return (!ret);
        }

        public Vendedor searchVendedor(Vendedor v)
        {
            if (osVededores.Contains(v))
                return OsVededores[osVededores.IndexOf(v)];
            else
                return null;
        }

        public double valorVendas()
        {
            double ret = 0;

            foreach (Vendedor item in OsVededores)
            {
                ret += item.valorVendas();
            }

            return ret;
        }

        public double valorComissao()
        {
            double ret = 0;

            foreach (Vendedor item in OsVededores)
            {
                ret += item.valorComissao();
            }

            return ret;
        }
    }
}
