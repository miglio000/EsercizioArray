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
            int[] copia_array = GestioneArray.CopiaArray(numero);
            //GestioneArray.RicercaArray(numero, n);
        }
    }
}
