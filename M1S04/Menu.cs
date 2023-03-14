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
                Bebida bebida = new Bebida(1, "Diet", 1000, "Coca-Cola", (decimal)2.00); //Inserindo manualmente, mas poderia ter sido feito pelo Console
                Bebida bebida2 = new Bebida(14, "Diet", 2000, "Coca-Cola", (decimal)2.00);
                Repositorio.InserirBebida(bebida);
                Repositorio.InserirBebida(bebida2);
                 
            }
            if (opcao == 2)
            {
                Bebida bebida = new Bebida(1, "Diet", 1000, "Coca-Cola", (decimal)2.00); //Inserindo manualmente, mas poderia ter sido feito pelo Console
                bebida.Id = 1;
                bebida.NomeBebida = "Alterado para Mountain Dew";
                Repositorio.Alterar(bebida);

                bebida = new Bebida(1, "Diet", 1000, "ALTERADO", (decimal)2.00);
            }

            if (opcao == 3)
            {
                Repositorio.Remover(1); // Pode ser feito pelo console escolhendo o id para remover
            }
            if (opcao == 4)
            {
                Repositorio.ImprimirBebida();
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