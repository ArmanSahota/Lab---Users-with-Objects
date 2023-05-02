using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Users_with_Objects
{
    internal class Sea : Animal
    {
        string _habitat;
        int _fins;
        int _age;
        int _weight;

        public string Habitat { get { return _habitat; } set { _habitat = value; } }
        public int Fins { get { return _fins; } set { _fins = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }


        public Sea(string name, string food, int age, int weight, bool gender, bool bloodtype, int fins, string habitat)
          : base(name, food, gender, bloodtype)
        {
            fins = Fins;
            habitat = Habitat;
            Age = age;
            Weight = weight;


        }
        public override string ToString()
        {
            return $"{base.ToString()}- {Age} age - {Weight} Pounds  - {Fins} fins - {Habitat} habitat";
        }
    }
}


