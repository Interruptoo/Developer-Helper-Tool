using Developer_Helper.Class;
using Developer_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Developer_Helper.View
{
    /// <summary>
    /// SetDBConnetion_View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SetDBConnetion_View : Window
    {
        public SetDBConnetion_View()
        {
            InitializeComponent();
            
            DataContext = new SetDBConnection_ViewModel(new Mediator());
        }

        #region Event
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-21
        /// description : Window Close Event
        /// </summary>
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            callClose();
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-21
        /// description : 입력한 Connection 정보를 저장하고 닫는다.
        /// </summary>
        private void Save_Click(object sender, RoutedEventArgs e)
        {


            callClose();
        }

        #endregion Event End

        #region Method
        /// <summary>
        /// author : yuminhio
        /// date   : 2023-12-21
        /// description : Window Close
        /// </summary>
        private void callClose()
        {
            Close();
        }
        #endregion Method End
        
    }
}
