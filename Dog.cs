using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkAnimals
{
    class Dog : Animal
    {
        public string _favoriteDogFood;
        public Dog(string name, string favoriteDogFood) : base(name)
        {
            _favoriteDogFood = favoriteDogFood;
        }
        public virtual void Bark()
        {
            Console.WriteLine("woof woof");
        }
        public override void MakeSound()
        {
            Bark();
        }

        public override string ToString()
        {
            return base.ToString() + $" favorite food {_favoriteDogFood}";
        }
  
    }
}
