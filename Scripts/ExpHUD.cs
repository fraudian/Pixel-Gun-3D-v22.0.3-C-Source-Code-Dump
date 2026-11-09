using UnityEngine;
public class ExpHUD : MonoBehaviour
{
    // Fields
    public UILabel lbCurLev;
    public UILabel lbExp;
    public UITexture txExp;
    
    // Methods
    private void OnEnable()
    {
        ExpController.丑七不且上丗丁一世().丞丝丏丈与一下专下(丙业与丙丗丝不丈东:  false);
        this.丑丞丂一丅专丝丙丂();
    }
    private void OnDisable()
    {
        if(ExpController.丑七不且上丗丁一世() == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "ExpController.Instance == null");
            return;
        }
        
        ExpController.丑七不且上丗丁一世().丞丝丏丈与一下专下(丙业与丙丗丝不丈东:  true);
    }
    private void 丑丞丂一丅专丝丙丂()
    {
        var val_6 = null;
        this.lbCurLev.text = ExperienceController.丞丞丘业东丙丏七丌().ToString();
        this.lbExp.text = ExpController.丄丌丟丙专丙七下丆();
        if(ExperienceController.丞丞丘业东丙丏七丌() == 65)
        {
                if(this.txExp != null)
        {
            goto label_9;
        }
        
        }
        
        label_9:
        this.txExp.fillAmount = ExpController.丁丈下丈丘丈丏丏丝();
    }
    public ExpHUD()
    {
    
    }

}
