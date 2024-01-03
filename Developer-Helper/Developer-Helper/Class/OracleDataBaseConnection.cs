using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Developer_Helper.Model;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace Developer_Helper.Class
{
    class OracleDataBaseConnection
    {                
        private OracleCommand cmd;

        private ConnectionInformationModel inputDBInfo;

        #region Constructor
        public OracleDataBaseConnection(ConnectionInformationModel obj)
        {
            this.inputDBInfo = obj;
        }
        #endregion Constructor end


        public bool Connect_Test()
        {
            bool result = false;            
            //string connectionString = $"Data Source={inputDBInfo.DataBase};User Id={inputDBInfo.UserName};Password={inputDBInfo.PassWord}";
            string connectionString = $"Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = {inputDBInfo.HostAddress})(PORT = {inputDBInfo.Port})))(CONNECT_DATA =(SID = {inputDBInfo.DataBase})));User Id={inputDBInfo.UserName};Password={inputDBInfo.PassWord}";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    //Console.WriteLine(conn.State);
                    Debug.WriteLine($"Oracle Status : {conn.State}");
                    result = true;
                }
                catch(Exception ex)
                {
                    //Console.WriteLine (ex.Message);
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }                
            }

            return result;
        }
        
    }
}
