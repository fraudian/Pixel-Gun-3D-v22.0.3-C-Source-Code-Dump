using UnityEngine;
public sealed class PlacebleItemSubcategoryButton : PGBehaviour
{
    // Fields
    public SelectableButton selectableButton;
    private UILabel title;
    private UISprite icon;
    private UnityEngine.GameObject notifContainer;
    private UILabel notifCountLabel;
    private int 丈丒业丈丅且不丌丝;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(string 丒丑丞丁世丌专不丈, int 丂丗丝与丕丁丗丅丛 = 0)
    {
        this.name = 丒丑丞丁世丌专不丈;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.title, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PlaceableItems_" + 丒丑丞丁世丌专不丈 + "_Title"));
        this.icon.spriteName = "PlaceableItems_" + 丒丑丞丁世丌专不丈 + "_Icon";
        this.与东不丈丈万且丝东(丌丒丝东丌下丕丁丅:  丂丗丝与丕丁丗丅丛);
        this.gameObject.SetActive(value:  true);
    }
    internal void 与东不丈丈万且丝东(int 丌丒丝东丌下丕丁丅)
    {
        this.丈丒业丈丅且不丌丝 = 丌丒丝东丌下丕丁丅;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notifContainer, 丏业丟一东丂东丘丛:  (丌丒丝东丌下丕丁丅 > 0) ? 1 : 0);
        if(this.丈丒业丈丅且不丌丝 < 1)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.notifCountLabel, 丕丗丘丑丛与丑业丒:  this.丈丒业丈丅且不丌丝.ToString());
    }
    internal void 世下不与丆专丅丘丙()
    {
        this.与东不丈丈万且丝东(丌丒丝东丌下丕丁丅:  this.丈丒业丈丅且不丌丝 - 1);
    }
    internal void 世三丆丞且与世业丟()
    {
        this.与东不丈丈万且丝东(丌丒丝东丌下丕丁丅:  this.丈丒业丈丅且不丌丝 + 1);
    }
    public PlacebleItemSubcategoryButton()
    {
    
    }

}
