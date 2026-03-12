// See https://aka.ms/new-console-template for more information
using System.Text;
using SuperHeroesApp.Models;

Console.WriteLine("Hello, World!");

var fly = new SuperPower
{
    Name = "Flight",
    Description = "The ability to fly through the air at will.",
    Level = PowerLevel.Medium
};

var superStrength = new SuperPower
{
    Name = "Super Strength",
    Description = "The ability to have strength far beyond that of a normal human.",
    Level = PowerLevel.High
};

var iceBreath = new SuperPower
{
    Name = "Ice Breath",
    Description = "The ability to exhale a freezing breath that can freeze objects and opponents.",
    Level = PowerLevel.Medium
};

var laserEyes = new SuperPower
{
    Name = "Laser Eyes",
    Description = "The ability to emit powerful laser beams from the eyes.",
    Level = PowerLevel.High
};

var xRayVision = new SuperPower
{
    Name = "X-ray Vision",
    Description = "The ability to see through solid objects.",
    Level = PowerLevel.Low
};

var superman = new SuperHero();
List<SuperPower> supermanPowers = new List<SuperPower>();
supermanPowers.Add(fly);
supermanPowers.Add(superStrength);
supermanPowers.Add(iceBreath);
supermanPowers.Add(laserEyes);
supermanPowers.Add(xRayVision);

superman.Name = "    Superman   ";
superman.Description = "A Kriptonian that lives on planet earth at metropolis, he loves to save the day and defeat Lex Luthor";
superman.SecretIdentity = "Clark Kent";
superman.City = "Metropolis";
superman.HasSuperPowers = true;
superman.SuperPowers = supermanPowers;
superman.IsAlive = true;
superman.IsHuman = false;
superman.CanFly = true;
// superman.UseSuperPower();
string resultPowers = superman.UseSuperPower();
Console.WriteLine(resultPowers);

var batman = new SuperHero();

batman.Name = "Batman";
batman.Description = "A man with a bat suit that defends Gotham city from villians like Joker, Penguin and the Riddler";
batman.SecretIdentity = "Bruce Wayne";
batman.City = "Gotham";
batman.HasSuperPowers = false;
batman.IsAlive = true;
batman.IsHuman = true;
batman.CanFly= false;

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();

public enum PowerLevel
{
       Low,
    Medium,
    High,
    Godlike
}

//Here is a RECORD instead of a class, it is immutable and has a built-in constructor, it is used to represent data that does not change, like a DTO (Data Transfer Object) or a Value Object
public record SuperHeroRecord(
    Guid Id, 
    string Name, 
    string Description, 
    string SecretIdentity, 
    string City, 
    bool HasSuperPowers, 
    IReadOnlyList<SuperPower> SuperPowers, 
    bool IsAlive, 
    bool isHuman, 
    bool Canfly)
{

} // Example of using the RECORD