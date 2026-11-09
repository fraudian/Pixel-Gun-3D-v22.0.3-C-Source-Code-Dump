using UnityEngine;
private sealed class InfoWindowController.丟丝丞丂丙丝七下丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InfoWindowController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InfoWindowController.丟丝丞丂丙丝七下丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        var val_10;
        var val_11;
        UnityEngine.WaitForSeconds val_12;
        int val_13;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = null;
        val_9 = null;
        int val_2 = InfoWindowController.东万下丅下东七一万.Count;
        var val_3 = (val_2 > 0) ? 1 : 0;
        if(val_2 <= 0)
        {
            goto label_5;
        }
        
        val_11 = 1;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_19;
        }
        
        label_23:
        if(val_11 == 0)
        {
            goto label_7;
        }
        
        label_24:
        val_12 = this.丝且与丝丒丟万丁专.丈丂丙丂丘一与丟丄;
        if(val_12 == null)
        {
                UnityEngine.WaitForSeconds val_4 = null;
            val_12 = val_4;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  1f);
            this.丝且与丝丒丟万丁专.丈丂丙丂丘一与丟丄 = val_12;
        }
        
        this.丒上七丌业七丟与丐 = val_12;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_13 = 1;
        return (bool)val_13;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
                val_13 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_13;
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
        label_5:
        List.Enumerator<T> val_5 = this.丝且与丝丒丟万丁专._listReviewWindows.GetEnumerator();
        label_17:
        if(((-908024312) & 1) == 0)
        {
            goto label_15;
        }
        
        if(0.丐丏七丌丕丗业且上().activeInHierarchy == false)
        {
            goto label_17;
        }
        
        val_10 = 1;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_8 = (val_10 != 0) ? 1 : 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_23;
        }
        
        label_19:
        if( != 0)
        {
            goto label_24;
        }
        
        label_7:
        val_13 = 0;
        this.丝且与丝丒丟万丁专.七丑丑丗丏七丏且丄 = 0;
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
