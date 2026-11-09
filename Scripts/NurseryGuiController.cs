using UnityEngine;
public class NurseryGuiController : MonoBehaviour
{
    // Fields
    private const float 万丄丕丛丞不三业丐 = 12;
    private static NurseryGuiController 丏丐丛丏丘东丛且丕;
    private static System.Collections.Generic.List<UnityEngine.Camera> 丟丌丞万丕万丐丐上;
    private static bool 专丏丄丙一一丆丌三;
    private static bool 下丙丟且丕丆丌东业;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private ShopItemsRowContainer[] 上丟丞且丞丏丑上丏;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private System.Collections.Generic.List<丙且上东下丏丏丟下> 万丕丛丝丑丗下丁丘;
    private System.Nullable<UnityEngine.Color> 与丕专丛世丛丅丒东;
    private System.Nullable<bool> 专丆丐丙丒丌七东丙;
    private bool 丄且丆丛丗丆丗丙丙;
    public UnityEngine.GameObject ActiveObject;
    private UIRoot armory;
    private UISprite backButtonBackground;
    public Rilisoft.BankShopViewGuiElement bankShopView;
    public UnityEngine.Transform bottomPointForShader;
    public UnityEngine.Transform topPointForShader;
    public UnityEngine.GameObject buttonsEggPanel;
    public UnityEngine.GameObject buttonsPanel;
    public MyCenterOnChild carouselCenter;
    public EggInfoController eggInfo;
    public FifthEggController fifthEggController;
    private bool 丄丐丄专上下丞万丙;
    private bool 丄丈且丂丕丐丅丐七;
    public FixedSlider fixedSlider;
    public UIScrollView gridScrollView;
    public EggIncubatorManager incubatorManager;
    private bool 丟丆丕业丌丂丂且专;
    public UIGrid itemsGrid;
    public UIWrapContent itemsWrapContainer;
    public System.Collections.Generic.List<string> listToSHowEffect;
    public UnityEngine.GameObject loadingDataIndication;
    private 丙且上东下丏丏丟下 且丛丌丌七丈丝丒丈;
    private 丙且上东下丏丏丟下 专丑下东丙丞丏七丄;
    public System.Collections.Generic.List<UnityEngine.Light> mylights;
    private float otherWidth;
    public PetInfoController petInfo;
    public UnityEngine.GameObject petShadow;
    public UnityEngine.Transform rentScreenPoint;
    private UISlider slider;
    private float 丙丗丅上三三与丑丙;
    public NurseryTrainingController trainingController;
    private float 丏丗一不一丒七与专;
    public UIGrid wrapContent;
    
    // Properties
    public UIRoot 丗丝丛丆丆丘专下丕 { get; }
    internal static bool 丄专丐丂丈丘丆丌丏 { get; }
    internal static bool 丐丆万丟丛丟且上上 { get; }
    internal static bool 与业一丅丗业业三丁 { get; }
    public 丙且上东下丏丏丟下 与丛专丁一不丟丒丐 { get; set; }
    internal static NurseryGuiController 丌丛丟丁丏丌且丛且 { get; }
    internal static bool 下丐丙专丕丙丗万丕 { get; set; }
    public System.Collections.Generic.List<BaseArmoryCell> 丐丙丘世丗丏丒七丙 { get; }
    
    // Methods
    public UIRoot get_UiRoot()
    {
        return (UIRoot)this.armory;
    }
    internal static bool 丙丌不七丁与世上下()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        val_8 = 1152921505061052416;
        if(与丂丏丛丞丞丒丟丄.世丕丒上丟丆专丌丅 != 1)
        {
                val_9 = null;
            val_8 = ExperienceController.丞丞丘业东丙丏七丌();
            val_9 = null;
            var val_2 = (val_8 >= 与丂丏丛丞丞丒丟丄.世丕丒上丟丆专丌丅) ? 1 : 0;
            return (bool)(ExperienceController.丞丞丘业东丙丏七丌() > 2) ? 1 : 0;
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() < 2)
        {
                return (bool)(ExperienceController.丞丞丘业东丙丏七丌() > 2) ? 1 : 0;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  "CountMatchAfterTraining", defaultValue:  0)) <= 0)
        {
                return (bool)(ExperienceController.丞丞丘业东丙丏七丌() > 2) ? 1 : 0;
        }
        
        val_10 = 1;
        return (bool)(ExperienceController.丞丞丘业东丙丏七丌() > 2) ? 1 : 0;
    }
    internal static bool 与不丞丁丟丅业丁丟()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.世丕丒上丟丆专丌丅 != 1)
        {
                val_6 = 1;
            return (bool)(ExperienceController.丞丞丘业东丙丏七丌() > val_6) ? 1 : 0;
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() >= 2)
        {
                if((UnityEngine.PlayerPrefs.GetInt(key:  "CountMatchAfterTraining", defaultValue:  0)) > 0)
        {
                val_7 = 1;
            return (bool)(ExperienceController.丞丞丘业东丙丏七丌() > val_6) ? 1 : 0;
        }
        
        }
        
        val_6 = 2;
        return (bool)(ExperienceController.丞丞丘业东丙丏七丌() > val_6) ? 1 : 0;
    }
    internal static bool 丕丛丗丒三丛七丁丌()
    {
        return (bool)(NurseryTrainingController.丁丏丒专一丄丏丙七() == 6) ? 1 : 0;
    }
    public 丙且上东下丏丏丟下 get_CurrentItem()
    {
        return (丙且上东下丏丏丟下)this.且丛丌丌七丈丝丒丈;
    }
    private void 与世丙与丅丕丏丈丕(丙且上东下丏丏丟下 丙业与丙丗丝不丈东)
    {
        this.且丛丌丌七丈丝丒丈 = 丙业与丙丗丝不丈东;
    }
    internal static NurseryGuiController 且丕丈丙丛不业丂丗()
    {
        null = null;
        return (NurseryGuiController)NurseryGuiController.丏丐丛丏丘东丛且丕;
    }
    internal static bool 丛世丛与丌不丈丐丐()
    {
        if(NurseryGuiController.且丕丈丙丛不业丂丗() == 0)
        {
                return false;
        }
        
        NurseryGuiController val_3 = NurseryGuiController.且丕丈丙丛不业丂丗();
        if(val_3.ActiveObject != null)
        {
                return val_3.ActiveObject.activeInHierarchy;
        }
        
        return val_3.ActiveObject.activeInHierarchy;
    }
    internal static void 丘丏丑丕丙东丗丏下(bool 丙业与丙丗丝不丈东)
    {
        object val_64;
        bool val_73;
        var val_74;
        object val_76;
        System.Collections.IEnumerator val_77;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        val_73 = 丙业与丙丗丝不丈东;
        bool val_1 = NurseryGuiController.丛世丛与丌不丈丐丐();
        NurseryGuiController.且丕丈丙丛不业丂丗().SetOtherCamerasEnabled(丗丛不丁丑专专丂且:  (~val_73) & 1);
        NurseryGuiController val_4 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_4.ActiveObject.SetActive(value:  val_73);
        NurseryGuiController val_6 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_6.eggInfo.gameObject.SetActive(value:  false);
        NurseryGuiController val_8 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_8.petInfo.gameObject.SetActive(value:  false);
        NurseryGuiController val_10 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_10.buttonsPanel.gameObject.SetActive(value:  false);
        NurseryGuiController val_12 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_12.buttonsEggPanel.gameObject.SetActive(value:  false);
        if(val_73 != false)
        {
                NurseryGuiController val_14 = NurseryGuiController.且丕丈丙丛不业丂丗();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14.loadingDataIndication, 丏业丟一东丂东丘丛:  false);
            val_74 = null;
            val_74 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
            NurseryGuiController val_15 = NurseryGuiController.且丕丈丙丛不业丂丗();
            val_15.丙丗丅上三三与丑丙 = UnityEngine.Time.realtimeSinceStartup;
        }
        
        if(NurseryGuiController.且丕丈丙丛不业丂丗() == 0)
        {
            goto label_127;
        }
        
        if(val_73 == false)
        {
            goto label_33;
        }
        
        NurseryGuiController val_19 = NurseryGuiController.且丕丈丙丛不业丂丗();
        if(val_19.且丂七丑丈丞丈三丑 == null)
        {
                NurseryGuiController val_20 = NurseryGuiController.且丕丈丙丛不业丂丗();
            val_76 = NurseryGuiController.且丕丈丙丛不业丂丗();
            val_20.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  val_76, method:  public System.Void NurseryGuiController::CloseNursery()), 与且专丈不万东一万:  "CloseNursery");
        }
        
        NurseryGuiController.且丕丈丙丛不业丂丗().不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  0, 丕丝丟下丗丛一丕业:  true);
        NurseryGuiController.且丕丈丙丛不业丂丗().三丈世丌丄不丈上不();
        NurseryGuiController val_27 = NurseryGuiController.且丕丈丙丛不业丂丗();
        if(val_27.slider != 0)
        {
                NurseryGuiController val_29 = NurseryGuiController.且丕丈丙丛不业丂丗();
            val_29.slider.value = 0f;
        }
        
        NurseryGuiController.且丐丛专与三且万且();
        val_77 = 1152921505237143552;
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 3)
        {
                if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 4)
        {
            goto label_66;
        }
        
        }
        
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() == 6)
        {
                NurseryGuiController val_33 = NurseryGuiController.且丕丈丙丛不业丂丗();
            val_33.trainingController.UpdateTrainingStep(丒且丆丘丞丑业丅不:  3);
        }
        
        label_66:
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
                if(NurseryTrainingController.丁丏丒专一丄丏丙七() == 6)
        {
                val_77 = NurseryGuiController.且丕丈丙丛不业丂丗().丏丕业丈丏万丅丂且();
            UnityEngine.Coroutine val_39 = NurseryGuiController.且丕丈丙丛不业丂丗().StartCoroutine(routine:  val_77);
        }
        
        }
        
        NurseryGuiController val_40 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_40.eggInfo.CheckFifthEgg();
        goto label_127;
        label_33:
        NurseryGuiController.且丕丈丙丛不业丂丗().StopCoroutine(routine:  NurseryGuiController.且丕丈丙丛不业丂丗().丏丕业丈丏万丅丂且());
        NurseryGuiController val_44 = NurseryGuiController.且丕丈丙丛不业丂丗();
        if(val_44.且丂七丑丈丞丈三丑 != null)
        {
                NurseryGuiController val_45 = NurseryGuiController.且丕丈丙丛不业丂丗();
            var val_72 = 0;
            val_72 = val_72 + 1;
            val_45.且丂七丑丈丞丈三丑.Dispose();
            NurseryGuiController val_47 = NurseryGuiController.且丕丈丙丛不业丂丗();
            val_47.且丂七丑丈丞丈三丑 = 0;
        }
        
        InfoWindowController.一丘丕上丈一丂丐丌();
        NurseryGuiController val_48 = NurseryGuiController.且丕丈丙丛不业丂丗();
        if(val_48.与丕专丛世丛丅丒东.HasValue != false)
        {
            
        }
        else
        {
                UnityEngine.Color val_50 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_50.r, g = val_50.g, b = val_50.b, a = val_50.a});
        NurseryGuiController val_51 = NurseryGuiController.且丕丈丙丛不业丂丗();
        if(((-507549716) & 1) != 0)
        {
                bool val_52 = val_51.专丆丐丙丒丌七东丙.GetValueOrDefault();
        }
        else
        {
                val_79 = 0;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙());
        NurseryGuiController val_55 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_55.ActiveObject.SetActive(value:  false);
        val_77 = 1152921505080860672;
        val_80 = null;
        val_80 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_81 = null;
            val_81 = null;
            MainMenuController.丄丞丁丈与业上丞丟.UpdateTutorialHints();
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
        {
                val_82 = null;
            val_82 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        label_127:
        System.Collections.Generic.List<TSource> val_61 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  NurseryGuiController.且丕丈丙丛不业丂丗().gameObject.GetComponentsInChildren<UnityEngine.Camera>(includeInactive:  true));
        if(val_61 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_62 = val_61.GetEnumerator();
        val_76 = 1152921524440492608;
        label_144:
        if(((-507549744) & 1) == 0)
        {
            goto label_136;
        }
        
        string val_65 = val_64.丐丏七丌丕丗业且上();
        val_65.enabled = val_73;
        if((val_65.GetComponent<UICamera>()) == 0)
        {
            goto label_144;
        }
        
        val_65.GetComponent<UICamera>().enabled = val_73;
        goto label_144;
        label_136:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public System.Collections.Generic.List<BaseArmoryCell> get_AllSecondGridArmoryCells()
    {
        var val_4;
        System.Func<BaseArmoryCell, System.String> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = NurseryGuiController.<>c.<>9__62_0;
        if(val_6 != null)
        {
                return System.Linq.Enumerable.ToList<BaseArmoryCell>(source:  System.Linq.Enumerable.OrderBy<BaseArmoryCell, System.String>(source:  this.GetAllArmoryCellsInWrapContainer<BaseArmoryCell>(丟丝七七一丁丏丏丙:  true), keySelector:  System.Func<BaseArmoryCell, System.String> val_2 = null));
        }
        
        val_6 = val_2;
        val_2 = new System.Func<BaseArmoryCell, System.String>(object:  NurseryGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.String NurseryGuiController.<>c::丏丄丗一上丐丈且专(BaseArmoryCell 丌丝万上丅丒一丈丘));
        NurseryGuiController.<>c.<>9__62_0 = val_6;
        return System.Linq.Enumerable.ToList<BaseArmoryCell>(source:  System.Linq.Enumerable.OrderBy<BaseArmoryCell, System.String>(source:  this.GetAllArmoryCellsInWrapContainer<BaseArmoryCell>(丟丝七七一丁丏丏丙:  true), keySelector:  val_2));
    }
    public float GetGridSize()
    {
        return (float)this.丏丗一不一丒七与专;
    }
    public void UpdateIncubators()
    {
        this.incubatorManager.UpdateEggs();
    }
    private System.Collections.IEnumerator 丅东业丈丝不丙丐七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NurseryGuiController.丒丁东丌与丈丁万万();
    }
    private static void 且丐丛专与三且万且()
    {
        NurseryGuiController val_1 = NurseryGuiController.且丕丈丙丛不业丂丗();
        UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        mem2[0] = 0;
        val_1.与丕专丛世丛丅丒东 = 0;
        NurseryGuiController val_3 = NurseryGuiController.且丕丈丙丛不业丂丗();
        bool val_5 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        val_3.专丆丐丙丒丌七东丙 = 0;
        UnityEngine.Color val_6 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
    }
    private void OnEnable()
    {
        this.buttonsPanel.SetActive(value:  false);
        this.buttonsEggPanel.SetActive(value:  false);
        this.petShadow.SetActive(value:  false);
        this.fifthEggController.UpdateEgg();
    }
    private void 三丈世丌丄不丈上不()
    {
        var val_15;
        UnityEngine.Light val_16;
        var val_17;
        UnityEngine.Light val_18;
        var val_19;
        val_15 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Light>();
        if(val_15 == null)
        {
                val_16 = 0;
            val_15 = new UnityEngine.Light[0];
        }
        
        val_17 = 0;
        goto label_4;
        label_13:
        val_18 = val_15[0];
        val_16 = val_18;
        if((this.mylights.Contains(item:  val_16)) != true)
        {
                int val_4 = val_18.cullingMask;
            string val_14 = "NGUIShop";
            int val_5 = UnityEngine.LayerMask.NameToLayer(layerName:  val_14);
            if(val_18 != null)
        {
                val_14 = val_5 & 31;
            val_14 = 1 << val_14;
            val_18.cullingMask = val_4 & (~val_14);
        }
        else
        {
                val_14 = val_5 & 31;
            val_14 = 1 << val_14;
            0.cullingMask = val_4 & (~val_14);
        }
        
            string val_15 = "NGUIShopWorld";
            val_15 = (UnityEngine.LayerMask.NameToLayer(layerName:  val_15)) & 31;
            val_15 = 1 << val_15;
            val_16 = val_18.cullingMask & (~val_15);
            val_18.cullingMask = val_16;
        }
        
        val_17 = 1;
        label_4:
        if(val_17 < val_2.Length)
        {
            goto label_13;
        }
        
        val_19 = null;
        val_19 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_18 = 1152921505175109632;
            if(ExpController.丑七不且上丗丁一世() != 0)
        {
                ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        this.fifthEggController.SetState(丆丟专丑丁丒丁上丙:  true);
    }
    public void SetOtherCamerasEnabled(bool 丗丛不丁丑专专丂且)
    {
        bool val_3;
        var val_52;
        var val_54;
        var val_55;
        bool val_56;
        System.Collections.Generic.IEnumerable<T> val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        if(丗丛不丁丑专专丂且 == false)
        {
            goto label_1;
        }
        
        val_52 = null;
        val_52 = null;
        List.Enumerator<T> val_1 = NurseryGuiController.丟丌丞万丕万丐丐上.GetEnumerator();
        val_54 = 1152921524440491584;
        val_55 = 1152921504848912384;
        label_15:
        if(((-505829424) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_15;
        }
        
        val_4.enabled = true;
        UICamera val_6 = val_4.GetComponent<UICamera>();
        if(val_6 == 0)
        {
            goto label_15;
        }
        
        val_6.enabled = true;
        goto label_15;
        label_1:
        if(UnityEngine.Camera.allCameras != null)
        {
                val_56 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  UnityEngine.Camera.allCameras);
        }
        else
        {
                System.Collections.Generic.List<UnityEngine.Camera> val_11 = null;
            val_56 = val_11;
            val_11 = new System.Collections.Generic.List<UnityEngine.Camera>();
        }
        
        bool val_12 = 丗丛不丁丑专专丂且;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(ProfileController.丑七不且上丗丁一世() == 0)
        {
                object[] val_16 = new object[1];
            val_3 = val_12;
            val_16[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCamerasEnabled({0}): ProfileController.Instance == null", args:  val_16);
        }
        
        }
        
        if(ProfileController.丑七不且上丗丁一世() == 0)
        {
            goto label_36;
        }
        
        val_57 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  ProfileController.丑七不且上丗丁一世().GetComponentsInChildren<UnityEngine.Camera>(includeInactive:  true));
        if(val_56 != null)
        {
            goto label_42;
        }
        
        goto label_41;
        label_36:
        System.Collections.Generic.List<UnityEngine.Camera> val_22 = null;
        val_57 = val_22;
        val_22 = new System.Collections.Generic.List<UnityEngine.Camera>();
        if(val_56 != null)
        {
            goto label_42;
        }
        
        label_41:
        label_42:
        val_11.AddRange(collection:  val_22);
        System.Collections.Generic.List<UnityEngine.Camera> val_23 = NurseryGuiController.且不下丙丛丛丄丈东();
        if(val_56 != null)
        {
                val_11.AddRange(collection:  val_23);
        }
        else
        {
                val_11.AddRange(collection:  val_23);
        }
        
        List.Enumerator<T> val_24 = val_11.GetEnumerator();
        val_58 = 1152921505719563712;
        val_55 = 1152921505175109632;
        val_59 = 1152921505261211648;
        label_129:
        if(((-505829424) & 1) == 0)
        {
            goto label_47;
        }
        
        string val_25 = val_3.丐丏七丌丕丗业且上();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(val_25 == 0)
        {
                object[] val_28 = new object[1];
            val_3 = val_12;
            val_28[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCamerasEnabled({0}): c == null", args:  val_28);
            val_60 = val_58;
            val_59 = val_59;
        }
        
        }
        
        if(val_25 == 0)
        {
            goto label_129;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if((ExpController.丑七不且上丗丁一世().丙上世与丁丙丘丞丗(丁丂专业丁丅丅丈丙:  val_25)) == true)
        {
            goto label_129;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(val_25.gameObject == 0)
        {
                object[] val_37 = new object[1];
            val_3 = val_12;
            val_37[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCamerasEnabled({0}): c.gameObject == null", args:  val_37);
            val_60 = val_60;
            val_59 = val_59;
        }
        
        }
        
        if(val_25.gameObject != 0)
        {
                if((val_25.gameObject.CompareTag(tag:  "CamTemp")) == true)
        {
            goto label_129;
        }
        
        }
        
        val_61 = null;
        if((Contains(item:  val_25)) == true)
        {
            goto label_129;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
                object[] val_46 = new object[1];
            val_3 = val_12;
            val_46[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCamerasEnabled({0}): InfoWindowController.Instance == null", args:  val_46);
        }
        
        }
        
        if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
            goto label_115;
        }
        
        InfoWindowController val_49 = InfoWindowController.丑七不且上丗丁一世();
        if(val_49.infoWindowCamera == val_25)
        {
            goto label_129;
        }
        
        label_115:
        val_62 = null;
        val_62 = null;
        NurseryGuiController.丟丌丞万丕万丐丐上.Add(item:  val_25);
        val_25.enabled = false;
        UICamera val_50 = val_25.GetComponent<UICamera>();
        if(val_50 == 0)
        {
            goto label_129;
        }
        
        val_50.enabled = false;
        goto label_129;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_169;
        label_47:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_169:
        System.Collections.Generic.List<T>._emptyArray.__il2cppRuntimeField_8.Clear();
    }
    private static System.Collections.Generic.List<UnityEngine.Camera> 且不下丙丛丛丄丈东()
    {
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  BankController.丑七不且上丗丁一世().GetComponentsInChildren<UnityEngine.Camera>(includeInactive:  true));
        if(FreeAwardController.丑七不且上丗丁一世() == 0)
        {
                return (System.Collections.Generic.List<UnityEngine.Camera>)val_3;
        }
        
        FreeAwardController val_6 = FreeAwardController.丑七不且上丗丁一世();
        if(val_6.renderCamera == 0)
        {
                return (System.Collections.Generic.List<UnityEngine.Camera>)val_3;
        }
        
        FreeAwardController val_8 = FreeAwardController.丑七不且上丗丁一世();
        val_3.Add(item:  val_8.renderCamera);
        return (System.Collections.Generic.List<UnityEngine.Camera>)val_3;
    }
    public void HandleRenamePetButton()
    {
    
    }
    public T[] GetAllArmoryCellsInWrapContainer<T>(bool 丟丝七七一丁丏丏丙)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_12 = __RuntimeMethodHiddenParam;
        val_13 = this.itemsWrapContainer.gameObject;
        T[] val_3 = val_13.GetComponentsInChildren<ShopItemsRowContainer>(includeInactive:  丟丝七七一丁丏丏丙);
        if(val_3 == null)
        {
                return (T[])val_14;
        }
        
        val_15 = mem[__RuntimeMethodHiddenParam + 48 + 294];
        val_15 = __RuntimeMethodHiddenParam + 48 + 294;
        if((val_15 & 1) == 0)
        {
                val_15 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_15 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
        val_16 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
        val_16 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
        if(val_16 == 0)
        {
                val_17 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_17 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_17 & 1) == 0)
        {
                val_17 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_17 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
            val_18 = mem[__RuntimeMethodHiddenParam + 48];
            val_18 = __RuntimeMethodHiddenParam + 48;
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) == 0)
        {
                val_18 = mem[__RuntimeMethodHiddenParam + 48];
            val_18 = __RuntimeMethodHiddenParam + 48;
        }
        
            val_16 = __RuntimeMethodHiddenParam + 48 + 16;
            mem2[0] = val_16;
        }
        
        val_14 = System.Linq.Enumerable.ToList<ShopItemsRowContainer>(source:  val_3);
        val_12 = ???;
        val_13 = ???;
        goto __RuntimeMethodHiddenParam + 48 + 40;
    }
    public void ChooseItem(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丕丝丟下丗丛一丕业 = False, bool 丙丑丄丟万上丙丈丘 = False)
    {
        var val_28;
        var val_29;
        var val_30;
        System.Collections.Generic.List<EventDelegate> val_31;
        var val_32;
        float val_33;
        float val_34;
        UnityEngine.Object val_35;
        NurseryGuiController.丂一七世业一不丞专 val_1 = new NurseryGuiController.丂一七世业一不丞专();
        if(val_1 != null)
        {
                val_28 = val_1;
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            mem[1152921538461821576] = this;
            val_29 = this.AllSecondGridArmoryCells;
        }
        else
        {
                val_28 = 16;
            mem[16] = 下丅丙一丂丗丅丝七;
            mem[24] = this;
            val_29 = this.AllSecondGridArmoryCells;
        }
        
        if(val_28 == 0)
        {
            goto label_3;
        }
        
        System.Predicate<丙且上东下丏丏丟下> val_4 = static_value_081D9E68;
        val_4 = new System.Predicate<丙且上东下丏丏丟下>(object:  val_1, method:  System.Boolean NurseryGuiController.丂一七世业一不丞专::丌丗丟东且丛丄丑丏(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
        val_30 = this.万丕丛丝丑丗下丁丘.FindIndex(match:  val_4);
        if(val_29 == null)
        {
            goto label_5;
        }
        
        label_7:
        val_31 = val_29.Count;
        goto label_6;
        label_3:
        val_30 = 0;
        if(val_29 != null)
        {
            goto label_7;
        }
        
        label_5:
        val_31 = 0.Count;
        label_6:
        BaseArmoryCell val_10 = val_29.Item[val_30 - ((val_30 / val_31) * val_31)];
        if(丕丝丟下丗丛一丕业 == false)
        {
            goto label_25;
        }
        
        val_32 = this.gridScrollView.panel;
        if(val_32 == null)
        {
                val_32 = this.gridScrollView.GetComponent<UIPanel>();
            if(val_32 == null)
        {
            goto label_43;
        }
        
        }
        
        label_43:
        UnityEngine.Vector2 val_13 = val_32.GetViewSize();
        val_33 = val_13.y;
        val_31 = val_32.且丝万丈丛丑丗且三();
        float val_29 = this.itemsGrid.cellHeight;
        UnityEngine.Vector2 val_15 = val_32.clipSoftness;
        int val_17 = (val_30 / val_31) + 1;
        float val_28 = (float)val_17;
        val_28 = val_29 * val_28;
        val_29 = val_15.y + val_28;
        val_34 = val_29 + 7f;
        int val_20 = (this.万丕丛丝丑丗下丁丘.Count / val_31) + 1;
        if(val_17 < val_20)
        {
                float val_30 = this.itemsGrid.cellHeight;
            float val_31 = 3f;
            val_30 = val_30 / val_31;
            val_34 = val_34 + val_30;
        }
        
        val_31 = val_34 - val_33;
        float val_21 = UnityEngine.Mathf.Max(a:  0f, b:  val_31);
        if(val_20 >= 10)
        {
                val_33 = 0.01f;
            do
        {
            val_31 = 0 + 1;
        }
        while(val_31 < (-1));
        
        }
        
        if(this.itemsWrapContainer.onStarted == null)
        {
                this.itemsWrapContainer.onStarted = new UIWrapContent.专丅七丘一丄丅丞丟(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void NurseryGuiController.丂一七世业一不丞专::东丐丌丂丌且丕上丒());
        }
        
        label_25:
        val_35 = 1152921504848912384;
        if(val_10 != 0)
        {
                val_35 = val_10.GetComponent<UIToggle>();
            if(val_35 != 0)
        {
                val_31 = val_24.onChange;
            System.Collections.Generic.List<EventDelegate> val_26 = new System.Collections.Generic.List<EventDelegate>();
            if(val_35 != null)
        {
                val_24.onChange = val_26;
        }
        else
        {
                val_24.onChange = val_26;
        }
        
            if(丙丑丄丟万上丙丈丘 != false)
        {
                val_24.instantTween = true;
        }
        
            val_35.Set(丏业丟一东丂东丘丛:  true);
            val_24.onChange = val_31;
            val_24.instantTween = val_24.instantTween;
        }
        
        }
        
        this.且丛丌丌七丈丝丒丈 = mem[16];
        this.petInfo.Show(世丐丗专丅三丝丑丆:  mem[16].业上丙丞丐丄丆丅七(), 下丗丐丙丙丞与与三:  0, 上丑七与丗三丐丈丙:  true, 上世丗与丗东三丐丛:  0);
        this.petShadow.SetActive(value:  true);
    }
    private void Awake()
    {
        var val_9;
        var val_10;
        System.Action val_12;
        var val_13;
        System.Action val_15;
        this.丄丐丄专上下丞万丙 = true;
        val_9 = null;
        val_9 = null;
        NurseryGuiController.丏丐丛丏丘东丛且丕 = this;
        BaseArmoryCell.七一丕丁丅且专一丂(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  System.Void NurseryGuiController::丅丅丟丘丌丐专丛丆(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        BaseArmoryCell.丑一丄丐丂世丕万世(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  System.Void NurseryGuiController::不丌业专丕且丐上丗(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        if(this.bankShopView == 0)
        {
                return;
        }
        
        .丝且与丝丒丟万丁专 = this;
        val_10 = null;
        val_10 = null;
        val_12 = NurseryGuiController.<>c.<>9__74_2;
        if(val_12 == null)
        {
                System.Action val_5 = null;
            val_12 = val_5;
            val_5 = new System.Action(object:  NurseryGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NurseryGuiController.<>c::丞丙专七丛丑丏东丆());
            NurseryGuiController.<>c.<>9__74_2 = val_12;
        }
        
        .丒七丒丌世丘丑丂七 = val_12;
        .下丄不丅万上一丟丕 = new System.Action(object:  this, method:  System.Void NurseryGuiController::丄丌丙不丝一下丘丆());
        val_13 = null;
        val_13 = null;
        val_15 = NurseryGuiController.<>c.<>9__74_4;
        if(val_15 == null)
        {
                System.Action val_7 = null;
            val_15 = val_7;
            val_7 = new System.Action(object:  NurseryGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NurseryGuiController.<>c::丕丁不丟丞丝丙丛七());
            NurseryGuiController.<>c.<>9__74_4 = val_15;
        }
        
        .丞丐下东与丅万丅丁 = val_15;
        this.bankShopView.丄下与业丏丂丞不世(丙业与丙丗丝不丈东:  new System.EventHandler(object:  new NurseryGuiController.且丛丑丘丏丈七丑丝(), method:  System.Void NurseryGuiController.且丛丑丘丏丈七丑丝::专丒丙丏丛世丝万万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public void HandlePetInfoButton()
    {
        if(this.rentScreenPoint.childCount != 0)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == true)
        {
                return;
        }
        
        this.eggInfo.gameObject.SetActive(value:  false);
        this.buttonsEggPanel.SetActive(value:  false);
        UnityEngine.Transform val_6 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "PetInfoNursery"));
        val_6.parent = this.rentScreenPoint;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        val_6.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        if(val_6 != null)
        {
                val_6.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        else
        {
                val_6.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        
        val_6.GetComponent<PetInfoController>().WasCreated = true;
        val_6.GetComponent<PetInfoController>().Show(世丐丗专丅三丝丑丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 下丗丐丙丙丞与与三:  0, 上丑七与丗三丐丈丙:  true, 上世丗与丗东三丐丛:  0);
    }
    private int 且丝万丈丛丑丗且三()
    {
        var val_6;
        float val_6 = (float)UnityEngine.Screen.width;
        val_6 = val_6 / (float)UnityEngine.Screen.height;
        if(val_6 >= 0)
        {
                float val_7 = (float)UnityEngine.Screen.width;
            val_7 = val_7 / (float)UnityEngine.Screen.height;
            var val_5 = ((double)val_7 >= 0) ? 5 : 4;
            return (int)val_6;
        }
        
        val_6 = 3;
        return (int)val_6;
    }
    private void 丒一丄丛上七丁不丘(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        int val_3;
        ShopItemsRowContainer val_1 = 丝三丁东丈丒世丅业.GetComponent<ShopItemsRowContainer>();
        val_3 = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        if(val_1 != null)
        {
                val_1.wrapIndex = val_3;
        }
        else
        {
                val_1.wrapIndex = val_3;
            val_3 = val_1.wrapIndex;
        }
        
        this.丈不丈丝丏丁东东丆(业丟丈丂丝丐丌丛世:  val_1, 丞世不丒下上上丝丑:  val_3);
    }
    private void 丈不丈丝丏丁东东丆(ShopItemsRowContainer 业丟丈丂丝丐丌丛世, int 丞世不丒下上上丝丑)
    {
        int val_6 = 丞世不丒下上上丝丑;
        int val_6 = 业丟丈丂丝丐丌丛世.maxCellsCount;
        int val_1 = val_6 * val_6;
        val_6 = val_6 + val_1;
        if(val_1 >= val_6)
        {
                return;
        }
        
        do
        {
            业丟丈丂丝丐丌丛世.InitializeCellWithShopItem(丑丝丏丂且不下一东:  this.丟丛丒丅七丛丏丌一(一丂丐丟丅丑业万东:  val_1 + 0), 七丆丒与丗丌丄且丂:  168, 业丌丆业丘丟丆丁丛:  0, 丈东丘丏与丌东东下:  NurseryGuiController.且丕丈丙丛不业丂丗());
            int val_7 = 业丟丈丂丝丐丌丛世.maxCellsCount;
            val_6 = 0 + 1;
            val_7 = val_7 + val_1;
        }
        while((val_1 + val_6) < val_7);
    
    }
    private 丙且上东下丏丏丟下 丟丛丒丅七丛丏丌一(int 一丂丐丟丅丑业万东)
    {
        var val_3;
        if(this.万丕丛丝丑丗下丁丘.Count > 一丂丐丟丅丑业万东)
        {
                丙且上东下丏丏丟下 val_2 = this.万丕丛丝丑丗下丁丘.Item[一丂丐丟丅丑业万东];
            return (丙且上东下丏丏丟下)val_3;
        }
        
        val_3 = 0;
        return (丙且上东下丏丏丟下)val_3;
    }
    private void 丗一丝专丘七丑丏世(BaseArmoryCell 丌丝万上丅丒一丈丘, UnityEngine.Vector2 丟丒且一专丟丙下一, float 丝丕丁丏丏上丅丏且)
    {
        UnityEngine.Transform val_1 = 丌丝万上丅丒一丈丘.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        if(val_1 != null)
        {
                val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        else
        {
                0.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        
        val_1.GetChild(index:  0).localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丟丒且一专丟丙下一.x, y = 丟丒且一专丟丙下一.y});
        丌丝万上丅丒一丈丘.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UIWidget val_6 = 丌丝万上丅丒一丈丘.GetComponent<UIWidget>();
        if(val_6 != 0)
        {
                val_6.width = (int)丟丒且一专丟丙下一.x;
        }
        
        this.丞世一丄丆七丝丅业(丆丌丏丞丄丈万丒丁:  丌丝万上丅丒一丈丘);
    }
    private void 丐丄丑七专丙专丐万(BaseArmoryCell 丌丝万上丅丒一丈丘, int 业丌丆业丘丟丆丁丛, CategoryNames 七丆丒与丗丌丄且丂)
    {
        var val_3;
        if(七丆丒与丗丌丄且丂 == 140000)
        {
                val_3 = "sets_";
        }
        
        丌丝万上丅丒一丈丘.name = System.String.Format(format:  "{0}{1}", arg0:  System.String.__il2cppRuntimeField_static_fields, arg1:  业丌丆业丘丟丆丁丛.ToString(format:  "D4"));
    }
    private void 业东丁业与业丐丙东()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemsGrid.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    internal void 不丑丞丌丂世专丄下(丙且上东下丏丏丟下 与丝丕与丙不与丗丆, bool 丕丝丟下丗丛一丕业 = True)
    {
        float val_107;
        float val_108;
        var val_109;
        float val_110;
        int val_111;
        var val_112;
        var val_113;
        UIWrapContent val_114;
        bool val_115;
        float val_116;
        var val_117;
        FixedSlider val_119;
        var val_120;
        七丁丌丒万丄专三三 val_122;
        EggIncubatorManager val_123;
        if(this.itemsWrapContainer.onInitializeItem == null)
        {
                this.itemsWrapContainer.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void NurseryGuiController::丒一丄丛上七丁不丘(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        }
        
        this.业东丁业与业丐丙东();
        int val_3 = this.itemsGrid.且丝万丈丛丑丗且三();
        this.gridScrollView.transform.parent.GetComponent<UIWidget>().ResetAndUpdateAnchors();
        float val_107 = (float)(this.armory.activeHeight * UnityEngine.Screen.width) / UnityEngine.Screen.height;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_107 = IphoneXCameraScaler.不丅七丘丈不丌丝丏 * val_107;
        }
        
        float val_108 = this.otherWidth;
        val_108 = val_107 - val_108;
        float val_13 = val_108 / (float)val_3;
        val_108 = val_13 * (float)val_3;
        this.丏丗一不一丒七与专 = val_108;
        if((this.GetAllArmoryCellsInWrapContainer<ArmoryCell>(丟丝七七一丁丏丏丙:  true)) == null)
        {
                ArmoryCell[] val_15 = new ArmoryCell[0];
        }
        
        if(NurseryGuiController.专丏丄丙一一丆丌三 != true)
        {
                NurseryGuiController.专丏丄丙一一丆丌三 = true;
        }
        
        System.Collections.Generic.List<丙且上东下丏丏丟下> val_16 = new System.Collections.Generic.List<丙且上东下丏丏丟下>();
        float val_109 = 170f;
        this.万丕丛丝丑丗下丁丘 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  168, 丙丑丄与丅丐一不东:  true);
        val_109 = val_13 / val_109;
        T[] val_18 = this.itemsWrapContainer.GetComponentsInChildren<ShopItemsRowContainer>(includeInactive:  true);
        val_107 = val_109 * 150f;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.one;
        val_108 = val_107 + 10f;
        .丞丟丛丛丐丅丛丞丂 = 1;
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_13 + 10f, y:  val_108);
        .丞丟丛丛丐丅丛丞丂 = val_3;
        this.itemsGrid.cellWidth = val_21.x;
        this.itemsGrid.cellHeight = val_21.y;
        this.itemsGrid.maxPerLine = (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
        if(val_18.Length != 5)
        {
            goto label_35;
        }
        
        val_109 = 1152921538461676464;
        goto label_36;
        label_55:
        T val_110 = val_18[0];
        if(val_110 != 0)
        {
                mem2[0] = val_21.x;
            mem2[0] = val_21.y;
            mem2[0] = (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
        }
        else
        {
                mem[24] = val_21.x;
            mem[28] = val_21.y;
            mem[32] = (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
        }
        
        int val_23 = val_110.AttachedCells.Count;
        if((val_23 != 0) || ((NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂 < 1))
        {
            goto label_45;
        }
        
        do
        {
            val_110.AttachCell(丆丌丏丞丄丈万丒丁:  val_23.万丒丙七丘不丁丈三(), 七丆丒与丗丌丄且丂:  168);
        }
        while(1 < (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂);
        
        goto label_45;
        label_53:
        val_108 = val_21.y;
        val_110 = val_109;
        this.丗一丝专丘七丑丏世(丌丝万上丅丒一丈丘:  val_110.AttachedCells.Item[0], 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_21.x, y = val_108}, 丝丕丁丏丏上丅丏且:  val_110);
        this.丐丄丑七专丙专丐万(丌丝万上丅丒一丈丘:  val_110.AttachedCells.Item[0], 业丌丆业丘丟丆丁丛:  0 + (0 * (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂), 七丆丒与丗丌丄且丂:  168);
        label_45:
        if(1 < val_110.AttachedCells.Count)
        {
            goto label_53;
        }
        
        val_110.RepositionCells();
        label_36:
        if(1 < val_18.Length)
        {
            goto label_55;
        }
        
        goto label_56;
        label_35:
        val_109 = 28;
        do
        {
            ShopItemsRowContainer val_32 = this.专一丈丅丂丆丈丒丅();
            val_32.gameObject.name = 0.ToString(format:  "D4");
            val_32.transform.SetParent(parent:  this.itemsWrapContainer.transform, worldPositionStays:  false);
            if(val_32 != null)
        {
                val_32.cellSize = val_21.x;
            mem2[0] = val_21.y;
            val_111 = (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
        }
        else
        {
                mem[24] = val_21.x;
            mem[28] = val_21.y;
            val_111 = (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
        }
        
            val_32.maxCellsCount = val_111;
            if((NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂 >= 1)
        {
                var val_111 = 0;
            do
        {
            BaseArmoryCell val_37 = this.万丒丙七丘不丁丈三();
            val_108 = val_21.y;
            val_110 = val_109;
            this.丗一丝专丘七丑丏世(丌丝万上丅丒一丈丘:  val_37, 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_21.x, y = val_108}, 丝丕丁丏丏上丅丏且:  val_110);
            this.丐丄丑七专丙专丐万(丌丝万上丅丒一丈丘:  val_37, 业丌丆业丘丟丆丁丛:  val_111 + (0 * (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂), 七丆丒与丗丌丄且丂:  168);
            val_32.AttachCell(丆丌丏丞丄丈万丒丁:  val_37, 七丆丒与丗丌丄且丂:  168);
            val_111 = val_111 + 1;
        }
        while(val_111 < (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂);
        
        }
        
            val_32.RepositionCells();
        }
        while(1 <= 4);
        
        label_56:
        this.上丟丞且丞丏丑上丏 = this.itemsWrapContainer.GetComponentsInChildren<ShopItemsRowContainer>(includeInactive:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemsWrapContainer.gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector2 val_42 = this.gridScrollView.panel.GetViewSize();
        .丟专丏不东专世丄丄 = UnityEngine.Mathf.CeilToInt(f:  val_42.y / this.itemsGrid.cellHeight);
        int val_114 = (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
        int val_48 = this.万丕丛丝丑丗下丁丘.Count + (new System.Func<System.Collections.Generic.List<丙且上东下丏丏丟下>, System.Int32>(object:  new NurseryGuiController.丂丁丏丞丅与丗一与(), method:  System.Int32 NurseryGuiController.丂丁丏丞丅与丗一与::不东丆丐丞丑丞丗万(System.Collections.Generic.List<丙且上东下丏丏丟下> 丈丏东丐不丕丐东丟)).Invoke(arg:  this.万丕丛丝丑丗下丁丘));
        int val_49 = val_48 / (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
        if(val_49 <= (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丟专丏不东专世丄丄)
        {
            goto label_81;
        }
        
        val_113 = 0;
        goto label_82;
        label_88:
        val_112 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_18[0].gameObject, 丏业丟一东丂东丘丛:  true);
        val_113 = 1;
        label_82:
        if(val_113 < val_18.Length)
        {
            goto label_88;
        }
        
        val_114 = this.itemsWrapContainer;
        if(val_114 == null)
        {
            goto label_181;
        }
        
        val_115 = 1;
        goto label_90;
        label_81:
        val_109 = 0;
        goto label_91;
        label_97:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_18[0].gameObject, 丏业丟一东丂东丘丛:  (val_109 < val_49) ? 1 : 0);
        val_109 = 1;
        label_91:
        if(val_109 < val_18.Length)
        {
            goto label_97;
        }
        
        val_114 = this.itemsWrapContainer;
        if(val_114 == null)
        {
            goto label_181;
        }
        
        val_115 = false;
        label_90:
        this.itemsWrapContainer.CanOverrideRestrictWithingPanel = val_115;
        this.itemsWrapContainer.cullContent = false;
        val_114 = val_48 / val_114;
        int val_115 = 1;
        val_115 = val_115 - val_114;
        this.itemsWrapContainer.minIndex = val_115;
        val_116 = val_21.y;
        this.itemsWrapContainer.itemSize = UnityEngine.Mathf.FloorToInt(f:  val_116);
        this.gridScrollView.restrictWithinPanel = true;
        this.gridScrollView.ResetPosition();
        val_117 = null;
        val_117 = null;
        if(NurseryGuiController.下丙丟且丕丆丌东业 != true)
        {
                NurseryGuiController.下丙丟且丕丆丌东业 = true;
            if(this.gridScrollView.panel != 0)
        {
                this.gridScrollView.panel.ResetAndUpdateAnchors();
            this.gridScrollView.panel.Refresh();
        }
        
        }
        
        val_119 = this.fixedSlider;
        if((val_119 != 0) && (丕丝丟下丗丛一丕业 != false))
        {
                val_120 = null;
            val_120 = null;
            val_119 = NurseryGuiController.<>c.<>9__83_1;
            if(val_119 == null)
        {
                System.Func<ShopItemsRowContainer, System.Int32> val_59 = null;
            val_119 = val_59;
            val_59 = new System.Func<ShopItemsRowContainer, System.Int32>(object:  NurseryGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 NurseryGuiController.<>c::专丒七丕丆丗东上一(ShopItemsRowContainer 三丟东丕丄丄下下丑));
            NurseryGuiController.<>c.<>9__83_1 = val_119;
        }
        
            ShopItemsRowContainer val_61 = System.Linq.Enumerable.First<ShopItemsRowContainer>(source:  System.Linq.Enumerable.OrderBy<ShopItemsRowContainer, System.Int32>(source:  this.上丟丞且丞丏丑上丏, keySelector:  val_59));
            if(val_61 != 0)
        {
                val_119 = val_61.AttachedCells;
            if(val_119.Count >= 1)
        {
                UnityEngine.Transform val_67 = val_61.AttachedCells.Item[0].transform;
            UnityEngine.Vector3 val_68 = val_67.localPosition;
            UnityEngine.Vector3 val_69 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_70 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z}, d:  val_21.y);
            UnityEngine.Vector3 val_71 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z}, d:  2f);
            UnityEngine.Vector3 val_72 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z}, b:  new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z});
            UnityEngine.Vector3 val_73 = val_67.TransformPoint(position:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z});
            UnityEngine.Vector3 val_74 = val_67.localPosition;
            UnityEngine.Vector3 val_75 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_76 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, d:  val_21.y);
            UnityEngine.Vector3 val_77 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z}, d:  2f);
            UnityEngine.Vector3 val_78 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z}, b:  new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_77.z});
            UnityEngine.Vector3 val_79 = val_67.TransformPoint(position:  new UnityEngine.Vector3() {x = val_78.x, y = val_78.y, z = val_78.z});
            this.fixedSlider.StartContentPosition = new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z};
            UnityEngine.Vector3 val_80 = UnityEngine.Vector3.up;
            int val_116 = (NurseryGuiController.丂丁丏丞丅与丗一与)[1152921538463925872].丞丟丛丛丐丅丛丞丂;
            val_116 = val_48 / val_116;
            UnityEngine.Vector3 val_81 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z}, d:  (float)val_116);
            UnityEngine.Vector3 val_82 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z}, b:  new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z});
            UnityEngine.Vector3 val_83 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z}, d:  val_82.y);
            this.fixedSlider.ContentSize = new UnityEngine.Vector3() {x = val_83.x, y = val_83.y, z = val_83.z};
            UnityEngine.Vector3 val_84 = UnityEngine.Vector3.up;
            val_119 = this.gridScrollView.panel;
            UnityEngine.Vector2 val_86 = val_119.GetViewSize();
            UnityEngine.Vector3 val_87 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_84.x, y = val_84.y, z = val_84.z}, d:  val_86.y);
            UnityEngine.Vector3 val_88 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z}, b:  new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z});
            UnityEngine.Vector3 val_90 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_87.x, y = val_87.y, z = val_87.z}, d:  val_88.y / val_88.x);
            val_116 = val_90.x;
            val_107 = val_90.z;
            this.fixedSlider.ViewSize = new UnityEngine.Vector3() {x = val_116, y = val_90.y, z = val_107};
            if(this.丄且丆丛丗丆丗丙丙 != true)
        {
                val_119 = 1152921505091350528;
            val_122 = System.Delegate.Combine(a:  this.gridScrollView.ScrollbarUpdating, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void NurseryGuiController::丙一东丄七世下业丄()));
            if((val_122 != null) && (null != null))
        {
                val_122 = 0;
        }
        
            this.gridScrollView.ScrollbarUpdating = val_122;
        }
        
        }
        
        }
        
        }
        
        if(this.petInfo != 0)
        {
                this.petInfo.gameObject.SetActive(value:  (与丝丕与丙不与丗丆 != 0) ? 1 : 0);
        }
        
        if(this.buttonsPanel != 0)
        {
                this.buttonsPanel.gameObject.SetActive(value:  (与丝丕与丙不与丗丆 != 0) ? 1 : 0);
        }
        
        val_123 = this.incubatorManager;
        if(val_123 != 0)
        {
                val_123 = this.incubatorManager;
            val_123.SetupIncubators();
        }
        
        if(与丝丕与丙不与丗丆 == 0)
        {
            goto label_170;
        }
        
        if(this.丄丐丄专上下丞万丙 == false)
        {
            goto label_171;
        }
        
        UnityEngine.Coroutine val_102 = this.StartCoroutine(routine:  this.世上下丏丐下丟丛且(与丝丕与丙不与丗丆:  与丝丕与丙不与丗丆));
        goto label_177;
        label_170:
        if(this.incubatorManager == 0)
        {
            goto label_177;
        }
        
        this.incubatorManager.SetIncubatorActive();
        goto label_177;
        label_171:
        this.ChooseItem(下丅丙一丂丗丅丝七:  与丝丕与丙不与丗丆, 丕丝丟下丗丛一丕业:  true, 丙丑丄丟万上丙丈丘:  true);
        label_177:
        if(this.listToSHowEffect == null)
        {
                return;
        }
        
        if(this.listToSHowEffect.Count < 1)
        {
                return;
        }
        
        if(this.丟丆丕业丌丂丂且专 == true)
        {
                return;
        }
        
        UnityEngine.Coroutine val_106 = this.StartCoroutine(routine:  this.丅东业丈丝不丙丐七());
        return;
        label_181:
    }
    private System.Collections.IEnumerator 世上下丏丐下丟丛且(丙且上东下丏丏丟下 与丝丕与丙不与丗丆)
    {
        NurseryGuiController.丅世丞丁丅丏丗上丞 val_1 = new NurseryGuiController.丅世丞丁丅丏丗上丞();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .与丝丕与丙不与丗丆 = 与丝丕与丙不与丗丆;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丙一东丄七世下业丄()
    {
        var val_27;
        System.Func<ShopItemsRowContainer, System.Int32> val_29;
        int val_30;
        if(this.fixedSlider == 0)
        {
                return;
        }
        
        val_27 = null;
        val_27 = null;
        val_29 = NurseryGuiController.<>c.<>9__85_0;
        if(val_29 == null)
        {
                System.Func<ShopItemsRowContainer, System.Int32> val_2 = null;
            val_29 = val_2;
            val_2 = new System.Func<ShopItemsRowContainer, System.Int32>(object:  NurseryGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 NurseryGuiController.<>c::丆丞丑丝上一丁丁丅(ShopItemsRowContainer 三丟东丕丄丄下下丑));
            NurseryGuiController.<>c.<>9__85_0 = val_29;
        }
        
        ShopItemsRowContainer val_4 = System.Linq.Enumerable.First<ShopItemsRowContainer>(source:  System.Linq.Enumerable.OrderBy<ShopItemsRowContainer, System.Int32>(source:  this.上丟丞且丞丏丑上丏, keySelector:  val_2));
        if(val_4 == 0)
        {
                return;
        }
        
        val_29 = val_4.AttachedCells;
        if(val_29.Count < 1)
        {
                return;
        }
        
        if(val_4 != null)
        {
                val_30 = val_4.wrapIndex;
        }
        else
        {
                val_30 = val_4.wrapIndex;
        }
        
        UnityEngine.Transform val_10 = val_4.AttachedCells.Item[0].transform;
        UnityEngine.Vector3 val_11 = val_10.localPosition;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  null);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  2f);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = val_10.TransformPoint(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3 val_17 = val_10.localPosition;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  val_14.x);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  2f);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        UnityEngine.Vector3 val_22 = val_10.TransformPoint(position:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.up;
        float val_28 = (float)val_30;
        val_28 = (System.Math.Abs(val_16.y - val_22.y)) * val_28;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  val_28);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        this.fixedSlider.UpdateSlider(丒不三丁丒丏丂丒丈:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
    }
    private void 丞世一丄丆七丝丅业(BaseArmoryCell 丆丌丏丞丄丈万丒丁)
    {
        if(丆丌丏丞丄丈万丒丁 == null)
        {
                return;
        }
        
        this.丄万与丂丐下丆丁丂(丆丌丏丞丄丈万丒丁:  丆丌丏丞丄丈万丒丁);
    }
    private void 丄万与丂丐下丆丁丂(ArmoryCell 丆丌丏丞丄丈万丒丁)
    {
        UnityEngine.Material val_1 = 丆丌丏丞丄丈万丒丁.capeRenderer.material;
        UnityEngine.Material val_3 = 丆丌丏丞丄丈万丒丁.modelForSkin.GetComponent<UnityEngine.MeshRenderer>().material;
        UnityEngine.Vector3 val_5 = this.topPointForShader.transform.localPosition;
        UnityEngine.Vector3 val_7 = this.bottomPointForShader.transform.localPosition;
        float val_12 = val_7.y;
        val_12 = val_12 + 5f;
        UnityEngine.Transform val_9 = this.gridScrollView.transform.parent;
        UnityEngine.Vector3 val_10 = val_9.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_11 = val_9.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(val_1 != null)
        {
                val_1.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        else
        {
                0.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        
        val_1.SetFloat(name:  "_BottomBorder", value:  val_11.y);
        if(val_3 != null)
        {
                val_3.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        else
        {
                0.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        
        val_3.SetFloat(name:  "_BottomBorder", value:  val_11.y);
    }
    private BaseArmoryCell 万丒丙七丘不丁丈三()
    {
        return (BaseArmoryCell)UnityEngine.Object.Instantiate<BaseArmoryCell>(original:  UnityEngine.Resources.Load<BaseArmoryCell>(path:  "ArmoryCell"));
    }
    private ShopItemsRowContainer 专一丈丅丂丆丈丒丅()
    {
        return (ShopItemsRowContainer)UnityEngine.Object.Instantiate<ShopItemsRowContainer>(original:  UnityEngine.Resources.Load<ShopItemsRowContainer>(path:  "ShopRowItemsContainer"));
    }
    public void CloseNursery()
    {
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 6)
        {
                return;
        }
        
        if(EggHatchingWindowControllerV2.且丕丈丙丛不业丂丗() != 0)
        {
                return;
        }
        
        NurseryGuiController.丘丏丑丕丙东丗丏下(丙业与丙丗丝不丈东:  false);
    }
    internal static void 七丝丘丌丌丕丞丏三(UnityEngine.GameObject 丛丈七丒丄业丒丈丕, 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞, System.Action 七丒上且丝业业下七, System.Action 丝丏丗丄丗与丐丌三, System.Func<bool> 丟丌丟丕丟三丑丛丏, System.Action 丒七丒丌世丘丑丂七, System.Action 丞丐下东与丅万丅丁, System.Action 下丄不丅万上一丟丕, bool 且不东丈丝三丕与一 = False, bool 与丟丁七丟专业一丅 = False, System.Action 丌丆万丏丙丕丙一丂)
    {
        var val_9;
        object val_10;
        var val_11;
        NurseryGuiController.丟丐丟丝丝不丈下丒 val_1 = new NurseryGuiController.丟丐丟丝丝不丈下丒();
        if(val_1 != null)
        {
                val_9 = val_1;
            .丒世丘丘上丆丝东丞 = 丒世丘丘上丆丝东丞;
            mem[1152921538465767704] = 丛丈七丒丄业丒丈丕;
            mem[1152921538465767712] = 丒七丒丌世丘丑丂七;
            mem[1152921538465767720] = 下丄不丅万上一丟丕;
            mem[1152921538465767744] = 丟丌丟丕丟三丑丛丏;
            mem[1152921538465767752] = 与丟丁七丟专业一丅;
            mem[1152921538465767760] = 丌丆万丏丙丕丙一丂;
            mem[1152921538465767768] = 七丒上且丝业业下七;
            mem[1152921538465767776] = 丝丏丗丄丗与丐丌三;
        }
        else
        {
                mem[24] = 丛丈七丒丄业丒丈丕;
            mem[32] = 丒七丒丌世丘丑丂七;
            mem[40] = 下丄不丅万上一丟丕;
            val_9 = 56;
            mem[56] = 丒世丘丘上丆丝东丞;
            mem[64] = 丟丌丟丕丟三丑丛丏;
            mem[72] = 与丟丁七丟专业一丅;
            mem[80] = 丌丆万丏丙丕丙一丂;
            mem[88] = 七丒上且丝业业下七;
            mem[96] = 丝丏丗丄丗与丐丌三;
        }
        
        .丞丐下东与丅万丅丁 = 丞丐下东与丅万丅丁;
        UnityEngine.Debug.Log(message:  "Trying to buy from ShopNGUIController...");
        if(BankController.丑七不且上丗丁一世() == 0)
        {
                val_10 = "BankController.Instance == null";
        }
        else
        {
                if(val_9 != 0)
        {
                .丑丘丐丂不丐丒丟且 = 0;
            .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  val_1, method:  System.Void NurseryGuiController.丟丐丟丝丝不丈下丒::丈丌丟丕丁一业业世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            .丌专业且丛丏丞丝且 = 0;
            System.EventHandler val_7 = new System.EventHandler(object:  val_1, method:  System.Void NurseryGuiController.丟丐丟丝丝不丈下丒::七丒丟三不七丛丘丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            .丌专业且丛丏丞丝且 = val_7;
            val_11 = null;
            val_11 = null;
            val_7.Invoke(sender:  BankController.丑七不且上丗丁一世(), e:  System.EventArgs.Empty);
            return;
        }
        
            val_10 = "price == null";
        }
        
        UnityEngine.Debug.LogWarning(message:  val_10);
    }
    private System.Collections.IEnumerator 丏丕业丈丏万丅丂且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NurseryGuiController.专丟丈丕丑丂丐业丏();
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 != false)
        {
                this.StopCoroutine(routine:  this.丏丕业丈丏万丅丂且());
            return;
        }
        
        this.UpdateIncubators();
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
        {
                return;
        }
        
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 6)
        {
                return;
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丏丕业丈丏万丅丂且());
    }
    public NurseryGuiController()
    {
        this.丄丈且丂丕丐丅丐七 = true;
        this.otherWidth = 450f;
        this.丏丗一不一丒七与专 = 600f;
    }
    private static NurseryGuiController()
    {
        NurseryGuiController.丏丐丛丏丘东丛且丕 = 0;
        NurseryGuiController.丟丌丞万丕万丐丐上 = new System.Collections.Generic.List<UnityEngine.Camera>();
        NurseryGuiController.专丏丄丙一一丆丌三 = false;
        NurseryGuiController.下丙丟且丕丆丌东业 = false;
    }
    private void 丅丅丟丘丌丐专丛丆(BaseArmoryCell 丌丝万上丅丒一丈丘)
    {
        var val_5;
        if(NurseryGuiController.且丕丈丙丛不业丂丗() == 0)
        {
                return;
        }
        
        val_5 = null;
        if(NurseryGuiController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        if(this.petInfo == 0)
        {
                return;
        }
        
        this.HandlePetInfoButton();
    }
    private void 不丌业专丕且丐上丗(BaseArmoryCell 丌丝万上丅丒一丈丘)
    {
        var val_16;
        UnityEngine.Object val_17;
        var val_18;
        val_16 = this;
        val_17 = NurseryGuiController.且丕丈丙丛不业丂丗();
        if(val_17 == 0)
        {
                return;
        }
        
        val_18 = null;
        if(NurseryGuiController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_17 = this.petInfo;
        if(val_17 == 0)
        {
                return;
        }
        
        val_17 = this.buttonsPanel;
        if(val_17 == 0)
        {
                return;
        }
        
        this.且丛丌丌七丈丝丒丈 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丌丝万上丅丒一丈丘.ItemId, 七丆丒与丗丌丄且丂:  168);
        if(this.eggInfo != 0)
        {
                if(this.buttonsEggPanel != 0)
        {
                this.eggInfo.gameObject.SetActive(value:  false);
            this.buttonsEggPanel.gameObject.SetActive(value:  false);
        }
        
        }
        
        val_17 = this.petInfo;
        val_17.Show(世丐丗专丅三丝丑丆:  丌丝万上丅丒一丈丘.ItemId, 下丗丐丙丙丞与与三:  0, 上丑七与丗三丐丈丙:  true, 上世丗与丗东三丐丛:  0);
        this.丄丈且丂丕丐丅丐七 = false;
        val_16 = 1152921505237143552;
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 3)
        {
                return;
        }
        
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() == 6)
        {
                return;
        }
        
        NurseryGuiController val_15 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_15.trainingController.UpdateTrainingStep(丒且丆丘丞丑业丅不:  4);
    }
    private void 丄丌丙不丝一下丘丆()
    {
        this.SetOtherCamerasEnabled(丗丛不丁丑专专丂且:  false);
        NurseryGuiController.丘丏丑丕丙东丗丏下(丙业与丙丗丝不丈东:  true);
    }

}
