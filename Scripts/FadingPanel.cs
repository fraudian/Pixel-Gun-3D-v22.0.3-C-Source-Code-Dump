using UnityEngine;
public class FadingPanel : MonoBehaviour
{
    // Fields
    public UISprite spritePanel;
    public UIPanel panel;
    private bool 丘且下七丁丑丄丑丒;
    private float 不丞下业丕丕下丙万;
    
    // Methods
    public void SetFadeKill(bool 与七业万丌三丟不一)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        与七业万丌三丟不一 = 与七业万丌三丟不一;
        this.SetFade(与七业万丌三丟不一:  与七业万丌三丟不一, 丟丞一专丕三东丗一:  2f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
    }
    public void SetFade(bool 与七业万丌三丟不一, float 丟丞一专丕三东丗一, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        this.丘且下七丁丑丄丑丒 = 与七业万丌三丟不一;
        this.不丞下业丕丕下丙万 = 丟丞一专丕三东丗一;
        this.spritePanel.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    private void Update()
    {
        var val_8;
        var val_9;
        var val_10;
        float val_4 = UnityEngine.Mathf.MoveTowards(current:  V0.16B, target:  (this.丘且下七丁丑丄丑丒 == true) ? 1f : 0f, maxDelta:  this.不丞下业丕丕下丙万 * UnityEngine.Time.deltaTime);
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_9 = null;
            val_9 = null;
            var val_7 = (丆丗丂三丐不东且丏() != true) ? 100 : 220;
        }
        else
        {
                val_10 = 220;
        }
        
        this.panel.depth = 220;
    }
    public FadingPanel()
    {
    
    }

}
