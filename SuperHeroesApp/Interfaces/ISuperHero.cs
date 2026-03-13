using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHero
    {
        Guid Id { get; }
        string Name { get; set; }
        string SecretIdentity { get; set; }
    }
}
