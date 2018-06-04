using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using Newtonsoft.Json;
namespace ValidTry.ValidateRequestTDN
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

            var f = JsonConvert.SerializeObject(jsonTest);
            
            return  f;

        }

    }

    
}
