using UnityEngine;
private sealed class SettingsTabAccount.丆丁丕东丏丟丝三东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private SettingsTabAccount.不丞丛丑万丗丏丄丟 丄丌丂东丘丗一万且;
    public SettingsTabAccount 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SettingsTabAccount.丆丁丕东丏丟丝三东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_25;
        var val_26;
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
            goto label_60;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11) || (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2))
        {
            goto label_45;
        }
        
        if(((System.String.op_Inequality(a:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专(), b:  System.String.alignConst)) == false) || ((System.String.op_Equality(a:  丅丛丟上丁丆上丛专.业丟不七丄且不东下(), b:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专())) == false))
        {
            goto label_15;
        }
        
        InfoWindowController.丟丂不丘丂下上与世(丏不丄丑丝丁丘万不:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7746"));
        goto label_45;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_51:
        if((mem[this.丄丌丂东丘丗一万且] + 24 + 16) == 0)
        {
            goto label_23;
        }
        
        if((mem[this.丄丌丂东丘丗一万且] + 16) == 0)
        {
            goto label_60;
        }
        
        mem2[0] = 0;
        goto label_45;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(UnityEngine.Application.isEditor != true)
        {
                this.丝且与丝丒丟万丁专.不丁丅丒丗丁专丌三();
        }
        
        label_60:
        val_25 = 0;
        return (bool)val_25;
        label_23:
        val_25 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
        label_15:
        SettingsTabAccount.世东丒与丞七不不东 val_10 = new SettingsTabAccount.世东丒与丞七不不东();
        bool val_12 = Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅();
        if(val_10 == null)
        {
            goto label_34;
        }
        
        bool val_13 = val_12;
        .丌丙丅丄下三丈丐丅 = val_13;
        if(val_13 == false)
        {
            goto label_35;
        }
        
        label_45:
        val_26 = 0;
        if((CloudHashMigrationValidator.七一一丑七丒上丐丑(丛专下丞丒丛下下与:  false)) != false)
        {
                if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() != false)
        {
                val_26 = 0;
        }
        else
        {
                CloudHashMigrationValidator.丄万丁三业万丛东丑();
            val_26 = 1;
        }
        
        }
        
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.世丐不丗不业七丘丐(与下丛丂丒丘丛三丆:  true, 丄丌丟丛丆丝东世一:  false, 丙丛丐东与丒且丂上:  true, 且丏下一下上丟与丐:  true));
        this.丗丏丅丕丆世丁专丟 = 2;
        val_25 = 1;
        return (bool)val_25;
        label_34:
        mem[16] = val_12;
        if(mem[16] == true)
        {
            goto label_45;
        }
        
        label_35:
        SettingsTabAccount.不丞丛丑万丗丏丄丟 val_21 = new SettingsTabAccount.不丞丛丑万丗丏丄丟();
        this.丄丌丂东丘丗一万且 = val_21;
        .东丟且丗且三专丙丁 = val_10;
        mem[1152921538965433728] = 0;
        Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丟丕丕丌丈业丝丅丅(业丏丈世世世丞丒世:  new System.Action<System.Boolean>(object:  val_21, method:  System.Void SettingsTabAccount.不丞丛丑万丗丏丄丟::丝丘丗专丂业丞东丕(bool 丐万丗丒下七丟丁三)), 与且专丏丅世丐丐丑:  false);
        goto label_51;
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
