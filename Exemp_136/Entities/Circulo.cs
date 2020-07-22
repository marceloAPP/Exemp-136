using System;
using System.Collections.Generic;
using Exemp_136.Entities.Enums;

namespace Exemp_136.Entities
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cores cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
