using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosIntermediarios.Models
{
    public class PersonagemPai
    {
        public string Nome { get; set; }
        public int Mana { get; set; }

        public PersonagemPai(string nome, int mana)
        {
            Nome = nome;
            Mana = mana;
        }
    }
}