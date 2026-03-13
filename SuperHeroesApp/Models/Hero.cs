using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroesApp.Models
{
    internal abstract class Hero
    {
        public abstract string Name { get; set; }
        public abstract string SaveTheWorld();
        // Abstract method is used to force the derived classes to implement it, it does not have a body and it is declared with the abstract keyword, it can only be used in an abstract class
        public string SaveEarth()
        {
            return $"{Name} save the Earth!!!";
        }
    }
}
