using System;

class Program
{
    static void Main(string[] args)
    {

        // DESAFIO 1 - Explorando Sintaxe e Tipos de Dados
        /*
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
        */


        // DESAFIO 2 - Dominando os Operadores
        /*
                string titulo;
                string descricao;
                string dataVencimento;

                Console.WriteLine("Título:");
                titulo = Console.ReadLine();

                Console.WriteLine("Descrição:");
                descricao = Console.ReadLine();

                if (descricao.Length > 50)
                {
                    Console.WriteLine("Descricao ultrapassa limite de caracteres.");
                }
                else
                {
                    Console.WriteLine("Data de vencimento:");
                    dataVencimento = Console.ReadLine();

                    Console.WriteLine($"{descricao} ate {dataVencimento}");
                }
        */


        // DESAFIO 3 - Desvendando o Controle de Fluxo
        /*
                Console.WriteLine("Limite Inferior:");
                int limiteInferior = int.Parse(Console.ReadLine());

                Console.WriteLine("Limite Superior:");
                int limiteSuperior = int.Parse(Console.ReadLine());

                int somaPares = 0;

                for (int i = limiteInferior; i <= limiteSuperior; i++)
                {
                    if (i % 2 == 0)
                    {
                        somaPares += i;
                    }
                }


                Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
        */


        // DESAFIO 4 - Utilizando Array e Listas

        Console.WriteLine("Quantos jogos deseja adicionar:");
        int quantidadeJogos = int.Parse(Console.ReadLine());

        //Inicializa os arrays com base na quantidade informada pelo usuário:
        string[] nomesJogos = new string[quantidadeJogos]; 

        // Loop para adicionar jogos conforme a quantidade especificada:
        for (int i = 0; i < quantidadeJogos; i++)
        {
            AdicionarJogo(i, nomesJogos);
        }

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);

    }



    // DESAFIO 4 - Continuação do código
    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        string nomesConcatenados = string.Join(", ", nomes); // Separa os itens da lista por vírbula

        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {nomesConcatenados} ao catalogo.");
    }


}