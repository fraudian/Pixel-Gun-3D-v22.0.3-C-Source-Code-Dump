using UnityEngine;
public class DungeonWindowUI : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.Dictionary<int, DungeonWindowUI.万丗且专万丟丌丂丐> dungeonsInfo;
    public static System.Collections.Generic.Dictionary<int, PGCompany.ModuleData.ModuleType[]> dungeonsCheckModulesParams;
    public UnityEngine.Texture[] mobModuleTypeIcons;
    public static string[] mobModuleTypeLocalizations;
    public Rilisoft.ButtonHandler backBtn;
    public UnityEngine.GameObject easyLock;
    public UnityEngine.GameObject mediumLock;
    public UnityEngine.GameObject hardLock;
    public UnityEngine.GameObject easyToggleLabel;
    public UnityEngine.GameObject mediumToggleLabel;
    public UnityEngine.GameObject hardToggleLabel;
    public UILabel easyLockLevel;
    public UILabel mediumLockLevel;
    public UILabel hardLockLevel;
    public UIButton easyToggleBtn;
    public UIButton mediumToggleBtn;
    public UIButton hardToggleBtn;
    public UIToggle easyToggle;
    public UIToggle mediumToggle;
    public UIToggle hardToggle;
    public UnityEngine.GameObject easyToggledObj;
    public UnityEngine.GameObject mediumToggledObj;
    public UnityEngine.GameObject hardToggledObj;
    public UnityEngine.GameObject goBattleObj;
    public UnityEngine.GameObject goBattleDisabledObj;
    public UITable monsterTypeTable;
    public UITexture[] monsterTypes;
    public UILabel[] monsterTypesLevels;
    public UITexture[] bossTypes;
    public UILabel[] bossTypesLevels;
    public UITexture dungeonIcon;
    public UILabel[] headerLabel;
    public UILabel descLabel;
    public DungeonWindowRewardItem[] rewardItems;
    public DungeonWindowRewardItem[] specRewardItems;
    public UIGrid rewardGrid;
    public UIGrid specRewardGrid;
    private 丐七不丝丆丐丂丐下 丞丒丌丄丄丏下下专;
    private bool 丆丛丅丞七七丞丘丞;
    private bool 东一丗丁世丒丒一丙;
    private int 下丞七丒业丂丈丘下;
    internal bool 丑丗与世丕万丟丞丛;
    public bool squadInstance;
    private static int[] 东丌丗丗专三丅且丗;
    
    // Methods
    private void Awake()
    {
        goto label_1;
        label_7:
        this.specRewardItems[0].GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DungeonWindowUI::丅丟不丂丑丒丗丗丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        0 = 1;
        label_1:
        if(0 < this.specRewardItems.Length)
        {
            goto label_7;
        }
    
    }
    internal void 上东与丛丞下丈专丈(PGCompany.GameModeHub.万业世丙丗丌与不丆 下丒丏丙一不七丕丏)
    {
        null = null;
        SceneInfo val_1 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  下丒丏丙一不七丕丏.丝丏丘丁丝上丅丆下);
        this.上东与丛丞下丈专丈(下丞七丒业丂丈丘下:  val_1.indexMap, 丏丒与一上丂三丂丑:  下丒丏丙一不七丕丏.丑东丐下专丞丕丘世());
    }
    internal void 上东与丛丞下丈专丈(MapPreviewController 下丒丏丙一不七丕丏)
    {
    
    }
    internal void 上东与丛丞下丈专丈(int 下丞七丒业丂丈丘下, UnityEngine.Texture 丏丒与一上丂三丂丑)
    {
        if(this.squadInstance != true)
        {
                this.hardToggle.Set(丏业丟一东丂东丘丛:  false);
            this.mediumToggle.Set(丏业丟一东丂东丘丛:  false);
            this.easyToggle.Set(丏业丟一东丂东丘丛:  true);
        }
        
        this.丞丒丌丄丄丏下下专 = 1;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.dungeonIcon, y:  0);
        this.下丞七丒业丂丈丘下 = 下丞七丒业丂丈丘下;
        this.与不下丑丞与丝一与();
        this.丙不丄丂丗丒下世下();
        this.丛丛丅东丅丈丁与丏();
    }
    private void 丛丛丅东丅丈丁与丏()
    {
        var val_4;
        DungeonWindowRewardItem val_5;
        PGCompany.三丘丌上丁万丏丛丟 val_6;
        val_4 = 0;
        goto label_1;
        label_20:
        if(val_4 != 0)
        {
                val_5 = 0;
            this.specRewardItems[val_5].gameObject.SetActive(value:  false);
        }
        else
        {
                丐七不丝丆丐丂丐下 val_5 = this.丞丒丌丄丄丏下下专;
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = DungeonWindowUI.丄上且丏丅丞丂丙上(丒万丟丅丌丝丟下下:  val_5);
            if(val_2 != null)
        {
                val_5 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_6 = 0;
        }
        
            this.specRewardItems[0].gameObject.SetActive(value:  true);
            val_5 = this.specRewardItems[0];
            val_5.丐丘丑丞世丝丕世丗(业丆丙丆丅丌丛丙丘:  val_6);
        }
        
        val_4 = 1;
        label_1:
        if(val_4 < this.specRewardItems.Length)
        {
            goto label_20;
        }
        
        this.东一丗丁世丒丒一丙 = true;
    }
    internal static PGCompany.丗丟丄丈东丝丕丄世 丄上且丏丅丞丂丙上(丐七不丝丆丐丂丐下 丒万丟丅丌丝丟下下)
    {
        object val_9;
        var val_10;
        var val_11;
        DungeonWindowUI.且丘东丙不三丈丗丁 val_1 = null;
        val_9 = val_1;
        val_1 = new DungeonWindowUI.且丘东丙不三丈丗丁();
        if(ExpController.万上一丝丆且七丅丅() < 1)
        {
            goto label_10;
        }
        
        .丗万丛丁丟不丆丐七 = 0;
        if(丒万丟丅丌丝丟下下 == 3)
        {
            goto label_5;
        }
        
        if(丒万丟丅丌丝丟下下 == 2)
        {
            goto label_6;
        }
        
        if(丒万丟丅丌丝丟下下 != 1)
        {
            goto label_7;
        }
        
        val_10 = 1152921525967170432;
        goto label_9;
        label_5:
        val_10 = 1152921525967170432;
        goto label_9;
        label_6:
        val_10 = 1152921525967170432;
        label_9:
        mem[1152921525967260240] = 0;
        label_7:
        if((1152921525967260240 & 1) != 0)
        {
                ModuleChestData val_5 = System.Linq.Enumerable.FirstOrDefault<ModuleChestData>(source:  丐东不丅丂丂丅丙不.丁世与业丈丅业丒与(), predicate:  new System.Func<ModuleChestData, System.Boolean>(object:  val_1, method:  System.Boolean DungeonWindowUI.且丘东丙不三丈丗丁::万丂丒丗丅上丗业上(ModuleChestData 三丟东丕丄丄下下丑)));
            if(val_5 == null)
        {
                return (PGCompany.丗丟丄丈东丝丕丄世)val_11;
        }
        
            val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丗丟丄丈东丝丕丄世 val_8 = val_9.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  val_5.id);
            return (PGCompany.丗丟丄丈东丝丕丄世)val_11;
        }
        
        label_10:
        val_11 = 0;
        return (PGCompany.丗丟丄丈东丝丕丄世)val_11;
    }
    private void 与不下丑丞与丝一与()
    {
        int val_3;
        丒丗专丝三与丑丏三[] val_4;
        int val_5;
        int val_6;
        丒丗专丝三与丑丏三[] val_7;
        int val_8;
        int val_9;
        int val_10;
        string val_11;
        string val_12;
        var val_31;
        int val_32;
        var val_33;
        var val_34;
        string val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        val_31 = null;
        val_31 = null;
        val_32 = this.下丞七丒业丂丈丘下;
        if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  val_32)) == false)
        {
            goto label_93;
        }
        
        val_33 = null;
        val_33 = null;
        万丗且专万丟丌丂丐 val_2 = DungeonWindowUI.dungeonsInfo.Item[this.下丞七丒业丂丈丘下];
        if((this.headerLabel != null) && (this.headerLabel.Length >= 1))
        {
                do
        {
            val_34 = 0;
            this.headerLabel[val_34].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
        }
        while((val_34 + 1) < this.headerLabel.Length);
        
        }
        
        val_35 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_12);
        this.descLabel.text = val_35;
        val_36 = 0;
        goto label_18;
        label_53:
        if(val_36 >= (val_4 + 24))
        {
            goto label_20;
        }
        
        val_34 = 0;
        var val_16 = val_4 + 0;
        if(((val_4 + 0) + 32) <= this.丞丒丌丄丄丏下下专)
        {
            goto label_22;
        }
        
        label_20:
        this.monsterTypes[0].gameObject.SetActive(value:  false);
        goto label_27;
        label_22:
        this.monsterTypes[val_34].gameObject.SetActive(value:  true);
        UITexture val_35 = this.monsterTypes[val_34];
        var val_19 = val_4 + 0;
        UnityEngine.Texture val_36 = this.mobModuleTypeIcons[(val_4 + 0) + 36];
        this.monsterTypesLevels[val_34].gameObject.SetActive(value:  true);
        if(this.丞丒丌丄丄丏下下专 == 1)
        {
            goto label_44;
        }
        
        val_37 = val_9;
        if(this.丞丒丌丄丄丏下下专 == 2)
        {
            goto label_48;
        }
        
        if(this.丞丒丌丄丄丏下下专 != 3)
        {
            goto label_46;
        }
        
        val_37 = val_6;
        goto label_48;
        label_44:
        val_37 = val_8;
        goto label_48;
        label_46:
        val_37 = 0;
        label_48:
        val_35 = PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  0);
        this.monsterTypesLevels[val_34].text = val_35;
        label_27:
        val_36 = 1;
        label_18:
        if(val_36 < this.monsterTypes.Length)
        {
            goto label_53;
        }
        
        val_38 = 0;
        goto label_54;
        label_90:
        if(val_38 >= (val_7 + 24))
        {
            goto label_56;
        }
        
        val_34 = 0;
        var val_22 = val_4 + 0;
        if(((val_4 + 0) + 32) <= this.丞丒丌丄丄丏下下专)
        {
            goto label_59;
        }
        
        label_56:
        this.bossTypes[0].gameObject.SetActive(value:  false);
        goto label_64;
        label_59:
        this.bossTypes[val_34].gameObject.SetActive(value:  true);
        UITexture val_41 = this.bossTypes[val_34];
        var val_25 = val_7 + 0;
        UnityEngine.Texture val_42 = this.mobModuleTypeIcons[(val_7 + 0) + 36];
        this.bossTypesLevels[val_34].gameObject.SetActive(value:  true);
        if(this.丞丒丌丄丄丏下下专 == 1)
        {
            goto label_81;
        }
        
        val_39 = val_9;
        if(this.丞丒丌丄丄丏下下专 == 2)
        {
            goto label_85;
        }
        
        if(this.丞丒丌丄丄丏下下专 != 3)
        {
            goto label_83;
        }
        
        val_39 = val_6;
        goto label_85;
        label_81:
        val_39 = val_8;
        goto label_85;
        label_83:
        val_39 = 0;
        label_85:
        val_35 = PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  0);
        this.bossTypesLevels[val_34].text = val_35;
        label_64:
        val_38 = 1;
        label_54:
        val_32 = this.bossTypes;
        if(val_38 < this.bossTypes.Length)
        {
            goto label_90;
        }
        
        string val_45 = val_12;
        val_45 = this.丏专丙万与丑丒丝与(东一丁世丑丞业丄丐:  new 万丗且专万丟丌丂丐() {下丞七丒业丂丈丘下 = val_3, 不丙且丄上且万丙丞 = val_4, 专丆丌丞丙丅丌丄丕 = val_7, 丙丌七三与丟世与且 = val_8, 丁丝丗丛丆丛且丈上 = val_9, 下丝丒丕丅丆丐丑丁 = val_6, 丆丁东七专与丞与上 = val_5, 丄上七业丅丅丕业三 = val_5, 万世且上上东三万专 = val_10, 丈丐丆丛上丕丌上世 = val_11, 下一不一丁丟丄丑丒 = val_45});
        this.丑丗与世丕万丟丞丛 = val_45;
        if(this.goBattleObj != 0)
        {
                this.goBattleObj.SetActive(value:  (this.丑丗与世丕万丟丞丛 == true) ? 1 : 0);
            val_32 = this.丑丗与世丕万丟丞丛;
            this.goBattleDisabledObj.SetActive(value:  (val_32 == false) ? 1 : 0);
        }
        
        label_93:
        this.丆丛丅丞七七丞丘丞 = true;
    }
    private void LateUpdate()
    {
        if(this.丆丛丅丞七七丞丘丞 != false)
        {
                this.丆丛丅丞七七丞丘丞 = false;
        }
        
        if(this.东一丗丁世丒丒一丙 == false)
        {
                return;
        }
        
        this.东一丗丁世丒丒一丙 = false;
    }
    private void 丙不丄丂丗丒下世下()
    {
        var val_5;
        var val_10;
        UIButton val_39;
        var val_40;
        var val_41;
        var val_42;
        val_39 = this;
        if(this.squadInstance == true)
        {
                return;
        }
        
        val_40 = null;
        val_40 = null;
        if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  this.下丞七丒业丂丈丘下)) != false)
        {
                val_41 = null;
            val_41 = null;
            万丗且专万丟丌丂丐 val_2 = DungeonWindowUI.dungeonsInfo.Item[this.下丞七丒业丂丈丘下];
            万丗且专万丟丌丂丐 val_7 = DungeonWindowUI.dungeonsInfo.Item[this.下丞七丒业丂丈丘下];
            万丗且专万丟丌丂丐 val_12 = DungeonWindowUI.dungeonsInfo.Item[this.下丞七丒业丂丈丘下];
            val_42;
        }
        else
        {
                val_42 = 0;
        }
        
        val_42 = val_42;
        int val_17 = ExperienceController.丂丂下丑且下丌丝东();
        int val_18 = ExperienceController.丂丂下丑且下丌丝东();
        int val_19 = ExperienceController.丂丂下丑且下丌丝东();
        this.easyLockLevel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  val_5.ToString());
        this.mediumLockLevel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  val_10.ToString());
        this.hardLockLevel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  val_42.ToString());
        this.easyLock.SetActive(value:  (val_17 < val_5) ? 1 : 0);
        this.mediumLock.SetActive(value:  (val_18 < val_10) ? 1 : 0);
        this.hardLock.SetActive(value:  (val_19 < val_42) ? 1 : 0);
        this.easyToggleLabel.SetActive(value:  (val_17 >= val_5) ? 1 : 0);
        this.mediumToggleLabel.SetActive(value:  (val_18 >= val_10) ? 1 : 0);
        this.hardToggleLabel.SetActive(value:  (val_19 >= val_42) ? 1 : 0);
        var val_35 = (val_17 >= val_5) ? 1 : 0;
        var val_36 = (val_18 >= val_10) ? 1 : 0;
        val_39 = this.hardToggleBtn;
        var val_37 = (val_19 >= val_42) ? 1 : 0;
    }
    public void HandleGoBtnClick()
    {
        this.丆丑丑丆丗丗且丛丑();
    }
    internal static int[] 丑丄且业丕丌丈且专()
    {
        var val_4;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        val_22 = null;
        val_22 = null;
        DungeonWindowUI.东丌丗丗专三丅且丗.__unknownFiledOffset_20 = 0;
        DungeonWindowUI.东丌丗丗专三丅且丗.__unknownFiledOffset_24 = 0;
        DungeonWindowUI.东丌丗丗专三丅且丗.__unknownFiledOffset_28 = 0;
        val_23 = null;
        val_23 = null;
        List.Enumerator<T> val_2 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().GetEnumerator();
        val_24 = 0;
        val_25 = 0;
        var val_22 = 0;
        label_73:
        if(((-111613504) & 1) == 0)
        {
            goto label_13;
        }
        
        List.Enumerator<T> val_10 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  val_4.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛()).丟且丘丗七且下三专().GetEnumerator();
        goto label_41;
        label_50:
        string val_11 = val_4.丐丏七丌丕丗业且上();
        ModuleType val_12 = val_11.与丝丅丘且丐上丅世();
        if(val_12 == 1)
        {
            goto label_21;
        }
        
        if(val_12 == 2)
        {
            goto label_22;
        }
        
        if(val_12 != 3)
        {
            goto label_41;
        }
        
        val_26 = null;
        val_26 = null;
        DungeonWindowUI.东丌丗丗专三丅且丗.__unknownFiledOffset_28 = UnityEngine.Mathf.Max(a:  DungeonWindowUI.东丌丗丗专三丅且丗 + 40, b:  val_11.丑业世丞上丂丄丟丞());
        goto label_41;
        label_21:
        val_27 = null;
        val_27 = null;
        DungeonWindowUI.东丌丗丗专三丅且丗.__unknownFiledOffset_20 = UnityEngine.Mathf.Max(a:  DungeonWindowUI.东丌丗丗专三丅且丗 + 32, b:  val_11.丑业世丞上丂丄丟丞());
        goto label_41;
        label_22:
        val_28 = null;
        val_28 = null;
        DungeonWindowUI.东丌丗丗专三丅且丗.__unknownFiledOffset_24 = UnityEngine.Mathf.Max(a:  DungeonWindowUI.东丌丗丗专三丅且丗 + 36, b:  val_11.丑业世丞上丂丄丟丞());
        label_41:
        if(((-111613536) & 1) != 0)
        {
            goto label_50;
        }
        
        val_22 = val_22 + 1;
        mem2[0] = 230;
        val_29 = val_25;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_22 == 1) || ((1152921525970069872 + ((0 + 1)) << 2) != 230))
        {
            goto label_70;
        }
        
        var val_23 = 0;
        val_23 = val_23 ^ (val_22 >> 31);
        val_22 = val_22 + val_23;
        goto label_73;
        label_70:
        if( == 0)
        {
            goto label_73;
        }
        
        goto label_73;
        label_13:
        val_22 = val_22 + 1;
        mem2[0] = 258;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_22 == 1)
        {
            goto label_83;
        }
        
        if(( == 0) || ((1152921525970069872 + ((0 + 1)) << 2) == 258))
        {
            goto label_89;
        }
        
        label_88:
        label_89:
        val_30 = null;
        val_30 = null;
        return (System.Int32[])DungeonWindowUI.东丌丗丗专三丅且丗;
        label_83:
        if( != 0)
        {
            goto label_88;
        }
        
        goto label_89;
    }
    internal bool 丏专丙万与丑丒丝与(DungeonWindowUI.万丗且专万丟丌丂丐 东一丁世丑丞业丄丐)
    {
        System.Int32[] val_1 = DungeonWindowUI.丑丄且业丕丌丈且专();
    }
    private void 丆丑丑丆丗丗且丛丑()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        GameConnect.与丝丒万且丘丂丟三 = this.丞丒丌丄丄丏下下专;
        val_2 = static_value_081DACA8;
        val_2 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.HandleGoBtnClicked();
    }
    public void OnHardSelectionValueChanged()
    {
        丐七不丝丆丐丂丐下 val_10;
        if(this.easyToggle.value == false)
        {
            goto label_1;
        }
        
        val_10 = 1;
        goto label_5;
        label_1:
        if(this.mediumToggle.value == false)
        {
            goto label_4;
        }
        
        val_10 = 2;
        goto label_5;
        label_4:
        if(this.hardToggle.value == false)
        {
            goto label_7;
        }
        
        val_10 = 3;
        label_5:
        this.丞丒丌丄丄丏下下专 = val_10;
        label_7:
        this.easyToggledObj.SetActive(value:  this.easyToggle.value);
        this.mediumToggledObj.SetActive(value:  this.mediumToggle.value);
        this.hardToggledObj.SetActive(value:  this.hardToggle.value);
        this.与不下丑丞与丝一与();
        this.丛丛丅东丅丈丁与丏();
    }
    public void SetDifficulty(丐七不丝丆丐丂丐下 丒万丟丅丌丝丟下下)
    {
        this.丞丒丌丄丄丏下下专 = 丒万丟丅丌丝丟下下;
        this.与不下丑丞与丝一与();
        this.丛丛丅东丅丈丁与丏();
    }
    internal void 丅丟不丂丑丒丗丗丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        SquadPanelGUI val_6;
        SquadPanelGUI val_7;
        PGCompany.三丘丌上丁万丏丛丟 val_8;
        var val_9;
        var val_10;
        val_6 = this;
        val_7 = DungeonWindowUI.丄上且丏丅丞丂丙上(丒万丟丅丌丝丟下下:  this.丞丒丌丄丄丏下下专);
        if(val_7 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_8 = 0;
        if(this.squadInstance == false)
        {
            goto label_5;
        }
        
        label_15:
        val_9 = null;
        val_9 = null;
        val_7 = SquadPanelGUI.丄丘七三上丕世丞业;
        if(val_7 == 0)
        {
            goto label_18;
        }
        
        val_10 = null;
        val_10 = null;
        val_6 = SquadPanelGUI.丄丘七三上丕世丞业;
        if(val_6 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_4:
        if(this.squadInstance == true)
        {
            goto label_15;
        }
        
        label_5:
        if(val_7 != null)
        {
                if(null == null)
        {
            goto label_17;
        }
        
        }
        
        val_8 = 0;
        goto label_18;
        label_17:
        val_8 = val_7;
        label_18:
        PGCompany.ModuleChestViewer val_5 = PGCompany.ModuleChestViewer.下与丞三丅丛丄七丕(丐下丝丘丑丟丟丗丌:  val_8, 丆丏七丟不丒与七专:  this.transform);
    }
    public DungeonWindowUI()
    {
    
    }
    private static DungeonWindowUI()
    {
        int val_10;
        int val_11;
        System.Collections.Generic.Dictionary<System.Int32, 万丗且专万丟丌丂丐> val_1 = new System.Collections.Generic.Dictionary<System.Int32, 万丗且专万丟丌丂丐>();
        丒丗专丝三与丑丏三[] val_2 = new 丒丗专丝三与丑丏三[3];
        val_10 = val_2.Length;
        if(val_10 == 0)
        {
                val_10 = val_2.Length;
        }
        
        val_2[0] = 4294967297;
        if(val_10 <= 1)
        {
                val_10 = val_2.Length;
        }
        
        val_2[1] = 8589934594;
        val_2[2] = 12884901891;
        丒丗专丝三与丑丏三[] val_3 = new 丒丗专丝三与丑丏三[1];
        val_3[0] = 4294967297;
        val_1.Add(key:  159, value:  new 万丗且专万丟丌丂丐() {下丞七丒业丂丈丘下 = 5023, 不丙且丄上且万丙丞 = val_2, 专丆丌丞丙丅丌丄丕 = val_3, 丙丌七三与丟世与且 = 1, 丁丝丗丛丆丛且丈上 = 2, 下丝丒丕丅丆丐丑丁 = 3, 丆丁东七专与丞与上 = 12, 丄上七业丅丅丕业三 = 54, 万世且上上东三万专 = 32, 丈丐丆丛上丕丌上世 = "Key_7045", 下一不一丁丟丄丑丒 = "Key_7110"});
        丒丗专丝三与丑丏三[] val_4 = new 丒丗专丝三与丑丏三[3];
        val_11 = val_4.Length;
        if(val_11 == 0)
        {
                val_11 = val_4.Length;
        }
        
        val_4[0] = new 丒丗专丝三与丑丏三();
        if(val_11 <= 1)
        {
                val_11 = val_4.Length;
        }
        
        val_4[1] = 8589934594;
        val_4[2] = new 丒丗专丝三与丑丏三();
        丒丗专丝三与丑丏三[] val_5 = new 丒丗专丝三与丑丏三[1];
        val_5[0] = new 丒丗专丝三与丑丏三();
        val_1.Add(key:  160, value:  new 万丗且专万丟丌丂丐() {下丞七丒业丂丈丘下 = 5024, 不丙且丄上且万丙丞 = val_4, 专丆丌丞丙丅丌丄丕 = val_5, 丙丌七三与丟世与且 = 2, 丁丝丗丛丆丛且丈上 = 3, 下丝丒丕丅丆丐丑丁 = 4, 丆丁东七专与丞与上 = 12, 丄上七业丅丅丕业三 = 54, 万世且上上东三万专 = 32, 丈丐丆丛上丕丌上世 = "Key_7324", 下一不一丁丟丄丑丒 = "Key_7325"});
        DungeonWindowUI.dungeonsInfo = val_1;
        System.Collections.Generic.Dictionary<System.Int32, ModuleType[]> val_6 = new System.Collections.Generic.Dictionary<System.Int32, ModuleType[]>();
        ModuleType[] val_7 = new ModuleType[1];
        val_7[0] = 1;
        val_6.Add(key:  159, value:  val_7);
        DungeonWindowUI.dungeonsCheckModulesParams = val_6;
        string[] val_8 = new string[4];
        val_8[0] = "";
        val_8[1] = "Key_7117";
        val_8[2] = "Key_7118";
        val_8[3] = "Key_7119";
        DungeonWindowUI.mobModuleTypeLocalizations = val_8;
        DungeonWindowUI.东丌丗丗专三丅且丗 = new int[3];
    }

}
