using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager
{
    public static class SysAccount
    {
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool CreateAccount(string username, string password)
        {
            string cmd = string.Format("SELECT * FROM ACCOUNT WHERE USER_NAME= '{0}'", username);
            int rowsCount = StaticValue.DATABASECONNECTION.Execute(cmd).Rows.Count;
            if (rowsCount > 0)
            {
                return false;
            }
            else
            {
                cmd = string.Format("DECLARE @SUCC INT " +
                                   "EXEC PROC_INSERT_ACCOUNT '{0}', '{1}', @SUCC OUTPUT" +
                                   " SELECT STR(@SUCC, 10)", username, ComputeSha256Hash(password));
                rowsCount = int.Parse(StaticValue.DATABASECONNECTION.Execute(cmd).Rows[0][0].ToString());
                if (rowsCount < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool LoginAccount(string username, string password)
        {
            try
            {
                string cmd = string.Format("SELECT * FROM FUNCTION_LOGIN_ACCOUNT('{0}','{1}')", username,ComputeSha256Hash(password));
                StaticValue.ACCOUNT = StaticValue.DATABASECONNECTION.Execute(cmd).Rows[0][0].ToString();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
       
    }
}
