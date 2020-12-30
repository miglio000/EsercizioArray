using System;

namespace FunzioniArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array )
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Inserisci un numero: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Hai inserito: {array[i]}");
            }
        }
        public static int[] CopiaArray(int[] array)
        {
            int[] copia = new int[array.Length];
            array.CopyTo(copia, 0);
            return copia;
        }
        public static bool RicercaArray(int[] array, int n_posizione)
        {
            
            int posizione = 4;  // ricerca
            int pos = -1; // indice in cui è stato trovato. -1 significa non trovato

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == posizione)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
            {
                Console.WriteLine($"La ricerca di {posizione} è stata trovata in posizione {pos}");
            }
            else
            {
                Console.WriteLine("Non trovato");
            }             
        }
    }
}
