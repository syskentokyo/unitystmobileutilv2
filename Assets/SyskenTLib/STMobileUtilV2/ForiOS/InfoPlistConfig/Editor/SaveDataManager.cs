using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.ForiOS.InfoPlistConfig.Editor
{
    public class SaveDataManager
    {
        public SyskenTLibSTMobileUtilV2UtilForiOSInfoPlistConfig GetConfig()
        {
            return SearchConfigFile();
        }

        private SyskenTLibSTMobileUtilV2UtilForiOSInfoPlistConfig SearchConfigFile()
        {
            List<SyskenTLibSTMobileUtilV2UtilForiOSInfoPlistConfig> configList = new List<SyskenTLibSTMobileUtilV2UtilForiOSInfoPlistConfig>();
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("t:SyskenTLibSTMobileUtilV2UtilForiOSInfoPlistConfig");
            guids.ToList().ForEach(nextGUID =>
            {
                string filePath = AssetDatabase.GUIDToAssetPath(nextGUID);
                configList.Add( AssetDatabase.LoadAssetAtPath<SyskenTLibSTMobileUtilV2UtilForiOSInfoPlistConfig> (filePath));
                
            });
#endif
            return configList[0];
        }

     
        
    }
}