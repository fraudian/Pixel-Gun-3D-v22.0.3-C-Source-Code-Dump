using UnityEngine;
private sealed class CampaignPartBase.丕世丒世不丏丏不业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CampaignPartBase 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CampaignPartBase.丕世丒世不丏丏不业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BotChangeDamageMaterial[] val_2;
        var val_3;
        int val_4;
        var val_5;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_3 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_3;
        label_9:
        this.丝且与丝丒丟万丁专.丒东丕丙且上不一丆[0].ShowDamageEffect(万东丏丌不七东丘万:  false, 丗与丟上上丑专世丗:  0);
        val_3 = 1;
        label_3:
        if(val_3 < this.丝且与丝丒丟万丁专.丒东丕丙且上不一丆.Length)
        {
            goto label_9;
        }
        
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        val_5 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_11;
        label_17:
        this.丝且与丝丒丟万丁专.丒东丕丙且上不一丆[0].ResetMainMaterial();
        val_5 = 1;
        label_11:
        val_2 = this.丝且与丝丒丟万丁专.丒东丕丙且上不一丆;
        if(val_5 < this.丝且与丝丒丟万丁专.丒东丕丙且上不一丆.Length)
        {
            goto label_17;
        }
        
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
