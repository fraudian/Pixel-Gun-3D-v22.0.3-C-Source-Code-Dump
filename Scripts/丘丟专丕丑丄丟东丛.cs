using UnityEngine;
private sealed class Player_move_c.丘丟专丕丑丄丟东丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丙一丑丏丁一且丒业;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丘丟专丕丑丄丟东丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_0;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丙一丑丏丁一且丒业 > 0f)
        {
            goto label_1;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        this.丝且与丝丒丟万丁专.丟丆丄丏万下业丞丏(丙业与丙丗丝不丈东:  false);
        goto label_3;
        label_0:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丙一丑丏丁一且丒业 - val_1;
        val_2 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丙一丑丏丁一且丒业 = val_1;
        this.丗丏丅丕丆世丁专丟 = val_2;
        return (bool)val_2;
        label_2:
        0.丟丆丄丏万下业丞丏(丙业与丙丗丝不丈东:  false);
        label_3:
        val_2 = 0;
        this.丝且与丝丒丟万丁专.世丂丄一丑专丘世业 = 0;
        return (bool)val_2;
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
