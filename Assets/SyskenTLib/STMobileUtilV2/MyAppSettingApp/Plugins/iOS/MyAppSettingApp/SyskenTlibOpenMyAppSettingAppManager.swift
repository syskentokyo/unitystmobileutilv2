import Foundation

class SyskenTlibOpenMyAppSettingAppManager{


    public func openMyAppSettingApp(){
        let url = URL(string: UIApplication.openSettingsURLString)
        
        if UIApplication.shared.canOpenURL(url!) {
            UIApplication.shared.open(url!, options: [:], completionHandler: nil)
        }
    }


}
