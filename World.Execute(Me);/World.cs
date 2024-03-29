﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Execute_Me__
{
    // Naming Conventions: camelCase, If it's a singular word, then Capital
    //
    public class World
    {


        private List<Thing> things = new List<Thing>();
        public World(int size)
        {
            things=new List<Thing>(size);
        }
        public void addThing(Thing thing)
        {
            things.Add(thing);
        }
        public void activateSimulation()
        {
            Console.WriteLine("World Generated with " + things.Count
                + " souls");
        }

        public void timeTravelForTwo(string yearPos,int year, Thing passenger_1 ,Thing passenger_2)
        {

        }
        public void Unite(Thing Partner_1, Thing Partner_2)
        {

        }
        public void runExecution()
        {

        }
        public void Announce(string header, string message)
        {
            Console.WriteLine(header + "\n");
            Console.WriteLine(message);
        }

    }
}
