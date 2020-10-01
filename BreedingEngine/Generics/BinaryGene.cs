using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BreedingEngine.Enums;
using BreedingEngine.Models;

namespace BreedingEngine.Generics
{
    public class BinaryGene : Gene
    {
        public BinaryGene() { }
        public BinaryGene(Alele alele) 
        {
            this.Alele = alele;
        }

        protected Alele Alele;


        protected BinaryGene Breed(BinaryGene parentA, BinaryGene parentB)
        {
            Alele aDominance = parentA.Alele;
            Alele bDominance = parentB.Alele;

            int aRand = new Random().Next(2);
            int bRand = new Random().Next(2);

            Dominance aDom = (aRand == 0) ? aDominance.Pair.Key : aDominance.Pair.Value;
            Dominance bDom = (bRand == 0) ? bDominance.Pair.Key : bDominance.Pair.Value;

            Alele childAlele = new Alele(aDom, bDom);
            BinaryGene childGene = new BinaryGene();
            childGene.Alele = childAlele;
            return childGene;
        }

        public override string ToString()
        {
            return $"({this.Alele.Pair.Key});({this.Alele.Pair.Value})";
        }

    }
}