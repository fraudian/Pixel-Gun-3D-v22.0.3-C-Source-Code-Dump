using UnityEngine;
public class GiftAnimatorController : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        var val_5;
        string val_6;
        UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_6;
        }
        
        val_6 = "SkipShowAnimation";
        goto label_14;
        label_6:
        bool val_4 = Progress.七七世万专丕丁上业.丐丐上丟丑丆丐专丗().七丝上丝丘三丅下丈();
        if(val_1 == null)
        {
            goto label_12;
        }
        
        if(val_4 == false)
        {
            goto label_13;
        }
        
        label_15:
        val_6 = "ShowShowAnimation";
        goto label_14;
        label_12:
        if(val_4 == true)
        {
            goto label_15;
        }
        
        label_13:
        val_6 = "ShowShowPlusAnimation";
        label_14:
        val_1.SetBool(name:  val_6, value:  true);
    }
    public GiftAnimatorController()
    {
    
    }

}
