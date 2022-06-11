using System;
using System.IO;
using System.Collections.Generic;



namespace CharProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeFisier=Console.ReadLine();
            numeFisier = @"..\..\" + numeFisier;
           FisierCaractere file = new FisierCaractere(numeFisier);
           Console.WriteLine("Numarul de linii = "+file.NumarLinii());
            Console.WriteLine("Nunarul de vocale = "+ file.NumarVocale());
            Console.WriteLine("Nunarul de consoane = " + file.NumarConsoane());
            Console.WriteLine("Nunarul total de caractere = " + file.NumarTotalCaractere());

        }
    }
}
