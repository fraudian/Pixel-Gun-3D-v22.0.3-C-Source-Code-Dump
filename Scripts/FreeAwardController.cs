using UnityEngine;
internal sealed class FreeAwardController : MonoBehaviour
{
    // Fields
    private static FreeAwardController 世丒丞七专三与万丕;
    public UnityEngine.Camera renderCamera;
    private UICamera 丄丝且业丙丞专丟丑;
    private static System.EventHandler 丙丙丌丝专丁丄与丁;
    
    // Properties
    internal UICamera 世专七不丟丒丄丙七 { get; }
    internal static bool 丙与丟丁丕丂丏七且 { get; }
    internal static FreeAwardController 丆丕丝丒不丙且丐丗 { get; }
    private FreeAwardController.丙丟与丐三丐万万丆 上丅丑丌丑丏丏丙东 { get; }
    
    // Methods
    internal UICamera 三下丒丅丟丞丁七一()
    {
        if(this.丄丝且业丙丞专丟丑 != 0)
        {
                return (UICamera)this.丄丝且业丙丞专丟丑;
        }
        
        if(this.renderCamera == 0)
        {
                return (UICamera)this.丄丝且业丙丞专丟丑;
        }
        
        this.丄丝且业丙丞专丟丑 = this.renderCamera.GetComponent<UICamera>();
        return (UICamera)this.丄丝且业丙丞专丟丑;
    }
    internal static void 丞丑与丂丒丌丒上丐(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  FreeAwardController.丙丙丌丝专丁丄与丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreeAwardController.丙丙丌丝专丁丄与丁 != 1152921505178415112);
    
    }
    internal static void 万丄丝丞丛丆下丂丕(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  FreeAwardController.丙丙丌丝专丁丄与丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreeAwardController.丙丙丌丝专丁丄与丁 != 1152921505178415112);
    
    }
    internal static bool 丁丈丐万万一丕丞丄()
    {
        return true;
    }
    internal static FreeAwardController 丑七不且上丗丁一世()
    {
        return (FreeAwardController)FreeAwardController.世丒丞七专三与万丕;
    }
    public bool IsInState<T>()
    {
        return (bool)(this.万丘三丘下与与且业() != 0) ? 1 : 0;
    }
    private FreeAwardController.丙丟与丐三丐万万丆 万丘三丘下与与且业()
    {
        return FreeAwardController.下丝丒东丟丂一七世.丑七不且上丗丁一世();
    }
    internal bool 丒丘丛丏丗专一丁上()
    {
        return false;
    }
    private void Awake()
    {
        if(FreeAwardController.世丒丞七专三与万丕 != 0)
        {
                return;
        }
        
        FreeAwardController.世丒丞七专三与万丕 = this;
    }
    private void OnDestroy()
    {
        FreeAwardController.世丒丞七专三与万丕 = 0;
    }
    internal static bool 丆万丂丝丟丄七世且(string 丅专与丒丈丗丒丘丌, out System.Collections.Generic.KeyValuePair<System.DateTime, int> 一世上丟专丗丝丄丁)
    {
        var val_11;
        string val_2 = 0;
        一世上丟专丗丝丄丁.Value = 0;
        mem[1152921537260241236] = 0;
        mem[1152921537260241240] = 0;
        if((PGCompany.丆丁业万丁七专且东.下丆与与丛丕丄丌丕(下上丐丆丝丟丝丒不:  PGCompany.Ads.且世丒丅三丏与丁丐.七丄与丑丘丕一丛三(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌), 丙业与丙丗丝不丈东: out  val_2)) != false)
        {
                object val_4 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_2);
            if(val_4 == null)
        {
                return (bool)val_11;
        }
        
            System.Collections.Generic.IEnumerable<TSource> val_5 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_4) : 0;
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    public static int GetAdvertCountDuringCurrentPeriod(string 丅专与丒丈丗丒丘丌, System.DateTime 与三丂丆丗东下丐丙)
    {
        var val_2;
        if((FreeAwardController.丆万丂丝丟丄七世且(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 一世上丟专丗丝丄丁: out  new System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32>())) != false)
        {
                val_2;
            return (int)val_2;
        }
        
        val_2 = 0;
        return (int)val_2;
    }
    internal static System.Collections.Generic.KeyValuePair<System.DateTime, int> 且丑丂不丑上七丂丈(string 丅专与丒丈丗丒丘丌)
    {
        var val_3;
        if((FreeAwardController.丆万丂丝丟丄七世且(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 一世上丟专丗丝丄丁: out  new System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32>())) != false)
        {
                return 0;
        }
        
        val_3 = 0;
        return 0;
    }
    internal static void 丗丑三三丘丘丏丄七(string 丅专与丒丈丗丒丘丌, System.Collections.Generic.KeyValuePair<string, int> 一世上丟专丗丝丄丁)
    {
        var val_1;
        FreeAwardController.丕世不一丟专丘丏且(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 一世上丟专丗丝丄丁:  new System.Collections.Generic.KeyValuePair<System.String, System.Int32>() {Value = 一世上丟专丗丝丄丁.Value});
        if(FreeAwardController.丙丙丌丝专丁丄与丁 == null)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        FreeAwardController.丙丙丌丝专丁丄与丁.Invoke(sender:  0, e:  System.EventArgs.Empty);
    }
    private static void 丕世不一丟专丘丏且(string 丅专与丒丈丗丒丘丌, System.Collections.Generic.KeyValuePair<string, int> 一世上丟专丗丝丄丁)
    {
        if((System.String.IsNullOrEmpty(value:  一世上丟专丗丝丄丁.Value.丐丏七丌丕丗业且上())) == true)
        {
                return;
        }
        
        string[] val_3 = new string[5];
        val_3[0] = "{ \"";
        val_3[1] = 一世上丟专丗丝丄丁.Value.丐丏七丌丕丗业且上();
        val_3[2] = "\":";
        val_3[3] = 一世上丟专丗丝丄丁.Value.ToString();
        1152921524529905312 = " }";
        val_3[4] = 1152921524529905312;
        PGCompany.丆丁业万丁七专且东.且且世专与丒丌专世(下上丐丆丝丟丝丒不:  PGCompany.Ads.且世丒丅三丏与丁丐.七丄与丑丘丕一丛三(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌), 丙业与丙丗丝不丈东:  +val_3);
    }
    public FreeAwardController()
    {
    
    }

}
