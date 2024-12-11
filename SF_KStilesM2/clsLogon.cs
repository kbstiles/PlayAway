using System.Collections.Generic;

namespace SF_KStilesM2
{
    /// <summary>
    /// Class used to perform login actions.
    /// </summary>
    internal class clsLogon
    {
        /// <summary>
        /// Used to determine valid login info.
        /// </summary>
        /// <param name="user">Holds user inputted username</param>
        /// <param name="password">Holds user inputted password</param>
        /// <param name="inputList">Holds users info</param>
        /// <example>
        /// <code>
        /// clsLogon.Logon(tbxUsername.Text, tbxPassword.Text, Program.loggedInUserInfo);
        /// </code>
        /// </example>
        public static void Logon(string user, string password, List<string> inputList)
        {
            clsSQL.UserLogin(user, password, inputList);
        }
    }
}
