using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KincoLightManager
{
    /// <summary>
    /// 步科帶燈貨架控制命令產生中心
    /// Create By  : Enzhi.Zhou
    /// Create Date: 2016/09/27
    /// </summary>
    public static class g
    {
        public static void SendCommand(string cmd)
        {
            CommandCenter.Broadcast(cmd);
        }

        #region 多货架控制命令
        /// <summary>
        /// 創建多貨架控制命令
        /// </summary>
        /// <param name="rackStatus"></param>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateRackControlCmd(RackTowerLedStatus rackStatus, params UInt16[] racks)
        {
            string cmd = CommandCenter.CreateRackControlCmd(rackStatus, racks);
            return cmd;
        }

        /// <summary>
        /// 創建货架所有灯灭，五色灯单色灯灭指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnRackLedAndTowerWhiteLed(params UInt16[] racks)
        {
            return CreateRackControlCmd(RackTowerLedStatus.RackLedOff_TowerWhiteOff, racks);
        }

        /// <summary>
        /// 創建货架所有灯亮绿色，五色灯单色灯亮指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOnRackGreenLedAndTowerWhiteLed(params UInt16[] racks)
        {
            return CreateRackControlCmd(RackTowerLedStatus.RackGreenOn_TowerWhiteOn, racks);
        }

        /// <summary>
        /// 創建货架所有灯亮红色，五色灯单色灯亮指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOnRackRedLedAndTowerWhiteLed(params UInt16[] racks)
        {
            return CreateRackControlCmd(RackTowerLedStatus.RackRedOn_TowerWhiteOn, racks);
        }

        /// <summary>
        /// 創建货架红绿灯塔灭指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOffTowerRedAndGreenLed(params UInt16[] racks)
        {
            return CreateRackControlCmd(RackTowerLedStatus.Tower_RedOff_GreenOff, racks);
        }

        /// <summary>
        /// 創建货架红灯塔亮指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOnTowerRedLed(params UInt16[] racks)
        {
            return CreateRackControlCmd(RackTowerLedStatus.Tower_RedOn, racks);
        }

        /// <summary>
        /// 創建货架绿灯塔亮指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOnTowerGreeLed(params UInt16[] racks)
        {
            return CreateRackControlCmd(RackTowerLedStatus.Tower_GreenOn, racks);
        }

        /// <summary>
        /// 創建货架红绿灯塔都亮指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOffTowerRedGreenLed(params UInt16[] racks)
        {
            return CreateRackControlCmd(RackTowerLedStatus.Tower_RedOff_GreenOff, racks);
        }

        #endregion

        #region 多灯亮灭控制命令

        /// <summary>
        /// 多灯亮灭控制命令
        /// </summary>
        /// <param name="lightStatus"></param>
        /// <param name="rackAddress_LEDAddress_Pairs"></param>
        /// <returns></returns>
        public static string CreateLedOnOffControlCmd(LedOnOffStatus lightStatus, params KeyValuePair<UInt16, UInt16>[] rackAddress_LEDAddress_Pairs)
        {
            string cmd = CommandCenter.CreateLedOnOffControlCmd(lightStatus, rackAddress_LEDAddress_Pairs);
            return cmd;
        }

        /// <summary>
        /// 創建關閉貨架儲位指示燈指令
        /// </summary>
        /// <param name="rackAddress_LEDAddress_Pairs"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOffLed(params KeyValuePair<UInt16, UInt16>[] rackAddress_LEDAddress_Pairs)
        {
            string cmd = CreateLedOnOffControlCmd(LedOnOffStatus.Off, rackAddress_LEDAddress_Pairs);
            return cmd;
        }

        /// <summary>
        /// 創建打開貨架儲位綠色指示燈指令
        /// </summary>
        /// <param name="rackAddress_LEDAddress_Pairs"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOnGreenLed(params KeyValuePair<UInt16, UInt16>[] rackAddress_LEDAddress_Pairs)
        {
            string cmd = CreateLedOnOffControlCmd(LedOnOffStatus.GreenOn, rackAddress_LEDAddress_Pairs);
            return cmd;
        }

        /// <summary>
        /// 創建打開貨架儲位紅色指示燈指令
        /// </summary>
        /// <param name="rackAddress_LEDAddress_Pairs"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOnRedLed(params KeyValuePair<UInt16, UInt16>[] rackAddress_LEDAddress_Pairs)
        {
            string cmd = CreateLedOnOffControlCmd(LedOnOffStatus.RedOn, rackAddress_LEDAddress_Pairs);
            return cmd;
        }


        #endregion

        #region 多灯闪控制指令

        /// <summary>
        /// 創建多灯闪控制指令
        /// </summary>
        /// <param name="flashStatus"></param>
        /// <param name="lightsOnTime"></param>
        /// <param name="lightsOffTime"></param>
        /// <param name="flashCount"></param>
        /// <param name="rackNo_lightNo_Pairs"></param>
        /// <returns></returns>
        public static string CreateLightsFlashControlCmd(LedFlashStatus flashStatus, UInt16 lightsOnTime, UInt16 lightsOffTime, UInt16 flashCount, params KeyValuePair<UInt16, UInt16>[] rackNo_lightNo_Pairs)
        {
            string cmd = CommandCenter.CreateLedFlashControlCmd(flashStatus, lightsOnTime, lightsOffTime, flashCount, rackNo_lightNo_Pairs);
            return cmd;
        }

        /// <summary>
        ///  創建貨架儲位綠色指示燈閃爍指令
        /// </summary>
        /// <param name="lightsOnTime"></param>
        /// <param name="lightsOffTime"></param>
        /// <param name="flashCount"></param>
        /// <param name="rackNo_lightNo_Pairs"></param>
        /// <returns></returns>
        public static string CreateCmd_FlashGreenLed(UInt16 lightsOnTime, UInt16 lightsOffTime, UInt16 flashCount, params KeyValuePair<UInt16, UInt16>[] rackNo_lightNo_Pairs)
        {
            string cmd = CreateLightsFlashControlCmd(LedFlashStatus.Green_Flash, lightsOnTime, lightsOffTime, flashCount, rackNo_lightNo_Pairs);
            return cmd;
        }

        /// <summary>
        /// 創建貨架儲位紅色指示燈閃爍指令
        /// </summary>
        /// <param name="lightsOnTime"></param>
        /// <param name="lightsOffTime"></param>
        /// <param name="flashCount"></param>
        /// <param name="rackNo_lightNo_Pairs"></param>
        /// <returns></returns>
        public static string CreateCmd_FlashRedLed(UInt16 lightsOnTime, UInt16 lightsOffTime, UInt16 flashCount, params KeyValuePair<UInt16, UInt16>[] rackNo_lightNo_Pairs)
        {
            string cmd = CreateLightsFlashControlCmd(LedFlashStatus.Red_Flash, lightsOnTime, lightsOffTime, flashCount, rackNo_lightNo_Pairs);
            return cmd;
        }

        #endregion
    }
}
