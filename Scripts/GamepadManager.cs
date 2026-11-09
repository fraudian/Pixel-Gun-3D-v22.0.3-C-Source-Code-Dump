using UnityEngine;
internal sealed class GamepadManager : PGBehaviour
{
    // Fields
    internal static GamepadManager 丆丕丝丒不丙且丐丗;
    private static System.Action<丄丐世丆丛世丅上丛> 丘丗丟丐丑上丞丁丏;
    private static System.Action<string> 业专丘丑丞且七丅世;
    private static System.Action<string> 丗丅丙丙丌丛世丝且;
    private static System.Action<string> 丆专下丁万丗丂丅丄;
    internal const string 不万丅丁专丛不万丁 = "Sony Interactive Entertainment Wireless Controller";
    internal const string 丝三丂不丈丛专丙丈 = "Unknown Xbox Wireless Controller";
    private 丄丐世丆丛世丅上丛 万万丈世业一丆丌世;
    private 丟世丝丅丕丟丗七丅 上丒与上丅七且丏世;
    private System.Collections.Generic.List<string> 三丞一丌七东丐丞七;
    private string 丞上丞三上丒七丁世;
    private string 丁丟丐专一丕丄丒万;
    private System.Collections.Generic.Dictionary<string, System.Type> 一丞丈丗丆且丆丏下;
    
    // Properties
    internal string 丑丒东东丑下丆丗万 { get; }
    
    // Methods
    internal static void 丐专且丌丂丐下丞三(System.Action<丄丐世丆丛世丅上丛> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  GamepadManager.丘丗丟丐丑上丞丁丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.丘丗丟丐丑上丞丁丏 != 1152921505203015688);
    
    }
    internal static void 三不丏与上丅丟丈下(System.Action<丄丐世丆丛世丅上丛> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  GamepadManager.丘丗丟丐丑上丞丁丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.丘丗丟丐丑上丞丁丏 != 1152921505203015688);
    
    }
    internal static void 业世丘世丏一丗丗业(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  GamepadManager.业专丘丑丞且七丅世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.业专丘丑丞且七丅世 != 1152921505203015696);
    
    }
    internal static void 七世且丞丄丆上丆业(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  GamepadManager.业专丘丑丞且七丅世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.业专丘丑丞且七丅世 != 1152921505203015696);
    
    }
    internal static void 丆丘丘丏丒世且丆丘(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  GamepadManager.丗丅丙丙丌丛世丝且, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.丗丅丙丙丌丛世丝且 != 1152921505203015704);
    
    }
    internal static void 一业丈丒丂且上丑丆(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  GamepadManager.丗丅丙丙丌丛世丝且, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.丗丅丙丙丌丛世丝且 != 1152921505203015704);
    
    }
    internal static void 丟专与丟丅丑丝丅上(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  GamepadManager.丆专下丁万丗丂丅丄, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.丆专下丁万丗丂丅丄 != 1152921505203015712);
    
    }
    internal static void 万丏丟丐丑丄万丅与(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  GamepadManager.丆专下丁万丗丂丅丄, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GamepadManager.丆专下丁万丗丂丅丄 != 1152921505203015712);
    
    }
    internal string 业七不丞丝丝丂丆丂()
    {
        return (string)this.丞上丞三上丒七丁世;
    }
    private void Awake()
    {
        this.丘上丐世丆丑且丞丒();
    }
    private void 丘上丐世丆丑且丞丒()
    {
        if(GamepadManager.丝三丂不丈丛专丙丈 != 0)
        {
                if(GamepadManager.丝三丂不丈丛专丙丈 != this)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.gameObject);
            return;
        }
        
        }
        
        GamepadManager.丝三丂不丈丛专丙丈 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    private void Update()
    {
    
    }
    private void 丙丂丟不丟不丒丆丗()
    {
    
    }
    private void 丈丗上世丂丅一专丌()
    {
    
    }
    private void 东丛丅且丄下七不丘()
    {
    
    }
    private void 七东丝丙丒丈三丟丈(string[] 东丅丝丏丅丘业万丄)
    {
    
    }
    private void 万丁丂丒丌丌且丌丞(string[] 东丅丝丏丅丘业万丄)
    {
    
    }
    private void 万万丐万七丄丈业丒()
    {
    
    }
    private void 丒丐丘丕丕丆东七丄(string 专丐丈与丙三世丒上)
    {
    
    }
    private void 世下丄七业丅丑东丌(int 且丒丕与丒丑丆丕丏)
    {
    
    }
    public GamepadManager()
    {
        this.三丞一丌七东丐丞七 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.Dictionary<System.String, System.Type> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Type>();
        val_2.Add(key:  "Sony Interactive Entertainment Wireless Controller", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_2.Add(key:  "Unknown Xbox Wireless Controller", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        this.一丞丈丗丆且丆丏下 = val_2;
    }

}
