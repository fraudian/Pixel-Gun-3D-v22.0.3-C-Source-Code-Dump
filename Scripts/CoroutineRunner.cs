using UnityEngine;
public sealed class CoroutineRunner : MonoBehaviour
{
    // Fields
    private static CoroutineRunner 丝业丆丁业三丈丟东;
    private static System.Action 专丞丛丘丞丅且丒丐;
    private static System.Action 上丘丁丄东七丟丅丆;
    private static System.Action<bool> 丞万丄丕丒下上业丄;
    private static System.Action 万丙丂丒丒业且上东;
    private readonly System.Collections.Concurrent.ConcurrentQueue<System.Collections.IEnumerator> 丐丙且丟丟不万万不;
    
    // Properties
    public static CoroutineRunner 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    public static CoroutineRunner get_Instance()
    {
        var val_5;
        CoroutineRunner val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = CoroutineRunner.丝业丆丁业三丈丟东;
        if(val_6 == 0)
        {
                val_6 = new UnityEngine.GameObject();
            val_6 = new UnityEngine.GameObject(name:  "CoroutineRunner");
            val_7 = null;
            val_7 = null;
            CoroutineRunner.丝业丆丁业三丈丟东 = new UnityEngine.GameObject().AddComponent<CoroutineRunner>();
            if(UnityEngine.Application.isPlaying != false)
        {
                UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        return (CoroutineRunner)CoroutineRunner.丝业丆丁业三丈丟东;
    }
    internal static void 丈与丅丆丘丟丆丆丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  CoroutineRunner.专丞丛丘丞丅且丒丐, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.专丞丛丘丞丅且丒丐 != 1152921505168244744);
    
    }
    internal static void 东丁丗三丌丆丝丘丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  CoroutineRunner.专丞丛丘丞丅且丒丐, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.专丞丛丘丞丅且丒丐 != 1152921505168244744);
    
    }
    internal static void 丁丑丈丈且下业与东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  CoroutineRunner.上丘丁丄东七丟丅丆, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.上丘丁丄东七丟丅丆 != 1152921505168244752);
    
    }
    internal static void 丏丕丁丆丂业一与一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  CoroutineRunner.上丘丁丄东七丟丅丆, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.上丘丁丄东七丟丅丆 != 1152921505168244752);
    
    }
    internal static void 与万且丗丆下丁且丂(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  CoroutineRunner.丞万丄丕丒下上业丄, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.丞万丄丕丒下上业丄 != 1152921505168244760);
    
    }
    internal static void 丕丑不丗上丁丝丕专(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  CoroutineRunner.丞万丄丕丒下上业丄, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.丞万丄丕丒下上业丄 != 1152921505168244760);
    
    }
    internal static void 丁丅丙上丅丛丂丁丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  CoroutineRunner.万丙丂丒丒业且上东, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.万丙丂丒丒业且上东 != 1152921505168244768);
    
    }
    internal static void 丗一丏与丅万丕丞丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  CoroutineRunner.万丙丂丒丒业且上东, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(CoroutineRunner.万丙丂丒丒业且上东 != 1152921505168244768);
    
    }
    private void Awake()
    {
    
    }
    private void OnDestroy()
    {
    
    }
    private void Update()
    {
        var val_5;
        System.Collections.IEnumerator val_2 = 0;
        goto label_2;
        label_8:
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  val_2);
        label_2:
        if((this.丐丙且丟丟不万万不.TryDequeue(result: out  val_2)) == true)
        {
            goto label_8;
        }
        
        val_5 = null;
        val_5 = null;
        if(CoroutineRunner.专丞丛丘丞丅且丒丐 == null)
        {
                return;
        }
        
        CoroutineRunner.专丞丛丘丞丅且丒丐.Invoke();
    }
    private void OnGUI()
    {
        null = null;
        if(CoroutineRunner.上丘丁丄东七丟丅丆 == null)
        {
                return;
        }
        
        CoroutineRunner.上丘丁丄东七丟丅丆.Invoke();
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        var val_1;
        System.Action<System.Boolean> val_2;
        val_1 = null;
        val_1 = null;
        val_2 = CoroutineRunner.丞万丄丕丒下上业丄;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = CoroutineRunner.丞万丄丕丒下上业丄;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        丁与丟万丄丒丗专丌 = 丁与丟万丄丒丗专丌;
        val_2.Invoke(obj:  丁与丟万丄丒丗专丌);
    }
    private void OnApplicationQuit()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = CoroutineRunner.万丙丂丒丒业且上东;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = CoroutineRunner.万丙丂丒丒业且上东;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal static void 丌不三万且丂丟丐丆(System.Action 一丏丘业丅丈东东丄)
    {
        var val_6 = null;
        if((CoroutineRunner.<>c.<>9__22_0) == null)
        {
            goto label_5;
        }
        
        label_11:
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  null.不一业丐不丈丌世丑(且丐丈丕三丟丕丙丒:  CoroutineRunner.<>c.<>9__22_0, 一丏丘业丅丈东东丄:  一丏丘业丅丈东东丄));
        return;
        label_5:
        CoroutineRunner.<>c.<>9__22_0 = new System.Func<System.Boolean>(object:  CoroutineRunner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CoroutineRunner.<>c::且丈丄不不丐且专一());
        if(CoroutineRunner.Instance != null)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    internal System.Collections.IEnumerator 丐一业东不且下丟丝(System.Collections.IEnumerator 丈不不丁丆世丑专上, System.Threading.Tasks.TaskCompletionSource<bool> 世丅丒丆三下专丘丆)
    {
        string val_3;
        if(丈不不丁丆世丑专上 == null)
        {
            goto label_1;
        }
        
        if(世丅丒丆三下专丘丆 == null)
        {
            goto label_2;
        }
        
        return this.丐丛丌丁丕丂丝丗丐(丈不不丁丆世丑专上:  丈不不丁丆世丑专上, 世丅丒丆三下专丘丆:  世丅丒丆三下专丘丆);
        label_1:
        val_3 = "routine";
        goto label_3;
        label_2:
        val_3 = "promise";
        label_3:
        null = new System.ArgumentNullException(paramName:  val_3);
    }
    private System.Collections.IEnumerator 丐丛丌丁丕丂丝丗丐(System.Collections.IEnumerator 丈不不丁丆世丑专上, System.Threading.Tasks.TaskCompletionSource<bool> 世丅丒丆三下专丘丆)
    {
        CoroutineRunner.丒不专业上三丑丌丐 val_1 = new CoroutineRunner.丒不专业上三丑丌丐();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丈不不丁丆世丑专上 = 丈不不丁丆世丑专上;
        }
        else
        {
                mem[32] = 丈不不丁丆世丑专上;
        }
        
        .世丅丒丆三下专丘丆 = 世丅丒丆三下专丘丆;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 七丘且世丙丅七丘与(System.Collections.IEnumerator 丈不不丁丆世丑专上)
    {
        if(丈不不丁丆世丑专上 == null)
        {
                return;
        }
        
        this.丐丙且丟丟不万万不.Enqueue(item:  丈不不丁丆世丑专上);
    }
    internal static System.Collections.IEnumerator 世不丗东且丆专专丄(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new CoroutineRunner.三上丘丘万丂一丁丘();
    }
    internal static System.Collections.IEnumerator 丞丗丟与不丌万丛丒(float 七且丆丞丌丘下世丑, System.Action 七丐丅专且专七三丆, int 丏丏下丛丆丐丈三丏)
    {
        CoroutineRunner.丛丘万丟丅丐丝万专 val_1 = new CoroutineRunner.丛丘万丟丅丐丝万专();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
            .七丐丅专且专七三丆 = 七丐丅专且专七三丆;
        }
        else
        {
                mem[48] = 七且丆丞丌丘下世丑;
            mem[40] = 七丐丅专且专七三丆;
        }
        
        .丏丏下丛丆丐丈三丏 = 丏丏下丛丆丐丈三丏;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static UnityEngine.Coroutine 丆万七与丏丁丞丂专(System.Func<bool> 且丐丈丕三丟丕丙丒, System.Action 一丏丘业丅丈东东丄)
    {
        CoroutineRunner val_1 = CoroutineRunner.Instance;
        if(val_1 != null)
        {
                return val_1.StartCoroutine(routine:  CoroutineRunner.Instance.不一业丐不丈丌世丑(且丐丈丕三丟丕丙丒:  且丐丈丕三丟丕丙丒, 一丏丘业丅丈东东丄:  一丏丘业丅丈东东丄));
        }
        
        return val_1.StartCoroutine(routine:  CoroutineRunner.Instance.不一业丐不丈丌世丑(且丐丈丕三丟丕丙丒:  且丐丈丕三丟丕丙丒, 一丏丘业丅丈东东丄:  一丏丘业丅丈东东丄));
    }
    private System.Collections.IEnumerator 不一业丐不丈丌世丑(System.Func<bool> 且丐丈丕三丟丕丙丒, System.Action 一丏丘业丅丈东东丄)
    {
        CoroutineRunner.丄七丌丒三丕丏丙丏 val_1 = new CoroutineRunner.丄七丌丒三丕丏丙丏();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .且丐丈丕三丟丕丙丒 = 且丐丈丕三丟丕丙丒;
        }
        else
        {
                mem[32] = 且丐丈丕三丟丕丙丒;
        }
        
        .一丏丘业丅丈东东丄 = 一丏丘业丅丈东东丄;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static void 不万丏与丐业丛丟万(int 业丗七丕万万不丈丗, System.Action 一丏丘业丅丈东东丄)
    {
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  CoroutineRunner.Instance.专七丙上与业丗三万(业丗七丕万万不丈丗:  业丗七丕万万不丈丗, 一丏丘业丅丈东东丄:  一丏丘业丅丈东东丄));
    }
    private System.Collections.IEnumerator 专七丙上与业丗三万(int 业丗七丕万万不丈丗, System.Action 一丏丘业丅丈东东丄)
    {
        CoroutineRunner.丛丂与丛丑上七丝丐 val_1 = new CoroutineRunner.丛丂与丛丑上七丝丐();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .业丗七丕万万不丈丗 = 业丗七丕万万不丈丗;
        }
        else
        {
                mem[32] = 业丗七丕万万不丈丗;
        }
        
        .一丏丘业丅丈东东丄 = 一丏丘业丅丈东东丄;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static UnityEngine.Coroutine 丝世下丆业丘上丆上(float 丙不三七上丑丗丑丏, System.Action 丌专业且丛丏丞丝且)
    {
        CoroutineRunner val_1 = CoroutineRunner.Instance;
        if(val_1 != null)
        {
                return val_1.StartCoroutine(routine:  CoroutineRunner.Instance.万丏七丞七不上三丝(丙不三七上丑丗丑丏:  丙不三七上丑丗丑丏, 丌专业且丛丏丞丝且:  丌专业且丛丏丞丝且));
        }
        
        return val_1.StartCoroutine(routine:  CoroutineRunner.Instance.万丏七丞七不上三丝(丙不三七上丑丗丑丏:  丙不三七上丑丗丑丏, 丌专业且丛丏丞丝且:  丌专业且丛丏丞丝且));
    }
    internal static UnityEngine.Coroutine 丄丝丝丏丗三丙与丁(int 业丗七丕万万不丈丗, System.Action 丌专业且丛丏丞丝且)
    {
        CoroutineRunner val_1 = CoroutineRunner.Instance;
        if(val_1 != null)
        {
                return val_1.StartCoroutine(routine:  CoroutineRunner.Instance.万丏七丞七不上三丝(丅丞与且专且丅丘三:  业丗七丕万万不丈丗, 丌专业且丛丏丞丝且:  丌专业且丛丏丞丝且));
        }
        
        return val_1.StartCoroutine(routine:  CoroutineRunner.Instance.万丏七丞七不上三丝(丅丞与且专且丅丘三:  业丗七丕万万不丈丗, 丌专业且丛丏丞丝且:  丌专业且丛丏丞丝且));
    }
    internal static void 丌丄丏下七丁专丂世(UnityEngine.Coroutine 丂丒丐下丑丏丐专上)
    {
        CoroutineRunner.Instance.StopCoroutine(routine:  丂丒丐下丑丏丐专上);
    }
    internal static UnityEngine.Coroutine 不七丏丝丒一下丄万(float 丂三丟丂丈丐丆丗丟, System.Action 七丐丅专且专七三丆)
    {
        CoroutineRunner val_1 = CoroutineRunner.Instance;
        if(val_1 != null)
        {
                return val_1.StartCoroutine(routine:  CoroutineRunner.丐丁丑丝三丌丝丒丐(丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 七丐丅专且专七三丆:  七丐丅专且专七三丆));
        }
        
        return val_1.StartCoroutine(routine:  CoroutineRunner.丐丁丑丝三丌丝丒丐(丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 七丐丅专且专七三丆:  七丐丅专且专七三丆));
    }
    private static System.Collections.IEnumerator 丐丁丑丝三丌丝丒丐(float 丂三丟丂丈丐丆丗丟, System.Action 七丐丅专且专七三丆)
    {
        CoroutineRunner.丂业丈与业一专丟丞 val_1 = new CoroutineRunner.丂业丈与业一专丟丞();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        }
        else
        {
                mem[40] = 丂三丟丂丈丐丆丗丟;
        }
        
        .七丐丅专且专七三丆 = 七丐丅专且专七三丆;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static UnityEngine.Coroutine Start(System.Collections.IEnumerator 丂丒丐下丑丏丐专上)
    {
        CoroutineRunner val_1 = CoroutineRunner.Instance;
        if(val_1 != null)
        {
                return val_1.StartCoroutine(routine:  丂丒丐下丑丏丐专上);
        }
        
        return val_1.StartCoroutine(routine:  丂丒丐下丑丏丐专上);
    }
    private System.Collections.IEnumerator 万丏七丞七不上三丝(float 丙不三七上丑丗丑丏, System.Action 丌专业且丛丏丞丝且)
    {
        CoroutineRunner.丑丘丟丙万东丁丗不 val_1 = new CoroutineRunner.丑丘丟丙万东丁丗不();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丙不三七上丑丗丑丏 = 丙不三七上丑丗丑丏;
        }
        else
        {
                mem[32] = 丙不三七上丑丗丑丏;
        }
        
        .丌专业且丛丏丞丝且 = 丌专业且丛丏丞丝且;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 万丏七丞七不上三丝(int 丅丞与且专且丅丘三, System.Action 丌专业且丛丏丞丝且)
    {
        CoroutineRunner.丙一万与丂丒上丛三 val_1 = new CoroutineRunner.丙一万与丂丒上丛三();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丅丞与且专且丅丘三 = 丅丞与且专且丅丘三;
        }
        else
        {
                mem[32] = 丅丞与且专且丅丘三;
        }
        
        .丌专业且丛丏丞丝且 = 丌专业且丛丏丞丝且;
        return (System.Collections.IEnumerator)val_1;
    }
    internal System.Collections.IEnumerator 不丕丕丗业丁下东丂(System.Threading.Tasks.Task 东且丘且丟万丘丛丅)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .东且丘且丟万丘丛丅 = 东且丘且丟万丘丛丅;
        return (System.Collections.IEnumerator)new CoroutineRunner.丟丂专丈上一丈东丁();
    }
    public static void DoOnNextFrame(System.Action 七丐丅专且专七三丆)
    {
        UnityEngine.Coroutine val_2 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  CoroutineRunner.不上不丙丒丄下丁上(七丐丅专且专七三丆:  七丐丅专且专七三丆));
    }
    private static System.Collections.IEnumerator 不上不丙丒丄下丁上(System.Action 七丐丅专且专七三丆)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七丐丅专且专七三丆 = 七丐丅专且专七三丆;
        return (System.Collections.IEnumerator)new CoroutineRunner.丐丟专丅与业丐丝业();
    }
    public static UnityEngine.Coroutine DoWithDelay(System.Action 七丐丅专且专七三丆, int 业丗七丕万万不丈丗)
    {
        return CoroutineRunner.Start(丂丒丐下丑丏丐专上:  CoroutineRunner.丏丐丁七业上丒丐丏(七丐丅专且专七三丆:  七丐丅专且专七三丆, 业丗七丕万万不丈丗:  业丗七丕万万不丈丗));
    }
    private static System.Collections.IEnumerator 丏丐丁七业上丒丐丏(System.Action 七丐丅专且专七三丆, int 业丗七丕万万不丈丗)
    {
        CoroutineRunner.不丗与丏丒世专上业 val_1 = new CoroutineRunner.不丗与丏丒世专上业();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .七丐丅专且专七三丆 = 七丐丅专且专七三丆;
        }
        else
        {
                mem[40] = 七丐丅专且专七三丆;
        }
        
        .业丗七丕万万不丈丗 = 业丗七丕万万不丈丗;
        return (System.Collections.IEnumerator)val_1;
    }
    public static UnityEngine.Coroutine DoWithDelay(System.Action 七丐丅专且专七三丆, float 丆丐七丅丆丗丛上与)
    {
        return CoroutineRunner.Start(丂丒丐下丑丏丐专上:  CoroutineRunner.丏丐丁七业上丒丐丏(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丆丐七丅丆丗丛上与:  丆丐七丅丆丗丛上与));
    }
    private static System.Collections.IEnumerator 丏丐丁七业上丒丐丏(System.Action 七丐丅专且专七三丆, float 丆丐七丅丆丗丛上与)
    {
        CoroutineRunner.丂丕三丆世东丄丛万 val_1 = new CoroutineRunner.丂丕三丆世东丄丛万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .七丐丅专且专七三丆 = 七丐丅专且专七三丆;
        }
        else
        {
                mem[40] = 七丐丅专且专七三丆;
        }
        
        .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
        return (System.Collections.IEnumerator)val_1;
    }
    public CoroutineRunner()
    {
        this.丐丙且丟丟不万万不 = new System.Collections.Concurrent.ConcurrentQueue<System.Collections.IEnumerator>();
    }
    private static CoroutineRunner()
    {
    
    }

}
