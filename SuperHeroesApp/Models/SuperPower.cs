using System;

namespace SuperHeroesApp.Models;

public class SuperPower
{
    public string Name { get; set; }
    public string Description { get; set; }
    public PowerLevel Level { get; set; }

    //Constructor
    public SuperPower()
    {
        Name = "";
        Description = "";
        Level = PowerLevel.Low;

    }

}

