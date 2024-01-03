using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
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
        static string serverVersion;
        static string clientDriver;

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
                    string cmdText = @"select distinct                                            
                                            i.client_driver
                                            from v$session s,
                                            v$session_connect_info i
                                            where s.sid = i.sid                                            
                                            and s.program = 'Developer-Helper.exe'";

                    conn.Open();

                    //Console.WriteLine(conn.State);
                    Debug.WriteLine($"Oracle Status : {conn.State}");

                    cmd = new OracleCommand(cmdText, conn);
                    //using(OracleDataReader reader = cmd.ExecuteReader())
                    //{
                    //    while(reader.Read())
                    //    {
                    //        int id = reader.GetInt32(0);
                    //        string name = reader.GetString(1);
                    //    }
                    //}
                    using(OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            serverVersion = conn.ServerVersion.ToString();
                            clientDriver = reader.GetString(0);                            
                        }
                    }                                        

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
