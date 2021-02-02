using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents_1_HW
{
    public class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action PrintMenu { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int , double> Calculate { get; set; }
        public Action <double> PrintResultNicely { get; set; }

        public void Run() {

            X = GetNumberFromUser();
            Y = GetNumberFromUser();
            PrintMenu();
            int chooise = GetUserChoice();
            Calculate(X ,Y, chooise);
            PrintResultNicely(Calculate(X, Y, chooise));
        }
    }
}
