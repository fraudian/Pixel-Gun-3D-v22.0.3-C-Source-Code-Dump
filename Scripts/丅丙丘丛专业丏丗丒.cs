using UnityEngine;
private sealed class ClansController.丅丙丘丛专业丏丗丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClansController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClansController.丅丙丘丛专业丏丗丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_5;
        int val_6;
        var val_7;
        System.Func<System.Boolean> val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = null;
        val_4 = null;
        ClansController.万丗丘丙丁丆三丑万 = 0;
        ClansController.丟丞丆上下业丟丙丞(丙业与丙丗丝不丈东:  false);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        val_5 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.专丕丛丕与丆东且丘 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丂丐丝东丕丅丑丐七();
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_5:
        mem[72] = 0;
        mem[41] = 0;
        mem[42] = 0;
        mem[56] = 0;
        mem[48] = 0;
        val_5 = 64;
        mem[64] = 0;
        label_6:
        this.丝且与丝丒丟万丁专.<专丄下丒丝丆丌丐东>k__BackingField.业丕丘丁丏丗专丕丁();
        mem[64] = this.丝且与丝丒丟万丁专.<专丄下丒丝丆丌丐东>k__BackingField.世且丐丄丕与丝丆丛();
        val_7 = null;
        val_7 = null;
        val_9 = ClansController.<>c.<>9__92_0;
        if(val_9 == null)
        {
                System.Func<System.Boolean> val_2 = null;
            val_9 = val_2;
            val_2 = new System.Func<System.Boolean>(object:  ClansController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClansController.<>c::丐一不且与丈丆一丄());
            ClansController.<>c.<>9__92_0 = val_9;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_2);
        this.丗丏丅丕丆世丁专丟 = val_6;
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
