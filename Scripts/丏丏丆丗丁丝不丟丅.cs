using UnityEngine;
private sealed class FriendsController.丏丏丆丗丁丝不丟丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 且丆万丕丐丛三丙丟;
    public FriendsController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendsController.丏丏丆丗丁丝不丟丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_15;
        int val_16;
        var val_17;
        var val_18;
        System.Func<丙与不与七丌丟上东, System.String> val_20;
        var val_21;
        int val_22;
        if((this.丗丏丅丕丆世丁专丟 - 2) < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_23;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
            goto label_4;
        }
        
        UnityEngine.WaitForSeconds val_3 = null;
        val_15 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_16 = 1;
        this.丒上七丌业七丟与丐 = val_15;
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_17 = 1152921505132351488;
        val_15 = this.丝且与丝丒丟万丁专;
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一() == null)
        {
            goto label_8;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_18 = null;
        val_18 = null;
        val_20 = FriendsController.<>c.<>9__151_0;
        if(val_20 == null)
        {
                System.Func<丙与不与七丌丟上东, System.String> val_8 = null;
            val_20 = val_8;
            val_8 = new System.Func<丙与不与七丌丟上东, System.String>(object:  FriendsController.<>c.__il2cppRuntimeField_static_fields, method:  System.String FriendsController.<>c::与丘丟丛下七七丑三(丙与不与七丌丟上东 三丟东丕丄丄下下丑));
            FriendsController.<>c.<>9__151_0 = val_20;
        }
        
        val_5.Add(key:  "ids", value:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丙与不与七丌丟上东, System.String>(source:  丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏(), selector:  val_8)));
        val_17 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_21 = null;
        val_21 = null;
        if((val_17.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.与业丄一丑丟万下丙, 一丐丗丁丞丆丅丟丄:  val_5, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  val_15, 丛丌丙世专世东丕下:  System.Void FriendsController::丁丗东丌丐七且七丆(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)))) != 1)
        {
            goto label_23;
        }
        
        val_15.东丆丗丄丁丁三丞丒(且丆万丕丐丛三丙丟:  30f);
        goto label_23;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = 1152921505065418752;
        FriendsController.丘世且丞丂一丒丙丕(丙业与丙丗丝不丈东:  true);
        val_16 = FriendsController.与丆丂丏丝上三丗世;
        if(val_16 == null)
        {
                return (bool)val_16;
        }
        
        val_16.Invoke();
        label_23:
        val_16 = 0;
        return (bool)val_16;
        label_8:
        val_22 = 3;
        this.丒上七丌业七丟与丐 = 0;
        goto label_28;
        label_4:
        UnityEngine.WaitForSeconds val_14 = null;
        val_15 = val_14;
        val_14 = new UnityEngine.WaitForSeconds(seconds:  this.且丆万丕丐丛三丙丟);
        this.丒上七丌业七丟与丐 = val_15;
        val_22 = 2;
        label_28:
        this.丗丏丅丕丆世丁专丟 = val_22;
        val_16 = 1;
        return (bool)val_16;
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
