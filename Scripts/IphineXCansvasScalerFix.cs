using UnityEngine;
public class IphineXCansvasScalerFix : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        UnityEngine.Object val_6;
        var val_7;
        val_6 = this;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        val_6 = this.GetComponent<UnityEngine.UI.CanvasScaler>();
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_4 = val_6.referenceResolution;
        float val_7 = val_4.y;
        val_7 = null;
        val_7 = null;
        float val_6 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
        val_6 = val_7 / val_6;
        val_7 = val_6 + 22f;
        val_6.referenceResolution = new UnityEngine.Vector2() {x = val_4.x, y = (float)UnityEngine.Mathf.RoundToInt(f:  val_7)};
    }
    public IphineXCansvasScalerFix()
    {
    
    }

}
