using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkAnimals
{
    class Poodle : Dog
    {
        public string _numberOfPonyTales;
        public Poodle(string name, string favoriteDogFood, string numberOfPonyTales) : base(name, favoriteDogFood)
        {
            _numberOfPonyTales = numberOfPonyTales;
        }

        public override void Bark()
        {
            Console.WriteLine("wif wif");
        }


        public override string ToString()
        {
            return base.ToString() + $" number of pony tales {_numberOfPonyTales}";
        }

    }
}
