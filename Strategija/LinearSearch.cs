using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{
    class LinearSearch:SearchStrategy
    {
        public override void Search(double[] array,double number)
        {
            int j = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] == number)
                {
                    j++;
                    Console.WriteLine("Broj pronadjen");
                    return;
                }

            }
            if (j == 0)
                Console.WriteLine("Broj nije pronadjen");

        }
    }
}
