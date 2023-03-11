using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
         public decimal ValorCompra { get; set; }
        public Bebida(int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) 
        { 
            Id = id;
            Tipo = tipo;
            MiliLitro = miliLitro; 
            NomeBebida= nomeBebida;
            ValorCompra = valorCompra;
        }

        
        public void Comprar(string id, string valorCompra)
        {
            Console.WriteLine($"Valor da compra do produto id {id} alterado para {valorCompra}"); 
        }
        public void ImprimirBebidas()
        {
            Console.WriteLine($"ID, {Id}, nome, {NomeBebida} e valor, {ValorCompra}"); 
        }


    }
}
