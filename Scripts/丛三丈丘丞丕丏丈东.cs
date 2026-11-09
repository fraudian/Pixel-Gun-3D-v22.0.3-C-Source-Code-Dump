using UnityEngine;
private sealed class FortSpawnMobImmortal.丛三丈丘丞丕丏丈东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FortSpawnMobImmortal 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortSpawnMobImmortal.丛三丈丘丞丕丏丈东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<RilisoftBot.BaseBot> val_9;
        int val_10;
        int val_11;
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
        goto label_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_16;
        }
        
        this.丝且与丝丒丟万丁专.上丌万丁丄丅一丐丙();
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_16;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_12;
        }
        
        val_10 = this.丝且与丝丒丟万丁专.maxCountSpawnMob;
        goto label_13;
        label_2:
        val_11 = 0;
        return (bool)val_11;
        label_12:
        val_10 = 130653168;
        label_13:
        val_9 = this.丝且与丝丒丟万丁专.世丞且丒丑丈丈与丞;
        if(130653168 > val_9.Count)
        {
                val_9 = this.丝且与丝丒丟万丁专._spawnBot;
            this.丝且与丝丒丟万丁专.丟丕丏专专丙专丂丗(丗丙丒一且丝丂丒世:  val_9.Item[UnityEngine.Random.Range(min:  0, max:  val_9.Count - 1)]);
        }
        
        label_16:
        val_11 = 1;
        this.丗丏丅丕丆世丁专丟 = val_11;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_11;
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
