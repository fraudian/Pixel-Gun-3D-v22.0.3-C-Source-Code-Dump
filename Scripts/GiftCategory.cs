using UnityEngine;
[Serializable]
public class GiftCategory
{
    // Fields
    private readonly System.Collections.Generic.List<GiftInfo> _rootGifts;
    private System.Collections.Generic.List<GiftInfo> _ag;
    private System.Collections.Generic.List<string> _availableRandomProducts;
    public int ListPosition;
    private int parity;
    internal Rilisoft.丝丑丂丛万丐丈丘且 Parity;
    public GiftCategoryType Type;
    private readonly int unlockLevel;
    private readonly float partAllowedPercent;
    
    // Properties
    public System.Collections.Generic.List<GiftInfo> _allGifts { get; }
    public bool AnyGifts { get; }
    private System.Collections.Generic.List<GiftInfo> _availableGifts { get; }
    public int AvaliableGiftsCount { get; }
    
    // Methods
    public System.Collections.Generic.List<GiftInfo> get__allGifts()
    {
        System.Collections.Generic.List<GiftInfo> val_2 = this._ag;
        if(val_2 != null)
        {
                return val_2;
        }
        
        System.Collections.Generic.List<GiftInfo> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.List<GiftInfo>(collection:  this._rootGifts);
        this._ag = val_2;
        return val_2;
    }
    public bool get_AnyGifts()
    {
        return (bool)(this._allGifts.Count > 0) ? 1 : 0;
    }
    private System.Collections.Generic.List<GiftInfo> get__availableGifts()
    {
        return System.Linq.Enumerable.ToList<GiftInfo>(source:  System.Linq.Enumerable.Where<GiftInfo>(source:  this._allGifts, predicate:  new System.Func<GiftInfo, System.Boolean>(object:  this, method:  System.Boolean GiftCategory::丒丞丐东丗下七丌与(GiftInfo 业七丐世专丝丂丟丈))));
    }
    public int get_AvaliableGiftsCount()
    {
        var val_11;
        var val_12;
        val_11 = this;
        if(this.Type != 5)
        {
            goto label_1;
        }
        
        if((System.String.IsNullOrEmpty(value:  SkinsController.丑上万专丟业上丁丑())) == false)
        {
            goto label_4;
        }
        
        val_12 = 0;
        return (int)val_12;
        label_1:
        System.Collections.Generic.List<GiftInfo> val_3 = this._availableGifts;
        if(val_3 != null)
        {
                return val_3.Count;
        }
        
        return val_3.Count;
        label_4:
        val_12 = this._availableGifts;
        if(val_12.Count == 0)
        {
                return (int)val_12;
        }
        
        if(this._availableGifts.Count >= 1)
        {
                val_11 = this._availableGifts.Item[0];
            val_12 = val_11;
            if(val_12.Count == 0)
        {
                return (int)val_12;
        }
        
        }
        
        val_12 = 1;
        return (int)val_12;
    }
    public void 不丕丕专不丅一三丁(GiftInfo 东一丁世丑丞业丄丐)
    {
        this._rootGifts.Add(item:  东一丁世丑丞业丄丐);
    }
    public void 上一上丁东七七业下()
    {
        null = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        GiftController.丆丕丝丒不丙且丐丗.一丘丏七丁丕世丕下(下上丐丆丝丟丝丒不:  this.Type.ToString(), 丙业与丙丗丝不丈东:  System.String.alignConst);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐上专丕丘丆丆下万(丂丕下不与丄丞丁丙:  GiftController.丆丕丝丒不丙且丐丗.不不七与丏东专东丏());
    }
    public bool 丝专丝丞与丟丝丗丞(string 丑丞业丗丒三丂且东)
    {
        string val_6 = 丑丞业丗丒三丂且东;
        GiftCategory.业丂七丏丟丕丌丂世 val_1 = new GiftCategory.业丂七丏丟丕丌丂世();
        if(val_1 != null)
        {
                .丑丞业丗丒三丂且东 = val_6;
        }
        else
        {
                mem[16] = val_6;
            val_6 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true)
        {
                return false;
        }
        
        val_6 = this._allGifts;
        GiftInfo val_5 = System.Linq.Enumerable.SingleOrDefault<GiftInfo>(source:  val_6, predicate:  new System.Func<GiftInfo, System.Boolean>(object:  val_1, method:  System.Boolean GiftCategory.业丂七丏丟丕丌丂世::丞三丞丒丛丄三上丘(GiftInfo 业七丐世专丝丂丟丈)));
        if(val_5 == null)
        {
                return false;
        }
        
        return this.丝专丝丞与丟丝丗丞(且丌丒丝不丛上三丆:  val_5, 丒丕七丄丏三丕丗丑:  this.Type);
    }
    public bool 丝专丝丞与丟丝丗丞(GiftInfo 且丌丒丝不丛上三丆, GiftCategoryType 丒丕七丄丏三丕丗丑)
    {
        string val_70;
        var val_71;
        var val_73;
        val_70 = 丒丕七丄丏三丕丗丑;
        if(((且丌丒丝不丛上三丆 == null) || ((System.String.IsNullOrEmpty(value:  且丌丒丝不丛上三丆.Id)) == true)) || ((且丌丒丝不丛上三丆.Count & 2147483648) != 0))
        {
            goto label_132;
        }
        
        val_71 = null;
        val_71 = null;
        if(且丌丒丝不丛上三丆.Setting != GiftController.丆丕丝丒不丙且丐丗.丁东丑丏丐丗丝七一)
        {
                if(且丌丒丝不丛上三丆.Setting != 1)
        {
            goto label_132;
        }
        
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_4 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if((val_70 - 1) > 176)
        {
            goto label_10;
        }
        
        var val_71 = 106034796 + ((丒丕七丄丏三丕丗丑 - 1)) << 2;
        val_71 = val_71 + 106034796;
        goto (106034796 + ((丒丕七丄丏三丕丗丑 - 1)) << 2 + 106034796);
        label_132:
        val_73 = 0;
        label_119:
        val_73 = val_73 & 1;
        return (bool)val_73;
        label_10:
        if(val_70 != 9999)
        {
            goto label_132;
        }
        
        goto label_119;
    }
    internal GiftInfo 丗上丆丟丄丕丐丅业(string 丞丅上丏丂且下丅与, bool 专东丅一三丏三丐丟 = False)
    {
        string val_7;
        var val_8;
        var val_9;
        val_7 = this;
        GiftInfo val_1 = this.丁丛丛丂丞下丘丙丒(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
        if(val_1 == null)
        {
                return val_1;
        }
        
        val_8 = null;
        val_8 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        mem2[0] = null;
        GiftController.丆丕丝丒不丙且丐丗.一丘丏七丁丕世丕下(下上丐丆丝丟丝丒不:  this.Type.ToString(), 丙业与丙丗丝不丈东:  val_1.Id);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        mem2[0] = null;
        val_7 = val_1.Id;
        GiftController.丆丕丝丒不丙且丐丗.一丘丏七丁丕世丕下(下上丐丆丝丟丝丒不:  this.Type.ToString() + "_shown", 丙业与丙丗丝不丈东:  val_7);
        if(专东丅一三丏三丐丟 == false)
        {
                return val_1;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = GiftController.丆丕丝丒不丙且丐丗.不不七与丏东专东丏();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐上专丕丘丆丆下万(丂丕下不与丄丞丁丙:  val_7);
        return val_1;
    }
    public GiftInfo 丄丗三业东丕丙丈丄(bool 专东丅一三丏三丐丟 = False)
    {
        null = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        return this.丗上丆丟丄丕丐丅业(丞丅上丏丂且下丅与:  丞东丑专丛丆丄丝世.丂丏丞丘丗丒丕且丐<System.String, System.String>(丏丂万业丙专丏丒丒:  GiftController.丆丕丝丒不丙且丐丗.不不七与丏东专东丏(), 下上丐丆丝丟丝丒不:  this.Type.ToString(), 丝专且上丈专下上且:  System.String.alignConst), 专东丅一三丏三丐丟:  专东丅一三丏三丐丟);
    }
    private GiftInfo 丁丛丛丂丞下丘丙丒(string 丞丅上丏丂且下丅与)
    {
        GiftCategoryType val_18;
        string val_19;
        var val_20;
        val_18 = this;
        GiftCategory.上三且上丁业与与丑 val_1 = null;
        val_19 = val_1;
        val_1 = new GiftCategory.上三且上丁业与与丑();
        .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
        System.Collections.Generic.List<GiftInfo> val_2 = this._availableGifts;
        if((val_2 == null) || (val_2.Count == 0))
        {
            goto label_9;
        }
        
        if((System.String.IsNullOrEmpty(value:  (GiftCategory.上三且上丁业与与丑)[1152921537791323648].丞丅上丏丂且下丅与)) == false)
        {
            goto label_4;
        }
        
        label_21:
        val_20 = val_2.Item[UnityEngine.Random.Range(min:  0, max:  val_2.Count)];
        return (GiftInfo)val_20;
        label_4:
        if(this.Type != 5)
        {
            goto label_6;
        }
        
        if(val_2.Count >= 1)
        {
                if(val_2.Item[0].Count == 0)
        {
            goto label_9;
        }
        
        }
        
        GiftInfo val_11 = null;
        val_20 = val_11;
        val_11 = new GiftInfo();
        if((SkinsController.七丞丌丁丂丌丏丟丘(专丑丐丅世丒不七丈:  (GiftCategory.上三且上丁业与与丑)[1152921537791323648].丞丅上丏丂且下丅与)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  (GiftCategory.上三且上丁业与与丑)[1152921537791323648].丞丅上丏丂且下丅与)) == false)
        {
            goto label_13;
        }
        
        }
        
        val_19 = SkinsController.丑上万专丟业上丁丑();
        if(val_20 != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        .Id = val_19;
        val_18 = this.Type;
        .KeyTranslateInfo = GiftController.丁不丐丕专一丞业与(丁丅丈丌丟世丗丗丟:  val_18);
        return (GiftInfo)val_20;
        label_9:
        val_20 = 0;
        return (GiftInfo)val_20;
        label_6:
        if((System.Linq.Enumerable.FirstOrDefault<GiftInfo>(source:  val_2, predicate:  new System.Func<GiftInfo, System.Boolean>(object:  val_1, method:  System.Boolean GiftCategory.上三且上丁业与与丑::万七七东万东不丝丞(GiftInfo 业七丐世专丝丂丟丈)))) != null)
        {
                return (GiftInfo)val_20;
        }
        
        goto label_21;
        label_13:
        if(val_20 != null)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    public GiftCategory()
    {
        this._rootGifts = new System.Collections.Generic.List<GiftInfo>();
        this.ListPosition = 0;
        this.parity = 0;
        this.Parity = 0;
        mem[1152921537791470264] = 0;
        this.unlockLevel = 2;
        this.partAllowedPercent = 7.346868E-41f;
    }
    private bool 丒丞丐东丗下七丌与(GiftInfo 业七丐世专丝丂丟丈)
    {
        return this.丝专丝丞与丟丝丗丞(且丌丒丝不丛上三丆:  业七丐世专丝丂丟丈, 丒丕七丄丏三丕丗丑:  this.Type);
    }

}
