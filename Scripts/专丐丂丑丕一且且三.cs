using UnityEngine;
private sealed class BPNextLevelRewardView.专丐丂丑丕一且且三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPNextLevelRewardView 丝且与丝丒丟万丁专;
    private int 不专业与丛丂丆丒世;
    private UnityEngine.WaitForSecondsRealtime 丘丝丒丞丅丛万丗丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPNextLevelRewardView.专丐丂丑丕一且且三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_8;
        int val_9;
        int val_10;
        int val_11;
        UnityEngine.WaitForSecondsRealtime val_12;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.不专业与丛丂丆丒世 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丘丝丒丞丅丛万丗丅 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(this.丝且与丝丒丟万丁专._centerOnChild == 0)
        {
            goto label_8;
        }
        
        val_8 = this.丝且与丝丒丟万丁专;
        val_9 = this;
        if(this.丝且与丝丒丟万丁专.丄七丗业丐万丁丆丄.Count <= this.不专业与丛丂丆丒世)
        {
            goto label_14;
        }
        
        this.丝且与丝丒丟万丁专._centerOnChild.CenterOn(丞下万上三丘上与专:  this.丝且与丝丒丟万丁专.丄七丗业丐万丁丆丄.Item[this.不专业与丛丂丆丒世].transform);
        goto label_14;
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_8:
        val_9 = this.不专业与丛丂丆丒世;
        val_8 = this.丝且与丝丒丟万丁专.丄七丗业丐万丁丆丄;
        label_14:
        if((val_9 + 1) == this.丝且与丝丒丟万丁专.丄七丗业丐万丁丆丄.SyncRoot.Count)
        {
                val_11 = 0;
        }
        else
        {
                val_11 = val_9 + 1;
        }
        
        mem2[0] = val_11;
        val_12 = this.丘丝丒丞丅丛万丗丅;
        if(val_12 == null)
        {
                UnityEngine.WaitForSecondsRealtime val_7 = null;
            val_12 = val_7;
            val_7 = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专._rotateTSeconds);
            this.丘丝丒丞丅丛万丗丅 = val_12;
        }
        
        val_10 = 1;
        this.丒上七丌业七丟与丐 = val_12;
        this.丗丏丅丕丆世丁专丟 = val_10;
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
