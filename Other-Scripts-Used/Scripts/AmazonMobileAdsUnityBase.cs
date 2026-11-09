using UnityEngine;
private abstract class AmazonMobileAdsImpl.AmazonMobileAdsUnityBase : AmazonMobileAdsImpl.AmazonMobileAdsBase
{
    // Fields
    private const string CrossPlatformTool = "UNITY";
    private static com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.AmazonMobileAdsUnityBase instance;
    private static System.Type instanceType;
    private static bool quit;
    private static object initLock;
    
    // Methods
    private static AmazonMobileAdsImpl.AmazonMobileAdsUnityBase()
    {
        AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.quit = false;
        AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.initLock = new System.Object();
    }
    public static T getInstance<T>()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        UnityEngine.GameObject val_22;
        val_11 = null;
        val_11 = null;
        if(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.quit != false)
        {
                return 0;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = null;
        if(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance != 0)
        {
                val_14 = null;
            if(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance == null)
        {
                return 0;
        }
        
            if(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance != null)
        {
                return 0;
        }
        
            return 0;
        }
        
        val_15 = null;
        bool val_3 = false;
        System.Threading.Monitor.Enter(obj:  AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.initLock, lockTaken: ref  val_3);
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 8});
        val_16 = null;
        val_16 = null;
        if(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance == 0)
        {
                val_17 = 1;
        }
        else
        {
                val_18 = null;
            val_18 = null;
            if(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance != 0)
        {
                val_19 = null;
            val_19 = null;
            val_17 = System.Type.op_Equality(left:  AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instanceType, right:  val_4);
        }
        else
        {
                val_17 = 0;
        }
        
        }
        
        AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.assertTrue(statement:  false, errorMessage:  "Only 1 instance of 1 subtype of AmazonMobileAdsUnityBase can exist.");
        if(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance == 0)
        {
                val_20 = null;
            val_20 = null;
            AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instanceType = val_4;
            new UnityEngine.GameObject() = new UnityEngine.GameObject();
            AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance = new UnityEngine.GameObject();
            new UnityEngine.GameObject().name = val_4 + "_Singleton";
            UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
        }
        
        val_21 = null;
        val_21 = null;
        val_22 = AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.instance;
        if(val_22 == null)
        {
            goto label_50;
        }
        
        if(val_22 == null)
        {
            goto label_51;
        }
        
        val_22 = 0;
        goto label_52;
        label_51:
        val_22 = 0;
        label_50:
        label_52:
        if(val_3 != 0)
        {
                System.Threading.Monitor.Exit(obj:  AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.initLock);
        }
        
        if(val_22 != 1)
        {
                return 0;
        }
        
        if(0 == 0)
        {
                return 0;
        }
        
        return 0;
    }
    public void OnDestroy()
    {
        AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.quit = true;
    }
    private static void assertTrue(bool statement, string errorMessage)
    {
        if(statement != false)
        {
                return;
        }
        
        com.amazon.mas.cpt.ads.AmazonException val_2 = new com.amazon.mas.cpt.ads.AmazonException(message:  "FATAL: An internal error occurred", innerException:  new System.InvalidOperationException(message:  errorMessage));
    }
    protected override void Init()
    {
        goto typeof(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase).__il2cppRuntimeField_5B8;
    }
    protected override void RegisterCrossPlatformTool()
    {
        goto typeof(AmazonMobileAdsImpl.AmazonMobileAdsUnityBase).__il2cppRuntimeField_5C8;
    }
    protected abstract void NativeInit(); // 0
    protected abstract void NativeRegisterCrossPlatformTool(string crossPlatformTool); // 0
    protected AmazonMobileAdsImpl.AmazonMobileAdsUnityBase()
    {
    
    }

}
