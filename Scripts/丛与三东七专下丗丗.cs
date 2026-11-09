using UnityEngine;
internal class 丛与三东七专下丗丗 : IDisposable
{
    // Fields
    private string 丏世丑万世一七丟丞;
    private int 与丏三丘丑丅丑丘与;
    private System.Collections.Generic.List<不上丌世万丁丝丏丆> 且上业丟丕一与三业;
    private UnityEngine.GameObject 业丌丛丛丞丆丕三丙;
    
    // Properties
    internal string 下丄丈不与世丐业专 { get; }
    internal int 丒丘丝丝世与丞与丒 { get; }
    internal System.Collections.Generic.List<不上丌世万丁丝丏丆> 丂万丟不丅不丝专丞 { get; }
    internal bool 与丆与丂丄丞丒丏丑 { get; }
    public UnityEngine.Vector3 丗丞世万东且丘下丗 { get; }
    public UnityEngine.Vector3 东世丘丅丌丏且丂丂 { get; }
    public UnityEngine.GameObject 丗丐丆东丌丁专一丒 { get; }
    
    // Methods
    internal string 业上丙丞丐丄丆丅七()
    {
        return (string)this.丏世丑万世一七丟丞;
    }
    internal int 丛丆东上上丗丗业丕()
    {
        return (int)this.与丏三丘丑丅丑丘与;
    }
    internal System.Collections.Generic.List<不上丌世万丁丝丏丆> 丂丘业丐丕三上七且()
    {
        return (System.Collections.Generic.List<不上丌世万丁丝丏丆>)this.且上业丟丕一与三业;
    }
    internal bool 丆世丆东三专东东三()
    {
        var val_2 = null;
        if((丛与三东七专下丗丗.<>c.<>9__10_0) != null)
        {
                if(this.且上业丟丕一与三业 == null)
        {
                return this.且上业丟丕一与三业.Exists(match:  丛与三东七专下丗丗.<>c.<>9__10_0);
        }
        
            return this.且上业丟丕一与三业.Exists(match:  丛与三东七专下丗丗.<>c.<>9__10_0);
        }
        
        丛与三东七专下丗丗.<>c.<>9__10_0 = new System.Predicate<不上丌世万丁丝丏丆>(object:  丛与三东七专下丗丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛与三东七专下丗丗.<>c::丈丆丈且与丞下三丈(不上丌世万丁丝丏丆 三丟东丕丄丄下下丑));
        if(this.且上业丟丕一与三业 != null)
        {
                return this.且上业丟丕一与三业.Exists(match:  丛与三东七专下丗丗.<>c.<>9__10_0);
        }
        
        return this.且上业丟丕一与三业.Exists(match:  丛与三东七专下丗丗.<>c.<>9__10_0);
    }
    internal void 丈且东丑丂且万丒丅(string 丞丅上丏丂且下丅与, System.Collections.Generic.List<不上丌世万丁丝丏丆> 丂丗丏丈万业丅丕且)
    {
        this.丏世丑万世一七丟丞 = 丞丅上丏丂且下丅与;
        this.且上业丟丕一与三业 = 丂丗丏丈万业丅丕且;
        char[] val_1 = new char[1];
        val_1[0] = '-';
        this.与丏三丘丑丅丑丘与 = 丞东丑专丛丆丄丝世.与丛丆专东丐一且丅<System.Int32>(丙业与丙丗丝不丈东:  System.Linq.Enumerable.Last<System.String>(source:  丞丅上丏丂且下丅与.Split(separator:  val_1)));
    }
    public UnityEngine.Vector3 丌丆业专三万丁丒丒()
    {
        var val_4;
        float val_17;
        float val_18;
        float val_19;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_17 = val_1.x;
        val_18 = val_1.y;
        val_19 = val_1.z;
        List.Enumerator<T> val_2 = this.且上业丟丕一与三业.GetEnumerator();
        goto label_8;
        label_14:
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5.丑丕丞三三世丑丅丝() != 0)
        {
                UnityEngine.Vector3 val_10 = val_5.丑丕丞三三世丑丅丝().transform.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_17 = val_11.x;
            val_18 = val_11.y;
            val_19 = val_11.z;
        }
        
        label_8:
        if((2119982192 & 1) != 0)
        {
            goto label_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19}, d:  (float)this.且上业丟丕一与三业.Count);
        return new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
    }
    public UnityEngine.Vector3 丄丏丘丆丏世丗丟万()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        int val_2 = this.与丏三丘丑丅丑丘与;
        val_2 = val_2 * 60;
        val_2 = val_2 - 60;
        return new UnityEngine.Vector3() {x = val_1.x, y = (float)val_2, z = val_1.z};
    }
    internal void 丅一丁上上世丄三丏(bool 丝三丄专丗丞丄丄丌)
    {
        UnityEngine.Vector3 val_3 = this.丄丏丘丆丏世丗丟万();
        this.丂丕丏丅不丑丐丌丗().transform.eulerAngles = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_6 = this.丌丆业专三万丁丒丒();
        this.丂丕丏丅不丑丐丌丗().transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.丂丕丏丅不丑丐丌丗().SetActive(value:  丝三丄专丗丞丄丄丌);
    }
    public UnityEngine.GameObject 丂丕丏丅不丑丐丌丗()
    {
        UnityEngine.GameObject val_4;
        if(this.业丌丛丛丞丆丕三丙 == 0)
        {
                this.业丌丛丛丞丆丕三丙 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans/War/Prefabs/FortSelectionIndicator"));
            return val_4;
        }
        
        val_4 = this.业丌丛丛丞丆丕三丙;
        return val_4;
    }
    public void Dispose()
    {
        if(this.业丌丛丛丞丆丕三丙 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.业丌丛丛丞丆丕三丙);
    }
    public 丛与三东七专下丗丗()
    {
    
    }

}
