using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Execute_Me__
{
    public class Thing
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool isAC { get; set; }
        public bool isBlind { get; set; } = true;
        public List<string> Fellings { get; set; }

        public Thing(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public bool toggleCurrent()
        {
            isAC = !isAC;
            return isAC;
        }
        public bool canSee(bool flag)
        {
            isBlind = flag; 
            return isBlind;
        }
        public void addFellings(string status)
        {
            Fellings.Add(status);
        }
    }
    public class Lovable : Thing
    {
        public bool isLovable { get; set; }
        public char Gender { get; set; }
        public Lovable(string name, int age, bool lovable, char gender): base(name, age)
        {
            isLovable = lovable;
            Gender = gender;
        }
        public void updateGender(char updatedGender)
        {
            Gender = updatedGender;
        }
    }
    public class pointSet : Thing
    {
        public int xCords { get; set; }
        public int yCords { get; set; }
        public pointSet(string name, int age, int xcoordinate, int ycoordinate): base(name,age)
       {
            xCords = xcoordinate;
            yCords = ycoordinate;
        }
    }
    public class Circle : Thing
    {
        public double radius { get; set; }
        public double pi = 3.1452;

        public Circle(string name, int age, double e) : base(name, age)
        {
            radius = e;
        }
    }
    public class sineWave : Thing
    {
        public double Amplitude { get; set; }
        public double Frequency { get; set; }
        public double Period => 1 / Frequency;
        public double Phase { get; set; }
        public double Wavelength => Speed / Frequency;
        public double Speed { get; set; }
        public sineWave(string name, int age, double amplitude, double frequency, double phase, double speed)
            : base(name, age)
        {
            Amplitude = amplitude;
            Frequency = frequency;
            Phase = phase;
            Speed = speed;
        }
    }
    public class Sequence : Thing
    {
        public int currentSequence {  get; set; }
        public Sequence(string name, int age, int seq)
            : base(name, age)
        {
            currentSequence= seq;   
        }
    }


}

