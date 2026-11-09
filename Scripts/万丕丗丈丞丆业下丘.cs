using UnityEngine;
private sealed class AuthSceneController.万丕丗丈丞丆业下丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.万丕丗丈丞丆业下丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        System.Func<System.Boolean> val_6;
        int val_7;
        val_3 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_3;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            丅丛丟上丁丆上丛专.业丁丂七上丗丟丙丟(丈丌丐丟一上世丝丞:  true);
            val_4 = null;
            val_4 = null;
            val_6 = AuthSceneController.<>c.<>9__123_0;
            if(val_6 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  AuthSceneController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AuthSceneController.<>c::丏丂丈丙丕丝下丐丟());
            AuthSceneController.<>c.<>9__123_0 = val_6;
        }
        
            val_7 = 1;
            val_3 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_1);
        }
        else
        {
                val_7 = 0;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_3;
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
