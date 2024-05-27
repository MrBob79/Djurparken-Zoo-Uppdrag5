using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurparken_Zoo_Uppdrag5
{
    internal class Lion : Animals
    {
        public Lion(int _age, string _name, string _favFood, bool _hungry) : base (_age, _name, _favFood, _hungry)  
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
