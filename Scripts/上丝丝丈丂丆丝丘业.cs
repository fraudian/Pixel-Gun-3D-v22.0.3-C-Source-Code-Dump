using UnityEngine;
private sealed class FriendsController.上丝丝丈丂丆丝丘业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private string 与丛丑七丂专专丏丕;
    private UnityEngine.WWW 丆丑万业丄与丈丏丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendsController.上丝丝丈丂丆丝丘业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_23;
        var val_25;
        var val_26;
        var val_27;
        System.Action val_28;
        if(this.丗丏丅丕丆世丁专丟 > 5)
        {
            goto label_4;
        }
        
        var val_23 = 106017416 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_23 = val_23 + 106017416;
        goto (106017416 + (this.丗丏丅丕丆世丁专丟) << 2 + 106017416);
        label_4:
        val_23 = 0;
        return (bool)val_23;
        label_47:
        this.丗丏丅丕丆世丁专丟 = ;
        val_23 = 1;
        return (bool)val_23;
        label_30:
        val_25 = null;
        val_25 = null;
        if((System.String.op_Equality(a:  Item[0], b:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒)) == true)
        {
            goto label_29;
        }
        
         =  + 1;
        if( < Count)
        {
            goto label_30;
        }
        
        val_26 = 0;
        goto label_31;
        label_29:
        val_26 = 1;
        label_31:
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "localMultyKey", 下下丏一丙不丘丌丞:  (val_26 == 0) ? (1 + 1) : 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        if(val_26 == 0)
        {
                return (bool)val_23;
        }
        
        if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() != true)
        {
                val_27 = null;
            val_27 = null;
            val_28 = FriendsController.丕丐丒下丑丈业丛丛;
            if(val_28 != null)
        {
                val_28 = FriendsController.丕丐丒下丑丈业丛丛;
            if(val_28 == null)
        {
                val_28 = 0;
        }
        
            val_28.Invoke();
        }
        
            Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丘上丐世丆丑且丞丒();
        }
        
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  15f);
        goto label_47;
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
