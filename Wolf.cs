using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homeworkAnimals
{
    class Wolf : Dog
    {
        public string _nameOfPack;
        
        public Wolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood)
        {
            _nameOfPack = nameOfPack;
        }

        public override void MakeSound()
        {
            Console.WriteLine("owooooooo");
        }

        public override string ToString()
        {
            return base.ToString() + $" name of pack {_nameOfPack}";
        }
    }
}
