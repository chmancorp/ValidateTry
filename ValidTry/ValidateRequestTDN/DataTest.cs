using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateRequestTDN
{
    public class DataTest
    {
        public string nombre { get; set; }
        public string test { get; set; }

        

        public string getData()
        {
            DataTest jsonTest = new DataTest()
            {
                nombre = "Jojo",
                test = "Star"
            };

            return jsonTest.ToString();

        }

    }

    
}
