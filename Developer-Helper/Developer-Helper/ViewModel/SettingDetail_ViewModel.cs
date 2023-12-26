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

namespace Developer_Helper.ViewModel
{
    class SettingDetail_ViewModel : ViewModelBase
    {
        #region Const
        private readonly Mediator _mediator;
        #endregion Const        

        #region Properties
        private ConnectionInformationModel connectionInformation;
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
        private void init()
        {
            clearProperty();
        }


        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-22
        /// description : ViewProperty를 초기화 한다.
        /// </summary>
        private void clearProperty()
        {
            connectionInformation = new ConnectionInformationModel();
            connectionInformation.Port = "1521";
        }        

        #endregion Method End
    }
}
