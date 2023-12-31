using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosIntermediarios.Models
{
    // 1. Primeiro Desafio com POO
    public class Pessoa
    {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetIdade()
        {
            return Idade;
        }

    }





}