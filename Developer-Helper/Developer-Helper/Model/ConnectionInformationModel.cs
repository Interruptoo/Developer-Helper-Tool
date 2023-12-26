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
            get => _hostAddress;
            set => SetProperty(ref _hostAddress, value, nameof(HostAddress));
        }

        /// <summary>
        /// Port
        /// </summary>
        [DataMember]
        public string Port
        {
            get => _port;
            set => SetProperty(ref _port, value, nameof(Port));
        }

        /// <summary>
        /// 계정
        /// </summary>
        [DataMember]
        public string UserName
        {
            get => _username;
            set => SetProperty(ref _username, value, nameof(UserName));
        }

        /// <summary>
        /// 비밀번호
        /// </summary>
        [DataMember]
        public string PassWord
        {
            get => _password;
            set => SetProperty(ref _password, value, nameof(PassWord));
        }

        /// <summary>
        /// DB
        /// </summary>
        [DataMember]
        public string DataBase
        {
            get => _dataBase;
            set => SetProperty(ref _dataBase, value, nameof(DataBase));
        }

        /// <summary>
        /// 연결이름
        /// </summary>
        [DataMember]
        public string ConnectionName
        {
            get => _connectionName;
            set => SetProperty(ref _connectionName, value, nameof(ConnectionName));
        }

        /// <summary>
        /// 설명
        /// </summary>
        [DataMember]
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value, nameof(Description));
        }
        #endregion 객체Property정의 End

        #region 객체메소드        
        #endregion
    }
}
