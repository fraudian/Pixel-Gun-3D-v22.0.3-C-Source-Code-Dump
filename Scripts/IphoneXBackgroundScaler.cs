using UnityEngine;
public class IphoneXBackgroundScaler : MonoBehaviour
{
    // Methods
    private void Start()
    {
        if((((float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height) <= 1.87f) && (东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != true))
        {
                return;
        }
        
        UIWidget val_5 = this.GetComponent<UIWidget>();
        if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
        {
            goto label_7;
        }
        
        if(val_5 == null)
        {
            goto label_8;
        }
        
        val_5.SetAnchor(丙丒七丄上与丏丙丙:  0);
        mem2[0] = 0;
        val_5.keepAspectRatio = 1;
        goto label_9;
        label_7:
        UnityEngine.Vector3 val_9 = this.transform.localScale;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  1.3f);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        return;
        label_8:
        0.SetAnchor(丙丒七丄上与丏丙丙:  0);
        mem[56] = 0;
        val_5.keepAspectRatio = 1;
        label_9:
        val_5.width = 8;
    }
    public IphoneXBackgroundScaler()
    {
    
    }

}
