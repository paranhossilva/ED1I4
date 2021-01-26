using System;
using System.Collections.Generic;

namespace Atividade_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;
            int id;
            string tipo;
            Equipamento equipamento;
            Equipamentos equipamentos = new Equipamentos();
            Contrato contrato;
            Contratos contratos = new Contratos();
            DateTime saida, retorno;
            char c;
            int i = 0;
            bool b = true;

            do
            {
                Console.WriteLine("0. Sair" +
                                  "\n1. Cadastrar Tipo de Equipamento" +
                                  "\n2. Consultar Tipo de Equipamento" +
                                  "\n3. Cadastrar Equipamento" +
                                  "\n4. Registrar Contrato de Locação" +
                                  "\n5. Consultar Contratos de Locação" +
                                  "\n6. Liberar de Contrato de Locação" +
                                  "\n7. Consultar Contratos de Locação Liberados" +
                                  "\n8. Devolver Equipamentos");
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

                    #region Cadastrar Tipo

                    case 1:
                       
                        break;

                    #endregion

                    #region Consultar Tipo

                    case 2:
                        Console.Write("Informe o tipo do equipamento: ");
                        tipo = Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("Equipamentos do tipo {0}: ", tipo);

                        i = 0;
                        b = true;

                        foreach (Equipamento item in equipamentos.ListaEquips)
                        {
                            if (item.Tipo == tipo)
                                Console.WriteLine(item.toString());
                        }

                        break;

                    #endregion

                    #region Cadastrar Equipamento

                    case 3:
                        Console.Write("Informe o ID do equipamento: ");
                        id = int.Parse(Console.ReadLine());

                        Console.Write("Informe o tipo do equipamento: ");
                        tipo = Console.ReadLine();

                        equipamento = new Equipamento(id, tipo);

                        equipamentos.inserir(equipamento);
                        
                        break;

                    #endregion

                    #region Registrar Contrato

                    case 4:
                        List<Equipamento> lista = new List<Equipamento>();

                        Console.Write("Informe o ID do contrato: ");
                        id = int.Parse(Console.ReadLine());

                        Console.Write("Informe a data de saída: ");
                        saida = DateTime.Parse(Console.ReadLine());

                        Console.Write("Informe a data de retorno: ");
                        retorno = DateTime.Parse(Console.ReadLine());

                        do
                        {
                            Console.Write("Informe o tipo do equipamento para locação: ");
                            tipo = Console.ReadLine();

                            Console.Clear();

                            i = 0;
                            b = true;

                            do
                            {
                                if (equipamentos.ListaEquips[i].Tipo == tipo && !equipamentos.ListaEquips[i].Avariado && !equipamentos.ListaEquips[i].Locado)
                                    b = false;
                                else
                                    i++;
                                
                            } while (b && i < equipamentos.ListaEquips.Count);

                            if (i < equipamentos.ListaEquips.Count)
                            {
                                lista.Add(equipamentos.ListaEquips[i]);
                                equipamentos.ListaEquips[i].Locado = true;

                                Console.WriteLine("Deseja adicionar outro equipamento à lista?(S/N)");
                                c = Console.ReadLine()[0];
                            }
                            else
                            {
                                Console.WriteLine("Equipamento não encontrado!");
                                
                                Console.WriteLine("Aperte qualquer tecla para continuar...");
                                Console.ReadKey();

                                c = 'S';
                            }

                            Console.Clear();

                        } while (c == 'S' || c == 's');

                        contrato = new Contrato(id, saida, retorno, lista);

                        contratos.inserir(contrato);

                        Console.WriteLine("Contrato cadastrado");

                        break;

                    #endregion

                    #region Consultar Contratos

                    case 5:
                        Console.WriteLine(contratos.exibir());
                        
                        break;

                    #endregion

                    #region Liberar Contrato

                    case 6:
                        Console.Write("Informe o ID do contrato: ");
                        id = int.Parse(Console.ReadLine());

                        Console.Clear();

                        i = 0;
                        b = true;

                        do
                        {
                            if (contratos.ListaContratos[i].Id == id)
                                b = false;
                            else
                                i++;

                        } while (b && i < contratos.ListaContratos.Count);

                        if (i < contratos.ListaContratos.Count)
                        {
                            contratos.ListaContratos[i].Liberado = true;
                            Console.WriteLine("Contrato Liberado");
                        }
                        else
                            Console.WriteLine("Contrato Não Encontrado");
                        break;

                    #endregion

                    #region Consultar Contratos Liberados

                    case 7:
                        Console.WriteLine(contratos.exibirLiberados());

                        break;

                    #endregion

                    #region Devolver

                    case 8:
                        Console.Write("Informe o ID do contrato: ");
                        id = int.Parse(Console.ReadLine());

                        Console.Clear();

                        i = 0;
                        b = true;

                        do
                        {
                            if (contratos.ListaContratos[i].Id == id)
                                b = false;
                            else
                                i++;

                        } while (b && i < contratos.ListaContratos.Count);


                        if (i < contratos.ListaContratos.Count)
                        {
                            foreach (Equipamento item in equipamentos.ListaEquips)
                            {
                                foreach (Equipamento item2 in contratos.ListaContratos[i].Equipamentos)
                                {
                                    if (item.Id == item2.Id)
                                        item.Locado = false;
                                }
                            }

                            contratos.ListaContratos[i].Equipamentos.Clear();
                        }
                        else
                            Console.WriteLine("Contrato Não Encontrado");

                        break;

                    #endregion

                    #region Default

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;

                    #endregion
                }

                Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();


            } while (op != 0);

            GC.Collect();
        }
    }
}
