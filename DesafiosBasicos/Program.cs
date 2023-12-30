using System;

class Program
{
    static void Main(string[] args)
    {

       // DESAFIO 1 - Explorando Sintaxe e Tipos de Dados
        string registroNome;
        string registroEmail;
        string registroSenha;

        Console.WriteLine("Informe seu e-mail:");
        registroEmail = Console.ReadLine();
        
        Console.WriteLine("Informe seu nome:");
        registroNome = Console.ReadLine();

        Console.WriteLine("Digite uma senha:");
        registroSenha = Console.ReadLine();

        Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");


    }
}