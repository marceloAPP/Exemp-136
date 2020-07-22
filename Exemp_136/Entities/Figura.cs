using System;
using System.Collections.Generic;
using System.Text;
using Exemp_136.Entities.Enums;

namespace Exemp_136.Entities
{
    abstract class Figura
    {
        public Cores Cor { get; set; }
        
        public Figura(Cores cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
