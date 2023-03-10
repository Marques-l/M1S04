using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace M1S04
{
    public static class Repositorio 
    {
        private static List<Bebida> ListaBebida { get; set; }
        private static List<Suco> ListaSuco { get; set; }
        private static List<Refrigerante> ListaRefrigerante { get; set; }
        static Repositorio()
        {
            if (ListaBebida == null)
            {
                ListaBebida= new List<Bebida>();
            }
            if (ListaSuco == null)
            {
                ListaSuco= new List<Suco>();
            }
            if (ListaRefrigerante== null) 
            { 
                ListaRefrigerante= new List<Refrigerante>();
            }
           
        }
        public static void InserirBebida(Bebida bebida)
        {
            ListaBebida.Add(bebida);
        }
        public static void InserirRefrigerante(Refrigerante refrigerante)
        {
         ListaBebida.Add(refrigerante);
        }
        public static void InserirSuco(Suco suco)
        {
            ListaSuco.Add(suco); 
        }
        public static void Alterar(Bebida bebida)
        {
            foreach (var item in ListaBebida.Where(w => w.Id == bebida.Id))
            {
                item.NomeBebida = bebida.NomeBebida;
            }

        }
    }
}
