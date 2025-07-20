using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.Callbacks;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.ConnectToAndroid.Editor
{
    public class CustomPostProcessorManager:IPreprocessBuildWithReport, IPostprocessBuildWithReport
    {
        // 実行順
        public int callbackOrder => 1;
        

        // 事前実行
        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform == BuildTarget.Android)
            {
                //
                // ビルド時の処理開始
                //

            }
        }
        
        /// <summary>
        /// ビルド後
        /// </summary>
        /// <param name="report"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnPostprocessBuild(BuildReport report)
        {
            Debug.Log("OnPostprocessBuild　SyskenTLib.STMobileUtilV2.ConnectToAndroid");
            if (report.summary.platform == BuildTarget.Android)
            {
                
                //
                // パス系を控える処理
                //
                Debug.Log("APKパス："+report.summary.outputPath);

                STAndroidADBManager androidADBManager = new STAndroidADBManager();
                androidADBManager.SaveLastBuildAPKPath(report.summary.outputPath);
                
                
                string currentAppID = PlayerSettings.GetApplicationIdentifier(NamedBuildTarget.Android);
                Debug.Log("APKのアプリID："+currentAppID);
                androidADBManager.SaveLastBuildAppID(currentAppID);
                
            }
        }

    }
}