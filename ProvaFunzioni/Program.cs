using System;
using FunzioniArray;
namespace ProvaFunzioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int [5];
            GestioneArray.LeggiArray(numero);
            GestioneArray.StampaArray(numero);
            int[] copia_Array = GestioneArray.CopiaArray(numero);
            GestioneArray.StampaArray(copia_Array);
            bool ricerca_Array = GestioneArray.RicercaArray(numero);
            Console.WriteLine("Trovato:" + trovato);
        }
    }
}
