using UnityEngine;
private sealed class 世丘与丙丗且三且丗.丑丈丈业丁丙业丗上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.GameModeHub.世丘与丙丗且三且丗 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 世丘与丙丗且三且丗.丑丈丈业丁丙业丗上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
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
        this.丝且与丝丒丟万丁专.不与丞下业丑丒丙万();
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_14;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_5:
        val_5 = null;
        val_5 = null;
        if(SceneInfoController.丄丘七三上丕世丞业 != 0)
        {
                if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
            goto label_14;
        }
        
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_14:
        if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() != true)
        {
                if(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.世丄七东丈一七丆丌() == false)
        {
            goto label_19;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.不一丘丅且丆不七上();
        }
        else
        {
                0.不一丘丅且丆不七上();
        }
        
        this.丝且与丝丒丟万丁专.下丌业业丐丘丐丘三();
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_19:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_6;
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
