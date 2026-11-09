using UnityEngine;
private sealed class AuthSceneController.一丟丘丈丒丁一丛丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AuthSceneController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.一丟丘丈丒丁一丛丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_9;
        System.Func<System.Boolean> val_11;
        int val_12;
        var val_13;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.83f));
        val_9 = null;
        val_9 = null;
        val_11 = AuthSceneController.<>c.<>9__111_0;
        if(val_11 == null)
        {
                System.Func<System.Boolean> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Func<System.Boolean>(object:  AuthSceneController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AuthSceneController.<>c::丅丒丆丝丆丑丌丑丂());
            AuthSceneController.<>c.<>9__111_0 = val_11;
        }
        
        val_12 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_2);
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 8)
        {
            goto label_14;
        }
        
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.84f));
        val_8 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_8.东丘下世万丝丑丐丐(东七丛丝丑专世丏三:  Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丝丆且丂丐丄丘三与());
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_14:
        val_8 = 1152921505359773696;
        val_13 = null;
        val_13 = null;
        val_12 = 0;
        Progress.下丁下丂七丆丙七一.丙丘七丝丘丕丙丅专 = true;
        return (bool)val_12;
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
