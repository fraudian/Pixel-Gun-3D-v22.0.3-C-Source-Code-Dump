using UnityEngine;
internal sealed class AdsButtonController : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject adsButton;
    
    // Properties
    internal bool 丅业东万丌丕上丌丄 { get; }
    
    // Methods
    internal bool 丈丐丞丐上丑且丕万()
    {
        long val_4 = PixelTime.丝丗专上三不丄丑丑();
        val_4 = ((val_4 > 0) ? 1 : 0) & ((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丒丒丟丄业丆丆三丐(丁丂丕与丁丒丕丟丞: out  0)) ^ 1);
        return (bool)val_4;
    }
    private void OnEnable()
    {
        this.丑不丗三丕丌万丁丙();
    }
    private void OnDisable()
    {
    
    }
    private void 丑不丗三丕丌万丁丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.adsButton, 丏业丟一东丂东丘丛:  static_value_000004F0.丈丐丞丐上丑且丕万());
    }
    public void U_AdsButtonPressed()
    {
        this.丘业上三丝七丒丏丟();
    }
    private void 丘业上三丝七丒丏丟()
    {
        object val_8;
        string val_3 = 0;
        Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> val_2 = 0;
        if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丙丒三丂东丒一丑上(丅丟丛丙下丙丄丒丁: out  val_2, 丏丞专丏业丗丝七丝: out  val_3)) != false)
        {
                val_8 = val_2;
            bool val_5 = val_8.TryProcessEvent(ev:  2);
            return;
        }
        
        val_8 = "[" + this.tag + "] TryResolveLobbyStateMachine: "("] TryResolveLobbyStateMachine: ") + val_3;
        UnityEngine.Debug.LogWarning(message:  val_8);
    }
    public AdsButtonController()
    {
    
    }

}
