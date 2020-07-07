using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homeworkAnimals
{
    class Horse : Animal
    {
        public bool _racingHorse;
        public Horse(string name, bool racingHorse) : base(name)
        {
            _racingHorse = racingHorse;
        }
        public virtual void neigh()
        {
            Console.WriteLine("*horse sound*");
        }


        public override void MakeSound()
        {
            neigh();
        }
      
        public override string ToString()
        {
            return base.ToString() + $" is racing horse {_racingHorse}";
        }
    }
}
