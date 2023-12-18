using Developer_Helper.Class;
using Developer_Helper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        /// <summary>
        /// MainWindow에 렌더링해줄 Component
        /// </summary>
        private UserControl? _viewComponent;
        public UserControl? ViewComponent
        {
            get { return _viewComponent; }
            set 
            {
                if (_viewComponent != value) _viewComponent = value; OnpropertyChanged("ViewComponent");                
            }
        }

        /// <summary>
        /// PopupWindow 렌더링해줄 Component
        /// </summary>
        private UserControl? _popupComponent;
        public UserControl? PopupComponent
        {
            get { return _popupComponent; }
            set
            {
                if (_popupComponent != value) _popupComponent = value; OnpropertyChanged("PopupComponent");
            }
        }        
        #endregion View Properties

        #region Model Properties

        #endregion Model Properties

        #region Constructors

        #endregion Constructors

        #region Command
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-16
        /// description : menuItem 선택 시 렌더링 되는 userControl을 변경하는 Command
        /// </summary>
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

        private ICommand _selectPopupMenuItem;
        public ICommand SelectPopupMenuItem
        {
            get
            {
                if (_selectPopupMenuItem == null)
                    _selectPopupMenuItem = new RelayCommand(prop => CallPopupMenu(prop));
                
                return _selectPopupMenuItem;
            }                        
        }

        #endregion Command

        #region Method
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-16
        /// description : menuItem클릭시 Tag 값을 파싱해서 파라미터로 넘겨준다.
        /// </summary>
        private void SetVisibleUserControl(object p)
        {
            if (p == null) return;            

            string selectedMenu = ((System.Windows.FrameworkElement)p).Tag.ToString();

            ViewComponent = GetUserControl(selectedMenu);

        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-16
        /// description : 파라미터로 받은 값으로 case별 UserControl을 Return한다.
        /// </summary>
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

        private void CallPopupMenu(object p)
        {
            if (p == null) return;

            string selectedMenu = ((System.Windows.FrameworkElement)p).Tag.ToString();
            
            SetDBConnetion_View pop = new SetDBConnetion_View();
            pop.ShowDialog();
        }                        

        #endregion Method
    }
}
