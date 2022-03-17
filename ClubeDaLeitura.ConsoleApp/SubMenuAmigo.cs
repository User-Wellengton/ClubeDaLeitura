using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class SubMenuAmigo
    {

        public Amigo[] listaAmigo = new Amigo[100];
        int contadorAmigo = 0;

        string opcaoAmigo;

        public void MenuAmigo()
        {


            while (true)
            {
                
                Console.WriteLine("SUBMENU AMIGOS... ");
                Console.WriteLine("Digite 1 para cadastrar amigos:");
                Console.WriteLine("Digite 2 para vizualizar amigos:");
                Console.WriteLine("Digite 'S' para sair:");
                opcaoAmigo = Console.ReadLine();

                if (opcaoAmigo == "1")
                {
                    Console.Clear();
                    CadastrarAmigo();
                }
                else if (opcaoAmigo == "2")
                {
                    Console.Clear();
                    vizualizarAmigos();
                }
                else if (opcaoAmigo == "s")
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


        public void CadastrarAmigo()
        {
            listaAmigo[contadorAmigo] = new Amigo();

            Console.WriteLine("Informe o nome do amigo:");
            listaAmigo[contadorAmigo].amigo = Console.ReadLine();

            Console.WriteLine("Informe o nome do responsavel:");
            listaAmigo[contadorAmigo].nomeResponsavel = Console.ReadLine();

            Console.WriteLine("Informe o telefone:");
            listaAmigo[contadorAmigo].telefone = Console.ReadLine();

            Console.WriteLine("Informe o endereço:");
            listaAmigo[contadorAmigo].endereço = Console.ReadLine();

            contadorAmigo++;

        }

        public void vizualizarAmigos()
        {

            if (contadorAmigo == 0)
            {
                Console.WriteLine("Sem amigos cadastrads, por favor adicionar amigo...");
                CadastrarAmigo();
            }
            else
            {
                for (int i = 0; i < contadorAmigo; i++)
                {
                    Console.WriteLine("ID .................: " + i);
                    Console.WriteLine("Nome ...............: " + listaAmigo[i].amigo);
                    Console.WriteLine("Nome Responsável ...: " + listaAmigo[i].nomeResponsavel);
                    Console.WriteLine("Telefone ...........: " + listaAmigo[i].telefone);
                    Console.WriteLine("Endereço ...........: " + listaAmigo[i].endereço);


                }
            }


        }

    }
}
