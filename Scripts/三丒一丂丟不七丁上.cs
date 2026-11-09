using UnityEngine;
private sealed class DynamicStringWrapGrid.三丒一丂丟不七丁上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丙业与丙丗丝不丈东;
    public PGCompany.DynamicStringWrapGrid 丝且与丝丒丟万丁专;
    public float 丗丒丛下与万丗丙丝;
    private float 东丟丁且下七万七专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamicStringWrapGrid.三丒一丂丟不七丁上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_6;
        float val_7;
        var val_8;
        int val_9;
        float val_10;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.东丟丁且下七万七专 = this.丙业与丙丗丝不丈东;
        val_6 = this.丙业与丙丗丝不丈东;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_1 = UnityEngine.Mathf.Sign(f:  this.丙业与丙丗丝不丈东);
        UIWrapContent val_2 = this.丝且与丝丒丟万丁专.wrapContent;
        float val_3 = UnityEngine.Time.deltaTime;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        float val_4 = val_1 * this.丗丒丛下与万丗丙丝;
        val_4 = val_4 * (float)val_2.itemSize;
        val_7 = val_3 * val_4;
        val_8 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.世丕丞三一丞世与万 = val_7;
        goto label_9;
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_8:
        float val_5 = val_1 * this.丗丒丛下与万丗丙丝;
        val_5 = val_5 * (float)val_2.itemSize;
        val_5 = val_3 * val_5;
        val_8 = 96;
        mem[96] = val_5;
        val_7 = mem[96];
        label_9:
        val_10 = this.东丟丁且下七万七专;
        if(System.Math.Abs(val_7) > System.Math.Abs(val_10))
        {
                mem[96] = val_10;
            val_7 = val_10;
            val_10 = this.东丟丁且下七万七专;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_7 = val_10 - val_7;
            this.东丟丁且下七万七专 = val_7;
        }
        else
        {
                float val_8 = mem[96];
            val_8 = val_10 - val_8;
            this.东丟丁且下七万七专 = val_8;
        }
        
        this.丝且与丝丒丟万丁专.丟东不丅丙丆专丝丟 = true;
        val_6 = this.东丟丁且下七万七专;
        label_3:
        if((double)System.Math.Abs(val_6) <= 0.01)
        {
                val_9 = 0;
            this.丝且与丝丒丟万丁专.丟丝业丛七丟上一三 = 0;
            return (bool)val_9;
        }
        
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
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
