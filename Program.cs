using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homeworkAnimals
{
    class Program
    {

        static void AnimalsSing (Animal[] a)
        {
            for (int i = 0; i<a.Length; i++)
            {
                a[i].MakeSound();
            }
        }

        static void Main(string[] args)
        {
            Wolf moshe = new Wolf("moshe", "cow meet", "cow killers");
            Poodle pich = new Poodle("pich", "bonzo", "5");
            Horse bruno = new Horse("bruno", true);
            PetWolf simba = new PetWolf("simba", "sheep meet", "the dominators");

        }
    }
}
