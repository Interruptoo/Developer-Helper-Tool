using Developer_Helper.Class;
using Developer_Helper.Model;
using Developer_Helper.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using WpfMvvm.Commands;

namespace Developer_Helper.ViewModel
{
    class SetDBConnection_ViewModel : ViewModelBase
    {
        #region Const
        private Mediator _mediator;
        #endregion Const        

        #region Model Properties
        private ConnectionInformationModel _connectionInformation;
        public ConnectionInformationModel ConnectionInformation
        {
            get => _connectionInformation;
            set => SetProperty(ref _connectionInformation, value, nameof(ConnectionInformation));
        }

        #endregion Model Properties End

        #region Constructors        
        public SetDBConnection_ViewModel(Mediator mediator)
        {
            _mediator = mediator;

            ConnectionInformation = Mediator.Instance.SharedModel;
            
            new SettingDetail_ViewModel(_mediator);

        }
        #endregion Constructors End

        #region Command
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : Clear버튼 클릭
        /// </summary>
        private ICommand _clearDataCommand;
        public ICommand ClearDataCommand
        {
            get
            {
                if (_clearDataCommand == null) _clearDataCommand = new RelayCommand(p => ClearViewProperty());
                return _clearDataCommand;
            }
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-27
        /// description : Test Connection Command
        /// </summary>
        private ICommand _connectionTestCommand;
        public ICommand ConnectionTestCommand
        {
            get
            {
                if (_connectionTestCommand == null) _connectionTestCommand = new RelayCommand(p => ExcuteConnectionTest());
                return _connectionTestCommand;
            }
        }
        #endregion Command End

        #region Method
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : 초기화
        /// </summary>
        private void Init()
        {
            
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : 초기화
        /// </summary>
        private void ClearViewProperty()
        {            
            _mediator.Notify("SettingDetail_Clear");

        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-27
        /// description : DB연결 테스트
        /// </summary>
        private void ExcuteConnectionTest()
        {
            OracleDataBaseConnection connectionTest = new OracleDataBaseConnection(ConnectionInformation);

            if (!connectionTest.Connect_Test())
            {
                MessageBox.Show("DataBase Connection Faild", "DataBase Connection");
            }
            
        }

        #endregion Method End
    }
}
