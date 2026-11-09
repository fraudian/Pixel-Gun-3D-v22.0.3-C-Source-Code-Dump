using UnityEngine;
private sealed class SquareFieldSelectableCell.丆专丈丛万丂丄三丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SquareFieldSelectableCell 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SquareFieldSelectableCell.丆专丈丛万丂丄三丕(int 丗丏丅丕丆世丁专丟)
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
        int val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.丄丑三东丘丆丂丟丙;
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = val_1 * this.丝且与丝丒丟万丁专.scrollSpeed;
        val_7 = this.丝且与丝丒丟万丁专.丄丑三东丘丆丂丟丙 + val_1;
        this.丝且与丝丒丟万丁专.丄丑三东丘丆丂丟丙 = val_7;
        goto label_3;
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_2:
        val_6 = 300;
        float val_2 = UnityEngine.Time.unscaledDeltaTime;
        val_2 = val_2 * (1.64395E-34f);
        val_2 = 0f + val_2;
        mem[300] = val_2;
        val_7 = mem[300];
        label_3:
        if(System.Math.Abs(val_7) >= 1f)
        {
                mem[300] = 0f;
        }
        
        val_9 = 0;
        goto label_9;
        label_15:
        val_7 = mem[300];
        this.丝且与丝丒丟万丁专.七万丞且丘丅且丛丟.Item[0].material.SetFloat(name:  this.丝且与丝丒丟万丁专.丒与丆七与丕丑东丆, value:  val_7);
        val_9 = 1;
        label_9:
        if(val_9 < this.丝且与丝丒丟万丁专.七万丞且丘丅且丛丟.Count)
        {
            goto label_15;
        }
        
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
