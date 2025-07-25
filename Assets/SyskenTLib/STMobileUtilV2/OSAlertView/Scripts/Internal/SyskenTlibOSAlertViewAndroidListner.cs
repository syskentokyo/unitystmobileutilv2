using System;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.OSAlertView.Internal
{
    public class SyskenTlibOSAlertViewAndroidListner:AndroidJavaProxy
    {
        public Action<AlertButtonType> _onTouchedButtonAction;
        
        public SyskenTlibOSAlertViewAndroidListner(STOSAlertViewInternalManager javaInterface): base("android.content.DialogInterface$OnClickListener"){
            //リスナーを作成した時に呼び出される
        }

        public void onClick(AndroidJavaObject obj, int value){
            if (value == -1)
            {
                //OK
                _onTouchedButtonAction?.Invoke(AlertButtonType.OK);
                
            }else if (value == -2)
            {
                //キャンセル
                _onTouchedButtonAction?.Invoke(AlertButtonType.Cancel);
            }
        }
    }
}