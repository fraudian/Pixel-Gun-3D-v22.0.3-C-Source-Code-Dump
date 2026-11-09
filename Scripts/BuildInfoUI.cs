using UnityEngine;
internal sealed class BuildInfoUI : PGBehaviour
{
    // Fields
    private BuildLevelUI buildLevelUI;
    private UILabel energyCount;
    private UISprite energyBar;
    private UISprite energySpendBar;
    private UnityEngine.Color spendEnergyBarColorOrange;
    private UnityEngine.Color spendEnergyBarColorRed;
    private UILabel power;
    private UILabel powerIncrease;
    private UILabel clanName;
    
    // Methods
    private void Start()
    {
        string val_16;
        var val_17;
        var val_18;
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_2 != null)
        {
                val_16 = val_2.东丙上东业丆不丟丘();
        }
        else
        {
                val_16 = 0;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanName, 丕丗丘丑丛与丑业丒:  val_16);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.powerIncrease, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        this.丄丁丕丛丈丞丅丅丆();
        Base_BuildingUI_Controller.instance.业丆丝不七一七世丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丁丙丈丌丈丂丕丟丕()));
        Base_BuildingUI.instance.丐丗世三丝丞专三一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
        Base_BuildingUI.instance.丌丐与丙东万上丛东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丄丁丕丛丈丞丅丅丆()));
        Base_BuildingUI.instance.世业丐丏丗业丟一上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丄丁丕丛丈丞丅丅丆()));
        丂丘丗丗与且丌丁丙.七丈七万丂丒丐丐丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丁丙丈丌丈丂丕丟丕()));
        丂丘丗丗与且丌丁丙.七丈七万丂丒丐丐丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
        val_17 = null;
        val_17 = null;
        if(ClanTankBuildController.丄丘七三上丕世丞业 != 0)
        {
                val_18 = null;
            val_18 = null;
            ClanTankBuildController.丄丘七三上丕世丞业.业万丟丄且丒下上一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
        }
        
        if(ClanTankBuildBase.instance != 0)
        {
                ClanTankBuildBase.instance.丈东丑丑丅丘丄丌丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
        }
        
        this.buildLevelUI.丈且东丑丂且万丒丅(丏丛下与丌且丅丐一:  Base_BuildingUI_Controller.instance);
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.上丅丝与丏不七丆丏());
    }
    private System.Collections.IEnumerator 上丅丝与丏不七丆丏()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BuildInfoUI.三丟世丈万丕下丝万();
    }
    private void OnDestroy()
    {
        var val_12;
        var val_13;
        var val_14;
        丂丘丗丗与且丌丁丙.丐丟丂丁下丐丑丈丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
        丂丘丗丗与且丌丁丙.丐丟丂丁下丐丑丈丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丁丙丈丌丈丂丕丟丕()));
        val_12 = 1152921505159667712;
        if(Base_BuildingUI_Controller.instance != 0)
        {
                Base_BuildingUI_Controller.instance.世东丂一丄三下业丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丁丙丈丌丈丂丕丟丕()));
            val_12 = 1152921505159561216;
            Base_BuildingUI.instance.丝丈专且丆业一丄丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
            Base_BuildingUI.instance.丄专丏丅丗丐丏万专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丄丁丕丛丈丞丅丅丆()));
            Base_BuildingUI.instance.丑丕一丁专一三且丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::丄丁丕丛丈丞丅丅丆()));
        }
        
        val_13 = null;
        val_13 = null;
        if(ClanTankBuildController.丄丘七三上丕世丞业 != 0)
        {
                val_14 = null;
            val_14 = null;
            ClanTankBuildController.丄丘七三上丕世丞业.丄丆丝丁丒不丐丟丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
        }
        
        if(ClanTankBuildBase.instance == 0)
        {
                return;
        }
        
        ClanTankBuildBase.instance.业上丗丝丆丁丛丏丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildInfoUI::下丂丗丟丝丁丁丗万()));
    }
    private void 丁丙丈丌丈丂丕丟丕()
    {
        Base_BuildingUI_Controller val_1 = Base_BuildingUI_Controller.instance;
        val_1 = Base_BuildingUI_Controller.instance - val_1;
        this.energySpendBar.fillAmount = 0f;
        this.丂丞丑丅丂丈丙丕丕(且丝专丟一丆丐丏丈:  val_1, 丌一七世三丑专丒丆:  Base_BuildingUI_Controller.instance);
        this.东丑丄且万丄专丆七(且丝专丟一丆丐丏丈:  val_1, 丌一七世三丑专丒丆:  Base_BuildingUI_Controller.instance);
        this.丄三丈丛万七丗与专();
    }
    private void 下丂丗丟丝丁丁丗万()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丞丒丝丙丄丛丈不丄());
    }
    private System.Collections.IEnumerator 丞丒丝丙丄丛丈不丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BuildInfoUI.丏丐东丑丛业一且世();
    }
    private void 丗不丅丏丏丌三丏丅()
    {
        string val_9;
        PlaceableItemSettings val_10;
        if(null == 0)
        {
            goto label_2;
        }
        
        val_9 = "";
        if(IsDecoration != true)
        {
                val_9 = System.String.Format(format:  "+{0}", arg0:  Power.ToString());
            string val_8 = val_9;
        }
        
        if((((Base_BuildingUI_Controller.instance.东丅丙丆丒丆三丂七 == false) || (IsDecoration == true)) || (ClanTankBuildBase.instance == 0)) || (ClanTankBuildBase.instance.selectedItemPoint == 0))
        {
            goto label_17;
        }
        
        if(null == 0)
        {
            goto label_16;
        }
        
        this.丕丒七丑丈丄丟七上(丅丗丝一丞丄丘丟不:  Base_BuildingUI.instance.selectedItemSettings, 丟丕丌世丗丕万三丗: ref  val_8);
        val_9 = val_8;
        goto label_17;
        label_2:
        if(Base_BuildingUI_Controller.instance.东丅丙丆丒丆三丂七 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.powerIncrease, 丕丗丘丑丛与丑业丒:  "");
        val_10 = 0;
        goto label_22;
        label_16:
        val_9 = "";
        label_17:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.powerIncrease, 丕丗丘丑丛与丑业丒:  val_9);
        if(Base_BuildingUI_Controller.instance.且丄丏上丐丛世且丗 != false)
        {
                this.丑丈丒丝三丄丁丟丈(丅丗丝一丞丄丘丟不:  Base_BuildingUI.instance.selectedItemSettings);
        }
        
        if(Base_BuildingUI_Controller.instance.东丅丙丆丒丆三丂七 == false)
        {
                return;
        }
        
        val_10 = Base_BuildingUI.instance.selectedItemSettings;
        label_22:
        this.一下丐丛丟东七丟一(丅丗丝一丞丄丘丟不:  val_10);
    }
    private void 丄丁丕丛丈丞丅丅丆()
    {
        this.powerIncrease.text = "";
        this.energySpendBar.fillAmount = 0f;
    }
    private void 丄三丈丛万七丗与专()
    {
        object val_11;
        int val_12;
        var val_13;
        val_11 = "";
        if(Base_BuildingUI_Controller.instance.且丄丏上丐丛世且丗 != false)
        {
                val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8241");
            ClanFieldBuildController val_2 = ClanFieldBuildController.丑七不且上丗丁一世();
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<PlaceableItemSettings>(source:  val_2.专丁丑世业丌丏丁丛.Values);
            val_12 = val_4.丒丄丒丈丙丟丛丗丁(三世东下世下下东丈:  val_4);
        }
        else
        {
                val_12 = 0;
        }
        
        if(Base_BuildingUI_Controller.instance.东丅丙丆丒丆三丂七 != false)
        {
                val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8242");
            val_13 = null;
            val_13 = null;
            System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<PlaceableItemSettings>(source:  Values);
            val_12 = val_8.丒丄丒丈丙丟丛丗丁(三世东下世下下东丈:  val_8);
        }
        
        this.power.text = val_11 + ": "(": ") + val_12;
    }
    private int 丒丄丒丈丙丟丛丗丁(System.Collections.Generic.List<PlaceableItemSettings> 三世东下世下下东丈)
    {
        var val_5;
        var val_6;
        val_5 = 0;
        val_6 = 0;
        goto label_1;
        label_7:
        if(三世东下世下下东丈.Item[0] != null)
        {
                val_6 = 三世东下世下下东丈.Item[0].Power + val_6;
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < 三世东下世下下东丈.Count)
        {
            goto label_7;
        }
        
        return (int)val_6;
    }
    private void 丕丒七丑丈丄丟七上(PlaceableItemSettings 丅丗丝一丞丄丘丟不, ref string 丟丕丌世丗丕万三丗)
    {
        var val_3;
        var val_12;
        var val_13;
        System.Collections.Generic.Dictionary<ClanTankPlaceableItemPoint, PlaceableItemSettings> val_14;
        var val_15;
        object val_16;
        val_12 = 1152921536799645536;
        PlaceableItemSettings val_12 = 丅丗丝一丞丄丘丟不;
        val_13 = null;
        val_13 = null;
        val_14 = mem[ClanTankBuildController.丄丘七三上丕世丞业 + 96];
        val_14 = ClanTankBuildController.丄丘七三上丕世丞业.与且丘东丒一上业东;
        Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
        val_15 = 1152921536799564960;
        if((2127979264 & 1) == 0)
        {
            goto label_5;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
        string val_6 = val_5._value._obj.丐丏七丌丕丗业且上();
        val_14;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_5._value._obj == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  ???, b:  PGBehaviour.__il2cppRuntimeField_parent)) == false)
        {
            goto label_14;
        }
        
        val_14 = val_5._value._obj.Power;
        val_12 = val_12.Power - val_14;
        val_16 = val_12.ToString();
        if((val_12 & 2147483648) != 0)
        {
            goto label_16;
        }
        
        丟丕丌世丗丕万三丗 = System.String.Format(format:  "+{0}", arg0:  val_16);
        return;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        return;
        label_14:
        val_16 = "";
        label_16:
        丟丕丌世丗丕万三丗 = val_16;
    }
    private void 丑丈丒丝三丄丁丟丈(PlaceableItemSettings 丅丗丝一丞丄丘丟不)
    {
        UISprite val_4;
        UISprite val_5;
        UnityEngine.Color val_6;
        val_4 = this;
        Base_BuildingUI_Controller val_1 = Base_BuildingUI_Controller.instance - Base_BuildingUI_Controller.instance;
        this.energyCount.text = val_1 + "/"("/") + Base_BuildingUI_Controller.instance;
        float val_4 = (float)val_1;
        val_4 = val_4 / (float)Base_BuildingUI_Controller.instance;
        this.energyBar.fillAmount = val_4;
        val_5 = this.energySpendBar;
        val_5.fillAmount = 0f;
        if(丅丗丝一丞丄丘丟不.Placeable == false)
        {
                return;
        }
        
        val_5 = Base_BuildingUI_Controller.instance + val_1;
        if(val_5 <= Base_BuildingUI_Controller.instance)
        {
            goto label_12;
        }
        
        val_6 = this.spendEnergyBarColorRed;
        if(this.energySpendBar != null)
        {
            goto label_15;
        }
        
        goto label_14;
        label_12:
        val_6 = this.spendEnergyBarColorOrange;
        if(this.energySpendBar != null)
        {
            goto label_15;
        }
        
        label_14:
        label_15:
        this.energySpendBar.color = new UnityEngine.Color() {r = val_6, g = V9.16B, b = V10.16B, a = V11.16B};
        val_4 = this.energySpendBar;
        float val_5 = (float)val_5;
        val_5 = val_5 / (float)Base_BuildingUI_Controller.instance;
        val_4.fillAmount = val_5;
    }
    private void 丂丞丑丅丂丈丙丕丕(int 且丝专丟一丆丐丏丈, int 丌一七世三丑专丒丆)
    {
        float val_1 = (float)且丝专丟一丆丐丏丈;
        val_1 = val_1 / (float)丌一七世三丑专丒丆;
        this.energyBar.fillAmount = val_1;
    }
    private void 东丑丄且万丄专丆七(int 且丝专丟一丆丐丏丈, int 丌一七世三丑专丒丆)
    {
        this.energyCount.text = System.String.Format(format:  "{0}/{1}", arg0:  且丝专丟一丆丐丏丈, arg1:  丌一七世三丑专丒丆);
    }
    private void 一下丐丛丟东七丟一(PlaceableItemSettings 丅丗丝一丞丄丘丟不)
    {
        var val_4;
        var val_11;
        var val_12;
        UISprite val_13;
        UnityEngine.Color val_14;
        int val_18;
        if(丅丗丝一丞丄丘丟不 != null)
        {
                val_11 = null;
            val_11 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            if((2128595088 & 1) != 0)
        {
                ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            string val_6 = val_5._value._obj.丐丏七丌丕丗业且上();
            val_12;
        }
        else
        {
                val_12 = 0;
        }
        
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_12 = 0;
        }
        
        Base_BuildingUI_Controller val_9 = Base_BuildingUI_Controller.instance;
        val_9 = Base_BuildingUI_Controller.instance - val_9;
        this.东丑丄且万丄专丆七(且丝专丟一丆丐丏丈:  val_9, 丌一七世三丑专丒丆:  Base_BuildingUI_Controller.instance);
        if(val_12 == 0)
        {
            goto label_22;
        }
        
        if((System.String.op_Inequality(a:  0, b:  丅丗丝一丞丄丘丟不.name)) == false)
        {
            goto label_24;
        }
        
        val_13 = Base_BuildingUI_Controller.instance - Base_BuildingUI_Controller.instance;
        goto label_29;
        label_22:
        val_13 = Base_BuildingUI_Controller.instance;
        goto label_29;
        label_24:
        val_13 = 0;
        label_29:
        this.energySpendBar.fillAmount = 0f;
        Base_BuildingUI_Controller val_8 = val_13 + val_9;
        if((val_13 & 2147483648) != 0)
        {
            goto label_31;
        }
        
        if(val_13 == 0)
        {
            goto label_32;
        }
        
        if(val_8 <= Base_BuildingUI_Controller.instance)
        {
            goto label_33;
        }
        
        val_14 = this.spendEnergyBarColorRed;
        if(this.energySpendBar != null)
        {
            goto label_38;
        }
        
        goto label_35;
        label_31:
        val_13 = this.energySpendBar;
        float val_10 = (float)val_9;
        val_10 = val_10 / (float)Base_BuildingUI_Controller.instance;
        val_13.fillAmount = val_10;
        val_18 = val_8;
        goto label_37;
        label_33:
        val_14 = this.spendEnergyBarColorOrange;
        if(this.energySpendBar != null)
        {
            goto label_38;
        }
        
        label_35:
        label_38:
        this.energySpendBar.color = new UnityEngine.Color() {r = val_14, g = V9.16B, b = V10.16B, a = V11.16B};
        val_13 = this.energySpendBar;
        float val_11 = (float)val_8;
        val_11 = val_11 / (float)Base_BuildingUI_Controller.instance;
        val_13.fillAmount = val_11;
        label_32:
        val_18 = val_9;
        label_37:
        this.丂丞丑丅丂丈丙丕丕(且丝专丟一丆丐丏丈:  val_18, 丌一七世三丑专丒丆:  Base_BuildingUI_Controller.instance);
    }
    public BuildInfoUI()
    {
        this.spendEnergyBarColorOrange = 0;
        mem[1152921536800366076] = 0;
        mem[1152921536800366084] = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.red;
        this.spendEnergyBarColorRed = val_1;
        mem[1152921536800366092] = val_1.g;
        mem[1152921536800366096] = val_1.b;
        mem[1152921536800366100] = val_1.a;
    }

}
