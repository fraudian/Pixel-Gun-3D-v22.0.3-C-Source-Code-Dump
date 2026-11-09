using UnityEngine;
private sealed class BattlePassLobbyButton.丛丙上丒丗丒丕丒丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassLobbyButton 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 丅与丁丆丝丞丌丂下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassLobbyButton.丛丙上丒丗丒丕丒丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_4;
        var val_5;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
        {
            goto label_14;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        label_10:
        this.丝且与丝丒丟万丁专.丙且丛丘业丑丛丙丄();
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_11;
        }
        
        goto label_9;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        label_6:
        0.丙且丛丘业丑丛丙丄();
        label_7:
        this.丝且与丝丒丟万丁专.与下丐东丙丟丘丑丕();
        this.丅与丁丆丝丞丌丂下 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_11;
        }
        
        label_9:
        label_11:
        this.丝且与丝丒丟万丁专.丘丟万丌丄三丏丈业();
        val_4 = this.丅与丁丆丝丞丌丂下;
        if(val_4 == null)
        {
                UnityEngine.WaitForSeconds val_3 = null;
            val_4 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
            this.丅与丁丆丝丞丌丂下 = val_4;
        }
        
        label_14:
        val_5 = 1;
        this.丒上七丌业七丟与丐 = val_4;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_5;
        label_3:
        val_5 = 0;
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
