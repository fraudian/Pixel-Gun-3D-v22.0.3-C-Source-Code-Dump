using UnityEngine;
private sealed class MaterialColorSwitcher.丕丘丄上一三丏丆业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.MaterialColorSwitcher 丝且与丝丒丟万丁专;
    public int 下丒丒丛不丑丗丘丙;
    public float 丂三丟丂丈丐丆丗丟;
    private UnityEngine.Color 专丝丏丅与专丑丁七;
    private UnityEngine.Color 上丟丕丝丅且丗下下;
    private float 东丁且丛丏与丙丕丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MaterialColorSwitcher.丕丘丄上一三丏丆业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        float val_7;
        int val_8;
        float val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Color val_1 = this.丝且与丝丒丟万丁专.下丘丈丌丁与丅七东.color;
        this.专丝丏丅与专丑丁七 = val_1;
        mem[1152921543210355140] = val_1.g;
        mem[1152921543210355144] = val_1.b;
        mem[1152921543210355148] = val_1.a;
        UnityEngine.Color val_2 = this.丝且与丝丒丟万丁专.Colors.Item[this.下丒丒丛不丑丗丘丙];
        val_6 = this;
        this.东丁且丛丏与丙丕丏 = 0f;
        mem[1152921543210355152] = val_2.r;
        mem[1152921543210355156] = val_2.g;
        mem[1152921543210355160] = val_2.b;
        mem[1152921543210355164] = val_2.a;
        val_7 = 0f;
        goto label_6;
        label_1:
        val_6 = this;
        val_7 = this.东丁且丛丏与丙丕丏;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        if(val_7 < 0)
        {
            goto label_7;
        }
        
        val_8 = 0;
        this.丝且与丝丒丟万丁专.丞丅三万丈七一丞丙 = true;
        return (bool)val_8;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_7:
        val_9 = val_7 + UnityEngine.Time.deltaTime;
        this.东丁且丛丏与丙丕丏 = val_9;
        if(this.丝且与丝丒丟万丁专 == null)
        {
                val_9 = this.东丁且丛丏与丙丕丏;
        }
        
        val_9 = val_9 / this.丂三丟丂丈丐丆丗丟;
        UnityEngine.Color val_4 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.专丝丏丅与专丑丁七}, b:  new UnityEngine.Color() {r = this.上丟丕丝丅且丗下下}, t:  val_9);
        val_7 = val_4.r;
        this.丝且与丝丒丟万丁专.下丘丈丌丁与丅七东.color = new UnityEngine.Color() {r = val_7, g = val_4.g, b = val_4.b, a = val_4.a};
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
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
