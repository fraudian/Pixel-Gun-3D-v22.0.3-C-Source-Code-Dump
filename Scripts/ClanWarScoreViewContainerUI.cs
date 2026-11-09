using UnityEngine;
internal sealed class ClanWarScoreViewContainerUI : PGBehaviour
{
    // Fields
    private UILabel _place;
    private UILabel _name;
    private UILabel _score;
    private UITexture _logo;
    private UITextureMasked _chest;
    internal UILabel _levelUp;
    internal UILabel _levelDown;
    internal UISprite _bg;
    internal UISprite _outline;
    internal UITexture Shield;
    private PGCompany.ItemCurrencyUI _currencyRewardUi;
    internal PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝;
    private System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丞丙世丗丈专一丆世;
    
    // Properties
    internal UILabel 万丙丛丂丌丞一三不 { get; }
    internal UILabel 专丕与丒丗丁丘专丟 { get; }
    internal UILabel 丄东丞丘丞下下下丙 { get; }
    internal UITexture 七不丐丆丅丞丗丛丘 { get; }
    internal UITextureMasked 丌丈东专丟丟与世三 { get; }
    internal PGCompany.ItemCurrencyUI 丂丆丒丘丂丛丟丛与 { get; }
    
    // Methods
    internal UILabel 三丄丏丂丁下丐丛万()
    {
        return (UILabel)this._place;
    }
    internal UILabel 东丙上东业丆不丟丘()
    {
        return (UILabel)this._name;
    }
    internal UILabel 丞丏丕丑丞丑丏丏丄()
    {
        return (UILabel)this._score;
    }
    internal UITexture 丈丐丒丘丕丅七丈丙()
    {
        return (UITexture)this._logo;
    }
    internal UITextureMasked 丈丂七世丙丑丝下丘()
    {
        return (UITextureMasked)this._chest;
    }
    internal PGCompany.ItemCurrencyUI 丝与丄业世丒丄七丙()
    {
        return (PGCompany.ItemCurrencyUI)this._currencyRewardUi;
    }
    internal void 万东世丆丄丂丁丟丗(System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丞丙世丗丈专一丆世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞丙世丗丈专一丆世 != 1152921536725814280);
    
    }
    internal void 丗且丏丞不丟丛不丝(System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丞丙世丗丈专一丆世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞丙世丗丈专一丆世 != 1152921536725950856);
    
    }
    public void U_OnChestButtonClick()
    {
        if(this.丞丙世丗丈专一丆世 == null)
        {
                return;
        }
        
        this.丞丙世丗丈专一丆世.Invoke(obj:  this.丒丁丝与且丂且丐丝);
    }
    public ClanWarScoreViewContainerUI()
    {
    
    }

}
