using System;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.OSAlertView.Internal
{
    public class SyskenTlibOSAlertViewiOSListner:MonoBehaviour
    {
        public Action<AlertButtonType> _onTouchedButtonAction;
        
        /// <summary>
        /// OSネイティブのアラートのボタン押したときの通知先
        /// </summary>
        /// <param name="message"></param>
        private void OnTouchedOSAlertViewButton(string message)
        {
            if (message == "OK")
            {
                _onTouchedButtonAction?.Invoke(AlertButtonType.OK);
            }else if (message == "Cancel")
            {
                _onTouchedButtonAction?.Invoke(AlertButtonType.Cancel);
            }
        }
    }
}