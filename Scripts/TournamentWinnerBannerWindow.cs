using UnityEngine;
public class TournamentWinnerBannerWindow : BannerWindow
{
    // Fields
    private static readonly Rilisoft.丆专丐丂丆丐丕丝丒 丙丌七专丁且业且丌;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UnityEngine.GameObject _coinsIconObj;
    private UnityEngine.GameObject _gemsIconObj;
    private Rilisoft.TextGroup _RewardCoinsTextGroup;
    private Rilisoft.TextGroup _RewardGemsTextGroup;
    
    // Properties
    internal static bool 丕世一与业丅万专丑 { get; set; }
    
    // Methods
    internal static bool 丌七丘七丗下丐七丞()
    {
        null = null;
        if(TournamentWinnerBannerWindow.丙丌七专丁且业且丌 != null)
        {
                return TournamentWinnerBannerWindow.丙丌七专丁且业且丌.世三丞丅丑丌丈丈一();
        }
        
        return TournamentWinnerBannerWindow.丙丌七专丁且业且丌.世三丞丅丑丌丈丈一();
    }
    internal static void 丈业丙丈丆丈丛丆专(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentWinnerBannerWindow.丙丌七专丁且业且丌.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public override void Show()
    {
        var val_14;
        丈丞丕丘丕丗与上一 val_15;
        var val_16;
        var val_17;
        System.Action<Rilisoft.TextGroup> val_19;
        var val_20;
        System.Action<UnityEngine.GameObject> val_22;
        var val_23;
        var val_24;
        UnityEngine.GameObject val_25;
        System.Action<UnityEngine.GameObject> val_27;
        var val_28;
        System.Action<Rilisoft.TextGroup> val_30;
        var val_31;
        var val_33;
        this.Show();
        val_14 = null;
        val_14 = null;
        val_15 = BalanceController.丟上丒与且下丄专专;
        if(val_15 == null)
        {
                return;
        }
        
        val_15 = BalanceController.丟上丒与且下丄专专;
        if(val_15 == null)
        {
                val_15 = 0;
        }
        
        val_16 = null;
        val_16 = null;
        if((System.String.op_Equality(a:  val_15.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_9;
        }
        
        val_17 = null;
        val_17 = null;
        val_19 = TournamentWinnerBannerWindow.<>c.<>9__9_0;
        if(val_19 == null)
        {
                System.Action<Rilisoft.TextGroup> val_3 = null;
            val_19 = val_3;
            val_3 = new System.Action<Rilisoft.TextGroup>(object:  TournamentWinnerBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TournamentWinnerBannerWindow.<>c::下丛丒东丟上丟且万(Rilisoft.TextGroup 丙丒七丄上与丏丙丙));
            TournamentWinnerBannerWindow.<>c.<>9__9_0 = val_19;
        }
        
        Rilisoft.TextGroup val_4 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.TextGroup>(丄三丅七丆丛与与上:  this._RewardCoinsTextGroup, 七丐丅专且专七三丆:  val_3);
        val_20 = null;
        val_20 = null;
        val_22 = TournamentWinnerBannerWindow.<>c.<>9__9_1;
        if(val_22 == null)
        {
                System.Action<UnityEngine.GameObject> val_5 = null;
            val_22 = val_5;
            val_5 = new System.Action<UnityEngine.GameObject>(object:  TournamentWinnerBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TournamentWinnerBannerWindow.<>c::业丏丅丅丐丂且且丌(UnityEngine.GameObject 丄三丅七丆丛与与上));
            TournamentWinnerBannerWindow.<>c.<>9__9_1 = val_22;
        }
        
        val_23 = 1152921530844247360;
        UnityEngine.GameObject val_6 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UnityEngine.GameObject>(丄三丅七丆丛与与上:  this._coinsIconObj, 七丐丅专且专七三丆:  val_5);
        val_24 = null;
        val_25 = this._gemsIconObj;
        val_24 = null;
        val_27 = TournamentWinnerBannerWindow.<>c.<>9__9_2;
        if(val_27 != null)
        {
            goto label_38;
        }
        
        System.Action<UnityEngine.GameObject> val_7 = null;
        val_27 = val_7;
        val_7 = new System.Action<UnityEngine.GameObject>(object:  TournamentWinnerBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TournamentWinnerBannerWindow.<>c::丒丅丂专丁七专丑丄(UnityEngine.GameObject 丄三丅七丆丛与与上));
        TournamentWinnerBannerWindow.<>c.<>9__9_2 = val_27;
        goto label_38;
        label_9:
        val_28 = null;
        val_28 = null;
        val_30 = TournamentWinnerBannerWindow.<>c.<>9__9_3;
        if(val_30 == null)
        {
                System.Action<Rilisoft.TextGroup> val_8 = null;
            val_30 = val_8;
            val_8 = new System.Action<Rilisoft.TextGroup>(object:  TournamentWinnerBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TournamentWinnerBannerWindow.<>c::东丈丛七丅丛丝丂丘(Rilisoft.TextGroup 丙丒七丄上与丏丙丙));
            TournamentWinnerBannerWindow.<>c.<>9__9_3 = val_30;
        }
        
        Rilisoft.TextGroup val_9 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.TextGroup>(丄三丅七丆丛与与上:  this._RewardGemsTextGroup, 七丐丅专且专七三丆:  val_8);
        val_31 = null;
        val_31 = null;
        val_22 = TournamentWinnerBannerWindow.<>c.<>9__9_4;
        if(val_22 == null)
        {
                System.Action<UnityEngine.GameObject> val_10 = null;
            val_22 = val_10;
            val_10 = new System.Action<UnityEngine.GameObject>(object:  TournamentWinnerBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TournamentWinnerBannerWindow.<>c::丏丌丗上丞丂世丈东(UnityEngine.GameObject 丄三丅七丆丛与与上));
            TournamentWinnerBannerWindow.<>c.<>9__9_4 = val_22;
        }
        
        val_23 = 1152921530844247360;
        UnityEngine.GameObject val_11 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UnityEngine.GameObject>(丄三丅七丆丛与与上:  this._coinsIconObj, 七丐丅专且专七三丆:  val_10);
        val_33 = null;
        val_25 = this._gemsIconObj;
        val_33 = null;
        val_27 = TournamentWinnerBannerWindow.<>c.<>9__9_5;
        if(val_27 == null)
        {
                System.Action<UnityEngine.GameObject> val_12 = null;
            val_27 = val_12;
            val_12 = new System.Action<UnityEngine.GameObject>(object:  TournamentWinnerBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TournamentWinnerBannerWindow.<>c::丙丁万东丘丝丘丄丟(UnityEngine.GameObject 丄三丅七丆丛与与上));
            TournamentWinnerBannerWindow.<>c.<>9__9_5 = val_27;
        }
        
        label_38:
        UnityEngine.GameObject val_13 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UnityEngine.GameObject>(丄三丅七丆丛与与上:  val_25, 七丐丅专且专七三丆:  val_12);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void TournamentWinnerBannerWindow::HideButtonAction()), 与且专丈不万东一万:  0);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
    }
    protected override void OnDestroy()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.OnDestroy();
    }
    public void HideButtonAction()
    {
        丈丞丕丘丕丗与上一 val_9;
        string val_10;
        var val_11;
        TournamentWinnerBannerWindow.丈业丙丈丆丈丛丆专(丙业与丙丗丝不丈东:  false);
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  16);
            BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
        }
        
        val_9 = BalanceController.丟上丒与且下丄专专;
        if(val_9 != null)
        {
                val_9 = BalanceController.丟上丒与且下丄专专;
            if(val_9 == null)
        {
                val_9 = 0;
        }
        
            val_10 = val_9.东与三丌丅三丒丏业();
        }
        else
        {
                val_11 = null;
            val_11 = null;
            val_10 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        }
        
        UnityEngine.Coroutine val_8 = CoroutineRunner.Instance.StartCoroutine(routine:  BankController.世丌丄与丁丈且且丂(丏丂不专上丘丂不丅:  val_10));
    }
    public TournamentWinnerBannerWindow()
    {
    
    }
    private static TournamentWinnerBannerWindow()
    {
        TournamentWinnerBannerWindow.丙丌七专丁且业且丌 = new Rilisoft.丆专丐丂丆丐丕丝丒(丟东丟丑丕丄丂丟丙:  "TournamentWinnerBannerWindow_needShow");
    }

}
