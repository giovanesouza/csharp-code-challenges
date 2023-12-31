using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosIntermediarios.Models
{
    public class Subclasse : PersonagemPai
    {
        public int DanoBase { get; set; }

        public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
        {
            DanoBase = danoBase;
        }

        public void CalcularDano()
        {
            Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
        }

    }
}