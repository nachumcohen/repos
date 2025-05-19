using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19may
{
    internal class Tool
    {
        protected int UseCount;
        protected string Category;
        protected string Name;
        protected int Weight;
        public Tool(string name, int weight,string category)
        {
            Name = name;
            Weight = weight;
            Category = category;
        }
        public string GetCategory()
        {
            return Category;
        }

        public int getUseCount()
        {
            return UseCount;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"weight of tool {Name} is {Weight}");    
        }
        public virtual void Use()
        {
            Console.WriteLine("Tool is being used");

        }

    }
}
