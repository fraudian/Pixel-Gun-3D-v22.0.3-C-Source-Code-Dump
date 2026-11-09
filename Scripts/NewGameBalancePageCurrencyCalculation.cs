using UnityEngine;
public class NewGameBalancePageCurrencyCalculation : NewGameBalancePage
{
    // Fields
    private UITweener _alphaTween;
    private UILabel _newCoinsCountLabel;
    private UILabel _newGemsCountLabel;
    private UILabel _oldCoinsCountLabel;
    private UILabel _oldGemsCountLabel;
    
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
        var val_10;
        this.OnEnable();
        val_10 = null;
        this.与专七不丐丂上七且(丏七丗丏且丕三丘丞:  NewGameBalance12_5WindowController.万丆丙万丏七丒丅丅(), 世东世丙万丞丐七丌:  NewGameBalance12_5WindowController.专丕丙不万世丞丌丛(), 丞丝丅丏万丛丞丁且:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且(), 丄世丑一丗专丒丟丂:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
        this._alphaTween.enabled = true;
        this._alphaTween.ResetToBeginning();
        this.StopCoroutine(routine:  this.丝万下一丙上上丌下());
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丝万下一丙上上丌下());
    }
    private System.Collections.IEnumerator 丝万下一丙上上丌下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NewGameBalancePageCurrencyCalculation.专丑且七丄丑丛七与();
    }
    private void 与专七不丐丂上七且(int 丏七丗丏且丕三丘丞, int 世东世丙万丞丐七丌, int 丞丝丅丏万丛丞丁且, int 丄世丑一丗专丒丟丂)
    {
        this._oldGemsCountLabel.text = 丏七丗丏且丕三丘丞.ToString();
        this._oldCoinsCountLabel.text = 世东世丙万丞丐七丌.ToString();
        this._newGemsCountLabel.text = 丞丝丅丏万丛丞丁且.ToString();
        this._newCoinsCountLabel.text = 丄世丑一丗专丒丟丂.ToString();
    }
    public NewGameBalancePageCurrencyCalculation()
    {
        mem[1152921536342770744] = 1073741824;
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
