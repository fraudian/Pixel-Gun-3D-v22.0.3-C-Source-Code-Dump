using UnityEngine;
private abstract class AmazonIapV2Impl.AmazonIapV2UnityBase : AmazonIapV2Impl.AmazonIapV2Base
{
    // Fields
    private const string CrossPlatformTool = "UNITY";
    private static com.amazon.device.iap.cpt.AmazonIapV2Impl.AmazonIapV2UnityBase instance;
    private static System.Type instanceType;
    private static bool quit;
    private static object initLock;
    
    // Methods
    private static AmazonIapV2Impl.AmazonIapV2UnityBase()
    {
        AmazonIapV2Impl.AmazonIapV2UnityBase.quit = false;
        AmazonIapV2Impl.AmazonIapV2UnityBase.initLock = new System.Object();
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
        if(AmazonIapV2Impl.AmazonIapV2UnityBase.quit != false)
        {
                return 0;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = null;
        if(AmazonIapV2Impl.AmazonIapV2UnityBase.instance != 0)
        {
                val_14 = null;
            if(AmazonIapV2Impl.AmazonIapV2UnityBase.instance == null)
        {
                return 0;
        }
        
            if(AmazonIapV2Impl.AmazonIapV2UnityBase.instance != null)
        {
                return 0;
        }
        
            return 0;
        }
        
        val_15 = null;
        bool val_3 = false;
        System.Threading.Monitor.Enter(obj:  AmazonIapV2Impl.AmazonIapV2UnityBase.initLock, lockTaken: ref  val_3);
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 8});
        val_16 = null;
        val_16 = null;
        if(AmazonIapV2Impl.AmazonIapV2UnityBase.instance == 0)
        {
                val_17 = 1;
        }
        else
        {
                val_18 = null;
            val_18 = null;
            if(AmazonIapV2Impl.AmazonIapV2UnityBase.instance != 0)
        {
                val_19 = null;
            val_19 = null;
            val_17 = System.Type.op_Equality(left:  AmazonIapV2Impl.AmazonIapV2UnityBase.instanceType, right:  val_4);
        }
        else
        {
                val_17 = 0;
        }
        
        }
        
        AmazonIapV2Impl.AmazonIapV2UnityBase.assertTrue(statement:  false, errorMessage:  "Only 1 instance of 1 subtype of AmazonIapV2UnityBase can exist.");
        if(AmazonIapV2Impl.AmazonIapV2UnityBase.instance == 0)
        {
                val_20 = null;
            val_20 = null;
            AmazonIapV2Impl.AmazonIapV2UnityBase.instanceType = val_4;
            new UnityEngine.GameObject() = new UnityEngine.GameObject();
            AmazonIapV2Impl.AmazonIapV2UnityBase.instance = new UnityEngine.GameObject();
            new UnityEngine.GameObject().name = val_4 + "_Singleton";
            UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
        }
        
        val_21 = null;
        val_21 = null;
        val_22 = AmazonIapV2Impl.AmazonIapV2UnityBase.instance;
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
                System.Threading.Monitor.Exit(obj:  AmazonIapV2Impl.AmazonIapV2UnityBase.initLock);
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
        AmazonIapV2Impl.AmazonIapV2UnityBase.quit = true;
    }
    private static void assertTrue(bool statement, string errorMessage)
    {
        if(statement != false)
        {
                return;
        }
        
        com.amazon.device.iap.cpt.AmazonException val_2 = new com.amazon.device.iap.cpt.AmazonException(message:  "FATAL: An internal error occurred", innerException:  new System.InvalidOperationException(message:  errorMessage));
    }
    protected override void Init()
    {
        goto typeof(AmazonIapV2Impl.AmazonIapV2UnityBase).__il2cppRuntimeField_3B8;
    }
    protected override void RegisterCrossPlatformTool()
    {
        goto typeof(AmazonIapV2Impl.AmazonIapV2UnityBase).__il2cppRuntimeField_3C8;
    }
    protected abstract void NativeInit(); // 0
    protected abstract void NativeRegisterCrossPlatformTool(string crossPlatformTool); // 0
    protected AmazonIapV2Impl.AmazonIapV2UnityBase()
    {
    
    }

}
