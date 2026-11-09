using UnityEngine;
private sealed class MiniBannerPromotionView.丐丑三与且丕丛丂丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.MiniBannerPromotionView 丝且与丝丒丟万丁专;
    private float 与不丂业且上上上丄;
    private float 与不上一丌专丆一丂;
    private float 丅丈丟万三七丑专上;
    private int 且丌下丌与丏东丕丒;
    private UIWidget 丏三万世丒丐丛业万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MiniBannerPromotionView.丐丑三与且丕丛丂丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.MiniBannerPromotionView val_40;
        var val_41;
        var val_42;
        float val_43;
        float val_45;
        int val_46;
        PGCompany.StorePromotionConfig val_47;
        UIWidget val_48;
        var val_49;
        val_40 = this.丝且与丝丒丟万丁专;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_40 == null)
        {
            goto label_2;
        }
        
        val_41 = 0;
        goto label_8;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_4;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.与不丂业且上上上丄 = 1.701412E+38f;
        this.与不上一丌专丆一丂 = 0.5f;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专._oneItemContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专._twoItemsContainer, 丏业丟一东丂东丘丛:  false);
        val_41 = 0;
        this.丅丈丟万三七丑专上 = 0f;
        this.且丌下丌与丏东丕丒 = 0;
        this.丏三万世丒丐丛业万 = 0;
        goto label_8;
        label_4:
        val_42 = 0;
        return (bool)val_42;
        label_2:
        val_41 = 1;
        label_8:
        if((val_40.gameObject.activeInHierarchy == false) || (this.丝且与丝丒丟万丁专.三下丙与且且不万丞 == null))
        {
            goto label_13;
        }
        
        val_43 = this.丅丈丟万三七丑专上;
        val_45 = val_43 - UnityEngine.Time.deltaTime;
        this.丅丈丟万三七丑专上 = val_45;
        if(this.丏三万世丒丐丛业万 == 0)
        {
            goto label_30;
        }
        
        PGCompany.StorePromotionSettings val_6 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        val_43 = 1f;
        if(val_6.ItemsParams.Count < 3)
        {
            goto label_24;
        }
        
        float val_39 = this.与不丂业且上上上丄;
        val_45 = this.与不上一丌专丆一丂;
        float val_40 = this.丅丈丟万三七丑专上;
        val_39 = val_39 - val_45;
        if(val_40 <= val_39)
        {
            goto label_21;
        }
        
        val_40 = val_40 - val_39;
        val_40 = val_45 - val_40;
        val_43 = val_40 / val_45;
        goto label_24;
        label_13:
        val_46 = 1;
        goto label_23;
        label_21:
        if(val_40 <= val_45)
        {
                val_45 = 0f;
            float val_9 = UnityEngine.Mathf.Lerp(a:  val_45, b:  1f, t:  val_40 / val_45);
            val_43 = val_9;
        }
        
        label_24:
        bool val_10 = 丞东丑专丛丆丄丝世.丙下且丒丑东丑丞丈(与丕丁三万专世不丅:  val_9, 丘丛丏丘丝七世七丅:  val_43);
        label_30:
        if(this.丅丈丟万三七丑专上 > 0f)
        {
            goto label_63;
        }
        
        this.丅丈丟万三七丑专上 = this.与不丂业且上上上丄;
        this.且丌下丌与丏东丕丒 = this.且丌下丌与丏东丕丒 + 1;
        PGCompany.东丑丒丗一丞下丙丙<T> val_12 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
        PGCompany.StorePromotionSettings val_13 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        int val_14 = val_13.ItemsParams.Count;
        PGCompany.StorePromotionSettings val_15 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        if(val_15.ItemsParams.Count != 1)
        {
            goto label_42;
        }
        
        val_47 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞;
        val_48 = this.丝且与丝丒丟万丁专._oneItemContainer;
        PGCompany.StorePromotionSettings val_17 = val_47.Settings;
        val_40 = val_17.ItemsParams.Item[0];
        val_49 = public System.Void System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::Add(PGCompany.三东丏不丗世丅丌丄 item);
        goto label_47;
        label_42:
        PGCompany.StorePromotionSettings val_19 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        if(val_19.ItemsParams.Count == 2)
        {
            goto label_51;
        }
        
        int val_41 = this.且丌下丌与丏东丕丒;
        var val_21 = (val_41 < 0) ? (val_41 + 1) : (val_41);
        val_21 = val_21 & 4294967294;
        val_41 = val_41 - val_21;
        if(val_41 != 1)
        {
            goto label_52;
        }
        
        label_51:
        val_48 = this.丝且与丝丒丟万丁专._twoItemsContainer;
        PGCompany.StorePromotionSettings val_22 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        val_47 = val_22.ItemsParams.Item[0];
        val_12.Add(item:  val_47);
        PGCompany.StorePromotionSettings val_24 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        label_94:
        val_40 = val_24.ItemsParams.Item[1];
        val_49 = public System.Void System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::Add(PGCompany.三东丏不丗世丅丌丄 item);
        label_47:
        val_12.Add(item:  val_40);
        label_90:
        if(val_48 == 0)
        {
            goto label_63;
        }
        
        if(this.丏三万世丒丐丛业万 != 0)
        {
                if(this.丏三万世丒丐丛业万 != val_48)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丏三万世丒丐丛业万, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        this.丏三万世丒丐丛业万 = val_48;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_48, 丏业丟一东丂东丘丛:  true);
        val_40 = 0;
        goto label_74;
        label_81:
        val_47 = val_12.Item[0];
        val_48.transform.GetChild(index:  0).GetComponent<PGCompany.InventoryItemView>().Setup(丈丄不七三万丄丁不:  val_47);
        val_40 = 1;
        label_74:
        if(val_40 < val_12.Count)
        {
            goto label_81;
        }
        
        label_63:
        val_46 = 2;
        label_23:
        val_42 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_46;
        return (bool)val_42;
        label_52:
        PGCompany.StorePromotionSettings val_34 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        val_12.Add(item:  val_34.ItemsParams.Item[2]);
        PGCompany.StorePromotionSettings val_36 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        if(val_36.ItemsParams.Count >= 4)
        {
            goto label_89;
        }
        
        goto label_90;
        label_89:
        PGCompany.StorePromotionSettings val_38 = this.丝且与丝丒丟万丁专.三下丙与且且不万丞.Settings;
        if(val_38.ItemsParams != null)
        {
            goto label_94;
        }
        
        goto label_94;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
