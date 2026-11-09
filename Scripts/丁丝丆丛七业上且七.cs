using UnityEngine;
private sealed class LevelUpWithOffers.丁丝丆丛七业上且七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LevelUpWithOffers 丝且与丝丒丟万丁专;
    private float 专丁三丏丞丏丑丗上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelUpWithOffers.丁丝丆丛七业上且七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        float val_6;
        float val_7;
        int val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_5 = this;
        this.专丁三丏丞丏丑丗上 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丄且丈丌丝一上丑上(丙业与丙丗丝不丈东:  0);
        goto label_4;
        label_1:
        val_5 = this.专丁三丏丞丏丑丗上;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_6 = mem[this.专丁三丏丞丏丑丗上];
        val_6 = val_5;
        if(val_6 < 0)
        {
            goto label_5;
        }
        
        val_7 = this.丝且与丝丒丟万丁专.不丈丕专丘七丄丒丕;
        this.丝且与丝丒丟万丁专.丄且丈丌丝一上丑上(丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  val_7));
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_5:
        val_9 = 0;
        goto label_10;
        label_15:
        val_6 = 0f;
        this.丝且与丝丒丟万丁专.丄且丈丌丝一上丑上(丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Lerp(a:  val_6, b:  this.丝且与丝丒丟万丁专.不丈丕专丘七丄丒丕, t:  val_5)));
        val_9 = 1;
        label_10:
        if(val_9 < this.丝且与丝丒丟万丁专.coinsStarterBank.Length)
        {
            goto label_15;
        }
        
        val_7 = this.专丁三丏丞丏丑丗上;
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = val_7 + val_4;
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.专丁三丏丞丏丑丗上 = val_4;
        this.丗丏丅丕丆世丁专丟 = val_8;
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
