using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_BasicosII
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops
            loop(); // llamado el metodo loop
            Console.ReadKey();
        }
        // Whille
        // evalua la condicion y ejecuta las instrucciones
        // si la condicion es verdadera 
        public static void loop()
        {
            int[] nums = new int[3]; // crea arreglo 

            // lenar arreglo 
            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            // imprimir los numeros 
            int i = 0, idw = 0, ifor = 0;
            Console.WriteLine("Imprimiendo con while");
            while (i < nums.Length )

            {
               
                Console.WriteLine("indice {0}: {1}", i,nums[i]);
                i++;
            }
            //Imprimir con ciclo dowhile
            //la condicion se valua al final
            Console.WriteLine("imprimiendo con Do-while: ");
            do 
            {

          
                Console.WriteLine("indice {0}: {1}", idw,nums[idw]);
                idw++;

            } while (idw < nums.Length);
            //Imprimir con ciclo for 
            // se comprueba la condicion primero y ejecuta si la condicion es verdadera 
            Console.WriteLine("imprimiendo con for");
            for (int inc = 0; inc < nums.Length; inc++) 
            {
                Console.WriteLine("indice {0}: {1} ", inc , nums[inc]);

            }
        }
    }
}
