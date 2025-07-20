using UnityEditor;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.ConnectToAndroid.Editor
{
    public class ConnectOnWIFISettingWindow : EditorWindow
    {
        

        private string androidAdbPath = "";
        private string currentIPAddress = "192.168.0.0";
        private string currentPort = "40000";
        
        [MenuItem("SyskenTLib/STMobileUtilV2/ConnectToAndroid/Connect Android On WIFI",priority = 10)]
        private static void ShowWindow()
        {
            var window = GetWindow<ConnectOnWIFISettingWindow>();
            window.titleContent = new GUIContent("ConnectOnAndroidWIFI - STMobileUtilV2");
            
            //パス設定
            STAndroidADBManager androidADBManager = new STAndroidADBManager();
            window.SetAndroidSDKPath( androidADBManager.GetADBPath());
            
            window.Show();
        }

        public void SetAndroidSDKPath(string newPath)
        {
            androidAdbPath = newPath;
        }

        private void OnGUI()
        {
            
            
            
            
#if UNITY_ANDROID
            EditorGUILayout.BeginVertical("Box");
            EditorGUILayout.LabelField("Android SDK ADB Path");
            EditorGUILayout.TextArea(androidAdbPath);
            EditorGUILayout.Space(30);
            
            EditorGUILayout.LabelField("Connect TO Android Device On WIFI");
            EditorGUILayout.LabelField("IP Address");
            currentIPAddress= EditorGUILayout.TextArea(currentIPAddress);
            EditorGUILayout.LabelField("Port");
            currentPort=EditorGUILayout.TextArea(currentPort);
            if (GUILayout.Button("Connect"))
            {
                STAndroidADBManager androidADBManager = new STAndroidADBManager();
                androidADBManager.ADB_ChangeTCPIPMode();
                androidADBManager.ADB_ConnectToAndroidDevice(currentIPAddress,currentPort);
            }
            
            EditorGUILayout.Space(30);
            
            EditorGUILayout.LabelField("Other");
            
            if (GUILayout.Button("ReInstall Latest APK", GUILayout.Width(140)))
            {
                STAndroidADBManager androidADBManager = new STAndroidADBManager();
                 string lastPath = androidADBManager.ReadLastBuildAPKPath();

                 if (lastPath != null && lastPath != "")
                 {
                     Debug.Log("再インストール開始："+lastPath);
                     androidADBManager.ADB_InstallAPK(lastPath);
                     Debug.Log("再インストール完了："+lastPath);
                     
                     
                     string appID = androidADBManager.ReadLastBuildAPKAppID();
                     Debug.Log("アプリ実行:"+appID);
                     
                     androidADBManager.ADB_RunAPK(appID);


                 }
            }
            

            EditorGUILayout.EndVertical();

#else

            EditorGUILayout.BeginVertical("Box");
            EditorGUILayout.HelpBox("Please Select Android Platform", MessageType.Warning);
            EditorGUILayout.EndVertical();
#endif
        }
    }
}