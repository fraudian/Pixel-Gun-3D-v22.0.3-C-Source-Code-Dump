using UnityEngine;
public class MapEventPauseUI : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject modsSingleGO;
    public UnityEngine.GameObject modsDoubleGO;
    public UnityEngine.GameObject modesTripleGO;
    public MapEventModifItem[] mods;
    public MapEventModifItem settingMod;
    public UIGrid grid;
    public bool updateOnEnable;
    private bool 上不丟东丞丑丟七世;
    private System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> 不东丁一且七业丗丟;
    
    // Methods
    private void Awake()
    {
    
    }
    private void 丂丟丗丞丆丘与丕业(int 丞世不丒下上上丝丑, PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一)
    {
        if(this.mods.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        this.mods[(long)丞世不丒下上上丝丑].gameObject.SetActive(value:  true);
        this.mods[(long)丞世不丒下上上丝丑].上东与丛丞下丈专丈(一丙上不丌丆三丗一:  一丙上不丌丆三丗一);
    }
    private void 丈三七专上丙丙业丗(int 丞世不丒下上上丝丑, PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一, System.Collections.Generic.KeyValuePair<CategoryNames, float> 丙丑丕丂下丏一丁专)
    {
        if(this.mods.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        this.mods[(long)丞世不丒下上上丝丑].gameObject.SetActive(value:  true);
        this.mods[(long)丞世不丒下上上丝丑].七专丆世丆丑一丈丆(一丙上不丌丆三丗一:  一丙上不丌丆三丗一, 丙丑丕丂下丏一丁专:  new System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>() {Value = 丙丑丕丂下丏一丁专.Value});
    }
    private void OnEnable()
    {
        var val_1;
        if(this.updateOnEnable == false)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        this.丄丈丕丒世丒世丆下(丐且丘丑与万丞丑丅:  GameConnect.丈丝丂丐丟万丙丑丕);
    }
    internal void 丄丈丕丒世丒世丆下(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        var val_35;
        float val_36;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_45;
        MapEventModifItem val_46;
        var val_47;
        var val_48;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_49;
        var val_50;
        var val_51;
        if(丐且丘丑与万丞丑丅 == null)
        {
            goto label_2;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(513693608 != 1)
        {
            goto label_2;
        }
        
        val_45 = 丐且丘丑与万丞丑丅.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13);
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_3 = 丐且丘丑与万丞丑丅.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  19);
        if(val_45 == null)
        {
            goto label_3;
        }
        
        if(this.modsSingleGO != 0)
        {
                this.modsSingleGO.SetActive(value:  false);
        }
        
        if(this.modsDoubleGO != 0)
        {
                this.modsDoubleGO.SetActive(value:  false);
        }
        
        if(this.modesTripleGO != 0)
        {
                this.modesTripleGO.SetActive(value:  true);
        }
        
        this.grid.gameObject.SetActive(value:  false);
        this.settingMod.gameObject.SetActive(value:  true);
        val_46 = this.settingMod;
        val_46.上东与丛丞下丈专丈(一丙上不丌丆三丗一:  val_45);
        return;
        label_2:
        val_45 = 1152921504848912384;
        if(this.modsSingleGO != 0)
        {
                this.modsSingleGO.SetActive(value:  false);
        }
        
        if(this.modsDoubleGO != 0)
        {
                this.modsDoubleGO.SetActive(value:  false);
        }
        
        if(this.modesTripleGO != 0)
        {
                this.modesTripleGO.SetActive(value:  false);
        }
        
        this.grid.gameObject.SetActive(value:  false);
        val_46 = this.settingMod.gameObject;
        val_46.SetActive(value:  false);
        return;
        label_3:
        if(val_3 != null)
        {
                if(this.modsSingleGO != 0)
        {
                this.modsSingleGO.SetActive(value:  false);
        }
        
            if(this.modsDoubleGO != 0)
        {
                this.modsDoubleGO.SetActive(value:  false);
        }
        
            if(this.modesTripleGO != 0)
        {
                this.modesTripleGO.SetActive(value:  true);
        }
        
            this.grid.gameObject.SetActive(value:  false);
            this.settingMod.gameObject.SetActive(value:  true);
            this.settingMod.上东与丛丞下丈专丈(一丙上不丌丆三丗一:  val_3);
            return;
        }
        
        this.grid.gameObject.SetActive(value:  true);
        this.settingMod.gameObject.SetActive(value:  false);
        val_47 = 0;
        goto label_61;
        label_67:
        this.mods[0].gameObject.SetActive(value:  false);
        val_47 = 1;
        label_61:
        if(val_47 < this.mods.Length)
        {
            goto label_67;
        }
        
        this.不东丁一且七业丗丟.Clear();
        this.不东丁一且七业丗丟.AddRange(collection:  丐且丘丑与万丞丑丅.丑丛业丛东业且丒下());
        val_48 = 0;
        goto label_70;
        label_75:
        if(this.不东丁一且七业丗丟.Item[0].不业丙丒丂丞下丆丙() == 7)
        {
            goto label_73;
        }
        
        val_48 = 1;
        label_70:
        if(val_48 < this.不东丁一且七业丗丟.Count)
        {
            goto label_75;
        }
        
        label_73:
        if((0 != 1) && (this.不东丁一且七业丗丟.Count >= 3))
        {
                if(this.不东丁一且七业丗丟 != null)
        {
                val_49 = this.不东丁一且七业丗丟.Item[0];
        }
        else
        {
                val_49 = 0.Item[0];
        }
        
            this.不东丁一且七业丗丟.set_Item(index:  1, value:  val_49);
            this.不东丁一且七业丗丟.set_Item(index:  0, value:  this.不东丁一且七业丗丟.Item[1]);
        }
        
        val_50 = 0;
        val_51 = 0;
        goto label_83;
        label_99:
        if(this.不东丁一且七业丗丟.Count <= val_50)
        {
            goto label_96;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_31 = this.不东丁一且七业丗丟.Item[0];
        if(val_31 == null)
        {
            goto label_96;
        }
        
        if(val_31.不业丙丒丂丞下丆丙() != 8)
        {
            goto label_88;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_34 = val_31.丛丅下丆丗丏三丁丕<System.Collections.Generic.Dictionary<CategoryNames, System.Single>>(丒丑丂丐丕丒丕东与:  "custom").GetEnumerator();
        goto label_90;
        label_91:
        string val_37 = val_35.丐丏七丌丕丗业且上();
        this.丈三七专上丙丙业丗(丞世不丒下上上丝丑:  0, 一丙上不丌丆三丗一:  val_31, 丙丑丕丂下丏一丁专:  new System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>() {Value = val_36});
        val_51 = 1;
        label_90:
        if((513693568 & 1) != 0)
        {
            goto label_91;
        }
        
        var val_47 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_47 == 1)
        {
            goto label_95;
        }
        
        var val_46 = 0;
        val_46 = val_46 ^ 0;
        val_47 = val_47 + val_46;
        goto label_96;
        label_95:
        label_88:
        this.丂丟丗丞丆丘与丕业(丞世不丒下上上丝丑:  1, 一丙上不丌丆三丗一:  val_31);
        val_51 = val_51 + 1;
        label_96:
        val_50 = 1;
        label_83:
        if(val_50 < this.不东丁一且七业丗丟.Count)
        {
            goto label_99;
        }
        
        if(this.modsSingleGO != 0)
        {
                this.modsSingleGO.SetActive(value:  (val_51 == 1) ? 1 : 0);
        }
        
        if(this.modsDoubleGO != 0)
        {
                this.modsDoubleGO.SetActive(value:  (val_51 == 2) ? 1 : 0);
        }
        
        if(this.modesTripleGO != 0)
        {
                this.modesTripleGO.SetActive(value:  (val_51 > 2) ? 1 : 0);
        }
        
        this.上不丟东丞丑丟七世 = true;
    }
    private void LateUpdate()
    {
        if(this.上不丟东丞丑丟七世 == false)
        {
                return;
        }
        
        this.上不丟东丞丑丟七世 = false;
    }
    public MapEventPauseUI()
    {
        this.updateOnEnable = true;
        this.不东丁一且七业丗丟 = new System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛>();
    }

}
