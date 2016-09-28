using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KincoLightManager
{
    /// <summary>
    /// 整个货架灯或灯塔的行为碼
    /// Create By  : Enzhi.Zhou
    /// Create Date: 2016/09/27
    /// </summary>
    public enum RackTowerLedStatus
    {
        /// <summary>
        /// 货架所有灯灭，五色灯单色灯灭
        /// </summary>
        RackLedOff_TowerWhiteOff=0,

        /// <summary>
        /// 货架所有灯亮绿色，五色灯单色灯亮
        /// </summary>
        RackGreenOn_TowerWhiteOn=1,

        /// <summary>
        /// 货架所有灯亮红色，五色灯单色灯亮
        /// </summary>
        RackRedOn_TowerWhiteOn=2,

        /// <summary>
        /// 货架红绿灯塔灭
        /// </summary>
        Tower_RedOff_GreenOff=3,

        /// <summary>
        /// 货架红灯塔亮
        /// </summary>
        Tower_RedOn=4,

        /// <summary>
        /// 货架绿灯塔亮
        /// </summary>
        Tower_GreenOn=5,

        /// <summary>
        /// 货架红绿灯塔都亮
        /// </summary>
        Tower_RedOn_GreenOn=6
    }
}
