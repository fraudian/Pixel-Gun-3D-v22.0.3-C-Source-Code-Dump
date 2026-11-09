using UnityEngine;
public class TicketsUpdater : CurrencyUpdater
{
    // Properties
    protected override string 世丟丑丘丘业七丑不 { get; }
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        BankController.世丘丏且丅丒丝七丈(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void CurrencyUpdater::上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅)));
    }
    protected override void OnDisable()
    {
        BankController.丝丅丙且且丈丑丐丝(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void CurrencyUpdater::上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅)));
        this.OnDisable();
    }
    protected override int 丞下丂下东东丅一七()
    {
        return BankController.丈丐业丈丄丕丕三世();
    }
    protected override string 丌东世丁丁丌丐丕丟()
    {
        return "TicketsUpdater_blink_sequence";
    }
    public TicketsUpdater()
    {
    
    }

}
