using System;
using System.Collections;
using System.Collections.Generic;
using SyskenTLib.STMobileUtilV2.OSAlertView;
using SyskenTLib.STMobileUtilV2.OSAlertView.Internal;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.Demo
{
    public class OSNativeUIDemoManager : MonoBehaviour
    {

        [SerializeField]
        private STOSAlertViewManager _stosAlertViewInternalManager;

        public void OnTouchedShowAlertButton()
        {
            _stosAlertViewInternalManager._onTouchedButtonAction -= OnTouchedButton;
            _stosAlertViewInternalManager._onTouchedButtonAction += OnTouchedButton;
            _stosAlertViewInternalManager.ShowAlert("タイトル","サブタイトル","OK","キャンセル");
        }

        private void OnTouchedButton(AlertButtonType buttonType)
        {
            Debug.Log("OnTouchedButton"+buttonType);
        }
    }
}
