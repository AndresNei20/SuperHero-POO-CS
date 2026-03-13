using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroesApp
{
    internal class PrintSuperHero
    {
        public void PrintSuperhero(ISuperHero superhero)
        {
            Console.WriteLine($"Id: {superhero.Id}");
            Console.WriteLine($"Name: {superhero.Name}");
            Console.WriteLine($"Secret Identity: {superhero.SecretIdentity}");
        }
    }
}
