using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosIntermediarios.Models
{
    // 2. Utilizando Propriedades e Métodos
    public class Robo
    {
        public int VelocidadeAtual { get; set; } = 0;
        public int VelocidadeMaxima { get; }
        public int VelocidadeMinima { get; }

        public Robo(int vmin, int vmax)
        {
            VelocidadeMinima = vmin;
            VelocidadeMaxima = vmax;
            VelocidadeAtual = vmin;
        }

        public void Acelerar()
        {
            if (VelocidadeAtual < VelocidadeMaxima)
            {
                VelocidadeAtual++;
            }
        }

        public void Desacelerar()
        {
            if (VelocidadeAtual > VelocidadeMinima)
            {
                VelocidadeAtual--;
            }
        }

    }
}