using UnityEngine;
private sealed class BaseBot.丕丟丒丂东丂丑不丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.BaseBot 丝且与丝丒丟万丁专;
    public bool 万东丏丌不七东丘万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseBot.丕丟丒丂东丂丑不丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.上丞丞丏丂丅专丝丆 = true;
        val_3 = this.万东丏丌不七东丘万;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丟丘一丄一东且丐丗(丞七丛与丝下一一丆:  false, 丌丒丕丄丑丌世不丐:  false);
        goto label_6;
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_3:
        mem[80] = 1;
        val_3 = this.万东丏丌不七东丘万;
        label_4:
        val_4 = 1;
        this.丝且与丝丒丟万丁专.丟丘一丄一东且丐丗(丞七丛与丝下一一丆:  true, 丌丒丕丄丑丌世不丐:  (val_3 == true) ? 1 : 0);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.125f);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_5:
        0.丟丘一丄一东且丐丗(丞七丛与丝下一一丆:  false, 丌丒丕丄丑丌世不丐:  false);
        label_6:
        val_4 = 0;
        this.丝且与丝丒丟万丁专.上丞丞丏丂丅专丝丆 = false;
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
