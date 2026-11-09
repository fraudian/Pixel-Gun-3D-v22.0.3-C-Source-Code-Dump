using UnityEngine;
public class CheckAvalibleCategory : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject backgroundBlock;
    public int currentCategory;
    private UISprite 丅专三丁丗丞丏万与;
    
    // Properties
    private UISprite 丑丕世丑专东丄东丅 { get; }
    
    // Methods
    private UISprite 丆且丟丝且丐一且丕()
    {
        UISprite val_3;
        if(this.丅专三丁丗丞丏万与 == 0)
        {
                this.丅专三丁丗丞丏万与 = this.backgroundBlock.GetComponent<UISprite>();
            return val_3;
        }
        
        val_3 = this.丅专三丁丗丞丏万与;
        return val_3;
    }
    private void Update()
    {
        var val_14;
        var val_15;
        if((TimeGameController.丄丞丁丈与业上丞丟 != 0) && (GameConnect.丙丘不世专且万丄丐() != false))
        {
                if(ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory != 1)
        {
                var val_3 = (ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory == this.currentCategory) ? 1 : 0;
        }
        else
        {
                val_14 = 1;
        }
        
            if(val_14 == this.backgroundBlock.activeSelf)
        {
                this.backgroundBlock.SetActive(value:  (val_14 == 0) ? 1 : 0);
        }
        
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.上丁业丑万丆丘丄专 > 0f)
        {
                val_15 = null;
            val_15 = null;
            WeaponSounds val_8 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            int val_14 = val_8.categoryNabor;
            val_14 = val_14 - 1;
            if(val_14 == this.currentCategory)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丆且丟丝且丐一且丕().gameObject, 丏业丟一东丂东丘丛:  true);
            this.丆且丟丝且丐一且丕().alpha = InGameGUI.丙丞专丌丁丞与不丐.七下丏丛丞丏下且专;
            return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丆且丟丝且丐一且丕().gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public CheckAvalibleCategory()
    {
    
    }

}
