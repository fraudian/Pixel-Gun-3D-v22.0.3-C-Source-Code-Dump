using UnityEngine;
internal sealed class ItemViewComponentLootBoxName : ItemViewComponent
{
    // Fields
    private UILabel lootBoxName;
    
    // Methods
    internal override void 丝一丅丆三东丂丞七()
    {
        UnityEngine.GameObject val_2 = this.gameObject;
        if(不业丙丒丂丞下丆丙() == 1460)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lootBoxName, 丕丗丘丑丛与丑业丒:  val_2);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
    }
    public ItemViewComponentLootBoxName()
    {
        val_1 = new PGBehaviour();
    }

}
