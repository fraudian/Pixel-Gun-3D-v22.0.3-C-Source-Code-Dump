using UnityEngine;
public class ClanChestView : MonoBehaviour, 世丙丘下丝丗上下丏<世不丁七七丘业专丅>
{
    // Fields
    private 世不丁七七丘业专丅 <丅丝丌丝丁丏丙东丞>k__BackingField;
    private UILabel _medalsCountLabel;
    private UISprite _medalsCountFillSprite;
    private UILabel _timeLeftLabel;
    private UILabel _chestName;
    private UnityEngine.GameObject _mainGuiObject;
    private UnityEngine.GameObject _failObject;
    private UnityEngine.GameObject _progressObject;
    private UnityEngine.GameObject _readyObject;
    
    // Properties
    public 世不丁七七丘业专丅 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    public 世不丁七七丘业专丅 get_Context()
    {
        return (世不丁七七丘业专丅)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    private void 不丕丌与业丕下东丂(世不丁七七丘业专丅 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(世不丁七七丘业专丅 丐下丝丘丑丟丟丗丌)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丐下丝丘丑丟丟丗丌;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainGuiObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._failObject, 丏业丟一东丂东丘丛:  true);
    }
    public void U_ShowInfo()
    {
    
    }
    public void U_Interract()
    {
    
    }
    public ClanChestView()
    {
    
    }

}
