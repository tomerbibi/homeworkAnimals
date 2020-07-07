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

        public override void MakeSound()
        {
            Console.WriteLine("*horse sound*");
        }
        public virtual void neigh()
        {
            Console.WriteLine("*horse neigh sound*");
        }

        public override string ToString()
        {
            return base.ToString() + $" is racing horse {_racingHorse}";
        }
    }
}
