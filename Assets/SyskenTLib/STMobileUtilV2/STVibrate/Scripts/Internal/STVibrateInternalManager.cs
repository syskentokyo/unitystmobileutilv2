using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.STVibrate.Internal
{
    public class STVibrateInternalManager
    {
        
        private STVibrateInternaliOSManager _stVibrateInternaliOSManager = new STVibrateInternaliOSManager();
        private STVibrateInternalAndroidManager _stVibrateInternalAndroidManager = new STVibrateInternalAndroidManager();

        public void Play(VibrateType vibrateType)
        {
#if UNITY_EDITOR
            Debug.Log("UnityEditor:Play Vibrate: "+ vibrateType);
#elif UNITY_IOS
            PrepareVibrateiOSInternal(vibrateType);
            PlayVibrateiOSInternal(vibrateType);
            
            #elif  UNITY_ANDROID
            PlayVibrateAndroidInternal(vibrateType);
#endif
        }

        public void PrepareVibrate(VibrateType vibrateType)
        {
#if UNITY_EDITOR
            Debug.Log("UnityEditor:PrepareVibrate Vibrate: "+ vibrateType);
#elif UNITY_IOS
            PrepareVibrateiOSInternal(vibrateType);
#elif  UNITY_ANDROID
            Debug.Log("No Prepare On Android");
#endif
        }

        public void PlayVibrate(VibrateType vibrateType)
        {
#if UNITY_EDITOR
            Debug.Log("UnityEditor:PlayVibrate Vibrate: "+ vibrateType);
#elif UNITY_IOS
            PlayVibrateiOSInternal(vibrateType);
#elif  UNITY_ANDROID
            PlayVibrateAndroidInternal(vibrateType);
#endif
        }

        #region 内部

        #region iOS
        

        private void PrepareVibrateiOSInternal(VibrateType vibrateType)
        {
            switch (vibrateType)
            {
                case VibrateType.UI_HEAVY:
                    _stVibrateInternaliOSManager.PrepareVibrate(0, 0);
                    break;
                case VibrateType.UI_LIGHT:
                    _stVibrateInternaliOSManager.PrepareVibrate(0, 1);
                    break;
                case VibrateType.UI_MEDIUM:
                    _stVibrateInternaliOSManager.PrepareVibrate(0, 2);
                    break;
                case VibrateType.UI_RIDID:
                    _stVibrateInternaliOSManager.PrepareVibrate(0, 3);
                    break;
                case VibrateType.UI_SOFT:
                    _stVibrateInternaliOSManager.PrepareVibrate(0, 4);
                    break;
                case VibrateType.UI_SELECT:
                    _stVibrateInternaliOSManager.PrepareVibrate(1, 0);
                    break;
                case VibrateType.NOTICE_SUCCESS:
                    _stVibrateInternaliOSManager.PrepareVibrate(2, 0);
                    break;
                case VibrateType.NOTICE_ERROR:
                    _stVibrateInternaliOSManager.PrepareVibrate(2, 1);
                    break;
                case VibrateType.NOTICE_WARING:
                    _stVibrateInternaliOSManager.PrepareVibrate(2, 2);
                    break;
               
                default:
                    break;
            }
        }

        private void PlayVibrateiOSInternal(VibrateType vibrateType)
        {
            switch (vibrateType)
            {
                case VibrateType.UI_HEAVY:
                    _stVibrateInternaliOSManager.PlayVibrate(0, 0,100);
                    break;
                case VibrateType.UI_LIGHT:
                    _stVibrateInternaliOSManager.PlayVibrate(0, 1,100);
                    break;
                case VibrateType.UI_MEDIUM:
                    _stVibrateInternaliOSManager.PlayVibrate(0, 2,100);
                    break;
                case VibrateType.UI_RIDID:
                    _stVibrateInternaliOSManager.PlayVibrate(0, 3,100);
                    break;
                case VibrateType.UI_SOFT:
                    _stVibrateInternaliOSManager.PlayVibrate(0, 4,100);
                    break;
                case VibrateType.UI_SELECT:
                    _stVibrateInternaliOSManager.PlayVibrate(1, 0,100);
                    break;
                case VibrateType.NOTICE_SUCCESS:
                    _stVibrateInternaliOSManager.PlayVibrate(2, 0,100);
                    break;
                case VibrateType.NOTICE_ERROR:
                    _stVibrateInternaliOSManager.PlayVibrate(2, 1,100);
                    break;
                case VibrateType.NOTICE_WARING:
                    _stVibrateInternaliOSManager.PlayVibrate(2, 2,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3, 0,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,1,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_3:
                    _stVibrateInternaliOSManager.PlayVibrate(3,8,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_4:
                    _stVibrateInternaliOSManager.PlayVibrate(3,12,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_NORMAL_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3,13,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_NORMAL_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,14,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_STRONG_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3,15,100);
                    break;
                case VibrateType.CUSTOM_HEARTBEAT_STRONG_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,16,100);
                    break;
                case VibrateType.CUSTOM_GRADUALLY_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3,2,100);
                    break;
                case VibrateType.CUSTOM_GRADUALLY_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,3,100);
                    break;
                case VibrateType.CUSTOM_KONKON_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3,4,100);
                    break;
                case VibrateType.CUSTOM_KONKON_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,5,100);
                    break;
                case VibrateType.CUSTOM_ERROR_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3,6,100);
                    break;
                case VibrateType.CUSTOM_ERROR_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,7,100);
                    break;
                case VibrateType.CUSTOM_ERROR_3:
                    _stVibrateInternaliOSManager.PlayVibrate(3,9,100);
                    break;
                case VibrateType.CUSTOM_ERROR_4:
                    _stVibrateInternaliOSManager.PlayVibrate(3,10,100);
                    break;
                case VibrateType.CUSTOM_ERROR_5:
                    _stVibrateInternaliOSManager.PlayVibrate(3,11,100);
                    break;
                case VibrateType.CUSTOM_WATER_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3,17,100);
                    break;
                case VibrateType.CUSTOM_WATER_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,18,100);
                    break;
                case VibrateType.CUSTOM_WATER_3:
                    _stVibrateInternaliOSManager.PlayVibrate(3,19,100);
                    break;
                case VibrateType.CUSTOM_WATER_4:
                    _stVibrateInternaliOSManager.PlayVibrate(3,20,100);
                    break;
                case VibrateType.CUSTOM_WATER_5:
                    _stVibrateInternaliOSManager.PlayVibrate(3,21,100);
                    break;
                case VibrateType.CUSTOM_OTHER_1:
                    _stVibrateInternaliOSManager.PlayVibrate(3,22,100);
                    break;
                case VibrateType.CUSTOM_OTHER_2:
                    _stVibrateInternaliOSManager.PlayVibrate(3,23,100);
                    break;
                case VibrateType.CUSTOM_OTHER_3:
                    _stVibrateInternaliOSManager.PlayVibrate(3,24,100);
                    break;
                case VibrateType.CUSTOM_OTHER_4:
                    _stVibrateInternaliOSManager.PlayVibrate(3,25,100);
                    break;
                default:
                    break;
            }
        }


        #region Android
        private void PlayVibrateAndroidInternal(VibrateType vibrateType)
        {
            _stVibrateInternalAndroidManager.PlayVibrate(vibrateType);
            
        }

        #endregion

        #endregion
        
        #endregion
    }
}