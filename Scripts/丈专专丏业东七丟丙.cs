using UnityEngine;
private sealed class SpawnMobBase.丈专专丏业东七丟丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SpawnMobBase 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpawnMobBase.丈专专丏业东七丟丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.timeForSpawnMob);
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_19;
        }
        
        if((GameConnect.且丞丁东丝丗上丈业() == false) || (DungeonsController.三丅丅丄东丑丛上下() == false))
        {
            goto label_13;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_14;
        }
        
        label_20:
        0.上丌万丁丄丅一丐丙();
        goto label_15;
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_13:
        if(GameConnect.且丞丁东丝丗上丈业() == true)
        {
            goto label_19;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_20;
        }
        
        label_14:
        this.丝且与丝丒丟万丁专.上丌万丁丄丅一丐丙();
        label_15:
        this.丝且与丝丒丟万丁专.丟丕丏专专丙专丂丗();
        label_19:
        val_6 = 1;
        this.丗丏丅丕丆世丁专丟 = val_6;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
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
