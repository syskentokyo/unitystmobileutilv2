using System;
using SyskenTLib.STMobileUtilV2.STVibrate.Internal;
using UnityEngine;


namespace SyskenTLib.STMobileUtilV2.STVibrate{

    public enum VibrateType
    {
        UI_HEAVY=0
        ,UI_LIGHT=1
        ,UI_MEDIUM=2
        ,UI_RIDID=3
        ,UI_SOFT=4
        ,UI_SELECT=5
        
        ,NOTICE_SUCCESS=100
        ,NOTICE_ERROR=101
        ,NOTICE_WARING=102
        
        
        ,CUSTOM_HEARTBEAT_1=300//0
        ,CUSTOM_HEARTBEAT_2=301//1
        ,CUSTOM_HEARTBEAT_3=302//8
        ,CUSTOM_HEARTBEAT_4=303//12
        ,CUSTOM_HEARTBEAT_NORMAL_1=304//13
        ,CUSTOM_HEARTBEAT_NORMAL_2=305//14
        ,CUSTOM_HEARTBEAT_STRONG_1=306//15
        ,CUSTOM_HEARTBEAT_STRONG_2=307//16
        ,CUSTOM_GRADUALLY_1=308//2
        ,CUSTOM_GRADUALLY_2=309//3
        ,CUSTOM_KONKON_1=310//4
        ,CUSTOM_KONKON_2=311//5
        ,CUSTOM_ERROR_1=312//6
        ,CUSTOM_ERROR_2=313//7
        ,CUSTOM_ERROR_3=314//9
        ,CUSTOM_ERROR_4=315//10
        ,CUSTOM_ERROR_5=316//11
        ,CUSTOM_WATER_1=317//17
        ,CUSTOM_WATER_2=318//18
        ,CUSTOM_WATER_3=319//19
        ,CUSTOM_WATER_4=320//20
        ,CUSTOM_WATER_5=321//21
        
        ,CUSTOM_OTHER_1=322
        ,CUSTOM_OTHER_2=323
        ,CUSTOM_OTHER_3=324
        ,CUSTOM_OTHER_4=325

        
    }
    
    public class STVibrateManager
    {
        
        private STVibrateInternalManager _stVibrateInternalManager = new STVibrateInternalManager();
        
        public void Play(VibrateType vibrateType)
        {
            _stVibrateInternalManager.Play(vibrateType);
        }

        public void PrepareVibrate(VibrateType vibrateType)
        {
            _stVibrateInternalManager.PrepareVibrate(vibrateType);
        }

        public void PlayVibrate(VibrateType vibrateType)
        {
            _stVibrateInternalManager.PlayVibrate(vibrateType);
        }
    }
}