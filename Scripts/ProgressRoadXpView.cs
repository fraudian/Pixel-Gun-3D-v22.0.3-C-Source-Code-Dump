using UnityEngine;
internal sealed class ProgressRoadXpView : MonoBehaviour
{
    // Fields
    private UIBasicSprite fillTexture;
    private UILabel levelLabel;
    private UILabel xpLabel;
    private float maxFillValue;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(int 丒东专一不与丐丐丁)
    {
        var val_5;
        UIBasicSprite val_6;
        System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_1 = 丐丄丞世丂丄丛不一.七三世丂丛丙丅七业(上丕丈丞丌丘丅不与:  丒东专一不与丐丐丁);
        int val_2 = val_1.Value.GetHashCode();
        val_5 = null;
        val_5 = null;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  val_2);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.xpLabel, 丕丗丘丑丛与丑业丒:  丒东专一不与丐丐丁);
        val_6 = this.fillTexture;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = this.fillTexture;
        float val_5 = 1.152922E+18f;
        val_5 = val_5 / ((float)ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  val_2));
        val_5 = val_5 * this.maxFillValue;
        val_6.fillAmount = val_5;
    }
    public ProgressRoadXpView()
    {
        this.maxFillValue = 0.965f;
    }

}
