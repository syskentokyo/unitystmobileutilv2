 #import <UnityFramework/UnityFramework-Swift.h>

 #ifdef __cplusplus
 extern "C" {
 #endif
    void STMobileUtilV2_CameraLight_TurnDeviceLightOn() {
        [SyskenTLibLightManagerBridge TurnOn];
    }
     void STMobileUtilV2_CameraLight_TurnDeviceLightOff() {
         [SyskenTLibLightManagerBridge TurnOff];
     }
     
 #ifdef __cplusplus
 }
 #endif
