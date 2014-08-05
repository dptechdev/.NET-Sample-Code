using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    
    class Program
    
    {

        delegate void customBirthdayDelegate(int param, int param1);
        static void Main(string[] args)
        {
            Action<int, int> myAdditionAction = (x, y) => Console.WriteLine(x + y);
            ProcessAction(2, 2, myAdditionAction);

            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMultiplyDel = (x, y) => x * y;
            ProcessAnotherAction(5, 10, funcAddDel);

            Func<int, int, int> birthdayCalculate = (x, y) => x - y;
            BirthdayMethod(2014, 1990, birthdayCalculate);

            customBirthdayDelegate BirthdayCalculation = new customBirthdayDelegate(BirthdayMethod);
            BirthdayCalculation(2014, 1990);

          
            



        }

        public static void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action has been processed.");
        }

        public static void ProcessAnotherAction(int x, int y, Func<int, int, int> func)
        {
            var result = func(x, y);
            Console.WriteLine(result);
            Console.WriteLine("Func is FUNKING");
        }

        public static void BirthdayMethod(int currentYear, int Yearborn, Func<int, int, int> funcparam)
        {
            var result = funcparam(currentYear, Yearborn);
            Console.WriteLine(result);
            Console.WriteLine("Calculation Complete");
        }

        public static void BirthdayMethod(int currentYear, int yearBorn)
        {
            var result = currentYear - yearBorn;
            Console.WriteLine(result);
            Console.WriteLine("Calculation complete");
        }

        public static void Speak()
        {
            Console.WriteLine("Hello, my name is Derek.");
        }

        public static void SpeakAgain()
        {
            Console.WriteLine("Hello, my name is also Derek and we're using delegates.");
        }

        public static void SpeakOneMoreTime()
        {
            Console.WriteLine("Once again, delegates are very cool.");
        }
    }
}
