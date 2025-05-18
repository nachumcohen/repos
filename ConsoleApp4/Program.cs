using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent agent8200 = new Agent("agent8200",4);
            Report report = new Report();
            report.Summary = "hello agent";
            report.UrgencyLevel = 1;
            report.Sudmittedby = agent8200;
            MissionControl missionControl = new MissionControl();
            missionControl.AnalyzeReport(report);
            string encryp = IntelTools.EncryptMessage(report.Summary);
            IntelTools.LogTransmission(agent8200.CodeName, encryp);
            
        }
    }
}
