using UnityEngine;
public class PriceLabel : MonoBehaviour
{
    // Fields
    public UILabel price;
    public UnityEngine.GameObject gem;
    public UnityEngine.GameObject coin;
    public UnityEngine.GameObject detail;
    
    // Methods
    internal void 丗丘丗丈丑丒丗七丘(丈丞丕丘丕丗与上一 丐丂丛与万丛丞丘万)
    {
        var val_9;
        this.price.text = 丐丂丛与万丛丞丘万.丟丂丞不专丆万丒世().ToString();
        val_9 = null;
        val_9 = null;
        string val_9 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        val_9 = System.String.op_Equality(a:  丐丂丛与万丛丞丘万.东与三丌丅三丒丏业(), b:  val_9);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gem, 丏业丟一东丂东丘丛:  val_9);
        string val_10 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        val_10 = System.String.op_Equality(a:  丐丂丛与万丛丞丘万.东与三丌丅三丒丏业(), b:  val_10);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.coin, 丏业丟一东丂东丘丛:  val_10);
        string val_11 = "DetailsCurrency";
        val_11 = System.String.op_Equality(a:  丐丂丛与万丛丞丘万.东与三丌丅三丒丏业(), b:  val_11);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.detail, 丏业丟一东丂东丘丛:  val_11);
    }
    internal void 丌丛三丂上丗丂丌下(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(this.detail == 0)
        {
                return;
        }
        
        this = this.detail.GetComponent<UIBasicSprite>();
        if(this == 0)
        {
                return;
        }
        
        this.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    public PriceLabel()
    {
    
    }

}
