import Foundation


 let  settingManager = SyskenTlibOpenMyAppSettingAppManager()

@_cdecl("SyskenTlibOpenMyAppSettingAppOpenMySettingApp")
public  func openMyAppSettingApp(){
    settingManager.openMyAppSettingApp()
}