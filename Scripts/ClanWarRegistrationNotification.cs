using UnityEngine;
internal sealed class ClanWarRegistrationNotification : BannerWindow
{
    // Fields
    private static System.Action 丛丄业丘不丆丄三丞;
    private UnityEngine.GameObject _regButton;
    private UIButton _regWithPriceButton;
    private UnityEngine.GameObject _gem;
    private UnityEngine.GameObject _coin;
    private UILabel _price;
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ClanWarRegistrationNotification.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ClanWarRegistrationNotification.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static bool 业丗丝万专万丞丟上()
    {
        var val_19;
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
                return (bool)0 & 1;
        }
        
        val_19 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_19.丁三丂丒业丁丙丂且() == false)
        {
                return (bool)0 & 1;
        }
        
        val_19 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丁丈丕丆下丙丏业世();
        if(val_19 < PGCompany.丂丘丞丂丏七丁丄不.不专不丝与丂丐三业())
        {
                return (bool)0 & 1;
        }
        
        val_19 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_19.与七世丝上丗丄丌丗() == false)
        {
                return (bool)0 & 1;
        }
        
        val_19 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_19.丆丅丟丂且丑一与丘() == true)
        {
                return (bool)0 & 1;
        }
        
        val_19 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_19.丗丛丗丏丑丏丌丒丆() == true)
        {
                return (bool)0 & 1;
        }
        
        val_19 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_19.丗丕三下上丗专东业() != false)
        {
                return (bool)0 & 1;
        }
        
        bool val_19 = (Progress.七七世万专丕丁上业.业丌丌丈丑不丕业丅().丕丕丛丝丘丐三丒不(下上丐丆丝丟丝丒不:  "cw_rcs")) ^ 1;
        return (bool)0 & 1;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "ClanWarRegistrationNotification_" + this.gameObject.name);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    public override void Show()
    {
        this.Show();
        this.丐上万且丘丅世业丄();
    }
    private void 丐上万且丘丅世业丄()
    {
        UILabel val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        if(BalanceController.下七不丙丌一丁专丕.丟丂丞不专丆万丒世() >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._regButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._regWithPriceButton, 丏业丟一东丂东丘丛:  true);
            val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            string val_8 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            val_8 = System.String.op_Equality(a:  BalanceController.下七不丙丌一丁专丕.东与三丌丅三丒丏业(), b:  val_8);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gem, 丏业丟一东丂东丘丛:  val_8);
            string val_9 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            val_9 = System.String.op_Equality(a:  BalanceController.下七不丙丌一丁专丕.东与三丌丅三丒丏业(), b:  val_9);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coin, 丏业丟一东丂东丘丛:  val_9);
            val_8 = this._price;
            val_8.text = BalanceController.下七不丙丌一丁专丕.丟丂丞不专丆万丒世().ToString();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._regButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._regWithPriceButton, 丏业丟一东丂东丘丛:  false);
    }
    public void U_Registration()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        PGCompany.ClanWarRegistration.RegistrationInClanWar(丛丈七丒丄业丒丈丕:  0, 丙丕丏下世丌不三丕:  new System.Action(object:  this, method:  System.Void ClanWarRegistrationNotification::丂七丟丑丗专丝丘世()), 丒七丒丌世丘丑丂七:  0);
    }
    private void 丂七丟丑丗专丝丘世()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleClansClickedCore(三丂东专丕专业丏万:  false);
        Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().丕丗不与丟丑东不下();
    }
    public void U_Hide()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        goto typeof(ClanWarRegistrationNotification).__il2cppRuntimeField_208;
    }
    public override void HideSelf()
    {
        this.HideSelf();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万丘丁丝七丅专丏与(下上丐丆丝丟丝丒不:  "cw_rcs", 丐丅一丘丟丄丑三丏:  new System.Nullable<System.Int32>() {HasValue = false});
        if(ClanWarRegistrationNotification.丛丄业丘不丆丄三丞 == null)
        {
                return;
        }
        
        ClanWarRegistrationNotification.丛丄业丘不丆丄三丞.Invoke();
    }
    public ClanWarRegistrationNotification()
    {
    
    }

}
