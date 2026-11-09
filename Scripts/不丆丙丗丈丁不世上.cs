using UnityEngine;
private sealed class PetHighlightComponent.不丆丙丗丈丁不世上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.PetHighlightComponent 丝且与丝丒丟万丁专;
    private float 下丐丅丛与专与业丈;
    private int 丏丒三丘丅丕七丂丅;
    private float 丛丙丁三世丟世丟丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PetHighlightComponent.不丆丙丗丈丁不世上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        var val_5;
        var val_6;
        float val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        val_4 = this;
        this.下丐丅丛与专与业丈 = 0.4f;
        val_5 = 1152921543371425928;
        val_6 = 1152921543371425928;
        this.丗丏丅丕丆世丁专丟 = 0;
        mem[1152921543371425932] = 1;
        mem[1152921543371425936] = 0;
        val_7 = 0f;
        goto label_2;
        label_0:
        val_6 = this;
        val_7 = this.丛丙丁三世丟世丟丘;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = 1152921543371425932;
        val_4 = 5.286276E-35f;
        label_2:
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_7 + val_1;
        this.丛丙丁三世丟世丟丘 = val_1;
        val_1 = val_1 / val_4;
        UnityEngine.Color val_3 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专.且丌东丞万业与丏丒, g = V9.16B, b = V10.16B, a = V11.16B}, b:  new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专._immortalColor}, t:  ((val_5 & 1) != 0) ? (-val_1) : (val_1));
        this.丝且与丝丒丟万丁专.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        if(this.丛丙丁三世丟世丟丘 > this.下丐丅丛与专与业丈)
        {
                this.丛丙丁三世丟世丟丘 = 0f;
            mem[1152921543371425932] = 2;
        }
        
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        val_8 = 0;
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
