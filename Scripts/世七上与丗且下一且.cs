using UnityEngine;
private sealed class DynamicWrapGrid.世七上与丗且下一且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丙业与丙丗丝不丈东;
    public DynamicWrapGrid 丝且与丝丒丟万丁专;
    public float 丗丒丛下与万丗丙丝;
    private float 东丟丁且下七万七专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamicWrapGrid.世七上与丗且下一且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        float val_6;
        int val_7;
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
        val_4 = this.丙业与丙丗丝不丈东;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_3 = (UnityEngine.Mathf.Sign(f:  this.丙业与丙丗丝不丈东)) * this.丗丒丛下与万丗丙丝;
        val_3 = val_3 * ((float)this.丝且与丝丒丟万丁专.<业丐丈三不东丑专丈>k__BackingField.itemSize);
        val_5 = UnityEngine.Time.deltaTime * val_3;
        this.丝且与丝丒丟万丁专.世丕丞三一丞世与万 = val_5;
        val_6 = this.东丟丁且下七万七专;
        if(System.Math.Abs(val_5) > System.Math.Abs(val_6))
        {
                this.丝且与丝丒丟万丁专.世丕丞三一丞世与万 = val_6;
            val_5 = val_6;
            val_6 = this.东丟丁且下七万七专;
        }
        
        val_5 = val_6 - val_5;
        this.东丟丁且下七万七专 = val_5;
        this.丝且与丝丒丟万丁专.丟东不丅丙丆专丝丟 = true;
        val_4 = this.东丟丁且下七万七专;
        label_3:
        if((double)System.Math.Abs(val_4) > 0.01)
        {
            goto label_11;
        }
        
        val_7 = 0;
        this.丝且与丝丒丟万丁专.丟丝业丛七丟上一三 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_11:
        val_7 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
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
