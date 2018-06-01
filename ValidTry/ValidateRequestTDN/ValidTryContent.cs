using System;
using System.Collections.Generic;
using System.Text;
using ValidTry.Interface;

namespace ValidateRequestTDN
{
    public class ValidTryContent : IValidTryContent
    {
        public void validCircle()
        {
            throw new NotImplementedException();
        }

        public bool validIntents(bool intent)
        {
            if (intent)
            {
             //Consumo servicios
                //Consumo de servicio para obtener el numero maximo de intentos
                int numberIntent = 1;
                //Termino de servicio de numero maximo

                //consumo de servicio para obtener los valores 
                DataTest valuesJson = new DataTest();
                string test =  valuesJson.getData();
            

             //Termina consumo de servico
            }




            return false;
        }

        public void validSMS()
        {
            throw new NotImplementedException();
        }
    }
}
