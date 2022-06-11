using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CharProcessing
{
    internal class FisierCaractere
    {
         List<char> charList = new List<char> { };
        TextReader file;
        int nrLinii = 0;
        int nrConsoane = 0;
        int alteCaractere = 0;
        int nrVocale = 0;
        public  FisierCaractere(string caleFisier)
        {
            file=new StreamReader(caleFisier);
            string linie;
            while ((linie = file.ReadLine()) != null)
            {
                foreach  (char caracter in linie)
                {
                    charList.Add(caracter);
                }
                nrLinii++;
            }
        }
        public int NumarLinii()
        {
           return nrLinii;
        }

        bool EsteVocala(char item)
        {
            char[] vocale = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (var vocala in vocale)
            {
                if (item==vocala)
                {
                    return true;
                }
            }
            return false;

        }
        public int NumarVocale()
        {
            foreach (char item in charList)
            {
                if (EsteVocala(item))
                {
                    nrVocale++;
                }
            }
            return nrVocale; 
        }
        bool EsteConsoana(char item)
        {
                if (((item >= 65 && item <= 90) || (item >= 97 && item <= 122)) && !EsteVocala(item))
                {
                  return true;
                }
            return false;
        }

        public int NumarConsoane()
        {
            foreach (var item in charList)
            { 
                if (EsteConsoana(item))
                {
                    nrConsoane++;
                }
            }
            return nrConsoane;
        }
        public int NumarTotalCaractere()
        {
            foreach (var item in charList)
            {
                if (!EsteVocala(item)&&!EsteConsoana(item))
                {
                    alteCaractere++;
                }
            }
            return alteCaractere+nrConsoane+nrVocale;
        }

    }
}
