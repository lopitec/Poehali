using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poehali
{
    using System.Runtime.CompilerServices;

    internal class Worker
    {
        public string Name
        {
            get;
            set;
        }

        public int Weight
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public Worker(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name is {0}, age is {1}, weight is {2}", Name, Age, Weight);
        }

     }
}

