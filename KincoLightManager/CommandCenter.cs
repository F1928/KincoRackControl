using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace KincoLightManager
{
    public static class CommandCenter
    {
        public static void Broadcast(string cmd)
        {
            byte[] sendBytes = cmd.HexStringToByteArray();
            Socket newSockt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newSockt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);

            // 货架控制器IP
            IPEndPoint remoteIpep = new IPEndPoint(IPAddress.Broadcast, 9000);

            newSockt.SendTo(sendBytes, sendBytes.Length, SocketFlags.None, remoteIpep);

            newSockt.Close();
        }

        /// <summary>
        /// 創建多貨架控制命令
        /// </summary>
        /// <param name="rackStatus"></param>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateRackControlCmd(RackTowerLedStatus rackStatus, params UInt16[] racks)
        {
            if (racks == null || racks.Length <= 0) return string.Empty;

            string rackStatusHex = rackStatus.ToHexString();

            StringBuilder racksHex = new StringBuilder();
            foreach (UInt16 rackNO in racks)
            {
                racksHex.Append(rackNO.ToHexString(4));
            }
            UInt16 rackCount = (UInt16)racks.Length;
            string rackCountHex = rackCount.ToHexString(4);

            string tmpCmd = CmdTemplate.RackAndTowerControl.FormatWith(rackStatusHex, rackCountHex, racksHex);

            string crc = tmpCmd.GetKincoCRC();

            return string.Format("{0}{1}", tmpCmd, crc);

        }

        /// <summary>
        /// 多灯亮灭控制命令
        /// </summary>
        /// <param name="lightStatus">燈的狀態</param>
        /// <param name="rackNo_lightNo_Pairs">貨架與料位組合地址碼</param>
        /// <returns></returns>
        public static string CreateLedOnOffControlCmd(LedOnOffStatus lightStatus, params KeyValuePair<UInt16, UInt16>[] rackNo_lightNo_Pairs)
        {
            if (rackNo_lightNo_Pairs == null || rackNo_lightNo_Pairs.Length <= 0) return string.Empty;

            string lightStatusHex = lightStatus.ToHexString();

            StringBuilder rackLightHex = new StringBuilder();
            foreach (KeyValuePair<UInt16, UInt16> rackLightNo in rackNo_lightNo_Pairs)
            {
                rackLightHex.Append("{0}{1}".FormatWith(rackLightNo.Key.ToHexString(4), rackLightNo.Value.ToHexString(4)));
            }

            UInt16 lightsCount = (UInt16)rackNo_lightNo_Pairs.Length;
            string lightsCountHex = lightsCount.ToHexString(4);

            string tmpCmd = CmdTemplate.LedOnOffControl.FormatWith(lightStatusHex, lightsCountHex, rackLightHex);

            string crc = tmpCmd.GetKincoCRC();

            return string.Format("{0}{1}", tmpCmd, crc);

        }

        /// <summary>
        ///  創建多灯闪控制命令
        /// </summary>
        /// <param name="flashStatus">燈的狀態</param>
        /// <param name="lightsOnTime">亮燈的持續時間(毫秒)</param>
        /// <param name="lightsOffTime">滅燈的持續時間(毫秒)</param>
        /// <param name="flashCount">持續閃爍次數</param>
        /// <param name="rackNo_lightNo_Pairs">貨架與料位組合地址碼</param>
        /// <returns></returns>
        public static string CreateLedFlashControlCmd(LedFlashStatus flashStatus, UInt16 lightsOnTime, UInt16 lightsOffTime, UInt16 flashCount, params KeyValuePair<UInt16, UInt16>[] rackNo_lightNo_Pairs)
        {
            if (rackNo_lightNo_Pairs == null || rackNo_lightNo_Pairs.Length <= 0) return string.Empty;
            string flashStatusHex = flashStatus.ToHexString();

            string lightsOnTimeHex = lightsOnTime.ToHexString(4);

            string lightsOffTimeHex = lightsOffTime.ToHexString(4);

            string flashCountHex = flashCount.ToHexString(4);

            StringBuilder rackLightHex = new StringBuilder();
            foreach (KeyValuePair<UInt16, UInt16> rackLightNo in rackNo_lightNo_Pairs)
            {
                rackLightHex.Append("{0}{1}".FormatWith(rackLightNo.Key.ToHexString(4), rackLightNo.Value.ToHexString(4)));
            }

            UInt16 lightsCount = (UInt16)rackNo_lightNo_Pairs.Length;
            string lightsCountHex = lightsCount.ToHexString(4);

            string tmpCmd = CmdTemplate.LedFlashControl.FormatWith(flashStatusHex, lightsCountHex, rackLightHex, lightsOnTimeHex, lightsOffTimeHex, flashCountHex);

            string crc = tmpCmd.GetKincoCRC();

            return string.Format("{0}{1}", tmpCmd, crc);

        }

        #region 多货架控制命令


        /// <summary>
        /// 創建货架所有灯灭，五色灯单色灯灭指令
        /// </summary>
        /// <param name="racks"></param>
        /// <returns></returns>
        public static string CreateCmd_TurnOffRackLedAndTowerWhiteLed(params UInt16[] racks)
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
