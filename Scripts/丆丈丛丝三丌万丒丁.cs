using UnityEngine;
public class 丆丈丛丝三丌万丒丁
{
    // Fields
    private const string 丛丗丝七下丙三丛丏 = "Unsupported Platform";
    private static 丆丈丛丝三丌万丒丁 丝业丆丁业三丈丟东;
    private static UnityEngine.AndroidJavaObject 丁丏丕丗丐丌丒丕丝;
    private static readonly string 丗上且丈万丘七丝东;
    
    // Properties
    public static 丆丈丛丝三丌万丒丁 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    public static 丆丈丛丝三丌万丒丁 丑七不且上丗丁一世()
    {
        丆丈丛丝三丌万丒丁 val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(丆丈丛丝三丌万丒丁.丝业丆丁业三丈丟东 == null)
        {
                丆丈丛丝三丌万丒丁 val_1 = null;
            val_2 = val_1;
            val_1 = new 丆丈丛丝三丌万丒丁();
            val_4 = null;
            val_4 = null;
            丆丈丛丝三丌万丒丁.丝业丆丁业三丈丟东 = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        return (丆丈丛丝三丌万丒丁)丆丈丛丝三丌万丒丁.丝业丆丁业三丈丟东;
    }
    public 丆丈丛丝三丌万丒丁()
    {
        var val_11;
        var val_12;
        UnityEngine.AndroidJavaObject val_13;
        var val_14;
        val_11 = null;
        val_11 = null;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_12 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  丆丈丛丝三丌万丒丁.丗上且丈万丘七丝东);
        val_13 = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
        val_14 = null;
        val_14 = null;
        丆丈丛丝三丌万丒丁.丁丏丕丗丐丌丒丕丝 = val_13;
        if(val_12 != null)
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
        
        val_12 = ???;
        val_13 = ???;
    }
    public void 丒丁东丕丝丅上丄万(string 丞丞丐丝丝丏丐丛丞)
    {
        null = null;
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(丞丞丐丝丝丏丐丛丞 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(丞丞丐丝丝丏丐丛丞 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = 丞丞丐丝丝丏丐丛丞;
        丆丈丛丝三丌万丒丁.丁丏丕丗丐丌丒丕丝.Call(methodName:  "setLanguage", args:  val_1);
    }
    public void 万丟丌丂七下丁丁万(bool 丝丝不丝上丂三丌世)
    {
        var val_3;
        bool val_1 = 丝丝不丝上丂三丌世;
        val_3 = null;
        val_3 = null;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_1 == true)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_1 == false)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = val_1;
        丆丈丛丝三丌万丒丁.丁丏丕丗丐丌丒丕丝.Call(methodName:  "setClientSideCallbacks", args:  val_2);
    }
    public void 不下丁不丐七丆万上(System.Collections.Generic.Dictionary<string, string> 专丘丑丏业丘丙丕一)
    {
        var val_3;
        string val_1 = IronSourceJSON.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  专丘丑丏业丘丙丕一);
        val_3 = null;
        val_3 = null;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_1 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_1 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = val_1;
        丆丈丛丝三丌万丒丁.丁丏丕丗丐丌丒丕丝.Call(methodName:  "setRewardedVideoCustomParams", args:  val_2);
    }
    public void 丄丒丌丑东东上丂与(System.Collections.Generic.Dictionary<string, string> 丞下丂丗丟丆丄一丒)
    {
        var val_3;
        string val_1 = IronSourceJSON.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丞下丂丗丟丆丄一丒);
        val_3 = null;
        val_3 = null;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_1 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_1 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = val_1;
        丆丈丛丝三丌万丒丁.丁丏丕丗丐丌丒丕丝.Call(methodName:  "setOfferwallCustomParams", args:  val_2);
    }
    private static 丆丈丛丝三丌万丒丁()
    {
        丆丈丛丝三丌万丒丁.丗上且丈万丘七丝东 = "com.ironsource.unity.androidbridge.AndroidBridge";
    }

}
