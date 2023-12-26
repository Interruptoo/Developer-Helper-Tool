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

        #region View Properties

        #endregion View Properties End

        #region Model Properties
        ConnectionInformationModel connectionInformationModel;

        private SettingDetail_ViewModel _settingDetail;
        public SettingDetail_ViewModel SettingDetail
        {
            get => _settingDetail;            
            set => SetProperty(ref _settingDetail, value);
        }        

        #endregion Model Properties End

        #region Constructors
        public SetDBConnection_ViewModel()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            this.Init();            
        }

        public SetDBConnection_ViewModel(Mediator mediator)
        {
            _mediator = mediator;

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
            _mediator = new Mediator();
            SettingDetail_ViewModel test = new SettingDetail_ViewModel(_mediator);
        }


        private void ClearViewProperty()
        {
            _mediator.Notify("SettingDetail_Clear");
        }

        #endregion Method End
    }
}
