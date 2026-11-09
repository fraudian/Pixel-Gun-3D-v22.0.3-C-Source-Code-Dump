using UnityEngine;
public class InGameGUIPart_FortAttack : InGameGUIPartContainer
{
    // Fields
    internal SiegeContainerGUI containerUI;
    public UILabel tankHealthLabel;
    public UISprite tankRepairProgress;
    public UnityEngine.Color defaultTankRepairColor;
    public FortKilledByUI killedByUI;
    public static InGameGUIPart_FortAttack instance;
    private ProgressBarUI _progressBar;
    private UnityEngine.GameObject _injuryPanel;
    private GameStageEvent _fortDefenceMainLabel;
    private Rilisoft.ButtonHandler _respawnNowButton;
    private float 丄与与业丛丝且丟丆;
    private float grayBlinkDelay;
    private float colorBlinkDelay;
    private float 一丑丗且丁丟丕丛丑;
    private float 专丛七丂丐世丕丌丄;
    private bool 不丁丄业不七丌丗业;
    
    // Properties
    internal ProgressBarUI 且丟专万不世丆下丄 { get; }
    internal UnityEngine.GameObject 丏丐丂业与与丘一丌 { get; }
    internal GameStageEvent 丝丅丕丌丒丞丙不业 { get; }
    internal Rilisoft.ButtonHandler 丆与业东丄上丁世丏 { get; }
    
    // Methods
    internal ProgressBarUI 丐七丆丐丏丁东丅专()
    {
        return (ProgressBarUI)this._progressBar;
    }
    internal UnityEngine.GameObject 丄且丈丘丄丆丌丗丏()
    {
        return (UnityEngine.GameObject)this._injuryPanel;
    }
    internal GameStageEvent 且丕万丑下业丙丂丗()
    {
        return (GameStageEvent)this._fortDefenceMainLabel;
    }
    internal Rilisoft.ButtonHandler 丛三且三专丞上丂丒()
    {
        return (Rilisoft.ButtonHandler)this._respawnNowButton;
    }
    private void Awake()
    {
        InGameGUIPart_FortAttack.instance = this;
        InGameGUI.丙丞专丌丁丞与不丐.丕下丌七万丝丅三丘 = this;
        this._injuryPanel.SetActive(value:  false);
        this._respawnNowButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void InGameGUIPart_FortAttack::丘与丘丙上丄丞三丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        UnityEngine.Color val_2 = this.tankRepairProgress.color;
        this.defaultTankRepairColor = val_2;
        mem[1152921538087339164] = val_2.g;
        mem[1152921538087339168] = val_2.b;
        mem[1152921538087339172] = val_2.a;
    }
    private void Update()
    {
        if(TankController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        this.专丙一丏世下丘丛下();
    }
    private void 专丙一丏世下丘丛下()
    {
        UILabel val_11;
        TankController val_12;
        float val_13;
        float val_14;
        val_11 = this;
        UnityEngine.GameObject val_1 = this.tankRepairProgress.gameObject;
        if(val_1 == null)
        {
            goto label_4;
        }
        
        val_1.SetActive(value:  true);
        if(TankController.丄丘七三上丕世丞业.丄丁丝丛丒专且丝丛 <= 0f)
        {
            goto label_11;
        }
        
        val_12 = TankController.丄丘七三上丕世丞业;
        this.tankRepairProgress.fillAmount = TankController.丄丘七三上丕世丞业.丄丁丝丛丒专且丝丛;
        UnityEngine.Color val_2 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_repair");
        val_13 = val_2.b;
        this.tankRepairProgress.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_13, a = val_2.a};
        goto label_11;
        label_4:
        val_1.SetActive(value:  false);
        label_11:
        val_14 = this.丄与与业丛丝且丟丆;
        float val_4 = typeof(TankDamageable).__il2cppRuntimeField_28 / maxHealth;
        float val_11 = 100f;
        val_11 = val_4 * val_11;
        val_12 = System.String.Format(format:  "{0}%", arg0:  UnityEngine.Mathf.RoundToInt(f:  val_11));
        this.tankHealthLabel.text = val_12;
        this.丄与与业丛丝且丟丆 = typeof(TankDamageable).__il2cppRuntimeField_28;
        UnityEngine.Color val_7 = UnityEngine.Color.white;
        UnityEngine.Color val_10 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  (val_4 > 0.15f) ? ((val_4 > 0.5f) ? "FortAttack_green" : "FortAttack_damaged_50") : "FortAttack_damaged_15");
        val_11 = this.tankHealthLabel;
        val_14 = val_10.r;
        val_13 = val_10.b;
        val_11.color = new UnityEngine.Color() {r = val_14, g = val_10.g, b = val_13, a = val_10.a};
    }
    private void 丘与丘丙上丄丞三丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        Player_move_c val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_6 = null;
        val_6 = null;
        业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  丆丛不丄丂下且不丏(), 丗东丏与上丆丌不且:  0, 与丘丂下丘丁丅与东:  0, 丞丂丂丁丝丄万一丞:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丝三丛且丘不丌丙下:  "", 丞丗且下世丐业丌丙:  0);
    }
    public void TankDestroyedBlink(UnityEngine.Color 丄下丐丛与世丛丄丂)
    {
        this.tankRepairProgress.color = new UnityEngine.Color() {r = 丄下丐丛与世丛丄丂.r, g = 丄下丐丛与世丛丄丂.g, b = 丄下丐丛与世丛丄丂.b, a = 丄下丐丛与世丛丄丂.a};
        this.tankRepairProgress.fillAmount = 1f;
    }
    public InGameGUIPart_FortAttack()
    {
        this.丄与与业丛丝且丟丆 = ;
        this.grayBlinkDelay = ;
        this.colorBlinkDelay = 0.6f;
        this.一丑丗且丁丟丕丛丑 = 0.5f;
    }

}
