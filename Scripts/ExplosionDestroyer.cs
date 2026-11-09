using UnityEngine;
public class ExplosionDestroyer : MonoBehaviour
{
    // Fields
    public float Time;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.Remove());
    }
    private System.Collections.IEnumerator Remove()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ExplosionDestroyer.丅丕三丈万丑丈七东();
    }
    public ExplosionDestroyer()
    {
        this.Time = 30f;
    }

}
