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
        public string serverVersion;
        public string clientDriver;

        private OracleConnection conn;
        private OracleCommand cmd;
        private ConnectionInformationModel inputDBInfo;

        #region Instance
        private static OracleDataBaseConnection _instance;
        public static OracleDataBaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OracleDataBaseConnection();
                }
                return _instance;
            }
        }

        private ConnectionInformationModel _sharedModel;
        public ConnectionInformationModel SharedModel
        {
            get
            {
                if (_sharedModel == null)
                {
                    _sharedModel = new ConnectionInformationModel();
                }
                return _sharedModel;
            }
        }
        #endregion Instance End

        #region Constructor
        public OracleDataBaseConnection()
        {
            
        }

        public OracleDataBaseConnection(ConnectionInformationModel obj)
        {
            this.inputDBInfo = obj;
        }
        #endregion Constructor end

        /// <summary>
        /// author : yuminhio
        /// date   : 2024-01-04
        /// description : DB Connection 정보를 Setting한다.
        /// </summary>
        private string SetConnectInformation()
        {            
            //string connectionString = $"Data Source={inputDBInfo.DataBase};User Id={inputDBInfo.UserName};Password={inputDBInfo.PassWord}";            
            return $"Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = {inputDBInfo.HostAddress})(PORT = {inputDBInfo.Port})))(CONNECT_DATA =(SID = {inputDBInfo.DataBase})));User Id={inputDBInfo.UserName};Password={inputDBInfo.PassWord}";
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2024-01-04
        /// description : DB Connection Open
        /// </summary>
        private void Open()
        {
            conn = new OracleConnection(SetConnectInformation());

            conn.Open();
            
            Debug.WriteLine($"Oracle Status : {conn.State}");            
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2024-01-04
        /// description : DB Connection Close
        /// </summary>
        private void Close()
        {
            conn.Close();
        }

        private void SetCommand()
        {
            //연결한 DB의 ClientDriver를 조회해서 가져온다.
            string cmdText = @"select distinct                                            
                                    i.client_driver
                                    from v$session s,
                                    v$session_connect_info i
                                    where s.sid = i.sid                                            
                                    and s.program = 'Developer-Helper.exe'";

            cmd = new OracleCommand(cmdText, conn);
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2024-01-04
        /// description : Command Excute, Return Data
        /// </summary>
        private void ExcuteCommand()
        {
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    serverVersion = conn.ServerVersion.ToString();
                    clientDriver = reader.GetString(0);
                }
            }
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2024-01-04
        /// description : DB Connection Test
        /// </summary>
        public bool Connect_Test()
        {
            bool result = false;

            try
            {
                Open();

                SetCommand();

                ExcuteCommand();

                result = true;
            }
            catch(Exception ex)
            {                
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Close();
            }            

            return result;
        }
        
    }
}
