using UnityEngine;
private sealed class LootBoxRewardsViewAllAtOnce.丂与丐三业丒与东丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LootBoxRewardsViewAllAtOnce 丝且与丝丒丟万丁专;
    private float 丘丌丕一上丛下丙上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LootBoxRewardsViewAllAtOnce.丂与丐三业丒与东丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丘丌丕一上丛下丙上 = this.丝且与丝丒丟万丁专.animationTime;
        val_2 = this.丝且与丝丒丟万丁专.animationTime;
        goto label_3;
        label_0:
        val_2 = this.丘丌丕一上丛下丙上;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(val_2 > 0f)
        {
            goto label_4;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丄丛丘且丑丄万丈丙();
        this.丝且与丝丒丟万丁专.丑不与下万一一丂上();
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_4:
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = val_2 - val_1;
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丘丌丕一上丛下丙上 = val_1;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_5:
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
