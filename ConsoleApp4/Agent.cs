using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Agent
    {
        public string CodeName;
        private int ClearanLevel;

        public Agent(string codeName, int clearanLevel)
        {
            CodeName = codeName;
            ClearanLevel = clearanLevel;
        }

        public void Report()
        {
            Console.WriteLine($"Agent {CodeName} repoting. Clearance Level: {ClearanLevel}");
        }

        public int GetClearanceLevel()
        {
            return ClearanLevel;
        }
        public void SetClearanLevel(int level)
        {
            
            if (level > 1 && level <= 5)
            {
                ClearanLevel = level;
            }
            else
            {
                Console.WriteLine("enter ClearanLevel 1-5 only");
            }
        }

        
    }
}
