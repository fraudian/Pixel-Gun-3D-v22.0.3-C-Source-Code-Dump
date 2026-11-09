using UnityEngine;
public class BattlePassRootUI : MonoBehaviour
{
    // Fields
    internal string 丒三丝一上丙专丗丒;
    private static BattlePassRootUI 丝业丆丁业三丈丟东;
    internal static BattlePassRootUI.丝丂丅丝丟丞丐上与 丂丑丌且丄丞丝七上;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UnityEngine.Color 世下丕东七丆丆专三;
    private bool 丁丝丌丞与丑丂三上;
    private PGCompany.BattlePass.BattlePassWellcomeWindow 不丟丄世下丟不丈丏;
    private Rilisoft.且丈丞一丞丟与上七 丐丄不丗万丌丆丆丐;
    private static BattlePassRootUI.丁丆丌且且不丟上世 <东丒专万三丗丆丘业>k__BackingField;
    private static BattlePassRootUI.丁丆丌且且不丟上世 <丞三丝丌丁东丅丝丄>k__BackingField;
    private static BattlePassRootUI.丁丆丌且且不丟上世 <七丆世丁丄丌丏丏且>k__BackingField;
    private static BattlePassRootUI.丁丆丌且且不丟上世 <丙东三丙丈与东专丘>k__BackingField;
    internal bool 丒丂业丒一丏丝丟丆;
    private PGCompany.UI.七万丁丞丄丛业一丌 丝丝丂丘丛东一丛三;
    private UnityEngine.GameObject 东丗丌丝三三丐业且;
    private static UnityEngine.Coroutine 丆不丈丕业丒丆丘丒;
    public UnityEngine.GameObject Camera;
    private UILabel _timeLeftlLabel;
    private UnityEngine.GameObject _buyPremiumBtn;
    private UnityEngine.GameObject _buyLevelBtn;
    private UILabel _boughtPassLabel;
    private UnityEngine.Transform _subWindowsPlacePoint;
    private PGCompany.BattlePass.BattlePassMainUI _mainUi;
    private PGCompany.BattlePass.BattlePassChallangesUI _challangesUi;
    internal UnityEngine.GameObject _commonUi;
    public UnityEngine.GameObject ShootButton;
    private System.Collections.Generic.List<BattlePassRootUI.TutorialObjects> _tutorialSteps;
    private PGCompany.BattlePass.BPParticles _bpCrownParticles;
    private PGCompany.BattlePass.BPParticles _bpBlockPointParticles;
    private Rilisoft.BankBannersHolder _bannersHolder;
    
    // Properties
    internal static BattlePassRootUI 丆丕丝丒不丙且丐丗 { get; set; }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 丈丁丏万丗上三丆丛 { get; set; }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 上丗万丘丂丆与丒丈 { get; set; }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 上丅丑丌丑丏丏丙东 { get; set; }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 业万且丗丞丐不丙三 { get; set; }
    internal UnityEngine.Transform 下丒丁专三三且丞不 { get; }
    internal PGCompany.BattlePass.BattlePassMainUI 丏世丑业丟世上丏丟 { get; }
    internal PGCompany.BattlePass.BPParticles 丈丂丞丝专上不丌七 { get; }
    internal PGCompany.BattlePass.BPParticles 万东丑上丟丒丞与上 { get; }
    internal Rilisoft.BankBannersHolder 且丝七丈丗丑不丒丁 { get; }
    
    // Methods
    internal static BattlePassRootUI 丑七不且上丗丁一世()
    {
        null = null;
        return (BattlePassRootUI)BattlePassRootUI.丝业丆丁业三丈丟东;
    }
    private static void 丒且丒丗丗丟下丗丝(BattlePassRootUI 丙业与丙丗丝不丈东)
    {
        null = null;
        BattlePassRootUI.丝业丆丁业三丈丟东 = 丙业与丙丗丝不丈东;
    }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 且且丒丝三业丛东丞()
    {
        null = null;
        return (丁丆丌且且不丟上世)BattlePassRootUI.<东丒专万三丗丆丘业>k__BackingField;
    }
    internal static void 东丄一丌三世丟丙丙(BattlePassRootUI.丁丆丌且且不丟上世 丙业与丙丗丝不丈东)
    {
        null = null;
        BattlePassRootUI.<东丒专万三丗丆丘业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 丕丕丞丙丑丂业丛上()
    {
        null = null;
        return (丁丆丌且且不丟上世)BattlePassRootUI.<丞三丝丌丁东丅丝丄>k__BackingField;
    }
    internal static void 丙丞丗万丐丐丒丈丙(BattlePassRootUI.丁丆丌且且不丟上世 丙业与丙丗丝不丈东)
    {
        null = null;
        BattlePassRootUI.<丞三丝丌丁东丅丝丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 万丘三丘下与与且业()
    {
        null = null;
        return (丁丆丌且且不丟上世)BattlePassRootUI.<七丆世丁丄丌丏丏且>k__BackingField;
    }
    internal static void 丒丟丛丂丆三三丙丑(BattlePassRootUI.丁丆丌且且不丟上世 丙业与丙丗丝不丈东)
    {
        null = null;
        BattlePassRootUI.<七丆世丁丄丌丏丏且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static BattlePassRootUI.丁丆丌且且不丟上世 丗万不丘且世业下丘()
    {
        null = null;
        return (丁丆丌且且不丟上世)BattlePassRootUI.<丙东三丙丈与东专丘>k__BackingField;
    }
    internal static void 丆丛丏且丌丂丝丛丌(BattlePassRootUI.丁丆丌且且不丟上世 丙业与丙丗丝不丈东)
    {
        null = null;
        BattlePassRootUI.<丙东三丙丈与东专丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void SetTutorialStep(int 丒且丆丘丞丑业丅不)
    {
        var val_3;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        List.Enumerator<T> val_1 = this._tutorialSteps.GetEnumerator();
        val_8 = 0;
        val_9 = 0;
        var val_8 = 0;
        label_17:
        if((1725928512 & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_3.丐丏七丌丕丗业且上() != null)
        {
            
        }
        else
        {
                val_10 = 28563616;
        }
        
        List.Enumerator<T> val_5 = val_4.m_stringLength.GetEnumerator();
        label_9:
        if((1725928480 & 1) == 0)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  (28563616 == 丒且丆丘丞丑业丅不) ? 1 : 0);
        goto label_9;
        label_6:
        val_8 = val_8 + 1;
        mem2[0] = 82;
        val_11 = val_9;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_8 == 1) || ((1152921536397546480 + ((0 + 1)) << 2) != 82))
        {
            goto label_14;
        }
        
        var val_9 = 0;
        val_9 = val_9 ^ (val_8 >> 31);
        val_8 = val_8 + val_9;
        goto label_17;
        label_14:
        if( == 0)
        {
            goto label_17;
        }
        
        goto label_17;
        label_2:
        val_8 = val_8 + 1;
        mem2[0] = 107;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_8 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921536397546480 + ((0 + 1)) << 2) == 107)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private void Awake()
    {
        if(this._bannersHolder != 0)
        {
                this._bannersHolder.万丙丐丛丟丞专万丏(丙业与丙丗丝不丈东:  false);
        }
        
        this.丝丝丂丘丛东一丛三 = new PGCompany.UI.七万丁丞丄丛业一丌(七万上丐一丈丏丏专:  this.transform);
        PGCompany.BattlePass.BPTutorialController.东世不丁丐丗下上丈(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Boolean>(object:  this, method:  System.Void BattlePassRootUI::下下丒丒世丝丝丗丅(int 丒且丆丘丞丑业丅不, bool 丛丅丘一丏丙且丌上)));
        PGCompany.BattlePass.BPTutorialController.世与不丗丛丙丘丝丒(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Boolean>(object:  this, method:  System.Void BattlePassRootUI::下下丒丒世丝丝丗丅(int 丒且丆丘丞丑业丅不, bool 丛丅丘一丏丙且丌上)));
    }
    private void OnDestroy()
    {
        if(this.丝丝丂丘丛东一丛三 != null)
        {
                this.丝丝丂丘丛东一丛三.Dispose();
        }
        
        PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丝丞丒万丅丑一丂丆()));
        PGCompany.BattlePass.BPTutorialController.东世不丁丐丗下上丈(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Boolean>(object:  this, method:  System.Void BattlePassRootUI::下下丒丒世丝丝丗丅(int 丒且丆丘丞丑业丅不, bool 丛丅丘一丏丙且丌上)));
        PGCompany.BattlePass.BattlePassBuyLevelWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丞丝且丄丁不丏专不()));
        PGCompany.BattlePass.BattlePassBuyPremiumWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丞丝且丄丁不丏专不()));
        PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丄一丐丂与丐且丘世(丙业与丙丗丝不丈东:  false);
        if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        if(BattlePassRootUI.丑七不且上丗丁一世() != this)
        {
                return;
        }
        
        BattlePassRootUI.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
    }
    private void 下下丒丒世丝丝丗丅(int 丒且丆丘丞丑业丅不, bool 丛丅丘一丏丙且丌上)
    {
        if(丛丅丘一丏丙且丌上 != false)
        {
                this.SetTutorialStep(丒且丆丘丞丑业丅不:  丒且丆丘丞丑业丅不);
            return;
        }
        
        this.SetTutorialStep(丒且丆丘丞丑业丅不:  0);
    }
    internal void 丝世丂专三万丏且丑()
    {
        var val_25;
        string val_26;
        var val_27;
        if(this.东丗丌丝三三丐业且 != 0)
        {
                return;
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_3 == null)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_26 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  PGCompany.BattlePass.BPWelcomeScreenUI.不不丗丂丆专丝专一, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        if(val_3.丄专世丈丄业专与业() == true)
        {
                return;
        }
        
        if(val_26 == val_3.万上丁一丞业业万东())
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_3.丕世丝七世与三丞一(), b:  "Military")) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_3.丕世丝七世与三丞一(), b:  "Invasion")) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_3.丕世丝七世与三丞一(), b:  "Christmas")) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_3.丕世丝七世与三丞一(), b:  "Magic")) != false)
        {
                if(val_3.业丈丅丂且丁与丄丂() > 2)
        {
                return;
        }
        
        }
        
        val_27 = null;
        val_27 = null;
        val_26 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  BattlePassController.丈丛丙七丂丙东与一);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_26)) == true)
        {
                return;
        }
        
        val_26 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_26);
        if(val_26 == 0)
        {
                return;
        }
        
        this.东丗丌丝三三丐业且 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_26, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        Progress.七七世万专丕丁上业.上业丑丅业不东丛业().万世丄丏业丙东丝丕(世不下丟世一丝丐丗:  val_3.万上丁一丞业业万东(), 丙业与丙丗丝不丈东:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  54);
    }
    private void 世与且业业丁专与丕()
    {
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
    }
    private void OnEnable()
    {
        丁丆丌且且不丟上世 val_26;
        if(this.丝丝丂丘丛东一丛三 != null)
        {
                this.丝丝丂丘丛东一丛三.丒上丁丄丛上丅丁且();
        }
        
        BattlePassRootUI.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        this.世下丕东七丆丆专三 = val_1;
        mem[1152921536398540364] = val_1.g;
        mem[1152921536398540368] = val_1.b;
        mem[1152921536398540372] = val_1.a;
        this.丁丝丌丞与丑丂三上 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
        CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::世与且业业丁专与丕()));
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
        {
                this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丝东丐丝东三丈世丝()), 与且专丈不万东一万:  0);
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆.万丕上丂丕丑丕东丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::且不丕丆丞七丅丗不()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.且丙丛与万丑丙上丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::且不丕丆丞七丅丗不()));
        Rilisoft.丗丄丙丁丌业丅丒丕.丒一且丅丈丅丒丆丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::且不丕丆丞七丅丗不()));
        System.Action val_15 = new System.Action(object:  this, method:  System.Void BattlePassRootUI::且不丕丆丞七丅丗不());
        Rilisoft.丗丄丙丁丌业丅丒丕.丝丕七丄丛丘业一丗(丙业与丙丗丝不丈东:  val_15);
        val_15.下丈丌丙东丆丗丛东();
        this.丝一丅丆三东丂丞七();
        PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void BattlePassRootUI::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void BattlePassRootUI::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丝一丅丆三东丂丞七()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丝一丅丆三东丂丞七()));
        if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() != false)
        {
                if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() <= 3)
        {
                val_26 = 2;
        }
        else
        {
                val_26 = 1;
        }
        
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  val_26);
        }
        
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
        {
                this.丝世丂专三万丏且丑();
        }
        
        this.ChangeState(专丂丕丗丗东世丞下:  BattlePassRootUI.丗万不丘且世业下丘());
        PGCompany.BattlePass.BPTutorialController.丝丑丄不丄丏丞丂丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丅丌不且丞业东丁专()));
    }
    private void OnDisable()
    {
        var val_19;
        BattlePassRootUI.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
        if(this.丝丝丂丘丛东一丛三 != null)
        {
                this.丝丝丂丘丛东一丛三.与丙丏丘万不东丂丙();
        }
        
        Rilisoft.丗丄丙丁丌业丅丒丕.丒一且丅丈丅丒丆丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::且不丕丆丞七丅丗不()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.万丕上丂丕丑丕东丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::且不丕丆丞七丅丗不()));
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
        this.下一且万丕一丈丄丗();
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        PGCompany.BattlePass.BattlePassChallangesUI.丟丄丐一七东不丁且(丙业与丙丗丝不丈东:  0);
        PGCompany.BattlePass.BattlePassChallangesUI.不丌丘丅世丄丌丌不 = PGCompany.BattlePass.BattlePassChallangesUI.丗丞下丒丞丒丘丌丆();
        PGCompany.BattlePass.BattlePassChallengesCommonView.CurrentTab = 0;
        PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 = 0;
        val_19 = null;
        val_19 = null;
        BattlePassRootUI.丂丑丌且丄丞丝七上 = 0;
        PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void BattlePassRootUI::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丝一丅丆三东丂丞七()));
        if((this._mainUi != 0) && (this._mainUi.gameObject != 0))
        {
                this._mainUi.Resert();
            if(this._mainUi.gameObject.activeSelf != false)
        {
                this._mainUi.Hide();
        }
        
        }
        
        if((this._challangesUi != 0) && (this._challangesUi.gameObject != 0))
        {
                if(this._challangesUi.gameObject.activeSelf != false)
        {
                this._challangesUi.Hide();
        }
        
        }
        
        PGCompany.BattlePass.BPTutorialController.不一丁丐万丏丑丆东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丅丌不且丞业东丁专()));
        this.丒丂业丒一丏丝丟丆 = false;
    }
    public void ChangeState(BattlePassRootUI.丁丆丌且且不丟上世 专丂丕丗丗东世丞下)
    {
        var val_34;
        if(专丂丕丗丗东世丞下 == 0)
        {
                BattlePassRootUI.东丄一丌三世丟丙丙(丙业与丙丗丝不丈东:  BattlePassRootUI.万丘三丘下与与且业());
        }
        
        val_34 = 1152921505138155520;
        if(BattlePassRootUI.万丘三丘下与与且业() != 0)
        {
                BattlePassRootUI.丙丞丗万丐丐丒丈丙(丙业与丙丗丝不丈东:  BattlePassRootUI.万丘三丘下与与且业());
        }
        
        BattlePassRootUI.丒丟丛丂丆三三丙丑(丙业与丙丗丝不丈东:  专丂丕丗丗东世丞下);
        BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  专丂丕丗丗东世丞下);
        if((专丂丕丗丗东世丞下 - 1) <= 3)
        {
                var val_34 = 106017080 + ((专丂丕丗丗东世丞下 - 1)) << 2;
            val_34 = val_34 + 106017080;
        }
        else
        {
                if(专丂丕丗丗东世丞下 != 0)
        {
                return;
        }
        
            if(PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
            PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世().Back();
        }
    
    }
    private void 丐丌专丆丈丂丏东上()
    {
        if(PGCompany.BattlePass.BattlePassBuyLevelWindow.丑七不且上丗丁一世() != 0)
        {
                PGCompany.BattlePass.BattlePassBuyLevelWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丞丝且丄丁不丏专不()));
            PGCompany.BattlePass.BattlePassBuyLevelWindow.丑七不且上丗丁一世().Hide();
        }
        
        if(PGCompany.BattlePass.BattlePassBuyPremiumWindow.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        PGCompany.BattlePass.BattlePassBuyPremiumWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丞丝且丄丁不丏专不()));
        PGCompany.BattlePass.BattlePassBuyPremiumWindow.丑七不且上丗丁一世().Hide();
    }
    private void 丞丝且丄丁不丏专不()
    {
        丁丆丌且且不丟上世 val_11;
        PGCompany.BattlePass.BattlePassBuyLevelWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丞丝且丄丁不丏专不()));
        PGCompany.BattlePass.BattlePassBuyPremiumWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丞丝且丄丁不丏专不()));
        if((BattlePassRootUI.丕丕丞丙丑丂业丛上() != BattlePassRootUI.丗万不丘且世业下丘()) && (BattlePassRootUI.丕丕丞丙丑丂业丛上() != 0))
        {
                val_11 = BattlePassRootUI.丕丕丞丙丑丂业丛上();
        }
        else
        {
                val_11 = 1;
        }
        
        this.ChangeState(专丂丕丗丗东世丞下:  val_11);
        if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() == false)
        {
                return;
        }
        
        if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() != 5)
        {
                if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() != 6)
        {
                return;
        }
        
        }
        
        PGCompany.BattlePass.BPTutorialController.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this.transform);
    }
    private void 与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)
    {
        if(世丁丙世丄一万丆三 == 1)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        var val_27;
        PGCompany.BattlePass.BattlePassWellcomeWindow val_28;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_2 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._boughtPassLabel, 丏业丟一东丂东丘丛:  (val_2.专丟专一丒且丘与丌() == 100) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyPremiumBtn, 丏业丟一东丂东丘丛:  (val_2.专丟专一丒且丘与丌() != 100) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyLevelBtn, 丏业丟一东丂东丘丛:  (~val_2.丐丞上丒七丞丁丙丕()) & 1);
        if(BattlePassRootUI.丗万不丘且世业下丘() == 1)
        {
                val_27 = this._mainUi;
            val_27.UpdateView();
        }
        else
        {
                if(BattlePassRootUI.丗万不丘且世业下丘() == 2)
        {
                val_27 = this._challangesUi;
            val_27.UpdateView();
        }
        
        }
        
        val_28 = this.不丟丄世下丟不丈丏;
        if(val_28 != 0)
        {
                return;
        }
        
        if(PGCompany.BattlePass.BPGetRewards.丌七丘七丗下丐七丞() != false)
        {
                PGCompany.BattlePass.BPGetRewards.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::业丑一丟丆丕不丁不()));
            PGCompany.BattlePass.BPGetRewards.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::业丑一丟丆丕不丁不()));
            PGCompany.BattlePass.BPGetRewards.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  BannerWindowController.与丅与丒丅专丙丐丗().transform);
            return;
        }
        
        if(BPChallengesController.丑七不且上丗丁一世().丕业与丅丟七七世不() != false)
        {
                if(val_2.专丟专一丒且丘与丌() == 100)
        {
                BPChallengeRewardWindow.下与丞三丅丛丄七丕(丈东丘丏与丌东东下:  BannerWindowController.与丅与丒丅专丙丐丗().transform);
            return;
        }
        
        }
        
        val_28 = 1152921505676279808;
        if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() == false)
        {
                return;
        }
        
        if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() < 2)
        {
                return;
        }
        
        PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丝丞丒万丅丑一丂丆()));
        PGCompany.BattlePass.BPTutorialController.业丙丘丈丁一丛专丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丝丞丒万丅丑一丂丆()));
        PGCompany.BattlePass.BPTutorialController.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this.transform);
    }
    private void 业丑一丟丆丕不丁不()
    {
        PGCompany.BattlePass.BPGetRewards.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::业丑一丟丆丕不丁不()));
        this.丝一丅丆三东丂丞七();
    }
    private void 丝丞丒万丅丑一丂丆()
    {
        if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() != 2)
        {
                if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() != 4)
        {
                if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() != 5)
        {
                return;
        }
        
        }
        
        }
        
        if(PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世() != 0)
        {
                if(PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世().gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        }
        
        PGCompany.BattlePass.BPTutorialController.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this.transform);
    }
    private void 专三东业丟丐丄世丆()
    {
        PGCompany.BattlePass.BattlePassWellcomeWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::专三东业丟丐丄世丆()));
        this.不丟丄世下丟不丈丏 = 0;
        this.丝一丅丆三东丂丞七();
    }
    private void 丂丐丆丞丙业丗丆下()
    {
        PGCompany.BattlePass.BattlePassHelpBanner.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassRootUI::丂丐丆丞丙业丗丆下()));
        this.丝一丅丆三东丂丞七();
    }
    private void 下丈丌丙东丆丗丛东()
    {
        string val_10 = Rilisoft.Singleton<BattlePassController>.Instance;
        if(val_10.丛东丛丕东丟丂丈丝() == null)
        {
                return;
        }
        
        val_10 = "menu_music_battle_pass_" + Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丕世丝七世与三丞一().ToLower()(Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丕世丝七世与三丞一().ToLower());
        if((MenuBackgroundMusic.丙丄丏下丕丄丘丏丄().Contains(value:  val_10)) != false)
        {
                return;
        }
        
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  val_10, 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  false, 丆与丈丏丟七丁东丛:  0);
    }
    private void 下一且万丕一丈丄丗()
    {
        string val_11 = Rilisoft.Singleton<BattlePassController>.Instance;
        if(val_11.丛东丛丕东丟丂丈丝() == null)
        {
                return;
        }
        
        val_11 = System.String.Format(format:  "menu_music_battle_pass_{0}", arg0:  Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丕世丝七世与三丞一().ToLower());
        if((MenuBackgroundMusic.丙丄丏下丕丄丘丏丄().Contains(value:  val_11)) == false)
        {
                return;
        }
        
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  MenuBackgroundMusic.丄一丙三丄专丛一丆(), 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  false, 丆与丈丏丟七丁东丛:  0);
    }
    private void 且不丕丆丞七丅丗不()
    {
        this.ChangeState(专丂丕丗丗东世丞下:  BattlePassRootUI.丗万不丘且世业下丘());
    }
    private void 丅丌不且丞业东丁专()
    {
        this.丒丂业丒一丏丝丟丆 = true;
        this.丝世丂专三万丏且丑();
    }
    private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BattlePassRootUI.丁且丅下丕丛万丟丝();
    }
    public void U_BuyPremium()
    {
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2.专丟专一丒且丘与丌() == 100)
        {
                return;
        }
        
        this.ChangeState(专丂丕丗丗东世丞下:  4);
    }
    public void U_BuyLevel()
    {
        this.ChangeState(专丂丕丗丗东世丞下:  3);
    }
    public void U_BuyPremiumOrLevel()
    {
        丁丆丌且且不丟上世 val_5;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2.专丟专一丒且丘与丌() == 0)
        {
            goto label_3;
        }
        
        if(val_2.丐丞上丒七丞丁丙丕() == false)
        {
            goto label_4;
        }
        
        return;
        label_3:
        val_5 = 4;
        goto label_5;
        label_4:
        val_5 = 3;
        label_5:
        this.ChangeState(专丂丕丗丗东世丞下:  val_5);
    }
    public void ShowBuyCurrencyWindow()
    {
        UnityEngine.GameObject val_1 = PGCompany.BattlePass.BattlePassBuyCurrencyWindow.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this._subWindowsPlacePoint);
    }
    internal static void 与丈不丟丄三七丗上(Rilisoft.CharacterHelper 丆丆东专丟丂丈万不, PGCompany.BattlePass.OfferItemDescriptionView 丒丟丕上丅丆丆丝东, bool 丏七丟丐丏丞丄不丅, UnityEngine.Transform 丝丆下丐东世上一且, System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 上业丟世三与七七三, UnityEngine.GameObject 丒丈七三丄丞丐丝丂)
    {
        var val_8;
        System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_10;
        var val_11;
        System.Func<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem> val_13;
        if(上业丟世三与七七三 == null)
        {
                return;
        }
        
        if(上业丟世三与七七三.Count == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = BattlePassRootUI.<>c.<>9__58_0;
        if(val_10 == null)
        {
                System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  BattlePassRootUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassRootUI.<>c::三丛丝七丄丟专三丅(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
            BattlePassRootUI.<>c.<>9__58_0 = val_10;
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = BattlePassRootUI.<>c.<>9__58_1;
        if(val_13 == null)
        {
                System.Func<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem> val_4 = null;
            val_13 = val_4;
            val_4 = new System.Func<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem>(object:  BattlePassRootUI.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem BattlePassRootUI.<>c::丞丆世东丑七东丗与(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
            BattlePassRootUI.<>c.<>9__58_1 = val_13;
        }
        
        BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  丆丆东专丟丂丈万不, 丒丟丕上丅丆丆丝东:  丒丟丕上丅丆丆丝东, 丏七丟丐丏丞丄不丅:  丏七丟丐丏丞丄不丅, 丝丆下丐东世上一且:  丝丆下丐东世上一且, 上业丟世三与七七三:  System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  上业丟世三与七七三, predicate:  val_2), selector:  val_4)), 丒丈七三丄丞丐丝丂:  丒丈七三丄丞丐丝丂);
    }
    internal static bool 三与丑不且丟丅一丞(Rilisoft.CharacterHelper 丞丛丈丝不丛丒丌丐, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三, bool 丏丏三七丌丈下三丁 = True, bool 丐丁三世上下丄丘丐 = True, UnityEngine.GameObject 丒丈七三丄丞丐丝丂)
    {
        var val_8;
        var val_94;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_96;
        var val_97;
        var val_98;
        string val_99;
        string val_100;
        System.Collections.Generic.Dictionary<System.String, 丟丄七万东与上丒丟> val_101;
        var val_102;
        System.String[] val_103;
        var val_104;
        var val_105;
        CharacterInterfaceV2 val_106;
        bool val_107;
        var val_108;
        var val_109;
        var val_110;
        var val_111;
        var val_112;
        string val_113;
        var val_114;
        var val_115;
        var val_116;
        CharacterInterfaceV2 val_117;
        var val_118;
        BattlePassRootUI.一三下世一丁丘丁丝 val_1 = new BattlePassRootUI.一三下世一丁丘丁丝();
        val_94 = null;
        val_94 = null;
        val_96 = BattlePassRootUI.<>c.<>9__60_0;
        if(val_96 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_2 = null;
            val_96 = val_2;
            val_2 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BattlePassRootUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassRootUI.<>c::丙丟丑丕丆丏丏业丂(Rilisoft.OfferItem 东七上世万下丗丄丛));
            BattlePassRootUI.<>c.<>9__60_0 = val_96;
        }
        
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  上业丟世三与七七三, predicate:  val_2));
        val_97 = null;
        val_97 = null;
        if(BattlePassRootUI.丆不丈丕业丒丆丘丒 != null)
        {
                val_98 = null;
            val_98 = null;
            CoroutineRunner.Instance.StopCoroutine(routine:  BattlePassRootUI.丆不丈丕业丒丆丘丒);
            val_97 = null;
        }
        
        val_97 = null;
        BattlePassRootUI.丆不丈丕业丒丆丘丒 = 0;
        .上东丞世三世且丈丌 = 0;
        List.Enumerator<T> val_6 = val_4.GetEnumerator();
        val_99 = 0;
        val_100 = 0;
        label_136:
        if((1730632560 & 1) == 0)
        {
            goto label_18;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        if(val_9.Type != 10)
        {
                if((val_9.Type != 1070) || ((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_9.Id)) == null))
        {
            goto label_26;
        }
        
        }
        
        if(0 != 0)
        {
            goto label_136;
        }
        
        三丅丁丗丗丝丂万且 val_15 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_9.Id);
        if(val_15 == null)
        {
            goto label_136;
        }
        
        goto label_136;
        label_26:
        if(val_9.Type != 60)
        {
            goto label_34;
        }
        
        if(val_100 != 0)
        {
            goto label_136;
        }
        
        string val_18 = val_9.Id;
        goto label_136;
        label_34:
        if(val_9.Type != 30)
        {
            goto label_39;
        }
        
        if(val_99 != 0)
        {
            goto label_136;
        }
        
        string val_20 = val_9.Id;
        goto label_136;
        label_39:
        if(val_9.Type != 40)
        {
            goto label_44;
        }
        
        if(0 != 0)
        {
            goto label_136;
        }
        
        string val_22 = val_9.Id;
        goto label_136;
        label_44:
        if(val_9.Type != 50)
        {
            goto label_49;
        }
        
        if(0 != 0)
        {
            goto label_136;
        }
        
        string val_24 = val_9.Id;
        goto label_136;
        label_49:
        if(val_9.Type != 1080)
        {
                if(val_9.Type != 1070)
        {
            goto label_56;
        }
        
        }
        
        int val_28 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_9.Id);
        if((val_28 & 2147483648) != 0)
        {
            goto label_60;
        }
        
        if((((val_15.三与丛丑且丐丈业丌() != 0) || (0 != 0)) || (0 != 0)) || (val_28 != 160000))
        {
            goto label_64;
        }
        
        if(0 != 0)
        {
            goto label_136;
        }
        
        goto label_136;
        label_60:
        System.Collections.Generic.Dictionary<System.String, 丟丄七万东与上丒丟> val_30 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
        val_101 = val_30;
        if(val_101 == 0)
        {
                val_101 = val_30;
        }
        
        var val_33 = (0 == 0) ? 1 : 0;
        val_33 = val_33 & (val_101.ContainsKey(key:  val_9.Id));
        if((val_33 == false) || (丏丏三七丌丈下三丁 == false))
        {
            goto label_136;
        }
        
        val_102 = null;
        val_102 = null;
        string val_35 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与).三与丛丑且丐丈业丌();
        goto label_136;
        label_56:
        if(val_9.Type != 1120)
        {
            goto label_82;
        }
        
        if((Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  val_9.Id)) == null)
        {
            goto label_136;
        }
        
        val_103 = val_39.ToWeapons;
        if((val_103 == null) || (val_39.ToWeapons.Length == 0))
        {
            goto label_136;
        }
        
        if(val_39.ToWeapons.Length == 0)
        {
                val_103 = val_103;
        }
        
        string val_40 = val_9.Id;
        goto label_136;
        label_64:
        if((((val_103[0] != 0) || (val_9.Id != 0)) || (0 != 0)) || (val_28 != 210000))
        {
            goto label_95;
        }
        
        if(0 != 0)
        {
            goto label_136;
        }
        
        if(丏丏三七丌丈下三丁 == false)
        {
            goto label_97;
        }
        
        val_104 = null;
        val_104 = null;
        goto label_103;
        label_82:
        if(val_9.Type != 80)
        {
            goto label_136;
        }
        
        .上东丞世三世且丈丌 = val_9.Id;
        goto label_136;
        label_95:
        if(((((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与).三与丛丑且丐丈业丌()) != 0) || (0 != 0)) || (0 != 0)) || (val_28 != 200000))
        {
            goto label_112;
        }
        
        if(0 != 0)
        {
            goto label_136;
        }
        
        if(丏丏三七丌丈下三丁 == false)
        {
            goto label_114;
        }
        
        val_105 = null;
        val_105 = null;
        string val_46 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与).三与丛丑且丐丈业丌();
        goto label_120;
        label_112:
        if(val_28 == 170000)
        {
            goto label_121;
        }
        
        if(val_28 == 180000)
        {
            goto label_122;
        }
        
        if((val_28 != 190000) || (val_9.Id != 0))
        {
            goto label_136;
        }
        
        string val_47 = val_9.Id;
        goto label_136;
        label_97:
        label_103:
        string val_48 = val_9.Id;
        goto label_136;
        label_114:
        label_120:
        string val_49 = val_9.Id;
        goto label_136;
        label_121:
        if(0 != 0)
        {
            goto label_136;
        }
        
        string val_50 = val_9.Id;
        goto label_136;
        label_122:
        if(0 != 0)
        {
            goto label_136;
        }
        
        string val_51 = val_9.Id;
        goto label_136;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_106 = 丞丛丈丝不丛丒丌丐.丟丑万与丒与不下丛();
        if(val_1 == null)
        {
            goto label_184;
        }
        
        .丌专丄丙丑丙且东专 = val_106;
        if(val_106 != null)
        {
            goto label_221;
        }
        
        label_222:
        label_221:
        if((val_106.丘丂丆丕丂丆丌丙丝(丏丅三丑专丌世丂丏:  8)) != false)
        {
                val_107 = 1;
        }
        else
        {
                val_106 = .丌专丄丙丑丙且东专;
            val_107 = val_106.丘丂丆丕丂丆丌丙丝(丏丅三丑专丌世丂丏:  10);
        }
        
        丞丛丈丝不丛丒丌丐.SetWear(丈丐丕业下丟业丛一:  val_100, 丟世丟丐且丐丟七上:  val_99, 上丈专丌万丕丙万丘:  0, 且与丛专丗丞丑丑丝:  0, 专丆东丌上七丄丄下:  false, 下丈丝丁丟下世丐丒:  true, 丈七与世丏丕业世丙:  false);
        var val_55 = val_99 | val_100;
        val_55 = 0 | val_55;
        val_55 = 0 | val_55;
        var val_56 = (val_55 != 0) ? 1 : 0;
        if(0 == 0)
        {
            goto label_193;
        }
        
        if((System.String.op_Inequality(a:  0, b:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  3))) != false)
        {
                .丌专丄丙丑丙且东专.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  0);
        }
        
        label_224:
        if(.丌专丄丙丑丙且东专 == null)
        {
            goto label_198;
        }
        
        if(0 == 0)
        {
            goto label_199;
        }
        
        label_225:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  10))) != true)
        {
                .丌专丄丙丑丙且东专.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  0);
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  11))) != true)
        {
                .丌专丄丙丑丙且东专.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  0);
        }
        
        if((System.String.op_Inequality(a:  0, b:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  8))) != false)
        {
                .丌专丄丙丑丙且东专.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  0);
            .丌专丄丙丑丙且东专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  0);
        }
        
        if(val_1 != null)
        {
            goto label_220;
        }
        
        goto label_220;
        label_184:
        mem[16] = val_106;
        if(mem[16] != 0)
        {
            goto label_221;
        }
        
        goto label_222;
        label_193:
        .丌专丄丙丑丙且东专.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  0);
        if(val_1 != null)
        {
            goto label_224;
        }
        
        goto label_224;
        label_198:
        if(0 != 0)
        {
            goto label_225;
        }
        
        label_199:
        .丌专丄丙丑丙且东专.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  0);
        if(((0 == 0) && (0 == 0)) && (0 == 0))
        {
                val_108 = null;
            val_108 = null;
            .丌专丄丙丑丙且东专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
            .丌专丄丙丑丙且东专.业不丛不丞七丕东世(七不丐下丟专业万丅:  0);
        }
        
        label_220:
        if(0 == 0)
        {
            goto label_237;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  8))) != true)
        {
                .丌专丄丙丑丙且东专.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  0);
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  11))) != true)
        {
                .丌专丄丙丑丙且东专.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  0);
        }
        
        if((System.String.op_Inequality(a:  0, b:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  10))) != false)
        {
                .丌专丄丙丑丙且东专.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  0);
            val_109 = null;
            val_109 = null;
            .丌专丄丙丑丙且东专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        }
        
        if(val_1 != null)
        {
            goto label_260;
        }
        
        goto label_260;
        label_237:
        .丌专丄丙丑丙且东专.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  0);
        if(((0 == 0) && (0 == 0)) && (0 == 0))
        {
                val_110 = null;
            val_110 = null;
            .丌专丄丙丑丙且东专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
            .丌专丄丙丑丙且东专.业不丛不丞七丕东世(七不丐下丟专业万丅:  0);
        }
        
        label_260:
        if(0 == 0)
        {
            goto label_272;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  10))) != true)
        {
                .丌专丄丙丑丙且东专.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  0);
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  8))) != true)
        {
                .丌专丄丙丑丙且东专.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  0);
        }
        
        if((System.String.op_Inequality(a:  0, b:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  11))) != false)
        {
                .丌专丄丙丑丙且东专.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  0);
            val_111 = null;
            val_111 = null;
            .丌专丄丙丑丙且东专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        }
        
        val_112 = 1;
        if(val_1 != null)
        {
            goto label_311;
        }
        
        label_312:
        label_311:
        val_113 = 0;
        if(val_113 == 0)
        {
            goto label_296;
        }
        
        if((System.String.op_Inequality(a:  val_113, b:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  12))) == false)
        {
            goto label_297;
        }
        
        .丌专丄丙丑丙且东专.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  val_113);
        val_112 = 1;
        if(((0 != 0) || (0 != 0)) || (0 != 0))
        {
            goto label_315;
        }
        
        val_114 = null;
        val_114 = null;
        .丌专丄丙丑丙且东专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        .丌专丄丙丑丙且东专.业不丛不丞七丕东世(七不丐下丟专业万丅:  0);
        label_297:
        val_112 = 1;
        if(val_1 != null)
        {
            goto label_310;
        }
        
        goto label_310;
        label_272:
        .丌专丄丙丑丙且东专.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  0);
        if(val_1 != null)
        {
            goto label_311;
        }
        
        goto label_312;
        label_296:
        .丌专丄丙丑丙且东专.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  0);
        if(((0 == 0) && (0 == 0)) && (0 == 0))
        {
                val_115 = null;
            val_115 = null;
            val_113 = 与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与;
            .丌专丄丙丑丙且东专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  val_113);
            .丌专丄丙丑丙且东专.业不丛不丞七丕东世(七不丐下丟专业万丅:  0);
        }
        
        label_315:
        label_310:
        if((BattlePassRootUI.一三下世一丁丘丁丝)[1152921536402307024].上东丞世三世且丈丌 == null)
        {
            goto label_323;
        }
        
        if(val_107 == false)
        {
            goto label_324;
        }
        
        val_116 = null;
        val_116 = null;
        BattlePassRootUI.丆不丈丕业丒丆丘丒 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  0.5f, 丌专业且丛丏丞丝且:  new System.Action(object:  val_1, method:  System.Void BattlePassRootUI.一三下世一丁丘丁丝::业丘三业丅丙上世丞()));
        goto label_329;
        label_323:
        .丌专丄丙丑丙且东专.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  0);
        goto label_331;
        label_324:
        .丌专丄丙丑丙且东专.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  (BattlePassRootUI.一三下世一丁丘丁丝)[1152921536402307024].上东丞世三世且丈丌);
        label_329:
        val_112 = 1;
        label_331:
        if((((0 == 0) && (0 == 0)) && (0 == 0)) && (0 != 0))
        {
                val_112 = 1;
            if((System.String.op_Inequality(a:  0, b:  .丌专丄丙丑丙且东专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  1))) != false)
        {
                .丌专丄丙丑丙且东专.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  0);
            val_112 = 1;
        }
        
        }
        
        val_117 = .丌专丄丙丑丙且东专;
        val_117.不丕与丛三丛业丙不(东丐丛丁一东丑丒专:  "Idle");
        PGCompany.BattlePass.BPCharacterPositionModyfier val_83 = 丞丛丈丝不丛丒丌丐.GetComponent<PGCompany.BattlePass.BPCharacterPositionModyfier>();
        if(val_83 == 0)
        {
            goto label_357;
        }
        
        if(val_4.Count < 1)
        {
            goto label_346;
        }
        
        val_99 = 1152921524416091376;
        val_117 = 0;
        goto label_347;
        label_356:
        Rilisoft.OfferItem val_86 = val_4.Item[0];
        if(val_86 == null)
        {
            goto label_349;
        }
        
        int val_88 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_86.Id);
        val_113 = 0;
        if((val_83.SetPosition(业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false}, 丞一丁业丄一一业且:  val_86.Id)) == true)
        {
            goto label_357;
        }
        
        label_349:
        val_117 = 1;
        label_347:
        if(val_117 < val_4.Count)
        {
            goto label_356;
        }
        
        goto label_357;
        label_346:
        bool val_92 = val_83.SetPosition(业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false}, 丞一丁业丄一一业且:  0);
        label_357:
        if(0 == 0)
        {
            goto label_359;
        }
        
        val_118 = 0;
        if(((0 != 0) || (0 != 0)) || ((BattlePassRootUI.一三下世一丁丘丁丝)[1152921536402307024].上东丞世三世且丈丌 != null))
        {
            goto label_364;
        }
        
        var val_93 = (0 == 0) ? 1 : 0;
        goto label_364;
        label_359:
        val_118 = 0;
        label_364:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丒丈七三丄丞丐丝丂, 丏业丟一东丂东丘丛:  false);
        return (bool)val_112;
    }
    internal static void 丗业丐丄丌丁丁丛丆(Rilisoft.CharacterHelper 丞丛丈丝不丛丒丌丐)
    {
        Rilisoft.CharacterHelper val_18 = 丞丛丈丝不丛丒丌丐;
        if(val_18 == 0)
        {
                return;
        }
        
        val_18.丟丑万与丒与不下丛().丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  System.String.alignConst);
        val_18.丟丑万与丒与不下丛().丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  Rilisoft.万丂丕丁三一丒三丞.丗丑专丞专丙丛丟一());
        val_18.丟丑万与丒与不下丛().不丕与丛三丛业丙不(东丐丛丁一东丑丒专:  "Idle");
        val_18 = val_18.GetComponent<PGCompany.BattlePass.BPCharacterPositionModyfier>();
        if(val_18 == 0)
        {
                return;
        }
        
        bool val_17 = val_18.SetPosition(业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false}, 丞一丁业丄一一业且:  0);
    }
    internal static void 与丈不丟丄三七丗上(Rilisoft.CharacterHelper 丆丆东专丟丂丈万不, PGCompany.BattlePass.OfferItemDescriptionView 丒丟丕上丅丆丆丝东, bool 丏七丟丐丏丞丄不丅, UnityEngine.Transform 丝丆下丐东世上一且, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三, UnityEngine.GameObject 丒丈七三丄丞丐丝丂)
    {
        System.Collections.Generic.IEnumerable<TSource> val_22;
        UnityEngine.Object val_23;
        UnityEngine.Object val_24;
        var val_25;
        val_22 = 上业丟世三与七七三;
        val_23 = 丝丆下丐东世上一且;
        val_24 = 丆丆东专丟丂丈万不;
        if(val_22 == null)
        {
                return;
        }
        
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
        {
                return;
        }
        
        Rilisoft.OfferItem val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_22);
        if(val_24 == 0)
        {
            goto label_6;
        }
        
        if((BattlePassRootUI.三与丑不且丟丅一丞(丞丛丈丝不丛丒丌丐:  val_24, 上业丟世三与七七三:  val_22, 丏丏三七丌丈下三丁:  true, 丐丁三世上下丄丘丐:  false, 丒丈七三丄丞丐丝丂:  丒丈七三丄丞丐丝丂)) == true)
        {
            goto label_40;
        }
        
        val_22 = Rilisoft.万丂丕丁三一丒三丞.丗丑专丞专丙丛丟一();
        val_24.丟丑万与丒与不下丛().丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_22);
        val_24.SetWear(丈丐丕业下丟业丛一:  0, 丟世丟丐且丐丟七上:  0, 上丈专丌万丕丙万丘:  0, 且与丛专丗丞丑丑丝:  0, 专丆东丌上七丄丄下:  false, 下丈丝丁丟下世丐丒:  true, 丈七与世丏丕业世丙:  false);
        if((val_3 == null) || (丏七丟丐丏丞丄不丅 == false))
        {
            goto label_40;
        }
        
        if((val_23 != 0) || (BattlePassRootUI.丑七不且上丗丁一世() == 0))
        {
            goto label_33;
        }
        
        val_25 = null;
        goto label_23;
        label_6:
        if((val_3 == null) || (丏七丟丐丏丞丄不丅 == false))
        {
            goto label_40;
        }
        
        if(val_23 != 0)
        {
            goto label_33;
        }
        
        val_24 = 1152921505138155520;
        if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
        {
            goto label_33;
        }
        
        val_25 = null;
        label_23:
        val_23 = BattlePassRootUI.丑七不且上丗丁一世().gameObject.transform;
        label_33:
        if(val_23 != 0)
        {
                val_24 = val_3.Count;
            Rilisoft.ItemViewer val_20 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewBattlePass", 丆丏七丟不丒与七专:  val_23, 丕丁下丌不万丅丞丛:  val_3.Id, 丅三丟世下丞丝丙万:  val_24, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        }
        
        label_40:
        if(val_3 == null)
        {
                return;
        }
        
        if(丒丟丕上丅丆丆丝东 == 0)
        {
                return;
        }
        
        丒丟丕上丅丆丆丝东.Setup(与且专丈不万东一万:  val_3);
    }
    private void 丝东丐丝东三丈世丝()
    {
        if(PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世() != 0)
        {
                if(PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世().gameObject.activeSelf != false)
        {
                PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世().Hide();
            return;
        }
        
        }
        
        if(PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世().Back();
    }
    public void GoBattleRequest(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丟专三丙丒丄丂下与)
    {
        var val_6;
        var val_7;
        .丟专三丙丒丄丂下与 = 丟专三丙丒丄丂下与;
        val_6 = null;
        val_6 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_7 = static_value_081DACA8;
        val_7 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return;
        }
        
        System.Action val_4 = new System.Action(object:  new BattlePassRootUI.丂丒丝上丐丟丄下世(), method:  System.Void BattlePassRootUI.丂丒丝上丐丟丄下世::丈三业下专丏专丝下());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_4)) != false)
        {
                return;
        }
        
        val_4.Invoke();
    }
    public void ShowHelpBanner()
    {
        PGCompany.BattlePass.BattlePassHelpBanner.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this._subWindowsPlacePoint);
    }
    public void ResetRememberedParametersState()
    {
        if(this._mainUi == 0)
        {
                return;
        }
        
        this._mainUi.Resert();
    }
    internal UnityEngine.Transform 七丒丈世丟三与丂与()
    {
        return (UnityEngine.Transform)this._subWindowsPlacePoint;
    }
    internal PGCompany.BattlePass.BattlePassMainUI 丂上三丆东七且世一()
    {
        return (PGCompany.BattlePass.BattlePassMainUI)this._mainUi;
    }
    internal PGCompany.BattlePass.BPParticles 丈丁丄丈丏下丁丞丅()
    {
        return (PGCompany.BattlePass.BPParticles)this._bpCrownParticles;
    }
    internal PGCompany.BattlePass.BPParticles 丈丝丁丕一丐丛丄丄()
    {
        return (PGCompany.BattlePass.BPParticles)this._bpBlockPointParticles;
    }
    internal Rilisoft.BankBannersHolder 三东丒世专丞上不丟()
    {
        return (Rilisoft.BankBannersHolder)this._bannersHolder;
    }
    public BattlePassRootUI()
    {
        this.丐丄不丗万丌丆丆丐 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "BattlePassBannerWindow-_helpBannerViewed");
    }
    private static BattlePassRootUI()
    {
        BattlePassRootUI.丂丑丌且丄丞丝七上 = 1;
    }

}
