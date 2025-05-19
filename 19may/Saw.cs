using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19may
{
    internal class Saw : Tool
    {
        
        
        
        public Saw(string name, int weight, string category) : base(name, weight, category)
        {
            Name = name;
            Weight = weight;
            UseCount = 0;


        }
        public override void Describe()
        {
            Console.WriteLine($"Saw Name {Name} Weight: {Weight}");
        }
        public override void Use()
        {
            UseCount++;
            Console.WriteLine("Saw is sawing");
        }
    }
}
