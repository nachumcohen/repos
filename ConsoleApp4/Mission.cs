using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Mission
    {
        public string MissionName;
        public string TargetLocation;
        public Agent Agent;

        public void AssignAgent(string CodeName, int ClearanceLevel)
        {
            Agent = new Agent(CodeName, ClearanceLevel);
        }

        public void Brief()
        {
            Console.WriteLine($"Mission: {MissionName}, TargetLocation: {TargetLocation}, Agent: {Agent.CodeName}");
        }


    }
}
