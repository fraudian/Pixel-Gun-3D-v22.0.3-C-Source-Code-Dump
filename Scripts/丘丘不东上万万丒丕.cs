using UnityEngine;
private sealed class ActivityIndicator.丘丘不东上万万丒丕 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private float 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public ActivityIndicator 丝且与丝丒丟万丁专;
    private UnityEngine.Texture 丝丘专世丏三丝下丐;
    public UnityEngine.Texture 丝丕上丞丐上上七专;
    private float 与丈业丛丝丒丙一丏;
    public float 丅七丆三丐且丙下丗;
    private float 不下丟上丙丌一业丑;
    
    // Properties
    private float System.Collections.Generic.IEnumerator<System.Single>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ActivityIndicator.丘丘不东上万万丒丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Texture val_4;
        var val_5;
        int val_6;
        val_4 = this;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        float val_8 = this.不下丟上丙丌一业丑;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_8 < 0)
        {
            goto label_2;
        }
        
        UITexture val_4 = this.丝且与丝丒丟万丁专.txFon[1];
        val_4 = this.丝丘专世丏三丝下丐;
        if(this.丝且与丝丒丟万丁专.txFon[0] != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            UITexture val_6 = this.丝且与丝丒丟万丁专.txFon[1];
            val_5 = this.丝丘专世丏三丝下丐;
            if(this.丝且与丝丒丟万丁专.txFon.Length <= 1)
        {
                val_5 = 0;
        }
        
            this.丝且与丝丒丟万丁专.txFon[1].alpha = 0f;
            val_6 = 1;
            this.不下丟上丙丌一业丑 = 0f;
            this.丗丏丅丕丆世丁专丟 = val_6;
            this.丒上七丌业七丟与丐 = 0f;
            return (bool)val_6;
        }
        
        label_11:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_8 + val_2;
        this.不下丟上丙丌一业丑 = val_2;
        val_8 = val_2 / this.与丈业丛丝丒丙一丏;
        float val_3 = UnityEngine.Mathf.Min(a:  val_8, b:  1f);
        this.丝且与丝丒丟万丁专.txFon[1].alpha = val_8;
        this.丒上七丌业七丟与丐 = val_8;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
    }
    private float System.Collections.Generic.IEnumerator<System.Single>.get_Current()
    {
        return (float)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                ActivityIndicator.丘丘不东上万万丒丕 val_2 = null;
            val_4 = val_2;
            val_2 = new ActivityIndicator.丘丘不东上万万丒丕();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丝丘专世丏三丝下丐 = this.丝丕上丞丐上上七专;
        .与丈业丛丝丒丙一丏 = this.丅七丆三丐且丙下丗;
        return (System.Collections.Generic.IEnumerator<System.Single>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator();
    }

}
