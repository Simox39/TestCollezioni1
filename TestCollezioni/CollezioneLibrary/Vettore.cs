using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollezioneLibrary
{
    public class Vettore
    {

        public static int[] Ordina(int[] numeri)
        { for (int i = 0; i < numeri.Length - 1; i++)
            for (int j = i + 1; j < numeri.Length; j++)
             if (numeri[i] > numeri[j])
             { int tmp = numeri[i];
                numeri[i] = numeri[j];
                 numeri[j] = tmp;
             }
            return numeri;
        }
    }
}
