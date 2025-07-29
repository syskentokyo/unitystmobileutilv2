using System;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.STVibrate.Internal
{
    public class STVibrateInternalAndroidManager
    {
        public void PlayVibrate(VibrateType vibrateType)
        {
            
            using(var androidVibrateManager = UnityEngine.Android.AndroidApplication.currentContext.Call<AndroidJavaObject>(
                      "getSystemService",
                      "vibrator"
                  ))
            {

                long[] timeArray = new long[]{};
                
                
                var vibrationJavaObject = new AndroidJavaClass("android.os.VibrationEffect");
                
                
                switch (vibrateType)
                {
                    case VibrateType.UI_HEAVY:
                        timeArray = new long[2]{0,200};
                        //再生
                        androidVibrateManager.Call("vibrate",timeArray,-1);
                        break;
                    case VibrateType.UI_LIGHT:
                        timeArray = new long[2]{0,150};
                        //再生
                        androidVibrateManager.Call("vibrate",timeArray,-1);
                        
                        break;
                    case VibrateType.UI_MEDIUM:
                        timeArray = new long[2]{0,100};
                        //再生
                        androidVibrateManager.Call("vibrate",timeArray,-1);
                        break;
                    case VibrateType.UI_RIDID:
                        timeArray = new long[2]{0,50};
                        //再生
                        androidVibrateManager.Call("vibrate",timeArray,-1);
                        break;
                    case VibrateType.UI_SOFT:
                        timeArray = new long[2]{0,20};
                        //再生
                        androidVibrateManager.Call("vibrate",timeArray,-1);
                        break;
                    case VibrateType.UI_SELECT:
                    {
                        long time = 50;
                        int aplitude = 128;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.NOTICE_SUCCESS:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.NOTICE_ERROR:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.NOTICE_WARING:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_1:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_2:
                    {
                        long time = 50;
                        int aplitude = 40;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_3:
                    {
                        long time = 50;
                        int aplitude = 20;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_4:
                    {
                        long time = 50;
                        int aplitude = 10;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_NORMAL_1:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_NORMAL_2:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_STRONG_1:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_HEARTBEAT_STRONG_2:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_GRADUALLY_1:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_GRADUALLY_2:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_KONKON_1:
                        
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_KONKON_2:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_1:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_2:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_3:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_4:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_ERROR_5:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_WATER_1:
                        
                    {
                        long time = 50;
                        int aplitude = 30;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_WATER_2:
                    {
                        long time = 50;
                        int aplitude = 50;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_WATER_3:
                    {
                        long time = 50;
                        int aplitude = 55;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_WATER_4:
                    {
                        long time = 50;
                        int aplitude = 60;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_WATER_5:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_1:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_2:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_3:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    case VibrateType.CUSTOM_OTHER_4:
                    {
                        long time = 50;
                        int aplitude = 64;
                        var effect = vibrationJavaObject.CallStatic<AndroidJavaObject>("createOneShot", time, aplitude);
                        androidVibrateManager.Call("vibrate",effect);
                        
                    }
                        
                        break;
                    default:
                        break;
                }
                

    

            }
        }
    }
}