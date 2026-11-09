using UnityEngine;
private sealed class GoblinAutoCollectorController.丏丐丗丁七丒业业丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.GoblinAutoCollectorController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GoblinAutoCollectorController.丏丐丗丁七丒业业丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.GoblinAutoCollectorController val_32;
        int val_33;
        long val_34;
        var val_35;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_43;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_32 = this.丝且与丝丒丟万丁专;
        if(PixelTime.丝丗专上三不丄丑丑() < 1)
        {
            goto label_4;
        }
        
        if(this.丝且与丝丒丟万丁专.丆丙丐专七丐一丞万 != null)
        {
                val_32.StopCoroutine(routine:  this.丝且与丝丒丟万丁专.丆丙丐专七丐一丞万);
        }
        
        this.丝且与丝丒丟万丁专.丆丙丐专七丐一丞万 = 0;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丞丕业丞丆丘下三()) == false)
        {
            goto label_43;
        }
        
        if(一丅三东丑丗丅丗丝.丗丞丌世丟丝三七丄() == null)
        {
                return (bool)val_33;
        }
        
        System.Nullable<System.DateTime> val_6 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.业丝上丂丆丝丘丅丏();
        System.Nullable<System.DateTime> val_8 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世专世丒一下丟世丟();
        if(((-2071595168) & 1) == 0)
        {
            goto label_43;
        }
        
        if(( & 1) == 0)
        {
            goto label_43;
        }
        
        long val_31 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {});
        val_34 = this.丝且与丝丒丟万丁专.丘丕且三与业不七万;
        if(业丂丏与世一丏业不.丑七不且上丗丁一世().三丝丂丟丒且丐东丘().上丈丛一丑丏丂世丆() > val_34)
        {
                val_34 = 业丂丏与世一丏业不.丑七不且上丗丁一世().三丝丂丟丒且丐东丘().上丈丛一丑丏丂世丆();
        }
        
        if(val_31 <= val_34)
        {
            goto label_31;
        }
        
        val_31 = val_31 + (Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丆一上丄业世丝丙上());
        val_35 = (long)UnityEngine.Mathf.Max(a:  val_31, b:  (Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丏丘丆下丑世七丒丕()) + PixelTime.丝丗专上三不丄丑丑());
        goto label_37;
        label_4:
        val_33 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_33;
        return (bool)val_33;
        label_31:
        val_35 = (专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {})) + ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丆一上丄业世丝丙上()) << );
        label_37:
        float val_28 = UnityEngine.Mathf.Max(a:  0f, b:  (float)val_35 - PixelTime.丝丗专上三不丄丑丑());
        if(val_28 > 0f)
        {
                val_33 = 0;
            this.丝且与丝丒丟万丁专.丆丙丐专七丐一丞万 = val_32.StartCoroutine(routine:  val_32.丛丘丘丆一与七丑三(丆丐七丅丆丗丛上与:  val_28));
            return (bool)val_33;
        }
        
        label_43:
        val_33 = 0;
        return (bool)val_33;
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
