using UnityEngine;
private sealed class FortSpawnMob.丄丂下丑丑丘丛丐下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FortSpawnMob 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortSpawnMob.丄丂下丑丑丘丛丐下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<RilisoftBot.BaseBot> val_10;
        int val_11;
        int val_12;
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
        goto label_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = 1152921505107111936;
        if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false) || (this.丝且与丝丒丟万丁专.isActive == false))
        {
            goto label_18;
        }
        
        this.丝且与丝丒丟万丁专.上丌万丁丄丅一丐丙();
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_18;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_14;
        }
        
        val_11 = this.丝且与丝丒丟万丁专.maxCountSpawnMob;
        goto label_15;
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_14:
        val_11 = 130653168;
        label_15:
        val_10 = this.丝且与丝丒丟万丁专.世丞且丒丑丈丈与丞;
        if(130653168 > val_10.Count)
        {
                val_10 = this.丝且与丝丒丟万丁专._spawnBot;
            this.丝且与丝丒丟万丁专.丟丕丏专专丙专丂丗(丗丙丒一且丝丂丒世:  val_10.Item[UnityEngine.Random.Range(min:  0, max:  val_10.Count - 1)]);
        }
        
        label_18:
        val_12 = 1;
        this.丗丏丅丕丆世丁专丟 = val_12;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_12;
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
