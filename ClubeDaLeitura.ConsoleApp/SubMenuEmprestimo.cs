using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class SubMenuEmprestimo
    {
        Emprestimo[] ListaEmprestimo = new Emprestimo[10];
        int contadorEmprestimo = 0;

        string opcaoEmprestimo;

        public SubMenuAmigo amigosUtilizados;
        public SubMenuRevista revistaUtilizada;

        DateTime hoje = DateTime.Now;



        public void MenuEmprestimo()
        {



            while (true)
            {

                Console.WriteLine("SUBMENU CAIXA... ");
                Console.WriteLine("Digite 1 para cadastrar um emprestimo:");
                Console.WriteLine("Digite 2 para vizualizar emprestimos:");
                Console.WriteLine("Digite 3 para vizualizar emprestimos mensais:");
                Console.WriteLine("Digite 4 para vizualizar emprestimos diarios:");
                Console.WriteLine("Digite 'S' para sair:");
                opcaoEmprestimo = Console.ReadLine();

                if (opcaoEmprestimo == "1")
                {
                    Console.Clear();
                    cadastrarEmprestimo();
                }
                else if (opcaoEmprestimo == "2")
                {
                    Console.Clear();
                    vizualizarEmprestimo();
                }
                else if (opcaoEmprestimo == "3")
                {
                    Console.Clear();
                    emprestimosMensal();
                }
                else if (opcaoEmprestimo == "4")
                {
                    Console.Clear();
                    emprestimoDiario();
                }
                else if (opcaoEmprestimo == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção invalida, digite novamente... ");
                    continue;
                }


            }

        }

        public void cadastrarEmprestimo()
        {
            ListaEmprestimo[contadorEmprestimo] = new Emprestimo();

            amigosUtilizados.vizualizarAmigos();

            Console.WriteLine("Informe o ID do amigo:");
            int seletorAmigo = int.Parse(Console.ReadLine());

            ListaEmprestimo[contadorEmprestimo].quemEmprestou = amigosUtilizados.listaAmigo[seletorAmigo];


            revistaUtilizada.vizualizarRevista();


            Console.WriteLine("Informe qual o ID da revista:");
            int seletorRevista = int.Parse(Console.ReadLine());
            //                                                          objeto criado     array submenusrevista
            ListaEmprestimo[contadorEmprestimo].revistaEmprestada = revistaUtilizada.listaRevista[seletorRevista];


            Console.WriteLine("Informe a data de retirada da revista:");
            string emprestimo = Console.ReadLine();

            string[] dataSeparadaRetirada = emprestimo.Split("/");
            int diaEmprestimo = int.Parse(dataSeparadaRetirada[0]);    //0   1   2
            int mesEmprestimo = int.Parse(dataSeparadaRetirada[1]);   // 02 /03 /2022
            int anoEmprestimo = int.Parse(dataSeparadaRetirada[2]);

            ListaEmprestimo[contadorEmprestimo].dataRetirada = new DateTime(anoEmprestimo, mesEmprestimo, diaEmprestimo);



            Console.WriteLine("Informe a data de devolução da revista:");
            string devolucao = Console.ReadLine();

            string[] dataSeparadaDevolucao = devolucao.Split("/");
            int diaDevolucao = int.Parse(dataSeparadaDevolucao[0]);    //0   1   2
            int mesDevolucao = int.Parse(dataSeparadaDevolucao[1]);   // 02 /03 /2022
            int anoDevolucao = int.Parse(dataSeparadaDevolucao[2]);


            ListaEmprestimo[contadorEmprestimo].dataDevolucao = new DateTime(anoDevolucao, mesDevolucao, diaDevolucao);

            contadorEmprestimo++;

        }



        public void vizualizarEmprestimo()
        {

            for (int i = 0; i < contadorEmprestimo; i++)
            {
                Console.WriteLine("Amigo .............: " + ListaEmprestimo[i].quemEmprestou.amigo);
                Console.WriteLine("Resvista ..........: " + ListaEmprestimo[i].revistaEmprestada.tipoDeColecao);
                Console.WriteLine("Data emprestimo ...: " + ListaEmprestimo[i].dataRetirada);
                Console.WriteLine("Data devolução ....: " + ListaEmprestimo[i].dataDevolucao);
            }


        }

        public void emprestimosMensal()
        {
            int contador = 0;

            Console.WriteLine("informa qual o mes para obter informações: (mm)");
            int mes = int.Parse(Console.ReadLine());


            while (contador > contadorEmprestimo)
            {
                if (ListaEmprestimo[contador].dataRetirada.Month == mes && ListaEmprestimo[contador].dataRetirada.Year == hoje.Year)
                {
                    Console.WriteLine("Amigo .............: " + ListaEmprestimo[contador].quemEmprestou.amigo);
                    Console.WriteLine("Resvista ..........: " + ListaEmprestimo[contador].revistaEmprestada.tipoDeColecao);
                    Console.WriteLine("Data emprestimo ...: " + ListaEmprestimo[contador].dataRetirada);
                    Console.WriteLine("Data devolução ....: " + ListaEmprestimo[contador].dataDevolucao);


                }
                contador++;

            }
        }

        public void emprestimoDiario()
        {

            int contador = 0;

            Console.WriteLine("informa  o dia para obter informações: (dd)");
            int dia = int.Parse(Console.ReadLine());


            while (contador > contadorEmprestimo)
            {


                if (ListaEmprestimo[contador].dataRetirada.Day == dia && ListaEmprestimo[contador].dataRetirada.Month == hoje.Month
                    && ListaEmprestimo[contador].dataRetirada.Year == hoje.Year)
                {

                    if (ListaEmprestimo[contador].aberto)
                    {
                        Console.WriteLine("Amigo .............: " + ListaEmprestimo[contador].quemEmprestou.amigo);
                        Console.WriteLine("Resvista ..........: " + ListaEmprestimo[contador].revistaEmprestada.tipoDeColecao);
                        Console.WriteLine("Data emprestimo ...: " + ListaEmprestimo[contador].dataRetirada);
                        Console.WriteLine("Data devolução ....: " + ListaEmprestimo[contador].dataDevolucao);

                    }
                }
                contador++;

            }


        }
    }
}
