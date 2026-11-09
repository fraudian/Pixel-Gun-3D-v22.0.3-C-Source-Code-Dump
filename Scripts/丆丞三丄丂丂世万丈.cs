using UnityEngine;
private sealed class WeaponInfoInRespawnWindow.丆丞三丄丂丂世万丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponInfoInRespawnWindow 丝且与丝丒丟万丁专;
    public float 与丈业丛丝丒丙一丏;
    public float 丝三业丛丘且不丝丆;
    private float 业丂专丝丗丛丟一三;
    private float 专世丑三丅一业上一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponInfoInRespawnWindow.丆丞三丄丂丂世万丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UISprite val_6;
        float val_7;
        int val_8;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.业丂专丝丗丛丟一三 = this.丝且与丝丒丟万丁专.barSprite.fillAmount;
        this.专世丑三丅一业上一 = 0f;
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        val_7 = this.丝三业丛丘且不丝丆;
        if(this.丝且与丝丒丟万丁专.barSprite.fillAmount < 0)
        {
            goto label_8;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.barSprite;
        val_6.fillAmount = val_7;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_8:
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.专世丑三丅一业上一 + val_3;
        this.专世丑三丅一业上一 = val_3;
        val_7 = UnityEngine.Mathf.Lerp(a:  this.业丂专丝丗丛丟一三, b:  this.丝三业丛丘且不丝丆, t:  val_3 / this.与丈业丛丝丒丙一丏);
        this.丝且与丝丒丟万丁专.barSprite.fillAmount = val_7;
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
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
