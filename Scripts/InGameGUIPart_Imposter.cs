using UnityEngine;
public class InGameGUIPart_Imposter : InGameGUIPartContainer
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    public static InGameGUIPart_Imposter instance;
    public MiniMapController miniMap;
    public UnityEngine.GameObject pointCaptureBar;
    public UISprite captureBarSprite;
    public UILabel pointCaptureName;
    public UnityEngine.GameObject mainTaskBar;
    public UISprite mainTaskBarSprite;
    public ImposterModeTasksUI tasksUI;
    public UILabel myPlayerTaskCount;
    public UILabel crewmenTasksCount;
    public UnityEngine.GameObject sabotageButtons;
    public SabotageButtonUI reactorSabotageButton;
    public SabotageButtonUI oxygenSabotageButton;
    public System.Collections.Generic.List<SabotageDoorButtonUI> doorsSabotageButtons;
    public PlayGadgetSFX sabotageSFX;
    public PlayGadgetSFX youAreImposter;
    public PlayGadgetSFX youAreCrewman;
    public PlayGadgetSFX deadSFX;
    public PlayGadgetSFX taskComplete;
    public UITextureMasked deadMyPlayerAvatar;
    public UITextureMasked deadKillerAvatar;
    public UISprite deadMyPlayerBG;
    public UISprite deadKillerBG;
    public UnityEngine.GameObject imposterMiniMapTip;
    private System.Collections.Generic.Dictionary<PlayerTaskImposterMode.丌不丕丁丁东且丈丑, TaskUIImposterModeAbstract> 丕专专丁丏丝丟与丌;
    private TaskUIImposterModeAbstract 丐专丏万丞丞七丅与;
    private bool 丝丒一丏丟丙专丏丈;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丙下丆与丁丘丙丕丙 = this;
    }
    private void Start()
    {
        null = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.上专世丙丄丄丅万丟();
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.丘上丐世丆丑且丞丒();
        this.丐丁东丈丈三丌丗丝();
    }
    internal void 东上业与丐丝丁万丛(PlayerTaskImposterMode 万不且且丛丆东丒业)
    {
        System.Collections.Generic.Dictionary<丌不丕丁丁东且丈丑, TaskUIImposterModeAbstract> val_14;
        if((this.丕专专丁丏丝丟与丌.ContainsKey(key:  万不且且丛丆东丒业.taskType)) != true)
        {
                TaskUIImposterModeAbstract val_5 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<TaskUIImposterModeAbstract>(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<TaskUIImposterModeAbstract>(path:  System.String.Format(format:  "NguiWindows/ImposterModeUI/IM_Task{0}UI", arg0:  万不且且丛丆东丒业.taskType)), 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_5 != 0)
        {
                this.丕专专丁丏丝丟与丌.set_Item(key:  万不且且丛丆东丒业.taskType, value:  val_5);
        }
        
        }
        
        val_14 = this.丕专专丁丏丝丟与丌;
        if((val_14.ContainsKey(key:  万不且且丛丆东丒业.taskType)) == false)
        {
                return;
        }
        
        TaskUIImposterModeAbstract val_8 = this.丕专专丁丏丝丟与丌.Item[万不且且丛丆东丒业.taskType];
        this.丐专丏万丞丞七丅与 = val_8;
        val_8.东上业与丐丝丁万丛(万不且且丛丆东丒业:  万不且且丛丆东丒业);
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        System.Action val_11 = null;
        val_14 = val_11;
        val_11 = new System.Action(object:  this, method:  public System.Void InGameGUIPart_Imposter::CloseTaskUI());
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_11, 与且专丈不万东一万:  this.丐专丏万丞丞七丅与.name);
    }
    public void CloseTaskUI()
    {
        var val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丐专丏万丞丞七丅与, 丏业丟一东丂东丘丛:  false);
        val_2 = null;
        val_2 = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.三东三丐下丅丐一万();
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnDisable()
    {
        var val_2 = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.三东三丐下丅丐一万();
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnDestroy()
    {
        var val_2 = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.三东三丐下丅丐一万();
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    internal void 下丐丗丆一上万与丌()
    {
        var val_19;
        UnityEngine.Object val_20;
        UnityEngine.Texture val_21;
        var val_22;
        var val_23;
        UnityEngine.Object val_24;
        UnityEngine.Texture val_25;
        var val_26;
        InGameGUIPart_Imposter.丂丄丕业东丆丄三三 val_1 = new InGameGUIPart_Imposter.丂丄丕业东丆丄三三();
        this.CloseTaskUI();
        this.deadSFX.Play();
        val_19 = null;
        val_19 = null;
        if(val_1 != null)
        {
                val_20 = val_1;
            .丗丁丒三丐丞丏万下 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        }
        else
        {
                val_20 = 16;
            mem[16] = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        }
        
        bool val_2 = UnityEngine.Object.op_Inequality(x:  val_20, y:  0);
        UnityEngine.GameObject val_3 = this.deadMyPlayerAvatar.gameObject;
        if(val_3 == null)
        {
            goto label_10;
        }
        
        if(val_2 == false)
        {
            goto label_11;
        }
        
        label_17:
        val_3.SetActive(value:  true);
        PGCompany.丌丙丈丕丛丆丝丗丟 val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丙丈丕丛丆丝丗丟>(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  万丑一东丅上丗一东());
        if(val_6 == null)
        {
            goto label_15;
        }
        
        val_21 = val_6;
        goto label_16;
        label_10:
        if(val_2 == true)
        {
            goto label_17;
        }
        
        label_11:
        val_3.SetActive(value:  false);
        goto label_18;
        label_15:
        val_21 = 0;
        label_16:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.deadMyPlayerAvatar, 与万丆丛丒万丝丙丑:  val_21);
        val_22 = null;
        val_22 = null;
        System.ValueTuple<System.String, UnityEngine.Color32> val_8 = System.Linq.Enumerable.FirstOrDefault<System.ValueTuple<System.String, UnityEngine.Color32>>(source:  ImposterModeController.丟丟丄且丄丞与丑丘, predicate:  new System.Func<System.ValueTuple<System.String, UnityEngine.Color32>, System.Boolean>(object:  val_1, method:  System.Boolean InGameGUIPart_Imposter.丂丄丕业东丆丄三三::万丒丅业丘丗丝专七(System.ValueTuple<string, UnityEngine.Color32> 三丟东丕丄丄下下丑)));
        UnityEngine.Color val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 16, g = 91, b = 254, a = 203});
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.deadMyPlayerBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
        label_18:
        val_23 = null;
        val_23 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_26;
        }
        
        }
        
        label_26:
        var val_10 = (null == null) ? GameController.onlineMode : 0;
        if(val_1 != null)
        {
                val_24 = val_1;
            .丆丝专专丟丟丈丏丐 = onlineMode == null ? GameController.onlineMode : 0 + 608;
        }
        else
        {
                val_24 = 24;
            mem[24] = onlineMode == null ? GameController.onlineMode : 0 + 608;
        }
        
        bool val_11 = UnityEngine.Object.op_Inequality(x:  val_24, y:  0);
        UnityEngine.GameObject val_12 = this.deadKillerAvatar.gameObject;
        if(val_12 == null)
        {
            goto label_32;
        }
        
        if(val_11 == false)
        {
            goto label_33;
        }
        
        label_39:
        val_12.SetActive(value:  true);
        PGCompany.丌丙丈丕丛丆丝丗丟 val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丙丈丕丛丆丝丗丟>(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  mem[24].万丑一东丅上丗一东());
        if(val_15 == null)
        {
            goto label_37;
        }
        
        val_25 = val_15;
        goto label_38;
        label_32:
        if(val_11 == true)
        {
            goto label_39;
        }
        
        label_33:
        val_12.SetActive(value:  false);
        return;
        label_37:
        val_25 = 0;
        label_38:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.deadKillerAvatar, 与万丆丛丒万丝丙丑:  val_25);
        val_26 = null;
        val_26 = null;
        System.ValueTuple<System.String, UnityEngine.Color32> val_17 = System.Linq.Enumerable.FirstOrDefault<System.ValueTuple<System.String, UnityEngine.Color32>>(source:  ImposterModeController.丟丟丄且丄丞与丑丘, predicate:  new System.Func<System.ValueTuple<System.String, UnityEngine.Color32>, System.Boolean>(object:  val_1, method:  System.Boolean InGameGUIPart_Imposter.丂丄丕业东丆丄三三::万三丂丐丌与与丑不(System.ValueTuple<string, UnityEngine.Color32> 三丟东丕丄丄下下丑)));
        UnityEngine.Color val_18 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 16, g = 219, b = 254, a = 203});
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.deadKillerBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a});
    }
    public void ShowWorldMap(bool 丛与丙丒丒下丌丟且)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        if(丛与丙丒丒下丌丟且 != false)
        {
                this.丝丒一丏丟丙专丏丈 = this.tasksUI.tasksToggleUI.上丘丛业与专丌丟丐();
            this.tasksUI.tasksToggleUI.Hide();
            val_5 = null;
            val_5 = null;
            val_6 = JoystickController.丘万丏三丏丑世丐丏.gameObject;
            val_7 = 0;
        }
        else
        {
                if(this.丝丒一丏丟丙专丏丈 != false)
        {
                this.tasksUI.tasksToggleUI.Show();
        }
        
            val_8 = null;
            val_8 = null;
            val_6 = JoystickController.丘万丏三丏丑世丐丏.gameObject;
            val_7 = 1;
        }
        
        val_6.SetActive(value:  true);
    }
    private void 丐丁东丈丈三丌丗丝()
    {
        null = null;
        if(丟东丘丏上世且上丕() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.imposterMiniMapTip, 丏业丟一东丂东丘丛:  true);
    }
    public bool CheckTapOnSabotageButton(UnityEngine.Vector3 丙一与世丈专丅三三)
    {
        if((this.oxygenSabotageButton.一丁且上丛丛丐下丛(一丁丂东丏丙上丟且:  new UnityEngine.Vector3() {x = 丙一与世丈专丅三三.x, y = 丙一与世丈专丅三三.y, z = 丙一与世丈专丅三三.z})) == true)
        {
                return true;
        }
        
        if((this.reactorSabotageButton.一丁且上丛丛丐下丛(一丁丂东丏丙上丟且:  new UnityEngine.Vector3() {x = 丙一与世丈专丅三三.x, y = 丙一与世丈专丅三三.y, z = 丙一与世丈专丅三三.z})) != true)
        {
                var val_6 = 0;
            do
        {
            if(val_6 >= this.doorsSabotageButtons.Count)
        {
                return true;
        }
        
            val_6 = val_6 + 1;
        }
        while((this.doorsSabotageButtons.Item[0].一丁且上丛丛丐下丛(一丁丂东丏丙上丟且:  new UnityEngine.Vector3() {x = 丙一与世丈专丅三三.x, y = 丙一与世丈专丅三三.y, z = 丙一与世丈专丅三三.z})) == false);
        
        }
        
        return true;
    }
    public InGameGUIPart_Imposter()
    {
        this.丕专专丁丏丝丟与丌 = new System.Collections.Generic.Dictionary<丌不丕丁丁东且丈丑, TaskUIImposterModeAbstract>();
    }

}
