using UnityEngine;
private sealed class UpdatesChecker.业丌三丘丈丅丝丟下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UpdatesChecker 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 丝专万丌七业丑万丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UpdatesChecker.业丌三丘丈丅丝丟下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        UnityEngine.WaitForSeconds val_9;
        var val_10;
        System.Collections.Generic.List<VersionChange> val_11;
        bool val_12;
        int val_13;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丝专万丌七业丑万丕 = val_9;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = null;
        val_10 = null;
        val_11 = UpdatesChecker.丝不丒与万世下一丘;
        if(val_11 == null)
        {
            goto label_6;
        }
        
        val_11 = UpdatesChecker.丝不丒与万世下一丘;
        if(val_11 == null)
        {
                val_11 = 0;
        }
        
        List.Enumerator<T> val_2 = val_11.GetEnumerator();
        label_17:
        if((1691273264 & 1) == 0)
        {
            goto label_10;
        }
        
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  X22)) == true) || ((UpdatesChecker.专三丄丙丘世丁丘世(丝丅丏丙丞丟丕丘上:  val_4.丐丏七丌丕丗业且上())) == true))
        {
            goto label_17;
        }
        
        val_12 = 0;
        goto label_18;
        label_10:
        val_12 = 1;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_10 = null;
        val_10 = null;
        UpdatesChecker.丄丙丙万丅丐三丞丂 = ;
        label_6:
        val_10 = null;
        if(UpdatesChecker.丄丙丙万丅丐三丞丂 == false)
        {
            goto label_29;
        }
        
        this.丝且与丝丒丟万丁专.万丂丌丘丈丏丟丟一();
        label_2:
        val_13 = 0;
        return (bool)val_13;
        label_29:
        val_9 = this.丝专万丌七业丑万丕;
        label_3:
        val_13 = 1;
        this.丒上七丌业七丟与丐 = val_9;
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
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
