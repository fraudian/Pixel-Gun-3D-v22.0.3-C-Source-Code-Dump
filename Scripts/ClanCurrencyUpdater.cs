using UnityEngine;
public class ClanCurrencyUpdater : CurrencyUpdater
{
    // Fields
    private UITexture _currencyTexture;
    
    // Properties
    protected override string 世丟丑丘丘业七丑不 { get; }
    
    // Methods
    private void Start()
    {
        this.gameObject.SetActive(value:  false);
    }
    protected override int 丞下丂下东东丅一七()
    {
        return 500;
    }
    protected override string 丌东世丁丁丌丐丕丟()
    {
        return "ClanCurrencyUpdater_blink_sequence";
    }
    public ClanCurrencyUpdater()
    {
    
    }

}
