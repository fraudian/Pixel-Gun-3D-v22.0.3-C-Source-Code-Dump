using UnityEngine;
internal class 专丌丌丘丅上七丟丏 : 丏一丌丆业专丑丂丛
{
    // Fields
    private static UnityEngine.AndroidJavaClass 一与与业丄丁丗丆专;
    private const string 丂丘丕丆丁丞丁上丙 = "mounted";
    private string <上三丟丙不三丁东丑>k__BackingField;
    private string 丁丐下丐专万丁世丛;
    private static string 上丘三丁丅上丆世上;
    private static int 专丗业丁上不丅且世;
    
    // Properties
    public string 丗七丘丈丒上丌丞世 { get; set; }
    private static string 丝丙丁丆下万一且上 { get; }
    private static int 丄丝世丂丆专与且丛 { get; }
    
    // Methods
    public string 丄下丒丑三不丌丐丁()
    {
        return (string)this.<上三丟丙不三丁东丑>k__BackingField;
    }
    public void 丘丌丆丘丁丑三丈上(string 丙业与丙丗丝不丈东)
    {
        this.<上三丟丙不三丁东丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 丅上丄丂丌丟七丟丙()
    {
        var val_10;
        if((System.String.IsNullOrEmpty(value:  this.<上三丟丙不三丁东丑>k__BackingField)) != false)
        {
                UnityEngine.Debug.LogError(message:  "GooglePlayObbDownloader: The public key is not set - did you forget to set it in the script?\n");
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_10 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.plugin.downloader.UnityDownloaderService");
        val_2.SetStatic<System.String>(fieldName:  "BASE64_PUBLIC_KEY", val:  this.<上三丟丙不三丁东丑>k__BackingField);
        val_2.SetStatic<System.Byte[]>(fieldName:  "SALT", val:  new byte[20]);
        if(val_10 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_10 = ???;
    }
    public void 东下万丅丞且不丂丟()
    {
        this.丅上丄丂丌丟七丟丙();
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        object[] val_3 = new object[2];
        val_3[0] = val_2;
        new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.plugin.downloader.UnityDownloaderActivity");
        val_3[1] = new UnityEngine.AndroidJavaClass();
        new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  val_3);
        object[] val_6 = new object[1];
        val_6[0] = 65536;
        UnityEngine.AndroidJavaObject val_7 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "addFlags", args:  val_6);
        object[] val_8 = new object[2];
        val_8[0] = "unityplayer.Activity";
        val_8[1] = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getClass", args:  System.Array.Empty<System.Object>()).Call<System.String>(methodName:  "getName", args:  System.Array.Empty<System.Object>());
        UnityEngine.AndroidJavaObject val_13 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "putExtra", args:  val_8);
        object[] val_14 = new object[1];
        val_14[0] = new UnityEngine.AndroidJavaObject();
        val_2.Call(methodName:  "startActivity", args:  val_14);
        if(val_1 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(211 == 211)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    public string 下丘丐上三上丑丘丏()
    {
        var val_12;
        System.Object[] val_13;
        var val_14;
        val_12 = null;
        val_12 = null;
        val_13 = System.Array.Empty<System.Object>();
        if((System.String.op_Inequality(a:  专丌丌丘丅上七丟丏.丂丘丕丆丁丞丁上丙.CallStatic<System.String>(methodName:  "getExternalStorageState", args:  val_13), b:  "mounted")) != false)
        {
                this.丁丐下丐专万丁世丛 = 0;
            return (string)this.丁丐下丐专万丁世丛;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.丁丐下丐专万丁世丛)) == false)
        {
                return (string)this.丁丐下丐专万丁世丛;
        }
        
        val_14 = null;
        val_14 = null;
        UnityEngine.AndroidJavaObject val_6 = 专丌丌丘丅上七丟丏.丂丘丕丆丁丞丁上丙.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getExternalStorageDirectory", args:  System.Array.Empty<System.Object>());
        val_13 = 0;
        this.丁丐下丐专万丁世丛 = System.String.Format(format:  "{0}/{1}/{2}", arg0:  val_6.Call<System.String>(methodName:  "getPath", args:  System.Array.Empty<System.Object>()), arg1:  "Android/obb", arg2:  专丌丌丘丅上七丟丏.不丐专丟丁上一丑且());
        if(val_6 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_6.Dispose();
        }
        
        if(0 != 1)
        {
                return (string)this.丁丐下丐专万丁世丛;
        }
        
        if(val_13 == 0)
        {
                return (string)this.丁丐下丐专万丁世丛;
        }
        
        return (string)this.丁丐下丐专万丁世丛;
    }
    public string 丏上丙丂丐丒丟丅丌()
    {
        return 专丌丌丘丅上七丟丏.丅三且丞万丗丝丂丗(丐丐世丛丌丝丗一丂:  this.下丘丐上三上丑丘丏(), 丂业丕业丂丅丙一丛:  "main");
    }
    public string 丕东与七丏上丈与丛()
    {
        return 专丌丌丘丅上七丟丏.丅三且丞万丗丝丂丗(丐丐世丛丌丝丗一丂:  this.下丘丐上三上丑丘丏(), 丂业丕业丂丅丙一丛:  "patch");
    }
    private static string 丅三且丞万丗丝丂丗(string 丐丐世丛丌丝丗一丂, string 丂业丕业丂丅丙一丛)
    {
        var val_8;
        var val_9;
        var val_10;
        if((System.String.IsNullOrEmpty(value:  丐丐世丛丌丝丗一丂)) != false)
        {
                val_9 = 0;
            return (string)((System.IO.File.Exists(path:  string val_5 = System.String.Format(format:  "{0}/{1}.{2}.{3}.obb", args:  object[] val_2 = new object[4]))) != true) ? (val_8) : 0;
        }
        
        val_2[0] = 丐丐世丛丌丝丗一丂;
        val_2[1] = 丂业丕业丂丅丙一丛;
        val_10 = null;
        val_2[2] = 专丌丌丘丅上七丟丏.丝丈业丄丅丙丅丘业();
        val_2[3] = 专丌丌丘丅上七丟丏.不丐专丟丁上一丑且();
        val_8 = val_5;
        return (string)((System.IO.File.Exists(path:  val_5)) != true) ? (val_8) : 0;
    }
    private static string 不丐专丟丁上一丑且()
    {
        var val_1 = null;
        if(专丌丌丘丅上七丟丏.上丘三丁丅上丆世上 == null)
        {
                专丌丌丘丅上七丟丏.丏上且丂丕丙丑东丌();
            val_1 = null;
        }
        
        val_1 = null;
        return (string)专丌丌丘丅上七丟丏.上丘三丁丅上丆世上;
    }
    private static int 丝丈业丄丅丙丅丘业()
    {
        var val_1 = null;
        if(专丌丌丘丅上七丟丏.专丗业丁上不丅且世 == 0)
        {
                专丌丌丘丅上七丟丏.丏上且丂丕丙丑东丌();
            val_1 = null;
        }
        
        val_1 = null;
        return (int)专丌丌丘丅上七丟丏.专丗业丁上不丅且世;
    }
    private static void 丏上且丂丕丙丑东丌()
    {
        var val_11;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_11 = null;
        val_11 = null;
        专丌丌丘丅上七丟丏.上丘三丁丅上丆世上 = val_2.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
        object[] val_7 = new object[2];
        val_7[0] = 专丌丌丘丅上七丟丏.上丘三丁丅上丆世上;
        val_7[1] = 0;
        专丌丌丘丅上七丟丏.专丗业丁上不丅且世 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_7).Get<System.Int32>(fieldName:  "versionCode");
        if(val_1 != null)
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public 专丌丌丘丅上七丟丏()
    {
    
    }
    private static 专丌丌丘丅上七丟丏()
    {
        专丌丌丘丅上七丟丏.丂丘丕丆丁丞丁上丙 = new UnityEngine.AndroidJavaClass(className:  "android.os.Environment");
    }

}
