using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosIntermediarios.Models
{
    // 3. Criando um Objeto com Atributos
    public class Jogador
    {

        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }

        public Jogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Posicao = posicao;
        }

        public void ShowPlayerInfo()
        {
            Console.WriteLine("Jogador criado!");
            Console.WriteLine(Nome);
            Console.WriteLine(Nacionalidade);
            Console.WriteLine(Idade);
            Console.WriteLine($"Posição: {Posicao}");
        }


    }
}