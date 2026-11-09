using UnityEngine;
public class AlmanachCollectWeaponsStepUI : MonoBehaviour
{
    // Fields
    private AlmanachCollectWeaponsStep 丝丒丛丄不丑丗业丙;
    private UILabel countLabel;
    private UISprite progressBar;
    private OfferItemView rewardUi;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnComplete;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(AlmanachCollectWeaponsStep 丝丒丛丄不丑丗业丙)
    {
        this.丝丒丛丄不丑丗业丙 = 丝丒丛丄不丑丗业丙;
        if(丝丒丛丄不丑丗业丙 != null)
        {
                this.countLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  丝丒丛丄不丑丗业丙.collectedCount, arg1:  丝丒丛丄不丑丗业丙.neededCount);
            float val_8 = (float)丝丒丛丄不丑丗业丙.collectedCount;
            val_8 = val_8 / (float)丝丒丛丄不丑丗业丙.neededCount;
            this.progressBar.fillAmount = val_8;
            this.rewardUi.Setup(与且专丈不万东一万:  丝丒丛丄不丑丗业丙.reward);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnComplete, 丏业丟一东丂东丘丛:  (丝丒丛丄不丑丗业丙.collectedCount >= 丝丒丛丄不丑丗业丙.neededCount) ? 1 : 0);
            this.gameObject.SetActive(value:  true);
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public void CollectButtonPressed()
    {
        if(this.丝丒丛丄不丑丗业丙 == null)
        {
                return;
        }
        
        bool val_1 = 上且丁万与丌下丐上.丙丛丘上万丆丝丄七(丝丒丛丄不丑丗业丙:  this.丝丒丛丄不丑丗业丙);
    }
    public AlmanachCollectWeaponsStepUI()
    {
    
    }

}
