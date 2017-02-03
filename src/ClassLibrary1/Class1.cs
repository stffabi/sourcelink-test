using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int TestXy(int value)
        {
            if (value == 0)
            {
                throw new Exception("Not valid");
            }
            return value;
        }
    }
}
