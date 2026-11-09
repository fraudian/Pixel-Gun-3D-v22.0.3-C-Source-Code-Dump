using UnityEngine;
private sealed class ArmoryCell.且丑丂丁丐丆丏上东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ArmoryCell 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ArmoryCell.且丑丂丁丐丆丏上东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_52;
        string val_53;
        int val_54;
        int val_55;
        string val_56;
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
            goto label_17;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_52 = 1152921504848912384;
        if(this.丝且与丝丒丟万丁专 == 0)
        {
            goto label_17;
        }
        
        val_52 = this.丝且与丝丒丟万丁专.gameObject;
        if(val_52 == 0)
        {
            goto label_17;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_13;
        }
        
        val_53 = this.丝且与丝丒丟万丁专.ItemId;
        goto label_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_52 = 1152921504848912384;
        if(this.丝且与丝丒丟万丁专 == 0)
        {
            goto label_17;
        }
        
        val_52 = this.丝且与丝丒丟万丁专.gameObject;
        if(val_52 != 0)
        {
            goto label_21;
        }
        
        label_17:
        val_54 = 0;
        return (bool)val_54;
        label_21:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_23;
        }
        
        this.丝且与丝丒丟万丁专.丆丆丞一丛丝丞丘丗();
        val_55 = this.丝且与丝丒丟万丁专.丑丒丌且丟下丝丈七 + 1;
        this.丝且与丝丒丟万丁专.丑丒丌且丟下丝丈七 = val_55;
        goto label_24;
        label_13:
        val_53 = 0.ItemId;
        label_14:
        this.丝且与丝丒丟万丁专.丒丒三丅丈万丝不丞 = val_53;
        goto label_25;
        label_23:
        0.丆丆丞一丛丝丞丘丗();
        mem[736] = 1;
        val_55 = mem[736];
        label_24:
        if(1 != 0)
        {
            goto label_35;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.丝且与丝丒丟万丁专.Category)) == false)
        {
            goto label_30;
        }
        
        string val_12 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.丝且与丝丒丟万丁专.ItemId);
        label_76:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_79;
        }
        
        label_80:
        label_79:
        if((System.String.op_Inequality(a:  val_12, b:  this.丝且与丝丒丟万丁专.丈丄七丅下丛丐且丏)) != false)
        {
                this.丝且与丝丒丟万丁专.丈丄七丅下丛丐且丏 = val_12;
            this.丝且与丝丒丟万丁专.丂丅丅丕东丛丌东丑();
        }
        
        label_35:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_36;
        }
        
        this.丝且与丝丒丟万丁专.与业丄与丏上下专业();
        this.丝且与丝丒丟万丁专.丗下三与七且丁丈万();
        this.丝且与丝丒丟万丁专.丈上丝丑东丈业万丅();
        goto label_37;
        label_30:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.丝且与丝丒丟万丁专.Category)) != false)
        {
                if(this.丝且与丝丒丟万丁专.Category != 7)
        {
            goto label_43;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.Category != 7)
        {
            goto label_45;
        }
        
        if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  this.丝且与丝丒丟万丁专.ItemId))) <= 0)
        {
            goto label_52;
        }
        
        string val_22 = this.丝且与丝丒丟万丁专.ItemId;
        goto label_76;
        label_45:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.丝且与丝丒丟万丁专.Category)) == false)
        {
            goto label_58;
        }
        
        string val_26 = 丁下万丟且丟丛下业.丆丏丒丆万丄且丗丛(丗丑丐丕丟丝且下丕:  this.丝且与丝丒丟万丁专.ItemId);
        goto label_76;
        label_43:
        string val_28 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.丝且与丝丒丟万丁专.ItemId);
        goto label_76;
        label_58:
        if(this.丝且与丝丒丟万丁专.Category != 25000)
        {
            goto label_76;
        }
        
        val_56 = this.丝且与丝丒丟万丁专.丈丄七丅下丛丐且丏;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_56)) != false)
        {
                val_56 = Rilisoft.PetsManager.丝丂万丙丑万且丛七(世丐丗专丅三丝丑丆:  this.丝且与丝丒丟万丁专.ItemId);
        }
        
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_56)) != null)
        {
            goto label_76;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_79;
        }
        
        goto label_80;
        label_52:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_79;
        }
        
        goto label_80;
        label_36:
        0.与业丄与丏上下专业();
        0.丗下三与七且丁丈万();
        0.丈上丝丑东丈业万丅();
        label_37:
        this.丝且与丝丒丟万丁专.且与丁丆丂万丂丟上();
        label_25:
        if((this.丝且与丝丒丟万丁专.bg != 0) && (this.丝且与丝丒丟万丁专.bg.isVisible != true))
        {
                val_52 = this.丝且与丝丒丟万丁专.丒丒三丅丈万丝不丞;
            if((val_52.Equals(value:  this.丝且与丝丒丟万丁专.ItemId)) != false)
        {
                val_54 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_54;
            return (bool)val_54;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丒丒三丅丈万丝不丞 = this.丝且与丝丒丟万丁专.ItemId;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.unlocked, 丏业丟一东丂东丘丛:  this.丝且与丝丒丟万丁专.丁丁丏丛丏丅丁世丏());
        if((this.丝且与丝丒丟万丁专.Category != 8) && (this.丝且与丝丒丟万丁专.Category != 2000))
        {
                if(this.丝且与丝丒丟万丁专.Category != 6)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.lockedByLeagueContainer, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.Category == 250000)
        {
                this.丝且与丝丒丟万丁专.equipped.gameObject.SetActive(value:  false);
        }
        
        this.丝且与丝丒丟万丁专.丆丝专丗世丅上丞且();
        this.丝且与丝丒丟万丁专.丆世东七专丕且业丛();
        this.丝且与丝丒丟万丁专.UpdateNewAndTopSeller();
        this.丝且与丝丒丟万丁专.丈业世丝丙专丘丟丕();
        this.丝且与丝丒丟万丁专.与东丕万丗丛专丈丁();
        this.丝且与丝丒丟万丁专.与上丂丕丗丄丘不丏();
        this.丝且与丝丒丟万丁专.万丐三丒丑丑东丄丈();
        this.丝且与丝丒丟万丁专.丞世丗丁世与三上万();
        this.丝且与丝丒丟万丁专.丑下丘世丏丈三丘丞();
        this.丝且与丝丒丟万丁专.丑万丅丂丈东专丞东(一且上丗三丝丈业七:  this.丝且与丝丒丟万丁专.业丌不丞业世丞丗丗());
        this.丝且与丝丒丟万丁专.丟丂丁丄三不且丒丝();
        this.丝且与丝丒丟万丁专.丄丂丏丏丝上丐丞万();
        this.丝且与丝丒丟万丁专.三丆业丐东上东丅丂();
        this.丝且与丝丒丟万丁专.上丕丑丕丗万专丝丐();
        this.丝且与丝丒丟万丁专.丟世不一丏丞专上三();
        this.丝且与丝丒丟万丁专.一丘丈丘丒丏与丙业();
        this.丝且与丝丒丟万丁专.丈上上丆丄且七丘丁();
        this.丝且与丝丒丟万丁专.丏专丈下上丒七世丅();
        this.丝且与丝丒丟万丁专.不丐丆上业三东七万();
        val_52 = CoroutineRunner.世不丗东且丆专专丄(七且丆丞丌丘下世丑:  0.5f);
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  val_52);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_54 = 1;
        return (bool)val_54;
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
