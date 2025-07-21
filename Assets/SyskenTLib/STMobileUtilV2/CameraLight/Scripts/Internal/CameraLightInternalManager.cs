using System.Runtime.InteropServices;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.CameraLight.Internal
{
    internal class CameraLightInternalManager
    {
#if UNITY_IOS
        [DllImport("__Internal")]
        private static extern void STMobileUtilV2_CameraLight_TurnDeviceLightOn();
        
        [DllImport("__Internal")]
        private static extern void STMobileUtilV2_CameraLight_TurnDeviceLightOff();
#endif


        public void TurnLight(bool isOn)
        {
            if (isOn)
            {

#if UNITY_EDITOR
                
#elif UNITY_IOS
                STMobileUtilV2_CameraLight_TurnDeviceLightOn();

#elif UNITY_ANDROID
                TurnOnOnAndroid();

#endif
            }
            else
            {
#if UNITY_EDITOR

#elif UNITY_IOS
                STMobileUtilV2_CameraLight_TurnDeviceLightOff();
#elif UNITY_ANDROID
                TurnOffOnAndroid();

#endif
            }
        }

        private void TurnOnOnAndroid()
        {
            #if UNITY_ANDROID
            using(var cameraManager = UnityEngine.Android.AndroidApplication.currentContext.Call<AndroidJavaObject>(
                "getSystemService",
                "camera"
            ))
            {
                cameraManager.Call("setTorchMode","0",true);

            }
            #endif
        }
        
        private void TurnOffOnAndroid()
        {
#if UNITY_ANDROID
            using(var cameraManager = UnityEngine.Android.AndroidApplication.currentContext.Call<AndroidJavaObject>(
                      "getSystemService",
                      "camera"
                  ))
            {
                cameraManager.Call("setTorchMode","0",false);

            }
#endif
        }
    }
}