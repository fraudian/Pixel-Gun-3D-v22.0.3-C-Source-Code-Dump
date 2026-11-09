using UnityEngine;
private sealed class AIBotController.丛且专专且丒丅下丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBot.AIBotController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 万下一丈丄丌三且丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AIBotController.丛且专专且丒丅下丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        UnityEngine.WaitForSeconds val_11;
        int val_12;
        PlayerBot.东不与丕丁丟东丙且 val_13;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(((this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false) || (this.丝且与丝丒丟万丁专.useTestBehavior == true)) || (this.丝且与丝丒丟万丁专.丕丞丑丕一不下丞丙 > 0f))
        {
            goto label_6;
        }
        
        if(this.丝且与丝丒丟万丁专.currentBehaviorType == 3)
        {
            goto label_7;
        }
        
        if(this.丝且与丝丒丟万丁专.currentBehaviorType == 2)
        {
            goto label_8;
        }
        
        if(this.丝且与丝丒丟万丁专.currentBehaviorType != 1)
        {
            goto label_9;
        }
        
        PlayerBot.东不与丕丁丟东丙且 val_3 = this.丝且与丝丒丟万丁专.丒丟丕丘一丁丝丂且();
        goto label_16;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_12;
        }
        
        this.万下一丈丄丌三且丙 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.cycleTime);
        goto label_13;
        label_11:
        val_10 = 0;
        return (bool)val_10;
        label_12:
        this.万下一丈丄丌三且丙 = new UnityEngine.WaitForSeconds(seconds:  0f);
        label_13:
        UnityEngine.WaitForSeconds val_6 = null;
        val_11 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.丛丙东丕丙丙丐丞丙);
        val_12 = 1;
        goto label_15;
        label_7:
        PlayerBot.东不与丕丁丟东丙且 val_7 = this.丝且与丝丒丟万丁专.与丟丝丏丏且与丏丂();
        goto label_16;
        label_8:
        label_16:
        val_13 = this.丝且与丝丒丟万丁专.业丆丒且丒丏丞丒不();
        goto label_17;
        label_9:
        val_13 = 0;
        label_17:
        this.丝且与丝丒丟万丁专.丘业三丌丐丂丈丗丒(丌专丝丘丒丒丟丄上:  val_13);
        label_6:
        val_11 = this.万下一丈丄丌三且丙;
        val_12 = 2;
        label_15:
        val_10 = 1;
        this.丒上七丌业七丟与丐 = val_11;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_10;
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
