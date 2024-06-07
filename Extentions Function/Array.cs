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
        /// <param name="array">Mevcut dizin</param>
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

        /// <summary>
        /// Dizine belirli bir indeksten sonrasında yeni değerler atamak için
        /// </summary>
        /// <param name="array">Mevcut dizin</param>
        /// <param name="startindex">Eklenecek elemenların başlama indeksi</param>
        /// <param name="values">Eklenecek olan elemenlar</param>
        /// <exception cref="Exception">Başlama indeksi mevcut dizin elemenlarından az olamaz!</exception>
        public static void MyResize<T>(int startindex, ref T[] array, params T[] values)
        {
            T[] newarray = new T[array.Length + values.Length];

            if (startindex > array.Length)
            {
                throw new Exception("Başlama indeksi mevcut dizin ölçüsünden çok olamaz!");
            }

            for (int i = 0; i < startindex - 1; i++)
            {
                newarray[i] = array[i];
            }
            for (int i = 0; i < values.Length; i++)
            {
                newarray[startindex - 1 + i] = values[i];
            }
            for (int i = startindex - 1; i < array.Length; i++)
            {
                newarray[values.Length + i] = array[i];
            }

            for (int i = 0; i < newarray.Length; i++)
            {
                Console.Write(newarray[i] + " ");
            }
        }
    }
}
