using SyskenTLib.STMobileUtilV2.MyAppSettingApp.Internal;

namespace SyskenTLib.STMobileUtilV2.MyAppSettingApp
{
    public class OpenMySettingAppManager
    {
        private OSNativeOpenMyAppSettingAppBridge _osNativeOpenMySettingAppBridge = new OSNativeOpenMyAppSettingAppBridge();
        
        /// <summary>
        /// アプリの設定を開く
        /// </summary>
        public void OpenMySettingApp()
        {
            _osNativeOpenMySettingAppBridge.OpenSettingApp();;
        }
    }
}