import Foundation
import UIKit;


@objc public class SyskenTLibLightManagerBridge : NSObject {
    
    @objc public static func TurnOn() {
        let lightManager = SyskenTLibLightManager()
        lightManager.turnLight(isOn:true)
    }
    
    
    @objc public static func TurnOff() {
        let lightManager = SyskenTLibLightManager()
        lightManager.turnLight(isOn:false)
    }
}
