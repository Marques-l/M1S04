using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04
{
    public class Refrigerante : Bebida
    {
        public bool Vidro {get;set;}
        public Refrigerante(bool vidro, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base(id, tipo, miliLitro, nomeBebida, valorCompra)
        {
            Vidro= vidro;
        }
        public void ImprimirDados(string id, string nomeBebida, decimal miliLitro) 
        {
            if (Vidro)
            {
                Console.WriteLine($"O produto id {id} com nome {nomeBebida} é um refrigerante MiliLitros {miliLitro} é um vidro"); 
            }
            else
            {
                Console.WriteLine($"O produto id {id} com nome {nomeBebida} é um refrigerante MiliLitros {miliLitro} é uma garrafa pet"); 
            }
        }
    }
}
