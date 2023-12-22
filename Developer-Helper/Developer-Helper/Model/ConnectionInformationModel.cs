using Developer_Helper.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.Model
{
    /// <summary>
    /// name        : DB Connection Information
    /// desc        : DB 연결 정보
    /// author      : yuminho
    /// create date : 2023-12-21
    /// update date : 최종 수정 일자, 수정자, 수정개요 
    /// </summary>
    [Serializable]
    [DataContract]
    class ConnectionInformationModel : ModelBase
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
        [DataMember]
        public string HostAddress
        {
            //get { return _hostAddress; }
            //set { if (_hostAddress != value) _hostAddress = value; OnPropertyChanged(nameof(HostAddress)); }
            get => _hostAddress;
            set => SetProperty(ref _hostAddress, value);
        }

        /// <summary>
        /// Port
        /// </summary>
        [DataMember]
        public string Port
        {
            //get { return _port; }
            //set { if (_port != value) _port = value; OnPropertyChanged(nameof(Port)); }
            get => _port;
            set => SetProperty(ref _port, value);
        }

        /// <summary>
        /// 계정
        /// </summary>
        [DataMember]
        public string UserName
        {
            //get { return _username; }
            //set { if (_username != value) _username = value; OnPropertyChanged(nameof(UserName)); }
            get => _username;
            set => SetProperty(ref _username, value);
        }

        /// <summary>
        /// 비밀번호
        /// </summary>
        [DataMember]
        public string PassWord
        {
            //get { return _password; }
            //set { if (_password != value) _password = value; OnPropertyChanged(nameof(PassWord)); }
            get => _password;
            set => SetProperty(ref _password, value);
        }

        /// <summary>
        /// DB
        /// </summary>
        [DataMember]
        public string DataBase
        {
            //get { return _dataBase; }
            //set { if (_dataBase != value) _dataBase = value; OnPropertyChanged(nameof(DataBase)); }
            get => _dataBase;
            set => SetProperty(ref _dataBase, value);
        }

        /// <summary>
        /// 연결이름
        /// </summary>
        [DataMember]
        public string ConnectionName
        {
            //get { return _connectionName; }
            //set { if (_connectionName != value) _connectionName = value; OnPropertyChanged(nameof(ConnectionName)); }
            get => _connectionName;
            set => SetProperty(ref _connectionName, value);
        }

        /// <summary>
        /// 설명
        /// </summary>
        [DataMember]
        public string Description
        {
            //get { return _description; }
            //set { if (_description != value) _description = value; OnPropertyChanged(nameof(Description)); }
            get => _description;
            set => SetProperty(ref _description, value);
        }


        #endregion 객체Property정의 End

        #region 객체메소드

        #endregion
    }
}
