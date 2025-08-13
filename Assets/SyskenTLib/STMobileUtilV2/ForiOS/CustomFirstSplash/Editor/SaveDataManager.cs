using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;



namespace SyskenTLib.STMobileUtilV2.ForiOS.CustomFirstSplash.Editor
{
    public class SaveDataManager
    {
        public SyskenTLibSTMobileUtilV2ForiOSCustomFirstSplashConfig GetConfig()
        {
            return SearchConfigFile();
        }

        private SyskenTLibSTMobileUtilV2ForiOSCustomFirstSplashConfig SearchConfigFile()
        {
            List<SyskenTLibSTMobileUtilV2ForiOSCustomFirstSplashConfig> configList =
                new List<SyskenTLibSTMobileUtilV2ForiOSCustomFirstSplashConfig>();
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("t:SyskenTLibSTMobileUtilV2ForiOSCustomFirstSplashConfig");
            guids.ToList().ForEach(nextGUID =>
            {
                string filePath = AssetDatabase.GUIDToAssetPath(nextGUID);
                configList.Add(AssetDatabase.LoadAssetAtPath<SyskenTLibSTMobileUtilV2ForiOSCustomFirstSplashConfig>(filePath));

            });
#endif
            return configList[0];
        }



    }
}
