using System;

namespace WaterDepth
{
    class TestOfStateException : System.ApplicationException
    {
        public TestOfStateException(string exceptionType)
            : base(exceptionType)
        {

        }
    }
}