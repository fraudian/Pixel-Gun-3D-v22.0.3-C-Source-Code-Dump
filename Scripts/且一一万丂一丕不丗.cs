using UnityEngine;
private sealed class Rocket.且一一万丂一丕不丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.且一一万丂一丕不丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        Rocket val_10;
        int val_11;
        RocketSettings val_12;
        float val_13;
        var val_14;
        float val_15;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_13;
        }
        
        val_11 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        val_10 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if((val_10.下业丑万丟丁与丕不() == 0) || ((this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 == 0) || (this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.isPoisoning == false)))
        {
            goto label_13;
        }
        
        WeaponSounds val_4 = val_10.下业丑万丟丁与丕不();
        if(val_4.isPoisoning == false)
        {
            goto label_15;
        }
        
        label_13:
        val_11 = 0;
        return (bool)val_11;
        label_15:
        val_12 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_12 == null)
        {
            goto label_16;
        }
        
        this.丝且与丝丒丟万丁专.丌丒丕丄丑丌世不丐 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.isPoisoning;
        goto label_17;
        label_16:
        this.丝且与丝丒丟万丁专.丌丒丕丄丑丌世不丐 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.isPoisoning;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 == null)
        {
            goto label_18;
        }
        
        val_12 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        label_17:
        this.丝且与丝丒丟万丁专.三一丝且丝丛不丄丐 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.poisonType;
        label_36:
        this.丝且与丝丒丟万丁专.丐丒业丒丂丟丒三丝 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.poisonDamageMultiplier;
        label_37:
        this.丝且与丝丒丟万丁专.丂丐丈丕丞下丁下丘 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.poisonTime;
        WeaponSounds val_5 = val_10.下业丑万丟丁与丕不();
        if((val_5.三世丗丆丕万丐且三.ContainsKey(key:  18)) != false)
        {
                WeaponSounds val_7 = val_10.下业丑万丟丁与丕不();
            val_13 = val_7.三世丗丆丕万丐且三.Item[18];
        }
        else
        {
                val_13 = 1f;
        }
        
        val_13 = val_13 * (float)this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.poisonCount;
        if(val_13 >= 0f)
        {
            goto label_28;
        }
        
        if((double)val_13 != (-0.5))
        {
            goto label_29;
        }
        
        val_14 = val_9;
        val_15 = -1f;
        goto label_30;
        label_28:
        if((double)val_13 != 0.5)
        {
            goto label_31;
        }
        
        val_14 = val_9;
        val_15 = 1f;
        label_30:
        float val_10 = (float)val_14;
        val_15 = val_10 + val_15;
        val_10 = (((long)val_14 & 1) != 0) ? (val_10) : (val_15);
        goto label_33;
        label_29:
        float val_11 = -0.5f;
        val_11 = val_13 + val_11;
        goto label_33;
        label_31:
        float val_12 = 0.5f;
        val_12 = val_13 + val_12;
        label_33:
        this.丝且与丝丒丟万丁专.丂上上不一丐业一丕 = (int)val_12;
        this.丝且与丝丒丟万丁专.丌丛丑三丆丘万丘丛 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.isIgnoreIgnoreDamage;
        return (bool)val_11;
        label_18:
        this.丝且与丝丒丟万丁专.三一丝且丝丛不丄丐 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.poisonType;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 != null)
        {
            goto label_36;
        }
        
        this.丝且与丝丒丟万丁专.丐丒业丒丂丟丒三丝 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.poisonDamageMultiplier;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 != null)
        {
            goto label_37;
        }
    
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
