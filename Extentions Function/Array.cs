using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class Array
    {
        /// <summary>
        /// Dizinin sonuna istediğiniz değerleri ekleyin
        /// </summary>
        /// <param name="array">Şu anki dizin</param>
        /// <param name="values">Artrırılacak olan değerler</param>
        public static void MyResize<T>(ref T[] array, params T[] values)
        {
            T[] newarray = new T[array.Length + values.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i];
            }
            for (int i = 0; i < values.Length; i++)
            {
                newarray[array.Length + i] = values[i];
            }

            for (int i = 0; i < newarray.Length; i++)
            {
                Console.Write(newarray[i] + " ");
            }
        }
    }
}
