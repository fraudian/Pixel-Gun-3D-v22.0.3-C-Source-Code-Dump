using UnityEngine;
public sealed class RespawnWindowItemToBuy : MonoBehaviour
{
    // Fields
    private static UnityEngine.Color 丆丗丞丝东丁一丕丛;
    private static UnityEngine.Color 专丈三上丞世丙丅丘;
    public UIButton btnBuy;
    public int itemCategory;
    private UIBasicSprite itemImage;
    public UILabel itemNameLabel;
    internal 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三;
    public UnityEngine.GameObject itemPriceBtnBuyContainer;
    public UISprite itemPriceIcon;
    public UILabel itemPriceLabel;
    public string itemTag;
    public UILabel needTierLabel;
    public string nonLocalizedName;
    
    // Properties
    private UIBasicSprite 丐丆业丒丐不丘丆丗 { get; }
    
    // Methods
    private UIBasicSprite 丑丅丞丕三丌丁世丐()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemImage);
        this.itemImage = val_1;
        return val_1;
    }
    internal void 丅与丘丌专专丗丞丁(string 丕丁下丌不万丅丞丛, System.Nullable<int> 与丏丏丁丌与且三专, string 上丒业丗专丐七东东 = "")
    {
        string val_17;
        string val_18;
        var val_19;
        var val_20;
        val_17 = 上丒业丗专丐七东东;
        val_18 = 丕丁下丌不万丅丞丛;
        bool val_1 = System.String.IsNullOrEmpty(value:  val_18);
        UnityEngine.GameObject val_2 = this.gameObject;
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_1 == false)
        {
            goto label_2;
        }
        
        label_3:
        val_2.SetActive(value:  false);
        return;
        label_1:
        if(val_1 == true)
        {
            goto label_3;
        }
        
        label_2:
        val_2.SetActive(value:  true);
        int val_3 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_18);
        this.itemTag = val_18;
        this.itemCategory = val_3;
        this.万丐丏丐丒万不丟三 = 0;
        三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_18);
        if(val_4 != null)
        {
                if((WeaponManager.丞上一丘丆三下丐丑().Contains(item:  val_4.三与丛丑且丐丈业丌())) != false)
        {
                val_18 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_4.三丙且下一专上东与()).与不丞丑七丘丁丂丛();
        }
        
        }
        
        UIBasicSprite val_11 = this.丑丅丞丕三丌丁世丐();
        UnityEngine.Texture val_12 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_18, 七丆丒与丗丌丄且丂:  val_3, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = 与丏丏丁丌与且三专.HasValue}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(val_3 != 25000)
        {
                if((1296280952 & 1) != 0)
        {
                val_19;
        }
        else
        {
                val_19 = 0;
        }
        
            val_17 = RespawnWindowItemToBuy.与丆业丅上丗七丆一(丕丁下丌不万丅丞丛:  val_18, 业丈世与下丘丛丐且:  val_3, 与丏丏丁丌与且三专:  0);
        }
        
        this.itemNameLabel.text = val_17;
        if((1296280952 & 1) != 0)
        {
                val_20;
        }
        else
        {
                val_20 = 0;
        }
        
        this.nonLocalizedName = RespawnWindowItemToBuy.丝丑丐丒世世丞丌不(丕丁下丌不万丅丞丛:  val_18, 业丈世与下丘丛丐且:  val_3, 与丏丏丁丌与且三专:  0);
        this.itemPriceBtnBuyContainer.gameObject.SetActive(value:  false);
        this.needTierLabel.gameObject.SetActive(value:  false);
    }
    internal static string 与丆业丅上丗七丆一(string 丕丁下丌不万丅丞丛, CategoryNames 业丈世与下丘丛丐且, int 与丏丏丁丌与且三专 = 0)
    {
        string val_6 = 丕丁下丌不万丅丞丛;
        if((System.String.op_Equality(a:  val_6 = 丕丁下丌不万丅丞丛, b:  "LikeID")) != false)
        {
                return I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1796");
        }
        
        if((下专世丏丈丞三丗不.专丞丏东一丗丟下东(丆万一不丌且东丐丐:  val_6)) == false)
        {
                return 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_6 = 下专世丏丈丞三丗不.不丘与东丂与下丆丙(丞丅上丏丂且下丅与:  val_6, 七丞丙丒三丕且丌丟:  UnityEngine.Mathf.Min(a:  与丏丏丁丌与且三专, b:  下专世丏丈丞三丗不.丝丏与一丞万七一东())), 七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且);
        }
        
        return 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_6, 七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且);
    }
    internal static string 丝丑丐丒世世丞丌不(string 丕丁下丌不万丅丞丛, CategoryNames 业丈世与下丘丛丐且, int 与丏丏丁丌与且三专 = 0)
    {
        if((下专世丏丈丞三丗不.专丞丏东一丗丟下东(丆万一不丌且东丐丐:  丕丁下丌不万丅丞丛)) == false)
        {
                return 丏丄丑上丛不丈且万.丄丌丙丞丛丞专丞丈(丞一丁业丄一一业且:  丕丁下丌不万丅丞丛, 丛丐且下丂丏丁专丌:  丕丁下丌不万丅丞丛 = 下专世丏丈丞三丗不.不丘与东丂与下丆丙(丞丅上丏丂且下丅与:  丕丁下丌不万丅丞丛, 七丞丙丒三丕且丌丟:  UnityEngine.Mathf.Min(a:  与丏丏丁丌与且三专, b:  下专世丏丈丞三丗不.丝丏与一丞万七一东())), 七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且, 专专丗丙丁七世丛业:  丕丁下丌不万丅丞丛);
        }
        
        return 丏丄丑上丛不丈且万.丄丌丙丞丛丞专丞丈(丞一丁业丄一一业且:  丕丁下丌不万丅丞丛, 丛丐且下丂丏丁专丌:  丕丁下丌不万丅丞丛, 七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且, 专专丗丙丁七世丛业:  丕丁下丌不万丅丞丛);
    }
    private static void 丗丘丗丈丑丒丗七丘(UISprite 丆且丁丙丁丏丝专丙, UILabel 三丈丕丒丄丟上三丁, 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        float val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_8 = 丆且丁丙丁丏丝专丙;
        val_9 = null;
        val_9 = null;
        bool val_2 = System.String.op_Equality(a:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        string val_3 = (val_2 != true) ? "gem_znachek" : "ingame_coin";
        if(val_8 != null)
        {
                val_8.spriteName = val_3;
            val_8.width = (val_2 != true) ? 24 : 20;
        }
        else
        {
                0.spriteName = val_3;
            0.width = (val_2 != true) ? 24 : 20;
            val_8 = 0;
        }
        
        val_8.height = 20;
        三丈丕丒丄丟上三丁.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世());
        val_10 = null;
        if(val_2 != false)
        {
                val_11 = null;
            val_13 = 1152921505320480772;
            val_14 = 1152921505320480776;
            val_15 = 1152921505320480780;
        }
        else
        {
                val_16 = null;
            val_12 = 1152921505320480784;
            val_13 = 1152921505320480788;
            val_14 = 1152921505320480792;
            val_15 = 1152921505320480796;
        }
        
        三丈丕丒丄丟上三丁.color = new UnityEngine.Color() {r = val_12, g = mem[1152921505320480788], b = mem[1152921505320480792], a = mem[1152921505320480796]};
    }
    public void Reset()
    {
        UIBasicSprite val_1 = this.丑丅丞丕三丌丁世丐();
        this.itemTag = System.String.alignConst;
        this.nonLocalizedName = System.String.alignConst;
    }
    public RespawnWindowItemToBuy()
    {
    
    }
    private static RespawnWindowItemToBuy()
    {
        UnityEngine.Color val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        RespawnWindowItemToBuy.丆丗丞丝东丁一丕丛 = val_1.r;
        RespawnWindowItemToBuy.丆丗丞丝东丁一丕丛.__il2cppRuntimeField_4 = val_1.g;
        RespawnWindowItemToBuy.丆丗丞丝东丁一丕丛.__il2cppRuntimeField_8 = val_1.b;
        RespawnWindowItemToBuy.丆丗丞丝东丁一丕丛.__il2cppRuntimeField_C = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        RespawnWindowItemToBuy.专丈三上丞世丙丅丘 = val_2.r;
        RespawnWindowItemToBuy.丆丗丞丝东丁一丕丛.__il2cppRuntimeField_14 = val_2.g;
        RespawnWindowItemToBuy.丆丗丞丝东丁一丕丛.__il2cppRuntimeField_18 = val_2.b;
        RespawnWindowItemToBuy.丆丗丞丝东丁一丕丛.__il2cppRuntimeField_1C = val_2.a;
    }

}
