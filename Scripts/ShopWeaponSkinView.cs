using UnityEngine;
public class ShopWeaponSkinView : ShopItemSkinView
{
    // Fields
    private UITextureMasked _skinItemTexture;
    
    // Methods
    protected override void 下丘丈三不万东丟丄(UnityEngine.GameObject 万丝丗丛丁丁丆业丞)
    {
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._skinItemTexture, 与万丆丛丒万丝丙丑:  this.丕丏业丒丘丒世丟且());
    }
    internal override bool 丁一丄一丑一且丑丘(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        PGCompany.丟丝世万东万丆丟上 val_2;
        PGCompany.丗丟丄丈东丝丕丄世 val_1 = this.丕丏业丒丘丒世丟且();
        if(val_1 != null)
        {
                val_1 = (null == null) ? (val_1) : 0;
            return 丏丞丛上七丁丞丛万.与丏丘丏丆丗丌专丅(丞丝丌七丁万丗丐一:  val_2 = 0);
        }
        
        return 丏丞丛上七丁丞丛万.与丏丘丏丆丗丌专丅(丞丝丌七丁万丗丐一:  val_2);
    }
    internal override 丈丞丕丘丕丗与上一 下丆丄与世丂丞丂七()
    {
        var val_2;
        var val_3;
        PGCompany.丗丟丄丈东丝丕丄世 val_1 = this.丕丏业丒丘丒世丟且();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_2 = null;
        if(null == val_2)
        {
            goto label_2;
        }
        
        label_1:
        val_3 = null;
        goto label_3;
        label_2:
        val_3 = val_2;
        label_3:
        val_1 = (val_2 == val_3) ? (val_1) : 0;
        goto val_2 == val_3 ? val_1 : 0 + 600;
    }
    public ShopWeaponSkinView()
    {
    
    }

}
