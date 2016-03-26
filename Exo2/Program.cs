using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nombres = {5,4,1,3,9,8,6,7,2,0};
            int[] scores = { 90, 71, 82, 93, 75, 82 };

         /*   int nombresPaires = nombres.Count(n => n % 2 ==0);

            Console.WriteLine(nombresPaires);

            Console.ReadLine(); */

           /* IEnumerable nPremier = nombres.Where(n => n % 2 != 0 && n > 6);

            foreach (var v in nPremier)
                Console.WriteLine(v);*/

           /* var lesNombres = nombres.TakeWhile((n, index) => n >= index);

            foreach (var l in lesNombres)
                Console.WriteLine(l);*/

           /* int ScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine(ScoreCount);*/

            var lesScoreCount = scores.Where(n => n > 80);

            foreach (var v in lesScoreCount)
                Console.WriteLine(v);

            Console.ReadLine();
        }
    }
}
