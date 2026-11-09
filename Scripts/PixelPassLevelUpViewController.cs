using UnityEngine;
internal sealed class PixelPassLevelUpViewController : PGBehaviour
{
    // Fields
    private PixelPassLevelUpView levelUpView;
    private UnityEngine.GameObject blockScreen;
    private PixelPassAnimatedProgressView animatedProgressView;
    private bool 丆丑三丕丒丈七业丝;
    private int 七丐一丙下丌丙丞丝;
    private int 丝丈三丐丏丐且一三;
    
    // Methods
    private void OnEnable()
    {
        this.丆丑三丕丒丈七业丝 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.levelUpView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blockScreen, 丏业丟一东丂东丘丛:  false);
        PGCompany.万下丛丁丟不下丄业.丏下且东上东丁丈丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassLevelUpViewController::上丄丐丞丄与下丄丆(PGCompany.PixelPass.七丒七与丆下丕丏丅 一丐丗丁丞丆丅丟丄)));
        this.animatedProgressView.丁丕丒丆且丆世丞丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassLevelUpViewController::丟专丒下万丅上丅丌()));
    }
    private void OnDisable()
    {
        丌东一万丗上丝丌三.丌丛东不丝三丒丌丅(丒丘丏上丙丟丑丕丈:  "PP_LevelUp_ScreenBlocker");
        PGCompany.万下丛丁丟不下丄业.丄三丒丝丁且丟业丂(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassLevelUpViewController::上丄丐丞丄与下丄丆(PGCompany.PixelPass.七丒七与丆下丕丏丅 一丐丗丁丞丆丅丟丄)));
        this.animatedProgressView.万丝丈丂丙七丂丂世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassLevelUpViewController::丟专丒下万丅上丅丌()));
    }
    private void 上丄丐丞丄与下丄丆(PGCompany.PixelPass.七丒七与丆下丕丏丅 一丐丗丁丞丆丅丟丄)
    {
        if(一丐丗丁丞丆丅丟丄.丟丈丅万丐万丆上丁 != 4)
        {
                return;
        }
        
        this.七丐一丙下丌丙丞丝 = 一丐丗丁丞丆丅丟丄.丂丄与丁上专丘丆丈;
        this.丝丈三丐丏丐且一三 = 一丐丗丁丞丆丅丟丄.丘丗不丂世丘三三丙().丞丞丘业东丙丏七丌();
        this.丆丑三丕丒丈七业丝 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blockScreen, 丏业丟一东丂东丘丛:  true);
        一丛丟世丗丈丘丏万 val_4 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  "PP_LevelUp_ScreenBlocker", 丘丁三丅丆与丆业业:  5f, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PixelPassLevelUpViewController::世丄丙下丌万丕丁丅()));
    }
    private void 丟专丒下万丅上丅丌()
    {
        if(this.丆丑三丕丒丈七业丝 == false)
        {
                return;
        }
        
        丌东一万丗上丝丌三.丌丛东不丝三丒丌丅(丒丘丏上丙丟丑丕丈:  "PP_LevelUp_ScreenBlocker");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blockScreen, 丏业丟一东丂东丘丛:  false);
        this.levelUpView.下与丞三丅丛丄七丕(与丗丟丝丞上东且丞:  this.七丐一丙下丌丙丞丝, 丁丅丄丗不丁丟丈世:  this.丝丈三丐丏丐且一三);
        this.丆丑三丕丒丈七业丝 = false;
    }
    public PixelPassLevelUpViewController()
    {
    
    }
    private void 世丄丙下丌万丕丁丅()
    {
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blockScreen, 丏业丟一东丂东丘丛:  false);
    }

}
