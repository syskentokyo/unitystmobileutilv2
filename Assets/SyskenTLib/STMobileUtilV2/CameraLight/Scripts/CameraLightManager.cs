using SyskenTLib.STMobileUtilV2.CameraLight.Internal;

namespace SyskenTLib.STMobileUtilV2.CameraLight
{
    public class CameraLightManager
    {
        private CameraLightInternalManager _cameraLightInternalManager = new CameraLightInternalManager();
        
        public void TurnLight(bool isOn)
        {
            _cameraLightInternalManager.TurnLight(isOn);
        }
    }
}