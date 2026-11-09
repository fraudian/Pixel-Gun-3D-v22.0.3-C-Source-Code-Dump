using UnityEngine;
public class SetBakedData : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector4[] vec;
    private UnityEngine.MeshRenderer 三丑专丘丏丙与丛丌;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.MeshRenderer val_1 = this.GetComponent<UnityEngine.MeshRenderer>();
        this.三丑专丘丏丙与丛丌 = val_1;
        val_1.sharedMaterial.SetVectorArray(name:  "uvs", values:  this.vec);
    }
    public SetBakedData()
    {
        this.vec = new UnityEngine.Vector4[64];
    }

}
