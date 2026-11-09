using UnityEngine;
public class RespawnWindowEquipmentItem : MonoBehaviour
{
    // Fields
    public UISprite emptyImage;
    public int itemCategory;
    private UIBasicSprite itemImage;
    private UnityEngine.GameObject clanBackground;
    internal WeaponToggleModulesUI modules;
    public string itemTag;
    
    // Properties
    internal UIBasicSprite 丐丆业丒丐不丘丆丗 { get; }
    
    // Methods
    internal UIBasicSprite 丑丅丞丕三丌丁世丐()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemImage);
        this.itemImage = val_1;
        return val_1;
    }
    public void SetItemTag(string 丕丁下丌不万丅丞丛, int 业丈世与下丘丛丐且)
    {
        bool val_15;
        bool val_1 = RespawnWindowEquipmentItem.丒一与丈丛业万丈东(丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丑丅丞丕三丌丁世丐().gameObject, 丏业丟一东丂东丘丛:  (~val_1) & 1);
        bool val_6 = val_1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.emptyImage.gameObject, 丏业丟一东丂东丘丛:  val_6);
        this.itemTag = (val_1 != true) ? 0 : 丕丁下丌不万丅丞丛;
        this.itemCategory = ((val_1 & true) != 0) ? 业丈世与下丘丛丐且 : (!0);
        if(val_6 != false)
        {
                return;
        }
        
        if((丁下万丟且丟丛下业.丈丛下丗丆丐丞丟丟(丕丁下丌不万丅丞丛:  丕丁下丌不万丅丞丛)) != false)
        {
                val_15 = 1;
        }
        else
        {
                val_15 = BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  丕丁下丌不万丅丞丛));
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanBackground, 丏业丟一东丂东丘丛:  val_15);
        UnityEngine.Texture val_14 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  丕丁下丌不万丅丞丛, 七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(this.丑丅丞丕三丌丁世丐() == null)
        {
            
        }
    
    }
    public void ResetImage()
    {
        if(this.丑丅丞丕三丌丁世丐() == null)
        {
            
        }
    
    }
    private static bool 丒一与丈丛业万丈东(string 丕丁下丌不万丅丞丛)
    {
        if((System.String.IsNullOrEmpty(value:  丕丁下丌不万丅丞丛)) == true)
        {
                return true;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  与丂丏丛丞丞丒丟丄.丄丄丏丛且丛丙且丑())) == true)
        {
                return true;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) == true)
        {
                return true;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  与丂丏丛丞丞丒丟丄.丟丕丈丙丈业业专业())) == true)
        {
                return true;
        }
        
        if((System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟())) == false)
        {
                return System.String.op_Equality(a:  丕丁下丌不万丅丞丛, b:  "MaskNoneEquipped");
        }
        
        return true;
    }
    public RespawnWindowEquipmentItem()
    {
    
    }

}
