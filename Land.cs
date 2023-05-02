using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Users_with_Objects
{
    internal class Land : Animal
    {
        int _speed;
        int _legs;
        string _habitat;
        int _age;
        int _weight;

        int Speed { get { return _speed; } set { _speed = value; } }
        int Legs { get { return _legs; } set { _legs = value; } }
        string Habitat { get { return _habitat; } set { _habitat = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }

        public Land(string name, string food, int age, int weight, bool gender, bool bloodtype, int speed, int legs, string habitat)
          : base(name, food, gender, bloodtype)
        {
            Speed = speed;
            Legs = legs;
            Habitat = habitat;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}- {Age} age - {Weight} Pounds  - {Legs} legs - {Habitat} habitat - {Speed} mph speed";
        }
    }


}

