using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public static class PlatformUtils
    {
        // Properties
        public static bool Supported { get; }
        
        // Methods
        public static bool get_Supported()
        {
            object[] val_5 = new object[1];
            val_5[0] = "com.google.android.play.games";
            return (bool)((new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "getLaunchIntentForPackage", args:  val_5)) != 0) ? 1 : 0;
        }
    
    }

}
