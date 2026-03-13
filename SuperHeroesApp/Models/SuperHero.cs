using System;
using System.Text;

namespace SuperHeroesApp.Models;

 class SuperHero : Hero
{
    private List<SuperPower> _superPowers;
    private bool _hasSuperPowers;
    private string _name;

    public Guid Id { get; }
    public override string Name 
        { get
            {
                return _name;
            }
            set
            {
            _name = value.Trim();
            }
        }

    public string NameAndSecretIdendity
        {
        get
        {
            return $"{Name} ({SecretIdentity})";
        }
    }

    public string Description { get; set; }
    public string SecretIdentity { get; set; }
    public string City { get; set; }
    public bool HasSuperPowers
    {
        get => _hasSuperPowers;
        set
        {
            _hasSuperPowers = value;
            if (!value)
            {
                _superPowers = null;
            }
        }
    }
    public List<SuperPower> SuperPowers
    {
        get => _superPowers;
        set
        {
            if (!_hasSuperPowers)
            {
                throw new InvalidOperationException("Cannot set SuperPowers when HasSuperPowers is false.");
            }
            _superPowers = value;
        }
    }

    public bool IsAlive { get; set; }
    public bool IsHuman { get; set; }
    public bool CanFly { get; set; }

    /* This DOES NOT RETURN ANYTHING, it just prints the powers to the console, but we want to return a string with the powers
    public void UseSuperPower()
    {
        
        foreach (var power in SuperPowers)
        {
            Console.WriteLine($"{Name} uses {power.Name}!");
        }

    }
    */

    //Method that returns a string with the powers of the superhero
    public string UseSuperPower()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var power in SuperPowers)
        {
            sb.AppendLine($"{NameAndSecretIdendity} uses {power.Name}!!!");
        }

        return sb.ToString();
    }

    public override string SaveTheWorld()
    {
        return $"{NameAndSecretIdendity} saves the world!";
    }

    //Constructor
    public SuperHero()
    {
        Id = Guid.NewGuid();
        Name = "";
        Description = "";
        SecretIdentity = "";
        City = "";
        _hasSuperPowers = false;
        _superPowers = new List<SuperPower>();
        IsAlive = true;
        IsHuman = true;
        CanFly = false;
    }
}
