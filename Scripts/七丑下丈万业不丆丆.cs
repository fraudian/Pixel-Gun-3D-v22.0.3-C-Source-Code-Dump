using UnityEngine;
private sealed class FreeAwardShowHandler.七丑下丈万业不丆丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreeAwardShowHandler 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreeAwardShowHandler.七丑下丈万业不丆丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_12 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_12;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_11 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  1f);
            val_12 = 1;
            this.丒上七丌业七丟与丐 = val_11;
            this.丗丏丅丕丆世丁专丟 = val_12;
            return (bool)val_12;
        }
        
        val_11 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专._headerTextTimer != 0) && (this.丝且与丝丒丟万丁专._headerTextTimer.isActiveAndEnabled != false))
        {
                val_13 = (~(System.String.IsNullOrWhiteSpace(value:  this.丝且与丝丒丟万丁专._headerTextTimer.Text))) & 1;
        }
        else
        {
                val_13 = 0;
        }
        
        val_14 = null;
        if(FreeAwardShowHandler.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[FreeAwardShowHandler.OnEnable+EnsureTimerCoroutine] isTimerTicking: "("[FreeAwardShowHandler.OnEnable+EnsureTimerCoroutine] isTimerTicking: ") + val_13.ToString());
            val_13 = val_13;
        }
        
        if(val_13 != 0)
        {
                val_12 = 0;
            return (bool)val_12;
        }
        
        this.丝且与丝丒丟万丁专.上丈丛七且与丝丙丌 = true;
        val_15 = null;
        val_11.丈丑丈三且且且下丌(丌且丁丐丁丅上丏丅:  FreeAwardShowHandler.世丈且业丆丑丏丐一());
        val_12 = 0;
        this.丝且与丝丒丟万丁专.上丈丛七且与丝丙丌 = false;
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
