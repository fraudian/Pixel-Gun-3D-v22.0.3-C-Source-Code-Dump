using UnityEngine;
private sealed class 东万丟丝丏丟丅丟丒.丝丕七一丘丘丕上上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 上下七丞丝丕一三丁;
    public PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丝且与丝丒丟万丁专;
    private bool 万丛丘东丅专与与下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 东万丟丝丏丟丅丟丒.丝丕七一丘丘丕上上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_8;
        bool val_9;
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_8 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = this;
        this.万丛丘东丅专与与下 = this.上下七丞丝丕一三丁.七丂丌丈丄专丄三世();
        goto label_7;
        label_1:
        val_9 = this.万丛丘东丅专与与下;
        val_8 = this.上下七丞丝丕一三丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_7;
        label_9:
        bool val_4 = mem[this.上下七丞丝丕一三丁].七丂丌丈丄专丄三世();
        mem2[0] = val_4;
        if(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且 != null)
        {
                PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且.Invoke(arg1:  this.丝且与丝丒丟万丁专, arg2:  val_4);
        }
        
        label_7:
        if((((val_9 == true) ? 1 : 0) ^ mem[this.上下七丞丝丕一三丁].七丂丌丈丄专丄三世()) == true)
        {
            goto label_9;
        }
        
        val_10 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_2:
        val_10 = 0;
        return (bool)val_10;
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
