using UnityEngine;
private sealed class SettingsAmounter.东丟丙丞专丙丅丁下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SettingsAmounter 丝且与丝丒丟万丁专;
    public int 七丞丙丒三丕且丌丟;
    private float 三万上一上且与一与;
    private int 上且丄丟七丏丆丐不;
    private System.Collections.Generic.List<int> 丒万丕东丁丏业不与;
    private int 丕丅专丘丘东丆下一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SettingsAmounter.东丟丙丞专丙丅丁下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_9;
        int val_10;
        int val_11;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三万上一上且与一与 = 0.2f;
        this.上且丄丟七丏丆丐不 = 1;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        val_1.Add(item:  1);
        val_1.Add(item:  5);
        val_1.Add(item:  10);
        val_1.Add(item:  15);
        val_1.Add(item:  20);
        val_1.Add(item:  30);
        val_1.Add(item:  40);
        val_1.Add(item:  50);
        val_1.Add(item:  60);
        val_1.Add(item:  70);
        val_1.Add(item:  80);
        val_1.Add(item:  100);
        val_1.Add(item:  120);
        val_1.Add(item:  140);
        val_1.Add(item:  160);
        val_1.Add(item:  180);
        goto label_4;
        label_1:
        int val_8 = this.上且丄丟七丏丆丐不;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = val_8 - 1;
        this.上且丄丟七丏丆丐不 = val_8;
        if((val_8 != 0) || (this.丕丅专丘丘东丆下一 >= this.丒万丕东丁丏业不与.Count))
        {
            goto label_7;
        }
        
        int val_3 = this.丕丅专丘丘东丆下一 + 1;
        this.丕丅专丘丘东丆下一 = val_3;
        float val_9 = this.三万上一上且与一与;
        this.上且丄丟七丏丆丐不 = this.丒万丕东丁丏业不与.Item[val_3];
        val_9 = val_9 * 0.5f;
        this.三万上一上且与一与 = val_9;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_9;
        }
        
        goto label_11;
        label_3:
        val_1.Add(item:  1);
        val_1.Add(item:  5);
        val_1.Add(item:  10);
        val_1.Add(item:  15);
        val_1.Add(item:  20);
        val_1.Add(item:  30);
        val_1.Add(item:  40);
        val_1.Add(item:  50);
        val_1.Add(item:  60);
        val_1.Add(item:  70);
        val_1.Add(item:  80);
        val_1.Add(item:  100);
        val_1.Add(item:  120);
        val_1.Add(item:  140);
        val_1.Add(item:  160);
        val_1.Add(item:  180);
        label_4:
        val_1.Add(item:  200);
        this.丒万丕东丁丏业不与 = val_1;
        this.丕丅专丘丘东丆下一 = 0;
        label_7:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_11;
        }
        
        label_9:
        val_8 = this.丝且与丝丒丟万丁专;
        val_9 = this;
        val_10 = this.丝且与丝丒丟万丁专._value;
        val_11 = this.七丞丙丒三丕且丌丟;
        goto label_12;
        label_11:
        val_8 = 88;
        val_9 = this;
        val_10 = 0;
        val_11 = this.七丞丙丒三丕且丌丟;
        label_12:
        if((val_10 + val_11) > this.丝且与丝丒丟万丁专.maxValue)
        {
                return false;
        }
        
        var val_10 = 0;
        val_10 = val_11 + val_10;
        if(val_10 < this.丝且与丝丒丟万丁专.minValue)
        {
                return false;
        }
        
        mem[88] = (val_10 > this.丝且与丝丒丟万丁专.maxValue) ? this.丝且与丝丒丟万丁专.maxValue : (val_10);
        this.丝且与丝丒丟万丁专.丆三且丆三不世丈丌();
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.三万上一上且与一与);
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
