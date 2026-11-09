using UnityEngine;
internal sealed class UniversalPromotionUI : PGBehaviour
{
    // Fields
    private System.Action 专丙丒丁与丏上世丑;
    private UnityEngine.Transform loadedPromotionViewsHolder;
    private PGCompany.东丑丆丗丏丐丟下丄 下东一丒丌东丛与丗;
    private PGCompany.StorePromotionInfoUIAbstract 丝丒上与丒一丆丏丂;
    private System.Collections.Generic.Dictionary<string, PGCompany.StorePromotionInfoUIAbstract> 一丐七且世万七丝丕;
    
    // Methods
    internal void 不丝丕丈丗丝专丟丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专丙丒丁与丏上世丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丙丒丁与丏上世丑 != 1152921539464354184);
    
    }
    internal void 三丒万丘丗丄丕且丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专丙丒丁与丏上世丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丙丒丁与丏上世丑 != 1152921539464490760);
    
    }
    private void 丑丏上丈丒丂且丞丛()
    {
        if(this.丝丒上与丒一丆丏丂 == 0)
        {
                return;
        }
        
        this.丝丒上与丒一丆丏丂.不丝丕丈丗丝专丟丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionUI::丗世丒丁不且不丐丏()));
    }
    private void 丆七世世丙丗七丝丁()
    {
        if(this.丝丒上与丒一丆丏丂 == 0)
        {
                return;
        }
        
        this.丝丒上与丒一丆丏丂.三丒万丘丗丄丕且丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionUI::丗世丒丁不且不丐丏()));
    }
    internal void 丒丙丘丒丄上三丘与(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        UnityEngine.Object val_18;
        object val_19;
        string val_20;
        string val_21;
        PGCompany.StorePromotionInfoUIAbstract val_22;
        this.丆七世世丙丗七丝丁();
        this.丝丒上与丒一丆丏丂 = 0;
        if(丐丆丝业丙丈下世丁 == null)
        {
            goto label_1;
        }
        
        val_18 = 丐丆丝业丙丈下世丁.不上丒一三丙不丁三();
        if(val_18 != 0)
        {
            goto label_4;
        }
        
        val_19 = "cant show UniversalPromotionView for nullable StorePromotionInfoUIAbstract";
        goto label_7;
        label_1:
        val_19 = "cant show UniversalPromotionView for nullable StorePromotion";
        label_7:
        UnityEngine.Debug.LogError(message:  val_19);
        return;
        label_4:
        this.三丁七丗丞丅丄世丈();
        val_20 = val_18.name;
        if((this.一丐七且世万七丝丕.ContainsKey(key:  val_20)) != false)
        {
                val_21 = val_18.name;
            this.丝丒上与丒一丆丏丂 = this.一丐七且世万七丝丕.Item[val_21];
        }
        else
        {
                if(val_18 != 0)
        {
                PGCompany.StorePromotionInfoUIAbstract val_8 = UnityEngine.Object.Instantiate<PGCompany.StorePromotionInfoUIAbstract>(original:  val_18, parent:  this.loadedPromotionViewsHolder);
            this.丝丒上与丒一丆丏丂 = val_8;
            val_8.gameObject.name = val_18.name;
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丝丒上与丒一丆丏丂.transform);
            int val_15 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丝丒上与丒一丆丏丂.gameObject, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            val_21 = this.丝丒上与丒一丆丏丂;
            val_20 = val_18.name;
            this.一丐七且世万七丝丕.Add(key:  val_20, value:  val_21);
        }
        
        }
        
        this.丑丏上丈丒丂且丞丛();
        if(this.丝丒上与丒一丆丏丂 != null)
        {
                val_22 = this.丝丒上与丒一丆丏丂;
        }
        else
        {
                val_22 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_22, 丏业丟一东丂东丘丛:  true);
    }
    internal void 三丁七丗丞丅丄世丈()
    {
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.一丐七且世万七丝丕.Values.GetEnumerator();
        label_6:
        if((498595640 & 1) == 0)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  0.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private string 丏丝丝丐丆与丈丈七(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        if(丐丆丝业丙丈下世丁 != null)
        {
                return 丐丆丝业丙丈下世丁.丐万丐丌丌丆丒丐丝();
        }
        
        return 丐丆丝业丙丈下世丁.丐万丐丌丌丆丒丐丝();
    }
    private void 丗世丒丁不且不丐丏()
    {
        if(this.专丙丒丁与丏上世丑 == null)
        {
                return;
        }
        
        this.专丙丒丁与丏上世丑.Invoke();
    }
    public UniversalPromotionUI()
    {
        this.一丐七且世万七丝丕 = new System.Collections.Generic.Dictionary<System.String, PGCompany.StorePromotionInfoUIAbstract>();
    }

}
