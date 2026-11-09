using UnityEngine;
private sealed class GameEventGui.丛七一且一三业业丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventGui 丝且与丝丒丟万丁专;
    private float 丘丌丕一上丛下丙上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventGui.丛七一且一三业业丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_2;
        float val_3;
        int val_4;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        val_3 = 0.3f;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丘丌丕一上丛下丙上 = 0.3f;
        goto label_3;
        label_0:
        val_3 = this.丘丌丕一上丛下丙上;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 > 0f)
        {
            goto label_3;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.不丒三丘丁下丗丂东 = 0;
        goto label_5;
        label_3:
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_3 - val_1;
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丘丌丕一上丛下丙上 = val_1;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_4:
        mem[240] = 0;
        label_5:
        val_2 = this.丝且与丝丒丟万丁专._touchBlocker;
        val_2.SetActive(value:  false);
        label_1:
        val_4 = 0;
        return (bool)val_4;
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
