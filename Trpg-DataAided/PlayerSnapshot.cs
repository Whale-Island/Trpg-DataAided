using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trpg_DataAided
{
    [Serializable]
    public class PlayerSnapshot
    {
        public DateTime Date { get; set; }
        /// <summary>
        /// 0.升级 1.降级 2.修改属性
        /// </summary>
        public int Category { get; set; }
        public string Description { get; set; }
        public PlayerProperty Property { get; set; }
    }
}
