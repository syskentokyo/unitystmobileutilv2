using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.ForiOS.NoSaveiCloud
{
    [DefaultExecutionOrder(-1000)]
    public class AutoNoSaveAllToiCloud : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
#if UNITY_IOS
                //できるだけすべてオフにする
                NoSaveiCloudManager noSaveiCloudManager = new NoSaveiCloudManager();
                noSaveiCloudManager.SetNoSaveToiCloud(Application.persistentDataPath);//Documenetフォルダすべてを対象から外す

#endif
        }

    }
}
