using Developer_Helper.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.Model
{
    class SetDBConnetion_Model : ModelBase
    {
        #region 객체변수선언
        private string _hostAddress;
        private string _port;
        private string _username;
        private string _password;
        private string _dataBase;
        private string _connectionName;
        private string _description;
        #endregion 객체변수선언 END

        #region 객체Property정의        
        /// <summary>
        /// Host
        /// </summary>
        public string HostAddress
        {
            get { return _hostAddress; }
            set { if (_hostAddress != value) _hostAddress = value; OnpropertyChanged("HostAddress"); }
        }

        /// <summary>
        /// Port
        /// </summary>
        public string Port
        {
            get { return _port; }
            set { if (_port != value) _port = value; OnpropertyChanged("Port"); }
        }

        /// <summary>
        /// 계정
        /// </summary>
        public string UserName
        {
            get { return _username; }
            set { if (_username != value) _username = value; OnpropertyChanged("UserName"); }
        }

        /// <summary>
        /// 비밀번호
        /// </summary>
        public string PassWord
        {
            get { return _password; }
            set { if (_password != value) _password = value; OnpropertyChanged("PassWord"); }
        }

        /// <summary>
        /// DB
        /// </summary>
        public string DataBase
        {
            get { return _dataBase; }
            set { if (_dataBase != value) _dataBase = value; OnpropertyChanged("DataBase"); }
        }

        /// <summary>
        /// 연결이름
        /// </summary>
        public string ConnectionName
        {
            get { return _connectionName; }
            set { if (_connectionName != value) _connectionName = value; OnpropertyChanged("ConnectionName"); }
        }

        /// <summary>
        /// 설명
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { if (_description != value) _description = value; OnpropertyChanged("Description"); }
        }


        #endregion 객체Property정의 End

        #region 객체메소드
        
        #endregion
    }


}
