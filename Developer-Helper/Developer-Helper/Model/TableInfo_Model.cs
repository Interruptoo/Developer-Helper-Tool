using Developer_Helper.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.Model
{
    class TableInfo_Model : ModelBase
    {
        public string TableName { get; }
        public string Owner {  get; }
        public string TableCommant { get; }
        
    }
}
