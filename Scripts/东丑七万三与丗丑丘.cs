using UnityEngine;
private sealed class AccountsMenuItem.东丑七万三与丗丑丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AccountsMenuItem 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AccountsMenuItem.东丑七万三与丗丑丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        AccountsMenuItem val_22;
        var val_23;
        object val_25;
        int val_26;
        var val_27;
        val_22 = this.丝且与丝丒丟万丁专;
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
            goto label_51;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_23 = null;
        val_23 = null;
        val_22 = AccountsMenuItem.<>c.<>9__35_0;
        if(val_22 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_22 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  AccountsMenuItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AccountsMenuItem.<>c::丏七一丒丛丂丁丁世());
            AccountsMenuItem.<>c.<>9__35_0 = val_22;
        }
        
        UnityEngine.WaitUntil val_2 = null;
        val_25 = val_2;
        val_2 = new UnityEngine.WaitUntil(predicate:  val_1);
        val_26 = 1;
        this.丒上七丌业七丟与丐 = val_25;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        丅丛丟上丁丆上丛专.上且万万丆专万一上(丙业与丙丗丝不丈东:  false);
        int val_5 = 丅丛丟上丁丆上丛专.世专丑七丈丕与上世(业丕丄专与与上丌业:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专(), 丑与丙丒且一业万丈:  AccountsMenuItem.与与丆丞世丒丐丁上(), 丞世丌丗世丑业业与:  true);
        label_10:
        val_25 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
        if(val_25.下不丙丌丙丞丞万上() == false)
        {
            goto label_51;
        }
        
        if(丅丛丟上丁丆上丛专.且一东三万丄且业丘() == false)
        {
            goto label_21;
        }
        
        val_25 = 1152921505256366080;
        if((上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != false) && ((System.String.op_Inequality(a:  丅丛丟上丁丆上丛专.业丟不七丄且不东下(), b:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专())) != false))
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丅丛丟上丁丆上丛专.业丟不七丄且不东下())) != false)
        {
                if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() == null)
        {
            goto label_37;
        }
        
        }
        
        }
        
        val_22 = 丅丛丟上丁丆上丛专.下丂且丕与世丄丝万();
        if(val_22 == null)
        {
                return (bool)val_26;
        }
        
        if((val_22.丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != true)
        {
                七专万下丄世丞丂且.且万万一丘世业且与(丙业与丙丗丝不丈东:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专());
            val_22 = 七专万下丄世丞丂且.丑七不且上丗丁一世();
            val_27 = null;
            val_27 = null;
            val_22.丛业丏且万专丛世丙(丈东丘丏与丌东东下:  MainMenuController.丄丞丁丈与业上丞丟 + 24.transform, 丘下丌丁丁丌丄丕丙:  true);
        }
        
        label_51:
        val_26 = 0;
        return (bool)val_26;
        label_21:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_26;
        label_37:
        val_22.丛丛丆丐专丁丅丌与();
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
