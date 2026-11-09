using UnityEngine;
internal class NewGameBalancePageGetFreeGems : NewGameBalancePage
{
    // Fields
    private UIButton _getGemsButton;
    private UILabel _rewardCountLabel;
    
    // Properties
    public override bool 丕世一与业丅万专丑 { get; }
    
    // Methods
    public override bool get_CanShow()
    {
        var val_2 = null;
        bool val_1 = NewGameBalance12_5WindowController.下与三丐丑丆业七世();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    protected override void OnEnable()
    {
        var val_6;
        UILabel val_7;
        var val_8;
        mem[1152921536343757904] = 0;
        this.OnEnable();
        val_6 = null;
        UnityEngine.GameObject val_2 = this._getGemsButton.gameObject;
        if(NewGameBalance12_5WindowController.下与三丐丑丆业七世() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2.gameObject, 丏业丟一东丂东丘丛:  false);
        val_8 = null;
        val_7 = this._rewardCountLabel;
        val_8 = null;
        val_7.text = NewGameBalance12_5WindowController.三丙丅丟丐一丈业一.ToString();
    }
    protected override void Update()
    {
        mem[1152921536343894480] = 0;
        this.不丞下丝丕丈上丈丕();
    }
    public void U_GetGems()
    {
        var val_2 = null;
        if(NewGameBalance12_5WindowController.下与三丐丑丆业七世() != true)
        {
                NewGameBalance12_5WindowController.丅一上丑与下丆丂且();
        }
    
    }
    protected override void 业丒丄丁丘丒丝专丌()
    {
        var val_2 = null;
        if(NewGameBalance12_5WindowController.下与三丐丑丆业七世() == false)
        {
                return;
        }
        
        this.业丒丄丁丘丒丝专丌();
    }
    public NewGameBalancePageGetFreeGems()
    {
        mem[1152921536344230456] = 1073741824;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
