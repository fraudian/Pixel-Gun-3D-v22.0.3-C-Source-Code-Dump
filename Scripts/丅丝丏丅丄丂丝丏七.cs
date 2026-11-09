using UnityEngine;
private sealed class LevelUpBanner.丅丝丏丅丄丂丝丏七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LevelUpBanner 丝且与丝丒丟万丁专;
    private float 不丐业东东不丅丐下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelUpBanner.丅丝丏丅丄丂丝丏七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_13;
        float val_14;
        var val_15;
        int val_16;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Vector3 val_2 = this.丝且与丝丒丟万丁专.downArrow.transform.position;
        val_13 = val_2.y;
        UnityEngine.Vector3 val_4 = this.丝且与丝丒丟万丁专.lowBorderContent.transform.position;
        val_4.y = val_13 - val_4.y;
        val_14 = 0f;
        val_15 = this;
        this.不丐业东东不丅丐下 = UnityEngine.Mathf.Max(a:  val_14, b:  val_4.y);
        goto label_10;
        label_1:
        val_15 = this;
        val_14 = this.不丐业东东不丅丐下;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_10:
        if(val_14 > 0f)
        {
            goto label_11;
        }
        
        label_2:
        val_16 = 0;
        return (bool)val_16;
        label_11:
        float val_7 = UnityEngine.Time.deltaTime * 3f;
        this.不丐业东东不丅丐下 = UnityEngine.Mathf.Max(a:  0f, b:  this.不丐业东东不丅丐下 - val_7);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  UnityEngine.Mathf.Min(a:  this.不丐业东东不丅丐下, b:  val_7));
        val_13 = val_12.x;
        this.丝且与丝丒丟万丁专.bannerScroll.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_13, y = val_12.y, z = val_12.z});
        val_16 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
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
