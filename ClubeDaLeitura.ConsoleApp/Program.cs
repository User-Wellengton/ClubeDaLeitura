using System;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            SubMenuAmigo subAmigo = new SubMenuAmigo();
            SubMenuCaixa subCaixa = new SubMenuCaixa();
            SubMenuEmprestimo subEmprestimo = new SubMenuEmprestimo();
            SubMenuRevista subRevista = new SubMenuRevista();
            subRevista.registroDaCaixa = subCaixa;
            subEmprestimo.amigosUtilizados = subAmigo;
            subEmprestimo.revistaUtilizada = subRevista;
            SubMenuCategoria subCategoria = new SubMenuCategoria();

            string opcaoMenuPrincipal;
            
            while (true)
            {

                

                Console.WriteLine("MENU PRINCIPAL...");

                Console.WriteLine("Digite 1 para menu revista.");
                Console.WriteLine("Digite 2 para menu caixa.");
                Console.WriteLine("Digite 3 para menu emprestimo.");
                Console.WriteLine("Digite 4 para menu amigo.");
                Console.WriteLine("Digite 5 para menu categoria.");
                Console.WriteLine("Digite 'S' para sair do programa.");
                opcaoMenuPrincipal = Console.ReadLine();

                

                if (opcaoMenuPrincipal == "1")
                {
                    subRevista.MenuRevista();
                }
                else if (opcaoMenuPrincipal == "2")
                {
                    subCaixa.MenuCaixa();
                }
                else if (opcaoMenuPrincipal == "3")
                {
                    subEmprestimo.MenuEmprestimo();
                }
                else if (opcaoMenuPrincipal == "4")
                {
                    subAmigo.MenuAmigo();
                }
                else if (opcaoMenuPrincipal == "5")
                {
                    subCategoria.MenuCategoria();
                }
                else if (opcaoMenuPrincipal == "s")
                {
                    break;
                }
                else
                {

                    Console.Clear();
                    Console.WriteLine(" Opção invalida, digite novamente... ");
                    Console.WriteLine("Digite enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                
            }
        }
    }
}
