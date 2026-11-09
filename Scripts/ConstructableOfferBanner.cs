using UnityEngine;
internal sealed class ConstructableOfferBanner : BannerWindowLobbyPurchase, 丑且丆万丏丝丘丙丟
{
    // Fields
    private ConstructableOfferView constructableOfferView;
    private UnityEngine.GameObject lightHolder;
    private bool _isPresentationBanner;
    private UnityEngine.Color 世下丕东七丆丆专三;
    private bool 丁丝丌丞与丑丂三上;
    
    // Methods
    public override void Show()
    {
        var val_10;
        this.Show();
        val_10 = 0;
        System.Collections.Generic.List<PGCompany.世丞上丏丗不丛上东> val_2 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().业丒丛世丄下丄丘丈();
        if(val_2 != null)
        {
                val_10 = public System.Int32 System.Collections.Generic.List<PGCompany.世丞上丏丗不丛上东>::get_Count();
            if(val_2.Count != 0)
        {
                if(this._isPresentationBanner != false)
        {
                PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().丐七一世丛丕丘万七();
        }
        
            PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().丐丒三下丛丟业业丑();
            this.constructableOfferView.丈且东丑丂且万丒丅(丏不万丆丟丏七丄丕:  val_2.Item[0], 七丁丕三丄七东三三:  false, 下丐丟下业丑万万丒:  new System.Action(object:  this, method:  typeof(ConstructableOfferBanner).__il2cppRuntimeField_220));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lightHolder, 丏业丟一东丂东丘丛:  ShopNGUIController.丛世丛与丌不丈丐丐());
        }
        
        }
    
    }
    public override void Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lightHolder, 丏业丟一东丂东丘丛:  false);
        this.Hide();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public ConstructableOfferBanner()
    {
    
    }

}
