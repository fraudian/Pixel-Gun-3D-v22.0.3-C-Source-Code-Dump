using UnityEngine;
private sealed class PlayerBotsManager.丄丈丕丁丈丟不丈专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBotsManager 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerBotsManager.丄丈丕丁丈丟不丈专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_51;
        float val_52;
        var val_53;
        WeaponManager val_54;
        bool val_55;
        int val_56;
        bool val_57;
        var val_58;
        var val_59;
        int val_60;
        System.Collections.Generic.List<PlayerBotController> val_61;
        int val_62;
        var val_63;
        var val_64;
        int val_65;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_51 = 1152921505189007360;
        val_52 = 5f;
        if((TimeGameController.丄丞丁丈与业上丞丟 != 0) && (TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 <= 39))
        {
                val_52 = 1f;
        }
        
        val_53 = null;
        val_53 = null;
        val_54 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_65;
        }
        
        val_54 = TimeGameController.丄丞丁丈与业上丞丟;
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 <= 40)
        {
            goto label_15;
        }
        
        val_55 = 0;
        goto label_16;
        label_1:
        val_56 = 0;
        return (bool)val_56;
        label_15:
        if(this.丝且与丝丒丟万丁专.丌丐上专丑丞上丄下 == true)
        {
            goto label_18;
        }
        
        this.丝且与丝丒丟万丁专.丙与专东不三丄丒丒(丁丝三丌丐丐东上丕:  GameConnect.丆丁上丟丛业丄丅丝());
        val_55 = true;
        label_16:
        this.丝且与丝丒丟万丁专.丌丐上专丑丞上丄下 = val_55;
        label_18:
        bool val_6 = this.丝且与丝丒丟万丁专.东丐丄丂且丒不丌丟(丝业且丈万丏丒三万:  this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛);
        val_51 = this.丝且与丝丒丟万丁专.东丐丄丂且丒不丌丟(丝业且丈万丏丒三万:  this.丝且与丝丒丟万丁专.丞业丆上一丐丟七丂);
        bool val_8 = GameConnect.丆丁上丟丛业丄丅丝();
        if(val_8 == false)
        {
            goto label_23;
        }
        
        if(val_8.丂丑丘上七丞世丐丙() == false)
        {
            goto label_24;
        }
        
        if(this.丝且与丝丒丟万丁专.丌丐上专丑丞上丄下 == true)
        {
            goto label_65;
        }
        
        val_54 = 1152921525522827936;
        val_57 = 1152921525522828960;
        val_58 = 0;
        goto label_26;
        label_41:
        if((val_51 & (this.丝且与丝丒丟万丁专.丞业丆上一丐丟七丂.ContainsKey(key:  this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]))) == false)
        {
            goto label_29;
        }
        
        val_59 = this.丝且与丝丒丟万丁专.丞业丆上一丐丟七丂.Item[this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]];
        val_60 = val_14.丏丙丙丌丑一丅上丆 - 1;
        goto label_33;
        label_29:
        if((val_6 & (this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.ContainsKey(key:  this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]))) == false)
        {
            goto label_36;
        }
        
        val_59 = this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.Item[this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]];
        val_60 = val_19.丏丙丙丌丑一丅上丆 + 1;
        label_33:
        val_59.丛丞丟丙万丞丐丌丝(丙业与丙丗丝不丈东:  val_60);
        label_36:
        val_58 = 1;
        label_26:
        val_61 = this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝;
        if(val_58 < val_61.Count)
        {
            goto label_41;
        }
        
        goto label_65;
        label_23:
        val_54 = 1152921525522827936;
        val_57 = 1152921538690441696;
        val_51 = 0;
        if(val_8.七丑东七且丞丟丙丒() == false)
        {
            goto label_43;
        }
        
        goto label_44;
        label_55:
        val_61 = this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0];
        if((val_6 & (this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.ContainsKey(key:  val_61))) == false)
        {
            goto label_47;
        }
        
        val_61 = this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0];
        丅丘万丑东不业丛不 val_26 = this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.Item[val_61];
        if(val_26 == null)
        {
            goto label_50;
        }
        
        if(this.丝且与丝丒丟万丁专.丌丐上专丑丞上丄下 == false)
        {
            goto label_51;
        }
        
        label_53:
        val_62 = 0;
        goto label_52;
        label_50:
        if(this.丝且与丝丒丟万丁专.丌丐上专丑丞上丄下 == true)
        {
            goto label_53;
        }
        
        label_51:
        val_62 = val_26.丏丙丙丌丑一丅上丆 - 1;
        label_52:
        val_26.丛丞丟丙万丞丐丌丝(丙业与丙丗丝不丈东:  val_62);
        label_47:
        val_51 = 1;
        label_43:
        if(val_51 < this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Count)
        {
            goto label_55;
        }
        
        goto label_65;
        label_64:
        val_61 = this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[1];
        if((val_6 & (this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.ContainsKey(key:  val_61))) != false)
        {
                val_61 = this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[1];
            this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.Item[val_61].丛丞丟丙万丞丐丌丝(丙业与丙丗丝不丈东:  val_32.丏丙丙丌丑一丅上丆 + 1);
        }
        
        val_51 = 2;
        label_44:
        if(val_51 < this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Count)
        {
            goto label_64;
        }
        
        goto label_65;
        label_24:
        val_54 = 1152921538690441696;
        val_63 = 0;
        goto label_66;
        label_87:
        if((val_51 & (this.丝且与丝丒丟万丁专.丞业丆上一丐丟七丂.ContainsKey(key:  this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]))) == false)
        {
            goto label_69;
        }
        
        val_57 = this.丝且与丝丒丟万丁专.丌丐上专丑丞上丄下;
        val_64 = this.丝且与丝丒丟万丁专.丞业丆上一丐丟七丂.Item[this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]];
        if(val_64 == null)
        {
            goto label_72;
        }
        
        if(val_57 == false)
        {
            goto label_73;
        }
        
        label_83:
        val_65 = 3;
        goto label_84;
        label_69:
        if((val_6 & (this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.ContainsKey(key:  this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]))) == false)
        {
            goto label_77;
        }
        
        val_57 = this.丝且与丝丒丟万丁专.丌丐上专丑丞上丄下;
        val_64 = this.丝且与丝丒丟万丁专.丌三丒丟丙与与丌丛.Item[this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝.Item[0]];
        if(val_64 == null)
        {
            goto label_80;
        }
        
        if(val_57 == false)
        {
            goto label_81;
        }
        
        label_85:
        val_65 = 0;
        goto label_82;
        label_72:
        if(val_57 == true)
        {
            goto label_83;
        }
        
        label_73:
        val_65 = val_39.丏丙丙丌丑一丅上丆 + 1;
        goto label_84;
        label_80:
        if(val_57 == true)
        {
            goto label_85;
        }
        
        label_81:
        val_65 = val_44.丏丙丙丌丑一丅上丆 - 1;
        label_84:
        label_82:
        val_64.丛丞丟丙万丞丐丌丝(丙业与丙丗丝不丈东:  val_65);
        label_77:
        val_63 = 1;
        label_66:
        val_61 = this.丝且与丝丒丟万丁专.业丌上丁下七不丐丝;
        if(val_63 < val_61.Count)
        {
            goto label_87;
        }
        
        label_65:
        val_56 = 1;
        this.丗丏丅丕丆世丁专丟 = val_56;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_52);
        return (bool)val_56;
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
