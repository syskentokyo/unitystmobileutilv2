using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;


namespace SyskenTLib.STMobileUtilV2.ForiOS.NoBitCode.Editor
{
    public class SaveDataManager
    {
        public SyskenTLibSTMobileUtilV2UtilForiOSNoBitCodeConfig GetConfig()
        {
            return SearchConfigFile();
        }

        private SyskenTLibSTMobileUtilV2UtilForiOSNoBitCodeConfig SearchConfigFile()
        {
            List<SyskenTLibSTMobileUtilV2UtilForiOSNoBitCodeConfig> configList = new List<SyskenTLibSTMobileUtilV2UtilForiOSNoBitCodeConfig>();
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("t:SyskenTLibSTMobileUtilV2UtilForiOSNoBitCodeConfig");
            guids.ToList().ForEach(nextGUID =>
            {
                string filePath = AssetDatabase.GUIDToAssetPath(nextGUID);
                configList.Add( AssetDatabase.LoadAssetAtPath<SyskenTLibSTMobileUtilV2UtilForiOSNoBitCodeConfig> (filePath));
                
            });
#endif
            return configList[0];
        }

     
        
    }
}