using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trpg_DataAided
{
    public class PlayerSnapshot
    {
        public DateTime Date { get; set; }
        /// <summary>
        /// 1.升级 2.降级 3.修改属性
        /// </summary>
        public int Category { get; set; }
        public string Description { get; set; }
        public PlayerProperty CurrentProperty { get; set; }
    }
}
