using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.OSAlertView.Internal
{
    public class STOSAlertViewInternalManager:MonoBehaviour
    {
        
        [SerializeField] private SyskenTlibOSAlertViewiOSListner iosLister;
        public Action<AlertButtonType> _onTouchedButtonAction;
        
        
       private SyskenTlibOSAlertViewAndroidListner _androidListner;
        
        
#if UNITY_IOS
        [DllImport("__Internal", EntryPoint = "SyskenTlibOSAlertViewManagerShowAlert")]
        private static extern void SyskenTlibOSAlertViewManagerShowAlert(String title,String subTitle,String okButtonName,String cancelButtonName);
#endif

        public void ShowAlert(String title,String subTitle,String okButtonName,String cancelButtonName)
        {
            
#if UNITY_IOS
            
            iosLister._onTouchedButtonAction -= OnTouchedButton;
            iosLister._onTouchedButtonAction += OnTouchedButton;

            SyskenTlibOSAlertViewManagerShowAlert(title, subTitle,okButtonName,cancelButtonName);
#elif UNITY_ANDROID
            ShowAlertOnAndroid(title, subTitle, okButtonName, cancelButtonName);
#endif
        }


        private void ShowAlertOnAndroid(String title, String subTitle, String okButtonName, String cancelButtonName)
        {
            _androidListner = new SyskenTlibOSAlertViewAndroidListner(this);

            _androidListner._onTouchedButtonAction -= OnTouchedButton;
            _androidListner._onTouchedButtonAction += OnTouchedButton;
            
            var activity = UnityEngine.Android.AndroidApplication.currentActivity;

            
            activity.Call ("runOnUiThread", new AndroidJavaRunnable (() => {
                AndroidJavaObject alertDialogBuilder = new AndroidJavaObject ("android.app.AlertDialog$Builder", activity);
                alertDialogBuilder.Call<AndroidJavaObject> ("setTitle", title);
                alertDialogBuilder.Call<AndroidJavaObject> ("setMessage", subTitle);
                alertDialogBuilder.Call<AndroidJavaObject> ("setCancelable", true);

                if (string.IsNullOrEmpty(okButtonName) == false)
                {
                    alertDialogBuilder.Call<AndroidJavaObject>("setPositiveButton", okButtonName,
                        _androidListner);
                }
                
                if (string.IsNullOrEmpty(cancelButtonName) == false)
                {
                    alertDialogBuilder.Call<AndroidJavaObject>("setNegativeButton", cancelButtonName,
                        _androidListner);
                }

                AndroidJavaObject dialog = alertDialogBuilder.Call<AndroidJavaObject> ("create");
                dialog.Call ("show");
            }));
            
        }

        private void OnTouchedButton(AlertButtonType buttonType)
        {
            _onTouchedButtonAction?.Invoke(buttonType);
        }
        
        
    }
}