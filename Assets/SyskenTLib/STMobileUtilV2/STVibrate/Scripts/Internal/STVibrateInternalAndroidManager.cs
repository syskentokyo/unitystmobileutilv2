using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.STVibrate.Internal
{
    public class STVibrateInternalAndroidManager
    {
        public void PlayVibrate(VibrateType vibrateType)
        {
            using(var androidVibrateManager = UnityEngine.Android.AndroidApplication.currentContext.Call<AndroidJavaObject>(
                      "getSystemService",
                      "vibrate"
                  ))
            {
                androidVibrateManager.Call("vibrate","200",false);
                
                switch (vibrateType)
                {
                    case VibrateType.UI_HEAVY:
                        
                        break;
                    case VibrateType.UI_LIGHT:
                        
                        break;
                    case VibrateType.UI_MEDIUM:
                       
                        break;
                    case VibrateType.UI_RIDID:
                        
                        break;
                    case VibrateType.UI_SOFT:
                        
                        break;
                    case VibrateType.UI_SELECT:
                        
                        break;
                    case VibrateType.NOTICE_SUCCESS:
                        
                        break;
                    case VibrateType.NOTICE_ERROR:
                        
                        break;
                    case VibrateType.NOTICE_WARING:
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_1:
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_2:
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_3:
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_4:
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_NORMAL_1:
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_NORMAL_2:
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_STRONG_1:
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_STRONG_2:
                        
                        break;
                    case VibrateType.CUSTOM_GRADUALLY_1:
                        
                        break;
                    case VibrateType.CUSTOM_GRADUALLY_2:
                        
                        break;
                    case VibrateType.CUSTOM_KONKON_1:
                        
                        break;
                    case VibrateType.CUSTOM_KONKON_2:
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_1:
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_2:
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_3:
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_4:
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_5:
                        
                        break;
                    case VibrateType.CUSTOM_WATER_1:
                        
                        break;
                    case VibrateType.CUSTOM_WATER_2:
                        
                        break;
                    case VibrateType.CUSTOM_WATER_3:
                        
                        break;
                    case VibrateType.CUSTOM_WATER_4:
                        
                        break;
                    case VibrateType.CUSTOM_WATER_5:
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_1:
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_2:
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_3:
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_4:
                        
                        break;
                    default:
                        break;
                }
                
                         

            }
        }
    }
}