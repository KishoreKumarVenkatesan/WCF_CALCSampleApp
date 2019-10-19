using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFCalcServiceAssignment
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double num1, double num2);
        [OperationContract]
        double Subtract(double num1, double num2);
        [OperationContract]
        double Multiply(double num1, double num2);
        [OperationContract]
        double Divide(double num1, double num2);

    }
}
