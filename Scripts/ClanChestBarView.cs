using UnityEngine;
public class ClanChestBarView : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _coinObj;
    private UILabel _currencyLabel;
    private UnityEngine.GameObject _currencyObject;
    private UnityEngine.GameObject _gemObj;
    private UnityEngine.GameObject _medalObj;
    private UIWidget _possibleOpen;
    private UILabel _stateLabel;
    private UIBasicSprite _texture;
    public UIWidget selector;
    private 世不丁七七丘业专丅 <丂世丕丝丕丛三世丒>k__BackingField;
    private System.Action<ClanChestBarView> 丌不丂丌丁丛丆丟与;
    
    // Properties
    public 世不丁七七丘业专丅 丌丈东专丟丟与世三 { get; set; }
    
    // Methods
    public 世不丁七七丘业专丅 get_Chest()
    {
        return (世不丁七七丘业专丅)this.<丂世丕丝丕丛三世丒>k__BackingField;
    }
    private void 丝丐七世下丕专且丄(世不丁七七丘业专丅 丙业与丙丗丝不丈东)
    {
        this.<丂世丕丝丕丛三世丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void add_OnClicked(System.Action<ClanChestBarView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921536531997064);
    
    }
    public void remove_OnClicked(System.Action<ClanChestBarView> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921536532133640);
    
    }
    public void Set(世不丁七七丘业专丅 丐下丝丘丑丟丟丗丌)
    {
        this.<丂世丕丝丕丛三世丒>k__BackingField = 丐下丝丘丑丟丟丗丌;
        if(丐下丝丘丑丟丟丗丌 != null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currencyObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this._texture == 0)
        {
                return;
        }
        
        UnityEngine.Texture val_5 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/Android_Alpha/{0}_Alpha", arg0:  this._texture.name));
        this = ???;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_308;
    }
    public void OnClick()
    {
        if(this.丌不丂丌丁丛丆丟与 == null)
        {
                return;
        }
        
        this.丌不丂丌丁丛丆丟与.Invoke(obj:  this);
    }
    public ClanChestBarView()
    {
    
    }

}
