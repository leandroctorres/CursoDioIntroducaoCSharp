using System;
using Primeiro;
using CursoDioIntroducaoCSharp;
using Interface;
using Enum;

namespace CursoDioIntroducaoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;

            Pessoa person = new Pessoa();

            person.Nome = "Leandro";
            person.Idade = 33;
            person.Estado = "SP";

            var person2 = new Pessoa();
            person2.Nome = "Julia";
            person2.Idade = 23;
            person2.Estado = "MG";

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            var classe = new Classe();
            var classe2 = new segundo.Classe();

            Console.WriteLine(pessoa2);
        }
    }
}
