using UnityEngine;
private sealed class Switcher.上丆丂丆下丞专业丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Switcher 丝且与丝丒丟万丁专;
    private bool 世且上丛上万丑丏丝;
    private System.Collections.Generic.IEnumerator<float> 业东东下丘丒丝业专;
    private Rilisoft.丅丞丈丅东丆与世丈 丒与不丕东七丂上不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Switcher.上丆丂丆下丞专业丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_4 = this.丗丏丅丕丆世丁专丟;
        val_4 = val_4 + 5;
        if(val_4 > 7)
        {
                return;
        }
        
        var val_5 = 106015360 + ((this.丗丏丅丕丆世丁专丟 + 5)) << 2;
        val_5 = val_5 + 106015360;
        goto (106015360 + ((this.丗丏丅丕丆世丁专丟 + 5)) << 2 + 106015360);
    }
    private bool MoveNext()
    {
        var val_20;
        System.Collections.Generic.IEnumerator<System.Single> val_21;
        System.Collections.Generic.IEnumerator<System.Single> val_22;
        var val_25;
        var val_28;
        int val_29;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_102;
        }
        
        val_20 = this;
        val_21 = this.业东东下丘丒丝业专;
        goto label_4;
        label_2:
        val_20 = this;
        val_22 = this.业东东下丘丒丝业专;
        this.丗丏丅丕丆世丁专丟 = -5;
        if(val_22 != null)
        {
            goto label_54;
        }
        
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丏东丅一丏东丆丌且();
        this.丝且与丝丒丟万丁专.上丕专上且上丕万丘 = 0f;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start Switcher");
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                Switcher.专且丏丕丁上丌万丕();
        }
        
        三丁丒丞丐丂丗不东.三丑丛丄万丟丄丞丁();
        this.世且上丛上万丑丏丝 = false;
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_21 = this.丝且与丝丒丟万丁专.InitializeSwitcher().GetEnumerator();
        val_20 = this;
        this.业东东下丘丒丝业专 = val_21;
        label_4:
        this.丗丏丅丕丆世丁专丟 = -3;
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(val_21.MoveNext() == false)
        {
            goto label_27;
        }
        
        var val_28 = mem[val_5];
        if((mem[val_5] + 286) == 0)
        {
            goto label_32;
        }
        
        var val_25 = mem[val_5] + 176;
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_31:
        if(((mem[val_5] + 176 + 8) + -8) == null)
        {
            goto label_30;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < (mem[val_5] + 286))
        {
            goto label_31;
        }
        
        goto label_32;
        label_27:
        this.一世丕丕业且且丅丌();
        this.业东东下丘丒丝业专 = 0;
        bool val_9 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        mem[1152921540453936872] = 0;
        this.丗丏丅丕丆世丁专丟 = -4;
        this.丒与不丕东七丂上不 = 0;
        var val_27 = 0;
        val_27 = val_27 + 1;
        goto label_40;
        label_30:
        val_28 = val_28 + (((mem[val_5] + 176 + 8)) << 4);
        val_25 = val_28 + 296;
        label_32:
        T val_11 = this.业东东下丘丒丝业专.Current;
        float val_29 = this.丝且与丝丒丟万丁专.上丕专上且上丕万丘;
        val_29 = val_29 * 100f;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Progress " + val_29);
        val_22 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        this.丝且与丝丒丟万丁专.上丕专上且上丕万丘 = val_22;
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  val_22);
        if((this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄 <= 0.25f) || (this.世且上丛上万丑丏丝 == true))
        {
            goto label_53;
        }
        
        this.世且上丛上万丑丏丝 = true;
        val_22 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_22.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                if(Rilisoft.丐丌丝七下丈丒丅丗.丕万世丄丄七丐丘丈() == false)
        {
            goto label_52;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丛不不丕丘丒一万东 = true;
        goto label_53;
        label_40:
        val_22 = this.丝且与丝丒丟万丁专.LoadMainMenu().GetEnumerator();
        this.业东东下丘丒丝业专 = val_22;
        this.丗丏丅丕丆世丁专丟 = -5;
        if(val_22 != null)
        {
            goto label_54;
        }
        
        label_6:
        label_54:
        var val_30 = 0;
        val_30 = val_30 + 1;
        if(val_22.MoveNext() == false)
        {
            goto label_59;
        }
        
        var val_33 = mem[val_17];
        if((mem[val_17] + 286) == 0)
        {
            goto label_64;
        }
        
        var val_31 = mem[val_17] + 176;
        var val_32 = 0;
        val_31 = val_31 + 8;
        label_63:
        if(((mem[val_17] + 176 + 8) + -8) == null)
        {
            goto label_62;
        }
        
        val_32 = val_32 + 1;
        val_31 = val_31 + 16;
        if(val_32 < (mem[val_17] + 286))
        {
            goto label_63;
        }
        
        goto label_64;
        label_59:
        this.七三世丕业世业万丑();
        this.业东东下丘丒丝业专 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_29 = 0;
        mem2[0] = false;
        与丒丕丁下世东丅丌 = false;
        mem[1] = 0;
        return (bool)val_29;
        label_62:
        val_33 = val_33 + (((mem[val_17] + 176 + 8)) << 4);
        val_28 = val_33 + 296;
        label_64:
        T val_20 = this.业东东下丘丒丝业专.Current;
        float val_34 = this.丝且与丝丒丟万丁专.上丕专上且上丕万丘;
        val_34 = val_34 * 100f;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Progress " + val_34);
        val_22 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        this.丝且与丝丒丟万丁专.上丕专上且上丕万丘 = val_22;
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  val_22);
        this.丒上七丌业七丟与丐 = 0f;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_29 = 1;
        return (bool)val_29;
        label_52:
        this.丝且与丝丒丟万丁专.丌且世丒不丁七丟上 = 与丂丏丛丞丞丒丟丄.丗丄丛丆七丁丗丗专();
        label_53:
        this.丒上七丌业七丟与丐 = V0.16B;
        val_29 = 1;
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_29;
        label_102:
        val_29 = 0;
        return (bool)val_29;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.业东东下丘丒丝业专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.业东东下丘丒丝业专.Dispose();
    }
    private void 且丆与丗丏三专丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
    }
    private void 七三世丕业世业万丑()
    {
        this.丗丏丅丕丆世丁专丟 = -4;
        if(this.业东东下丘丒丝业专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.业东东下丘丒丝业专.Dispose();
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
