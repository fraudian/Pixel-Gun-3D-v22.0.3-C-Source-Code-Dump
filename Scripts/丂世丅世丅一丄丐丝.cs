using UnityEngine;
private sealed class TierBundleLobbyBanner.丂世丅世丅一丄丐丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TierBundleLobbyBanner 丝且与丝丒丟万丁专;
    private float 与不丂业且上上上丄;
    private float 与不上一丌专丆一丂;
    private float 丅丈丟万三七丑专上;
    private int 且丌下丌与丏东丕丒;
    private UIWidget 丏三万世丒丐丛业万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TierBundleLobbyBanner.丂世丅世丅一丄丐丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.TierBundleLobbyBanner val_30;
        var val_31;
        var val_32;
        float val_33;
        float val_35;
        UnityEngine.Object val_36;
        int val_37;
        PGCompany.丒丌业一丕丘丐世专 val_38;
        UIWidget val_39;
        var val_40;
        val_30 = this.丝且与丝丒丟万丁专;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_30 == null)
        {
            goto label_2;
        }
        
        val_31 = 0;
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
        val_31 = 0;
        this.丅丈丟万三七丑专上 = 0f;
        this.且丌下丌与丏东丕丒 = 0;
        this.丏三万世丒丐丛业万 = 0;
        goto label_8;
        label_4:
        val_32 = 0;
        return (bool)val_32;
        label_2:
        val_31 = 1;
        label_8:
        if((val_30.gameObject.activeInHierarchy == false) || (this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕 == null))
        {
            goto label_13;
        }
        
        val_33 = this.丅丈丟万三七丑专上;
        val_35 = val_33 - UnityEngine.Time.deltaTime;
        this.丅丈丟万三七丑专上 = val_35;
        val_36 = 0;
        if(this.丏三万世丒丐丛业万 == val_36)
        {
            goto label_29;
        }
        
        val_33 = 1f;
        if(this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Count < 3)
        {
            goto label_23;
        }
        
        float val_29 = this.与不丂业且上上上丄;
        val_35 = this.与不上一丌专丆一丂;
        float val_30 = this.丅丈丟万三七丑专上;
        val_29 = val_29 - val_35;
        if(val_30 <= val_29)
        {
            goto label_20;
        }
        
        val_30 = val_30 - val_29;
        val_30 = val_35 - val_30;
        val_33 = val_30 / val_35;
        goto label_23;
        label_13:
        val_37 = 1;
        goto label_22;
        label_20:
        if(val_30 <= val_35)
        {
                val_35 = 0f;
            float val_8 = UnityEngine.Mathf.Lerp(a:  val_35, b:  1f, t:  val_30 / val_35);
            val_33 = val_8;
        }
        
        label_23:
        bool val_9 = 丞东丑专丛丆丄丝世.丙下且丒丑东丑丞丈(与丕丁三万专世不丅:  val_8, 丘丛丏丘丝七世七丅:  val_33);
        label_29:
        if(this.丅丈丟万三七丑专上 > 0f)
        {
            goto label_56;
        }
        
        this.丅丈丟万三七丑专上 = this.与不丂业且上上上丄;
        this.且丌下丌与丏东丕丒 = this.且丌下丌与丏东丕丒 + 1;
        PGCompany.东丑丒丗一丞下丙丙<T> val_11 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
        int val_12 = this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Count;
        if(this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Count != 1)
        {
            goto label_39;
        }
        
        val_38 = this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕;
        val_39 = this.丝且与丝丒丟万丁专._oneItemContainer;
        val_30 = val_38.Item[0];
        val_40 = public System.Void System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::Add(PGCompany.三东丏不丗世丅丌丄 item);
        goto label_43;
        label_39:
        if(this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Count == 2)
        {
            goto label_46;
        }
        
        int val_31 = this.且丌下丌与丏东丕丒;
        var val_16 = (val_31 < 0) ? (val_31 + 1) : (val_31);
        val_16 = val_16 & 4294967294;
        val_31 = val_31 - val_16;
        if(val_31 != 1)
        {
            goto label_47;
        }
        
        label_46:
        val_39 = this.丝且与丝丒丟万丁专._twoItemsContainer;
        val_38 = this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Item[0];
        val_11.Add(item:  val_38);
        label_84:
        val_30 = this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Item[1];
        val_40 = public System.Void System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::Add(PGCompany.三东丏不丗世丅丌丄 item);
        label_43:
        val_11.Add(item:  val_30);
        label_81:
        if(val_39 == 0)
        {
            goto label_56;
        }
        
        if(this.丏三万世丒丐丛业万 != 0)
        {
                if(this.丏三万世丒丐丛业万 != val_39)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丏三万世丒丐丛业万, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        this.丏三万世丒丐丛业万 = val_39;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_39, 丏业丟一东丂东丘丛:  true);
        val_30 = 0;
        goto label_67;
        label_74:
        val_38 = val_11.Item[0];
        val_39.transform.GetChild(index:  0).GetComponent<PGCompany.InventoryItemView>().Setup(丈丄不七三万丄丁不:  val_38);
        val_30 = 1;
        label_67:
        if(val_30 < val_11.Count)
        {
            goto label_74;
        }
        
        label_56:
        val_37 = 2;
        label_22:
        val_32 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_37;
        return (bool)val_32;
        label_47:
        val_11.Add(item:  this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Item[2]);
        if(this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕.Count >= 4)
        {
            goto label_80;
        }
        
        goto label_81;
        label_80:
        if(this.丝且与丝丒丟万丁专.丂丅七与丘丞丟万丕 != null)
        {
            goto label_84;
        }
        
        goto label_84;
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
