using UnityEngine;
private sealed class LeprechauntLobbyView.丏丂丘下丏丑世丈丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LeprechauntLobbyView 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeprechauntLobbyView.丏丂丘下丏丑世丈丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        UnityEngine.WaitForSecondsRealtime val_9;
        int val_10;
        val_8 = 91075;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSecondsRealtime val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.WaitForSecondsRealtime(time:  0.2f);
        this.丗丕专丐丞丞下不丒 = val_9;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        val_8 = 0;
        label_5:
        if(val_8.CanShow() == false)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.上丁丆三丗丛丝丐万(下下东且万业丞丅丒:  ((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.一与丘一不一不丟丁()) > 0) ? 1 : 0);
        val_9 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_9 == 0)
        {
            goto label_13;
        }
        
        val_9 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_9.上丙丆不丂丂丄一丂() == false)
        {
            goto label_13;
        }
        
        this.丝且与丝丒丟万丁专.一上与丙专丒与丟丞();
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_21;
        }
        
        goto label_16;
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_6:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_18;
        }
        
        this.丝且与丝丒丟万丁专.上丁丆三丗丛丝丐万(下下东且万业丞丅丒:  false);
        goto label_19;
        label_13:
        this.丝且与丝丒丟万丁专.丌丌丈专丝世丏三上();
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_21;
        }
        
        label_16:
        label_21:
        this.丝且与丝丒丟万丁专.丑专三丄丟七丐世丘();
        goto label_22;
        label_18:
        0.上丁丆三丗丛丝丐万(下下东且万业丞丅丒:  false);
        label_19:
        this.丝且与丝丒丟万丁专.一上与丙专丒与丟丞();
        label_22:
        val_10 = 1;
        this.丗丏丅丕丆世丁专丟 = val_10;
        this.丒上七丌业七丟与丐 = this.丗丕专丐丞丞下不丒;
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
