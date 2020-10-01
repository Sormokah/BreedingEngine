using BreedingEngine.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BreedingEngine.Models
{
    public class Alele
    {
        public Alele(Dominance a, Dominance b)
        {
            Pair = new KeyValuePair<Dominance, Dominance>(a, b);
        }
        public Alele(KeyValuePair<Dominance, Dominance> pair)
        {
            Pair = pair;
        }

        private KeyValuePair<Dominance, Dominance> _pair;
        public KeyValuePair<Dominance, Dominance> Pair
        {
            get { return _pair; }
            set
            {
                if (value.Key == Dominance.Recessive && value.Value == Dominance.Dominant)
                    _pair = new KeyValuePair<Dominance, Dominance>(Dominance.Dominant, Dominance.Recessive);
                else
                    _pair = value;
                
            }
        }
    }
}
