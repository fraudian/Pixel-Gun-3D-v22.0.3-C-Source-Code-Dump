using UnityEngine;
private sealed class AnimationCoroutineRunner.丁丕丕三丂与丝丛世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丄三丗丛丑下丅丏七;
    public UnityEngine.Animation 丆不丝丝上一丞七业;
    public string 七不丐下丟专业万丅;
    public AnimationCoroutineRunner 丝且与丝丒丟万丁专;
    public System.Action 丟丘丙丄丅万丏与丗;
    private UnityEngine.AnimationState 专丌丌东上专丒与丌;
    private bool 一丂丁丙上世丆丝丞;
    private float 万下丙丘丄一业丒三;
    private float 丗丛丆丛丟不丈七一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimationCoroutineRunner.丁丕丕三丂与丝丛世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Animation val_14;
        int val_15;
        bool val_16;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_9;
        }
        
        val_14 = this.丆不丝丝上一丞七业;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_14 == null)
        {
            goto label_4;
        }
        
        if(this.丄三丗丛丑下丅丏七 == false)
        {
            goto label_5;
        }
        
        label_17:
        bool val_1 = val_14.Play(animation:  this.七不丐下丟专业万丅);
        goto label_9;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = 1152921504848912384;
        if(this.丝且与丝丒丟万丁专 != 0)
        {
                if(this.丝且与丝丒丟万丁专.gameObject != 0)
        {
            goto label_13;
        }
        
        }
        
        label_9:
        val_15 = 0;
        return (bool)val_15;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丟丘丙丄丅万丏与丗 != null)
        {
                this.丟丘丙丄丅万丏与丗.Invoke();
        }
        
        val_15 = 0;
        this.专丌丌东上专丒与丌 = 0;
        return (bool)val_15;
        label_4:
        if(this.丄三丗丛丑下丅丏七 == true)
        {
            goto label_17;
        }
        
        label_5:
        val_16 = this;
        this.一丂丁丙上世丆丝丞 = true;
        val_14 = this.七不丐下丟专业万丅;
        mem[1152921524370832872] = val_14.Item[this.七不丐下丟专业万丅];
        mem[1152921524370832884] = 0;
        bool val_6 = val_14.Play(animation:  val_14);
        this.丗丛丆丛丟不丈七一 = UnityEngine.Time.realtimeSinceStartup;
        goto label_19;
        label_13:
        val_16 = this.一丂丁丙上世丆丝丞;
        label_19:
        if(val_16 == false)
        {
            goto label_20;
        }
        
        float val_8 = UnityEngine.Time.realtimeSinceStartup;
        float val_14 = this.丗丛丆丛丟不丈七一;
        val_14 = val_8 - val_14;
        float val_9 = val_14 + this.万下丙丘丄一业丒三;
        this.万下丙丘丄一业丒三 = val_9;
        this.丗丛丆丛丟不丈七一 = val_8;
        float val_10 = this.专丌丌东上专丒与丌.length;
        val_10 = val_9 / val_10;
        this.专丌丌东上专丒与丌.normalizedTime = val_10;
        this.丆不丝丝上一丞七业.Sample();
        if(this.万下丙丘丄一业丒三 < this.专丌丌东上专丒与丌.length)
        {
            goto label_28;
        }
        
        if(this.专丌丌东上专丒与丌.wrapMode != 2)
        {
            goto label_27;
        }
        
        this.万下丙丘丄一业丒三 = 0f;
        goto label_28;
        label_20:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_15 = 1;
        return (bool)val_15;
        label_27:
        mem2[0] = 0;
        label_28:
        val_15 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
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
