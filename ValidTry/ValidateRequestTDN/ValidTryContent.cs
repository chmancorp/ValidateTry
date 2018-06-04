using System;
using System.Collections.Generic;
using System.Text;
using ValidTry.Interface;
using Newtonsoft.Json;
namespace ValidTry.ValidateRequestTDN
{
    public class ValidTryContent : IValidTryContent
    {

        public bool validIntents(bool intent, int userId, int catalogId)
        {
            int numberIntent = 3;
            int intentNum = 1;

            if (intent)
            {
                //Consumo servicios
                    //Consumo de servicio para obtener el numero maximo de intentos
                        /*****IMPLEMENTAR AQUI EL CONSUMO DE SERVICIOS
                         ******numberIntent = 1 Ejemplo*/
                    //Termino de servicio de numero maximo

                    //Consumimos servicio para obtener el numero que ha usado el usuario
                        /*---IMPLEMENTAR AQUI EL CONSUMO PARA BUSCAR EN LA TABLA DE VALIDACIONES
                         ----intentNum = 1 Ejemplo-----*/
                //Termino de consumo de servicio

                numberIntent++;
                if (intentNum >= numberIntent)
                {
                    //AQUI SERVICIO PARA GUARDAR O ACTUALIZAR LA TABLA VALIDATION
                    Console.WriteLine("Ha sobrepasado el numero de intentos");
                }
                else
                {
                    //AQUI SERVICIO PARA GUARDAR O ACTUALIZAR LA TABLA VALIDATION
                    Console.WriteLine("Valido");

                }
                //Termina consumo de servico
            }




            return false;
        }

    }
}
