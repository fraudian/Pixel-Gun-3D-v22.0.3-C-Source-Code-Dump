using UnityEngine;
[Serializable]
public class ClanItem
{
    // Fields
    private Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Texture> _backgroundTexture;
    private int _count;
    private string _id;
    private Rilisoft.七丞丞丅东丞专丙丝<ItemRarity> _rarity;
    private int _sortOrder;
    private Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Texture> _texture;
    private ClanItemType _type;
    private bool _isDefaultItem;
    
    // Properties
    public ClanItemType Type { get; }
    public string Id { get; }
    public int Count { get; set; }
    public int SortOrder { get; }
    public bool IsDefault { get; }
    public bool IsCrafted { get; }
    internal ItemRarity Rarity { get; }
    public UnityEngine.Texture Texture { get; }
    public UnityEngine.Texture BackgroundTexture { get; }
    public string LocalizedName { get; }
    
    // Methods
    public ClanItem()
    {
        this._texture = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Texture>(丙丂丌且丌世丒丐三:  new System.Func<UnityEngine.Texture>(object:  this, method:  UnityEngine.Texture ClanItem::丕丁七丛丙与丘专下()));
        this._backgroundTexture = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Texture>(丙丂丌且丌世丒丐三:  new System.Func<UnityEngine.Texture>(object:  this, method:  UnityEngine.Texture ClanItem::丗上世丑下且三丏丞()));
        this._rarity = new Rilisoft.七丞丞丅东丞专丙丝<ItemRarity>(丙丂丌且丌世丒丐三:  new System.Func<ItemRarity>(object:  this, method:  ItemRarity ClanItem::丈丛下丞丌丝业丐三()));
    }
    public ClanItem(ClanItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丌丒丝东丌下丕丁丅 = 1, int 与世且且丐丑上丝且 = 0)
    {
        this._type = 丁丅丈丌丟世丗丗丟;
        this._id = 丞丅上丏丂且下丅与;
        this._count = 丌丒丝东丌下丕丁丅;
        this._sortOrder = 与世且且丐丑上丝且;
        this._isDefaultItem = Rilisoft.FortsManager.丈丕丗丕丆丛丄丆丘().ContainsValue(value:  丞丅上丏丂且下丅与);
    }
    public ClanItemType get_Type()
    {
        return (ClanItemType)this._type;
    }
    public string get_Id()
    {
        return (string)this._id;
    }
    public int get_Count()
    {
        return (int)this._count;
    }
    public void set_Count(int 丙业与丙丗丝不丈东)
    {
        this._count = 丙业与丙丗丝不丈东;
    }
    public int get_SortOrder()
    {
        return (int)this._sortOrder;
    }
    public bool get_IsDefault()
    {
        return (bool)this._isDefaultItem;
    }
    public bool get_IsCrafted()
    {
        Rilisoft.东且东丒丐世丐丞丒 val_2 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  this._id);
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        return val_2.且丅一一三七专丑丏();
    }
    internal ItemRarity get_Rarity()
    {
        if(this._rarity != null)
        {
                return this._rarity.世三丞丅丑丌丈丈一();
        }
        
        return this._rarity.世三丞丅丑丌丈丈一();
    }
    public UnityEngine.Texture get_Texture()
    {
        if(this._texture != null)
        {
                return this._texture.世三丞丅丑丌丈丈一();
        }
        
        return this._texture.世三丞丅丑丌丈丈一();
    }
    public UnityEngine.Texture get_BackgroundTexture()
    {
        if(this._backgroundTexture != null)
        {
                return this._backgroundTexture.世三丞丅丑丌丈丈一();
        }
        
        return this._backgroundTexture.世三丞丅丑丌丈丈一();
    }
    public string get_LocalizedName()
    {
        object val_11;
        var val_12;
        var val_13;
        var val_14;
        if(this._type == 100)
        {
            goto label_1;
        }
        
        if(this._type == 20)
        {
            goto label_2;
        }
        
        if(this._type == 10)
        {
                三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this._id);
            if(val_1 != null)
        {
                return 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_1.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_1.万上丄下业丛丌不丈() - 1);
        }
        
        }
        
        val_11 = 0;
        return (string)val_11;
        label_1:
        val_12 = null;
        val_12 = null;
        if((System.String.op_Equality(a:  this._id, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_12;
        }
        
        val_13 = "Key_0951";
        goto label_13;
        label_2:
        丞东丌丟与丅丅万丝 val_6 = Rilisoft.FortsManager.丅丁专丘丛丝丆丙丘(丞丅上丏丂且下丅与:  this._id);
        if(val_6 == null)
        {
            goto label_16;
        }
        
        return val_6.东丙上东业丆不丟丘();
        label_12:
        val_14 = null;
        val_14 = null;
        label_13:
        val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ((System.String.op_Equality(a:  this._id, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? "Key_0275" : 0);
        if(this._count < 2)
        {
                return (string)val_11;
        }
        
        val_11 = System.String.Format(format:  "{0} {1}", arg0:  this._count, arg1:  val_11);
        return (string)val_11;
        label_16:
        val_11 = System.String.alignConst;
        return (string)val_11;
    }
    private static ItemRarity 丙丕一丏丕万丏业且(ClanItem 下丅丙一丂丗丅丝七)
    {
        var val_8;
        string val_9;
        var val_10;
        val_8 = 下丅丙一丂丗丅丝七;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下丅丙一丂丗丅丝七._id)) == true)
        {
                return 0;
        }
        
        if(下丅丙一丂丗丅丝七._type != 20)
        {
                if(下丅丙一丂丗丅丝七._type != 10)
        {
                return 0;
        }
        
            val_9 = 下丅丙一丂丗丅丝七._id;
            if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_9)) == null)
        {
                return 0;
        }
        
            val_10 = ???;
        }
        else
        {
                val_9 = mem[val_10 + 32];
            val_9 = val_10 + 32;
            丞东丌丟与丅丅万丝 val_3 = Rilisoft.FortsManager.丅丁专丘丛丝丆丙丘(丞丅上丏丂且下丅与:  val_9);
            if(val_3 == null)
        {
                return 0;
        }
        
            return val_3.七东与丄丕丁丛世三();
        }
    
    }
    private static UnityEngine.Texture 一三丗万丞丘万与丄(ClanItem 下丅丙一丂丗丅丝七)
    {
        string val_4;
        ClanItemType val_5;
        var val_6;
        string val_7;
        val_4 = 下丅丙一丂丗丅丝七;
        if(val_4 == null)
        {
            goto label_1;
        }
        
        val_5 = 下丅丙一丂丗丅丝七._type;
        if(val_5 == 10)
        {
                return 丏丄丑上丛不丈且万.丟丕丟丟丁与一丒丏(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七._id, 与丏丏丁丌与且三专:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        
        if(val_5 == 20)
        {
            goto label_3;
        }
        
        goto label_4;
        label_1:
        if(1 == 10)
        {
                return 丏丄丑上丛不丈且万.丟丕丟丟丁与一丒丏(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七._id, 与丏丏丁丌与且三专:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        
        if(1 != 20)
        {
            goto label_8;
        }
        
        label_3:
        val_4 = 下丅丙一丂丗丅丝七._id;
        丞东丌丟与丅丅万丝 val_1 = Rilisoft.FortsManager.丅丁专丘丛丝丆丙丘(丞丅上丏丂且下丅与:  val_4);
        if(val_1 == null)
        {
                return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  BankController.丙不丒丒且世丆下丐(丏丂不专上丘丂不丅:  val_7 = 64, 世与丂且丘丐万丗丞:  val_4 = 下丅丙一丂丗丅丝七._count));
        }
        
        return val_1.丆下世世丟七专丞丒();
        label_8:
        val_5 = 1;
        label_4:
        if(val_5 != 100)
        {
            goto label_12;
        }
        
        if(val_4 == null)
        {
            goto label_13;
        }
        
        val_7 = 下丅丙一丂丗丅丝七._id;
        goto label_14;
        label_12:
        val_6 = 0;
        return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  BankController.丙不丒丒且世丆下丐(丏丂不专上丘丂不丅:  val_7, 世与丂且丘丐万丗丞:  val_4));
        label_13:
        label_14:
        return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  BankController.丙不丒丒且世丆下丐(丏丂不专上丘丂不丅:  val_7, 世与丂且丘丐万丗丞:  val_4));
    }
    private static UnityEngine.Texture 丌丐下丒三丑万丁一(ClanItem 下丅丙一丂丗丅丝七)
    {
        var val_6;
        var val_7;
        val_6 = 下丅丙一丂丗丅丝七;
        if(下丅丙一丂丗丅丝七._type == 100)
        {
                val_7 = "OfferIcons/craft_coincashback_cell";
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/craft_{0}_cell", arg0:  val_1.ToString().ToLower()));
        }
        
        ItemRarity val_1 = val_6.Rarity;
        val_6 = val_1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/craft_{0}_cell", arg0:  val_1.ToString().ToLower()));
    }
    public override string ToString()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    private UnityEngine.Texture 丕丁七丛丙与丘专下()
    {
        return ClanItem.一三丗万丞丘万与丄(下丅丙一丂丗丅丝七:  this);
    }
    private UnityEngine.Texture 丗上世丑下且三丏丞()
    {
        return ClanItem.丌丐下丒三丑万丁一(下丅丙一丂丗丅丝七:  this);
    }
    private ItemRarity 丈丛下丞丌丝业丐三()
    {
        return ClanItem.丙丕一丏丕万丏业且(下丅丙一丂丗丅丝七:  this);
    }

}
