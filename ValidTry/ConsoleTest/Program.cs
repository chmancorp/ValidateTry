
namespace ConsoleTest
{
    using System;
    using ValidTry.ValidateRequestTDN;
    using ValidTry.Interface;

    public class Program
    {
        static void Main(string[] args)
        {
            var test = new ValidTryContent();
            var abc = test.validIntents(true, 1,1
                );

            Console.ReadKey();
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
