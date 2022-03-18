using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class SubMenuRevista
    {

        public Revista[] listaRevista = new Revista[100];
        int contadorRevista = 0;

        string opcaoRevista;


        public SubMenuCaixa registroDaCaixa;
        

        public void MenuRevista()
        {


            while (true)
            {
                

                Console.WriteLine("SUBMENU REVISTA... ");
                Console.WriteLine("Digite 1 para cadastrar uma revista:");
                Console.WriteLine("Digite 2 para vizualizar as revistas:");
                Console.WriteLine("Digite 'S' para sair:");
                opcaoRevista = Console.ReadLine();


                if (opcaoRevista == "1")
                {
                    Console.Clear();
                    cadastrarRevista();
                }
                else if (opcaoRevista == "2")
                {
                    Console.Clear();
                    vizualizarRevista();
                }
                else if (opcaoRevista == "s")
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


        public void cadastrarRevista()
        {
            SubMenuCaixa cadastroRevista = new SubMenuCaixa();

            if (registroDaCaixa.contadorCaixa == 0)
            {
                Console.WriteLine("Não possui nehuma caixa cadastrada, adicione uma caixa primeiro...");
                
            }

            else
            {
                listaRevista[contadorRevista] = new Revista();


                Console.WriteLine("Informe o tipo de coleção:");
                listaRevista[contadorRevista].tipoDeColecao = Console.ReadLine();

                Console.WriteLine("Informe o numero de edição:");
                listaRevista[contadorRevista].numeroEdicao = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o ano da revista:");
                listaRevista[contadorRevista].anoRevista = int.Parse(Console.ReadLine());


                registroDaCaixa.vizualizarCaixas();

                Console.WriteLine("Informe em qual caixa esta a revista:");
                int seletorDaCaixa = int.Parse(Console.ReadLine());

                listaRevista[contadorRevista].caixaLivros = registroDaCaixa.listaCaixa[seletorDaCaixa];


                Console.WriteLine("Informe a categoria da revista:");
                listaRevista[contadorRevista].revistaCategoria = Console.ReadLine();




                contadorRevista++;
            }
        }


        public void vizualizarRevista()
        {
            if (contadorRevista == 0)
            {
                Console.WriteLine("Sem revistas cadastradas, por favor adicionar revistas...");
                cadastrarRevista();
            }
            else
            {
                for (int i = 0; i < contadorRevista; i++)
                {
                    Console.WriteLine("ID .....................: " + i);
                    Console.WriteLine("Coleção ................: " + listaRevista[i].tipoDeColecao);
                    Console.WriteLine("Numero de edição .......: " + listaRevista[i].numeroEdicao);
                    Console.WriteLine("Ano da Revista .........: " + listaRevista[i].anoRevista);
                    Console.WriteLine("Esta na caixa ..........: " + registroDaCaixa.listaCaixa[i].cor);
                    Console.WriteLine("Categoria da Revista ...: " + listaRevista[i].revistaCategoria);

                }
            }


        }
    }
}
