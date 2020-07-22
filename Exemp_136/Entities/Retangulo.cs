using System;
using System.Collections.Generic;
using Exemp_136.Entities.Enums;

namespace Exemp_136.Entities
{
    class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cores cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;            
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
