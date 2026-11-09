using UnityEngine;
private sealed class Switcher.丁且与业丒专丏万丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 专万丟三世业丙丈且;
    public Switcher 丝且与丝丒丟万丁专;
    public float 丘丛与上丞丐丝丑丑;
    public UnityEngine.AsyncOperation 三丗一丛丝丘不丟丁;
    private Rilisoft.丅丞丈丅东丆与世丈 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Switcher.丁且与业丒专丏万丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
    }
    private bool MoveNext()
    {
        int val_7;
        int val_8;
        float val_9;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_24;
        }
        
        val_7 = -3;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        string val_1 = "Switcher.WaitLoadSceneAsyncOperation(): "("Switcher.WaitLoadSceneAsyncOperation(): ") + this.专万丟三世业丙丈且;
        bool val_3 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        val_7 = -3;
        mem[1152921540461601392] = 0;
        this.与业丕业业业丌丟丐 = 0;
        label_3:
        this.丗丏丅丕丆世丁专丟 = val_7;
        if(this.三丗一丛丝丘不丟丁.isDone != false)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_8 = 0;
            mem2[0] = false;
            与丒丕丁下世东丅丌 = false;
            mem[1] = 0;
            return (bool)val_8;
        }
        
        float val_5 = this.三丗一丛丝丘不丟丁.progress;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                float val_6 = 50f;
            val_9 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
            val_6 = val_5 / val_6;
            val_6 = this.丘丛与上丞丐丝丑丑 + val_6;
            this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄 = val_6;
        }
        else
        {
                float val_7 = 50f;
            val_9 = 284;
            val_7 = val_5 / val_7;
            val_7 = this.丘丛与上丞丐丝丑丑 + val_7;
            mem[284] = val_7;
        }
        
        this.丒上七丌业七丟与丐 = mem[284];
        val_8 = 1;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_24:
        val_8 = 0;
        return (bool)val_8;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
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
