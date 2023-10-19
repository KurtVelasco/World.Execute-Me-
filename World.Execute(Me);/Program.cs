using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Execute_Me__
{
    // Naming Conventions: camelCase, If it's a singular word, then Capital
    // Parameters single words are lower case
    internal class Program
    {
        static void Main(string[] args)
        {
            Thing me = new Lovable("Me",0,false,'F');
            Thing you = new Lovable("You", 100, false,'M');

            World world = new World(5);
            world.addThing(me);
            world.addThing(you);

            world.activateSimulation();
        }
    }
}
