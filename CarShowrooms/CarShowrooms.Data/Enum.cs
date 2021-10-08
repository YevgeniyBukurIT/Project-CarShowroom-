using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowrooms.Data
{
    public enum Body { Hatchback, Sedan, Crossover, Convertible, Targa, Pickup, None = 10 }

    public enum Colour { white, black, yelow, red, green, orange, pink, brown, burgundy, None = 10 }

    public enum Wheels { radius_17, radius_18, radius_20, radius_21, None = 10 } 

    public enum Model { Audi, BMW, MersedecBenz, Renault, Subaru, Mitsubisi, None = 10 }

    public enum Sex { male, female, None = 10 }

    public enum NoveltyCheck
    {
        MadeInFactory, FromDismantling, None = 10
    }

    public enum Species { engine, wheels, body, optics, brakeSystem, wiring  }

    public enum Occasion { front, rear, full, None = 10 }
}
