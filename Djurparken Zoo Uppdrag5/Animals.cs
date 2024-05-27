using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Djurparken_Zoo_Uppdrag5
{
    public partial class Animals
    {
        protected int age;
        protected string name;
        protected string favFood;
        protected bool hungry;

        public Animals(int _age, string _name, string _favFood, bool _hungry)
        {
            age = _age;
            name = _name;
            favFood = _favFood;
            hungry = _hungry;
        
        }

        

        public string PetName()
        {
            return name;
        }

        public bool PetHungry()
        {
            return hungry;
        }
        public virtual string HungryAnimal()
        {
            return $"{name} är fortfarande hungrig!";
        }

        public string Eat(string _food)
        {
            if (_food != favFood)
            {
                return HungryAnimal();
            }
            else
            {
                hungry = false;
                return $"{name} är inte hungrig längre";
            }
        }

        public override string ToString()
        {
            return $"{name} ({age} år gammal)";
        }
    }
}
