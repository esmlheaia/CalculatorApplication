using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T args1, T args2); //generic delegate formula
    internal class CalculatorClass
    {
        public Formula<double> info; //genric delagate's variable

        public double GetSum(double txtboxfnumber, double txtboxsnumber)  //method that return sum  
        {
            return txtboxfnumber + txtboxsnumber;
        }
        public double GetDifference(double txtboxfnumber, double txtboxsnumber) //method that return diffrence
        {
            return txtboxfnumber - txtboxsnumber;
        }
        public double GetProduct(double txtboxfnumber, double txtboxsnumber) //method that return product
        {
            return txtboxfnumber * txtboxsnumber;
        }
        public double GetQuotient(double txtboxfnumber, double txtboxsnumber) //method that return quotient
        {
            return txtboxfnumber / txtboxsnumber;
        }
        public event Formula<double> CalculateEvent //sent a message in the console just to confirm  if the delegate is added or remove
        {
            add
            {
                Console.WriteLine("Add Delegate");
            }
            remove
            {
                Console.WriteLine("Remove Delegate");
            }

        }
    }
}