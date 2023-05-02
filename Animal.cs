using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Users_with_Objects
{
    internal class Animal
    {
        string _name;
        string _food;
        
        bool _gender;
        bool _is_warm_blood;

        public string Name { get { return _name; } set { _name = value; } }
        public string Food { get { return _food; } set {  _food = value; } }
        
        public bool isWarmBlooded { get { return _is_warm_blood; } set {_is_warm_blood = value; } }
        public bool Gender{get{ return _gender; } set { _gender = value; } }

        public Animal(string name, string food, bool gender, bool bloodtype) 
        {
            Name = name;
            food = Food;
            Gender = gender;
            isWarmBlooded = bloodtype;
        
        }
        public override string ToString()
        {

            return $"{_name} - Food {_food} - {(_is_warm_blood ? "Warm Blooded" : "Cold Blooded")} - {(_gender ? "Male" : "Female")}";
        
        }
    }
}
