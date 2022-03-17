using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class SubMenuCaixa
    {

        public Caixa[] listaCaixa = new Caixa[10];
        public int contadorCaixa = 0;



        string opcaoCaixa;


        public void MenuCaixa()
        {

            

            while (true)
            {
                

                Console.WriteLine("SUBMENU CAIXA... ");
                Console.WriteLine("Digite 1 para cadastrar uma caixa:");
                Console.WriteLine("Digite 2 para vizualizar uma caixa:");
                Console.WriteLine("Digite 'S' para sair:");
                opcaoCaixa = Console.ReadLine();

                if (opcaoCaixa == "1")
                {
                    Console.Clear();
                    cadastrarCaixa();
                }
                else if (opcaoCaixa == "2")
                {
                    Console.Clear();
                    vizualizarCaixas();
                }
                else if (opcaoCaixa == "s")
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

        public void cadastrarCaixa()
        {
            listaCaixa[contadorCaixa] = new Caixa();

            Console.WriteLine("Informe qual a cor da caixa:");
            listaCaixa[contadorCaixa].cor = Console.ReadLine();

            Console.WriteLine("Informe qual a etiqueta da caixa:");
            listaCaixa[contadorCaixa].etiqueta = Console.ReadLine();

            Console.WriteLine("Informe qual o número da caixa:");
            listaCaixa[contadorCaixa].numero = int.Parse(Console.ReadLine());


            contadorCaixa++;

        }


        public void vizualizarCaixas()
        {

            if (contadorCaixa == 0)
            {
                Console.WriteLine("Sem caixas cadastradas, por favor adicionar uam caixa...");
                cadastrarCaixa();
            }
            else
            {
                for (int i = 0; i < contadorCaixa; i++)
                {
                    Console.WriteLine("ID .........: " + i);
                    Console.WriteLine("Cor ........: " + listaCaixa[i].cor);
                    Console.WriteLine("Etiqueta ...: " + listaCaixa[i].etiqueta);
                    Console.WriteLine("Numero .....: " + listaCaixa[i].numero);

                }
            }


        }



    }
}
