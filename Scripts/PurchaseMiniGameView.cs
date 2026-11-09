using UnityEngine;
public sealed class PurchaseMiniGameView : MonoBehaviour
{
    // Fields
    public UITexture icon;
    public UILabel[] price;
    public UILabel[] itemName;
    public UISprite priceCurrency;
    public UIButton[] buttons;
    public UnityEngine.GameObject equipped;
    private 丅东世丒东三丏丐丌 <丝业三丑三上丆专不>k__BackingField;
    
    // Properties
    public 丅东世丒东三丏丐丌 不下下丞三一丘丗丐 { get; set; }
    
    // Methods
    public void Setup(丅东世丒东三丏丐丌 下丅丙一丂丗丅丝七)
    {
        var val_9;
        UITexture val_10;
        PurchaseMiniGameView.丘丞上世丗丘丏丐东 val_1 = new PurchaseMiniGameView.丘丞上世丗丘丏丐东();
        if(val_1 != null)
        {
                val_9 = val_1;
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            val_10 = this.icon;
            this.<丝业三丑三上丆专不>k__BackingField = 下丅丙一丂丗丅丝七;
        }
        else
        {
                val_9 = 16;
            mem[16] = 下丅丙一丂丗丅丝七;
            val_10 = this.icon;
            this.<丝业三丑三上丆专不>k__BackingField = mem[16];
        }
        
        UnityEngine.Texture val_3 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七 + 16, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七 + 16), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.itemName, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void PurchaseMiniGameView.丘丞上世丗丘丏丐东::丆一且世上丗上一丗(UILabel 丛丞丑丞丐丗上丂上)));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.price, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void PurchaseMiniGameView.丘丞上世丗丘丏丐东::一丄业丐丄丒下丏丞(UILabel 丛丞丑丞丐丗上丂上)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceCurrency.gameObject, 丏业丟一东丂东丘丛:  ((下丅丙一丂丗丅丝七 + 24.丟丂丞不专丆万丒世()) > 0) ? 1 : 0);
    }
    public 丅东世丒东三丏丐丌 get_Item()
    {
        return (丅东世丒东三丏丐丌)this.<丝业三丑三上丆专不>k__BackingField;
    }
    private void 丘丕丈下东一丑上丗(丅东世丒东三丏丐丌 丙业与丙丗丝不丈东)
    {
        this.<丝业三丑三上丆专不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public PurchaseMiniGameView()
    {
    
    }

}
