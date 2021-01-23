using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_19_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variáveis

            int op = -1;
            int id, lotacao;
            string placa;
            Veiculo veiculo;
            Veiculos veiculos = new Veiculos();
            string local;
            Garagem garagem;
            Garagens garagens = new Garagens();

            #endregion

            do
            {
                Console.WriteLine("0. Sair" +
                                  "\n1.Cadastrar Veículo" +
                                  "\n2.Cadastrar Garagem" +
                                  "\n3.Iniciar Jornada" +
                                  "\n4.Encerrar Jornada" +
                                  "\n5.Liberar Viagem" + 
                                  "\n6.Listar Veículos" +
                                  "\n7.Informar Quantidade de Viagens" +
                                  "\n8.Listar Viagens Efetuadas" +
                                  "\n9.Informar Quantidade de Passageiros");
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

                    #region Cadastrar Veículo

                    case 1:  
                        Console.WriteLine("informe o ID do veículo");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("informe a lotação do veículo");
                        lotacao = int.Parse(Console.ReadLine());

                        Console.WriteLine("informe a placa do veículo");
                        placa = Console.ReadLine();

                        veiculo = new Veiculo(id, placa, lotacao);

                        veiculos.incluir(veiculo);

                        break;

                    #endregion

                    #region Cadastrar Garagem

                    case 2:
                        Console.WriteLine("informe o ID do garagem");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("informe o local da garagem");
                        local = Console.ReadLine();

                        garagem = new Garagem(id, local);

                        garagens.incluir(garagem);

                        break;

                    #endregion

                    #region Iniciar

                    case 3:

                        break;

                    #endregion

                    #region Encerrar

                    case 4:

                        break;

                    #endregion

                    #region Liberar

                    case 5:

                        break;
                    
                    #endregion

                    #region Listar Veículos

                    case 6:
                        Console.WriteLine("informe o ID da garagem");
                        id = int.Parse(Console.ReadLine());

                        foreach (Garagem item in garagens.ListaGaragens)
                        {
                            //item.Veiculos
                        }

                        break;

                    #endregion

                    #region Informar Viagens

                    case 7:

                        break;

                    #endregion

                    #region Listar Viagens

                    case 8:

                        break;

                    #endregion

                    #region Informar Passageiros

                    case 9:

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
