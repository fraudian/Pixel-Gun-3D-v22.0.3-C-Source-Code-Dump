using UnityEngine;
private sealed class Player_move_c.上丛业丛丈丏下三专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    public float 丙一丑丏丁一且丒业;
    private float 丞三丄丑丅丘东丌丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.上丛业丛丈丏下三专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_2 = 0f;
        this.丝且与丝丒丟万丁专.丈且丟且与丐七一专 = true;
        this.丞三丄丑丅丘东丌丗 = 0f;
        goto label_4;
        label_0:
        val_2 = this.丞三丄丑丅丘东丌丗;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_2 <= 1f)
        {
            goto label_4;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丈且丟且与丐七一专 = false;
        goto label_6;
        label_4:
        float val_1 = UnityEngine.Time.deltaTime;
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        val_1 = val_1 / this.丙一丑丏丁一且丒业;
        val_1 = val_2 + val_1;
        this.丞三丄丑丅丘东丌丗 = val_1;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_5:
        label_6:
        val_3 = 0;
        this.丝且与丝丒丟万丁专.丂丑下下丘丝世丝一 = 0;
        return (bool)val_3;
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
