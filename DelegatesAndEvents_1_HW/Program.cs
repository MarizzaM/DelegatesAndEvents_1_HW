using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents_1_HW
{
    class Program
    {

        static void Main(string[] args)
        {
            AtomicCalculator ac = new AtomicCalculator();
            SimpleCalculator sc = new SimpleCalculator();

            ac.GetNumberFromUser = sc.NumberGetter;
            ac.PrintMenu = sc.PrintMenu;
            ac.GetUserChoice = sc.GetUserChoice;   
            ac.Calculate = sc.Calculate;
            ac.PrintResultNicely = sc.PrintResultNicely;
            ac.Run();

        }
    }
}
