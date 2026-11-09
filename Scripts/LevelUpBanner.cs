using UnityEngine;
internal sealed class LevelUpBanner : MonoBehaviour
{
    // Fields
    private static int <七且丁东丝丛丁且专>k__BackingField;
    private readonly System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, LevelUpBanner.丝不丕丁且丅丟丘丛> 丕一丕且丄东丌七丌;
    private readonly System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, LevelUpBanner.丝不丕丁且丅丟丘丛> 世丝丗丅且不丆七丟;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 丕丁丟不万丁丗上世;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 丂丑万丈丙专万东丘;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 丝丙丝丕业万七与丞;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 丈丁世与专丝丛三世;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 万业丐丘丒三丄丒七;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 下丗三丅且丁万专且;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 丞丙且丕丅丌丂丂丘;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 七七与丑丟丂丕丕丌;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 丗丒丙七世且丕丈与;
    private readonly LevelUpBanner.丝不丕丁且丅丟丘丛 丗丆丟世丒三丙东一;
    internal readonly System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<LevelUpBanner.丝不丕丁且丅丟丘丛>> 丛丗丕丛丕下丂丈丒;
    private readonly System.Collections.Generic.Dictionary<LevelUpBanner.丑与丅世东丙丙丕世<bool>, System.Collections.Generic.List<LevelUpBanner.丝不丕丁且丅丟丘丛>> 下世不丗丘丑丟丄丞;
    public Rilisoft.ButtonHandler okButton;
    public UILabel[] levelTierLabels;
    public UILabel[] levelLabels;
    public UILabel[] leagueLabels;
    public UnityEngine.GameObject itemGems;
    public UnityEngine.GameObject itemCoins;
    public UnityEngine.GameObject itemArmor;
    public UnityEngine.GameObject itemHealth;
    public UnityEngine.GameObject itemSignalPistol;
    public UnityEngine.GameObject itemFlamethrower;
    public UnityEngine.GameObject itemEgg;
    public UnityEngine.GameObject itemBP;
    public UnityEngine.GameObject itemModuleChest;
    public UnityEngine.GameObject newFeaturesPanel;
    public UnityEngine.GameObject contentLeftArrow;
    public UnityEngine.GameObject contentRightArrow;
    public UnityEngine.GameObject downArrow;
    public UnityEngine.GameObject tierHeader;
    public UnityEngine.GameObject defaultHeader;
    public UnityEngine.GameObject noNewContentAndFeatures;
    public UnityEngine.GameObject perfectButtonLabel;
    public UnityEngine.GameObject okButtonLabel;
    public UILabel itemGemsLabel;
    public UILabel itemCoinsLabel;
    public UILabel itemArmorLabel;
    public UILabel itemHealthLabel;
    public UILabel movedToNextLeagueLabel;
    public UILabel maxEffLabel;
    public LevelUpBannerNewContentView newContentItemView;
    private UIBasicSprite itemArmorTexture;
    public UIWidget featureBG;
    public UIWidget lowBorderContent;
    public LevelUpFeatureItem baseFeatureItem;
    public UITable featuresTable;
    public UITable windowTable;
    public UIScrollView bannerScroll;
    public UIScrollView newContentScroll;
    public UIWrapContent newContentWrap;
    private readonly System.Collections.Generic.List<LevelUpBannerNewContentView> 丙丙与丕不丞丛丐业;
    private readonly System.Collections.Generic.List<LevelUpFeatureItem> 丟丕上一丞上专下一;
    public UnityEngine.GameObject contentItemsBuffer;
    public UnityEngine.GameObject levelUpPanel;
    public UnityEngine.GameObject leagueUpAnimationPanel;
    public UnityEngine.GameObject newContentContainer;
    public UnityEngine.GameObject defaultAnimPanel;
    public UnityEngine.Animator defaultAnimator;
    public UnityEngine.GameObject[] tierObjects;
    public UnityEngine.GameObject[] defaultObjects;
    public UIGrid rewardGrid;
    private bool 丂不丐业东丆三丑万;
    private bool 三七丗丕丛不七丑丛;
    private bool 丞丒一与业丗业世丑;
    private 专丑丈丙七丗世丆下 世且丞丝不丅丟丅丙;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private bool 世七业丌东丂专七三;
    private bool 下丙丒下丏丈丐丕业;
    private bool 丑万三万丑七丈丂一;
    private bool 丝专与丅世万丕上七;
    private bool 丝七丗丄丏东世丘丙;
    private bool 丒世丅业丝东下与丗;
    
    // Properties
    internal static int 万三丈不丝业丐丒丏 { get; set; }
    private UIBasicSprite 丗且与丕丄丆且七丑 { get; }
    
    // Methods
    internal static int 丌丞丒丈丑丒万上丄()
    {
        return (int)LevelUpBanner.<七且丁东丝丛丁且专>k__BackingField;
    }
    private static void 业与与与丁丕丟丁与(int 丙业与丙丗丝不丈东)
    {
        LevelUpBanner.<七且丁东丝丛丁且专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void OnClickToGridReward(UnityEngine.GameObject 万且万且丑丗且丌丆)
    {
    
    }
    private UIBasicSprite 与丞丈丝丑与丅丄且()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemArmorTexture);
        this.itemArmorTexture = val_1;
        return val_1;
    }
    internal void 丛不丒丌七丏丕业业(专丑丈丙七丗世丆下 丆与丛丅丂三万一丑)
    {
        object val_33;
        var val_43;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>> val_44;
        var val_45;
        this.丏丑业丑专世丄丆专();
        this.世且丞丝不丅丟丅丙 = 丆与丛丅丂三万一丑;
        this.defaultAnimator.enabled = false;
        this.丞丒一与业丗业世丑 = false;
        this.itemCoinsLabel.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丆与丛丅丂三万一丑.丁丂丝丗七下万丞丐)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丆与丛丅丂三万一丑.丁丂丝丗七下万丞丐)) + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0275")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0275"));
        this.itemGemsLabel.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丆与丛丅丂三万一丑.丈专七丞三丙丘丛与)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丆与丛丅丂三万一丑.丈专七丞三丙丘丛与)) + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0951")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0951"));
        this.tierHeader.gameObject.SetActive(value:  false);
        this.defaultHeader.gameObject.SetActive(value:  true);
        val_43 = 0;
        goto label_13;
        label_20:
        this.levelLabels[0].text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3664"), arg0:  丆与丛丅丂三万一丑.丈上丐丘不七丑不丞.ToString());
        val_43 = 1;
        label_13:
        if(val_43 < this.levelLabels.Length)
        {
            goto label_20;
        }
        
        this.movedToNextLeagueLabel.gameObject.SetActive(value:  false);
        this.maxEffLabel.gameObject.SetActive(value:  false);
        if((this.tierObjects != null) && (this.tierObjects.Length >= 1))
        {
                do
        {
            this.tierObjects[0].SetActive(value:  false);
        }
        while((0 + 1) < this.tierObjects.Length);
        
        }
        
        if((this.defaultObjects != null) && (this.defaultObjects.Length >= 1))
        {
                do
        {
            this.defaultObjects[0].SetActive(value:  true);
        }
        while((0 + 1) < this.defaultObjects.Length);
        
        }
        
        this.itemHealth.SetActive(value:  false);
        if(this.itemSignalPistol != 0)
        {
                this.itemSignalPistol.SetActive(value:  false);
        }
        
        if(this.itemFlamethrower != 0)
        {
                this.itemFlamethrower.SetActive(value:  false);
        }
        
        if(this.itemEgg != 0)
        {
                this.itemEgg.SetActive(value:  false);
        }
        
        bool val_19 = System.String.IsNullOrEmpty(value:  丆与丛丅丂三万一丑.丑丗丅丕专丞丝万丒);
        this.itemArmor.SetActive(value:  val_19 ^ 1);
        if(val_19 != true)
        {
                this.itemArmorLabel.text = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  丆与丛丅丂三万一丑.丑丗丅丕专丞丝万丒, 七丆丒与丗丌丄且丂:  7);
            UnityEngine.Texture val_23 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  丆与丛丅丂三万一丑.丑丗丅丕专丞丝万丒, 七丆丒与丗丌丄且丂:  7, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        }
        
        val_44 = this.与丞丈丝丑与丅丄且().丛丈丕丕丟丁丏丒且(丈丘丝一丗下丈丐不:  丆与丛丅丂三万一丑.丈上丐丘不七丑不丞, 一丗丆丒世七丟丑丄:  丆与丛丅丂三万一丑.一丙且不与丏丐三不);
        this.丂丄丗丝丌丌丝世丘(丑七不与丛丆一丂丞:  val_44);
        this.newContentContainer.SetActive(value:  (val_44.Count > 0) ? 1 : 0);
        System.Collections.Generic.List<丝不丕丁且丅丟丘丛> val_28 = new System.Collections.Generic.List<丝不丕丁且丅丟丘丛>();
        val_45 = this.丛丗丕丛丕下丂丈丒.ContainsKey(key:  丆与丛丅丂三万一丑.丈上丐丘不七丑不丞);
        Dictionary.Enumerator<TKey, TValue> val_30 = this.下世不丗丘丑丟丄丞.GetEnumerator();
        label_63:
        if((421110320 & 1) == 0)
        {
            goto label_59;
        }
        
        ConfiguredValueTaskAwaiter val_34 = val_33.GetAwaiter();
        if(val_34._value._obj.丐丏七丌丕丗业且上().Invoke() == false)
        {
            goto label_63;
        }
        
        val_28.AddRange(collection:  val_34._value._obj);
        goto label_63;
        label_59:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        bool val_38 =  & 1;
        this.newFeaturesPanel.SetActive(value:  val_38);
        if((val_38 & 1) != 0)
        {
                ( != 1) ? this.noNewContentAndFeatures : 0.SetActive(value:  false);
            val_44 = this.丛丗丕丛丕下丂丈丒;
            val_28.AddRange(collection:  val_44.Item[丆与丛丅丂三万一丑.丈上丐丘不七丑不丞]);
            this.丏与且丗业丑丕三丕(丂丆且丛丆丘上专丒:  val_28, 业万上丆丐丞且丒七:  丆与丛丅丂三万一丑.一丙且不与丏丐三不);
        }
        else
        {
                this.noNewContentAndFeatures.SetActive(value:  (val_33.Count == 0) ? 1 : 0);
        }
        
        this.defaultAnimPanel.SetActive(value:  true);
        this.levelUpPanel.SetActive(value:  false);
        UnityEngine.Coroutine val_45 = CoroutineRunner.Instance.StartCoroutine(routine:  this.StartAnimation(业万上丆丐丞且丒七:  false));
        this.三七丗丕丛不七丑丛 = false;
        this.丝七丗丄丏东世丘丙 = true;
    }
    public System.Collections.IEnumerator StartAnimation(bool 业万上丆丐丞且丒七)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LevelUpBanner.东丈丌下一丑一且下();
    }
    public void AnimationCallback()
    {
        this.levelUpPanel.SetActive(value:  true);
    }
    private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, UnityEngine.Texture>> 丛丈丕丕丟丁丏丒且(int 丈丘丝一丗下丈丐不, bool 一丗丆丒世七丟丑丄)
    {
        object val_6;
        var val_42;
        var val_43;
        var val_44;
        MoonSharp.Interpreter.DynValue val_46;
        var val_47;
        var val_48;
        System.Func<PGCompany.ArmorSkinSettings, PGCompany.丗丟丄丈东丝丕丄世> val_50;
        var val_51;
        System.Func<PGCompany.丗丟丄丈东丝丕丄世, System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>> val_53;
        .丈丘丝一丗下丈丐不 = 丈丘丝一丗下丈丐不;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>> val_2 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>>();
        List.Enumerator<T> val_4 = PromoActionsGUIController.丗东丏丒万丝万万丘(丈丘丝一丗下丈丐不:  (LevelUpBanner.业丞丑丅丄与丑七丕)[1152921530798626784].丈丘丝一丗下丈丐不).GetEnumerator();
        label_13:
        if((421931904 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        MoonSharp.Interpreter.TablePair val_13 = new MoonSharp.Interpreter.TablePair(key:  val_7.与不丞丑七丘丁丂丛(), val:  丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_7.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_7.万上丄下业丛丌不丈() - 1, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false));
        val_2.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>() {Value = val_13.key});
        goto label_13;
        label_6:
        val_42 = 0;
        val_43 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (127 != 127))
        {
            goto label_25;
        }
        
        val_42 = 0;
        goto label_36;
        label_55:
        if((public System.Boolean List.Enumerator<三丅丁丗丗丝丂万且>::MoveNext()) != 1)
        {
            goto label_81;
        }
        
        if((null & 1) == 0)
        {
            goto label_28;
        }
        
        object[] val_14 = new object[1];
        val_14[0] = val_6;
        UnityEngine.Debug.LogErrorFormat(format:  "Exception in adding weapons to level up: {0}", args:  val_14);
        goto label_36;
        label_25:
        if( != 0)
        {
                val_43 = 0;
        }
        
        label_36:
        if(一丗丆丒世七丟丑丄 == false)
        {
            goto label_65;
        }
        
        List.Enumerator<T> val_17 = PromoActionsGUIController.丈三一不丂丆业专七(业万上丆丐丞且丒七:  ExpController.丐丈丒丈上业与丅丆(丝下三丆丅丕丐丒且:  (LevelUpBanner.业丞丑丅丄与丑七丕)[1152921530798626784].丈丘丝一丗下丈丐不)).GetEnumerator();
        label_51:
        if((421931872 & 1) == 0)
        {
            goto label_44;
        }
        
        string val_19 = val_13.key.丐丏七丌丕丗业且上();
        MoonSharp.Interpreter.TablePair val_24 = new MoonSharp.Interpreter.TablePair(key:  val_19.业上丙丞丐丄丆丅七(), val:  丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_19.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  val_19.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false));
        val_2.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>() {Value = val_24.key});
        goto label_51;
        label_44:
        val_42 = 1;
        goto label_52;
        label_28:
        mem[8] = val_6;
        goto label_55;
        label_52:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (127 == 269))
        {
                var val_42 = 0;
            val_42 = val_42 ^ 0;
            val_42 =  + val_42;
        }
        else
        {
                if( != 0)
        {
                val_43 = 0;
        }
        
        }
        
        label_65:
        Dictionary.Enumerator<TKey, TValue> val_27 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.世下丂丅丒不丄三专(丏世丞丅丁丄丁万丑:  (LevelUpBanner.业丞丑丅丄与丑七丕)[1152921530798626784].丈丘丝一丗下丈丐不).GetEnumerator();
        label_73:
        if((421931824 & 1) == 0)
        {
            goto label_69;
        }
        
        ConfiguredValueTaskAwaiter val_29 = val_24.key.GetAwaiter();
        MoonSharp.Interpreter.TablePair val_33 = new MoonSharp.Interpreter.TablePair(key:  val_29._value._obj.业上丙丞丐丄丆丅七(), val:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_29._value._obj.丙三专万丛丟万丝丘()));
        mem[8].Add(item:  new System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>() {Value = val_33.key});
        goto label_73;
        label_69:
        val_46 = val_43;
        val_47 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_82;
        }
        
        if(( == 0) || (127 == 372))
        {
            goto label_98;
        }
        
        label_97:
        label_98:
        val_48 = null;
        val_48 = null;
        val_50 = LevelUpBanner.<>c.<>9__81_1;
        if(val_50 == null)
        {
                System.Func<PGCompany.ArmorSkinSettings, PGCompany.丗丟丄丈东丝丕丄世> val_38 = null;
            val_50 = val_38;
            val_38 = new System.Func<PGCompany.ArmorSkinSettings, PGCompany.丗丟丄丈东丝丕丄世>(object:  LevelUpBanner.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.丗丟丄丈东丝丕丄世 LevelUpBanner.<>c::东丞丙丗丙业丕丝丏(PGCompany.ArmorSkinSettings 三丟东丕丄丄下下丑));
            LevelUpBanner.<>c.<>9__81_1 = val_50;
        }
        
        val_51 = null;
        val_51 = null;
        val_53 = LevelUpBanner.<>c.<>9__81_2;
        if(val_53 == null)
        {
                System.Func<PGCompany.丗丟丄丈东丝丕丄世, System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>> val_40 = null;
            val_53 = val_40;
            val_40 = new System.Func<PGCompany.丗丟丄丈东丝丕丄世, System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>>(object:  LevelUpBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture> LevelUpBanner.<>c::丗丐丌专东丝不业丟(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑));
            LevelUpBanner.<>c.<>9__81_2 = val_53;
        }
        
        mem[8].AddRange(collection:  System.Linq.Enumerable.Select<PGCompany.丗丟丄丈东丝丕丄世, System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>>(source:  System.Linq.Enumerable.Select<PGCompany.ArmorSkinSettings, PGCompany.丗丟丄丈东丝丕丄世>(source:  System.Linq.Enumerable.Where<PGCompany.ArmorSkinSettings>(source:  PGCompany.丈三丁三丂一丅丆丆.丑七不且上丗丁一世().不上丛丛丞万丒丝丈(), predicate:  new System.Func<PGCompany.ArmorSkinSettings, System.Boolean>(object:  new LevelUpBanner.业丞丑丅丄与丑七丕(), method:  System.Boolean LevelUpBanner.业丞丑丅丄与丑七丕::丌下万一丏丒且丏丝(PGCompany.ArmorSkinSettings 三丟东丕丄丄下下丑))), selector:  val_38), selector:  val_40));
        return (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture>>);
        label_82:
        if( != 0)
        {
            goto label_97;
        }
        
        goto label_98;
        label_81:
        val_44;
    }
    private void 丂丄丗丝丌丌丝世丘(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, UnityEngine.Texture>> 丑七不与丛丆一丂丞)
    {
        System.Collections.Generic.List<LevelUpBannerNewContentView> val_48;
        var val_49;
        if(this.丂不丐业东丆三丑万 == false)
        {
            goto label_1;
        }
        
        if(丑七不与丛丆一丂丞 != null)
        {
            goto label_63;
        }
        
        label_64:
        label_63:
        int val_48 = UnityEngine.Mathf.Max(a:  0, b:  丑七不与丛丆一丂丞.Count - this.丙丙与丕不丞丛丐业.Count);
        if(val_48 >= 1)
        {
                do
        {
            UnityEngine.GameObject val_9 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.newContentItemView.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.newContentItemView.gameObject);
            string val_12 = "newItem_" + this.丙丙与丕不丞丛丐业.Count.ToString(format:  "00")(this.丙丙与丕不丞丛丐业.Count.ToString(format:  "00"));
            if(val_9 != null)
        {
                val_9.name = val_12;
        }
        else
        {
                0.name = val_12;
        }
        
            val_48 = this.丙丙与丕不丞丛丐业;
            val_48.Add(item:  val_9.GetComponent<LevelUpBannerNewContentView>());
            val_48 = val_48 - 1;
        }
        while(val_48 != 0);
        
        }
        
        val_49 = 0;
        goto label_18;
        label_55:
        LevelUpBannerNewContentView val_15 = this.丙丙与丕不丞丛丐业.Item[0];
        if(val_49 < 丑七不与丛丆一丂丞.Count)
        {
                if(val_15.gameObject.activeSelf != true)
        {
                this.丙丙与丕不丞丛丐业.Item[0].gameObject.transform.SetParent(parent:  this.newContentWrap.transform, worldPositionStays:  true);
            this.丙丙与丕不丞丛丐业.Item[0].gameObject.SetActive(value:  true);
        }
        
            LevelUpBannerNewContentView val_24 = this.丙丙与丕不丞丛丐业.Item[0];
            System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture> val_25 = 丑七不与丛丆一丂丞.Item[0];
            val_24.ItemTag = val_25.Value.丐丏七丌丕丗业且上();
            UIBasicSprite val_28 = this.丙丙与丕不丞丛丐业.Item[0].Texture;
            System.Collections.Generic.KeyValuePair<System.String, UnityEngine.Texture> val_29 = 丑七不与丛丆一丂丞.Item[0];
            this.丙丙与丕不丞丛丐业.Item[0].remove_OnClickHandler(丙业与丙丗丝不丈东:  new System.Action<LevelUpBannerNewContentView>(object:  this, method:  System.Void LevelUpBanner::丗丛丒丆丏丕丅丒万(LevelUpBannerNewContentView 万且万且丑丗且丌丆)));
            System.Action<LevelUpBannerNewContentView> val_33 = null;
            val_48 = val_33;
            val_33 = new System.Action<LevelUpBannerNewContentView>(object:  this, method:  System.Void LevelUpBanner::丗丛丒丆丏丕丅丒万(LevelUpBannerNewContentView 万且万且丑丗且丌丆));
            this.丙丙与丕不丞丛丐业.Item[0].add_OnClickHandler(丙业与丙丗丝不丈东:  val_33);
        }
        else
        {
                val_15.remove_OnClickHandler(丙业与丙丗丝不丈东:  new System.Action<LevelUpBannerNewContentView>(object:  this, method:  System.Void LevelUpBanner::丗丛丒丆丏丕丅丒万(LevelUpBannerNewContentView 万且万且丑丗且丌丆)));
            val_48 = this.contentItemsBuffer.transform;
            this.丙丙与丕不丞丛丐业.Item[0].gameObject.transform.SetParent(parent:  val_48, worldPositionStays:  true);
            this.丙丙与丕不丞丛丐业.Item[0].gameObject.SetActive(value:  false);
        }
        
        val_49 = 1;
        label_18:
        if(val_49 < this.丙丙与丕不丞丛丐业.Count)
        {
            goto label_55;
        }
        
        this.丑万三万丑七丈丂一 = true;
        int val_42 = 丑七不与丛丆一丂丞.Count;
        this.丝专与丅世万丕上七 = (val_42 < 7) ? 1 : 0;
        this.contentLeftArrow.gameObject.SetActive(value:  (val_42 > 6) ? 1 : 0);
        this.contentRightArrow.gameObject.SetActive(value:  (val_42 > 6) ? 1 : 0);
        return;
        label_1:
        this.丂不丐业东丆三丑万 = true;
        this.丙丙与丕不丞丛丐业.Add(item:  this.newContentItemView);
        if(丑七不与丛丆一丂丞 != null)
        {
            goto label_63;
        }
        
        goto label_64;
    }
    private void 丗丛丒丆丏丕丅丒万(LevelUpBannerNewContentView 万且万且丑丗且丌丆)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  万且万且丑丗且丌丆.ItemTag)) == true)
        {
                return;
        }
        
        万且万且丑丗且丌丆 = 万且万且丑丗且丌丆.ItemTag;
        Rilisoft.ItemViewer val_4 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.gameObject.transform, 丕丁下丌不万丅丞丛:  万且万且丑丗且丌丆, 丅三丟世下丞丝丙万:  1, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
    }
    private void 丏与且丗业丑丕三丕(System.Collections.Generic.List<LevelUpBanner.丝不丕丁且丅丟丘丛> 丂丆且丛丆丘上专丒, bool 业万上丆丐丞且丒七)
    {
        string val_17;
        string val_18;
        var val_21;
        int val_20 = UnityEngine.Mathf.Max(a:  0, b:  丂丆且丛丆丘上专丒.Count - this.丟丕上一丞上专下一.Count);
        if(val_20 >= 1)
        {
                do
        {
            this.丟丕上一丞上专下一.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.baseFeatureItem.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.baseFeatureItem.gameObject).GetComponent<LevelUpFeatureItem>());
            val_20 = val_20 - 1;
        }
        while(val_20 != 0);
        
        }
        
        val_21 = 0;
        goto label_15;
        label_26:
        UnityEngine.GameObject val_14 = this.丟丕上一丞上专下一.Item[0].gameObject;
        if(val_21 < 丂丆且丛丆丘上专丒.Count)
        {
                val_14.SetActive(value:  true);
            丝不丕丁且丅丟丘丛 val_16 = 丂丆且丛丆丘上专丒.Item[0];
            this.丟丕上一丞上专下一.Item[0].上东与丛丞下丈专丈(丑专丙三丌一丗丕丙:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = val_18, 丈丐丆丛上丕丌上世 = val_18, 下一不一丁丟丄丑丒 = val_17}, 业万上丆丐丞且丒七:  业万上丆丐丞且丒七);
        }
        else
        {
                val_14.SetActive(value:  false);
        }
        
        val_21 = 1;
        label_15:
        if(val_21 < this.丟丕上一丞上专下一.Count)
        {
            goto label_26;
        }
        
        this.下丙丒下丏丈丐丕业 = true;
    }
    private void Awake()
    {
        if(this.okButton != 0)
        {
                this.okButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void LevelUpBanner::HandleOkPress(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        this.丟丕上一丞上专下一.Add(item:  this.baseFeatureItem);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemModuleChest, 丏业丟一东丂东丘丛:  false);
        Rilisoft.ButtonHandler val_5 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.itemGems.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void LevelUpBanner::丗专东丄丏丏三丏丝(Rilisoft.ButtonHandler 一丗世三专三万丞丞)));
        Rilisoft.ButtonHandler val_8 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.itemCoins.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void LevelUpBanner::丛丐丒丁业东世丂丌(Rilisoft.ButtonHandler 一丗世三专三万丞丞)));
        Rilisoft.ButtonHandler val_11 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.itemArmor.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void LevelUpBanner::丛丄丙丕丆丌丌世业(Rilisoft.ButtonHandler 一丗世三专三万丞丞)));
        Rilisoft.ButtonHandler val_14 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.itemHealth.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void LevelUpBanner::丞丗丙丟业丐丄丘东(Rilisoft.ButtonHandler 一丗世三专三万丞丞)));
        Rilisoft.ButtonHandler val_17 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.itemSignalPistol.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void LevelUpBanner::丁丙丛丞丞丑丙丛万(Rilisoft.ButtonHandler 一丗世三专三万丞丞)));
        Rilisoft.ButtonHandler val_20 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.ButtonHandler>(丄三丅七丆丛与与上:  this.itemFlamethrower.GetComponent<Rilisoft.ButtonHandler>(), 七丐丅专且专七三丆:  new System.Action<Rilisoft.ButtonHandler>(object:  this, method:  System.Void LevelUpBanner::丏三丙丄丕丒丆丅万(Rilisoft.ButtonHandler 一丗世三专三万丞丞)));
    }
    private void 丏丑业丑专世丄丆专()
    {
        var val_11;
        LevelUpBanner.丑与丅世东丙丙丕世<System.Boolean> val_13;
        this.丛丗丕丛丕下丂丈丒.Clear();
        ExpOpenSystem.丅一丐丌与丄上三丗 val_1 = 上且丁万与丌下丐上.丐丟东专丒丈一丅丕();
        this.丄丆丐丁一丐下不丟(丈丘丝一丗下丈丐不:  val_1.Progress, 一世专下丘丅万业业:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = this.丞丙且丕丅丌丂丂丘, 丈丐丆丛上丕丌上世 = this.丞丙且丕丅丌丂丂丘, 下一不一丁丟丄丑丒 = 上且丁万与丌下丐上.__il2cppRuntimeField_cctor_finished});
        if(Rilisoft.VIPController.丄东丅丐丁丅七丅与() != false)
        {
                this.丄丆丐丁一丐下不丟(丈丘丝一丗下丈丐不:  Rilisoft.VIPController.专上丄丁丏东三丂不(), 一世专下丘丅万业业:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = this.丕丁丟不万丁丗上世, 丈丐丆丛上丕丌上世 = this.丕丁丟不万丁丗上世, 下一不一丁丟丄丑丒 = Rilisoft.VIPController.__il2cppRuntimeField_cctor_finished});
        }
        
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count == 1)
        {
                this.丄丆丐丁一丐下不丟(丈丘丝一丗下丈丐不:  丑丝丞丒丅丄万丒三.万上丘丙丗丛丛丅丈(), 一世专下丘丅万业业:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = this.下丗三丅且丁万专且, 丈丐丆丛上丕丌上世 = this.下丗三丅且丁万专且, 下一不一丁丟丄丑丒 = 丑丝丞丒丅丄万丒三.__il2cppRuntimeField_cctor_finished});
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = LevelUpBanner.<>c.<>9__86_0;
        if(val_13 == null)
        {
                LevelUpBanner.丑与丅世东丙丙丕世<System.Boolean> val_8 = null;
            val_13 = val_8;
            val_8 = new LevelUpBanner.丑与丅世东丙丙丕世<System.Boolean>(三一丄丗专丌丛丘丅:  LevelUpBanner.<>c.__il2cppRuntimeField_static_fields, 丛丌丙世专世东丕下:  System.Boolean LevelUpBanner.<>c::丒七丅上丟上与丘丕());
            LevelUpBanner.<>c.<>9__86_0 = val_13;
        }
        
        System.Collections.Generic.List<丝不丕丁且丅丟丘丛> val_9 = new System.Collections.Generic.List<丝不丕丁且丅丟丘丛>();
        val_9.Add(item:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = this.丗丒丙七世且丕丈与, 丈丐丆丛上丕丌上世 = this.丗丒丙七世且丕丈与, 下一不一丁丟丄丑丒 = 1152921530797684544});
        this.下世不丗丘丑丟丄丞.set_Item(key:  val_8, value:  val_9);
    }
    private void 丄丆丐丁一丐下不丟(int 丈丘丝一丗下丈丐不, LevelUpBanner.丝不丕丁且丅丟丘丛 一世专下丘丅万业业)
    {
        System.Collections.Generic.List<丝不丕丁且丅丟丘丛> val_4;
        if((this.丛丗丕丛丕下丂丈丒.ContainsKey(key:  丈丘丝一丗下丈丐不)) != false)
        {
                val_4 = this.丛丗丕丛丕下丂丈丒.Item[丈丘丝一丗下丈丐不];
        }
        else
        {
                System.Collections.Generic.List<丝不丕丁且丅丟丘丛> val_3 = null;
            val_4 = val_3;
            val_3 = new System.Collections.Generic.List<丝不丕丁且丅丟丘丛>();
            this.丛丗丕丛丕下丂丈丒.Add(key:  丈丘丝一丗下丈丐不, value:  val_3);
        }
        
        val_3.Add(item:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = 一世专下丘丅万业业.万丑丞一丝丌丐丒丘, 丈丐丆丛上丕丌上世 = 一世专下丘丅万业业.万丑丞一丝丌丐丒丘, 下一不一丁丟丄丑丒 = 一世专下丘丅万业业.下一不一丁丟丄丑丒});
    }
    private void 且丄且丙丏丟万世丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        UnityEngine.Object val_14;
        UnityEngine.Transform val_15;
        int val_16;
        var val_17;
        var val_18;
        val_15 = this;
        if(不丟丗丏丛丕不丁丌 == null)
        {
                return;
        }
        
        UnityEngine.Object val_1 = (null == null) ? 不丟丗丏丛丕不丁丌 : 0;
        if(val_1 == 0)
        {
                return;
        }
        
        val_14 = val_1.gameObject;
        if(val_14 == 0)
        {
                return;
        }
        
        val_16 = System.String.alignConst;
        if(val_14 != this.itemGems)
        {
            goto label_11;
        }
        
        val_17 = null;
        val_17 = null;
        val_16 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        if(this.世且丞丝不丅丟丅丙 == null)
        {
            goto label_21;
        }
        
        val_14 = this.世且丞丝不丅丟丅丙.丈专七丞三丙丘丛与;
        goto label_23;
        label_11:
        if(val_14 != this.itemCoins)
        {
            goto label_18;
        }
        
        val_18 = null;
        val_18 = null;
        val_16 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        if(this.世且丞丝不丅丟丅丙 == null)
        {
            goto label_21;
        }
        
        val_14 = this.世且丞丝不丅丟丅丙.丁丂丝丗七下万丞丐;
        goto label_23;
        label_21:
        val_14 = 0;
        goto label_23;
        label_18:
        if(val_14 != this.itemArmor)
        {
            goto label_26;
        }
        
        if(this.世且丞丝不丅丟丅丙 == null)
        {
            goto label_28;
        }
        
        val_16 = this.世且丞丝不丅丟丅丙.丑丗丅丕专丞丝万丒;
        goto label_28;
        label_26:
        string val_9 = (val_14 != this.itemHealth) ? "" : (val_16);
        label_28:
        val_14 = 1;
        label_23:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == true)
        {
                return;
        }
        
        val_15 = this.gameObject.transform;
        Rilisoft.ItemViewer val_13 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  val_15, 丕丁下丌不万丅丞丛:  val_9, 丅三丟世下丞丝丙万:  1, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  false, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
    }
    private void Update()
    {
        if(this.三七丗丕丛不七丑丛 != true)
        {
                this.三七丗丕丛不七丑丛 = this.lowBorderContent.isVisible;
        }
        
        if(this.downArrow != 0)
        {
                this.downArrow.SetActive(value:  (this.三七丗丕丛不七丑丛 == false) ? 1 : 0);
        }
        
        if(this.perfectButtonLabel != 0)
        {
                this.perfectButtonLabel.SetActive(value:  (this.三七丗丕丛不七丑丛 == false) ? 1 : 0);
        }
        
        if(this.okButtonLabel == 0)
        {
                return;
        }
        
        this.okButtonLabel.SetActive(value:  (this.三七丗丕丛不七丑丛 == true) ? 1 : 0);
    }
    private void LateUpdate()
    {
        if(this.下丙丒下丏丈丐丕业 != false)
        {
                if(this.levelUpPanel.activeSelf != false)
        {
                this.下丙丒下丏丈丐丕业 = false;
            UnityEngine.Bounds val_3 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(丄上七丟不丗丕下丟:  this.featuresTable.transform);
            this.featureBG.height = (UnityEngine.Mathf.RoundToInt(f:  V1.16B)) + 40;
        }
        
        }
        
        if((this.丑万三万丑七丈丂一 == false) || (this.levelUpPanel.activeSelf == false))
        {
            goto label_11;
        }
        
        if(this.newContentScroll == null)
        {
            goto label_12;
        }
        
        if(this.丝专与丅世万丕上七 == false)
        {
            goto label_13;
        }
        
        label_15:
        this.newContentScroll.ResetPosition();
        goto label_14;
        label_12:
        if(this.丝专与丅世万丕上七 == true)
        {
            goto label_15;
        }
        
        label_13:
        label_14:
        this.丑万三万丑七丈丂一 = false;
        label_11:
        if(this.丝七丗丄丏东世丘丙 == false)
        {
                return;
        }
        
        if(this.levelUpPanel.activeSelf == false)
        {
                return;
        }
        
        this.丝七丗丄丏东世丘丙 = false;
        this.windowTable.repositionNow = true;
        this = this.bannerScroll;
        this.ResetPosition();
    }
    private void 丟专世专丈丂丗丞丄()
    {
        if(this.okButton.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.HandleOkPress(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  null);
    }
    public void HandleOkPress(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_12;
        var val_13;
        if(this.三七丗丕丛不七丑丛 != true)
        {
                if(this.丞丒一与业丗业世丑 == false)
        {
            goto label_2;
        }
        
        }
        
        ExpController.丑七不且上丗丁一世().HandleContinueButton(世丞丑上丅与世丁世:  this.gameObject);
        LevelUpBanner.<七且丁东丝丛丁且专>k__BackingField = ExperienceController.丞丞丘业东丙丏七丌();
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丄上丟丈下丂丑丏丛() != false)
        {
                业丈不上丟万一丕丏.丑七不且上丗丁一世().上丄与丂不且丑丞丛();
            return;
        }
        
        if((BalanceController.丈丟丂七丂丂丑万丂(丝丈三丐丏丐且一三:  ExperienceController.丞丞丘业东丙丏七丌())) != false)
        {
                PGCompany.丕丝下丁七东丄三丑.丗与丆丏丝下丅丕世(丈丁下不丐丑丈丈业:  0, 专上且丗丑丌丟丈丄:  false, 丁丟丑丆三丆业一丅:  0);
            return;
        }
        
        val_12 = 1152921505189646336;
        val_13 = null;
        val_13 = null;
        if(GameController.onlineMode == null)
        {
                return;
        }
        
        var val_9 = (null == null) ? GameController.onlineMode : 0;
        if(null != null)
        {
                return;
        }
        
        val_12 = mem[onlineMode == null ? GameController.onlineMode : 0 + 512];
        val_12 = onlineMode == null ? GameController.onlineMode : 0 + 512;
        mem2[0] = 0;
        return;
        label_2:
        this.丞丒一与业丗业世丑 = true;
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.下下丑丐不万丛万下());
    }
    private System.Collections.IEnumerator 下下丑丐不万丛万下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LevelUpBanner.丅丝丏丅丄丂丝丏七();
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void LevelUpBanner::丟专世专丈丂丗丞丄()), 与且专丈不万东一万:  "Level up banner");
        this.bannerScroll.ResetPosition();
        this.newContentScroll.ResetPosition();
    }
    private void OnDisable()
    {
        this.专下丛不丅丌丈丗丞();
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
        this.专下丛不丅丌丈丗丞();
    }
    private void 专下丛不丅丌丈丗丞()
    {
        null = null;
        BankController.丂七上业下丆丄东丄 = true;
        BankController.且丗丛丏丂丒世丒业();
    }
    private void 丏丝丟丆与一一丈丟()
    {
        bool val_5 = this.丒世丅业丝东下与丗;
        val_5 = val_5 ^ 1;
        this.丒世丅业丝东下与丗 = val_5;
        if((this.tierObjects != null) && (this.tierObjects.Length >= 1))
        {
                do
        {
            this.tierObjects[0].SetActive(value:  (this.丒世丅业丝东下与丗 == true) ? 1 : 0);
        }
        while((0 + 1) < this.tierObjects.Length);
        
        }
        
        if(this.defaultObjects == null)
        {
                return;
        }
        
        if(this.defaultObjects.Length < 1)
        {
                return;
        }
        
        do
        {
            this.defaultObjects[0].SetActive(value:  (this.丒世丅业丝东下与丗 == false) ? 1 : 0);
        }
        while((0 + 1) < this.defaultObjects.Length);
    
    }
    public LevelUpBanner()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 丝不丕丁且丅丟丘丛> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 丝不丕丁且丅丟丘丛>();
        val_1.Add(key:  20, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_royale_face", 丈丐丆丛上丕丌上世 = "Key_5420", 下一不一丁丟丄丑丒 = "Key_5421"});
        val_1.Add(key:  0, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_death_znachek", 丈丐丆丛上丕丌上世 = "Key_0104", 下一不一丁丟丄丑丒 = "Key_0550"});
        val_1.Add(key:  1, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_coop_survival", 丈丐丆丛上丕丌上世 = "Key_0135", 下一不一丁丟丄丑丒 = "Key_0552"});
        val_1.Add(key:  4, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_flag_znachek", 丈丐丆丛上丕丌上世 = "Key_0113", 下一不一丁丟丄丑丒 = "Key_0554"});
        val_1.Add(key:  5, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_capture_point", 丈丐丆丛上丕丌上世 = "Key_1263", 下一不一丁丟丄丑丒 = "Key_1368"});
        val_1.Add(key:  3, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_deadly_games_znachek", 丈丐丆丛上丕丌上世 = "Key_0121", 下一不一丁丟丄丑丒 = "Key_3733"});
        val_1.Add(key:  16, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_brawl", 丈丐丆丛上丕丌上世 = "Key_3634", 下一不一丁丟丄丑丒 = "Key_3635"});
        val_1.Add(key:  17, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "level_up_ram", 丈丐丆丛上丕丌上世 = "Key_8307", 下一不一丁丟丄丑丒 = "Key_8308"});
        val_1.Add(key:  22, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "reid_icon", 丈丐丆丛上丕丌上世 = "Key_7042", 下一不一丁丟丄丑丒 = "Key_7048"});
        val_1.Add(key:  31, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "icon_freeplay_mode", 丈丐丆丛上丕丌上世 = "Key_10204", 下一不一丁丟丄丑丒 = "Key_10205"});
        this.丕一丕且丄东丌七丌 = val_1;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 丝不丕丁且丅丟丘丛> val_2 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 丝不丕丁且丅丟丘丛>();
        val_2.Add(key:  11, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_campaign_znachek", 丈丐丆丛上丕丌上世 = "Key_0018", 下一不一丁丟丄丑丒 = "Key_3735"});
        val_2.Add(key:  9, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_sandbox_znachek", 丈丐丆丛上丕丌上世 = "Key_1567", 下一不一丁丟丄丑丒 = "Key_3732"});
        val_2.Add(key:  12, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_arena_znachek", 丈丐丆丛上丕丌上世 = "Key_0502", 下一不一丁丟丄丑丒 = "Key_0848"});
        val_2.Add(key:  10, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_parkour_znachek", 丈丐丆丛上丕丌上世 = "Key_3164", 下一不一丁丟丄丑丒 = "Key_3734"});
        val_2.Add(key:  13, value:  new 丝不丕丁且丅丟丘丛() {万丑丞一丝丌丐丒丘 = "mode_run_znachek", 丈丐丆丛上丕丌上世 = "Key_3165", 下一不一丁丟丄丑丒 = "Key_3182"});
        this.世丝丗丅且不丆七丟 = val_2;
        this.丕丁丟不万丁丗上世 = "offer_icon_VIP";
        mem[1152921530802435856] = "Key_4053";
        mem[1152921530802435864] = "Key_4054";
        this.丂丑万丈丙专万东丘 = "level_up_clan";
        mem[1152921530802435880] = "Key_0072";
        mem[1152921530802435888] = "Key_4354";
        this.丝丙丝丕业万七与丞 = "level_up_fort";
        mem[1152921530802435904] = "Key_8305";
        mem[1152921530802435912] = "Key_8306";
        this.丈丁世与专丝丛三世 = "bp_shield_gold";
        mem[1152921530802435928] = "Key_5725";
        mem[1152921530802435936] = "Key_6140";
        this.万业丐丘丒三丄丒七 = "modules_icon";
        mem[1152921530802435952] = "Key_7131";
        mem[1152921530802435960] = "Key_7204";
        this.下丗三丅且丁万专且 = "accounts_icon";
        mem[1152921530802435976] = "Key_7390";
        mem[1152921530802435984] = "Key_7541";
        this.丞丙且丕丅丌丂丂丘 = "almanach_icon";
        mem[1152921530802436000] = "Key_7547";
        mem[1152921530802436008] = "Key_7749";
        this.七七与丑丟丂丕丕丌 = "QuestShield";
        mem[1152921530802436024] = "Key_8303";
        mem[1152921530802436032] = "Key_8304";
        this.丗丒丙七世且丕丈与 = "marathon_icon";
        mem[1152921530802436048] = "Key_10275";
        mem[1152921530802436056] = "Key_10276";
        this.丗丆丟世丒三丙东一 = "loadouts_icon";
        mem[1152921530802436072] = "Key_10630";
        mem[1152921530802436080] = "Key_10631";
        this.丛丗丕丛丕下丂丈丒 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丝不丕丁且丅丟丘丛>>();
        this.下世不丗丘丑丟丄丞 = new System.Collections.Generic.Dictionary<LevelUpBanner.丑与丅世东丙丙丕世<System.Boolean>, System.Collections.Generic.List<丝不丕丁且丅丟丘丛>>();
        this.丙丙与丕不丞丛丐业 = new System.Collections.Generic.List<LevelUpBannerNewContentView>();
        this.丟丕上一丞上专下一 = new System.Collections.Generic.List<LevelUpFeatureItem>();
    }
    private void 丗专东丄丏丏三丏丝(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
    {
        一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LevelUpBanner::且丄且丙丏丟万世丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丛丐丒丁业东世丂丌(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
    {
        一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LevelUpBanner::且丄且丙丏丟万世丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丛丄丙丕丆丌丌世业(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
    {
        一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LevelUpBanner::且丄且丙丏丟万世丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丞丗丙丟业丐丄丘东(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
    {
        一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LevelUpBanner::且丄且丙丏丟万世丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丁丙丛丞丞丑丙丛万(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
    {
        一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LevelUpBanner::且丄且丙丏丟万世丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丏三丙丄丕丒丆丅万(Rilisoft.ButtonHandler 一丗世三专三万丞丞)
    {
        一丗世三专三万丞丞.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LevelUpBanner::且丄且丙丏丟万世丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }

}
