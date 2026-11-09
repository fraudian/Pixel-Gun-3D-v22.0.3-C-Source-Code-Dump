using UnityEngine;
public class BootsMaterial : MonoBehaviour
{
    // Fields
    public UnityEngine.MeshRenderer bootRenderer;
    public UnityEngine.Material[] materialList;
    
    // Methods
    public void SetBootsMaterial(string 丟东丕丗丑丏丐丟丅)
    {
        goto label_1;
        label_15:
        if(this.materialList[0] != 0)
        {
                if((System.String.op_Equality(a:  this.materialList[0].name, b:  丟东丕丗丑丏丐丟丅)) != false)
        {
                this.bootRenderer.sharedMaterial = this.materialList[0];
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this.materialList.Length)
        {
            goto label_15;
        }
        
        ShaderNameCollector val_4 = this.GetComponent<ShaderNameCollector>();
        if(val_4 == 0)
        {
                return;
        }
        
        val_4.丙万万丁丟专业且丌();
    }
    public BootsMaterial()
    {
    
    }

}
