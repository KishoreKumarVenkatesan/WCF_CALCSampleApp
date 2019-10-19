using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using System.Text;
using System.Threading.Tasks;

namespace WCFCalcServiceAssignment
{
    [DataContract]
    public class Calc
    {
        [DataMember]
        public double num1;
        [DataMember]
        public double num2;

    }
}
