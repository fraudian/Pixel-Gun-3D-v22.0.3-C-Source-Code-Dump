using UnityEngine;
internal sealed class RewardParticlesReceiver : PGBehaviour
{
    // Fields
    private System.Action 丂下丑丗丟丐丈一丑;
    private UnityEngine.GameObject enableOnRecive;
    internal SimpleTweenePlayer onReciveAnimation;
    private float enableTime;
    private float 丑且业丕下丁丙丁下;
    private UnityEngine.Coroutine 专丝与世丆七丏丙丂;
    
    // Methods
    internal void 丅丛丝不丛与上丗丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丂下丑丗丟丐丈一丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丂下丑丗丟丐丈一丑 != 1152921538794155640);
    
    }
    internal void 世专丅丄万丂丅丐丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丂下丑丗丟丐丈一丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丂下丑丗丟丐丈一丑 != 1152921538794292216);
    
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.enableOnRecive, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDestroy()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.enableOnRecive, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丝丟不丒丐三丌下丆(RewardParticle 丙与丁不丁丘丒上世)
    {
        if(this.丂下丑丗丟丐丈一丑 != null)
        {
                this.丂下丑丗丟丐丈一丑.Invoke();
        }
        
        this.且丕丈专上丟丏七丑();
    }
    private void 且丕丈专上丟丏七丑()
    {
        if(this.专丝与世丆七丏丙丂 != null)
        {
                this.StopCoroutine(routine:  this.专丝与世丆七丏丙丂);
            this.专丝与世丆七丏丙丂 = 0;
        }
        
        this.专丝与世丆七丏丙丂 = this.StartCoroutine(routine:  this.丈下丏丁与丟一丕丗());
    }
    private void 丆三业七丆丝丌丐七()
    {
        if(this.专丝与世丆七丏丙丂 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.专丝与世丆七丏丙丂);
        this.专丝与世丆七丏丙丂 = 0;
    }
    private System.Collections.IEnumerator 丈下丏丁与丟一丕丗()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RewardParticlesReceiver.丙丏丘三上丏与丁丁();
    }
    public RewardParticlesReceiver()
    {
        this.enableTime = 0.2f;
    }

}
