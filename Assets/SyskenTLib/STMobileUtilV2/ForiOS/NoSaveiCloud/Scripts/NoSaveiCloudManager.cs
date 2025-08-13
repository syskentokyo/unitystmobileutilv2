using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_IOS
using UnityEngine.iOS;
#endif


namespace SyskenTLib.STMobileUtilV2.ForiOS.NoSaveiCloud
{
    public class NoSaveiCloudManager 
    {

        #region よくあるフォルダ

        
        public void SetPersistentDataPathNoSaveToiCloud()
        {

            SetNoSaveToiCloud(Application.persistentDataPath);

        }
        
        public void SetDownloadDataPathNoSaveToiCloud(string dirPath)
        {

            SetNoSaveToiCloud(Application.persistentDataPath+"/"+"downloadData");

        }


        

        #endregion        

        public void SetNoSaveToiCloud(string dirPath){
            
#if UNITY_IOS
        
            Device.SetNoBackupFlag(dirPath);//iCloudへの保存しないようにする
            
#endif
        
        }


    }
}
