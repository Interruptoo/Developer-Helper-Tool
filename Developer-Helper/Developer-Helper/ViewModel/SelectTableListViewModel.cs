using Developer_Helper.Class;
using Developer_Helper.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.ViewModel
{
    class SelectTableListViewModel : ViewModelBase
    {
        #region [Consts]

        #endregion

        #region [Constructor]

        /// <summary>
        /// name         : SaveMedicationCounselingData 생성자
        /// desc         : SaveMedicationCounselingData 생성자
        /// author       : Parkjihye 
        /// create date  : 2016-04-27 오전 11:32:58
        /// update date  : 최종 수정 일자, 수정자, 수정개요 
        /// </summary>
        public SelectTableListViewModel()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            this.Init();
        }

        #endregion //Constructor

        #region [Member Variables]

        #endregion

        #region [Property]
        ObservableCollection<TableInfo> _tableInfo = new ObservableCollection<TableInfo>();
        ObservableCollection<TableInfo> _favTableInfo = new ObservableCollection<TableInfo>();
        ObservableCollection<ColumnInfo> _columnInfo = new ObservableCollection<ColumnInfo>();
        ObservableCollection<TableReferenceInfo> _tableRefInfo = new ObservableCollection<TableReferenceInfo>();
        ObservableCollection<TableInfo> _tableIndexInfo = new ObservableCollection<TableInfo>();
        ObservableCollection<TableAddInfo> _tableAddInfo = new ObservableCollection<TableAddInfo>();
        ObservableCollection<CCCCCSTE> _commonCodeInfo = new ObservableCollection<CCCCCSTE>();

        #endregion

        #region [Method]
        private void Init()
        {

            GetTableList();
        }

        private void GetTableList()
        {
            _tableInfo.Clear();


        }
        #endregion
    }
}
