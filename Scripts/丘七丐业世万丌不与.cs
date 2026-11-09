using UnityEngine;
private sealed class UILabelDynamicWorldName.丘七丐业世万丌不与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UILabelDynamicWorldName 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UILabelDynamicWorldName.丘七丐业世万丌不与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Color val_5;
        var val_8;
        var val_9;
        UnityEngine.Color val_10;
        UnityEngine.GameObject val_11;
        int val_12;
        var val_13;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_5 = this.丝且与丝丒丟万丁专.东上丙一七三丞七丟;
        val_8 = S9;
        val_9 = S10;
        val_10 = val_5;
        val_11 = this.丝且与丝丒丟万丁专.gameObject;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丕丕东丌丅丌业上丁();
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_3:
        val_5 = this.丝且与丝丒丟万丁专.东上丙一七三丞七丟;
        val_10 = this.丝且与丝丒丟万丁专.东上丙一七三丞七丟;
        val_11 = 0.gameObject;
        label_4:
        TweenColor val_3 = TweenColor.Begin(丝三丁东丈丒世丅业:  val_11, 与丈业丛丝丒丙一丏:  this.丝且与丝丒丟万丁专.fadeInDuration, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5, g = V9.16B, b = V10.16B, a = 1f});
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        this.丝且与丝丒丟万丁专.三丙丘丕与不上东丆 = val_3;
        if(val_3 != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        val_3.from = val_10;
        mem2[0] = ???;
        mem2[0] = ???;
        mem2[0] = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_9;
        }
        
        val_13 = mem[this.丝且与丝丒丟万丁专 + 56];
        val_13 = this.丝且与丝丒丟万丁专 + 56;
        goto label_10;
        label_7:
        mem[56] = val_3;
        if(mem[56] != 0)
        {
            goto label_11;
        }
        
        goto label_12;
        label_9:
        val_13 = mem[this.丝且与丝丒丟万丁专 + 56];
        val_13 = this.丝且与丝丒丟万丁专 + 56;
        label_10:
        mem2[0] = this.丝且与丝丒丟万丁专.method;
        val_12 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.hideDelay);
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
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
