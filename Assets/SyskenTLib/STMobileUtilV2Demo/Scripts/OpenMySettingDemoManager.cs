using SyskenTLib.STMobileUtilV2.MyAppSettingApp;

using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.Demo
{
    public class OpenMySettingDemoManager : MonoBehaviour
    {
        public void OnTouchedStartButton()
        {
            OpenMySettingAppManager openMySettingAppManager = new OpenMySettingAppManager();
            openMySettingAppManager.OpenMySettingApp();;
        }
    }
}