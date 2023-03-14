using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04
{
    public class Menu
    {
        public void MenuInterativo()
        {
            int opcao;
            do
            {
                Console.WriteLine("1 - Inserir bebida");
                Console.WriteLine("2 - Alterar bebida");
                Console.WriteLine("3 - Excluir bebida");
                Console.WriteLine("4 - Listar todas as bebidas");
                Console.WriteLine("5 - Listar todas os sucos");
                Console.WriteLine("6 - Listar todas os refrigerantes");
                Console.WriteLine("7 - Sair");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 7);
            if (opcao == 1)
            {

            }
            if (opcao == 2)
            {

            }

            if (opcao == 3)
            {

            }
            if (opcao == 4)
            {

            }
            if (opcao == 5)
            {

            }
            if (opcao == 6)
            {

            }

            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
        }
    }
}