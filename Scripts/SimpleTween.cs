using UnityEngine;
public class SimpleTween : MonoBehaviour
{
    // Fields
    private System.Action 丟丘丙丄丅万丏与丗;
    protected bool 丘丄丆不丛丗上三上;
    protected float 丏一上东丗丘三丂世;
    public bool loop;
    public float _duration;
    private bool 丕丛丂丞世丁丐丌专;
    protected UnityEngine.AnimationCurve animationCurve;
    private UnityEngine.Coroutine 丗下丌丅下丈丄三丑;
    
    // Properties
    public bool 丅业东万丌丕上丌丄 { get; }
    public float 七专丐丅东七丌丂丅 { get; }
    
    // Methods
    public void add_onComplete(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丟丘丙丄丅万丏与丗 != 1152921539472004408);
    
    }
    public void remove_onComplete(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丟丘丙丄丅万丏与丗 != 1152921539472140984);
    
    }
    public bool get_IsActive()
    {
        return (bool)this.丘丄丆不丛丗上三上;
    }
    public float get_TimeElapsed()
    {
        return (float)this.丏一上东丗丘三丂世;
    }
    public void Play()
    {
        this.丕丛丂丞世丁丐丌专 = false;
        this.专丞丆下丏丛世丁丁();
    }
    public void PlayRevers()
    {
        this.丕丛丂丞世丁丐丌专 = true;
        this.专丞丆下丏丛世丁丁();
    }
    public void Stop()
    {
        this.丘丄丆不丛丗上三上 = false;
        this.丏一上东丗丘三丂世 = 0f;
        if(this.丗下丌丅下丈丄三丑 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丗下丌丅下丈丄三丑);
        this.丗下丌丅下丈丄三丑 = 0;
    }
    public virtual void GetInitial()
    {
    
    }
    public virtual void SetInitial()
    {
    
    }
    public virtual void SetFinal()
    {
        float val_5;
        this.丘丄丆不丛丗上三上 = false;
        this.丏一上东丗丘三丂世 = 0f;
        if(this.丗下丌丅下丈丄三丑 != null)
        {
                this.StopCoroutine(routine:  this.丗下丌丅下丈丄三丑);
            this.丗下丌丅下丈丄三丑 = 0;
        }
        
        if(this.animationCurve != null)
        {
                val_5 = this.animationCurve.Evaluate(time:  1f);
        }
        else
        {
                val_5 = 0.Evaluate(time:  1f);
        }
        
        float val_3 = this.animationCurve.Evaluate(time:  val_5);
        goto typeof(SimpleTween).__il2cppRuntimeField_198;
    }
    private void 万丏丛东下丝下丟丕()
    {
        this.丘丄丆不丛丗上三上 = false;
        this.丏一上东丗丘三丂世 = 0f;
        if(this.丗下丌丅下丈丄三丑 != null)
        {
                this.StopCoroutine(routine:  this.丗下丌丅下丈丄三丑);
            this.丗下丌丅下丈丄三丑 = 0;
        }
        
        if(this.丟丘丙丄丅万丏与丗 == null)
        {
                return;
        }
        
        this.丟丘丙丄丅万丏与丗.Invoke();
    }
    protected virtual void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
    
    }
    private void 专丞丆下丏丛世丁丁()
    {
        this.丘丄丆不丛丗上三上 = false;
        this.丏一上东丗丘三丂世 = 0f;
        if(this.丗下丌丅下丈丄三丑 != null)
        {
                this.StopCoroutine(routine:  this.丗下丌丅下丈丄三丑);
            this.丗下丌丅下丈丄三丑 = 0;
        }
        
        this.丘丄丆不丛丗上三上 = true;
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.丗下丌丅下丈丄三丑 = this.StartCoroutine(routine:  this.上丒丅与丒丕业东且());
    }
    private void 丘东丁不上且丙丞东()
    {
        this.丘丄丆不丛丗上三上 = false;
        this.丏一上东丗丘三丂世 = 0f;
        if(this.丗下丌丅下丈丄三丑 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丗下丌丅下丈丄三丑);
        this.丗下丌丅下丈丄三丑 = 0;
    }
    private System.Collections.IEnumerator 上丒丅与丒丕业东且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SimpleTween.丆丁丒丘不丅丙丙世();
    }
    public SimpleTween()
    {
        this._duration = 0.5f;
        UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[2];
        val_1[0] = 0;
        val_1[0] = 0;
        val_1[1] = 0;
        val_1[1] = 0;
        this.animationCurve = new UnityEngine.AnimationCurve(keys:  val_1);
    }

}
