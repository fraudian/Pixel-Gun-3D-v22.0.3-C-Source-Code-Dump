using UnityEngine;
private sealed class WidgetLayoutDelayed.专与丄丒世丝丙丟丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WidgetLayoutDelayed 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List.Enumerator<UIWidget> 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WidgetLayoutDelayed.专与丄丒世丝丙丟丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_3;
        var val_6;
        List.Enumerator<UIWidget> val_7;
        var val_12;
        List.Enumerator<UIWidget> val_13;
        UnityEngine.Object val_14;
        var val_15;
        var val_16;
        int val_17;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_48;
        }
        
        val_13 = this.与业丕业业业丌丟丐;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = 1152921526158937552;
        List.Enumerator<T> val_1 = this.丝且与丝丒丟万丁专.widgetLayout.widgets.GetEnumerator();
        label_10:
        if(((-763031200) & 1) == 0)
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_10;
        label_7:
        val_15 = 0;
        val_16 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_17;
        }
        
        if( == 0)
        {
            goto label_21;
        }
        
        if(95 != 95)
        {
            goto label_19;
        }
        
        goto label_21;
        label_17:
        if( == 0)
        {
            goto label_21;
        }
        
        label_19:
        label_21:
        List.Enumerator<T> val_5 = this.丝且与丝丒丟万丁专.widgetLayout.widgets.GetEnumerator();
        val_13 = this.与业丕业业业丌丟丐;
        mem[1152921538203566328] = val_6;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_7;
        label_3:
        val_12 = 1152921526158938576;
        label_28:
        if((val_13 & 1) == 0)
        {
            goto label_25;
        }
        
        val_14 = val_13.丐丏七丌丕丗业且上();
        if(val_14 == 0)
        {
            goto label_28;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_14, 丏业丟一东丂东丘丛:  true);
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.stepDelay);
        val_17 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        this.丗丏丅丕丆世丁专丟 = val_17;
        return (bool)val_17;
        label_25:
        this.一世丕丕业且且丅丌();
        val_17 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_17;
        label_48:
        val_17 = 0;
        return (bool)val_17;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.与业丕业业业丌丟丐);
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
