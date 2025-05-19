using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19may
{
    internal class Toolbox
    {
        Dictionary<string, List<Tool>> sortCategory;
        List<Tool> Tools;
        public Toolbox()
        {
            sortCategory = new Dictionary<string, List<Tool>>();
        }
        
        public void AddTool(Tool tool)
        {
            if (!sortCategory.ContainsKey(tool.GetCategory()))
            {
                sortCategory[tool.GetCategory()] = new List<Tool> { tool };
            }
            else
            {
                sortCategory[tool.GetCategory()].Add(tool);
            }

        }

        public void PrintTools()
        {
            foreach (var item in sortCategory)
            {
                Console.WriteLine(item.Key); 
            }
        }
    }
}
