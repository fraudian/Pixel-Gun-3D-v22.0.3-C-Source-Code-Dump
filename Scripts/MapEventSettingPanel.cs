using UnityEngine;
public class MapEventSettingPanel : MonoBehaviour
{
    // Fields
    public UIBasicSprite[] weaponSlots;
    public UnityEngine.GameObject[] weaponSlotsObjects;
    public UnityEngine.GameObject[] weaponSlotsReds;
    public UnityEngine.GameObject[] weaponSlotsGreys;
    public UIBasicSprite gadget;
    public UnityEngine.GameObject[] emptySlots;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅;
    private System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丈不丄上丐一业丞下;
    public bool clearedUnequippedWeapons;
    public System.Action OnUnequippedWeaponsCleared;
    
    // Properties
    private UIBasicSprite 三丄且万丐三丅丙业 { get; }
    
    // Methods
    private UIBasicSprite 一丂七世丟不且下丙(int 丞世不丒下上上丝丑)
    {
        mem2[0] = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.weaponSlots[(long)丞世不丒下上上丝丑]);
        return (UIBasicSprite)this.weaponSlots[(long)丞世不丒下上上丝丑];
    }
    public void TweenReds()
    {
        goto label_1;
        label_17:
        if(this.weaponSlotsReds[0].activeSelf != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.weaponSlotsReds[0].GetComponentInParent<SimpleTweenePlayer>())) != false)
        {
                this.weaponSlotsReds[0].GetComponentInParent<SimpleTweenePlayer>().Play();
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this.weaponSlotsReds.Length)
        {
            goto label_17;
        }
    
    }
    private UIBasicSprite 丕东万丒丏丕下丒且()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.gadget);
        this.gadget = val_1;
        return val_1;
    }
    internal void 上东与丛丞下丈专丈(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        this.丐且丘丑与万丞丑丅 = 丐且丘丑与万丞丑丅;
        this.UpdateInventoryPanel();
    }
    public void UpdateInventoryPanel()
    {
        var val_37;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_54;
        var val_55;
        var val_56;
        System.Func<System.String, 三丅丁丗丗丝丂万且> val_58;
        var val_59;
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_60;
        var val_61;
        var val_62;
        UIBasicSprite val_63;
        var val_64;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        if(this == 0)
        {
                return;
        }
        
        val_54 = this;
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        FilterMaps val_2 = this.丆与且一丂丈丛丄丛();
        val_55 = null;
        val_55 = null;
        丅一丈与丄三丝丝丞 val_3 = WeaponManager.且专专丁丌丗丛且丙.Item[val_2];
        char[] val_5 = new char[1];
        val_5[0] = '#';
        val_56 = null;
        val_56 = null;
        val_58 = MapEventSettingPanel.<>c.<>9__14_0;
        if(val_58 == null)
        {
                val_58 = null;
            val_58 = new System.Func<System.String, 三丅丁丗丗丝丂万且>(object:  MapEventSettingPanel.<>c.__il2cppRuntimeField_static_fields, method:  三丅丁丗丗丝丂万且 MapEventSettingPanel.<>c::七丒丑丕与丄丑丄丕(string 三丟东丕丄丄下下丑));
            MapEventSettingPanel.<>c.<>9__14_0 = val_58;
        }
        
        val_60 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Select<System.String, 三丅丁丗丗丝丂万且>(source:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_3.丟丌东且上业丝丂丞).Split(separator:  val_5), selector:  null));
        this.丈不丄上丐一业丞下 = val_60;
        val_61 = 0;
        goto label_17;
        label_35:
        UIBasicSprite val_10 = this.一丂七世丟不且下丙(丞世不丒下上上丝丑:  0);
        if(this.丈不丄上丐一业丞下.Item[0] == null)
        {
            goto label_19;
        }
        
        val_62 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.丈不丄上丐一业丞下.Item[0].与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  this.丈不丄上丐一业丞下.Item[0].丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(val_10 != null)
        {
            goto label_28;
        }
        
        goto label_27;
        label_19:
        val_62 = 0;
        if(val_10 != null)
        {
            goto label_28;
        }
        
        label_27:
        label_28:
        val_59 = this.丈不丄上丐一业丞下.Item[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.emptySlots[0], 丏业丟一东丂东丘丛:  (val_59 == 0) ? 1 : 0);
        val_60 = this.丈不丄上丐一业丞下;
        val_61 = 1;
        label_17:
        if(val_61 < val_60.Count)
        {
            goto label_35;
        }
        
        string val_20 = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  212, 专丆丌丛东一不丑丙:  val_2);
        val_63 = this.gadget;
        if(val_63 == 0)
        {
            goto label_49;
        }
        
        val_63 = this.gadget;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_20)) == false)
        {
            goto label_43;
        }
        
        val_64 = 0;
        if(val_63 != null)
        {
            goto label_49;
        }
        
        goto label_49;
        label_43:
        val_64 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_20, 七丆丒与丗丌丄且丂:  212, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        label_49:
        if(mem[this.丐且丘丑与万丞丑丅] == 0)
        {
                return;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_25 = mem[this.丐且丘丑与万丞丑丅].丌不丅不丞东万专专();
        if(val_25.HasValue.丙东专丂世丈丏丁丂() != 4)
        {
                return;
        }
        
        if((519427112 & 1) == 0)
        {
                return;
        }
        
        val_63 = 0;
        goto label_88;
        label_103:
        val_59 = 0;
        UIBasicSprite val_54 = this.weaponSlots[val_59];
        this.weaponSlotsGreys[val_59].SetActive(value:  false);
        this.weaponSlotsObjects[val_59].GetComponent<UnityEngine.Collider>().enabled = true;
        this.weaponSlotsReds[val_59].SetActive(value:  false);
        val_63 = 1;
        label_88:
        if(val_63 < this.weaponSlots.Length)
        {
            goto label_103;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_28 = mem[this.丐且丘丑与万丞丑丅].三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  7);
        if(val_28 == null)
        {
            goto label_271;
        }
        
        val_66 = 0;
        goto label_106;
        label_110:
        UIBasicSprite val_58 = this.weaponSlots[0];
        val_66 = 1;
        label_106:
        if(val_66 < this.weaponSlots.Length)
        {
            goto label_110;
        }
        
        val_67 = 0;
        goto label_111;
        label_116:
        this.weaponSlotsGreys[0].gameObject.SetActive(value:  true);
        val_67 = 1;
        label_111:
        if(val_67 < this.weaponSlotsGreys.Length)
        {
            goto label_116;
        }
        
        val_68 = 0;
        goto label_117;
        label_122:
        this.weaponSlotsObjects[0].GetComponent<UnityEngine.Collider>().enabled = false;
        val_68 = 1;
        label_117:
        if(val_68 < this.weaponSlotsObjects.Length)
        {
            goto label_122;
        }
        
        val_69 = 0;
        goto label_123;
        label_133:
        this.weaponSlotsGreys[0].gameObject.SetActive(value:  true);
        this.weaponSlotsObjects[0].GetComponent<UnityEngine.Collider>().enabled = false;
        val_69 = 1;
        label_123:
        if(val_69 < this.weaponSlots.Length)
        {
            goto label_133;
        }
        
        val_70 = 0;
        goto label_134;
        label_139:
        this.weaponSlotsReds[0].gameObject.SetActive(value:  false);
        val_70 = 1;
        label_134:
        if(val_70 < this.weaponSlotsReds.Length)
        {
            goto label_139;
        }
        
        List.Enumerator<T> val_35 = val_28.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<CategoryNames>>(丒丑丂丐丕丒丕东与:  "custom").GetEnumerator();
        val_63 = 1152921530895186272;
        val_59 = 1152921530895187296;
        label_208:
        if((519427072 & 1) == 0)
        {
            goto label_141;
        }
        
        val_71 = public CategoryNames List.Enumerator<CategoryNames>::get_Current();
        if(val_37.丙东专丂世丈丏丁丂() > 5)
        {
            goto label_208;
        }
        
        var val_64 = 106029696 + (val_38) << 2;
        val_64 = val_64 + 106029696;
        goto (106029696 + (val_38) << 2 + 106029696);
        label_141:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        label_271:
        if(this.丆与且一丂丈丛丄丛() != 107)
        {
                return;
        }
        
        val_59 = 0;
        goto label_273;
        label_290:
        val_54 = 0;
        val_63 = this.weaponSlotsGreys[val_54];
        if(val_63.activeSelf != true)
        {
                val_63 = Competition.与丝丆丝丘丕七丞丒.丑七不且上丗丁一世().丑丟下不丒世丑丆七(七丆丒与丗丌丄且丂:  new CategoryNames[6][0]);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_63)) != true)
        {
                val_63 = Competition.与丝丆丝丘丕七丞丒.丑七不且上丗丁一世();
            string val_52 = val_63.丑丟下不丒世丑丆七(七丆丒与丗丌丄且丂:  val_46[0x0] + 32);
            if(this.clearedUnequippedWeapons != true)
        {
                val_63 = this.weaponSlotsReds[val_54];
            val_63.SetActive(value:  true);
        }
        
        }
        
        }
        
        val_59 = 1;
        label_273:
        if(val_59 < val_46.Length)
        {
            goto label_290;
        }
    
    }
    private void Awake()
    {
        ShopNGUIController.add_Close(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void MapEventSettingPanel::UpdateInventoryPanel()));
        WeaponManager.丙与专丝下丏与上下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void MapEventSettingPanel::UpdateInventoryPanel()));
    }
    private void OnDestroy()
    {
        WeaponManager.丛丏下丞丗业万丕丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void MapEventSettingPanel::UpdateInventoryPanel()));
        ShopNGUIController.remove_Close(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void MapEventSettingPanel::UpdateInventoryPanel()));
    }
    public void HandleShopButtonClick()
    {
        PGCompany.GameModeHub.GMHMainView val_3;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_3 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业;
        if(val_3 != 0)
        {
                val_3 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业;
            val_3.一丏丞丘专丘业丈丑(丝丗丙丞丙丕万业下:  this.丆与且一丂丈丛丄丛(), 与丝丕与丙不与丗丆:  0, 一专七丟丏且丑丄下:  0, 丄丕三丞一丌与与丅:  false);
        }
        
        this.ClearAllUnequippedWeapons();
    }
    public void HandlePrimaryClicked()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丈不丄上丐一业丞下 != null)
        {
                三丅丁丗丗丝丂万且 val_1 = this.丈不丄上丐一业丞下.Item[0];
            if(val_1 != null)
        {
                string val_2 = val_1.与不丞丑七丘丁丂丛();
        }
        
            this.丂丈丗丝丁丏丌丄七(丞一丁业丄一一业且:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  0, 丙丑丄与丅丐一不东:  true).Item[0].业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  0);
        }
        
        this.ClearAllUnequippedWeapons();
    }
    public void ClearAllUnequippedWeapons()
    {
        var val_8;
        var val_9;
        CategoryNames val_10;
        var val_11;
        val_8 = static_value_081DACA8;
        val_8 = static_value_081DACA8;
        if(((static_value_081DACA8 + 184 + 16) != 0) && (this.丐且丘丑与万丞丑丅 != null))
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
            if((val_2.HasValue.丙东专丂世丈丏丁丂() == 4) && ((521730136 & 1) != 0))
        {
                val_9 = static_value_081DACA8;
            val_9 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.AddWatchedCompetitionFiltermap(与丕丁三万专世不丅:  this.丐且丘丑与万丞丑丅.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13).丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom"));
        }
        
        }
        
        val_10 = 0;
        this.clearedUnequippedWeapons = true;
        goto label_14;
        label_18:
        this.weaponSlotsReds[0].SetActive(value:  false);
        val_10 = 1;
        label_14:
        if(val_10 < this.weaponSlotsReds.Length)
        {
            goto label_18;
        }
        
        val_11 = 0;
        goto label_19;
        label_23:
        val_10 = new CategoryNames[6][0];
        Competition.与丝丆丝丘丕七丞丒.丑七不且上丗丁一世().丁丂丟且丆七一业丑(七丆丒与丗丌丄且丂:  val_10);
        val_11 = 1;
        label_19:
        if(val_11 < val_6.Length)
        {
            goto label_23;
        }
        
        if(this.OnUnequippedWeaponsCleared == null)
        {
                return;
        }
        
        this.OnUnequippedWeaponsCleared.Invoke();
    }
    public void HandleBackupClicked()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丈不丄上丐一业丞下 != null)
        {
                三丅丁丗丗丝丂万且 val_1 = this.丈不丄上丐一业丞下.Item[1];
            if(val_1 != null)
        {
                string val_2 = val_1.与不丞丑七丘丁丂丛();
        }
        
            this.丂丈丗丝丁丏丌丄七(丞一丁业丄一一业且:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  1, 丙丑丄与丅丐一不东:  true).Item[0].业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  1);
        }
        
        this.ClearAllUnequippedWeapons();
    }
    public void HandleMeleeClicked()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丈不丄上丐一业丞下 != null)
        {
                三丅丁丗丗丝丂万且 val_1 = this.丈不丄上丐一业丞下.Item[2];
            if(val_1 != null)
        {
                string val_2 = val_1.与不丞丑七丘丁丂丛();
        }
        
            this.丂丈丗丝丁丏丌丄七(丞一丁业丄一一业且:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  2, 丙丑丄与丅丐一不东:  true).Item[0].业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  2);
        }
        
        this.ClearAllUnequippedWeapons();
    }
    public void HandleSpecialClicked()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丈不丄上丐一业丞下 != null)
        {
                三丅丁丗丗丝丂万且 val_1 = this.丈不丄上丐一业丞下.Item[3];
            if(val_1 != null)
        {
                string val_2 = val_1.与不丞丑七丘丁丂丛();
        }
        
            this.丂丈丗丝丁丏丌丄七(丞一丁业丄一一业且:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  3, 丙丑丄与丅丐一不东:  true).Item[0].业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  3);
        }
        
        this.ClearAllUnequippedWeapons();
    }
    public void HandleSniperClicked()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丈不丄上丐一业丞下 != null)
        {
                三丅丁丗丗丝丂万且 val_1 = this.丈不丄上丐一业丞下.Item[4];
            if(val_1 != null)
        {
                string val_2 = val_1.与不丞丑七丘丁丂丛();
        }
        
            this.丂丈丗丝丁丏丌丄七(丞一丁业丄一一业且:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  4, 丙丑丄与丅丐一不东:  true).Item[0].业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  4);
        }
        
        this.ClearAllUnequippedWeapons();
    }
    public void HandlePremiumClicked()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.丈不丄上丐一业丞下 != null)
        {
                三丅丁丗丗丝丂万且 val_1 = this.丈不丄上丐一业丞下.Item[5];
            if(val_1 != null)
        {
                string val_2 = val_1.与不丞丑七丘丁丂丛();
        }
        
            this.丂丈丗丝丁丏丌丄七(丞一丁业丄一一业且:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  5, 丙丑丄与丅丐一不东:  true).Item[0].业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  5);
        }
        
        this.ClearAllUnequippedWeapons();
    }
    public void HandleGrenadeClicked()
    {
        string val_7;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_7 = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  212, 专丆丌丛东一不丑丙:  this.丆与且一丂丈丛丄丛());
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) != false)
        {
                val_7 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  212, 丙丑丄与丅丐一不东:  true)).业上丙丞丐丄丆丅七();
        }
        
        this.丂丈丗丝丁丏丌丄七(丞一丁业丄一一业且:  val_7, 七丆丒与丗丌丄且丂:  212);
    }
    private FilterMaps 丆与且一丂丈丛丄丛()
    {
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = this.丐且丘丑与万丞丑丅.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13);
        if(val_1 != null)
        {
                return val_1.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        }
        
        return val_1.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
    }
    internal void 丂丈丗丝丁丏丌丄七(string 丞一丁业丄一一业且, CategoryNames 七丆丒与丗丌丄且丂)
    {
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        this = this.丆与且一丂丈丛丄丛();
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.一丏丞丘专丘业丈丑(丝丗丙丞丙丕万业下:  this, 与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂), 一专七丟丏且丑丄下:  七丆丒与丗丌丄且丂, 丄丕三丞一丌与与丅:  false);
    }
    public MapEventSettingPanel()
    {
    
    }

}
