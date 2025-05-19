using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19may
{
    internal class Hummer : Tool
    {
        
        public Hummer(string name, int weight,string butrial,string category) : base(name, weight, category)
        {
            Name = name;
            Weight = weight;
            UseCount = 0;


        }
        public override void Describe()
        {
            Console.WriteLine($"Hummer Name {Name} Weight: {Weight}");
        }
        public override void Use()
        {
            UseCount++;
            Console.WriteLine("Hummer is drill");
        }

    }
}
