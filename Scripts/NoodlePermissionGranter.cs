using UnityEngine;
public class NoodlePermissionGranter : MonoBehaviour
{
    // Fields
    public static System.Action<bool> PermissionRequestCallback;
    public static System.EventHandler<System.EventArgs> PermissionRequestFinished;
    private static NoodlePermissionGranter 丄丘七三上丕世丞业;
    private static bool 丝与丆丞东丘丈东丘;
    private static UnityEngine.AndroidJavaClass 专丅丁七丁世丁与丕;
    private static UnityEngine.AndroidJavaObject 丌丑丅且专丒丘不一;
    private const string 丗七丞七丗丗丏不且 = "WRITE_EXTERNAL_STORAGE";
    private const string 丑万丁一上丏世丁丛 = "PERMISSION_GRANTED";
    private const string 上丝世丐丟丟不上丟 = "PERMISSION_DENIED";
    private const string 专且万丏一与丌东丅 = "NoodlePermissionGranter";
    
    // Methods
    public static void GrantPermission(NoodlePermissionGranter.下丒丏万专上丂丆丅 丂丐东七专不丁丝专)
    {
        下丒丏万专上丂丆丅 val_4;
        System.Object[] val_5;
        var val_6;
        var val_7;
        val_4 = 丂丐东七专不丁丝专;
        object[] val_1 = new object[1];
        val_1[0] = val_4;
        UnityEngine.Debug.LogFormat(format:  "[NoodlePermissionGranter] GrantPermission => permission: {0}", args:  val_1);
        val_5 = 1152921505234907136;
        val_6 = null;
        val_6 = null;
        if(NoodlePermissionGranter.丝与丆丞东丘丈东丘 != true)
        {
                NoodlePermissionGranter.丟丏七丕丄三丈一丝();
        }
        
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        object[] val_3 = new object[2];
        val_5 = val_3;
        val_5[0] = NoodlePermissionGranter.丌丑丅且专丒丘不一;
        val_4 = val_4;
        val_5[1] = val_4;
        NoodlePermissionGranter.专丅丁七丁世丁与丕.CallStatic(methodName:  "grantPermission", args:  val_3);
    }
    public void Awake()
    {
        var val_4;
        UnityEngine.Debug.Log(message:  "[NoodlePermissionGranter] Awake");
        val_4 = null;
        val_4 = null;
        NoodlePermissionGranter.丄丘七三上丕世丞业 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        if((System.String.op_Inequality(a:  this.name, b:  "NoodlePermissionGranter")) == false)
        {
                return;
        }
        
        this.name = "NoodlePermissionGranter";
    }
    private static void 丟丏七丕丄三丈一丝()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        UnityEngine.Debug.Log(message:  "[NoodlePermissionGranter] initialize");
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(NoodlePermissionGranter.丄丘七三上丕世丞业 == 0)
        {
                UnityEngine.Debug.Log(message:  "[NoodlePermissionGranter] initialize => instance: null");
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject();
            val_10 = null;
            val_10 = null;
            NoodlePermissionGranter.丄丘七三上丕世丞业 = val_3.AddComponent<NoodlePermissionGranter>();
            val_3.name = "NoodlePermissionGranter";
        }
        
        val_11 = null;
        val_11 = null;
        NoodlePermissionGranter.专丅丁七丁世丁与丕 = new UnityEngine.AndroidJavaClass(className:  "com.noodlecake.unityplugins.NoodlePermissionGranter");
        UnityEngine.AndroidJavaClass val_6 = null;
        val_8 = val_6;
        val_6 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        NoodlePermissionGranter.丌丑丅且专丒丘不一 = val_6.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        NoodlePermissionGranter.丝与丆丞东丘丈东丘 = true;
    }
    private void permissionRequestCallbackInternal(string message)
    {
        var val_3;
        object[] val_1 = new object[1];
        val_1[0] = message;
        UnityEngine.Debug.LogFormat(format:  "[NoodlePermissionGranter] permissionRequestCallbackInternal => message: {0}", args:  val_1);
        string val_3 = "PERMISSION_GRANTED";
        val_3 = null;
        val_3 = null;
        if(NoodlePermissionGranter.专且万丏一与丌东丅 != null)
        {
                val_3 = System.String.op_Equality(a:  message, b:  val_3);
            0.Invoke(obj:  val_3);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[NoodlePermissionGranter] permissionRequestCallbackInternal => PermissionRequestCallback: null");
    }
    public NoodlePermissionGranter()
    {
    
    }
    private static NoodlePermissionGranter()
    {
    
    }

}
