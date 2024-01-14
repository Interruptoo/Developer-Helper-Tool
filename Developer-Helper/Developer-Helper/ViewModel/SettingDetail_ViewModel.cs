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
            init();
        }

        public SettingDetail_ViewModel(Mediator mediator)
        {                        
            _mediator = mediator;            

            _mediator.Subscribe("SettingDetail_Clear", () => clearProperty());            
        }

        #endregion Constructors End

        #region Command
        

        #endregion Command End

        #region Method
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : 
        /// </summary>
        private void init()
        {
            //CurrentConenction = Mediator.Instance.SharedModel;
            CurrentConenction = OracleDataBaseConnection.Instance.SharedModel;
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : ViewProperty를 초기화 한다.
        /// </summary>
        private void clearProperty()
        {
            init();
            //CurrentConenction.HostAddress = string.Empty;
            //CurrentConenction.DataBase = string.Empty;
            //CurrentConenction.Port = "1521";
            //CurrentConenction.UserName = string.Empty;
            //CurrentConenction.PassWord = string.Empty;
            //CurrentConenction.ConnectionName = string.Empty;
            //CurrentConenction.Description = string.Empty;
            CurrentConenction.HostAddress = "172.17.12.73";
            CurrentConenction.DataBase = "MEBDEV";
            CurrentConenction.Port = "1965";
            CurrentConenction.UserName = "xsup";
            CurrentConenction.PassWord = "xsup21";
            CurrentConenction.ConnectionName = string.Empty;
            CurrentConenction.Description = string.Empty;

        }
        #endregion Method End
    }
}
