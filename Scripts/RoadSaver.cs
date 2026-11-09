using UnityEngine;
public class RoadSaver : MonoBehaviour
{
    // Fields
    private UnityEngine.MeshFilter[] 丝上丁丂丄丈丗丘丄;
    
    // Methods
    private void 丂且不业丂专丛丆东()
    {
        UnityEngine.MeshFilter[] val_3;
        var val_4;
        val_3 = this.GetComponentsInChildren<UnityEngine.MeshFilter>();
        val_4 = 0;
        this.丝上丁丂丄丈丗丘丄 = val_3;
        goto label_1;
        label_6:
        UnityEngine.Mesh val_2 = this.丝上丁丂丄丈丗丘丄[0].mesh;
        val_3 = this.丝上丁丂丄丈丗丘丄;
        val_4 = 1;
        label_1:
        if(val_4 < this.丝上丁丂丄丈丗丘丄.Length)
        {
            goto label_6;
        }
    
    }
    private void 丌丝且丈七专上东丏(UnityEngine.Mesh 丁丁万丗业丗世丙丏, int 七丞丙丒三丕且丌丟)
    {
    
    }
    public RoadSaver()
    {
    
    }

}
