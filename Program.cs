using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace EJ1A_Vectornunmerico
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new VectorNumerico();
            if (v.Validar())
            {
                v.GenerarVector();

                Console.WriteLine(v.ToString());//imprimir en una linea
            }
            else
            {
                Console.WriteLine("Objeto no válido");
            }

            Console.WriteLine("convierto a string:");
            Console.WriteLine("");
            //var nuevo = new VectorNumerico;
            //nuevo=4*v;
            //Console.WriteLine(nuevo.ToString());

            Console.ReadLine();
        }
    }
    
}