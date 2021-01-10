using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;
            Lote lote = new Lote();
            Medicamento medicamento = new Medicamento();
            Medicamentos medicamentos = new Medicamentos();


            do
            {
                Console.WriteLine("0. Finalizar Processo" +
                                  "\n1. Cadastrar Medicamento" +
                                  "\n2. Consultar Medicamento (Sintético)" +
                                  "\n3. Consultar Medicamento (Analítico)" +
                                  "\n4. Comprar Medicamento" +
                                  "\n5. Vender Medicamento " +
                                  "\n6. Listar Medicamentos");
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
                        int id;
                        string nome, lab;

                        Console.Write("Informe o ID do medicamento: ");
                        id = int.Parse(Console.ReadLine());

                        Console.Write("Informe o nome do medicamento: ");
                        nome = Console.ReadLine();

                        Console.Write("Informe o fabricante do medicamento: ");
                        lab = Console.ReadLine();

                        medicamento = new Medicamento(id, nome, lab);

                        medicamentos.adicionar(medicamento);

                        break;

                    #endregion

                    #region Sintético

                    case 2:
                        Console.Write("Informe o ID do medicamento: ");
                        id = int.Parse(Console.ReadLine());

                        foreach (Medicamento item in medicamentos.ListaMedicamentos)
                        {
                            if (item.Equals(new Medicamento(id, "", "")))
                                Console.WriteLine(item.toString());
                        }

                        break;

                    #endregion

                    #region Analítico

                    case 3:
                        Console.Write("Informe o ID do medicamento: ");
                        id = int.Parse(Console.ReadLine());

                        foreach (Medicamento item in medicamentos.ListaMedicamentos)
                        {
                            if (item.Equals(new Medicamento(id, "", "")))
                            {
                                Console.WriteLine(item.toString());

                                Console.WriteLine("Lotes:");

                                foreach (Lote l in item.Lotes)
                                {
                                    Console.WriteLine(l.toString());
                                }
                            }
                        }

                        break;

                    #endregion

                    #region Comprar

                    case 4:
                        int idLote, idMed, qtd;
                        DateTime venc;

                        Console.Write("Informe o ID do medicamento: ");
                        idMed = int.Parse(Console.ReadLine());

                        Console.Write("Informe o ID do lote: ");
                        idLote = int.Parse(Console.ReadLine());

                        Console.Write("Informe a quantidade: ");
                        qtd = int.Parse(Console.ReadLine());

                        Console.Write("Informe a data de vencimento: ");
                        venc = DateTime.Parse(Console.ReadLine());

                        lote = new Lote(idLote, qtd, venc);

                        foreach (Medicamento item in medicamentos.ListaMedicamentos)
                        {
                            if (item.Equals(new Medicamento(idMed, "", "")))
                                item.comprar(lote);
                        }

                        break;

                    #endregion

                    #region Vender

                    case 5:                        
                        Console.Write("Informe o ID do medicamento: ");
                        id = int.Parse(Console.ReadLine());

                        Console.Write("Informe a quantidade: ");
                        qtd = int.Parse(Console.ReadLine());

                        foreach (Medicamento item in medicamentos.ListaMedicamentos)
                        {
                            if (item.Equals(new Medicamento(id, "", ""))) 
                            {
                                Console.Clear();

                                if (item.vender(qtd))
                                    Console.WriteLine("Vendido");
                                else
                                    Console.WriteLine("Quantidade insulficiente");
                            }
                        }

                        break;
                    #endregion

                    #region Listar

                    case 6:
                        foreach (Medicamento item in medicamentos.ListaMedicamentos)
                        {
                            Console.WriteLine(item.toString());
                        }

                        break;
                    #endregion

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                Console.Write("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();


            } while (op != 0);

            GC.Collect();
        }
    }
}
