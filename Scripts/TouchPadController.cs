using UnityEngine;
public class TouchPadController : MonoBehaviour
{
    // Fields
    internal const string 丆业丛一丁丛与丒丄 = "grenade_btn";
    private const string 丐七七丈丆一三万专 = "grenade_btn_n";
    internal const string 专不丙下丑丈丑万丌 = "grenade_like_btn";
    private const string 上与上丛丞丛三丞不 = "grenade_like_btn_n";
    internal static int 三丆丁丞与丘丄七丞;
    internal static float 丑丅丂丒且丅专丑丟;
    internal static bool 七丄丟丐丅丆丞丝与;
    internal static bool 业丌丝丝不专丙丄丁;
    private float 丛七丁东丁丆东丑一;
    private UnityEngine.Vector2 丈七万业且丘丅丟专;
    private bool 世丆丛丙不世丄丂丙;
    public bool _isFirstFrame;
    private bool 丟丈丝下世上世业万;
    private int 七丆三一丛万丁丕万;
    private 东丁世丕万丘丛丙上 丗与丛与丕不丕上下;
    private 东丁世丕万丘丛丙上 丏丈万丄万丛丐丞且;
    private 东丁世丕万丘丛丙上 丕丁上且丙丞丌且丕;
    private 东丁世丕万丘丛丙上 丄丘丌丛丛上丄丌一;
    private System.Collections.Generic.List<GadgetCategory> 且丌不业下丌且东专;
    public UnityEngine.GameObject cantUseGadget;
    public CarTouchButton carTouch;
    public ChooseGadgetPanel chooseGadgetPanel;
    private UnityEngine.Vector2 丏业业业丈丘一丘丒;
    public CrouchTouchButton crouchTouch;
    public GadgetTouchButton dungeonAbilityButton;
    private float 丞世丌东且丁下丅上;
    private float 上且专下丈下丕七丄;
    private float 世丞与丙丅丂上下丒;
    private float 丘下丂丕七下丝丐丑;
    public VehiclePedalTouchButton downPedalVehicle;
    public FireTouchButton fireTouch;
    private bool 上一丈东三丒万业东;
    private int 上业七丑丏丈丄丐丗;
    private int 业丗七丕万万不丈丗;
    private float 丛丕丑三丒业万丙丈;
    public bool gadgetPanelVisible;
    private UnityEngine.Rect 丘丛丌东不丆下丂上;
    public GadgetTouchButton[] gadgetsTouch;
    private int 丏丄东上世丁且丕与;
    public GrenadeButton grenadeButton;
    private bool 丈丁丒丒丛不七不且;
    private bool 东一三上专丙七丄专;
    private bool 丌七丘七万丅丘丟丌;
    public bool grenadePressed;
    private UnityEngine.Rect 丆丏丒丝丁丕丟丘丟;
    private UnityEngine.Rect 不丐丌丕东丕丟业丕;
    private UnityEngine.Rect 业丗丗世世丑且丒丑;
    public bool hasAmmo;
    private float 一丘丆专丌业业丅业;
    private bool 丂下与丛东专丄专下;
    private bool 专一专丙丒丂不一丑;
    private bool 丝世上丞丁与丒下丄;
    private bool 丒与世丞丕丗一丆丟;
    public bool isShootingPressure;
    public UnityEngine.GameObject jetPackIcon;
    public UnityEngine.GameObject jumpIcon;
    public JumpTouchButton jumpTouch;
    private UnityEngine.Vector2 丛一丒丝丒丕世下下;
    private float 丗丕万丁丙丗丐与不;
    private bool 丝世丝且一丟丄丆业;
    private float 丅世七丄丐不丈下东;
    private float 丘丞丐丘三丕与丙丁;
    private float 丄且丙丛丐丈丏丟丗;
    private float 丝业世丐与下东业丅;
    private float 下丛丛丏丞丁丂丕丗;
    private float 丗丟丐七丁丒业丄丕;
    private float 丄丛丞上一万丒丆东;
    private float 丝七丂下丌与东丌与;
    private float 专万丘丒丆丗丈丅业;
    private float 且丙世丛丕丐丛丝一;
    private UnityEngine.Rect 丄世丙丞七丒丅丑丒;
    private int 丅七下业丙上丘上丝;
    private int 不丑丞世且不丂丐丘;
    private UnityEngine.Vector2 与世丞丕世丄七丙丈;
    private UnityEngine.Vector2[] 丂且丛与丆丝东丂专;
    private UnityEngine.Vector2 一丏丞上一丏丌丕丗;
    private float 业一专三一与丐三丄;
    private bool 丙业与丂丈丅三七丂;
    public ReloadTouchButton reloadTouch;
    private UISprite 一一一丘丄下丏上丒;
    private int 丟丅丈一丕丗上丐丙;
    public UnityEngine.GameObject selectedGO;
    private float 丁丝丆丟丏三丅丁丁;
    private float 且三丂丘不不丘丅丂;
    private float 丟丁丅业专丈专丒丙;
    private System.Collections.Generic.List<TouchButton> touchButtons;
    public VehiclePedalTouchButton upPedalVehicle;
    public ZoomTouchButton zoomTouch;
    public UnityEngine.BoxCollider touchCollider;
    private System.Collections.Generic.List<TouchButton> listLeftButtonsPressed;
    private bool 与与上丘丌丒丕一下;
    private UnityEngine.Transform _uiRoot;
    private UIPanel _uiPanel;
    private float 丑丗丘与丈不七东丛;
    private ModulesSetGadgetsStorage.ModuleGadgetRecord 丕万丄丙世上与世丞;
    
    // Properties
    public bool 一丕不丆专七丒一丌 { get; }
    public float 丐不丏下丅丞东且上 { get; }
    public bool 业下专丗丛丏丆丟一 { get; }
    public bool 丗丑丆丟丟丞丛世丞 { get; }
    internal bool 上世丒三丌下丟丝丂 { get; }
    public 东丁世丕万丘丛丙上 业丅丗丌丅三丗丑丙 { get; set; }
    internal UnityEngine.Vector2 丁丕丙专丌丄丄上丂 { get; }
    
    // Methods
    public bool get_isAdaptiveSpeed()
    {
        return false;
    }
    public float get_deltaPosForStay()
    {
        return (float)this.丛七丁东丁丆东丑一;
    }
    public bool get_GadgetPanelPressed()
    {
        return (bool)this.丝世上丞丁与丒下丄;
    }
    public bool get_HasTouchFinger()
    {
        return (bool)(this.丅七下业丙上丘上丝 != 1) ? 1 : 0;
    }
    internal bool 上三丌丞丅丐丅丐丘()
    {
        var val_3;
        if(与丂丏丛丞丞丒丟丄.业七丑一丁丅不丌丟() != false)
        {
                var val_2 = (this.与与上丘丌丒丕一下 == true) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public 东丁世丕万丘丛丙上 get_touchControlScheme()
    {
        return (东丁世丕万丘丛丙上)this.丗与丛与丕不丕上下;
    }
    public void set_touchControlScheme(东丁世丕万丘丛丙上 丙业与丙丗丝不丈东)
    {
        this.丗与丛与丕不丕上下 = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == null)
        {
            
        }
    
    }
    public void MakeInactive()
    {
        int val_1 = this.touchButtons.Count;
        if(val_1 != 0)
        {
                object val_5 = 0;
            do
        {
            if(this.touchButtons.Item[0] == 0)
        {
                public System.Int32 System.Collections.Generic.List<TouchButton>::get_Count() = 0;
            UnityEngine.Debug.LogWarning(message:  "[TouchPadController] MakeInactive() => touchButton: null, i: "("[TouchPadController] MakeInactive() => touchButton: null, i: ") + val_5);
        }
        
            val_5 = val_5 + 1;
        }
        while(val_1 != val_5);
        
        }
        
        this.isShootingPressure = false;
        this.丟丈丝下世上世业万 = false;
    }
    public void MakeActive()
    {
        this.丟丈丝下世上世业万 = true;
    }
    private void 丕丌世丘丗专丞且丐(bool 丁丐不且七丂业丗丆)
    {
        UnityEngine.Object val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_14 = 丁丐不且七丂业丗丆;
        if(val_14 == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = 1152921504848912384;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_17 = null;
            val_17 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  4);
        }
        
        val_18 = 1152921505286238208;
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_20 = null;
            val_20 = null;
            val_21 = null;
            val_21 = null;
            val_22 = null;
            val_22 = null;
            val_16 = ???;
            val_18 = ???;
        }
        else
        {
                val_23 = mem[val_18];
            val_23 = val_18;
            if((((val_23 + 295) & 2) != 0) && ((val_23 + 216) == 0))
        {
                val_23 = mem[val_18];
            val_23 = val_18;
        }
        
            val_14 = mem[val_23 + 184 + 544];
            val_14 = val_23 + 184 + 544;
            if(val_14 == 0)
        {
                return;
        }
        
            val_24 = mem[val_18];
            val_24 = val_18;
            if((((val_24 + 295) & 2) != 0) && ((val_24 + 216) == 0))
        {
                val_24 = mem[val_18];
            val_24 = val_18;
        }
        
            val_14 = val_24 + 184 + 544.丞丛丏丐丘与丆七丗();
            if(val_14 == 0)
        {
                return;
        }
        
            val_25 = mem[val_18];
            val_25 = val_18;
            if((((val_25 + 295) & 2) != 0) && ((val_25 + 216) == 0))
        {
                val_25 = mem[val_18];
            val_25 = val_18;
        }
        
            val_14 = val_25 + 184 + 544.丞丛丏丐丘与丆七丗();
            if(val_14.世丆丙七丈与丝丁丐() == false)
        {
                return;
        }
        
            val_26 = mem[val_18];
            val_26 = val_18;
            if((((val_26 + 295) & 2) != 0) && ((val_26 + 216) == 0))
        {
                val_26 = mem[val_18];
            val_26 = val_18;
        }
        
            val_26 + 184 + 544 + 72.专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
        }
    
    }
    private void 与丂丈丐丙丞丕丙专(bool 丁丐不且七丂业丗丆)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = 丁丐不且七丂业丗丆;
        if(val_5 == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_7 = null;
            val_7 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  3);
        }
        
        val_5 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_5.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                if(TrainingController.下且丌丑丟丒丒丗丞() == false)
        {
                return;
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        下不业且一丛丝丒丞();
    }
    public void UpdateButtonsPosition()
    {
        float val_41;
        float val_42;
        float val_43;
        GadgetTouchButton val_44;
        var val_45;
        bool val_46;
        bool val_47;
        bool val_48;
        this.万且丞丕丗丟丘丟丟();
        this.zoomTouch.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  0);
        this.reloadTouch.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  1);
        this.jumpTouch.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  2);
        this.fireTouch.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  3);
        this.carTouch.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  11);
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_13;
        }
        
        }
        
        label_134:
        this.gadgetsTouch[0].上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  3);
        label_137:
        this.crouchTouch.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  5);
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_41 = V1.16B;
            this.dungeonAbilityButton.transform.localPosition = new UnityEngine.Vector3() {x = V0.16B, y = val_41, z = V2.16B};
            this.dungeonAbilityButton.SetButtonSize(丟丒且一专丟丙下一:  下丂世丂不丛专一一.丏丛丌世专丒丆不世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()));
            val_42 = V0.16B;
            val_43 = val_42;
            this.dungeonAbilityButton.丝丆且下丁三不丘世(下丌丟丏丏丘专丒专:  val_43);
        }
        
        bool val_7 = GameConnect.丙丌丒丈东七丒上丌();
        GadgetTouchButton val_42 = this.gadgetsTouch[1];
        if(val_42 == null)
        {
            goto label_30;
        }
        
        if(val_7 == false)
        {
            goto label_31;
        }
        
        label_36:
        val_42.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  1);
        val_44 = this.gadgetsTouch[2];
        val_45 = 5;
        goto label_35;
        label_30:
        if(val_7 == true)
        {
            goto label_36;
        }
        
        label_31:
        val_42.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  9);
        val_44 = this.gadgetsTouch[2];
        val_45 = 10;
        label_35:
        val_44.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  10);
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                UnityEngine.Vector3 val_10 = this.jumpTouch.transform.position;
            val_46 = mem[null + 472 + 8];
            val_46 = .丕丞且与东不万丟丁;
            val_46 = 0;
            UnityEngine.Vector3 val_13 = this.jumpTouch.transform.localPosition;
            UnityEngine.Vector3 val_15 = this.jumpTouch.transform.localPosition;
            UnityEngine.Vector3 val_18 = this.jumpTouch.transform.localPosition;
            float val_43 = (float)height;
            float val_44 = 1.5f;
            val_43 = val_43 / val_44;
            val_44 = val_15.y + val_43;
            val_43 = 0f;
            val_41 = 0f;
            this.jumpTouch.transform.localPosition = new UnityEngine.Vector3() {x = val_43, y = val_41, z = 0f};
            UnityEngine.Vector3 val_20 = this.fireTouch.transform.position;
            val_47 = mem[null + 472 + 8];
            val_47 = .丕丞且与东不万丟丁;
            val_47 = 0;
            UnityEngine.Vector3 val_23 = this.fireTouch.transform.localPosition;
            UnityEngine.Vector3 val_25 = this.fireTouch.transform.localPosition;
            UnityEngine.Vector3 val_28 = this.fireTouch.transform.localPosition;
            float val_45 = (float)height;
            float val_46 = 1.5f;
            val_45 = val_45 / val_46;
            val_46 = val_25.y + val_45;
            val_43 = 0f;
            val_41 = 0f;
            this.fireTouch.transform.localPosition = new UnityEngine.Vector3() {x = val_43, y = val_41, z = 0f};
            UnityEngine.Vector3 val_30 = this.gadgetsTouch[0].transform.position;
            val_42 = val_30.x;
            val_48 = mem[null + 472 + 8];
            val_48 = .丕丞且与东不万丟丁;
            val_48 = 0;
            UnityEngine.Vector3 val_33 = this.gadgetsTouch[0].transform.localPosition;
            val_42 = val_33.x;
            UnityEngine.Vector3 val_35 = this.gadgetsTouch[0].transform.localPosition;
            UnityEngine.Vector3 val_38 = this.gadgetsTouch[0].transform.localPosition;
            float val_52 = (float)height;
            float val_53 = 1.5f;
            val_52 = val_52 / val_53;
            val_53 = val_35.y + val_52;
            this.gadgetsTouch[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        this.upPedalVehicle.SetButtonSize(丟丒且一专丟丙下一:  150);
        this.downPedalVehicle.SetButtonSize(丟丒且一专丟丙下一:  150);
        if(InGameGUI.丙丞专丌丁丞与不丐.丘丏丛丂丅丂世上丒 != 0)
        {
                InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.与丏丅丑丙丑万三丝();
        }
        
        this.丙业与丂丈丅三七丂 = false;
        return;
        label_13:
        bool val_40 = GameConnect.丙丌丒丈东七丒上丌();
        GadgetTouchButton val_54 = this.gadgetsTouch[0];
        if(val_54 == null)
        {
            goto label_132;
        }
        
        if(val_40 == false)
        {
            goto label_133;
        }
        
        goto label_134;
        label_132:
        if(val_40 == true)
        {
            goto label_134;
        }
        
        label_133:
        val_54.上丅丕丅丟丕丏丁丆(丄一丌丝不三丙丗上:  5);
        if(this.crouchTouch != null)
        {
            goto label_137;
        }
        
        goto label_137;
    }
    private bool 丕丒丝上丄丏世丅丟(float 丑丅世丐丒丏丐三丅, float 东丏丕丗丕丞丁三丌, float 世万丈与丑专丝一丞)
    {
        return (bool)((丑丅世丐丒丏丐三丅 <= 世万丈与丑专丝一丞) ? 1 : 0) & ((丑丅世丐丒丏丐三丅 >= 东丏丕丗丕丞丁三丌) ? 1 : 0);
    }
    private void Awake()
    {
        object val_3;
        System.Delegate val_33;
        var val_34;
        东丁世丕万丘丛丙上 val_35;
        object val_36;
        var val_37;
        val_33 = System.Delegate.Combine(a:  137125888, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void TouchPadController::丕丌世丘丗专丞且丐(bool 丁丐不且七丂业丗丆)));
        if(this.zoomTouch == null)
        {
            goto label_2;
        }
        
        if(val_33 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_33 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_33 = 0;
        }
        
        label_6:
        mem2[0] = val_33;
        val_34 = System.Delegate.Combine(a:  val_33, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void TouchPadController::与丂丈丐丙丞丕丙专(bool 丁丐不且七丂业丗丆)));
        if(this.reloadTouch == null)
        {
            goto label_8;
        }
        
        if(val_34 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_34 == null)
        {
            goto label_12;
        }
        
        label_9:
        if(null != null)
        {
                val_34 = 0;
        }
        
        label_12:
        mem2[0] = val_34;
        ChooseGadgetPanel.一丟且世丈丏一与丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TouchPadController::丟一丌丅世丆丈丞七()));
        this.丌上三与与丁东与专();
        this.一一一丘丄下丏上丒 = this.reloadTouch.GetComponent<UISprite>();
        this.丄丘丌丛丛上丄丌一 = new 丅丂丘丐丐东丟丙丞();
        this.丏丈万丄万丛丐丞且 = new 丑丁且丏万丒丅三丝();
        this.丕丁上且丙丞丌且丕 = new 三三不丝且丄丛丒与();
        val_35 = this.丄丘丌丛丛上丄丌一;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                val_35 = this.丕丁上且丙丞丌且丕;
        }
        
        this.丗与丛与丕不丕上下 = (UnityEngine.Application.isEditor != true) ? (val_35) : this.丄丘丌丛丛上丄丌一;
        this.touchButtons = new System.Collections.Generic.List<TouchButton>();
        if(this.jumpTouch == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TouchPadController] Awake() => jumpTouch: null");
        }
        
        this.touchButtons.Add(item:  this.jumpTouch);
        if(this.fireTouch == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TouchPadController] Awake() => fireTouch: null");
        }
        
        this.touchButtons.Add(item:  this.fireTouch);
        if(this.zoomTouch == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TouchPadController] Awake() => zoomTouch: null");
        }
        
        this.touchButtons.Add(item:  this.zoomTouch);
        if(this.reloadTouch == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TouchPadController] Awake() => reloadTouch: null");
        }
        
        this.touchButtons.Add(item:  this.reloadTouch);
        val_36 = 0;
        goto label_44;
        label_59:
        if(this.gadgetsTouch[0] != 0)
        {
            goto label_49;
        }
        
        object[] val_21 = new object[1];
        val_3 = val_36;
        if(val_21 == null)
        {
            goto label_50;
        }
        
        if(val_3 != 0)
        {
            goto label_51;
        }
        
        goto label_54;
        label_50:
        if(val_3 == 0)
        {
            goto label_54;
        }
        
        label_51:
        label_54:
        val_21[0] = val_3;
        UnityEngine.Debug.LogErrorFormat(format:  "[TouchPadController] Awake() => gadgetsTouch[{0}]: null", args:  val_21);
        label_49:
        val_36 = 1;
        label_44:
        if(val_36 != this.gadgetsTouch.Length)
        {
            goto label_59;
        }
        
        this.touchButtons.AddRange(collection:  this.gadgetsTouch);
        if(this.crouchTouch == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TouchPadController] Awake() => crouchTouch: null; refIsNull: "("[TouchPadController] Awake() => crouchTouch: null; refIsNull: ") + (this.crouchTouch == 0) ? 1 : 0.ToString()((this.crouchTouch == 0) ? 1 : 0.ToString()));
        }
        
        this.touchButtons.Add(item:  this.crouchTouch);
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                this.touchButtons.Add(item:  this.dungeonAbilityButton);
        }
        
        if(this.carTouch == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TouchPadController] Awake() => carTouch: null; refIsNull: "("[TouchPadController] Awake() => carTouch: null; refIsNull: ") + (this.carTouch == 0) ? 1 : 0.ToString()((this.carTouch == 0) ? 1 : 0.ToString()));
        }
        
        this.touchButtons.Add(item:  this.carTouch);
        this.touchButtons.Add(item:  this.upPedalVehicle);
        this.touchButtons.Add(item:  this.downPedalVehicle);
        GameController val_31 = GameController.丑七不且上丗丁一世();
        if(val_31.万丕丘七丟丞丏不专 == false)
        {
            goto label_82;
        }
        
        val_37 = null;
        val_37 = null;
        if(null != 0)
        {
            goto label_86;
        }
        
        label_82:
        东丟丟万下丛丆丛丟.丘丞丏丈丝丟不丅丞();
        label_86:
        东丟丟万下丛丆丛丟.丌丟七世丗万丒东丆(丙业与丙丗丝不丈东:  new System.Action<ModuleGadgetRecord>(object:  this, method:  System.Void TouchPadController::丁三丂上上世丂丕丅(ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专)));
        this.丁业丁与丟丐丈业丆();
    }
    internal void 丄且丗丈丌丙且丆与()
    {
        var val_1;
        this.丏丄东上世丁且丕与 = 0;
        if(this.专一专丙丒丂不一丑 != false)
        {
                this.丛丆世丞丘丟且丂不();
            this.丝世丝且一丟丄丆业 = false;
        }
        
        val_1 = 0;
        this.grenadePressed = false;
        this.丂下与丛东专丄专下 = false;
        this.丈丁丒丒丛不七不且 = false;
        this.东一三上专丙七丄专 = false;
        goto label_1;
        label_6:
        GadgetTouchButton val_1 = this.gadgetsTouch[0];
        val_1 = 1;
        label_1:
        if(val_1 < this.gadgetsTouch.Length)
        {
            goto label_6;
        }
    
    }
    internal void 丙丂丈丟丕丕世丌丈()
    {
        goto label_0;
        label_5:
        this.gadgetsTouch[0].RestartCooldownGadget();
        0 = 1;
        label_0:
        if(0 < this.gadgetsTouch.Length)
        {
            goto label_5;
        }
    
    }
    private void 丟一丌丅世丆丈丞七()
    {
        if(this.专一专丙丒丂不一丑 != false)
        {
                this.丛丆世丞丘丟且丂不();
            this.丝世丝且一丟丄丆业 = false;
        }
        
        this.grenadePressed = false;
        this.丂下与丛东专丄专下 = false;
    }
    private void OnEnable()
    {
        this.isShootingPressure = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.七丌且下七丁丒下丞());
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void TouchPadController::丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void 丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        var val_9;
        GadgetTouchButton val_10;
        GadgetTouchButton[] val_11;
        GadgetTouchButton[] val_12;
        Rilisoft.ButtonHandler val_13;
        var val_14;
        var val_15;
        val_9 = this;
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(七丐丅专且专七三丆 == 6)
        {
                丙业与丙丗丝不丈东.丕丌世丘丗专丞且丐(丁丐不且七丂业丗丆:  (null != 0) ? 1 : 0);
        }
        
        if(null == 3)
        {
            goto label_4;
        }
        
        if(null != 1)
        {
                return;
        }
        
        if(七丐丅专且专七三丆 > 12)
        {
            goto label_6;
        }
        
        if(七丐丅专且专七三丆 == 11)
        {
            goto label_7;
        }
        
        if(七丐丅专且专七三丆 == 12)
        {
            goto label_15;
        }
        
        return;
        label_4:
        if(七丐丅专且专七三丆 > 28)
        {
            goto label_10;
        }
        
        if(七丐丅专且专七三丆 == 11)
        {
            goto label_11;
        }
        
        if(七丐丅专且专七三丆 == 12)
        {
            goto label_18;
        }
        
        if(七丐丅专且专七三丆 != 13)
        {
                return;
        }
        
        val_11 = this.gadgetsTouch;
        goto label_14;
        label_6:
        if(七丐丅专且专七三丆 == 29)
        {
            goto label_15;
        }
        
        if(七丐丅专且专七三丆 != 13)
        {
                return;
        }
        
        val_12 = this.gadgetsTouch;
        goto label_17;
        label_10:
        if(七丐丅专且专七三丆 == 29)
        {
            goto label_18;
        }
        
        if(七丐丅专且专七三丆 == 31)
        {
            goto label_19;
        }
        
        if(七丐丅专且专七三丆 != 32)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_13 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 280];
        val_13 = InGameGUI.丙丞专丌丁丞与不丐.cancelTurrelButton;
        if(null != 0)
        {
            goto label_60;
        }
        
        goto label_26;
        label_15:
        val_10 = this.gadgetsTouch[0];
        bool val_3 = val_10.Press(丆且上丘世下丅且丞:  true);
        if(七丐丅专且专七三丆 != 13)
        {
                return;
        }
        
        label_17:
        if(this.gadgetsTouch.Length < 2)
        {
                return;
        }
        
        val_14 = mem[this.gadgetsTouch + 40];
        if(val_14 != 0)
        {
            goto label_65;
        }
        
        label_66:
        label_65:
        val_15 = 1;
        goto label_36;
        label_18:
        val_10 = this.gadgetsTouch[0];
        bool val_4 = val_10.Press(丆且上丘世下丅且丞:  false);
        if(七丐丅专且专七三丆 != 13)
        {
                return;
        }
        
        label_14:
        if(this.gadgetsTouch.Length < 2)
        {
                return;
        }
        
        val_14 = mem[this.gadgetsTouch + 40];
        if(val_14 != 0)
        {
            goto label_71;
        }
        
        label_72:
        label_71:
        val_15 = 0;
        label_36:
        bool val_5 = val_14.Press(丆且上丘世下丅且丞:  false);
        return;
        label_7:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_48;
        }
        
        if(this.dungeonAbilityButton != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_11:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_53;
        }
        
        if(this.dungeonAbilityButton != null)
        {
            goto label_71;
        }
        
        goto label_72;
        label_19:
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_13 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 272];
        val_13 = InGameGUI.丙丞专丌丁丞与不丐.runTurrelButton;
        if(null != 0)
        {
            goto label_60;
        }
        
        label_26:
        label_60:
        DoClick();
        return;
        label_48:
        if(this.gadgetsTouch.Length < 3)
        {
                return;
        }
        
        if(this.gadgetsTouch[2] != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_53:
        if(this.gadgetsTouch.Length < 3)
        {
                return;
        }
        
        if(this.gadgetsTouch[2] != null)
        {
            goto label_71;
        }
        
        goto label_72;
    }
    internal static int 丈专丕三丑且丈丅上()
    {
        var val_3;
        WeaponManager val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_4 == 0)
        {
                return 0;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return 0;
        }
        
        val_6 = null;
        val_6 = null;
        if(null != 0)
        {
                return 丐丑专与与丗丗丟丂();
        }
        
        return 丐丑专与与丗丗丟丂();
    }
    private static bool 与丝世丗丘三且丝三()
    {
        Player_move_c val_4;
        var val_5;
        var val_6;
        if(InGameGUI.丙丞专丌丁丞与不丐.playerMoveC == 0)
        {
            goto label_7;
        }
        
        val_4 = 1152921505171275776;
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == false)
        {
            goto label_10;
        }
        
        label_7:
        val_4 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
        val_4 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
        if(val_4 != 0)
        {
            goto label_14;
        }
        
        val_5 = null;
        label_10:
        val_5 = null;
        var val_3 = (与丂丏丛丞丞丒丟丄.丄丁丑丞丅一三丌丆 == false) ? 1 : 0;
        return (bool)val_6;
        label_14:
        val_6 = 0;
        return (bool)val_6;
    }
    private bool 专丝丘丒一丘与丏丞()
    {
        WeaponManager val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = 1152921505321115648;
        val_7 = null;
        if(TouchPadController.与丝世丗丘三且丝三() == false)
        {
                return false;
        }
        
        val_8 = null;
        val_8 = null;
        if(与丂丏丛丞丞丒丟丄.三丆下丆七丁丛丐东 == false)
        {
                return false;
        }
        
        if(Player_move_c.丗丒丕专丛丆丈万一() == false)
        {
                return false;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_9 = null;
            if(TouchPadController.丈专丕三丑且丈丅上() < 1)
        {
                return false;
        }
        
        }
        
        val_6 = 1152921505286238208;
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 1)
        {
                return false;
        }
        
        val_11 = null;
        val_11 = null;
        val_6 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 2)
        {
                return false;
        }
        
        PGCompany.丗三万丁三丗上专丟 val_5 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if(val_5 != null)
        {
                return val_5.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
        }
        
        return val_5.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
    }
    internal static bool 丕上丅不丌丂丕万丌()
    {
        WeaponManager val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = null;
        if(TouchPadController.与丝世丗丘三且丝三() == false)
        {
                return false;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return false;
        }
        
        val_8 = null;
        val_8 = null;
        val_6 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_6 == 0)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_6 != 0)
        {
                val_10 = null;
            val_10 = null;
            val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(丐丑专与与丗丗丟丂() < 1)
        {
                return false;
        }
        
        }
        
        return false;
    }
    private void 丈一丕七专不丐专世()
    {
        UnityEngine.Object val_10;
        object val_11;
        var val_12;
        var val_13;
        int val_1 = this.touchButtons.Count;
        if(val_1 == 0)
        {
                return;
        }
        
        object val_10 = 0;
        label_28:
        val_10 = this.touchButtons.Item[0];
        if(val_10 != 0)
        {
            goto label_6;
        }
        
        if(val_10 == this.七丆三一丛万丁丕万)
        {
            goto label_16;
        }
        
        if(0 == 0)
        {
            goto label_10;
        }
        
        val_11 = 0.name;
        goto label_12;
        label_6:
        if(val_10 != null)
        {
                val_12 = 0;
            val_13 = val_10.gameObject;
        }
        else
        {
                val_12 = 0;
            val_13 = 0.gameObject;
        }
        
        val_13.SetActive(value:  val_10 & 1);
        goto label_16;
        label_10:
        val_11 = "(null)";
        label_12:
        object[] val_9 = new object[2];
        val_10 = val_9;
        if(val_10 == null)
        {
            goto label_17;
        }
        
        if(val_10 != 0)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(val_10 == 0)
        {
            goto label_21;
        }
        
        label_18:
        label_21:
        val_10[0] = val_10;
        val_10[1] = val_11;
        UnityEngine.Debug.LogErrorFormat(format:  "[TouchPadController] SetSpritesState() => touchButtons[{0}]: null, previous: {1}", args:  val_9);
        this.七丆三一丛万丁丕万 = val_10;
        label_16:
        val_10 = val_10 + 1;
        if(val_1 != val_10)
        {
            goto label_28;
        }
    
    }
    private void 万且丞丕丗丟丘丟丟()
    {
        与丆上丈丕丗丅东丏 val_20;
        float val_21;
        float val_22;
        var val_23;
        UIAnchor val_1 = this.GetComponent<UIAnchor>();
        val_20 = val_1.side;
        if(val_20 != 6)
        {
            goto label_2;
        }
        
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false)
        {
            goto label_5;
        }
        
        val_21 = 1f;
        goto label_8;
        label_5:
        val_20 = val_1.side;
        label_2:
        if(val_20 != 0)
        {
                val_21 = -1f;
        }
        
        label_8:
        val_1.side = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 6 : 0;
        UnityEngine.BoxCollider val_7 = this.GetComponent<UnityEngine.BoxCollider>();
        UnityEngine.Vector3 val_8 = val_7.center;
        val_22 = ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? -1f : 1f) * val_8.x;
        val_7.center = new UnityEngine.Vector3() {x = val_22, y = val_8.y, z = val_8.z};
        var val_11 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f;
        this.chooseGadgetPanel.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_23 = 0;
        goto label_19;
        label_33:
        var val_14 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f;
        UnityEngine.Vector3 val_16 = this.chooseGadgetPanel.objectsNoFilpXScale.Item[0].localScale;
        val_22 = val_16.y;
        UnityEngine.Vector3 val_18 = this.chooseGadgetPanel.objectsNoFilpXScale.Item[0].localScale;
        this.chooseGadgetPanel.objectsNoFilpXScale.Item[0].localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_23 = 1;
        label_19:
        if(val_23 < this.chooseGadgetPanel.objectsNoFilpXScale.Count)
        {
            goto label_33;
        }
    
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TouchPadController.与丈丅下丁三丝丆专();
    }
    public void Reset()
    {
        if(this.丗与丛与丕不丕上下 == null)
        {
                return;
        }
        
        goto typeof(东丁世丕万丘丛丙上).__il2cppRuntimeField_198;
    }
    internal void 丅丛下业业丆丈七丒(bool 丁丅丟丒丙丐丅与丂 = False)
    {
        var val_18;
        object val_19;
        UnityEngine.Object val_20;
        var val_21;
        val_19 = this;
        if(this.丙业与丂丈丅三七丂 != false)
        {
                if(丁丅丟丒丙丐丅与丂 == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Camera val_6 = 不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject).transform.GetChild(index:  0).GetChild(index:  0).GetComponent<UnityEngine.Camera>();
        UnityEngine.Transform val_7 = val_6.transform;
        val_18 = this.touchButtons.Count;
        if(val_18 != 0)
        {
                object val_18 = 0;
            do
        {
            val_20 = this.touchButtons.Item[0];
            if(val_20 == 0)
        {
                val_20 = "[TouchPadController] CalculateRects() => touchButton: null, i: "("[TouchPadController] CalculateRects() => touchButton: null, i: ") + val_18;
            UnityEngine.Debug.LogWarning(message:  val_20);
        }
        else
        {
                val_20.CalculateButtonRect(丆丏一专不丝丈丗上:  val_6);
        }
        
            val_18 = val_18 + 1;
        }
        while(val_18 != val_18);
        
        }
        
        this.CalculateMoveRect();
        FireTouchButton val_12 = this.fireTouch + 24;
        if((1315758268 & 1) != 0)
        {
                val_21 = 0;
        }
        
        mem2[0] = (UnityEngine.Screen.width > UnityEngine.Screen.height) ? 1 : 0;
        val_19 = "Control rects calculated. Success == "("Control rects calculated. Success == ") + this.丙业与丂丈丅三七丂.ToString();
        UnityEngine.Debug.Log(message:  val_19);
    }
    public void RecalculateRect()
    {
        this.丙业与丂丈丅三七丂 = false;
    }
    private UnityEngine.Rect 丆丗上丑东万三丟丙(UnityEngine.Camera 丆丏一专不丝丈丗上, UnityEngine.Transform 丑丏丂一丄下丕丘一, float 且丛上丕业丂丒与一, bool 丕丐丟下东专丒丘业 = True)
    {
        float val_7;
        float val_13 = 且丛上丕业丂丒与一;
        val_13 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_13;
        if(丆丏一专不丝丈丗上 != 0)
        {
                if(丑丏丂一丄下丕丘一 != 0)
        {
            goto label_8;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "camera or button not setted");
        label_8:
        val_13 = val_13 + val_13;
        UnityEngine.Bounds val_5 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  丑丏丂一丄下丕丘一, 一丐丂丘专丅丟丞七:  丕丐丟下东专丒丘业);
        UnityEngine.Vector3 val_8 = 丆丏一专不丝丈丗上.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_7, y = V1.16B, z = V2.16B});
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_13, y:  val_13);
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, d:  0.5f);
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    public void CalculateMoveRect()
    {
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                int val_3 = UnityEngine.Screen.width;
            float val_5 = (float)UnityEngine.Screen.height * 0.65f;
        }
        else
        {
                float val_12 = (float)UnityEngine.Screen.width;
            val_12 = val_12 * 0.5f;
            if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != false)
        {
                float val_13 = (float)UnityEngine.Screen.width;
            val_13 = val_13 - val_12;
            float val_9 = (float)UnityEngine.Screen.height * 0.65f;
        }
        else
        {
                float val_11 = (float)UnityEngine.Screen.height * 0.65f;
        }
        
        }
        
        this.丄世丙丞七丒丅丑丒 = 0;
        mem[1152921540282778180] = 0;
        mem[1152921540282778188] = 0;
    }
    private System.Collections.IEnumerator 七丌且下七丁丒下丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TouchPadController.业丁丝东丅业丅上丏();
    }
    private void 丌上三与与丁东与专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetPanel.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private bool 丞世东丈丄丐丈丗丗(UnityEngine.Vector2 丟下丙丆不东一与丅)
    {
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return false;
        }
        
        if(InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class == 0)
        {
                return false;
        }
        
        if(InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丐丗与丁七下丕世丈() == false)
        {
                return false;
        }
        
        return InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.下下世丙丟丅丐丞丒(丟下丙丆不东一与丅:  new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.x, y = 丟下丙丆不东一与丅.y});
    }
    private void Update()
    {
        int val_44;
        var val_45;
        UnityEngine.Object val_46;
        var val_47;
        var val_48;
        float val_51;
        float val_52;
        float val_53;
        UnityEngine.Rect val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        UnityEngine.Object val_59;
        var val_60;
        var val_61;
        var val_62;
        val_44 = 1152921505286238208;
        val_45 = null;
        val_45 = null;
        val_46 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七 != val_46)
        {
                val_47 = null;
            val_47 = null;
            val_46 = 0;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != val_46)
        {
                val_48 = null;
            val_48 = null;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            val_51 = val_3.x;
            val_52 = val_51;
            val_53 = val_3.y;
            val_46 = 0;
            typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丂万丟丑丅丕世丙且(丙业与丙丗丝不丈东:  new UnityEngine.Vector2() {x = val_52, y = val_53});
        }
        
        }
        
        if(this.丈丁丒丒丛不七不且 != false)
        {
                val_51 = this.且三丂丘不不丘丅丂;
            if(val_51 <= 0f)
        {
                this.丈丁丒丒丛不七不且 = false;
            this.丙丄上且一丌三三丐();
            val_51 = this.且三丂丘不不丘丅丂;
        }
        
            val_52 = val_51 - UnityEngine.Time.deltaTime;
            this.且三丂丘不不丘丅丂 = val_52;
        }
        
        if(this.东一三上专丙七丄专 != false)
        {
                if(this.丟丁丅业专丈专丒丙 <= 0f)
        {
                this.东一三上专丙七丄专 = false;
            if(UnityEngine.Input.touchCount >= 1)
        {
                var val_40 = 0;
            val_54 = this.丆丏丒丝丁丕丟丘丟;
            do
        {
            UnityEngine.Touch val_6 = UnityEngine.Input.GetTouch(index:  0);
            if(this.丏丄东上世丁且丕与 != 1)
        {
                val_46 = 0;
            if(GetHashCode() == this.丏丄东上世丁且丕与)
        {
                val_46 = 0;
            if((val_54 & 1) != 0)
        {
                this.GrenadePressInvoke();
        }
        else
        {
                this.丂下与丛东专丄专下 = false;
        }
        
        }
        
        }
        
            val_40 = val_40 + 1;
        }
        while(val_40 < UnityEngine.Input.touchCount);
        
        }
        
        }
        
            val_51 = this.丟丁丅业专丈专丒丙;
            val_52 = val_51 - UnityEngine.Time.deltaTime;
            this.丟丁丅业专丈专丒丙 = val_52;
        }
        
        if(this.丝世丝且一丟丄丆业 != false)
        {
                val_53 = this.丗丕万丁丙丗丐与不;
            val_52 = UnityEngine.Time.realtimeSinceStartup + (-5f);
            if(val_52 >= val_53)
        {
                this.丛丆世丞丘丟且丂不();
            this.丝世丝且一丟丄丆业 = false;
        }
        
        }
        
        this.丌上三与与丁东与专();
        val_55 = 0;
        goto label_32;
        label_54:
        GadgetTouchButton val_41 = this.gadgetsTouch[0];
        val_56 = null;
        val_56 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_45;
        }
        
        val_57 = null;
        val_57 = null;
        val_58 = null;
        val_58 = null;
        if(this.gadgetsTouch[0x0][0].cantUseGadgetObj != null)
        {
            goto label_52;
        }
        
        goto label_51;
        label_45:
        val_54 = 0;
        if(this.gadgetsTouch[0x0][0].cantUseGadgetObj != null)
        {
            goto label_52;
        }
        
        label_51:
        label_52:
        this.gadgetsTouch[0x0][0].cantUseGadgetObj.SetActive(value:  (val_54 != 0) ? 1 : 0);
        val_55 = 1;
        label_32:
        if(val_55 < this.gadgetsTouch.Length)
        {
            goto label_54;
        }
        
        if(this.专一专丙丒丂不一丑 != false)
        {
                UnityEngine.Vector2 val_14 = UICamera.lastTouchPosition;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetPanel.hoverBackground1, 丏业丟一东丂东丘丛:  this.丆丏丒丝丁丕丟丘丟 & 1);
            UnityEngine.Vector2 val_16 = UICamera.lastTouchPosition;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetPanel.hoverBackground2, 丏业丟一东丂东丘丛:  this.不丐丌丕东丕丟业丕 & 1);
            val_54 = this.业丗丗世世丑且丒丑;
            UnityEngine.Vector2 val_18 = UICamera.lastTouchPosition;
            val_46 = val_54 & 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetPanel.hoverBackground3, 丏业丟一东丂东丘丛:  val_46);
        }
        
        int val_42 = this.业丗七丕万万不丈丗;
        val_42 = val_42 + 1;
        this.业丗七丕万万不丈丗 = val_42;
        this.丈一丕七专不丐专世();
        this._isFirstFrame = false;
        if(this.丟丈丝下世上世业万 == false)
        {
            goto label_63;
        }
        
        int val_19 = UnityEngine.Input.touchCount;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
            goto label_67;
        }
        
        val_44 = InGameGUI.丙丞专丌丁丞与不丐.isWorldMapOpened;
        goto label_69;
        label_63:
        this.isShootingPressure = false;
        if(this.丗与丛与丕不丕上下 == null)
        {
                return;
        }
        
        return;
        label_67:
        val_44 = 0;
        label_69:
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_55 = WindowEnabled;
        }
        else
        {
                val_55 = 0;
        }
        
        val_54 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_54 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        val_59 = 0;
        if(val_54 != val_59)
        {
                val_54 = 丅与丌专丟一丝业三();
            val_59 = 0;
            val_60 = val_54.activeInHierarchy;
        }
        else
        {
                val_60 = 0;
        }
        
        if(val_19 < 1)
        {
            goto label_92;
        }
        
        val_60 = (val_55 | val_44) | val_60;
        if(val_60 != 0)
        {
            goto label_92;
        }
        
        if((this.丅七下业丙上丘上丝 != 1) || (val_19 < 1))
        {
            goto label_94;
        }
        
        val_55 = 1152921505077186560;
        label_109:
        UnityEngine.Touch val_28 = UnityEngine.Input.GetTouch(index:  0);
        val_61 = null;
        val_61 = null;
        val_44 = JoystickController.丗三丄与丂丟丌专东.TouchFingerID;
        if((val_44 != GetHashCode()) && ((System.Linq.Enumerable.Contains<UnityEngine.GameObject>(source:  WeaponTogglesController.__il2cppRuntimeField_byval_arg, value:  UICamera.selectedObject)) != true))
        {
                if(((丞世东丈丄丐丈丗丗(丟下丙丆不东一与丅:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y})) != false) && (this.不丑丞世且不丂丐丘 == 1))
        {
                this.不丑丞世且不丂丐丘 = GetHashCode();
        }
        
            if((this.丄世丙丞七丒丅丑丒 & 1) != 0)
        {
                val_44 = this.不丑丞世且不丂丐丘;
            if(val_44 != 1)
        {
                if(val_44 == GetHashCode())
        {
            goto label_108;
        }
        
        }
        
            this.丅七下业丙上丘上丝 = GetHashCode();
            this.上且专下丈下丕七丄 = -1f;
        }
        
        }
        
        label_108:
        val_54 = 0 + 1;
        if(val_19 != val_54)
        {
            goto label_109;
        }
        
        label_94:
        if(this.丝世上丞丁与丒下丄 == true)
        {
            goto label_122;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                if((SpeedrunTrackController.丛专与丅下丌丆世丒 + 164) == 0)
        {
            goto label_122;
        }
        
        }
        
        val_62 = null;
        val_62 = null;
        if(GameController.丒且丅丙丏丙不丒丙 == true)
        {
            goto label_122;
        }
        
        this.不且丌且丕丑丛专丑();
        goto label_122;
        label_92:
        this.丅七下业丙上丘上丝 = 0;
        this.不丑丞世且不丂丐丘 = 0;
        UnityEngine.Vector2 val_38 = UnityEngine.Vector2.zero;
        this.一丏丞上一丏丌丕丗 = val_38;
        mem[1152921540283374796] = val_38.y;
        UnityEngine.Vector2 val_39 = UnityEngine.Vector2.zero;
        this.与世丞丕世丄七丙丈 = val_39;
        mem[1152921540283374780] = val_39.y;
        label_122:
        if(this.丒与世丞丕丗一丆丟 == false)
        {
                return;
        }
        
        if(this.专一专丙丒丂不一丑 == false)
        {
                return;
        }
        
        this.丒与世丞丕丗一丆丟 = false;
    }
    internal static void 三与丅七丕上三东一()
    {
        System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌> val_4 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅();
        Dictionary.Enumerator<TKey, TValue> val_2 = val_4.GetEnumerator();
        if((1317016008 & 1) != 0)
        {
                do
        {
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            val_4;
            val_3._value._obj.三丆丘丙丄下万七三();
        }
        while((1317016008 & 1) != 0);
        
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丙丑丌丘不丈七且七()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        this.与与上丘丌丒丕一下 = false;
        if(UnityEngine.Input.touchCount < 1)
        {
                return;
        }
        
        UnityEngine.Touch[] val_2 = UnityEngine.Input.touches;
        val_4 = 0;
        goto label_2;
        label_20:
        val_5 = 0;
        var val_3 = 0 + 32;
        if(丏丘丑丈专丈丁丏世() != 2)
        {
            goto label_18;
        }
        
        val_5 = 0;
        val_6 = 0;
        goto label_5;
        label_17:
        val_7 = null;
        val_7 = null;
        if(this.丂且丛与丆丝东丂专[0] > UnityEngine.Mathf.Epsilon)
        {
            goto label_10;
        }
        
        val_8 = null;
        val_8 = null;
        if(this.丂且丛与丆丝东丂专[0] <= UnityEngine.Mathf.Epsilon)
        {
            goto label_15;
        }
        
        label_10:
        val_6 = 1;
        label_15:
        val_5 = 1;
        label_5:
        if(val_5 < this.丂且丛与丆丝东丂专.Length)
        {
            goto label_17;
        }
        
        if((val_6 & 1) == 0)
        {
                this.与与上丘丌丒丕一下 = true;
        }
        
        label_18:
        val_4 = 1;
        label_2:
        if(val_4 < val_2.Length)
        {
            goto label_20;
        }
    
    }
    internal void 丁业丁与丟丐丈业丆()
    {
        GadgetCategory val_29;
        GadgetTouchButton[] val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_35;
        var val_38;
        var val_39;
        var val_41;
        CategoryNames val_42;
        val_29 = 1152921505066536960;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_3;
        }
        
        val_30 = 0;
        goto label_4;
        label_12:
        GadgetTouchButton val_32 = this.gadgetsTouch[0];
        if(val_32 == null)
        {
            goto label_7;
        }
        
        if(val_30 == 0)
        {
            goto label_8;
        }
        
        label_10:
        val_32.DeactivateGadgetButton();
        goto label_9;
        label_7:
        if(val_30 != 0)
        {
            goto label_10;
        }
        
        label_8:
        val_32.SetupDaterButton();
        label_9:
        val_30 = 1;
        label_4:
        if(val_30 < this.gadgetsTouch.Length)
        {
            goto label_12;
        }
        
        return;
        label_3:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_16;
        }
        
        val_31 = null;
        val_31 = null;
        val_32 = 1152921505317388288;
        val_33 = 0;
        goto label_21;
        label_34:
        if(val_33 == 0)
        {
                val_29 = typeof(Player_move_c).__il2cppRuntimeField_5F0.丒万丕七专不丏丞丌();
            this.gadgetsTouch[0].丐不世丘丁丘下七一(丅东丕丄与一丛丂世:  丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  typeof(Player_move_c).__il2cppRuntimeField_5F0.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  typeof(Player_move_c).__il2cppRuntimeField_5F0.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false), 东一丁世丑丞业丄丐:  typeof(Player_move_c).__il2cppRuntimeField_5F0, 七丆丒与丗丌丄且丂:  val_29);
        }
        else
        {
                this.gadgetsTouch[0].DeactivateGadgetButton();
        }
        
        val_33 = 1;
        label_21:
        val_30 = this.gadgetsTouch;
        if(val_33 < this.gadgetsTouch.Length)
        {
            goto label_34;
        }
        
        return;
        label_16:
        this.且丌不业下丌且东专.Clear();
        if(GameConnect.丟丆丏上丌一丝丟业() == true)
        {
            goto label_87;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        System.Collections.Generic.IEnumerator<T> val_12 = System.Linq.Enumerable.OfType<GadgetCategory>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))).GetEnumerator();
        val_32 = 1152921504691191808;
        val_35 = 1152921526125882176;
        label_71:
        var val_36 = 0;
        val_36 = val_36 + 1;
        if(val_12.MoveNext() == false)
        {
            goto label_54;
        }
        
        var val_37 = 0;
        val_37 = val_37 + 1;
        T val_16 = val_12.Current;
        if((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().ContainsKey(key:  val_16)) == false)
        {
            goto label_71;
        }
        
        不丘丄丝丗丒丙一丌 val_20 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_16];
        this.且丌不业下丌且东专.Add(item:  val_16);
        goto label_71;
        label_54:
        val_38 = 0;
        val_39 = 0;
        if(val_12 == null)
        {
            
        }
        else
        {
                var val_38 = 0;
            val_38 = val_38 + 1;
            val_12.Dispose();
        }
        
        label_87:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_90;
        }
        
        val_30 = 1;
        goto label_91;
        label_96:
        this.gadgetsTouch[1].DeactivateGadgetButton();
        val_30 = 2;
        label_91:
        if(val_30 < this.gadgetsTouch.Length)
        {
            goto label_96;
        }
        
        return;
        label_90:
        val_32 = 1152921540284438144;
        val_35 = 1152921540284439168;
        val_41 = 0;
        goto label_98;
        label_120:
        if(val_41 >= this.且丌不业下丌且东专.Count)
        {
            goto label_100;
        }
        
        不丘丄丝丗丒丙一丌 val_26 = 0;
        bool val_27 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  this.且丌不业下丌且东专.Item[0], value: out  val_26);
        if(val_26 == 0)
        {
            goto label_115;
        }
        
        val_42 = this.且丌不业下丌且东专.Item[0];
        if(val_41 >= this.gadgetsTouch.Length)
        {
                val_42 = 0;
        }
        
        val_29 = val_26;
        this.gadgetsTouch[0].丐不世丘丁丘下七一(丅东丕丄与一丛丂世:  丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_26.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  val_42, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false), 东一丁世丑丞业丄丐:  val_29, 七丆丒与丗丌丄且丂:  this.且丌不业下丌且东专.Item[0]);
        goto label_115;
        label_100:
        this.gadgetsTouch[0].DeactivateGadgetButton();
        label_115:
        val_41 = 1;
        label_98:
        val_30 = this.gadgetsTouch;
        if(val_41 < this.gadgetsTouch.Length)
        {
            goto label_120;
        }
    
    }
    internal void 丁三丂上上世丂丕丅(ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专)
    {
        this.丕万丄丙世上与世丞 = 三丐三丞丘丕不丒专;
        this.世丞一丕丙丅专丗丙();
    }
    internal void 世丞一丕丙丅专丗丙()
    {
        var val_4;
        var val_5;
        GadgetTouchButton val_6;
        var val_7;
        丕丈丏丝丗下丟丅丂 val_8;
        var val_9;
        UnityEngine.Texture val_10;
        var val_11;
        var val_12;
        val_4 = null;
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_3;
        }
        
        val_5 = null;
        if(this.dungeonAbilityButton == null)
        {
            goto label_6;
        }
        
        if(东丟丟万下丛丆丛丟.丟丛丙七一与专上丆 == null)
        {
            goto label_7;
        }
        
        label_25:
        this.dungeonAbilityButton.gameObject.SetActive(value:  true);
        val_6 = this.dungeonAbilityButton;
        val_7 = null;
        val_7 = null;
        val_8 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        val_9 = 13500;
        val_10 = this.丕万丄丙世上与世丞.icon;
        goto label_14;
        label_3:
        val_11 = null;
        GadgetTouchButton val_4 = this.gadgetsTouch[2];
        if(东丟丟万下丛丆丛丟.丟丛丙七一与专上丆 == null)
        {
            goto label_19;
        }
        
        val_12 = null;
        val_6 = this.丕万丄丙世上与世丞.icon;
        val_12 = null;
        val_8 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        val_9 = 13500;
        val_10 = val_6;
        label_14:
        val_4.丐不世丘丁丘下七一(丅东丕丄与一丛丂世:  val_10, 东一丁世丑丞业丄丐:  val_8, 七丆丒与丗丌丄且丂:  188);
        return;
        label_6:
        if(东丟丟万下丛丆丛丟.丟丛丙七一与专上丆 != null)
        {
            goto label_25;
        }
        
        label_7:
        this.dungeonAbilityButton.DeactivateGadgetButton();
        this.dungeonAbilityButton.gameObject.SetActive(value:  false);
        return;
        label_19:
        val_4.DeactivateGadgetButton();
    }
    private void LateUpdate()
    {
        this.丅丛下业业丆丈七丒(丁丅丟丒丙丐丅与丂:  (this.上业七丑丏丈丄丐丗 > 0) ? 1 : 0);
        int val_2 = this.上业七丑丏丈丄丐丗;
        val_2 = val_2 - 1;
        if(this.上业七丑丏丈丄丐丗 >= 0)
        {
                this.上业七丑丏丈丄丐丗 = val_2;
        }
        
        this.与与上丘丌丒丕一下 = false;
    }
    private void 不且丌且丕丑丛专丑()
    {
        var val_29;
        float val_30;
        float val_31;
        float val_32;
        var val_35;
        UIJoystick val_36;
        UnityEngine.Vector2 val_37;
        UnityEngine.Vector2 val_38;
        float val_39;
        float val_42;
        var val_43;
        var val_44;
        float val_45;
        int val_1 = UnityEngine.Input.touchCount;
        if(val_1 < 1)
        {
                return;
        }
        
        val_29 = 0;
        val_30 = 2f;
        label_37:
        UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
        if(GetHashCode() != this.丅七下业丙上丘上丝)
        {
            goto label_2;
        }
        
        if(专三三与三且一且一() == 3)
        {
            goto label_3;
        }
        
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.一丏丞上一丏丌丕丗, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y})) != false)
        {
                this.一丏丞上一丏丌丕丗 = this.一丏丞上一丏丌丕丗;
            mem[1152921540285744220] = V10.16B;
        }
        
        val_31 = V10.16B;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.一丏丞上一丏丌丕丗, y = val_31}, b:  new UnityEngine.Vector2() {x = this.一丏丞上一丏丌丕丗, y = V10.16B});
        val_32 = val_7.x;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = val_32, y = val_7.y}, rhs:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y})) == false)
        {
            goto label_17;
        }
        
        val_32 = this.与世丞丕世丄七丙丈;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_32, y = val_7.y}, rhs:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y})) == false)
        {
            goto label_17;
        }
        
        val_35 = null;
        val_32 = this.与世丞丕世丄七丙丈;
        val_35 = null;
        val_36 = JoystickController.丗三丄与丂丟丌专东;
        if(val_36 == null)
        {
                val_35 = 0;
        }
        
        if(((this.丄专丕万丕不下万世(丕丛丄东一丒丅丈万:  new UnityEngine.Vector2() {x = val_32, y = val_7.y}, 下不三丕世丄七丝丒:  new UnityEngine.Vector2() {x = JoystickController.丗三丄与丂丟丌专东.value, y = JoystickController.丗三丄与丂丟丌专东 + 192 + 4})) == false) || (this.与世丞丕世丄七丙丈.sqrMagnitude <= 15f))
        {
            goto label_17;
        }
        
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = this.与世丞丕世丄七丙丈, y = val_7.y}, d:  val_30);
        val_38 = this.丏业业业丈丘一丘丒;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_38, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        goto label_20;
        label_2:
        if((GetHashCode() != this.不丑丞世且不丂丐丘) || (专三三与三且一且一() != 3))
        {
            goto label_23;
        }
        
        this.不丑丞世且不丂丐丘 = 0;
        goto label_23;
        label_17:
        val_31 = val_14.x;
        val_37 = this.丏业业业丈丘一丘丒;
        val_38 = val_31;
        val_39 = val_14.y;
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_38, y = val_39}, b:  new UnityEngine.Vector2() {x = val_37, y = val_32});
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.zero;
        label_20:
        this.丏业业业丈丘一丘丒 = val_19;
        mem[1152921540285743908] = val_19.y;
        if(this.上一丈东三丒万业东 != false)
        {
                val_42 = val_18.y;
            this.丛一丒丝丒丕世下下 = val_18;
            mem[1152921540285744124] = val_42;
            float val_30 = this.丁丝丆丟丏三丅丁丁;
            float val_29 = (float)UnityEngine.Screen.height;
            val_29 = val_19.x / val_29;
            val_30 = val_29 / val_30;
            this.上且专下丈下丕七丄 = val_30;
            val_38 = val_18.x;
            val_39 = val_18.y;
            this.与丛与不丝与一丕且(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_38, y = val_39});
        }
        else
        {
                if(val_18.x.sqrMagnitude > (1.401298E-45f))
        {
                this.上一丈东三丒万业东 = true;
            val_43 = null;
            val_43 = null;
            val_36 = ClickerDetector.丄丘七三上丕世丞业;
            if(val_36 != 0)
        {
                val_44 = null;
            val_44 = null;
            val_38 = val_18.x;
            val_42 = 15;
            val_36 = ClickerDetector.丄丘七三上丕世丞业;
            val_36.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  (val_38 < 0) ? (val_42) : 16);
        }
        
        }
        
        }
        
        this.一丏丞上一丏丌丕丗 = val_18;
        mem[1152921540285744220] = val_19.y;
        this.丛七丘丈丈丏专丂上();
        this.与世丞丕世丄七丙丈 = val_18;
        mem[1152921540285744204] = val_18.y;
        this.丑丗丘与丈不七东丛 = UnityEngine.Time.time;
        label_23:
        val_29 = val_29 + 1;
        if(val_29 < val_1)
        {
            goto label_37;
        }
        
        return;
        label_3:
        val_30 = this.上且专下丈下丕七丄;
        val_45 = this.且丙世丛丕丐丛丝一;
        if(val_30 > val_45)
        {
                float val_25 = UnityEngine.Mathf.Min(a:  val_30, b:  this.丅世七丄丐不丈下东);
            float val_31 = this.丝业世丐与下东业丅;
            this.世丞与丙丅丂上下丒 = val_25;
            val_31 = val_25 / val_31;
            float val_26 = UnityEngine.Mathf.Max(a:  this.丗丟丐七丁丒业丄丕, b:  val_31);
            this.丞世丌东且丁下丅上 = val_26;
            val_45 = val_26 + val_26;
            this.一丘丆专丌业业丅业 = val_45;
        }
        else
        {
                this.世丞与丙丅丂上下丒 = -1f;
        }
        
        this.丅七下业丙上丘上丝 = 0;
        UnityEngine.Vector2 val_27 = UnityEngine.Vector2.zero;
        this.一丏丞上一丏丌丕丗 = val_27;
        mem[1152921540285744220] = val_27.y;
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.zero;
        this.与世丞丕世丄七丙丈 = val_28;
        mem[1152921540285744204] = val_28.y;
        this.上一丈东三丒万业东 = false;
    }
    private void 丛七丘丈丈丏专丂上()
    {
        UnityEngine.Vector2[] val_4;
        int val_5;
        val_4 = this.丂且丛与丆丝东丂专;
        if(this.丂且丛与丆丝东丂专 == null)
        {
                val_4 = this.丂且丛与丆丝东丂专;
        }
        
        int val_1 = this.丂且丛与丆丝东丂专.Length - 1;
        if(val_1 >= 1)
        {
                int val_2 = this.丂且丛与丆丝东丂专.Length - 2;
            var val_7 = 0;
            var val_6 = (long)val_1;
            do
        {
            if(val_2 < this.丂且丛与丆丝东丂专.Length)
        {
                val_5 = this.丂且丛与丆丝东丂专.Length & 4294967295;
        }
        else
        {
                val_5 = this.丂且丛与丆丝东丂专.Length;
        }
        
            [val_7] = [val_7];
            [val_7] = [val_7];
            val_4 = this.丂且丛与丆丝东丂专;
            int val_3 = val_2 - 1;
            val_6 = val_6 - 1;
            val_7 = val_7 - 8;
        }
        while(val_2 > 0);
        
        }
        
        val_4[0] = this.与世丞丕世丄七丙丈;
        val_4[0] = this;
    }
    private bool 丄专丕万丕不下万世(UnityEngine.Vector2 丕丛丄东一丒丅丈万, UnityEngine.Vector2 下不三丕世丄七丝丒)
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = JoystickController.丗三丄与丂丟丌专东.value, y = JoystickController.丗三丄与丂丟丌专东 + 192 + 4}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) != false)
        {
                var val_5 = ((UnityEngine.Mathf.Sign(f:  丕丛丄东一丒丅丈万.x)) != (UnityEngine.Mathf.Sign(f:  下不三丕世丄七丝丒.x))) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public void HasAmmo()
    {
        if(this.reloadTouch == null)
        {
            
        }
    
    }
    public void NoAmmo()
    {
        if(this.reloadTouch == null)
        {
            
        }
    
    }
    public void HasAmmoInWeapon()
    {
        null = null;
        if(null == 0)
        {
            
        }
    
    }
    public void NoAmmoInWeapon()
    {
        null = null;
        if(null == 0)
        {
            
        }
    
    }
    private System.Collections.IEnumerator BlinkReload()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TouchPadController.三丏丙专与丕东专丁();
    }
    private bool 丘与丏丏东丟丒丞三(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        var val_1;
        if(this.丒与世丞丕丗一丆丟 == false)
        {
            goto label_0;
        }
        
        label_8:
        val_1 = 0;
        return (bool)val_1;
        label_0:
        if((this.丆丏丒丝丁丕丟丘丟 & 1) == 0)
        {
            goto label_2;
        }
        
        this.chooseGadgetPanel.ChooseDefault();
        goto label_7;
        label_2:
        if((this.不丐丌丕东丕丟业丕 & 1) == 0)
        {
            goto label_5;
        }
        
        this.chooseGadgetPanel.ChooseFirst();
        goto label_7;
        label_5:
        if((this.业丗丗世世丑且丒丑 & 1) == 0)
        {
            goto label_8;
        }
        
        this.chooseGadgetPanel.ChooseSecond();
        label_7:
        this.丛丆世丞丘丟且丂不();
        val_1 = 1;
        return (bool)val_1;
    }
    private void 丛丆世丞丘丟且丂不()
    {
        this.chooseGadgetPanel.Hide();
        this.专一专丙丒丂不一丑 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetPanel.hoverBackground1, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetPanel.hoverBackground2, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetPanel.hoverBackground3, 丏业丟一东丂东丘丛:  false);
    }
    internal TouchButton 丙丝三丈业业丞丘不(bool 丆且上丘世下丅且丞)
    {
        object val_8;
        UnityEngine.Object val_9;
        int val_1 = this.touchButtons.Count;
        if(val_1 != 0)
        {
                val_8 = 0;
            bool val_2 = 丆且上丘世下丅且丞;
            do
        {
            val_9 = this.touchButtons.Item[0];
            if(val_9 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "[TouchPadController] OnPress() => touchButton: null, i: "("[TouchPadController] OnPress() => touchButton: null, i: ") + val_8);
        }
        else
        {
                UnityEngine.Vector2 val_6 = UICamera.lastTouchPosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            if(val_3.丄东不且丘丏上与业 != true)
        {
                if((val_9 & 1) != 0)
        {
                return (TouchButton)val_9;
        }
        
        }
        
        }
        
            val_8 = val_8 + 1;
        }
        while(val_1 != val_8);
        
        }
        
        val_9 = 0;
        return (TouchButton)val_9;
    }
    internal bool 丛丁丏丌七不丘上丌(UnityEngine.Vector2 上下丁丕与上业丅丄)
    {
        var val_4;
        List.Enumerator<T> val_1 = this.touchButtons.GetEnumerator();
        label_4:
        if((1320792296 & 1) == 0)
        {
            goto label_2;
        }
        
        if(((0.丐丏七丌丕丗业且上() + 24) & 1) == 0)
        {
            goto label_4;
        }
        
        val_4 = 1;
        goto label_5;
        label_2:
        val_4 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        var val_10;
        东丁世丕万丘丛丙上 val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_26 = this.丗与丛与丕不丕上下;
        丆且上丘世下丅且丞 = 丆且上丘世下丅且丞;
        if(this.丟丈丝下世上世业万 == false)
        {
                return;
        }
        
        bool val_25 = this._isFirstFrame;
        val_25 = val_25 + 3;
        var val_26 = ~val_25;
        val_26 = val_26 & 3;
        if(val_26 != 0)
        {
                return;
        }
        
        val_27 = 1152921505286238208;
        val_28 = null;
        val_28 = null;
        val_26 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_26 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_26 != 0)
        {
                val_29 = null;
            val_29 = null;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  typeof(Player_move_c).__il2cppRuntimeField_668, y:  0);
        }
        
        bool val_3 = 丆且上丘世下丅且丞;
        TouchButton val_4 = this.丙丝三丈业业丞丘不(丆且上丘世下丅且丞:  val_3);
        if(val_3 != false)
        {
                UnityEngine.Vector2 val_5 = UICamera.lastTouchPosition;
            if((this.丄世丙丞七丒丅丑丒 & 1) != 0)
        {
                val_30 = null;
            val_30 = null;
            val_26 = JoystickController.世万丁丆业业丘丘丌.丙三丆丞丝丗丕丒丑(丆且上丘世下丅且丞:  true);
            this.listLeftButtonsPressed.Add(item:  val_26);
        }
        
            this.丙丑丌丘不丈七且七();
            return;
        }
        
        if(this.listLeftButtonsPressed.Count < 1)
        {
            goto label_26;
        }
        
        List.Enumerator<T> val_8 = this.listLeftButtonsPressed.GetEnumerator();
        val_26 = 1152921540287358560;
        val_27 = 1152921540287359584;
        label_37:
        if((1320979328 & 1) == 0)
        {
            goto label_28;
        }
        
        string val_11 = val_10.丐丏七丌丕丗业且上();
        if(val_11 == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Vector2 val_13 = UICamera.lastTouchPosition;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        if(val_11 != null)
        {
            goto label_37;
        }
        
        goto label_37;
        label_28:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.listLeftButtonsPressed.Clear();
        label_26:
        this.丝世上丞丁与丒下丄 = false;
        if(this.丂下与丛东专丄专下 != false)
        {
                this.丂下与丛东专丄专下 = false;
            this.丈丁丒丒丛不七不且 = false;
            this.CancelInvoke(methodName:  "GrenadePressInvoke");
            val_26 = 丁下万丟且丟丛下业.下丁丗丁丅下丆丂丌();
        }
        
        if(this.世丆丛丙不世丄丂丙 != false)
        {
                this.世丆丛丙不世丄丂丙 = false;
            val_26 = mem[val_19 != true ? "grenade_like_btn" : "grenade_btn"];
            val_26 = (GameConnect.东且三丆丑世世丘丟() != true) ? "grenade_like_btn" : "grenade_btn";
            this.grenadeButton.grenadeSprite.spriteName = val_26;
            UnityEngine.Vector2 val_21 = UICamera.lastTouchPosition;
            if((this.丆丏丒丝丁丕丟丘丟 & 1) != 0)
        {
                val_31 = null;
            val_31 = null;
            val_26 = System.EventArgs.Empty;
            HandleBuyGrenadeClicked(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  val_26);
        }
        
        }
        
        this.isShootingPressure = false;
        if(this.丒与世丞丕丗一丆丟 == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_22 = UICamera.lastTouchPosition;
        if((this.丘丛丌东不丆下丂上 & 1) == 0)
        {
                return;
        }
        
        if(this.丝世上丞丁与丒下丄 == true)
        {
                return;
        }
        
        if(this.专一专丙丒丂不一丑 == true)
        {
                return;
        }
        
        GadgetButton val_23 = this.chooseGadgetPanel.gadgetButtonScript;
        if(val_23.yazichok.activeSelf == false)
        {
                return;
        }
        
        this.专一专丙丒丂不一丑 = true;
        this.chooseGadgetPanel.Show();
    }
    private void 丙丄上且一丌三三丐()
    {
        if((this.丂下与丛东专丄专下 != false) && (this.chooseGadgetPanel.CanExtend() != true))
        {
                UnityEngine.Vector2 val_2 = UICamera.lastTouchPosition;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = this.丈七万业且丘丅丟专, y = V9.16B});
            if((UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})) > this.丘下丂丕七下丝丐丑)
        {
                int val_5 = UnityEngine.Input.touchCount;
            if(val_5 < 1)
        {
                return;
        }
        
            var val_8 = 0;
            do
        {
            UnityEngine.Touch val_6 = UnityEngine.Input.GetTouch(index:  0);
            if((this.丏丄东上世丁且丕与 != 1) && (GetHashCode() == this.丏丄东上世丁且丕与))
        {
                if((this.丆丏丒丝丁丕丟丘丟 & 1) != 0)
        {
                this.东一三上专丙七丄专 = true;
            this.丟丁丅业专丈专丒丙 = this.丛七丁东丁丆东丑一;
        }
        else
        {
                this.丂下与丛东专丄专下 = false;
        }
        
        }
        
            val_8 = val_8 + 1;
        }
        while(val_5 != val_8);
        
            return;
        }
        
        }
        
        this.GrenadePressInvoke();
    }
    private void GrenadePressInvoke()
    {
        var val_7;
        var val_8;
        this.丌七丘七万丅丘丟丌 = false;
        this.丝世上丞丁与丒下丄 = false;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                this.grenadeButton.grenadeSprite.spriteName = "grenade_like_btn_n";
            val_7 = null;
            val_7 = null;
            if((1 & 1) == 0)
        {
                return;
        }
        
            this.丂下与丛东专丄专下 = false;
            this.grenadePressed = true;
            return;
        }
        
        bool val_5 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  丁下万丟且丟丛下业.下丁丗丁丅下丆丂丌(), value: out  typeof(Player_move_c).__il2cppRuntimeField_D58);
        val_8 = null;
        val_8 = null;
        if(万丐丘与丙丂丕下丒() == false)
        {
                return;
        }
    
    }
    private void 丘丝丁丙丌上丘七与()
    {
        this.世丆丛丙不世丄丂丙 = true;
        this.grenadeButton.grenadeSprite.spriteName = "grenade_like_btn_n";
    }
    private void OnPressure(float pressure)
    {
        var val_12;
        var val_13;
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌() == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                if(TrainingController.下且丌丑丟丒丒丗丞() == false)
        {
            goto label_35;
        }
        
        }
        
        if((Player_move_c.丗丒丕专丛丆丈万一() != false) && (this.hasAmmo != false))
        {
                val_13 = null;
            val_13 = null;
            WeaponSounds val_10 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            if(val_10.isGrenadeWeapon != true)
        {
                if(与丂丏丛丞丞丒丟丄.丛丗丅丐丌且与丁与() < 0)
        {
                this.isShootingPressure = true;
            return;
        }
        
        }
        
        }
        
        label_35:
        this.isShootingPressure = false;
    }
    private void 与丛与不丝与一丕且(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        var val_7;
        double val_8;
        val_7 = this;
        val_8 = 丞且丅三三东不丄且.y;
        if(this.丟丈丝下世上世业万 != false)
        {
                this.业丗七丕万万不丈丗 = 0;
            val_7 = ???;
            val_8 = ???;
        }
        else
        {
                val_7 + 48.丕丑丕丒丌丕一丌丗();
        }
    
    }
    private void OnDestroy()
    {
        ChooseGadgetPanel.七丘万丂丕与专丝且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TouchPadController::丟一丌丅世丆丈丞七()));
        东丟丟万下丛丆丛丟.丏丈丐业丘丏万东下(丙业与丙丗丝不丈东:  new System.Action<ModuleGadgetRecord>(object:  this, method:  System.Void TouchPadController::丁三丂上上世丂丕丅(ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专)));
    }
    internal UnityEngine.Vector2 丟与丁丛万与三丄丞()
    {
        if(this.丗与丛与丕不丕上下 != null)
        {
                return this.丗与丛与丕不丕上下.专与万不与丅丁丝上();
        }
        
        return this.丗与丛与丕不丕上下.专与万不与丅丁丝上();
    }
    public UnityEngine.Vector2 GrabDeltaPosition()
    {
        东丁世丕万丘丛丙上 val_3;
        float val_6;
        float val_7;
        val_3 = this;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        val_6 = val_1.x;
        val_7 = val_1.y;
        if(this.丗与丛与丕不丕上下 == null)
        {
                return new UnityEngine.Vector2() {x = val_6, y = val_7};
        }
        
        UnityEngine.Vector2 val_2 = this.丗与丛与丕不丕上下.专与万不与丅丁丝上();
        val_3 = this.丗与丛与丕不丕上下;
        val_6 = val_2.x;
        val_7 = val_2.y;
        val_3.丕丑丕丒丌丕一丌丗();
        return new UnityEngine.Vector2() {x = val_6, y = val_7};
    }
    public void ApplyDeltaTo(UnityEngine.Vector2 一丟丂三丌丆与丟一, UnityEngine.Transform 丒一丘三丞与丟七三, UnityEngine.Transform 丙三万丙与丟丏丆丐, float 世专专丙世丒上丁丌, bool 丝业丈不丙丄丝一一)
    {
        if(this.丗与丛与丕不丕上下 == null)
        {
                return;
        }
        
        bool val_1 = 丝业丈不丙丄丝一一;
        goto typeof(东丁世丕万丘丛丙上).__il2cppRuntimeField_1A8;
    }
    public void OnDisable()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void TouchPadController::丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
        this.isShootingPressure = false;
        this.丅七下业丙上丘上丝 = 0;
        this.不丑丞世且不丂丐丘 = 0;
        this.丏丄东上世丁且丕与 = 0;
        if(this.专一专丙丒丂不一丑 != false)
        {
                this.丛丆世丞丘丟且丂不();
            this.丝世丝且一丟丄丆业 = false;
        }
        
        this.grenadePressed = false;
        this.丂下与丛东专丄专下 = false;
        this.丈丁丒丒丛不七不且 = false;
        this.东一三上专丙七丄专 = false;
    }
    private void 不上丂丂一丝丘丌丗()
    {
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        this.touchButtons.Add(item:  InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class + 136);
    }
    public TouchPadController()
    {
        this.丛七丁东丁丆东丑一 = 0.1f;
        this._isFirstFrame = true;
        this.丟丈丝下世上世业万 = true;
        this.七丆三一丛万丁丕万 = 0;
        this.且丌不业下丌且东专 = new System.Collections.Generic.List<GadgetCategory>(capacity:  3);
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.丏业业业丈丘一丘丒 = val_2;
        mem[1152921540289212996] = val_2.y;
        this.丞世丌东且丁下丅上 = -1f;
        this.世丞与丙丅丂上下丒 = -1f;
        float val_14 = (float)UnityEngine.Screen.height;
        val_14 = val_14 * 0.0001f;
        val_14 = val_14 * (float)UnityEngine.Screen.height;
        this.丏丄东上世丁且丕与 = 0;
        this.上业七丑丏丈丄丐丗 = 2;
        this.丛丕丑三丒业万丙丈 = 0.045f;
        this.丘下丂丕七下丝丐丑 = val_14;
        this.hasAmmo = true;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        this.丛一丒丝丒丕世下下 = val_5;
        mem[1152921540289213212] = val_5.y;
        mem2[0] = ;
        this.下丛丛丏丞丁丂丕丗 = 0.05f;
        mem2[0] = ;
        this.且丙世丛丕丐丛丝一 = 0.3f;
        this.丅七下业丙上丘上丝 = 0;
        this.不丑丞世且不丂丐丘 = 0;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
        this.与世丞丕世丄七丙丈 = val_6;
        mem[1152921540289213292] = val_6.y;
        UnityEngine.Vector2[] val_7 = new UnityEngine.Vector2[4];
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
        val_7[0] = val_8;
        val_7[0] = val_8.y;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        val_7[1] = val_9;
        val_7[1] = val_9.y;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        val_7[2] = val_10;
        val_7[2] = val_10.y;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
        val_7[3] = val_11;
        val_7[3] = val_11.y;
        this.丂且丛与丆丝东丂专 = val_7;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        this.一丏丞上一丏丌丕丗 = val_12;
        mem[1152921540289213308] = val_12.y;
        this.listLeftButtonsPressed = new System.Collections.Generic.List<TouchButton>();
        this.丑丗丘与丈不七东丛 = -1f;
    }
    private static TouchPadController()
    {
        TouchPadController.三丆丁丞与丘丄七丞 = 70;
        TouchPadController.丑丅丂丒且丅专丑丟 = 0.5f;
        TouchPadController.七丄丟丐丅丆丞丝与 = false;
        TouchPadController.业丌丝丝不专丙丄丁 = false;
    }

}
