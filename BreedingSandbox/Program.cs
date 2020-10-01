using BreedingEngine.Enums;
using BreedingEngine.Models;
using System;

namespace BreedingSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<16; i++)
            {
                EarLobe parentA = new EarLobe(new Alele(Dominance.Dominant, Dominance.Recessive));
                EarLobe parentB = new EarLobe(new Alele(Dominance.Recessive, Dominance.Dominant));

                EarLobe child = parentA.Breed<EarLobe>(parentA, parentB);

                Console.WriteLine(child);
            }
        }
    }
}
