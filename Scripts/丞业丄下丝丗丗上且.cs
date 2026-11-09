using UnityEngine;
private sealed class ClansController.丞业丄下丝丗丗上且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClansController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClansController.丞业丄下丝丗丗上且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_11;
        var val_12;
        System.Func<System.Boolean> val_14;
        int val_15;
        val_11 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = null;
        val_12 = null;
        val_14 = ClansController.<>c.<>9__62_0;
        if(val_14 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_14 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  ClansController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClansController.<>c::丗丘丅丕丝东丒丛丒());
            ClansController.<>c.<>9__62_0 = val_14;
        }
        
        val_15 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_1);
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丞丗丑丈一丅丗丌丟() == null)
        {
                return (bool)val_15;
        }
        
        val_11 = this.丝且与丝丒丟万丁专.丞丗丑丈一丅丗丌丟().丁丏丌丟丂丌一七与();
        if((System.String.op_Inequality(a:  val_11, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1440");
            InfoWindowController.七丏不丕丈丁丗丒不(丕丗丘丑丛与丑业丒:  val_11, 世丙丁丗业丝世丕丈:  0, 不且丁丐不丌丟上丌:  this.丝且与丝丒丟万丁专.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌(), 不上丏上丝丆一丛丑:  0);
        }
        
        label_13:
        val_15 = 0;
        return (bool)val_15;
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
