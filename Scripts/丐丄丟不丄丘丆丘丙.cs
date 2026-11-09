using UnityEngine;
private sealed class 三一丈七且丄与丝东.丐丄丟不丄丘丆丘丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.三一丈七且丄与丝东 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 三一丈七且丄与丝东.丐丄丟不丄丘丆丘丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_26;
        三一丈七且丄与丝东.丐丄丟不丄丘丆丘丙 val_27;
        UnityEngine.WaitForSeconds val_28;
        int val_29;
        var val_30;
        var val_31;
        System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_33;
        System.Collections.Generic.IEnumerable<TSource> val_34;
        System.Collections.Generic.List<System.Int32> val_38;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_27 = this;
        if((this.丗丏丅丕丆世丁专丟 == 2) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if(this.丝且与丝丒丟万丁专.且丞丄丂丏丝三丙丌() == false)
        {
            goto label_7;
        }
        
        if(this.丝且与丝丒丟万丁专.丌下东丛万丁丂丁丟 == null)
        {
            goto label_86;
        }
        
        List.Enumerator<T> val_2 = this.丝且与丝丒丟万丁专.丌下东丛万丁丂丁丟.GetEnumerator();
        label_12:
        if(((-318448304) & 1) == 0)
        {
            goto label_10;
        }
        
        val_4.丐丏七丌丕丗业且上().与丄丂且下丄丑丑丑();
        goto label_12;
        label_7:
        val_28 = 0;
        val_29 = 2;
        goto label_13;
        label_3:
        val_30 = 0;
        return (bool)val_30;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_31 = null;
        val_31 = null;
        val_33 = 三一丈七且丄与丝东.<>c.<>9__69_0;
        if(val_33 == null)
        {
                System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_6 = null;
            val_33 = val_6;
            val_6 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  三一丈七且丄与丝东.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 三一丈七且丄与丝东.<>c::世丂且丅一丙丙专丆(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
            三一丈七且丄与丝东.<>c.<>9__69_0 = val_33;
        }
        
        val_34 = System.Linq.Enumerable.Where<Rilisoft.丛且世丐丆上七业丁>(source:  this.丝且与丝丒丟万丁专.丌下东丛万丁丂丁丟, predicate:  val_6);
        var val_28 = 0;
        val_28 = val_28 + 1;
        System.Collections.Generic.IEnumerator<T> val_9 = val_34.GetEnumerator();
        label_48:
        label_45:
        var val_29 = 0;
        val_29 = val_29 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_36;
        }
        
        var val_30 = 0;
        val_30 = val_30 + 1;
        T val_13 = val_9.Current;
        if((this.丝且与丝丒丟万丁专.专丏业丂丈丄不不一.Contains(item:  val_13.丅丙丛丑丌丆丌丕丒())) == true)
        {
            goto label_45;
        }
        
        this.丝且与丝丒丟万丁专.专丏业丂丈丄不不一.Add(item:  val_13.丅丙丛丑丌丆丌丕丒());
        goto label_48;
        label_36:
        val_26 = 0;
        val_38 = 0;
        if(val_9 == null)
        {
            
        }
        else
        {
                var val_31 = 0;
            val_31 = val_31 + 1;
            val_9.Dispose();
        }
        
        if( == 1)
        {
            goto label_63;
        }
        
        if(( == false) || (250 == 250))
        {
            goto label_92;
        }
        
        label_91:
        label_92:
        if(this.丝且与丝丒丟万丁专.专丏业丂丈丄不不一.Count <= (System.Linq.Enumerable.Count<Rilisoft.丛且世丐丆上七业丁>(source:  val_34)))
        {
            goto label_68;
        }
        
        val_26 = 1152921542943066864;
        val_34 = 1152921538020187824;
        val_40 = 0;
        goto label_69;
        label_75:
        .丞丅上丏丂且下丅与 = this.丝且与丝丒丟万丁专.专丏业丂丈丄不不一.Item[0];
        if((System.Linq.Enumerable.All<Rilisoft.丛且世丐丆上七业丁>(source:  val_34, predicate:  new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  new 三一丈七且丄与丝东.丞丙丛丂上一丆丛万(), method:  System.Boolean 三一丈七且丄与丝东.丞丙丛丂上一丆丛万::丈丟七丌世丈丐不万(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且)))) != false)
        {
                bool val_24 = this.丝且与丝丒丟万丁专.专丏业丂丈丄不不一.Remove(item:  (三一丈七且丄与丝东.丞丙丛丂上一丆丛万)[1152921542943189488].丞丅上丏丂且下丅与);
        }
        
        val_40 = 1;
        label_69:
        val_38 = this.丝且与丝丒丟万丁专.专丏业丂丈丄不不一;
        if(val_40 < val_38.Count)
        {
            goto label_75;
        }
        
        val_27 = val_27;
        label_68:
        if((1 & 1) != 0)
        {
                BalanceController.丙丏丂下丂上七不一();
            val_41 = null;
            val_41 = null;
            if(Rilisoft.三一丈七且丄与丝东.丌上丛丅世下东丑业 != null)
        {
                Rilisoft.三一丈七且丄与丝东.丌上丛丅世下东丑业.Invoke();
        }
        
            val_26 = 1152921505205194752;
            val_42 = null;
            val_42 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_43 = null;
            val_43 = null;
            GiftController.丆丕丝丒不丙且丐丗.ReCreateSlotsIfPossible();
        }
        
        }
        
        label_86:
        val_28 = this.三丛与七下专丅丕东;
        if(val_28 == null)
        {
                UnityEngine.WaitForSeconds val_27 = null;
            val_28 = val_27;
            val_27 = new UnityEngine.WaitForSeconds(seconds:  1f);
            mem[1152921542943116504] = val_28;
        }
        
        val_29 = 1;
        label_13:
        val_30 = 1;
        mem[1152921542943116488] = val_28;
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_30;
        label_63:
        if( == true)
        {
            goto label_91;
        }
        
        goto label_92;
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
