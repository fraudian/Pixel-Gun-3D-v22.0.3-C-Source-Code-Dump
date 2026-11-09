using UnityEngine;
private sealed class QuietAuthorization.丈丙丘丝上不丐丝且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public QuietAuthorization.丈丙丘丝上不丐丝且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_17;
        var val_18;
        System.Func<System.Boolean> val_20;
        int val_21;
        var val_22;
        val_17 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_23;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_18 = null;
        val_18 = null;
        val_20 = QuietAuthorization.<>c.<>9__8_0;
        if(val_20 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_20 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  QuietAuthorization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean QuietAuthorization.<>c::不专丕三丄丘不丑下());
            QuietAuthorization.<>c.<>9__8_0 = val_20;
        }
        
        val_21 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_1);
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_17 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专一丌丗丟丏丑丟丁();
        if((System.String.op_Inequality(a:  val_17, b:  UnityEngine.SystemInfo.deviceUniqueIdentifier)) == false)
        {
            goto label_18;
        }
        
        val_17 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专一丌丗丟丏丑丟丁();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_17)) == false)
        {
            goto label_18;
        }
        
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下丝丛丆丝且丁丞丁(丙业与丙丗丝不丈东:  "");
        val_17 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_17.丗丟万丂丘丈专丄丂();
        goto label_23;
        label_18:
        val_22 = null;
        if(Progress.七上上丟丗丏一不与.丑不丗丏丂丈丗丛世() != false)
        {
                val_22 = null;
            val_21 = 0;
            Progress.下丁下丂七丆丙七一.丙丘七丝丘丕丙丅专 = true;
            return (bool)val_21;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丘下世万丝丑丐丐(东七丛丝丑专世丏三:  Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丝丆且丂丐丄丘三与());
        val_17 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_17.三丅丂三专七万专万();
        label_23:
        val_21 = 0;
        return (bool)val_21;
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
