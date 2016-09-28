using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KincoLightManager
{
    /// <summary>
    /// 多燈亮滅狀態控制碼
    /// </summary>
    public enum LedOnOffStatus
    {
        /// <summary>
        /// 灯灭
        /// </summary>
        Off = 0,

        /// <summary>
        /// 绿灯亮
        /// </summary>
        GreenOn=1,

        /// <summary>
        /// 红灯亮
        /// </summary>
        RedOn =2
    }
}
