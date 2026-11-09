using UnityEngine;
private sealed class AuthSceneController.业且丘丆东下丅丄不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AuthSceneController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.业且丘丆东下丅丄不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        AuthSceneController val_20;
        var val_21;
        object val_23;
        int val_24;
        System.Collections.IEnumerator val_25;
        System.Collections.IEnumerator val_26;
        val_20 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_33;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.83f));
        val_21 = null;
        val_21 = null;
        val_20 = AuthSceneController.<>c.<>9__75_0;
        if(val_20 == null)
        {
                System.Func<System.Boolean> val_2 = null;
            val_20 = val_2;
            val_2 = new System.Func<System.Boolean>(object:  AuthSceneController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AuthSceneController.<>c::且丝下下丑丗三丒业());
            AuthSceneController.<>c.<>9__75_0 = val_20;
        }
        
        UnityEngine.WaitUntil val_3 = null;
        val_23 = val_3;
        val_3 = new UnityEngine.WaitUntil(predicate:  val_2);
        val_24 = 1;
        this.丒上七丌业七丟与丐 = val_23;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_23 = 1152921505359773696;
        if(((System.String.op_Inequality(a:  Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专一丌丗丟丏丑丟丁(), b:  UnityEngine.SystemInfo.deviceUniqueIdentifier)) != false) && ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专一丌丗丟丏丑丟丁())) != false))
        {
                val_25 = val_20.丘不丏丘丛丝东丘丁(不丁一丁丁丛丘丌丅:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        }
        else
        {
                if(new 丒下丄与丏三世丘丝().丒丙丂丒丟丈丞丞万() != true)
        {
                if((PGCompany.三丙丅丅七丘丒丗丂.丟不下下且业丛丄丏(丞丅上丏丂且下丅与:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_29;
        }
        
        }
        
            if(val_20 != null)
        {
                val_26 = val_20.与丗丙上丅三且不丈();
        }
        else
        {
                val_26 = 0.与丗丙上丅三且不丈();
        }
        
            val_25 = val_26;
        }
        
        UnityEngine.Coroutine val_19 = val_20.StartCoroutine(routine:  val_25);
        label_33:
        val_24 = 0;
        return (bool)val_24;
        label_29:
        val_20.丑专丐丕专丄丐业东();
        goto label_33;
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
