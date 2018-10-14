using System;

namespace Lecture3.ExampleClasses
{
    //Some concepts discussed later in the lecture relating to structs:
    //  structs are value types
    //  structs cannot have default constructor
    //  structs do not support inheritance
    //  structs can implement interfaces
    public struct EuropeanOptionParams
    {
        public char type; // 'c' for call, 'p' for put
        public double T; // expiry time as a year fraction
        public double K; // strike
        double product;

         //Structs can still have methods
        public string GetTypeName(double t)
        {
            if (type == 'c')
            {
                return "Call";
            }
            if (type == 'p')
            {
                return "Put";
            }
            throw new InvalidOperationException("Unrecognized type");
        }   

  
    }
}
