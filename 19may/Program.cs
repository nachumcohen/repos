using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19may
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hummer Hum1 = new Hummer("Hum1",20,"wood","e");
            Hummer Hum2 = new Hummer("Hum2", 15, "iron", "e");
            Drill Drill1 = new Drill("Drill1", 7,"t");
            PipeCutter cutter1 = new PipeCutter("Drill1", 30, "e");
            PipeCutter cutter2 = new PipeCutter("Drill2", 11, "e");
            Saw saw1 = new Saw("Drill1", 13, "f");
            Screwdriver scrDri1 = new Screwdriver("Drill1", 2, "e");
            Wrench Wrench1 = new Wrench("Drill1", 1,"wood", "f");
            Toolbox T1 = new Toolbox();
            T1.AddTool(saw1);
            T1.AddTool(scrDri1);
            T1.AddTool(Wrench1);
            T1.AddTool(cutter1);
            T1.PrintTools();
            
            



        }
    }
}
