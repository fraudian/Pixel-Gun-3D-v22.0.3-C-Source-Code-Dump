using UnityEngine;
public class TargetScanner : MonoBehaviour
{
    // Fields
    public float DetectRadius;
    public UnityEngine.Transform LookPoint;
    public bool SkipCheckVisible;
    internal UnityEngine.GameObject 丘与丈丘丒丂丁丛丟;
    public float UpdateFrequency;
    
    // Methods
    private void OnEnable()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丘丐上丌丟丟丑丅丙().GetEnumerator());
    }
    private System.Collections.IEnumerable 丘丐上丌丟丟丑丅丙()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new TargetScanner.丙不丂万且万上丐与();
    }
    public TargetScanner()
    {
        this.DetectRadius = 30f;
        this.UpdateFrequency = 0.3f;
    }

}
