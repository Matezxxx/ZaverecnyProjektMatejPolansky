using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektPolanskyMatej
{
    internal class Metody
    {
        public List<Pojistenec> seznamPojistenych = new List<Pojistenec>();
        public void VytvorPojisteneho(string jmeno, string prijmeni, int vek, string telefon)
        {
            Pojistenec pojisteny = new Pojistenec(jmeno, prijmeni, vek, telefon);

            seznamPojistenych.Add(pojisteny);
            Console.WriteLine("\n Data byla uložena, uložili jste nového pojištěného {0} {1}, pokračujte libovolnou klávesou...\n", jmeno, prijmeni);
        }
        public void VypisSeznamPojistenych()
        {
            Console.WriteLine("\nSeznam pojištěných osob:");
            foreach (Pojistenec pojisteny in seznamPojistenych)
            {
                Console.WriteLine(pojisteny.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou");
        }
        public void NajdiPojisteneho(string jmeno, string prijmeni)
        {
            foreach (Pojistenec pojisteny in seznamPojistenych)
            {
                if (pojisteny.Jmeno == jmeno && pojisteny.Prijmeni == prijmeni)
                {

                    Console.WriteLine("\nPojištěný {0} {1} byl nalezen:\n{2}\n", jmeno, prijmeni, pojisteny.ToString());
                    Console.WriteLine("Pokračujte libovolnou klávesou");
                }
                else
                {
                    Console.WriteLine("\nPojištěný {0} {1} nebyl nalezen.\n", jmeno, prijmeni);
                    Console.WriteLine("Pokračujte libovolnou klávesou");
                }
            }
        }
    }
}
