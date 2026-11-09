using UnityEngine;
private sealed class FreeAwardShowHandler.丗丘丞七丙丕丘东万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreeAwardShowHandler 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreeAwardShowHandler.丗丘丞七丙丕丘东万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        int val_7;
        UnityEngine.WaitForSecondsRealtime val_8;
        int val_9;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专._headerTextTimer == 0)
        {
            goto label_8;
        }
        
        this.丗丕专丐丞丞下不丒 = 0;
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        if((this.业丘丝业丛丆丄一上 & 1) == 0)
        {
                val_7 = Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().与丈下不丏丁丛丒丐();
            if(val_7 > 0)
        {
                val_7 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_7, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            this.丝且与丝丒丟万丁专._headerTextTimer.Text = val_7;
            val_8 = this.丗丕专丐丞丞下不丒;
            if(val_8 == null)
        {
                UnityEngine.WaitForSecondsRealtime val_5 = null;
            val_8 = val_5;
            val_5 = new UnityEngine.WaitForSecondsRealtime(time:  0.5f);
            this.丗丕专丐丞丞下不丒 = val_8;
        }
        
            val_9 = 1;
            this.丒上七丌业七丟与丐 = val_8;
            this.丗丏丅丕丆世丁专丟 = val_9;
            return (bool)val_9;
        }
        
            val_6 = System.String.alignConst;
            this.丝且与丝丒丟万丁专._headerTextTimer.Text = val_6;
        }
        
        label_8:
        val_9 = 0;
        return (bool)val_9;
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
