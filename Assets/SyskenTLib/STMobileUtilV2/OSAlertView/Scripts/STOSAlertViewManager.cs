using System;
using SyskenTLib.STMobileUtilV2.OSAlertView.Internal;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.OSAlertView
{
    public class STOSAlertViewManager:MonoBehaviour
    {
        public Action<AlertButtonType> _onTouchedButtonAction;
        
        [SerializeField]
        private STOSAlertViewInternalManager _stosAlertViewInternalManager;
        
        public void ShowAlert(String title,String subTitle,String okButtonName,String cancelButtonName)
        {
            _stosAlertViewInternalManager._onTouchedButtonAction -= OnTouchedButton;
            _stosAlertViewInternalManager._onTouchedButtonAction += OnTouchedButton;
            
            _stosAlertViewInternalManager.ShowAlert(title, subTitle, okButtonName, cancelButtonName);
        }
        
        
        private void OnTouchedButton(AlertButtonType buttonType)
        {
            _onTouchedButtonAction?.Invoke(buttonType);
        }
    }
}