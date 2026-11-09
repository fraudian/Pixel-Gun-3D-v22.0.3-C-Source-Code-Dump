using UnityEngine;
internal class ThirdPersonAnimationWrapper : MonoBehaviour
{
    // Fields
    public UnityEngine.Animator animator;
    public UnityEngine.Renderer[] playerRenderers;
    internal visibleObjPhoton visObj;
    private bool 丏东业丂丈与丏七丞;
    private bool 丌丁丅丈丆万丁丞丛;
    
    // Properties
    public float 丝且一不丐且下世与 { get; set; }
    public bool 业丂万丏丒丛丒万且 { get; set; }
    
    // Methods
    public float get_VelocityMagnitude()
    {
        if(this.animator != null)
        {
                return this.animator.GetFloat(name:  "VelocityMagnitude");
        }
        
        return this.animator.GetFloat(name:  "VelocityMagnitude");
    }
    public void set_VelocityMagnitude(float 丙业与丙丗丝不丈东)
    {
        this.animator.SetFloat(name:  "VelocityMagnitude", value:  丙业与丙丗丝不丈东);
    }
    public bool get_isGrounded()
    {
        return (bool)this.丏东业丂丈与丏七丞;
    }
    public void set_isGrounded(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        this.丏东业丂丈与丏七丞 = val_1;
        this.animator.SetBool(name:  "isGrounded", value:  val_1);
    }
    public void StartFall()
    {
        this.animator.SetTrigger(name:  "Fall");
    }
    public void Revive()
    {
        this.animator.ResetTrigger(name:  "Fall");
        this.animator.SetTrigger(name:  "Revive");
    }
    private void Start()
    {
        this.VelocityMagnitude = 0f;
    }
    private void Update()
    {
        bool val_1 = this.丏东业丂丈与丏七丞;
        if(val_1 != false)
        {
                if(this.丌丁丅丈丆万丁丞丛 != false)
        {
                val_1 = 1;
        }
        else
        {
                this.animator.SetTrigger(name:  "Land");
            val_1 = this.丏东业丂丈与丏七丞;
        }
        
        }
        
        this.丌丁丅丈丆万丁丞丛 = val_1;
    }
    public ThirdPersonAnimationWrapper()
    {
        this.丏东业丂丈与丏七丞 = true;
        this.丌丁丅丈丆万丁丞丛 = true;
    }

}
