using UnityEngine;
internal sealed class USPViewComponentOldPCount : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject body;
    private UILabel textLabel;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        PGCompany.StorePromotionSettings val_1 = 且丘丏丁丑与丙与丁.与丄丆丁丘东丝下七();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.textLabel, 丕丗丘丑丛与丑业丒:  val_1.OldCount);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.body, 丏业丟一东丂东丘丛:  (val_1.OldCount > 0) ? 1 : 0);
    }
    public USPViewComponentOldPCount()
    {
    
    }

}
