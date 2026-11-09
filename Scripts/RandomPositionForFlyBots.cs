using UnityEngine;
internal class RandomPositionForFlyBots : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 丈万丏丈上丑不丅上;
    public float randomHeight;
    public System.Collections.Generic.List<UnityEngine.Transform> listTransform;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.丈万丏丈上丑不丅上 = val_2;
        mem[1152921538816362396] = val_2.y;
        mem[1152921538816362400] = val_2.z;
    }
    private void OnEnable()
    {
        var val_4 = this;
        float val_4 = this.randomHeight;
        List.Enumerator<T> val_2 = this.listTransform.GetEnumerator();
        label_4:
        if(((-150110776) & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = (UnityEngine.Random.Range(min:  -val_4, max:  val_4)) + val_4;
        0.丐丏七丌丕丗业且上().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public RandomPositionForFlyBots()
    {
        this.randomHeight = 0.15f;
    }

}
