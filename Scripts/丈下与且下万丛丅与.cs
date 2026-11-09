using UnityEngine;
internal sealed class 丈下与且下万丛丅与 : 东丑丆丗丏丐丟下丄
{
    // Fields
    private static System.Action<丈下与且下万丛丅与> 丐且丌丟丛万丗丙丑;
    private readonly System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> <丝不丕丑一丙专丘三>k__BackingField;
    private readonly PGCompany.DataObjects.丒丈丆丕丅丅丐万与 丂七丝丕下业丂与丕;
    
    // Properties
    internal int 丗丝且丞丒且丁丂丑 { get; }
    internal System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丞丙上丐万上丁丟东 { get; }
    internal override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丌丙丏丄下万万丄上 { get; }
    
    // Methods
    internal static void 七七东专世丘一丆丏(System.Action<丈下与且下万丛丅与> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  丈下与且下万丛丅与.丐且丌丟丛万丗丙丑, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丆丆丑丒丛七不丈丆(System.Action<丈下与且下万丛丅与> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  丈下与且下万丛丅与.丐且丌丟丛万丗丙丑, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal int 三万七与东丄业丐丙()
    {
        if(this.丂七丝丕下业丂与丕 != null)
        {
                return (int)this.丂七丝丕下业丂与丕.丗丝且丞丒且丁丂丑;
        }
        
        return (int)this.丂七丝丕下业丂与丕.丗丝且丞丒且丁丂丑;
    }
    internal System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丝世丑七丂丄丅专不()
    {
        if(this.丂七丝丕下业丂与丕 != null)
        {
                return (System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>)this.丂七丝丕下业丂与丕.下丐丐丁与丂下世七;
        }
        
        return (System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>)this.丂七丝丕下业丂与丕.下丐丐丁与丂下世七;
    }
    internal override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 七万三丟丞丆丞东业()
    {
        return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.<丝不丕丑一丙专丘三>k__BackingField;
    }
    internal 丈下与且下万丛丅与(PGCompany.StorePromotionConfig 上世丏丁世丟世丆业, PGCompany.DataObjects.丒丈丆丕丅丅丐万与 与丒三且三不丙丅丌)
    {
        this.丂七丝丕下业丂与丕 = 与丒三且三不丙丅丌;
        this.<丝不丕丑一丙专丘三>k__BackingField = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_2 = 与丒三且三不丙丅丌.下丐丐丁与丂下世七.GetEnumerator();
        label_6:
        if(((-657303464) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        this.Add(item:  val_3.m_stringLength);
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
    {
        var val_7;
        var val_8;
        val_7 = this;
        PGCompany.StorePromotionSettings val_2 = this.世丈丁业丛上丘丗丐().Settings;
        val_8 = 0;
        if((System.String.IsNullOrEmpty(value:  val_2.TexturePath)) == true)
        {
                return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_5.TexturePath);
        }
        
        val_7 = this.世丈丁业丛上丘丗丐().Settings;
        return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_5.TexturePath);
    }
    internal void 专不丗丈丒丄三三丙()
    {
        if(丈下与且下万丛丅与.丐且丌丟丛万丗丙丑 == null)
        {
                return;
        }
        
        丈下与且下万丛丅与.丐且丌丟丛万丗丙丑.Invoke(obj:  this);
    }

}
