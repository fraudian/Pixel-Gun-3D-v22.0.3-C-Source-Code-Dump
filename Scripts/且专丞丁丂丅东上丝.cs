using UnityEngine;
private sealed class RewardETControllerUi.且专丞丁丂丅东上丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RewardETControllerUi 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RewardETControllerUi.且专丞丁丂丅东上丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        var val_7;
        var val_8;
        val_5 = 94128;
        val_6 = 0;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_6;
        if(this.丝且与丝丒丟万丁专 == null)
        {
                val_5 = 0;
        }
        
        if(val_5.丑且丁丄丛丐一丌三() != false)
        {
                if(ActivityIndicator.丙专三丙丌丝丏丌丅() == false)
        {
            goto label_6;
        }
        
        }
        
        val_6 = 1;
        goto label_7;
        label_1:
        val_7 = 0;
        val_8 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_8;
        }
        
        return (bool)val_8;
        label_6:
        System.Collections.Generic.List<RewardParameters> val_3 = LeaderboardEventController.丑丐丄丆丛丁丟丗丅.丛丑丐三三丄与丞丗();
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丘丞丘丘一下丌上七 = val_3;
        }
        else
        {
                mem[168] = val_3;
        }
        
        if(this.丝且与丝丒丟万丁专._generalPanelGo != 0)
        {
                this.丝且与丝丒丟万丁专.Show();
        }
        
        val_6 = 2;
        this.丝且与丝丒丟万丁专.丅东三丒且丅丄丐丒 = 0;
        label_7:
        val_7 = 1;
        this.丒上七丌业七丟与丐 = 0;
        label_8:
        val_8 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_8;
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
