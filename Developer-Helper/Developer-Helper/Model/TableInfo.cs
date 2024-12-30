using Developer_Helper.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.Model
{
    class TableInfo : ModelBase
    {
        public string OWNER { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_COMMENTS { get; set; }
        public int CREATED_DAYS { get; set; }
        public int MODIFY_DAYS { get; set; }
        public string KEYWORD { get; set; }

        public string EX_OWNER { get; set; }

        public string INDEX_NAME { get; set; }
        public string COL_NAME { get; set; }
        public string COMMENTS { get; set; }
    }
}
