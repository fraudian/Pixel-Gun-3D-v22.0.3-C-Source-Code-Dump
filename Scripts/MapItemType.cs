using UnityEngine;
[Serializable]
public class NJGMapBase.MapItemType
{
    // Fields
    public bool enableInteraction;
    public string type;
    public string sprite;
    public string selectedSprite;
    public bool useCustomSize;
    public bool useCustomArrowSize;
    public bool useCustomBorderSize;
    public int size;
    public int sizeArrow;
    public int borderSize;
    public UnityEngine.Color color;
    public bool animateOnVisible;
    public bool showOnAction;
    public bool loopAnimation;
    public float fadeOutAfterDelay;
    public bool rotate;
    public bool updatePosition;
    public bool haveArrow;
    public string arrowSprite;
    public bool folded;
    public int depth;
    public bool deleteRequest;
    public int arrowDepth;
    
    // Methods
    public void 丒丗丁一丏丁丙丈东(string 万丑丞一丝丌丐丒丘)
    {
        this.sprite = 万丑丞一丝丌丐丒丘;
    }
    public void 丁丌东丅丄丗丛丏上(string 万丑丞一丝丌丐丒丘)
    {
        this.selectedSprite = 万丑丞一丝丌丐丒丘;
    }
    public void 丌专一丐丕丏丏三丛(string 万丑丞一丝丌丐丒丘)
    {
        this.arrowSprite = 万丑丞一丝丌丐丒丘;
    }
    public NJGMapBase.MapItemType()
    {
        this.size = 137438953504;
        this.sizeArrow = 32;
        this.borderSize = 32;
        this.type = "New Marker";
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.animateOnVisible = true;
        this.updatePosition = true;
        this.folded = true;
        this.color = val_1;
        mem[1152921541458503572] = val_1.g;
        mem[1152921541458503576] = val_1.b;
        mem[1152921541458503580] = val_1.a;
        this.arrowDepth = 5;
    }

}
