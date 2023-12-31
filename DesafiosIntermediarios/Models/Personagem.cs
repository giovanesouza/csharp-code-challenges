using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosIntermediarios.Models
{
    // 4. Utilizando Construtores
    public class Personagem
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; } = 1;
        public int Vida { get; set; } = 10;

        public Personagem(string nome, string raca, string classe)
        {
            Nome = nome;
            Raca = raca;
            Classe = classe;

        }

        public void ExibirStatus()
        {
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("Raça:" + Raca);
            Console.WriteLine("Classe:" + Classe);
            Console.WriteLine("Nível:" + Nivel);
            Console.WriteLine("Vida:" + Vida);
        }

    }
}