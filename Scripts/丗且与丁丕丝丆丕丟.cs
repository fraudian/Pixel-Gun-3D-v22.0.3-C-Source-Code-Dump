using UnityEngine;
private sealed class 东下丗世丘上丞世丛.丗且与丁丕丝丆丕丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private bool 且丞丞专丅下丞丗丅;
    private UnityEngine.WaitForSecondsRealtime 丐丁丄上丛专丙丞下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 东下丗世丘上丞世丛.丗且与丁丕丝丆丕丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        var val_13;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_4;
        }
        
        val_12 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_12;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(UnityEngine.Application.isEditor != true)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_10;
        }
        
        }
        
        this.且丞丞专丅下丞丗丅 = false;
        this.丐丁丄上丛专丙丞下 = new UnityEngine.WaitForSecondsRealtime(time:  0.5f);
        goto label_23;
        label_10:
        val_12 = 0;
        return (bool)val_12;
        label_4:
        Rilisoft.业丙丘丆东丈丕丂丄 val_7 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丐上丙世丂丅丝不丈(丁丅丈丌丟世丗丗丟:  110);
        if(val_7 == null)
        {
            goto label_23;
        }
        
        long val_8 = PixelTime.丙丅丅业丟丁世丁丗();
        System.Nullable<System.TimeSpan> val_9 = val_7.丏丈丑丐上三丙不丟(丝丙一丝丈丂不丙一:  new System.Nullable<System.Int64>() {HasValue = false});
        if((1618126896 & 1) == 0)
        {
            goto label_21;
        }
        
        double val_11 = val_9.HasValue.丐丏七丌丕丗业且上().TotalSeconds;
        if(val_11 > 0f)
        {
                this.且丞丞专丅下丞丗丅 = true;
        }
        
        if(val_11 > 0f)
        {
            goto label_23;
        }
        
        label_21:
        if(this.且丞丞专丅下丞丗丅 != false)
        {
                val_13 = null;
            val_13 = null;
            if(东下丗世丘上丞世丛.丌七丙上丑丗丏一三 != null)
        {
                东下丗世丘上丞世丛.丌七丙上丑丗丏一三.Invoke();
        }
        
        }
        
        this.且丞丞专丅下丞丗丅 = false;
        label_23:
        val_12 = 1;
        this.丗丏丅丕丆世丁专丟 = val_12;
        this.丒上七丌业七丟与丐 = this.丐丁丄上丛专丙丞下;
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
