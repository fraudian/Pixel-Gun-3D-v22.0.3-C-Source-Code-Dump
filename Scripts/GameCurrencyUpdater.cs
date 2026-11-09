using UnityEngine;
public class GameCurrencyUpdater : CurrencyUpdater
{
    // Fields
    private bool _gems;
    
    // Properties
    protected override string 世丟丑丘丘业七丑不 { get; }
    
    // Methods
    protected override string 丌东世丁丁丌丐丕丟()
    {
        return "GameCurrencyUpdater_blink_sequence";
    }
    protected override int 丞下丂下东东丅一七()
    {
        if(this._gems != false)
        {
                Progress.丑丅专一业丙丝丄丁 val_1 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
            if(val_1 != null)
        {
                return val_1.世丄丂下丏丝丞丒且();
        }
        
            return val_1.世丄丂下丏丝丞丒且();
        }
        
        Progress.丑丅专一业丙丝丄丁 val_2 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        if(val_2 != null)
        {
                return val_2.丗丞丝丅丈丑丗丂丌();
        }
        
        return val_2.丗丞丝丅丈丑丗丂丌();
    }
    public GameCurrencyUpdater()
    {
    
    }

}
