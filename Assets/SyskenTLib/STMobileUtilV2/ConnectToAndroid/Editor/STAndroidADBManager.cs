using System.Diagnostics;
using UnityEditor;
#if UNITY_ANDROID
using UnityEditor.Android;
#endif


namespace SyskenTLib.STMobileUtilV2.ConnectToAndroid.Editor
{
    public class STAndroidADBManager
    {
        private static string _lastBuildPath = "";
        private static string _lastAppID = "";

        #region 保存

        public void SaveLastBuildAPKPath(string apkPath)
        {
            _lastBuildPath = apkPath;
        }
        
        public string ReadLastBuildAPKPath()
        {
            return _lastBuildPath;
        }
        
        public void SaveLastBuildAppID(string appID)
        {
            _lastAppID = appID;
        }
        
        public string ReadLastBuildAPKAppID()
        {
            return _lastAppID;
        }


        #endregion
        


        #region パス取得

        
        public string GetAndroidSDKPath()
        {
            #if UNITY_ANDROID
            
            return AndroidExternalToolsSettings.sdkRootPath;
            #else

            return "";
            
            #endif

        }

        public string GetADBPath()
        {
            return GetAndroidSDKPath() + "/platform-tools/adb";
        }
        
        
        

        #endregion


        #region ADB 接続

        


        public void ADB_ChangeTCPIPMode()
        {
            #if UNITY_EDITOR_OSX
            string command = "-c \'" +GetADBPath() + " tcpip 5555"+"\'";
            
            Process process = new Process();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();
            
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();

            UnityEngine.Debug.Log(output);
            #elif  UNITY_EDITOR_WIN
            string command = "/c \"" +GetADBPath() + ".exe\"  tcpip 5555"+"";
            
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();
            
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();

            UnityEngine.Debug.Log(output);
            #endif
        }
        
        public void ADB_ConnectToAndroidDevice(string ipaddress,string port)
        {
#if UNITY_EDITOR_OSX
            string command = "-c '" +GetADBPath()+ " connect "+ ipaddress +":"+port+"'";
            
            Process process = new Process();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();
            
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();
            
            UnityEngine.Debug.Log(command);
            UnityEngine.Debug.Log(output);
#elif  UNITY_EDITOR_WIN
            string command = "/c \"" +GetADBPath()+ ".exe\"  connect "+ ipaddress +":"+port+"";
            
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();
            
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();
            
            UnityEngine.Debug.Log(command);
            UnityEngine.Debug.Log(output);

#endif
        }

        public void ADB_InstallAPK(string apkPath)
        {
#if UNITY_EDITOR_OSX
            string command = "-c '" + GetADBPath() + " install -r " + apkPath + "'";

            Process process = new Process();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();

            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();

            UnityEngine.Debug.Log(command);
            UnityEngine.Debug.Log(output);
#elif UNITY_EDITOR_WIN
            string command = "/c \"" +GetADBPath()+ ".exe\"   install -r  "+ apkPath +"'";
            
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();
            
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();
            
            UnityEngine.Debug.Log(command);
            UnityEngine.Debug.Log(output);

#endif
        }
        
        public void ADB_RunAPK(string appID)
        {
#if UNITY_EDITOR_OSX
            string command = "-c '" + GetADBPath() + " shell monkey  -p " + appID + " -c android.intent.category.LAUNCHER 1'";

            Process process = new Process();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();

            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();

            UnityEngine.Debug.Log(command);
            UnityEngine.Debug.Log(output);
#elif UNITY_EDITOR_WIN
            string command = "/c \"" +GetADBPath()+ ".exe\"   shell monkey  -p " + appID + " -c android.intent.category.LAUNCHER 1";
            
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command;
            process.Start();
            
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();
            
            UnityEngine.Debug.Log(command);
            UnityEngine.Debug.Log(output);

#endif
        }
        
        
        
        

        #endregion
    }
}