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

        public Thing(string name, int age)
        {
            Name = name;
            Age = age;
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


}

