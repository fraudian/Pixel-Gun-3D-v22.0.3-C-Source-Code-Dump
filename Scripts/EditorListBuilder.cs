using UnityEngine;
public class EditorListBuilder : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject itemPrefab;
    public UIScrollView scrollView;
    public UIGrid grid;
    public UIToggle defaultFilter;
    public UploadShopItemDataToServer applyWindow;
    public UIInput generateTextFile;
    public UIWidget promoActionPanel;
    public UIWidget x3Panel;
    private System.Collections.Generic.Dictionary<string, int> 丟丆丂丑丆三业一丆;
    private System.Collections.Generic.List<string> 丒且下上丗世丟丑丙;
    private System.Collections.Generic.List<string> 丝丞与丙与丂上万业;
    private 与丐万丄上丅下万丂 且丘丒丗丛丕丅丏世;
    private bool 世丕丁丑丌下三专丙;
    private System.Collections.Generic.List<丅丒丌且三丅丄丆丟> 丄三业丟上丐丛丘丆;
    
    // Methods
    private void Start()
    {
        string val_1 = 丟丏下丂七三下丗丕.丗七丏三万丛丙丟业();
        this.且丘丒丗丛丕丅丏世 = 6;
        this.世丕丁丑丌下三专丙 = true;
    }
    private 丅丒丌且三丅丄丆丟 万丝业丌丂丘丞丌丙(string 丆万一不丌且东丐丐)
    {
        if((this.丟丆丂丑丆三业一丆.ContainsKey(key:  丆万一不丌且东丐丐)) != false)
        {
                .三丒万万丗世三丆丄 = this.丟丆丂丑丆三业一丆.Item[丆万一不丌且东丐丐];
        }
        
        .丆万一不丌且东丐丐 = 丆万一不丌且东丐丐;
        .万世丆丏丟丑不丄丝 = this.丒且下上丗世丟丑丙.Contains(item:  丆万一不丌且东丐丐);
        .且丑丛丏丌世丆七丌 = this.丝丞与丙与丂上万业.Contains(item:  丆万一不丌且东丐丐);
        return (丅丒丌且三丅丄丆丟)new 丅丒丌且三丅丄丆丟();
    }
    private System.Collections.Generic.List<丅丒丌且三丅丄丆丟> 下上丏丒丙丙丂丒七()
    {
        var val_8;
        System.Collections.Generic.List<丅丒丌且三丅丄丆丟> val_2 = new System.Collections.Generic.List<丅丒丌且三丅丄丆丟>();
        val_8 = 0;
        goto label_1;
        label_15:
        丅丒丌且三丅丄丆丟 val_6 = this.万丝业丌丂丘丞丌丙(丆万一不丌且东丐丐:  丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  UnityEngine.Resources.LoadAll<WeaponSounds>(path:  "Weapons/")[0].name).与不丞丑七丘丁丂丛());
        if(val_6 != null)
        {
                val_6.丘业丗丆下不一与东 = val_1[0x0] + 32 + 112;
        }
        else
        {
                mem[16] = val_1[0x0] + 32 + 112;
        }
        
        val_6.丁丅丈丌丟世丗丗丟 = 0;
        val_6.丟丈一下东业一丝丆 = val_1[0x0] + 32.name;
        val_2.Add(item:  val_6);
        val_8 = 1;
        label_1:
        if(val_8 < val_1.Length)
        {
            goto label_15;
        }
        
        return val_2;
    }
    private System.Collections.Generic.List<丅丒丌且三丅丄丆丟> 不上丄下丌三丞下不(与丐万丄上丅下万丂 丁丅丈丌丟世丗丗丟)
    {
        var val_7;
        var val_8;
        if((丁丅丈丌丟世丗丗丟 - 2) <= 3)
        {
                val_7 = mem[130688912 + ((丁丅丈丌丟世丗丗丟 - 2)) << 3];
            val_7 = 130688912 + ((丁丅丈丌丟世丗丗丟 - 2)) << 3;
        }
        
        System.Collections.Generic.List<丅丒丌且三丅丄丆丟> val_3 = new System.Collections.Generic.List<丅丒丌且三丅丄丆丟>();
        val_8 = 0;
        goto label_3;
        label_14:
        丅丒丌且三丅丄丆丟 val_5 = this.万丝业丌丂丘丞丌丙(丆万一不丌且东丐丐:  UnityEngine.Resources.LoadAll<ShopPositionParams>(path:  System.String.__il2cppRuntimeField_static_fields)[0].name);
        if(val_5 != null)
        {
                val_5.丘业丗丆下不一与东 = val_2[0x0] + 32 + 64;
        }
        else
        {
                mem[16] = val_2[0x0] + 32 + 64;
        }
        
        val_5.丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        val_5.丟丈一下东业一丝丆 = val_2[0x0] + 32.name;
        val_3.Add(item:  val_5);
        val_8 = 1;
        label_3:
        if(val_8 < val_2.Length)
        {
            goto label_14;
        }
        
        return val_3;
    }
    private System.Collections.Generic.List<丅丒丌且三丅丄丆丟> 丁上且专东与丛丆不()
    {
        var val_5;
        var val_11;
        var val_12;
        System.Collections.Generic.List<丅丒丌且三丅丄丆丟> val_1 = new System.Collections.Generic.List<丅丒丌且三丅丄丆丟>();
        val_11 = null;
        val_11 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = SkinsController.丑丝七丒丅丙东丞万.GetEnumerator();
        label_11:
        if(((-1822340608) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        丅丒丌且三丅丄丆丟 val_8 = this.万丝业丌丂丘丞丌丙(丆万一不丌且东丐丐:  val_6._value._obj.丐丏七丌丕丗业且上());
        val_12 = null;
        val_12 = null;
        string val_10 = SkinsController.专丑下七丑丆丆丈不.Item[val_6._value._obj.丐丏七丌丕丗业且上()];
        if(val_8 != null)
        {
                val_8.丘业丗丆下不一与东 = val_10;
        }
        else
        {
                mem[16] = val_10;
        }
        
        val_8.丁丅丈丌丟世丗丗丟 = 1;
        val_1.Add(item:  val_8);
        goto label_11;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        return val_1;
    }
    public System.Collections.Generic.List<丅丒丌且三丅丄丆丟> GetItemsList(与丐万丄上丅下万丂 丟丐上丟丆丙丄丗丈)
    {
        System.Collections.Generic.IEnumerable<T> val_20;
        var val_21;
        val_20 = this;
        if(丟丐上丟丆丙丄丗丈 <= 6)
        {
                var val_19 = 106024352 + (丟丐上丟丆丙丄丗丈) << 2;
            val_19 = val_19 + 106024352;
        }
        else
        {
                val_21 = 0;
            return (System.Collections.Generic.List<丅丒丌且三丅丄丆丟>);
        }
    
    }
    private void 丒丝三丝丞一不与丞()
    {
        goto label_2;
        label_8:
        不丌丂丁丄一与丆丙.Destroy(万且万且丑丗且丌丆:  this.grid.GetComponentsInChildren<EditorShopItem>(includeInactive:  true)[0].gameObject);
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_8;
        }
    
    }
    private bool 丂丌丕上丛业丝丄丈(丅丒丌且三丅丄丆丟 丏专丕万丘丝与万三)
    {
        与丐万丄上丅下万丂 val_2;
        var val_3;
        val_2 = this.且丘丒丗丛丕丅丏世;
        if(val_2 == 6)
        {
            goto label_6;
        }
        
        if(val_2 != 7)
        {
            goto label_1;
        }
        
        if(丏专丕万丘丝与万三.且丑丛丏丌世丆七丌 == true)
        {
            goto label_6;
        }
        
        val_2 = this.且丘丒丗丛丕丅丏世;
        label_1:
        if(val_2 != 8)
        {
            goto label_4;
        }
        
        if(丏专丕万丘丝与万三.万世丆丏丟丑不丄丝 == true)
        {
            goto label_6;
        }
        
        val_2 = this.且丘丒丗丛丕丅丏世;
        label_4:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        if(丏专丕万丘丝与万三.三丒万万丗世三丆丄 <= 0)
        {
            goto label_9;
        }
        
        label_6:
        val_3 = 1;
        return (bool)(val_2 == 丏专丕万丘丝与万三.丁丅丈丌丟世丗丗丟) ? 1 : 0;
        label_7:
        if(丏专丕万丘丝与万三 != null)
        {
                return (bool)(val_2 == 丏专丕万丘丝与万三.丁丅丈丌丟世丗丗丟) ? 1 : 0;
        }
        
        return (bool)(val_2 == 丏专丕万丘丝与万三.丁丅丈丌丟世丗丗丟) ? 1 : 0;
        label_9:
        val_2 = this.且丘丒丗丛丕丅丏世;
        return (bool)(val_2 == 丏专丕万丘丝与万三.丁丅丈丌丟世丗丗丟) ? 1 : 0;
    }
    private int 七万丒下丟丘丛丌丂(UnityEngine.Transform 丈丂丕下丏丈丞丗业, UnityEngine.Transform 丂丌丌丛丆丆丙丌丈)
    {
        static_value_082C37BF = true;
        EditorShopItem val_1 = 丈丂丕下丏丈丞丗业.GetComponent<EditorShopItem>();
        EditorShopItem val_2 = 丂丌丌丛丆丆丙丌丈.GetComponent<EditorShopItem>();
        int val_4 = 0;
        bool val_5 = System.Int32.TryParse(s:  val_1.<丕专丗七丒东业世丛>k__BackingField.Replace(oldValue:  "Weapon", newValue:  ""), result: out  val_4);
        int val_7 = 0;
        bool val_8 = System.Int32.TryParse(s:  val_2.<丕专丗七丒东业世丛>k__BackingField.Replace(oldValue:  "Weapon", newValue:  ""), result: out  val_7);
        return (int)(val_4 <= val_7) ? ((val_4 < val_7) ? 1 : 0) : (!0);
    }
    private void 丘丛丒丂且万丑丒三()
    {
        var val_13;
        var val_14;
        var val_15;
        object val_16;
        object val_17;
        UIGrid val_18;
        丞丝丑业与下丏丅下 val_19;
        if(this.丄三业丟上丐丛丘丆 != null)
        {
                if(this.世丕丁丑丌下三专丙 == false)
        {
            goto label_2;
        }
        
        }
        
        System.Collections.Generic.List<丅丒丌且三丅丄丆丟> val_1 = this.GetItemsList(丟丐上丟丆丙丄丗丈:  this.且丘丒丗丛丕丅丏世);
        this.丄三业丟上丐丛丘丆 = val_1;
        this.applyWindow.itemsData = val_1;
        label_2:
        this.丒丝三丝丞一不与丞();
        val_13 = 1152921537145094960;
        val_14 = 1152921505093320704;
        val_15 = 1152921537145097088;
        val_16 = 0;
        goto label_4;
        label_20:
        if((this.丂丌丕上丛业丝丄丈(丏专丕万丘丝与万三:  this.丄三业丟上丐丛丘丆.Item[0])) != false)
        {
                UnityEngine.GameObject val_5 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.grid.gameObject, 丑且不丕与专丄业丙:  this.itemPrefab);
            string val_6 = System.String.Format(format:  "{0:00}", arg0:  val_16);
            if(val_5 != null)
        {
                val_5.name = val_6;
        }
        else
        {
                0.name = val_6;
        }
        
            EditorShopItem val_7 = val_5.GetComponent<EditorShopItem>();
            if(val_7 != 0)
        {
                val_7.SetData(一丐丗丁丞丆丅丟丄:  this.丄三业丟上丐丛丘丆.Item[0]);
            val_14 = val_14;
            val_15 = val_15;
            val_13 = 1152921537145094960;
        }
        
            val_5.gameObject.SetActive(value:  true);
        }
        
        val_16 = 1;
        label_4:
        if(val_16 < this.丄三业丟上丐丛丘丆.Count)
        {
            goto label_20;
        }
        
        val_18 = this.grid;
        if(this.且丘丒丗丛丕丅丏世 == 0)
        {
            goto label_21;
        }
        
        if(val_18 == null)
        {
            goto label_25;
        }
        
        val_19 = 1;
        goto label_23;
        label_21:
        System.Comparison<UnityEngine.Transform> val_12 = null;
        val_17 = this;
        val_12 = new System.Comparison<UnityEngine.Transform>(object:  this, method:  System.Int32 EditorListBuilder::七万丒下丟丘丛丌丂(UnityEngine.Transform 丈丂丕下丏丈丞丗业, UnityEngine.Transform 丂丌丌丛丆丆丙丌丈));
        this.grid.onCustomSort = val_12;
        val_18 = this.grid;
        if(val_18 == null)
        {
            goto label_25;
        }
        
        val_19 = 4;
        label_23:
        this.grid.sorting = val_19;
        this.scrollView.ResetPosition();
        return;
        label_25:
    }
    private void 下丞下丘丄丅世一与()
    {
        this.丟丆丂丑丆三业一丆.Clear();
        this.丒且下上丗世丟丑丙.Clear();
        this.丝丞与丙与丂上万业.Clear();
    }
    public System.Collections.IEnumerator GetPromoActionsData()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new EditorListBuilder.丏丁丌丂丏丒丄丒不();
    }
    public void ChangeCurrentFilter(UIToggle 丒世丅业丝东下与丗)
    {
        var val_17;
        if(丒世丅业丝东下与丗 == 0)
        {
                return;
        }
        
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        this.丒丝三丝丞一不与丞();
        string val_3 = 丒世丅业丝东下与丗.name;
        uint val_4 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_3);
        if(val_4 > 1924133334)
        {
            goto label_7;
        }
        
        if(val_4 > 687804662)
        {
            goto label_8;
        }
        
        if(val_4 == 283458873)
        {
            goto label_9;
        }
        
        if((val_4 != 687804662) || ((System.String.op_Equality(a:  val_3, b:  "OnlySkinsCheckbox")) == false))
        {
            goto label_38;
        }
        
        val_17 = 1;
        goto label_37;
        label_7:
        if(val_4 > (-841725250))
        {
            goto label_13;
        }
        
        if(val_4 == (-2030001540))
        {
            goto label_14;
        }
        
        if((val_4 != (-841725250)) || ((System.String.op_Equality(a:  val_3, b:  "OnlyTopsCheckbox")) == false))
        {
            goto label_38;
        }
        
        val_17 = 8;
        goto label_37;
        label_8:
        if(val_4 == 1127903659)
        {
            goto label_18;
        }
        
        if(val_4 == 1225819676)
        {
            goto label_19;
        }
        
        if((val_4 != 1924133334) || ((System.String.op_Equality(a:  val_3, b:  "OnlyWeaponCheckbox")) == false))
        {
            goto label_38;
        }
        
        this.且丘丒丗丛丕丅丏世 = 0;
        goto label_38;
        label_13:
        if(val_4 == (-564676074))
        {
            goto label_23;
        }
        
        if(val_4 == (-534472863))
        {
            goto label_24;
        }
        
        if((val_4 != (-295062811)) || ((System.String.op_Equality(a:  val_3, b:  "AllCheckbox")) == false))
        {
            goto label_38;
        }
        
        val_17 = 6;
        goto label_37;
        label_9:
        if((System.String.op_Equality(a:  val_3, b:  "OnlyBootsCheckbox")) == false)
        {
            goto label_38;
        }
        
        val_17 = 5;
        goto label_37;
        label_14:
        if((System.String.op_Equality(a:  val_3, b:  "OnlyCapesCheckbox")) == false)
        {
            goto label_38;
        }
        
        val_17 = 4;
        goto label_37;
        label_18:
        if((System.String.op_Equality(a:  val_3, b:  "OnlyArmorCheckbox")) == false)
        {
            goto label_38;
        }
        
        val_17 = 3;
        goto label_37;
        label_19:
        if((System.String.op_Equality(a:  val_3, b:  "OnlyHatsCheckbox")) == false)
        {
            goto label_38;
        }
        
        val_17 = 2;
        goto label_37;
        label_23:
        if((System.String.op_Equality(a:  val_3, b:  "OnlyNewCheckbox")) == false)
        {
            goto label_38;
        }
        
        val_17 = 7;
        goto label_37;
        label_24:
        if((System.String.op_Equality(a:  val_3, b:  "OnlyDiscountCheckbox")) == false)
        {
            goto label_38;
        }
        
        val_17 = 9;
        label_37:
        this.且丘丒丗丛丕丅丏世 = 9;
        label_38:
        if(this.世丕丁丑丌下三专丙 != false)
        {
                UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.GetPromoActionsData());
            return;
        }
        
        this.丘丛丒丂且万丑丒三();
    }
    public void SendDataToServerClick()
    {
        this.applyWindow.Show(丁丅丈丌丟世丗丗丟:  0);
    }
    public void CheckAllTopState(UIToggle 丆世丄丁丕丒丘丕丂)
    {
        var val_4;
        goto label_2;
        label_10:
        T val_4 = this.grid.GetComponentsInChildren<EditorShopItem>(includeInactive:  true)[0];
        val_1[0x0][0] + 32.value = 丆世丄丁丕丒丘丕丂.value;
        val_4 = mem[val_1[0x0] + 32];
        val_4 = val_1[0x0] + 32;
        val_4.SetTopState();
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_10;
        }
    
    }
    public void CheckAllNewState(UIToggle 丒丗且不与丌一丟丂)
    {
        var val_4;
        goto label_2;
        label_10:
        T val_4 = this.grid.GetComponentsInChildren<EditorShopItem>(includeInactive:  true)[0];
        val_1[0x0][0] + 40.value = 丒丗且不与丌一丟丂.value;
        val_4 = mem[val_1[0x0] + 32];
        val_4 = val_1[0x0] + 32;
        val_4.SetNewState();
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_10;
        }
    
    }
    public void SetAllDiscounts(UIInput 不丒丞万不丏丏丘一)
    {
        var val_3;
        goto label_2;
        label_12:
        T val_3 = this.grid.GetComponentsInChildren<EditorShopItem>(includeInactive:  true)[0];
        val_1[0x0][0] + 48 + 24.text = 不丒丞万不丏丏丘一.label.text;
        val_3 = mem[val_1[0x0] + 32];
        val_3 = val_1[0x0] + 32;
        val_3.SetDiscount();
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_12;
        }
    
    }
    internal static void 专且丝下丝丘丑且不(string 丕丗丘丑丛与丑业丒)
    {
        UnityEngine.TextEditor val_1 = new UnityEngine.TextEditor();
        if(val_1 != null)
        {
                val_1.text = 丕丗丘丑丛与丑业丒;
            val_1.SelectAll();
        }
        else
        {
                val_1.text = 丕丗丘丑丛与丑业丒;
            val_1.SelectAll();
        }
        
        val_1.Copy();
    }
    public void GenerateUploadTextButtonClick()
    {
        this.generateTextFile.value = this.applyWindow.GenerateTextForUploadFile();
        EditorListBuilder.专且丝下丝丘丑且不(丕丗丘丑丛与丑业丒:  this.generateTextFile.value);
    }
    public void DownloadDataClick()
    {
        this.世丕丁丑丌下三专丙 = true;
        this.applyWindow.Show(丁丅丈丌丟世丗丗丟:  1);
    }
    public void ShowPromoActionsPanel()
    {
        if(this.x3Panel == null)
        {
            
        }
    
    }
    public void ShowX3ActionsPanel()
    {
        if(this.x3Panel == null)
        {
            
        }
    
    }
    public EditorListBuilder()
    {
        this.丟丆丂丑丆三业一丆 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        this.丒且下上丗世丟丑丙 = new System.Collections.Generic.List<System.String>();
        this.丝丞与丙与丂上万业 = new System.Collections.Generic.List<System.String>();
    }

}
