using UnityEngine;
internal sealed class ComponentToggler : PGBehaviour
{
    // Fields
    public int delyInFrames;
    public ComponentToggler.丏三业丕丈丄丂丑东 trigger;
    public System.Collections.Generic.List<UnityEngine.MonoBehaviour> components;
    private UnityEngine.Coroutine 不万丙上丝丝上丟丂;
    
    // Methods
    private void Awake()
    {
        if(this.trigger != 1)
        {
                return;
        }
        
        this.万丄丅东丂且丒丝上();
    }
    private void Start()
    {
        if(this.trigger != 2)
        {
                return;
        }
        
        this.万丄丅东丂且丒丝上();
    }
    private void OnEnable()
    {
        if(this.trigger != 3)
        {
                return;
        }
        
        this.万丄丅东丂且丒丝上();
    }
    public void Toggle()
    {
        List.Enumerator<T> val_1 = this.components.GetEnumerator();
        label_8:
        if((895626024 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_8;
        }
        
        val_2.enabled = false;
        val_2.enabled = true;
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 万丄丅东丂且丒丝上()
    {
        if(this.不万丙上丝丝上丟丂 != null)
        {
                this.StopCoroutine(routine:  this.不万丙上丝丝上丟丂);
            this.不万丙上丝丝上丟丂 = 0;
        }
        
        this.不万丙上丝丝上丟丂 = this.StartCoroutine(routine:  this.丕丐丌丞丕丕丘一一());
    }
    private void 丗七丅世下丝丐丛丛()
    {
        if(this.不万丙上丝丝上丟丂 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.不万丙上丝丝上丟丂);
        this.不万丙上丝丝上丟丂 = 0;
    }
    private System.Collections.IEnumerator 丕丐丌丞丕丕丘一一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ComponentToggler.丆丌东丐丈丘世丙丆();
    }
    public ComponentToggler()
    {
    
    }

}
