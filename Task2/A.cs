using System;

namespace Task2
{
    public struct A:IBase
    {
        public string GetInfo()
        {
            return "A class";
        }

        public static implicit operator Base(A a)
        {
            return new Base();
        }

        
    }
}
