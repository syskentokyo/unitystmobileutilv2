
// using SyskenTLib.UtilForiOS.CameraLight;

using SyskenTLib.STMobileUtilV2.CameraLight;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.Demo
{
    public class CameraLightDemoManager : MonoBehaviour
    {



        public void TurnLightOn()
        {
            CameraLightManager cameraLightManager = new CameraLightManager();
            cameraLightManager.TurnLight(true);
        }
        
        public void TurnLightOff()
        {
            CameraLightManager cameraLightManager = new CameraLightManager();
            cameraLightManager.TurnLight(false);
        }
    }
}
