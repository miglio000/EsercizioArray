using System;

namespace FunzioniArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Inserisci un numero: ");
                int n = Convert.ToInt32(Console.ReadLine());
                array[i] = n;
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Hai inserito: {array[i]}");
            }
        }
        public static int[] ArrayRibaltato(int[] array)
        {
            int[] copia = new int[array.Length];
            int i2 = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                copia[i] = array[i2++];
            }
            return copia;
        }
        public static int[] CopiaArray(int[] array)
        {
            int[] copia = new int[array.Length];
            array.CopyTo(copia, 0);
            return copia;
        }
        public static bool RicercaArray(int[] array, int vero)
        {
            bool trova = false;
            for(int i = 0; i < array.Length && !trova; i++)
            {
                if (array[i] == vero)
                {
                    trova = true;
                }
            }
            return trova;
        }
    }
}
