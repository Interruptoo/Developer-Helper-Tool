using Developer_Helper.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.Model
{
    class TableAddInfo : ModelBase
    {
        public string TABLE_NAME { get; set; }

        public string COL_NAME { get; set; }
        public string COL_VALUE { get; set; }
    }
}
