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
        /// </summary>
        /// <param name="intent"></param>
        /// <param name="requestId"></param>
        /// <returns></returns>
        bool validIntents(bool intent, int userId, int catalogId);

    }
}
