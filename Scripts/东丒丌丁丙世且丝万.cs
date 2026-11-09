using UnityEngine;
private sealed class InGameGUI.东丒丌丁丙世且丝万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InGameGUI 丝且与丝丒丟万丁专;
    public int 丌丒丝东丌下丕丁丅;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameGUI.东丒丌丁丙世且丝万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        val_4 = this.丗丏丅丕丆世丁专丟;
        if(val_4 == 1)
        {
            goto label_1;
        }
        
        if(val_4 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = this.丙不丅丌丗上丂丕一 + 1;
        this.丙不丅丌丗上丂丕一 = val_4;
        label_3:
        if(val_4 >= this.丌丒丝东丌下丕丁丅)
        {
            goto label_4;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专.lowResourceBeep);
        }
        
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
        label_4:
        val_5 = 0;
        this.丝且与丝丒丟万丁专.丛丞丟丐丐万与丗丏 = 0;
        return (bool)val_5;
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
