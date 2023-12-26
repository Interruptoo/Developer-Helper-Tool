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
        private ICommand _clearData;
        public ICommand ClearData
        {
            get
            {
                if (_clearData == null) _clearData = new RelayCommand(prop => ClearViewProperty());
                return _clearData;
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

        private void ClearViewProperty()
        {
            Mediator.Instance.SharedModel.HostAddress = string.Empty;
            Mediator.Instance.SharedModel.DataBase = string.Empty;
            Mediator.Instance.SharedModel.Port = string.Empty;

            _mediator.Notify("SettingDetail_Clear");

        }

        #endregion Method End
    }
}
