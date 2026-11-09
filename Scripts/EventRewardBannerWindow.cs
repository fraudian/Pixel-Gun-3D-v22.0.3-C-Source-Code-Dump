using UnityEngine;
public class EventRewardBannerWindow : BannerWindow
{
    // Fields
    private static Rilisoft.丅丟丒丟丑丈丒三丆 专东丈一丟丂丅丌丆;
    private static Rilisoft.且丈丞一丞丟与上七 下万丅丌丘丁丈七下;
    private int 专与丑东专业丒丝三;
    private UILabel _currencyLeftLabel;
    private UILabel _rewardLabel;
    private UIBasicSprite _eventCurrencyTexture;
    
    // Properties
    private static Rilisoft.丅丟丒丟丑丈丒三丆 且丄丄丁丙专丛且丁 { get; }
    private static Rilisoft.且丈丞一丞丟与上七 丄丗丌三三丁万业丛 { get; }
    internal static bool 丕世一与业丅万专丑 { get; }
    private UIBasicSprite 丑下丙万下丒丂丞丞 { get; }
    
    // Methods
    private static Rilisoft.丅丟丒丟丑丈丒三丆 丛丁一与专丄上丄丙()
    {
        Rilisoft.丅丟丒丟丑丈丒三丆 val_2;
        Rilisoft.丅丟丒丟丑丈丒三丆 val_3 = EventRewardBannerWindow.专东丈一丟丂丅丌丆;
        if(val_3 != null)
        {
                return val_3;
        }
        
        Rilisoft.丅丟丒丟丑丈丒三丆 val_1 = null;
        val_2 = val_1;
        val_1 = new Rilisoft.丅丟丒丟丑丈丒三丆(丟东丟丑丕丄丂丟丙:  "EventRewardBannerWindow-EventIdForShow");
        EventRewardBannerWindow.专东丈一丟丂丅丌丆 = val_2;
        val_3 = EventRewardBannerWindow.专东丈一丟丂丅丌丆;
        return val_3;
    }
    private static Rilisoft.且丈丞一丞丟与上七 丑丁万上不丑丅万且()
    {
        Rilisoft.且丈丞一丞丟与上七 val_2;
        Rilisoft.且丈丞一丞丟与上七 val_3 = EventRewardBannerWindow.下万丅丌丘丁丈七下;
        if(val_3 != null)
        {
                return val_3;
        }
        
        Rilisoft.且丈丞一丞丟与上七 val_1 = null;
        val_2 = val_1;
        val_1 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "EventRewardBannerWindow-EventCurrencyCountForShow");
        EventRewardBannerWindow.下万丅丌丘丁丈七下 = val_2;
        val_3 = EventRewardBannerWindow.下万丅丌丘丁丈七下;
        return val_3;
    }
    internal static bool 丌七丘七丗下丐七丞()
    {
        string val_9;
        var val_10;
        val_9 = EventRewardBannerWindow.丛丁一与专丄上丄丙().世三丞丅丑丌丈丈一();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_9)) != false)
        {
                int val_5 = EventRewardBannerWindow.丑丁万上不丑丅万且().世三丞丅丑丌丈丈一();
            val_9 = EventRewardBannerWindow.丑丁万上不丑丅万且();
            var val_8 = (val_9.世三丞丅丑丌丈丈一() > 0) ? 1 : 0;
            return (bool)val_10;
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    internal static void 万丙丁丞丙丞丘丞丕(string 丟丟丄专上丟丁丐丝)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丟丟丄专上丟丁丐丝)) == true)
        {
                return;
        }
        
        int val_2 = BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
        if(val_2 < 1)
        {
                return;
        }
        
        EventRewardBannerWindow.丛丁一与专丄上丄丙().丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丟丟丄专上丟丁丐丝);
        EventRewardBannerWindow.丑丁万上不丑丅万且().丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_2);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.丙丐丅丁丈上丕丝丝();
    }
    private void 丙丐丅丁丈上丕丝丝()
    {
        if(EventRewardBannerWindow.丌七丘七丗下丐七丞() == false)
        {
                return;
        }
        
        int val_3 = EventRewardBannerWindow.丑丁万上不丑丅万且().世三丞丅丑丌丈丈一();
        this.专与丑东专业丒丝三 = (int)UnityEngine.Mathf.Max(a:  1f, b:  (float)UnityEngine.Mathf.FloorToInt(f:  (float)val_3 * 0.25f));
        this._rewardLabel.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  (int)UnityEngine.Mathf.Max(a:  1f, b:  (float)UnityEngine.Mathf.FloorToInt(f:  (float)val_3 * 0.25f)));
        this._currencyLeftLabel.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_3);
        UIBasicSprite val_12 = this.丟丌与丘且万世丗丙();
        UnityEngine.Texture val_13 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Rilisoft.丛且世丐丆上七业丁.丆丆丏丄丈丝丝业不(丟丟丄专上丟丁丐丝:  EventRewardBannerWindow.丛丁一与专丄上丄丙().世三丞丅丑丌丈丈一()));
        this = ???;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
    }
    private void 三丛丁丆东世丁丏三()
    {
        if(EventRewardBannerWindow.丌七丘七丗下丐七丞() == false)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  50);
        BankController.丒丘上丟下丅丑丅丄(丌丒丝东丌下丕丁丅:  this.专与丑东专业丒丝三, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  25, 丟世且丕丂丁万丒万:  0);
        Rilisoft.丛且世丐丆上七业丁.丄与三与丌丏丈丕一(丟丟丄专上丟丁丐丝:  EventRewardBannerWindow.丛丁一与专丄上丄丙().世三丞丅丑丌丈丈一());
        Rilisoft.三一丈七且丄与丝东.七与丝丛丄丛专丐三(丟丟丄专上丟丁丐丝:  EventRewardBannerWindow.丛丁一与专丄上丄丙().世三丞丅丑丌丈丈一(), 不丂丙丛丈不上七且:  false);
        EventRewardBannerWindow.丛丁一与专丄上丄丙().丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  System.String.alignConst);
        EventRewardBannerWindow.丑丁万上不丑丅万且().丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0);
        this.专与丑东专业丒丝三 = 0;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void U_Hide()
    {
        this.三丛丁丆东世丁丏三();
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  21);
    }
    private UIBasicSprite 丟丌与丘且万世丗丙()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._eventCurrencyTexture);
        this._eventCurrencyTexture = val_1;
        return val_1;
    }
    public EventRewardBannerWindow()
    {
    
    }

}
