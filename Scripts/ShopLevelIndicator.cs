using UnityEngine;
internal sealed class ShopLevelIndicator : MonoBehaviour
{
    // Fields
    private const float 丟丝丝七下丆丂世丑 = 0.969;
    private UILabel _levelLabel;
    private UITexture _levelProgress;
    
    // Methods
    private void OnEnable()
    {
        this.丙丆业丝丁丏丟丕丈();
        this.东丗丕丘丞丁丂丞且();
    }
    private void Update()
    {
        this.丙丆业丝丁丏丟丕丈();
        this.东丗丕丘丞丁丂丞且();
    }
    private void 丙丆业丝丁丏丟丕丈()
    {
        if(this._levelLabel == 0)
        {
                return;
        }
        
        if(ExpController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        this = this._levelLabel;
        this.text = ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂().ToString();
    }
    private void 东丗丕丘丞丁丂丞且()
    {
        var val_9;
        var val_10;
        if(this._levelProgress == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(ExperienceController.sharedController.万丌丄丗丟业七下丕() == null)
        {
                return;
        }
        
        float val_9 = (float)ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  ExperienceController.丞丞丘业东丙丏七丌());
        float val_7 = (float)ExperienceController.万丏丙丈东东万丝丞() / val_9;
        val_9 = val_7 * 0.969f;
        val_7 = (ExperienceController.丞丞丘业东丙丏七丌() == 65) ? 0.969f : (val_9);
        this._levelProgress.fillAmount = val_7;
    }
    public ShopLevelIndicator()
    {
    
    }

}
