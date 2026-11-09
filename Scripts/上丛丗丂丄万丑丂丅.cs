using UnityEngine;
private sealed class ReelController.上丛丗丂丄万丑丂丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ReelController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReelController.上丛丗丂丄万丑丂丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_31;
        var val_32;
        var val_33;
        var val_34;
        UnityEngine.GameObject val_35;
        UnityEngine.Transform val_36;
        var val_37;
        var val_38;
        UnityEngine.Transform val_39;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_31 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_31;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.<丞丘丛丈丛世与业东>k__BackingField = true;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_7;
        }
        
        val_32 = 48;
        0.万丝丑七丟不业东东(丞东丆与下丁丆七与:  0);
        val_33 = 1;
        goto label_6;
        label_3:
        mem[128] = 1;
        label_4:
        if(this.丝且与丝丒丟万丁专.丝世丘丁万业七丟丁 != false)
        {
                val_31 = 1;
            this.丝且与丝丒丟万丁专.丝世丘丁万业七丟丁 = false;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_31;
            return (bool)val_31;
        }
        
        label_7:
        val_32 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.万丝丑七丟不业东东(丞东丆与下丁丆七与:  this.丝且与丝丒丟万丁专.丒丐丝业丗不丅万丕);
        val_33 = 0;
        label_6:
        this.丝且与丝丒丟万丁专._scroll.ResetPosition();
        this.丝且与丝丒丟万丁专._wrap.minIndex = 0;
        this.丝且与丝丒丟万丁专._wrap.maxIndex = 0;
        UnityEngine.Transform val_1 = this.丝且与丝丒丟万丁专._wrap.transform;
        if(val_1.childCount >= (this.丝且与丝丒丟万丁专 + 48))
        {
            goto label_14;
        }
        
        goto label_15;
        label_36:
        if(val_1 != null)
        {
                val_34 = val_1.childCount;
        }
        else
        {
                val_34 = 0.childCount;
        }
        
        UnityEngine.Transform val_6 = val_1.GetChild(index:  val_34 - 1);
        UnityEngine.Transform val_7 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_6, parent:  val_1);
        UnityEngine.Vector3 val_9 = val_6.transform.localPosition;
        val_35 = val_6.transform;
        UnityEngine.Vector3 val_11 = val_35.localPosition;
        UnityEngine.Vector3 val_13 = val_6.transform.localPosition;
        float val_31 = (float)this.丝且与丝丒丟万丁专._wrap.itemSize;
        val_31 = val_9.x + val_31;
        UnityEngine.Transform val_14 = val_7.transform;
        val_14.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        val_14.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        val_7.name = "item_" + val_1.childCount - 1(val_1.childCount - 1);
        label_15:
        val_36 = 0;
        if(val_1.childCount < (this.丝且与丝丒丟万丁专 + 48))
        {
            goto label_36;
        }
        
        goto label_39;
        label_14:
        val_36 = 0;
        if(val_1.childCount <= (this.丝且与丝丒丟万丁专 + 48))
        {
            goto label_39;
        }
        
        val_35 = 1152921504848912384;
        goto label_40;
        label_50:
        UnityEngine.Transform val_21 = val_1.GetChild(index:  0);
        val_21.gameObject.SetActive(value:  false);
        if(val_21 != null)
        {
                val_21.SetParent(p:  0);
        }
        else
        {
                0.SetParent(p:  0);
        }
        
        UnityEngine.Object.Destroy(obj:  val_21.gameObject);
        label_40:
        val_36 = 0;
        if(val_1.childCount > (this.丝且与丝丒丟万丁专 + 48))
        {
            goto label_50;
        }
        
        label_39:
        val_37 = 0;
        goto label_51;
        label_59:
        UnityEngine.Transform val_25 = val_1.GetChild(index:  0);
        val_35 = val_25.gameObject;
        val_36 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_35, 丏业丟一东丂东丘丛:  true);
        if(this.丝且与丝丒丟万丁专.丈丘丝丈业丂三丏丆 != null)
        {
                val_36 = val_25;
            this.丝且与丝丒丟万丁专.丈丘丝丈业丂三丏丆.Invoke(arg1:  val_36, arg2:  0);
        }
        
        val_37 = 1;
        label_51:
        if(val_37 < (this.丝且与丝丒丟万丁专 + 48))
        {
            goto label_59;
        }
        
        this.丝且与丝丒丟万丁专._scroll.ResetPosition();
        val_38 = 0;
        label_68:
        if(val_38 >= val_1.childCount)
        {
            goto label_65;
        }
        
        val_35 = this.丝且与丝丒丟万丁专.七丁世丕丕业丛七丆;
        val_39 = val_1.GetChild(index:  0);
        val_38 = val_38 + 1;
        if((val_35.Invoke(arg:  val_39)) == false)
        {
            goto label_68;
        }
        
        goto label_69;
        label_65:
        val_39 = 0;
        label_69:
        if(val_39 != 0)
        {
                this.丝且与丝丒丟万丁专.且丘丝丕专世丕丕丅(丞下万上三丘上与专:  val_39, 丐丐七专三且世三七:  true);
        }
        
        val_31 = 0;
        return (bool)val_31;
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
