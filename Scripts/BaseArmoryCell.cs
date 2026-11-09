using UnityEngine;
public abstract class BaseArmoryCell : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _godlikeDivisionGui;
    private UnityEngine.GameObject _nonGodlikeDivisionGui;
    private UILabel _clanLockedOnDivisionLabel;
    private UISprite _clanLockebByDivisions;
    private UnityEngine.GameObject _clanLockebByDivisionsContainer;
    private static System.Action<BaseArmoryCell> 丘丁丗万丛不不丛七;
    private static System.Action<BaseArmoryCell> 丅丕丌丛万丂丈七与;
    private static System.Action<BaseArmoryCell> 不丗世丙丂丈七丅丒;
    public UnityEngine.GameObject emptyModuleChestGO;
    public UIToggle toggle;
    private UIBasicSprite icon;
    private string _itemId;
    private CategoryNames <丄上丞不三与一丅丒>k__BackingField;
    protected 丙且上东下丏丏丟下 丑丝丏丂且不下一东;
    private bool <丆丂丐丗丙业丒丒业>k__BackingField;
    protected const string 丂丐丌一丏丄专七东 = "Unlit/TransparentRGBMasked";
    
    // Properties
    public UIBasicSprite 丛丙丂丝不丏上东不 { get; }
    public string 与丙丌丈下万业丙丕 { get; set; }
    public CategoryNames 七丌丌丏丗东丕且丅 { get; set; }
    internal bool 丈丗世与丄丆且丒丆 { get; set; }
    
    // Methods
    internal static void 丑一丄丐丂世丕万世(System.Action<BaseArmoryCell> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  BaseArmoryCell.丂丐丌一丏丄专七东, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丂丁丑丏丞上丂丐丟(System.Action<BaseArmoryCell> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  BaseArmoryCell.丂丐丌一丏丄专七东, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 七一丕丁丅且专一丂(System.Action<BaseArmoryCell> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  BaseArmoryCell.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(BaseArmoryCell.丅丕丌丛万丂丈七与 != 1152921505039224840);
    
    }
    internal static void 不上世丙丈丅丒上丂(System.Action<BaseArmoryCell> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  BaseArmoryCell.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(BaseArmoryCell.丅丕丌丛万丂丈七与 != 1152921505039224840);
    
    }
    internal static void 丛丆丝一东一丙专不(System.Action<BaseArmoryCell> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  BaseArmoryCell.不丗世丙丂丈七丅丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(BaseArmoryCell.不丗世丙丂丈七丅丒 != 1152921505039224848);
    
    }
    internal static void 丄丁丕上且三丒三世(System.Action<BaseArmoryCell> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  BaseArmoryCell.不丗世丙丂丈七丅丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(BaseArmoryCell.不丗世丙丂丈七丅丒 != 1152921505039224848);
    
    }
    public UIBasicSprite get_Icon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.icon);
        this.icon = val_1;
        return val_1;
    }
    internal void 丄丈下丈上万世专丙()
    {
        UnityEngine.Shader val_2 = UnityEngine.Shader.Find(name:  "Unlit/TransparentRGBMasked");
        if(this.Icon == null)
        {
            
        }
    
    }
    public string get_ItemId()
    {
        return (string)this._itemId;
    }
    protected void 丆世丄丐丐与丄下三(string 丙业与丙丗丝不丈东)
    {
        this._itemId = 丙业与丙丗丝不丈东;
    }
    public CategoryNames get_Category()
    {
        return (CategoryNames)this.<丄上丞不三与一丅丒>k__BackingField;
    }
    protected void 与丘丑丒丅丕丞七丈(CategoryNames 丙业与丙丗丝不丈东)
    {
        this.<丄上丞不三与一丅丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public virtual void HandleToggleClicked(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        if(BaseArmoryCell.丂丐丌一丏丄专七东 == null)
        {
                return;
        }
        
        BaseArmoryCell.丂丐丌一丏丄专七东.Invoke(obj:  this);
    }
    public virtual void Setup(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丑丙丈三丞一丙丕丅, bool 丆丗一丛丌一与丅且, bool 与上七丈丁三丂世丟)
    {
        if(下丅丙一丂丗丅丝七 != null)
        {
                this._itemId = 下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七();
        }
        else
        {
                this._itemId = 0.业上丙丞丐丄丆丅七();
        }
        
        this.<丄上丞不三与一丅丒>k__BackingField = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
        this.丑丝丏丂且不下一东 = 下丅丙一丂丗丅丝七;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.emptyModuleChestGO, 丏业丟一东丂东丘丛:  false);
    }
    public virtual void OnStartUse()
    {
    
    }
    public virtual void OnReuseWhenExists()
    {
    
    }
    public virtual void UnloadIcons()
    {
        if(this.Icon == 0)
        {
                return;
        }
        
        UIBasicSprite val_3 = this.Icon;
        this = ???;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
    }
    public virtual void OnPostSelect()
    {
    
    }
    protected virtual void OnClick()
    {
        if(this.toggle.value == false)
        {
                return;
        }
        
        if(BaseArmoryCell.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        BaseArmoryCell.丅丕丌丛万丂丈七与.Invoke(obj:  this);
    }
    protected virtual void OnDoubleClick()
    {
    
    }
    protected virtual void 丂不丒丅丂丆一上万()
    {
    
    }
    internal bool 丗丙丗丄丛丞丛且不()
    {
        return (bool)this.<丆丂丐丗丙业丒丒业>k__BackingField;
    }
    internal void 专丞万丄专业三丘丙(bool 丙业与丙丗丝不丈东)
    {
        this.<丆丂丐丗丙业丒丒业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected internal void 丝丞且一下上丐三丞()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanLockebByDivisionsContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._godlikeDivisionGui, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nonGodlikeDivisionGui, 丏业丟一东丂东丘丛:  false);
    }
    protected virtual void 丞业与下丛万丁下丙()
    {
        UILabel val_27;
        var val_28;
        float val_29;
        var val_30;
        string val_31;
        val_27 = this;
        int val_7 = 0;
        val_28 = null;
        val_28 = null;
        val_29 = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒;
        if((this._itemId.StartsWith(value:  val_29)) != false)
        {
                if(this._clanLockebByDivisionsContainer == 0)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanLockebByDivisionsContainer, 丏业丟一东丂东丘丛:  true);
            val_30 = null;
            val_30 = null;
            bool val_8 = System.Int32.TryParse(s:  this._itemId.Substring(startIndex:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.Length + 4), style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_7);
            if(this._clanLockebByDivisions != 0)
        {
                this._clanLockebByDivisions.spriteName = System.String.Format(format:  "cup{0}_small", arg0:  1);
        }
        
            val_29 = val_7;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._godlikeDivisionGui, 丏业丟一东丂东丘丛:  (val_29 == 7) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nonGodlikeDivisionGui, 丏业丟一东丂东丘丛:  (val_7 != 7) ? 1 : 0);
            if(this._clanLockedOnDivisionLabel == 0)
        {
                return;
        }
        
            val_27 = this._clanLockedOnDivisionLabel;
            val_27.text = 丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_7);
            return;
        }
        
        val_31 = this._itemId;
        if((this.<丄上丞不三与一丅丒>k__BackingField) == 30000)
        {
                if((System.Linq.Enumerable.FirstOrDefault<PGCompany.EggIncubatorProgress>(source:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄(), predicate:  new System.Func<PGCompany.EggIncubatorProgress, System.Boolean>(object:  this, method:  System.Boolean BaseArmoryCell::丆丐丙业丂专一丟东(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且)))) != null)
        {
                val_31 = val_18.DataId;
        }
        else
        {
                object[] val_19 = new object[1];
            val_19[0] = this._itemId;
            UnityEngine.Debug.LogErrorFormat(format:  "ArmoryCell: SetIcon, egg = null, ItemId = {0}", args:  val_19);
        }
        
        }
        
        val_29 = this.Icon;
        if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_31, 七丆丒与丗丌丄且丂:  this.<丄上丞不三与一丅丒>k__BackingField, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  true)) == 0)
        {
                return;
        }
        
        val_27 = this.Icon;
        UnityEngine.Shader val_26 = UnityEngine.Shader.Find(name:  ((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this._itemId)) != true) ? "Unlit/Transparent Black Colored 1" : "Unlit/TransparentRGBMasked");
        if(val_27 != null)
        {
                return;
        }
    
    }
    protected void 丒丒丂七丈丂不丄三()
    {
        if(this.toggle.value == false)
        {
                return;
        }
        
        if(BaseArmoryCell.不丗世丙丂丈七丅丒 == null)
        {
                return;
        }
        
        BaseArmoryCell.不丗世丙丂丈七丅丒.Invoke(obj:  this);
    }
    protected BaseArmoryCell()
    {
    
    }
    private bool 丆丐丙业丂专一丟东(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且)
    {
        return System.String.op_Equality(a:  丗丛不丁丑专专丂且.Id.ToString(), b:  this._itemId);
    }

}
