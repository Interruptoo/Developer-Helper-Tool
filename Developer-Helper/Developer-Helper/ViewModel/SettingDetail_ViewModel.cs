using Developer_Helper.Class;
using Developer_Helper.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMvvm.Commands;

namespace Developer_Helper.ViewModel
{
    class SettingDetail_ViewModel : ViewModelBase
    {
        #region Const
        private readonly Mediator _mediator;
        #endregion Const        

        #region Properties
        //private string _currentHost;
        //public string CurrentHost
        //{
        //    get => _currentHost;
        //    set => SetProperty(ref _currentHost, value, nameof(CurrentHost));
        //}

        //private string _currentDataBase;
        //public string CurrentDataBase
        //{
        //    get => _currentDataBase;
        //    set => SetProperty(ref _currentDataBase, value, nameof(CurrentDataBase));
        //}

        //private string _currentPort;
        //public string CurrentPort
        //{
        //    get => _currentPort;
        //    set => SetProperty(ref _currentPort, value, nameof(CurrentPort));
        //}

        //private string _currentUserName;
        //public string CurrentUserName
        //{
        //    get => _currentUserName;
        //    set => SetProperty(ref _currentUserName, value, nameof(CurrentUserName));
        //}

        //private string _currentPassWord;
        //public string CurrentPassWord
        //{
        //    get => _currentPassWord;
        //    set => SetProperty(ref _currentPassWord, value, nameof(CurrentPassWord));
        //}

        //private string _currentConnectionName;
        //public string CurrentConnectionName
        //{
        //    get => _currentConnectionName;
        //    set => SetProperty(ref _currentConnectionName, value, nameof(CurrentConnectionName));
        //}

        //private string _currentDescription;
        //public string CurrentDescriptionrrentPort
        //{
        //    get => _currentDescription;
        //    set => SetProperty(ref _currentDescription, value, nameof(CurrentDescriptionrrentPort));
        //}

        private ConnectionInformationModel _currentConenction;
        public ConnectionInformationModel CurrentConenction
        {
            get => _currentConenction;
            set => SetProperty(ref  _currentConenction, value, nameof(CurrentConenction));
        }


        #endregion Properties End

        #region Constructors
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : 빈값으로 생성자를 호출할 시 Clear한다.
        /// </summary>
        public SettingDetail_ViewModel()
        {
            CurrentConenction = Mediator.Instance.SharedModel;
        }

        public SettingDetail_ViewModel(Mediator mediator)
        {                        
            _mediator = mediator;            

            _mediator.Subscribe("SettingDetail_Clear", () => clearProperty());
        }

        #endregion Constructors End

        #region Command
        private ICommand _clearCommand;
        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand == null) _clearCommand = new RelayCommand(p => clearProperty());
                
                return _clearCommand;
            }
        }

        private ICommand _initCommand;
        public ICommand InitCommand
        {
            get
            {
                if (_initCommand == null) _initCommand = new RelayCommand(p => init());

                return _initCommand;
            }
        }

        #endregion Command End

        #region Method
        private void init()
        {            
            CurrentConenction.HostAddress = "www.naver.com";
            CurrentConenction.DataBase = "DEV";
            CurrentConenction.Port = "1521";
        }


        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : ViewProperty를 초기화 한다.
        /// </summary>
        private void clearProperty()
        {
            CurrentConenction = Mediator.Instance.SharedModel;

        }        
        
        
        #endregion Method End
    }
}
