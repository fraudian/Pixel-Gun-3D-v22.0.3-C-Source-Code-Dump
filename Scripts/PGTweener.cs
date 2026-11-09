using UnityEngine;
internal class PGTweener : MonoBehaviour
{
    // Fields
    private System.Action 丟丘丙丄丅万丏与丗;
    protected bool 丘丄丆不丛丗上三上;
    protected float 丏一上东丗丘三丂世;
    protected bool localSpace;
    private float 世不万丙丘专丌丌一;
    protected float duration;
    protected UnityEngine.AnimationCurve animationCurve;
    private UnityEngine.Coroutine 丗下丌丅下丈丄三丑;
    
    // Properties
    internal bool 丅业东万丌丕上丌丄 { get; }
    internal float 七专丐丅东七丌丂丅 { get; }
    internal float 丛七世丙丙与不丄丗 { get; }
    
    // Methods
    internal void 丁七丙丈丑万丕丆与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丟丘丙丄丅万丏与丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟丘丙丄丅万丏与丗 != 1152921538182073256);
    
    }
    internal void 丐上丑丌七下丏丘丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丟丘丙丄丅万丏与丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟丘丙丄丅万丏与丗 != 1152921538182209832);
    
    }
    internal bool 丈丐丞丐上丑且丕万()
    {
        return (bool)this.丘丄丆不丛丗上三上;
    }
    internal float 三一万丐丝专丁丆三()
    {
        return (float)this.丏一上东丗丘三丂世;
    }
    internal float 丌丛丟丙丘丝丂一不()
    {
        return (float)this.duration;
    }
    private void Awake()
    {
        this.世不万丙丘专丌丌一 = this.duration;
    }
    internal void 丗万丞丒东万丂丛三()
    {
        this.丏一上东丗丘三丂世 = 0f;
        this.丘丄丆不丛丗上三上 = true;
        this.duration = this.世不万丙丘专丌丌一;
        this.专丞丆下丏丛世丁丁();
    }
    internal void 与丂丑一丙丆丕一上(float 丁万丐丌专丛丐世丌)
    {
        this.duration = 丁万丐丌专丛丐世丌;
    }
    internal void 丄与丒丂丂丘专丝万()
    {
        this.丘丄丆不丛丗上三上 = false;
        this.丘东丁不上且丙丞东();
    }
    internal virtual void Reset()
    {
        this.丘丄丆不丛丗上三上 = false;
        goto typeof(PGTweener).__il2cppRuntimeField_178;
    }
    private void 万丏丛东下丝下丟丕()
    {
        if(this.丟丘丙丄丅万丏与丗 == null)
        {
                return;
        }
        
        this.丟丘丙丄丅万丏与丗.Invoke();
    }
    protected virtual void 丕丆丞丅上且丌丈丑()
    {
    
    }
    protected virtual void 世丗东丗与丆丒丟专()
    {
    
    }
    protected virtual void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
    
    }
    protected virtual void 丒丐万丞不专丁丆丙()
    {
    
    }
    private void 专丞丆下丏丛世丁丁()
    {
        this.丘东丁不上且丙丞东();
        this.丗下丌丅下丈丄三丑 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.上丒丅与丒丕业东且());
    }
    private void 丘东丁不上且丙丞东()
    {
        if(this.丗下丌丅下丈丄三丑 == null)
        {
                return;
        }
        
        CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丗下丌丅下丈丄三丑);
        this.丗下丌丅下丈丄三丑 = 0;
    }
    private System.Collections.IEnumerator 上丒丅与丒丕业东且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PGTweener.一丐丙丐下上丙丂丅();
    }
    public PGTweener()
    {
        this.duration = 0.5f;
        UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[2];
        val_1[0] = 0;
        val_1[0] = 0;
        val_1[1] = 0;
        val_1[1] = 0;
        this.animationCurve = new UnityEngine.AnimationCurve(keys:  val_1);
    }

}
