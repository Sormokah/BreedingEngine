using System;
using System.Collections.Generic;
using System.Text;
using BreedingEngine.Enums;
using BreedingEngine.Generics;
using BreedingEngine.Models;

namespace BreedingSandbox
{
    class EarLobe : BinaryGene, Breedable<EarLobe>
    {
        public EarLobe() { }
        public EarLobe(Alele alele) : base(alele) { }

        public EarLobe Breed(EarLobe parentA, EarLobe parentB)
        {
            return (EarLobe)base.Breed(parentA, parentB);
        }
    }
}
