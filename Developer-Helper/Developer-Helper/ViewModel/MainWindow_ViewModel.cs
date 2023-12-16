using Developer_Helper.Class;
using Developer_Helper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfMvvm.Commands;

namespace Developer_Helper.ViewModel
{
    class MainWindow_ViewModel : ViewModelBase
    {
        #region Const

        #endregion Const

        #region Member Variables

        #endregion Member Variables

        #region View Properties
        private UserControl? _viewComponent;
        public UserControl? ViewComponent
        {
            get { return _viewComponent; }
            set 
            {
                if (_viewComponent != value) _viewComponent = value; OnpropertyChanged("ViewComponent");                
            }
        }
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
                    _selectedMenuItem = new RelayCommand(prop => SetVisibleUserControl(prop));

                return _selectedMenuItem;

            }

        }

        #endregion Command

        #region Method                
        private void SetVisibleUserControl(object p)
        {
            if (p == null) return;            

            string selectedMenu = ((System.Windows.FrameworkElement)p).Tag.ToString();

            ViewComponent = GetUserControl(selectedMenu);

        }

        private UserControl GetUserControl(string SelectedMenu)
        {
            UserControl? userControl = null;

            switch (SelectedMenu)
            {
                case "Table":
                    userControl = new SelectTableList();
                    break;
                case "SQL":
                    userControl = new ExcuteSQLControl();
                    break;
                default:                    
                    break;
            }

            return userControl;


        }
        #endregion Method
    }
}
