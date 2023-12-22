using Developer_Helper.Class;
using System;
using System.Collections.Generic;
using System.Linq;
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
            get { return _currentHost; }
            set { if (this._currentHost != value) { this._currentHost = value; OnPropertyChanged(nameof(CurrentHost)); } }
        }

        private string _currentDataBase;
        public string CurrentDataBase
        {
            get { return _currentDataBase; }
            set { if (this._currentDataBase != value) { this._currentDataBase = value; OnPropertyChanged(nameof(CurrentDataBase)); } }
        }

        private string _currentPort;
        public string CurrentPort
        {
            get { return _currentPort; }
            set { if (this._currentPort != value) { this._currentPort = value; OnPropertyChanged(nameof(CurrentPort)); } }
        }

        private string _currentUserName;
        public string CurrentUserName
        {
            get { return _currentUserName; }
            set { if (this._currentUserName != value) { this._currentUserName = value; OnPropertyChanged(nameof(CurrentUserName)); } }
        }

        private string _currentPassWord;
        public string CurrentPassWord
        {
            get { return _currentPassWord; }
            set { if (this._currentPassWord != value) { this._currentPassWord = value; OnPropertyChanged(nameof(CurrentPassWord)); } }
        }

        private string _currentConnectionName;
        public string CurrentConnectionName
        {
            get { return _currentConnectionName; }
            set { if (this._currentConnectionName != value) { this._currentConnectionName = value; OnPropertyChanged(nameof(CurrentConnectionName)); } }
        }

        private string _currentDescription;
        public string CurrentDescription
        {
            get { return _currentDescription; }
            set { if (this._currentDescription != value) { this._currentDescription = value; OnPropertyChanged(nameof(CurrentDescription)); } }
        }
        #endregion View Properties End

        #region Model Properties

        #endregion Model Properties End

        #region Constructors

        #endregion Constructors End

        #region Command

        #endregion Command End

        #region Method


        #endregion Method End
    }
}
