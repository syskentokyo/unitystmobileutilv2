using System.Runtime.InteropServices;
using System.Diagnostics;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.MyAppSettingApp.Internal
{
    internal class OSNativeOpenMyAppSettingAppBridge
    {
       
#if UNITY_IOS
        [DllImport("__Internal", EntryPoint = "SyskenTlibOpenMyAppSettingAppOpenMySettingApp")]
        private static extern bool SyskenTlibOpenMyAppSettingApp();
        
#endif

        public void OpenSettingApp()
        {
                #if UNITY_EDITOR
                    
            UnityEngine.Debug.Log("OpenSettingApp");
                
#elif UNITY_IOS
            SyskenTlibOpenMySettingApp();

#elif UNITY_ANDROID
                OpenSettingAppOnAndroid();
#endif
        }


        private void OpenSettingAppOnAndroid()
        {
#if UNITY_ANDROID
            try
            {
                using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
                {
                    using (var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                    {
                        var packageName = currentActivity.Call<string>("getPackageName");

                        using (var uriClass = new AndroidJavaClass("android.net.Uri"))
                        {
                            using (var uriObject =
                                   uriClass.CallStatic<AndroidJavaObject>("fromParts", "package", packageName, null))
                            {

                                using (var intent = new AndroidJavaObject("android.content.Intent",
                                           "android.settings.APPLICATION_DETAILS_SETTINGS",uriObject))
                                {
                                    currentActivity.Call("startActivity", intent);
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                UnityEngine.Debug.LogError("Failed to open settings: " + e.Message);
            }
#endif
            
            
        }
        
    }
}