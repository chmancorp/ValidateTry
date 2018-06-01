using System;
using ValidateRequestTDN;
using ValidTry.Interface;

namespace ConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var test = new ValidTryContent();
            var abc = test.validIntents(true);
        }
    }
    public class TESTT
    {
        private IValidTryContent _validContent;

        private TESTT(IValidTryContent validContent)
        {
            _validContent = validContent;
        }

    }
}
