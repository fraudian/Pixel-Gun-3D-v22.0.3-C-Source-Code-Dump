using UnityEngine;
public class LodCreator : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform lod0;
    public UnityEngine.Transform lod1;
    public float ls0;
    public float ls1;
    
    // Methods
    private void 丞丙东丌一三专丏不()
    {
        var val_28;
        var val_29;
        int val_30;
        val_28 = 1152921519105030032;
        val_29 = 0;
        goto label_1;
        label_44:
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Terrain_lod_" + 0.ToString());
        UnityEngine.Transform val_6 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  this.lod0.GetChild(index:  0));
        UnityEngine.Transform val_8 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  this.lod1.GetChild(index:  0));
        UnityEngine.Vector3 val_11 = this.lod0.GetChild(index:  0).position;
        val_3.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        val_3.transform.parent = this.transform;
        val_6.transform.parent = val_3.transform;
        val_28 = val_28;
        val_8.transform.parent = val_3.transform;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
        val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        UnityEngine.Renderer[] val_22 = new UnityEngine.Renderer[1];
        UnityEngine.MeshRenderer val_23 = val_6.GetComponent<UnityEngine.MeshRenderer>();
        if(val_22 == null)
        {
            goto label_26;
        }
        
        if(val_23 != null)
        {
            goto label_27;
        }
        
        goto label_30;
        label_26:
        if(val_23 == null)
        {
            goto label_30;
        }
        
        label_27:
        label_30:
        val_22[0] = val_23;
        UnityEngine.Renderer[] val_24 = new UnityEngine.Renderer[1];
        UnityEngine.MeshRenderer val_25 = val_8.GetComponent<UnityEngine.MeshRenderer>();
        if(val_24 == null)
        {
            goto label_33;
        }
        
        if(val_25 != null)
        {
            goto label_34;
        }
        
        goto label_37;
        label_33:
        if(val_25 == null)
        {
            goto label_37;
        }
        
        label_34:
        label_37:
        val_24[0] = val_25;
        UnityEngine.LOD[] val_26 = new UnityEngine.LOD[2];
        val_30 = val_26.Length;
        if(val_30 == 0)
        {
                val_30 = val_26.Length;
        }
        
        val_26[0] = 0;
        val_26[0] = 0;
        val_26[1] = 0;
        val_26[1] = 0;
        val_3.AddComponent<UnityEngine.LODGroup>().SetLODs(lods:  val_26);
        val_29 = 1;
        label_1:
        if(val_29 < this.lod0.childCount)
        {
            goto label_44;
        }
    
    }
    public LodCreator()
    {
        this.ls1 = 1f;
    }

}
