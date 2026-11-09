using UnityEngine;
private sealed class ConnectScene.丘丟丘一丈与丄丟丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ConnectScene 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectScene.丘丟丘一丈与丄丟丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        int val_9;
        var val_10;
        var val_11;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_24;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专.connectScenePanelEventHint.mapEventWindow == 0) || (this.丝且与丝丒丟万丁专.connectScenePanelEventHint.mapEventWindow.rateWindow == 0))
        {
            goto label_13;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.connectScenePanelEventHint.mapEventWindow.rateWindow.gameObject;
        if(val_8.activeSelf == true)
        {
            goto label_24;
        }
        
        label_13:
        val_8 = 1152921505052479488;
        val_10 = static_value_081DACA8;
        val_10 = static_value_081DACA8;
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
        {
                val_11 = static_value_081DACA8;
            val_11 = static_value_081DACA8;
            mem2[0] = 0;
            val_8 = ReviewHUDWindow.丑七不且上丗丁一世();
            val_8.ShowWindowRating();
        }
        
        label_24:
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
