using Developer_Helper.Class;
using Developer_Helper.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.ViewModel
{
    class SettingDetail_ViewModel : ViewModelBase
    {
        #region Const

        #endregion Const

        #region View Properties
        private string _currentHost;
        public string CurrentHost
        {
            get => _currentHost;
            set => SetProperty(ref _currentHost, value);
        }

        private string _currentDataBase;
        public string CurrentDataBase
        {
            get => _currentDataBase;
            set => SetProperty(ref _currentDataBase, value);
        }

        private string _currentPort;
        public string CurrentPort
        {            
            get => _currentPort;
            set => SetProperty(ref _currentPort, value);
        }

        private string _currentUserName;
        public string CurrentUserName
        {
            get => _currentUserName;
            set => SetProperty(ref _currentUserName, value);
        }

        private string _currentPassWord;
        public string CurrentPassWord
        {
            get => _currentPassWord;
            set => SetProperty(ref _currentPassWord, value);
        }

        private string _currentConnectionName;
        public string CurrentConnectionName
        {
            get => _currentConnectionName;
            set => SetProperty(ref _currentConnectionName, value);
        }

        private string _currentDescription;
        public string CurrentDescription
        {
            get => _currentDescription;
            set => SetProperty(ref _currentDescription, value);
        }
        #endregion View Properties End

        #region Model Properties

        #endregion Model Properties End

        #region Constructors
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : 빈값으로 생성자를 호출할 시 Clear한다.
        /// </summary>
        public SettingDetail_ViewModel()
        {
            clearProperty();
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : ConnectionInformationModel을 넘겨주면 모델을 ViewProperty와 매핑한다.
        /// </summary>
        public SettingDetail_ViewModel(ConnectionInformationModel inObj)
        {
            setViewProperty(inObj);
        }
        #endregion Constructors End

        #region Command

        #endregion Command End

        #region Method
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : ViewProperty를 초기화 한다.
        /// </summary>
        private void clearProperty()
        {
            CurrentHost = string.Empty;
            CurrentDataBase = string.Empty;
            CurrentPort = "1521";
            CurrentUserName = string.Empty;
            CurrentPassWord = string.Empty;
            CurrentConnectionName = string.Empty;
            CurrentDescription = string.Empty;
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : 생성자로 받은 객체를 mapping한다.
        /// </summary>
        private void setViewProperty(ConnectionInformationModel inObj)
        {
            CurrentHost = inObj.HostAddress;
            CurrentDataBase = inObj.DataBase;
            CurrentPort = inObj.Port;
            CurrentUserName = inObj.UserName;
            CurrentPassWord = inObj.PassWord;
            CurrentConnectionName = inObj.ConnectionName;
            CurrentDescription = inObj.Description;
        }

        #endregion Method End
    }
}
