using System;

namespace Test1
{
    class ExceptionIncorrectData : Exception
    {
        public ExceptionIncorrectData() : base("Incorrect data entered")
        {
          
        }
    }
}
