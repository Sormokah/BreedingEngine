using System;
using System.Collections.Generic;
using System.Text;

namespace BreedingEngine.Generics
{
    public interface Breedable<T> where T : Gene
    {
        T Breed(T parentA, T parentB);
    }
}
