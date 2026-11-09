using UnityEngine;
internal sealed class CreatePrivateGameWindow : PGBehaviour
{
    // Fields
    public static CreatePrivateGameWindow instance;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UnityEngine.GameObject amounterDamageMultiplierObj;
    private 东七丟与丞丌专丞三 丌不丈丟三丏丝丟三;
    private UnityEngine.GameObject amounterDamageHeadshotMultiplierObj;
    private 东七丟与丞丌专丞三 下丂七三七丄下丙丗;
    private UnityEngine.GameObject amounterGravityObj;
    private 东七丟与丞丌专丞三 丘丙丌且丕专丙与不;
    private UnityEngine.GameObject amounterMovementSpeedObj;
    private 东七丟与丞丌专丞三 下丏世丁东丗丂丄且;
    private UnityEngine.GameObject[] weaponCategoryButtonsObj;
    private 东七丟与丞丌专丞三[] 万丄丞七丈万丆丛七;
    private UnityEngine.GameObject toggleNoEquipmentEffectsObj;
    private 东七丟与丞丌专丞三 一丕丄丈世丛不专丏;
    private UnityEngine.GameObject toggleNoModulesObj;
    private 东七丟与丞丌专丞三 丝丁上丐世丅丕丘丒;
    private UnityEngine.GameObject toggleHideNicknamesObj;
    private 东七丟与丞丌专丞三 丗万与万专丘丘万丟;
    private UnityEngine.GameObject toggleNoPetsObj;
    private 东七丟与丞丌专丞三 上丐专丌丕上丙丂丏;
    private UnityEngine.GameObject toggleNoGadgetsObj;
    private 东七丟与丞丌专丞三 丞丟七世丆不业丄丘;
    private UnityEngine.GameObject toggleRealisticBallisticsObj;
    private 东七丟与丞丌专丞三 丂且丐丗丟且下丗丞;
    private UnityEngine.GameObject toggleHeadDamageOnlyObj;
    private 东七丟与丞丌专丞三 上丗丒专丗丁丑丌不;
    private UnityEngine.GameObject toggleNoArmorObj;
    private 东七丟与丞丌专丞三 丘万业丌丈丞丅丌丟;
    private UnityEngine.GameObject switcherCameraViewObj;
    private 东七丟与丞丌专丞三 丅与丑上丁与丁三丕;
    private UnityEngine.GameObject switcherMovementTypeObj;
    private 东七丟与丞丌专丞三 丅万丄丅丁丄一东丝;
    private bool 上丕万丝丌丕万专丒;
    private SceneInfo 且丄与丄且东丞三丕;
    
    // Methods
    public int WeaponCategoriesSelected()
    {
        var val_2;
        var val_3;
        val_2 = 0;
        val_3 = 0;
        goto label_1;
        label_10:
        var val_4 = 0;
        val_4 = val_4 + 1;
        object val_2 = this.万丄丞七丈万丆丛七[0].Get();
        val_2 = 1;
        val_3 = 1152921504628731904;
        label_1:
        if(val_2 < this.万丄丞七丈万丆丛七.Length)
        {
            goto label_10;
        }
        
        return (int)val_3;
    }
    private void 丂不下丏丆丌丐与丟()
    {
        var val_17;
        this.丌不丈丟三丏丝丟三 = this.amounterDamageMultiplierObj.GetComponent<东七丟与丞丌专丞三>();
        this.下丂七三七丄下丙丗 = this.amounterDamageHeadshotMultiplierObj.GetComponent<东七丟与丞丌专丞三>();
        this.丘丙丌且丕专丙与不 = this.amounterGravityObj.GetComponent<东七丟与丞丌专丞三>();
        this.下丏世丁东丗丂丄且 = this.amounterMovementSpeedObj.GetComponent<东七丟与丞丌专丞三>();
        val_17 = 0;
        this.万丄丞七丈万丆丛七 = new 东七丟与丞丌专丞三[0];
        goto label_6;
        label_17:
        东七丟与丞丌专丞三 val_6 = this.weaponCategoryButtonsObj[0].GetComponent<东七丟与丞丌专丞三>();
        if(this.万丄丞七丈万丆丛七 == null)
        {
            goto label_10;
        }
        
        if(val_6 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_6 == null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        val_17 = 1;
        this.万丄丞七丈万丆丛七[0] = val_6;
        label_6:
        if(val_17 < this.weaponCategoryButtonsObj.Length)
        {
            goto label_17;
        }
        
        this.一丕丄丈世丛不专丏 = this.toggleNoEquipmentEffectsObj.GetComponent<东七丟与丞丌专丞三>();
        this.丝丁上丐世丅丕丘丒 = this.toggleNoModulesObj.GetComponent<东七丟与丞丌专丞三>();
        this.丗万与万专丘丘万丟 = this.toggleHideNicknamesObj.GetComponent<东七丟与丞丌专丞三>();
        this.上丐专丌丕上丙丂丏 = this.toggleNoPetsObj.GetComponent<东七丟与丞丌专丞三>();
        this.丞丟七世丆不业丄丘 = this.toggleNoGadgetsObj.GetComponent<东七丟与丞丌专丞三>();
        this.丂且丐丗丟且下丗丞 = this.toggleRealisticBallisticsObj.GetComponent<东七丟与丞丌专丞三>();
        this.上丗丒专丗丁丑丌不 = this.toggleHeadDamageOnlyObj.GetComponent<东七丟与丞丌专丞三>();
        this.丘万业丌丈丞丅丌丟 = this.toggleNoArmorObj.GetComponent<东七丟与丞丌专丞三>();
        this.丅与丑上丁与丁三丕 = this.switcherCameraViewObj.GetComponent<东七丟与丞丌专丞三>();
        this.丅万丄丅丁丄一东丝 = this.switcherMovementTypeObj.GetComponent<东七丟与丞丌专丞三>();
        this.上丕万丝丌丕万专丒 = true;
    }
    private void Start()
    {
        var val_8;
        CreatePrivateGameWindow.instance = this;
        this.丂不下丏丆丌丐与丟();
        this.SetAllDefaults();
        val_8 = null;
        val_8 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  GameConnect.丘丅丄万丞丟丕丙丝)) == false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  GameConnect.丘丅丄万丞丟丕丙丝), b:  "[]")) == false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  GameConnect.丘丅丄万丞丟丕丙丝), b:  "")) == false)
        {
                return;
        }
        
        this.丌下万丘丝丌丘专丆(七万丄七丅丅丕丝丑:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丝与业丘丌业丄东万(丏丛与丅丛丌万专丌:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  GameConnect.丘丅丄万丞丟丕丙丝)));
    }
    private void 东丒三业丈万丒丈七(System.Collections.Generic.List<CategoryNames> 丟一丐丕丒下丐业丅)
    {
        object val_5;
        var val_6;
        var val_8;
        var val_9;
        this.丈丏丆丄丁丑丆七丂(三丟东丕丄丄下下丑:  false);
        val_5 = 0;
        goto label_1;
        label_9:
        if(val_5 >= true)
        {
                val_6 = 0;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_6 = 2;
        this.万丄丞七丈万丆丛七[0].Set(丄三丅七丆丛与与上:  null);
        val_5 = 1;
        label_1:
        if(val_5 < this.万丄丞七丈万丆丛七.Length)
        {
            goto label_9;
        }
        
        val_8 = 0;
        goto label_10;
        label_20:
        val_9 = public CategoryNames System.Collections.Generic.List<CategoryNames>::get_Item(int index);
        CategoryNames val_2 = 丟一丐丕丒下丐业丅.Item[0];
        if(val_2 >= this.万丄丞七丈万丆丛七.Length)
        {
                val_9 = 0;
        }
        
        val_5 = true;
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = 2;
        this.万丄丞七丈万丆丛七[(long)val_2].Set(丄三丅七丆丛与与上:  true);
        val_8 = 1;
        label_10:
        if(val_8 < 丟一丐丕丒下丐业丅.Count)
        {
            goto label_20;
        }
    
    }
    private void 丈丏丆丄丁丑丆七丂(bool 三丟东丕丄丄下下丑)
    {
        var val_3;
        var val_4;
        bool val_3 = 三丟东丕丄丄下下丑;
        bool val_1 = val_3 ^ 1;
        val_3 = 0;
        val_3 = val_1;
        goto label_1;
        label_9:
        if(val_3 >= val_1)
        {
                val_4 = 0;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_4 = 4;
        this.万丄丞七丈万丆丛七[0].SetReadonly(三丟东丕丄丄下下丑:  val_3);
        val_3 = 1;
        label_1:
        if(val_3 < this.万丄丞七丈万丆丛七.Length)
        {
            goto label_9;
        }
    
    }
    public void ReadMapInfoNextFrame(SceneInfo 丄不东丁丂丅万丒丟)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丙丞不丝丌丕丌不丄(丄不东丁丂丅万丒丟:  丄不东丁丂丅万丒丟));
    }
    private System.Collections.IEnumerator 丙丞不丝丌丕丌不丄(SceneInfo 丄不东丁丂丅万丒丟)
    {
        CreatePrivateGameWindow.业丁丒丂且丏世丟丒 val_1 = new CreatePrivateGameWindow.业丁丒丂且丏世丟丒();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丄不东丁丂丅万丒丟 = 丄不东丁丂丅万丒丟;
        return (System.Collections.IEnumerator)val_1;
    }
    public void ReadMapInfo(SceneInfo 丄不东丁丂丅万丒丟)
    {
        System.Collections.Generic.List<CategoryNames> val_8;
        var val_9;
        CategoryNames val_10;
        var val_12;
        东七丟与丞丌专丞三 val_13;
        东七丟与丞丌专丞三 val_14;
        var val_15;
        var val_17;
        var val_19;
        东七丟与丞丌专丞三 val_20;
        if(this.上丕万丝丌丕万专丒 == false)
        {
            goto label_1;
        }
        
        label_8:
        if(丄不东丁丂丅万丒丟.AvaliableWeapon == 2)
        {
            goto label_3;
        }
        
        if(丄不东丁丂丅万丒丟.AvaliableWeapon != 1)
        {
            goto label_4;
        }
        
        System.Collections.Generic.List<CategoryNames> val_1 = null;
        val_8 = val_1;
        val_1 = new System.Collections.Generic.List<CategoryNames>();
        val_9 = 1152921537060801728;
        val_10 = 2;
        goto label_6;
        label_1:
        this.丂不下丏丆丌丐与丟();
        if(丄不东丁丂丅万丒丟 != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_3:
        System.Collections.Generic.List<CategoryNames> val_2 = null;
        val_8 = val_2;
        val_2 = new System.Collections.Generic.List<CategoryNames>();
        val_9 = 1152921537060801728;
        val_10 = 4;
        label_6:
        val_2.Add(item:  val_10);
        this.东丒三业丈万丒丈七(丟一丐丕丒下丐业丅:  val_2);
        goto label_10;
        label_4:
        this.丈丏丆丄丁丑丆七丂(三丟东丕丄丄下下丑:  true);
        label_10:
        if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
            goto label_13;
        }
        
        val_12 = this;
        val_13 = this.丗万与万专丘丘万丟;
        goto label_14;
        label_13:
        val_12 = this;
        val_14 = this.丗万与万专丘丘万丟;
        if(GameConnect.丑丌丛丈丅丅与不业() != 16)
        {
            goto label_17;
        }
        
        label_14:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_15 = 2;
        goto label_22;
        label_17:
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_17 = 4;
        goto label_27;
        label_22:
        val_19 = public System.Void 东七丟与丞丌专丞三::Set(object 丄三丅七丆丛与与上);
        val_14.Set(丄三丅七丆丛与与上:  true);
        val_20 = val_13;
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_19 = 4;
        goto label_33;
        label_27:
        label_33:
        val_14.SetReadonly(三丟东丕丄丄下下丑:  false);
        this.且丄与丄且东丞三丕 = 丄不东丁丂丅万丒丟;
    }
    private void OnEnable()
    {
        this.业丆不丌丟丗业丘丐();
    }
    private void OnDisable()
    {
        this.丐七三与且丘丅丒丙();
    }
    public void SaveCurrentSettingsToStorager()
    {
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_1 = this.三丟丌一且丒东三万();
        val_1.丌专三丁一丒丐丗万(丐东东且与与丘三七:  val_1);
    }
    public void CloseWindow()
    {
        var val_3;
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_1 = this.三丟丌一且丒东三万();
        val_1.丌专三丁一丒丐丗万(丐东东且与与丘三七:  val_1);
        val_3 = null;
        val_3 = null;
        GameConnect.东丒丗丄一丐且丆丝 = false;
        this.gameObject.SetActive(value:  false);
    }
    private void 业丆不丌丟丗业丘丐()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void CreatePrivateGameWindow::CloseWindow()), 与且专丈不万东一万:  "CreatePrivateGameWindow");
    }
    private void 丐七三与且丘丅丒丙()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void 丌下万丘丝丌丘专丆(System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> 七万丄七丅丅丕丝丑)
    {
        int val_3;
        var val_53;
        东七丟与丞丌专丞三[] val_76;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        List.Enumerator<T> val_1 = 七万丄七丅丅丕丝丑.GetEnumerator();
        val_53 = 106015240;
        label_124:
        if(((-1904671840) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((val_4 == null) || ((val_4.不业丙丒丂丞下丆丙() - 1) > 21))
        {
            goto label_124;
        }
        
        var val_51 = val_53 + ((val_5 - 1)) << 2;
        val_51 = val_51 + val_53;
        goto (val_53 + ((val_5 - 1)) << 2 + val_53);
        label_85:
        东七丟与丞丌专丞三 val_68 = [0];
        if(val_68 != null)
        {
                if(null == null)
        {
            goto label_76;
        }
        
        }
        
        val_78 = "float";
        val_79 = val_53;
        val_80 = 0;
        goto label_77;
        label_76:
        val_78 = "float";
        val_79 = val_53;
        val_80 = val_68;
        label_77:
        val_80.SetCheckState(三丟东丕丄丄下下丑:  false);
        val_81 = 0;
        goto label_78;
        label_83:
        if(Item[0] == 1152921526176492176)
        {
                val_80.SetCheckState(三丟东丕丄丄下下丑:  true);
        }
        
        val_81 = 1;
        label_78:
        if(val_81 < Count)
        {
            goto label_83;
        }
        
        val_76 = ;
        val_82 = 1;
        if(val_76 == 0)
        {
                val_83 = val_82;
        }
        
        if(val_83 < (this.万丄丞七丈万丆丛七 + 24))
        {
            goto label_85;
        }
        
        goto label_124;
        label_90:
        if(((mem[1152921537061925928] + 176 + 8) + -8) == null)
        {
            goto label_89;
        }
        
         =  + 1;
         =  + 16;
        if( < (mem[1152921537061925928] + 286))
        {
            goto label_90;
        }
        
        val_84 = 2;
        goto label_91;
        label_97:
        if(((mem[1152921537061925768] + 176 + 8) + -8) == null)
        {
            goto label_96;
        }
        
         =  + 1;
         =  + 16;
        if( < (mem[1152921537061925768] + 286))
        {
            goto label_97;
        }
        
        val_86 = 2;
        goto label_98;
        label_89:
        var val_75 = ;
        val_75 = val_75 + 2;
         =  + val_75;
        val_85 =  + 296;
        label_91:
        mem[1152921537061925928].Set(丄三丅七丆丛与与上:  null);
        goto label_124;
        label_96:
        var val_77 = ;
        val_77 = val_77 + 2;
         =  + val_77;
        val_87 =  + 296;
        label_98:
        mem[1152921537061925768].Set(丄三丅七丆丛与与上:  null);
        goto label_124;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void SetAllDefaults()
    {
        var val_16;
        var val_19;
        var val_20;
        var val_21;
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_16 = System.Linq.Enumerable.OfType<东七丟与丞丌专丞三>(source:  UnityEngine.Object.FindObjectsOfType<PGBehaviour>()).GetEnumerator();
        label_24:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_16.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        T val_8 = val_16.Current;
        var val_22 = val_8;
        if((val_8 + 286) == 0)
        {
            goto label_23;
        }
        
        var val_20 = val_8 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_22:
        if(((val_8 + 176 + 8) + -8) == null)
        {
            goto label_21;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (val_8 + 286))
        {
            goto label_22;
        }
        
        goto label_23;
        label_21:
        val_22 = val_22 + (((val_8 + 176 + 8)) << 4);
        val_19 = val_22 + 296;
        label_23:
        val_8.SetDefault();
        goto label_24;
        label_13:
        val_20 = 0;
        val_21 = 0;
        if(val_16 == null)
        {
            
        }
        else
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_16.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_16 = ???;
        val_20 = ???;
    }
    public void SetAllDefaultsButton()
    {
        this.SetAllDefaults();
        if(this.且丄与丄且东丞三丕 != 0)
        {
                this.ReadMapInfo(丄不东丁丂丅万丒丟:  this.且丄与丄且东丞三丕);
        }
        
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_2 = this.三丟丌一且丒东三万();
        val_2.丌专三丁一丒丐丗万(丐东东且与与丘三七:  val_2);
    }
    private bool 丅上丑丑丛丆丂业丛()
    {
        var val_2;
        var val_4;
        val_2 = 0;
        label_10:
        if(val_2 >= this.万丄丞七丈万丆丛七.Length)
        {
            goto label_2;
        }
        
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_2 = val_2 + 1;
        if(this.万丄丞七丈万丆丛七[0].IsDefault() == true)
        {
            goto label_10;
        }
        
        val_4 = 1;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
    }
    private System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> 三丟丌一且丒东三万()
    {
        System.Collections.Generic.Dictionary<TKey, TValue> val_67;
        var val_68;
        System.Collections.Generic.List<T> val_69;
        var val_82;
        var val_83;
        var val_97;
        var val_98;
        东七丟与丞丌专丞三 val_99;
        val_68 = this;
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_1 = null;
        val_69 = val_1;
        val_1 = new System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛>();
        if((this.丌不丈丟三丏丝丟三 & 1) == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_3.Add(key:  "type", value:  10);
            double val_96 = 0.01;
            val_96 = (1.15292150460685E+18) * val_96;
            val_3.Add(key:  "float", value:  (float)val_96);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_3, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_97 = 0;
        val_97 = val_97 + 1;
        if(this.下丂七三七丄下丙丗.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_8.Add(key:  "type", value:  11);
            var val_98 = 0;
            val_98 = val_98 + 1;
            object val_10 = this.下丂七三七丄下丙丗.Get();
            double val_99 = 0.01;
            val_99 = (1.15292150460685E+18) * val_99;
            val_8.Add(key:  "float", value:  (float)val_99);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_8, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_100 = 0;
        val_100 = val_100 + 1;
        if(this.丘丙丌且丕专丙与不.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_14 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_14.Add(key:  "type", value:  1);
            var val_101 = 0;
            val_101 = val_101 + 1;
            object val_16 = this.丘丙丌且丕专丙与不.Get();
            double val_102 = 0.01;
            val_102 = (1.15292150460685E+18) * val_102;
            val_14.Add(key:  "float", value:  GravitySetter.专丙下不不专丏丌丅(丛丛不专三丐业专丛:  (float)val_102));
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_14, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_103 = 0;
        val_103 = val_103 + 1;
        if(this.下丏世丁东丗丂丄且.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_21 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_21.Add(key:  "type", value:  2);
            var val_104 = 0;
            val_104 = val_104 + 1;
            object val_23 = this.下丏世丁东丗丂丄且.Get();
            double val_105 = 0.01;
            val_105 = (1.15292150460685E+18) * val_105;
            val_21.Add(key:  "float", value:  (float)val_105);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_21, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_106 = 0;
        val_106 = val_106 + 1;
        if(this.一丕丄丈世丛不专丏.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_27 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_27.Add(key:  "type", value:  5);
            var val_107 = 0;
            val_107 = val_107 + 1;
            object val_29 = this.一丕丄丈世丛不专丏.Get();
            val_27.Add(key:  "bool", value:  1152921504628731905);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_27, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_108 = 0;
        val_108 = val_108 + 1;
        if(this.丝丁上丐世丅丕丘丒.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_33 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_33.Add(key:  "type", value:  18);
            var val_109 = 0;
            val_109 = val_109 + 1;
            object val_35 = this.丝丁上丐世丅丕丘丒.Get();
            val_33.Add(key:  "bool", value:  1152921504628731905);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_33, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_110 = 0;
        val_110 = val_110 + 1;
        if(this.丗万与万专丘丘万丟.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_39 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_39.Add(key:  "type", value:  15);
            var val_111 = 0;
            val_111 = val_111 + 1;
            object val_41 = this.丗万与万专丘丘万丟.Get();
            val_39.Add(key:  "bool", value:  null);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_39, 丟丟丄专上丟丁丐丝:  0));
        }
        
        if(this.丅上丑丑丛丆丂业丛() == false)
        {
            goto label_115;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_44 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_44.Add(key:  "type", value:  7);
        System.Collections.Generic.List<System.Object> val_45 = new System.Collections.Generic.List<System.Object>();
        val_82 = 0;
        val_83 = 0;
        goto label_117;
        label_132:
        var val_113 = 0;
        val_113 = val_113 + 1;
        object val_47 = this.万丄丞七丈万丆丛七[0].Get();
        if(null != null)
        {
                SettingsWeaponCategoryButton val_48 = this.weaponCategoryButtonsObj[0].GetComponent<SettingsWeaponCategoryButton>();
            val_45.Add(item:  val_48.weaponCategory);
            val_83 = 1;
        }
        
        val_68 = val_68;
        val_82 = 1;
        label_117:
        if(val_82 < this.万丄丞七丈万丆丛七.Length)
        {
            goto label_132;
        }
        
        val_67 = val_44;
        val_69 = val_69;
        if(val_83 == 0)
        {
                val_45.Add(item:  9990000);
            val_68 = val_68;
        }
        
        val_44.Add(key:  "custom", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_45));
        val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_44, 丟丟丄专上丟丁丐丝:  0));
        label_115:
        var val_115 = 0;
        val_115 = val_115 + 1;
        if(this.上丐专丌丕上丙丂丏.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_53 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            var val_116 = 0;
            val_116 = val_116 + 1;
            object val_55 = this.上丐专丌丕上丙丂丏.Get();
            val_67 = 1152921504617656320;
            val_53.Add(key:  "type", value:  3);
            val_53.Add(key:  "bool", value:  1152921504628731904 ^ 1);
            val_68 = val_68;
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_53, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_117 = 0;
        val_117 = val_117 + 1;
        if(this.丞丟七世丆不业丄丘.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_60 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            var val_118 = 0;
            val_118 = val_118 + 1;
            object val_62 = this.丞丟七世丆不业丄丘.Get();
            val_67 = 1152921504617656320;
            val_60.Add(key:  "type", value:  4);
            val_60.Add(key:  "bool", value:  1152921504628731904 ^ 1);
            val_68 = val_68;
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_60, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_119 = 0;
        val_119 = val_119 + 1;
        if(this.丂且丐丗丟且下丗丞.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_67 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_67.Add(key:  "type", value:  16);
            var val_120 = 0;
            val_120 = val_120 + 1;
            object val_69 = this.丂且丐丗丟且下丗丞.Get();
            val_67.Add(key:  "bool", value:  null);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_67, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_121 = 0;
        val_121 = val_121 + 1;
        if(this.上丗丒专丗丁丑丌不.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_73 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_73.Add(key:  "type", value:  9);
            var val_122 = 0;
            val_122 = val_122 + 1;
            object val_75 = this.上丗丒专丗丁丑丌不.Get();
            val_73.Add(key:  "bool", value:  null);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_73, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_123 = 0;
        val_123 = val_123 + 1;
        if(this.丘万业丌丈丞丅丌丟.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_79 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_67 = 1152921516595677584;
            val_79.Add(key:  "type", value:  22);
            var val_124 = 0;
            val_124 = val_124 + 1;
            object val_81 = this.丘万业丌丈丞丅丌丟.Get();
            val_79.Add(key:  "bool", value:  null);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_79, 丟丟丄专上丟丁丐丝:  0));
        }
        
        var val_125 = 0;
        val_125 = val_125 + 1;
        if(this.丅与丑上丁与丁三丕.IsDefault() != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_85 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            var val_126 = 0;
            val_126 = val_126 + 1;
            object val_87 = this.丅与丑上丁与丁三丕.Get();
            if(null == 1)
        {
                val_97 = null;
            val_98 = 17;
        }
        else
        {
                val_97 = null;
            val_98 = 19;
        }
        
            val_85.Add(key:  "type", value:  19);
            val_85.Add(key:  "bool", value:  true);
            val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_85, 丟丟丄专上丟丁丐丝:  0));
        }
        
        val_99 = this.丅万丄丅丁丄一东丝;
        var val_127 = 0;
        val_127 = val_127 + 1;
        if(val_99.IsDefault() == true)
        {
                return (System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛>)val_69;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_91 = null;
        val_99 = val_91;
        val_91 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_67 = 1152921516595677584;
        val_91.Add(key:  "type", value:  14);
        var val_128 = 0;
        val_128 = val_128 + 1;
        object val_93 = this.丅万丄丅丁丄一东丝.Get();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_91.Add(key:  "custom", value:  null.ToString());
        val_1.Add(item:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.东丝七业丄丑丒世七(丗丟下丄丐丂丑世上:  val_91, 丟丟丄专上丟丁丐丝:  0));
        return (System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛>)val_69;
    }
    private void 丌专三丁一丒丐丗万(System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> 丐东东且与与丘三七)
    {
        var val_2 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  GameConnect.丘丅丄万丞丟丕丙丝, 下下丏一丙不丘丌丞:  PGCompany.GameModeEvents.下丑一丈与丝与丐丛.上丝丂丈丟丒业丈丂(丐三丞七丝丅不万丛:  丐东东且与与丘三七));
    }
    public CreatePrivateGameWindow()
    {
    
    }

}
