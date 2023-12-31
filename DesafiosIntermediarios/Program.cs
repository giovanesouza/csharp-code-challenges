using DesafiosIntermediarios.Models;

// 1. Primeiro Desafio com POO

// Pega as informações do usuário

string nome = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());

Pessoa p = new Pessoa(nome, idade);

Console.WriteLine($"Nome: {p.GetNome()}, Idade: {p.GetIdade()}");



// 2. Utilizando Propriedades e Métodos
/*
// Pega as velocidades
string[] velocidades = Console.ReadLine().Split();
int vmin = int.Parse(velocidades[0]);
int vmax = int.Parse(velocidades[1]);

// Comandos A | D
string comandos = Console.ReadLine();

string nome = Console.ReadLine();
Robo robo = new Robo(vmin, vmax);

foreach (char comando in comandos)
{
    if (comando == 'A')
    {
        robo.Acelerar();
    }
    else if (comando == 'D')
    {
        robo.Desacelerar();
    }
}

// Imprime a velocidade com base na string
Console.WriteLine(robo.VelocidadeAtual);
*/

// 3. Criando um Objeto com Atributos
/*
string nome = Console.ReadLine();
string nacionalidade = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());
string posicao = Console.ReadLine();

Jogador player = new Jogador(nome, nacionalidade, idade, posicao);
player.ShowPlayerInfo();
*/


// 4. Utilizando Construtores
/*
string nome = Console.ReadLine();
string raca = Console.ReadLine();
string classe = Console.ReadLine();
      
Personagem p = new Personagem(nome, raca, classe);
p.ExibirStatus();
*/


// 5. Utilizando Herança e Subclasses
/*
string nome = Console.ReadLine();
int mana = int.Parse(Console.ReadLine());
int danoBase = int.Parse(Console.ReadLine());

Subclasse guerreiro = new Subclasse(nome, mana, danoBase);
guerreiro.CalcularDano();
*/