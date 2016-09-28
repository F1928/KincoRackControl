using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KincoLightManager
{
    /// <summary>
    /// 擴展中心
    /// Create By  : Enzhi.Zhou
    /// Create Date: 2016/09/27
    /// </summary>
    public static class ExtensionUtil
    {
        public static byte[] HexStringToByteArray(this string s)
        {
            s = s.Replace("   ", " ");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="howManyBytes">字節數，默認為2個字節</param>
        /// <returns></returns>
        public static string ByteArrayToHexString(this byte[] byteArray, int howManyBytes=2)
        {
            string result = string.Empty;
            string tmp = string.Empty;
            foreach (byte x in byteArray)
            {
                tmp = Convert.ToString(x, 16).PadLeft(howManyBytes, '0');
                result += tmp;
            }
            return result;
        }

        public static string GetKincoCRC(this string cmd, bool isHightBefore=true)
        {
            byte[] cmdByteArray = cmd.HexStringToByteArray();
            byte[] crcByteArray = CRC.GetCRC16(cmdByteArray, isHightBefore);
            string crcHexString = crcByteArray.ByteArrayToHexString();
            return crcHexString;
        }

       
        /// <summary>
        /// 轉換成16進制字符串
        /// </summary>
        /// <param name="myUInt16"></param>
        /// <param name="howManyBytes">字節數，默認為2個字節,表示返回的16進制需要多少個字節的長度</param>
        /// <returns></returns>
        public static string ToHexString(this UInt16 myUInt16, int howManyBytes =2 )
        {
            return Convert.ToString(myUInt16, 16).PadLeft(howManyBytes, '0');
        }


        public static string ToHexString(this LedFlashStatus status)
        {
            UInt16 iStatus = (UInt16)status;
            return iStatus.ToHexString();
        }

        public static string ToHexString(this LedOnOffStatus status)
        {
            UInt16 iStatus = (UInt16)status;
            return iStatus.ToHexString();
        }

        public static string ToHexString(this RackTowerLedStatus status)
        {
            UInt16 iStatus = (UInt16)status;
            return iStatus.ToHexString();
        }

        public static string FormatWith(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

    }
}
