using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFCalcServiceAssignment
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class CalcService : ICalculator
    {
        double ICalculator.Add(double num1, double num2)
        {
            return num1 + num2;
        }

        double ICalculator.Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        double ICalculator.Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        double ICalculator.Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
