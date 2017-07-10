


namespace Poehali
{
    using System.Runtime.Serialization;

    [DataContract]
    internal class Worker
    {
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        [DataMember]
        public int Weight
        {
            get;
            set;
        }

        [DataMember]
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

