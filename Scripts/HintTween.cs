using UnityEngine;
public class HintTween : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.3f);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    private void Update()
    {
        UnityEngine.Vector3 val_3 = this.transform.localScale;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  UnityEngine.Time.unscaledDeltaTime * 3f);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    public HintTween()
    {
    
    }

}
