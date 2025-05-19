using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19may
{
    internal class Drill : Tool
    {
        
        public Drill(string name, int weight,string category ) : base(name, weight, category)
        {
            Name = name;
            Weight = weight;
            Category = category;
            UseCount = 0;
        }
        public override void Describe()
        {
            Console.WriteLine($"Drill Name {Name} Weight: {Weight}");
        }
        public override void Use()
        {
            UseCount++;
            Console.WriteLine("Drill is drilling");
        }

        
    }
}
