using UnityEngine;
private sealed class ScrollOfferPackDrawer3D.下丒丗丛丝丆丆专丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.CancellationToken 不丒三业下丑不丞业;
    public Rilisoft.ScrollOfferPackDrawer3D 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ScrollOfferPackDrawer3D.下丒丗丛丝丆丆专丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        float val_23;
        UnityEngine.Object val_24;
        UnityEngine.GameObject val_25;
        var val_26;
        UnityEngine.GameObject val_27;
        var val_28;
        int val_29;
        var val_30;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_22 = this.丝且与丝丒丟万丁专.丁丝下丙业丝上丅丂();
        val_23 = 0.02f;
        if(S0 > val_23)
        {
            goto label_4;
        }
        
        val_24 = 0;
        if(this.丝且与丝丒丟万丁专.下丕万丒丟丅下业丆 == val_24)
        {
            goto label_19;
        }
        
        Rilisoft.OfferItem val_3 = this.丝且与丝丒丟万丁专.下丕万丒丟丅下业丆.Item;
        this.丝且与丝丒丟万丁专._itemExtendedView.SetItem(与业下丟丛万丗丑丆:  val_3);
        int val_4 = this.丝且与丝丒丟万丁专.专丄一丏丛丙丛丅丌(丟丄丛专丏丆与丑一:  this.丝且与丝丒丟万丁专.下丕万丒丟丅下业丆);
        if(val_4 == 0)
        {
            goto label_11;
        }
        
        var val_22 = val_3.transform.childCount;
        val_22 = val_22 - 1;
        if(val_4 != val_22)
        {
            goto label_14;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._leftPlus, 丏业丟一东丂东丘丛:  true);
        val_25 = this.丝且与丝丒丟万丁专._rightPlus;
        val_24 = 0;
        goto label_17;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_35;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_19;
        }
        
        val_26 = 1;
        goto label_20;
        label_4:
        if((this.不丒三业下丑不丞业 & 1) != 0)
        {
            goto label_35;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_22;
        }
        
        val_22 = this.丝且与丝丒丟万丁专.丁丝下丙业丝上丅丂();
        goto label_23;
        label_11:
        val_27 = this.丝且与丝丒丟万丁专._leftPlus;
        val_28 = 0;
        goto label_26;
        label_22:
        val_22 = 0.丁丝下丙业丝上丅丂();
        label_23:
        UIWidget val_9 = this.丝且与丝丒丟万丁专.丁丝下丙业丝上丅丂();
        float val_23 = -3f;
        val_23 = UnityEngine.Time.unscaledDeltaTime * val_23;
        val_23 = System.Math.Max(val1:  val_23, val2:  V0.16B + val_23);
        val_29 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_29;
        label_14:
        val_28 = 1;
        val_27 = this.丝且与丝丒丟万丁专._leftPlus;
        label_26:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  true);
        val_25 = this.丝且与丝丒丟万丁专._rightPlus;
        val_24 = 1;
        label_17:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  true);
        label_19:
        val_26 = 0;
        label_20:
        val_22 = this.丝且与丝丒丟万丁专.丁丝下丙业丝上丅丂();
        if(S0 < 0)
        {
                if((this.不丒三业下丑不丞业 & 1) == 0)
        {
            goto label_36;
        }
        
        }
        
        label_35:
        val_29 = 0;
        return (bool)val_29;
        label_36:
        if((val_26 & 1) != 0)
        {
                val_30 = 0.丁丝下丙业丝上丅丂();
        }
        else
        {
                val_30 = this.丝且与丝丒丟万丁专.丁丝下丙业丝上丅丂();
        }
        
        UIWidget val_17 = this.丝且与丝丒丟万丁专.丁丝下丙业丝上丅丂();
        float val_24 = 3f;
        val_24 = UnityEngine.Time.unscaledDeltaTime * val_24;
        float val_20 = System.Math.Min(val1:  1f, val2:  V0.16B + val_24);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_29;
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
