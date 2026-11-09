using UnityEngine;
internal sealed class ClanSecondVersionBanner : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<UIButton> _closeButtons;
    private UIButton _updateButton;
    private UnityEngine.GameObject _twoButtonsContainer;
    private UnityEngine.GameObject _oneButtonContainer;
    private static bool <上丗丛下丄丑且上丈>k__BackingField;
    
    // Properties
    internal static bool 丁与丛七且丐丒丅丁 { get; set; }
    
    // Methods
    internal static bool 丏丌丕丏万丏且丁丝()
    {
        return (bool)ClanSecondVersionBanner.<上丗丛下丄丑且上丈>k__BackingField;
    }
    internal static void 丗丈丁丆丐丅丟东东(bool 丙业与丙丗丝不丈东)
    {
        ClanSecondVersionBanner.<上丗丛下丄丑且上丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        var val_1;
        UnityEngine.GameObject val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._twoButtonsContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._oneButtonContainer, 丏业丟一东丂东丘丛:  false);
        if((ClanSecondVersionBanner.<上丗丛下丄丑且上丈>k__BackingField) != false)
        {
                val_1 = null;
            val_2 = this._twoButtonsContainer;
        }
        else
        {
                val_1 = null;
            val_2 = this._oneButtonContainer;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
    }
    public void U_Update()
    {
        UnityEngine.Application.OpenURL(url:  丄丛丏丄不一丆丐丑.丅丙业上丄不丘丝三());
    }
    public void U_Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public ClanSecondVersionBanner()
    {
    
    }

}
