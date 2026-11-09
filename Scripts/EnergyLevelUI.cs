using UnityEngine;
public class EnergyLevelUI : PGBehaviour
{
    // Fields
    private UILabel energyLabel;
    private UISprite energyBar;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(int 业万丒七丄丑万不且, int 丌一七世三丑专丒丆)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.energyLabel, 丕丗丘丑丛与丑业丒:  业万丒七丄丑万不且 + "/"("/") + 丌一七世三丑专丒丆);
        float val_2 = (float)业万丒七丄丑万不且;
        val_2 = val_2 / (float)丌一七世三丑专丒丆;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this.energyBar, 丙业与丙丗丝不丈东:  val_2);
    }
    public EnergyLevelUI()
    {
    
    }

}
