using UnityEngine;
internal class WeaponTargetDetectorBase : MonoBehaviour
{
    // Fields
    public int targetsCount;
    public float detectionRadius;
    private UnityEngine.Coroutine 万丁万丘上万丘丘万;
    
    // Methods
    private void Start()
    {
        if(this.万丁万丘上万丘丘万 != null)
        {
                return;
        }
        
        this.万丁万丘上万丘丘万 = this.StartCoroutine(routine:  this.丅丁丐丏丗丌专下丈());
    }
    private void OnDestroy()
    {
        if(this.万丁万丘上万丘丘万 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.万丁万丘上万丘丘万);
        this.万丁万丘上万丘丘万 = 0;
    }
    private System.Collections.IEnumerator 丅丁丐丏丗丌专下丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponTargetDetectorBase.不丒世丟业丆丕丆丆();
    }
    internal virtual void 不上丆东丘丌丄丛且(UnityEngine.Transform 丞下万上三丘上与专, float 专世丂丆专业丌丈丈)
    {
    
    }
    internal virtual void 不上丆东丘丌丄丛且(System.Collections.Generic.List<UnityEngine.Transform> 丌业丅丒丛且万丛丒)
    {
    
    }
    public WeaponTargetDetectorBase()
    {
        this.targetsCount = 1;
    }

}
