using System;

namespace Atividade_10_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;
            Venda venda = new Venda();
            Vendedor vendedor = new Vendedor();
            Vendedores vendedores = new Vendedores();

            do
            {
                Console.WriteLine("0. Sair" + 
                                  "\n1.Cadastrar vendedor" + 
                                  "\n2.Consultar vendedor" +
                                  "\n3.Excluir vendedor" + 
                                  "\n4.Registrar venda" +
                                  "\n5.Listar vendedores");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (op)
                {
                    #region Sair

                    case 0:
                        Console.WriteLine("Saindo");

                        break;

                    #endregion

                    #region Cadastrar
                    
                    case 1:

                        vendedor.Id = vendedores.OsVededores.Count + 1;
                        
                        Console.Write("Informe o nome do Vendedor: ");
                        vendedor.Nome = Console.ReadLine();

                        Console.Write("Informe o percentual de comissão do Vendedor: ");
                        vendedor.PercComissao = double.Parse(Console.ReadLine()) / 100;

                        if(vendedores.addVendedor(vendedor))
                            Console.Write("Vendedor cadastrado com o ID " + vendedor.Id);
                        else
                            Console.Write("Vendedor não cadastrado");

                        break;

                    #endregion

                    #region Consultar

                    case 2:
                        Console.Write("Informe o ID do Vendedor: ");
                        vendedor.Id = int.Parse(Console.ReadLine());

                        vendedor = vendedores.searchVendedor(vendedor);

                        if (vendedor == null)
                            Console.WriteLine("Vendedor não encontrado");
                        else
                        {
                            Console.WriteLine("ID      : " + vendedor.Id +
                                              "\nNome    : " + vendedor.Nome +
                                              "\nVendas  : " + vendedor.valorVendas().ToString("c") +
                                              "\nComissão: " + vendedor.valorComissao().ToString("c"));
                        }
                        break;

                    #endregion

                    #region Excluir

                    case 3:
                        Console.Write("Informe o ID do Vendedor: ");
                        vendedor.Id = int.Parse(Console.ReadLine());

                        if(vendedores.delVendedor(vendedor))
                            Console.WriteLine("Vendedor excluído");
                        else
                            Console.WriteLine("Vendedor excluído");



                        break;

                    #endregion

                    #region Registrar

                    case 4:
                        Console.Write("Informe o valor da venda: ");
                        venda.Valor = double.Parse(Console.ReadLine());

                        Console.Write("Informe aquantidade da venda: ");
                        venda.Qtd = int.Parse(Console.ReadLine());

                        Console.Write("Informe o ID do Vendedor: ");
                        vendedor.Id = int.Parse(Console.ReadLine());

                        int i = vendedores.OsVededores.IndexOf(vendedor);
                        vendedores.OsVededores[i].registrarVenda(venda);

                        break;

                    #endregion

                    #region Listar

                    case 5:

                        double totalVenda = 0, totalComissao = 0;

                        foreach (Vendedor item in vendedores.OsVededores)
                        {
                            Console.WriteLine("ID      : " + item.Id +
                                              "\nNome    : " + item.Nome +
                                              "\nVendas  : " + item.valorVendas().ToString("c") +
                                              "\nComissão: " + item.valorComissao().ToString("c"));

                            Console.WriteLine("\n-----------------------------------------------------------------------\n");

                            totalVenda += item.valorVendas();
                            totalComissao += item.valorComissao();
                        }

                        Console.WriteLine("Total de vendas: " + totalVenda.ToString("c"));
                        Console.WriteLine("Total de comissão: " + totalComissao.ToString("c"));
                break;
                    #endregion

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                
                Console.ReadKey();
                Console.Clear();
                

            } while (op != 0);
                       
            GC.Collect();
        }
    }
}
