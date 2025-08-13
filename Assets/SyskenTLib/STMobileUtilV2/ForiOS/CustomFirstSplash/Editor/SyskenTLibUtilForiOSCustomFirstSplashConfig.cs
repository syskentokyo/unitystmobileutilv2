using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.ForiOS.CustomFirstSplash.Editor
{

    
    public class SyskenTLibSTMobileUtilV2ForiOSCustomFirstSplashConfig : ScriptableObject
    {
        public bool isEnableOverwriteSplash = false;


        [Header("Source File")]
        [SerializeField]
        public TextAsset splashLogImage = null;
            
        [SerializeField]
        public TextAsset iPhoneBackgroundImage= null;
        
        [SerializeField]
        public TextAsset iPadBackgroundImage= null;
        
        [SerializeField] public TextAsset splashStoryboardIPhone = null;
        [SerializeField] public TextAsset splashStoryboardIpad = null;
        
    }
}