using System;

namespace SuperHeroesApp.Models;

    internal class AntiHero: SuperHero
{
    public string DoAntiHeroAction(string action)
    {
        return $"The AntiHero {NameAndSecretIdendity} do {action}";
    }
}
