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

        }
        // Whille
        // evalua la condicion y ejecuta las instrucciones
        // si la condicion es verdadera 
        public static void loopWhile()
        {
            int[] nums = new int[3]; // crea arreglo 

            // lenar arreglo 
            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            // imprimir los numeros 
            int i = 0;
            while (i < nums.Length )
            {
                Console.WriteLine(nums[i]);
                i++;
            }
        }
    }
}
