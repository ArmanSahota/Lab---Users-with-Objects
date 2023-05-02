using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Users_with_Objects
{
    internal class Flying : Animal
    {
        int _wings;
        int _speed;
        int _age;
        int _weight;

        public int Wings { get { return _wings; } set { _wings = value; } }
        public int Speed { get { return _speed; } set { _speed = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }

        public Flying(string name, string food, int age, int weight, bool gender, bool bloodtype, int wings, int speed)
          : base(name, food, gender, bloodtype)
        {
            wings = Wings;
            Speed = speed;
            Age = age;
            Weight = weight;


        }
        public override string ToString()
        {
            return $"{base.ToString()}- {Age} age - {Weight} Pounds  - {_wings} Wings - {_speed} MPH";
        }
    }
}
