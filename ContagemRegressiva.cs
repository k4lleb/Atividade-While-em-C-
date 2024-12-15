using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class ContagemRegressiva
    {
        public static void Main(string[] args)
        {
            int contadora = 10;

            while (contadora > 0)
            {
                Console.WriteLine(contadora);
                contadora--;
            }
        }
    }
}
