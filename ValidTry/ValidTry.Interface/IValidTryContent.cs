/* @RELJ 
 * Praxis 2018
*/

namespace ValidTry.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IValidTryContent
    {
        /// <summary>
        ///this class validate the intents that the client change his/her
        ///name,direction or name
        /// </summary>
        /// <param name="intent"></param>
        /// <returns></returns>
        bool validIntents(bool intent);
        /// <summary>
        /// This class validate de answer for the circle of credit(DENA)
        /// </summary>
        void validCircle();
        /// <summary>
        /// Class for validate the intents that the user sends the SMS
        /// </summary>
        void validSMS();

    }
}
