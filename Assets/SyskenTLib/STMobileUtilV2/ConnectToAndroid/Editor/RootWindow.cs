using UnityEditor;
using UnityEngine;

namespace SyskenTLib.STMobileUtilV2.ConnectToAndroid.Editor
{
    public class RootWindow : UnityEditor.EditorWindow
    {
        /// <Summary>
        /// Rootの定義(らいぶらりごとにメニューに区切りをつけるためのダミー）
        /// </Summary>
        [MenuItem("SyskenTLib/STMobileUtilV2/ConnectToAndroid/",priority = 40)]
        private static void OpenRoot()
        {
        }
    }
}