using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMvvm.Commands;

namespace Developer_Helper.ViewModel
{
    class MainWindow_ViewModel
    {
        #region Const

        #endregion Const

        #region Member Variables

        #endregion Member Variables

        #region View Properties
        
        #endregion View Properties

        #region Model Properties

        #endregion Model Properties

        #region Constructors

        #endregion Constructors

        #region Command
        private ICommand _selectedMenuItem;
        public ICommand SelectedMenuItem
        {
            get
            {
                if (_selectedMenuItem == null)
                    _selectedMenuItem = new RelayCommand(p => SetVisibleUserControl());

                return _selectedMenuItem;
                                    
            }

        }

        #endregion Command

        #region Method
        private void SetVisibleUserControl()
        {

        }
        #endregion Method
    }
}
