using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReelShelfControl;
using System.Collections;

namespace SMTNLightManager
{
    public class CommandCenter
    {
        /// <summary>
        /// 單燈控制
        /// </summary>
        /// <param name="rackNo">貨架储位號(庫位硬體編碼)</param>
        /// <param name="ledAction">行為(滅燈, 亮燈, 閃爍)</param>
        /// <param name="turnOnTime">亮灯时间(只有当Action为闪烁时有效)</param>
        /// <param name="turnOffTime">灭灯时间(只有当Action为闪烁时有效)</param>
        /// <param name="cycle">闪烁次数(只有当Action为闪烁时有效)</param>
        public static bool ControlSingleLighting(string locatorNo, LedAction ledAction, int turnOnTime, int turnOffTime, int cycle)
        {
            bool result =LedControlProxy.ReelShelfControlService.SingleLightingControl(locatorNo, (int)ledAction, turnOnTime, turnOffTime, cycle);
            System.Threading.Thread.Sleep(100); //间隔100毫秒，以便命令执行完成
            return result;
        }

        /// <summary>
        /// 多灯控制
        /// </summary>
        /// <param name="ledAction">行為(滅燈, 亮燈, 閃爍)</param>
        /// <param name="turnOnTime">亮灯时间(只有当Action为闪烁时有效)</param>
        /// <param name="turnOffTime">灭灯时间(只有当Action为闪烁时有效)</param>
        /// <param name="cycle">闪烁次数(只有当Action为闪烁时有效)</param>
        /// <param name="locators">貨架储位號列表</param>
        public static bool ControlMultiLighting(LedAction ledAction, int turnOnTime, int turnOffTime, int cycle, params string[] locators)
        {
            bool result = false;
            ArrayList arrayList =new ArrayList();
            if (locators != null)
            {
                arrayList.AddRange(locators);
                result = LedControlProxy.ReelShelfControlService.MultiLightingControl(arrayList, (int)ledAction, turnOnTime, turnOffTime, cycle);
                System.Threading.Thread.Sleep(100); //间隔100毫秒，以便命令执行完成
            }
            return result;
        }

        /// <summary>
        /// 全亮
        /// </summary>
        /// <param name="locatorsOrLedBoards">储位列表或者主板号数组</param>
        public static bool TurnOnAll(string[] locatorsOrLedBoards)
        {
            bool result = false;
            if (locatorsOrLedBoards != null)
            {
                ArrayList arrayList = new ArrayList();
                List<string> boards = new List<string>();
                string boardNo = string.Empty;
                foreach (string s in locatorsOrLedBoards)
                {
                    if (s.Length > 3)
                    {
                        boardNo = s.Substring(0, 3);
                    }
                    else if (s.Length == 3)
                    {
                        boardNo = s;
                    }
                    else
                    {
                        boardNo = s.PadLeft(3, '0');
                    }
                    if (boards.Contains(boardNo)) continue;
                    boards.Add(boardNo);
                }
                arrayList.AddRange(boards);
                result = LedControlProxy.ReelShelfControlService.TurnOnAll(arrayList);
                System.Threading.Thread.Sleep(100); //间隔100毫秒，以便命令执行完成
            }
            return result;
        }

        /// <summary>
        /// 全灭
        /// </summary>
        /// <param name="locatorsOrLedBoards">储位列表或者主板号数组</param>
        public static bool TurnOffAll(string[] locatorsOrLedBoards)
        {
            bool result = false;
            if (locatorsOrLedBoards != null)
            {
                ArrayList arrayList = new ArrayList();
                List<string> boards = new List<string>();
                string boardNo = string.Empty;
                foreach (string s in locatorsOrLedBoards)
                {
                    if (s.Length > 3)
                    {
                        boardNo = s.Substring(0, 3);
                    }
                    else if (s.Length == 3)
                    {
                        boardNo = s;
                    }
                    else
                    {
                        boardNo = s.PadLeft(3, '0');
                    }
                    if (boards.Contains(boardNo)) continue;
                    boards.Add(boardNo);
                }
                arrayList.AddRange(boards);
                result = LedControlProxy.ReelShelfControlService.TurnOffAll(arrayList);
                System.Threading.Thread.Sleep(100); //间隔100毫秒，以便命令执行完成
            }
            return result;
        }


        /// <summary>
        /// 灯塔控制
        /// </summary>
        /// <param name="locatorOrBoardNo">储位或主板号</param>
        /// <param name="action">行为(亮或者灭，闪烁等效于亮)</param>
        /// <returns></returns>
        public static bool LightHouseControl(string locatorOrBoardNo, LedAction action)
        {
            bool result = false;
            int boardNo = 0;
            if (locatorOrBoardNo.Length > 3)
            {
                boardNo = int.Parse(locatorOrBoardNo.Substring(0, 3));
            }
            else
            {
                boardNo = int.Parse(locatorOrBoardNo);
            }

            int iAction = (int)action > 1 ? 1 : (int)action;

            result = LedControlProxy.ReelShelfControlService.LightHouseControl(boardNo, iAction);
            System.Threading.Thread.Sleep(100); //间隔100毫秒，以便命令执行完成
            return result;
  
        }

    }
}
