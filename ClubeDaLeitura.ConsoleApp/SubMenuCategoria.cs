using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class SubMenuCategoria
    {
        public Categoria[] listaCategoria = new Categoria[10];
        int contadorCategoria = 0;

        string opcaoCategoria;



        public void MenuCategoria()
        {
            while (true)
            {


                Console.WriteLine("SUBMENU CATEGORIA... ");
                Console.WriteLine("Digite 1 para cadastrar uma categoria:");
                Console.WriteLine("Digite 2 para vizualizar as categorias:");
                Console.WriteLine("Digite 'S' para sair:");
                opcaoCategoria = Console.ReadLine();


                if (opcaoCategoria == "1")
                {
                    Console.Clear();
                    cadastrarCategoria();
                }
                else if (opcaoCategoria == "2")
                {
                    Console.Clear();
                    vizualizarCategoria();
                }
                else if (opcaoCategoria == "s")
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


        public void cadastrarCategoria()


        {
            listaCategoria[contadorCategoria] = new Categoria();


            Console.WriteLine("Informe o nome da categoria:");
            listaCategoria[contadorCategoria].nome = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de dias de emprestimo:");
            listaCategoria[contadorCategoria].quatidadeDiasEmprestimo = int.Parse(Console.ReadLine());

            

            contadorCategoria++;


        }
             
        


        public void vizualizarCategoria()
        {
            if(contadorCategoria <0)
            {
                Console.WriteLine("Sem categorias adicionadas... Inclua alguma categoria.");

                cadastrarCategoria();
            }
            else
            {
                for (int i = 0; i < contadorCategoria; i++)
                {
                    Console.WriteLine("ID ...................: " + i);
                   Console.WriteLine("Nome da categoria .....: " + listaCategoria[i].nome);
                    Console.WriteLine("Dias de emprestimo ....:" + listaCategoria[i].quatidadeDiasEmprestimo);



                }





            }



        }












    }
}
