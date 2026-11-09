using UnityEngine;
private sealed class Player_move_c.丁丈丞世丛且业万万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    public float 丙丒七丄上与丏丙丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丁丈丞世丛且业万万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_7;
        int val_8;
        val_7 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.万万一与丝业七专下 != true)
        {
                val_7.丙丙丟世丌且丑丅丘().PlayOneShot(clip:  this.丝且与丝丒丟万丁专.killerInvisActivSound);
        }
        
        val_7.世丘万丅万丈不不一(七下丛丌世上丞丂丗:  true, 与丞丏丗丏丁丂丗丝:  false, 丏丈丘丙业丞丏七丑:  false, 丝丟三且三丈七万丁:  false, 一且丘丛与丝丙不世:  true);
        WeaponSounds val_2 = val_7.丙不丅丕三丂业东丕();
        if(val_2.firstKillCritical != false)
        {
                val_7.丙不丅丕三丂业东丕().SetNextHitCritical(三丟东丕丄丄下下丑:  true);
        }
        
        UnityEngine.WaitForSeconds val_4 = null;
        val_7 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  this.丙丒七丄上与丏丙丙);
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        WeaponSounds val_5 = val_7.丙不丅丕三丂业东丕();
        if(val_5.firstKillCritical != false)
        {
                val_7.丙不丅丕三丂业东丕().SetNextHitCritical(三丟东丕丄丄下下丑:  false);
        }
        
        if(val_7 == null)
        {
            goto label_15;
        }
        
        val_7.世丘万丅万丈不不一(七下丛丌世上丞丂丗:  false, 与丞丏丗丏丁丂丗丝:  false, 丏丈丘丙业丞丏七丑:  false, 丝丟三且三丈七万丁:  false, 一且丘丛与丝丙不世:  true);
        goto label_16;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_15:
        0.世丘万丅万丈不不一(七下丛丌世上丞丂丗:  false, 与丞丏丗丏丁丂丗丝:  false, 丏丈丘丙业丞丏七丑:  false, 丝丟三且三丈七万丁:  false, 一且丘丛与丝丙不世:  true);
        label_16:
        val_8 = 0;
        this.丝且与丝丒丟万丁专.丌丑业丞丟一丝业丕 = 0;
        return (bool)val_8;
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
