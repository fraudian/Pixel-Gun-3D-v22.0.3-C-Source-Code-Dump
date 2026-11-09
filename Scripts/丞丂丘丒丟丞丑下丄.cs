using UnityEngine;
public class 丞丂丘丒丟丞丑下丄
{
    // Fields
    private string _creatorId;
    private string _id;
    private System.Collections.Generic.List<string> _invites;
    private string _leaderName;
    private string _logo;
    private string _logoHash;
    private System.Collections.Generic.List<七丈丗不丞丈丝丙七> _members;
    private string _name;
    private System.Collections.Generic.List<丅下丙一东丄丕丛下> _requests;
    private int _siegesWon;
    private string _slogan;
    private 丞丂丘丒丟丞丑下丄.丏丆丘丌且丒丏丄丏 _type;
    private int _version;
    private Rilisoft.丝丑丂丛万丐丈丘且 _clanWarScores;
    private PGCompany.Clans.业丟业世世七丈三丄 <业且丒丙丒丞丄上丕>k__BackingField;
    private Rilisoft.丝丑丂丛万丐丈丘且 _minimumRank;
    internal System.Collections.Generic.List<int> 且业丞一上丕丅三丌;
    private PGCompany.丁丏丝上丘丝丒丞丒 <丁丑业丅丟丘丐专上>k__BackingField;
    private UnityEngine.Texture2D 专业丆东丙丗上与丅;
    private int 业丆万丆专丗一丟丏;
    private Rilisoft.丝丑丂丛万丐丈丘且 _promotionEndTime;
    private Rilisoft.丝丑丂丛万丐丈丘且 divisionIndex;
    private Rilisoft.丝丑丂丛万丐丈丘且 丘三丙丞丂业世丆且;
    private Rilisoft.丝丑丂丛万丐丈丘且 丝世一三丂业丕丝丄;
    private Rilisoft.丝丑丂丛万丐丈丘且 业丏一丌丞世丆丄专;
    private Rilisoft.丝丑丂丛万丐丈丘且 丒且七世下专丁一丏;
    private Rilisoft.丝丑丂丛万丐丈丘且 丆丆丄丁世丒丞丗丈;
    private string <丑且专丑丟丌与丘三>k__BackingField;
    private string <丙上丑世不丐丅丟一>k__BackingField;
    private Rilisoft.丝丑丂丛万丐丈丘且 一丆丞丌丑丌万丏丛;
    private System.Collections.Generic.List<七丈丗不丞丈丝丙七> <专上一丑一丐丁丌丙>k__BackingField;
    private bool <丏丟上业七丅丘且丁>k__BackingField;
    private bool <丁丂丛丞且丁丛不丄>k__BackingField;
    internal int 丄丑丙万丌丂一丄丙;
    internal int 丏一丄丆丙业丛丝下;
    private Rilisoft.丝丑丂丛万丐丈丘且 万上一三丑上丏丅丑;
    private Rilisoft.丝丑丂丛万丐丈丘且 上丐丏下丛一专三东;
    private Rilisoft.丝丑丂丛万丐丈丘且 上三丈丕与丕丌丐丌;
    private Rilisoft.丝丑丂丛万丐丈丘且 业丅上与丙丕下丏丌;
    private System.Collections.Generic.List<SquareFieldCellData> <下世不上丏下丏丗七>k__BackingField;
    private System.Collections.Generic.List<FortFieldItemInfo> <丈丞三丒丑不丆丝业>k__BackingField;
    private System.Collections.Generic.List<ClanTankEquipInfo> <不丗与丆业丗下业且>k__BackingField;
    internal int 不一一丙丘专丟丌丌;
    internal int 上丞三七业世且丆世;
    
    // Properties
    internal PGCompany.Clans.业丟业世世七丈三丄 丘丘下七万七东丒七 { get; set; }
    private System.Collections.Generic.List<PGCompany.Clans.业丟业世世七丈三丄.万三丂专与万三下三> _items_storage { get; }
    internal PGCompany.丁丏丝上丘丝丒丞丒 丘世丒上丏丄丙丅丘 { get; set; }
    internal int 不丘东丞丂丏一丛业 { get; set; }
    internal 一一万丒与专丙丁丛 丈丏业丈与丆下丆专 { get; }
    internal int 丞专丑丄东业不东丛 { get; set; }
    internal int 丑丁不专丁丈丅丝不 { get; set; }
    internal int 丞丞东三丁丐丞万七 { get; set; }
    internal int 专丂七丁下业不丑丘 { get; set; }
    internal int 且三一丂不丝专与丘 { get; set; }
    internal string LeaderMessage { get; set; }
    internal string Continent { get; set; }
    internal int 丗与专丈业丝丟丐上 { get; set; }
    internal System.Collections.Generic.List<七丈丗不丞丈丝丙七> 丌丆丘丁丌丟丄丒东 { get; set; }
    internal System.Collections.Generic.List<string> 世丛东丌世世专东丝 { get; set; }
    internal System.Collections.Generic.List<丅下丙一东丄丕丛下> 下与丕丙丕丞丗丏丏 { get; set; }
    internal bool 不下丕丕丗下丝丂丛 { get; set; }
    internal string 丞丘丄丂丏七丙一丝 { get; set; }
    internal string 丌丑丝上上丈丏业丒 { get; set; }
    internal UnityEngine.Texture2D 丒东丄七与下丈丄且 { get; }
    internal int 丛丏丅丆丟丑丌丞丅 { get; set; }
    internal int 不且且业丙万丟专丑 { get; set; }
    internal bool 不丈丗丌丅上东丞丛 { get; set; }
    internal 丞丂丘丒丟丞丑下丄.丏丆丘丌且丒丏丄丏 丒三丝一上丙专丗丒 { get; set; }
    internal string 东七下专七丅丁丆专 { get; set; }
    internal int 万丄丟万丒一一不不 { get; set; }
    internal int 东丅丝丟丘上丄丒世 { get; set; }
    internal string 专丕与丒丗丁丘专丟 { get; set; }
    internal string 万与万丂下七丈丟丕 { get; set; }
    internal string 丁业世丅丌丛上下与 { get; set; }
    internal int 丂东下丂与丄与丒丕 { get; set; }
    internal string 业丙丂一丝且丄丑东 { get; set; }
    internal int 下丘丅丏丗丑丕上不 { get; set; }
    internal int 东世丁丌丙上丆丛万 { get; set; }
    internal int 丂下丝丝一且专业世 { get; set; }
    internal int 与业七上丁丐丟且丞 { get; set; }
    internal bool 丝丆丗丑一业一不丅 { get; }
    internal int 丘与七丏万丏丈丈丏 { get; set; }
    internal System.Collections.Generic.List<SquareFieldCellData> 上一丄且七丝七一丝 { get; set; }
    internal System.Collections.Generic.List<FortFieldItemInfo> 丄丏业世且且丞上一 { get; set; }
    internal System.Collections.Generic.List<ClanTankEquipInfo> 丞且七丛丙丒丗丈丐 { get; set; }
    internal System.Collections.Generic.List<七丈丗不丞丈丝丙七> 专不丂丄丂世丁丅丂 { get; set; }
    internal int 丝丑丌丑丙世专丛丅 { get; }
    internal int 丁丗丈专丂东丂丘世 { get; }
    
    // Methods
    internal PGCompany.Clans.业丟业世世七丈三丄 丐丌与丏丂东业业上()
    {
        return (PGCompany.Clans.业丟业世世七丈三丄)this.<业且丒丙丒丞丄上丕>k__BackingField;
    }
    internal void 丒丐丕丁丑丝丅丄一(PGCompany.Clans.业丟业世世七丈三丄 丙业与丙丗丝不丈东)
    {
        this.<业且丒丙丒丞丄上丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private System.Collections.Generic.List<PGCompany.Clans.业丟业世世七丈三丄.万三丂专与万三下三> 丞丆万丑一世与丐丘()
    {
        return System.Linq.Enumerable.ToList<万三丂专与万三下三>(source:  this.<业且丒丙丒丞丄上丕>k__BackingField.丑丒丏三丆丗专丞丗().Values);
    }
    internal PGCompany.丁丏丝上丘丝丒丞丒 东万丕丗丅万丄丘丙()
    {
        return (PGCompany.丁丏丝上丘丝丒丞丒)this.<丁丑业丅丟丘丐专上>k__BackingField;
    }
    internal void 丆万业丗三与下丈丟(PGCompany.丁丏丝上丘丝丒丞丒 丙业与丙丗丝不丈东)
    {
        this.<丁丑业丅丟丘丐专上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 丞丂丘丒丟丞丑下丄()
    {
        this._invites = new System.Collections.Generic.List<System.String>();
        this._members = new System.Collections.Generic.List<七丈丗不丞丈丝丙七>();
        this._requests = new System.Collections.Generic.List<丅下丙一东丄丕丛下>();
        this.且业丞一上丕丅三丌 = new System.Collections.Generic.List<System.Int32>();
        int val_5 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this._promotionEndTime = 0;
        mem[1152921536537490144] = 0;
        int val_6 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丘三丙丞丂业世丆且 = 0;
        mem[1152921536537490176] = 0;
        int val_7 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丝世一三丂业丕丝丄 = 0;
        mem[1152921536537490192] = 0;
        int val_8 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.业丏一丌丞世丆丄专 = 0;
        mem[1152921536537490208] = 0;
        int val_9 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丒且七世下专丁一丏 = 0;
        mem[1152921536537490224] = 0;
        this.<专上一丑一丐丁丌丙>k__BackingField = new System.Collections.Generic.List<七丈丗不丞丈丝丙七>();
        mem2[0] = 54;
        int val_11 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.万上一三丑上丏丅丑 = 0;
        mem[1152921536537490312] = 0;
        int val_12 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.上丐丏下丛一专三东 = 0;
        mem[1152921536537490328] = 0;
        int val_13 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.上三丈丕与丕丌丐丌 = 0;
        mem[1152921536537490344] = 0;
        int val_14 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.业丅上与丙丕下丏丌 = 0;
        mem[1152921536537490360] = 0;
        this.<下世不上丏下丏丗七>k__BackingField = new System.Collections.Generic.List<SquareFieldCellData>();
        this.<丈丞三丒丑不丆丝业>k__BackingField = new System.Collections.Generic.List<FortFieldItemInfo>();
        this.<不丗与丆业丗下业且>k__BackingField = new System.Collections.Generic.List<ClanTankEquipInfo>();
        this.<业且丒丙丒丞丄上丕>k__BackingField = new PGCompany.Clans.业丟业世世七丈三丄();
        this.<丁丑业丅丟丘丐专上>k__BackingField = new PGCompany.丁丏丝上丘丝丒丞丒(且丟丅丄丒丑丂丁世:  this);
    }
    internal 丞丂丘丒丟丞丑下丄(string 丞丅上丏丂且下丅与, string 丒丘丏上丙丟丑丕丈, string 丌万丌丅丐丗丘专丒, 丞丂丘丒丟丞丑下丄.丏丆丘丌且丒丏丄丏 丁丅丈丌丟世丗丗丟)
    {
        this._id = 丞丅上丏丂且下丅与;
        bool val_2 = System.Int32.TryParse(s:  丞丅上丏丂且下丅与, result: out  this.业丆万丆专丗一丟丏);
        this._name = 丒丘丏上丙丟丑丕丈;
        this._creatorId = 丌万丌丅丐丗丘专丒;
        this._type = 丁丅丈丌丟世丗丗丟;
    }
    internal int 三丑与丏丈丕七丙丂()
    {
    
    }
    internal void 丛丏丛丄丗丆万丙丌(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.divisionIndex = 0;
        mem[1152921536537899888] = 0;
    }
    internal 一一万丒与专丙丁丛 世丝丌一且丝专丑丛()
    {
    
    }
    internal int 上上三七丟丝与丆与()
    {
    
    }
    internal void 丁丟丝丐丛万丝丞与(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.业丏一丌丞世丆丄专 = 0;
        mem[1152921536538235936] = 0;
    }
    internal int 丁世丒丂丁不世丈丒()
    {
    
    }
    internal void 丝东丄丈世七丂专下(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丒且七世下专丁一丏 = 0;
        mem[1152921536538459952] = 0;
    }
    internal int 三丒三丕不七丁丅丈()
    {
    
    }
    internal void 丄丌丆丄丂丛丄专丆(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丘三丙丞丂业世丆且 = 0;
        mem[1152921536538683904] = 0;
    }
    internal int 丈专丙与丛下丈丕丒()
    {
    
    }
    internal void 业世丑东东丁与丞丒(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丝世一三丂业丕丝丄 = 0;
        mem[1152921536538907920] = 0;
    }
    internal int 三丕丝万且丈丒三丏()
    {
    
    }
    internal void 上三丅丙万丕上上与(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丆丆丄丁世丒丞丗丈 = 0;
        mem[1152921536539131968] = 0;
    }
    internal string 丞业三与丞三丏万丂()
    {
        return (string)this.<丑且专丑丟丌与丘三>k__BackingField;
    }
    internal void 丟上上丆丝业不丂下(string 丙业与丙丗丝不丈东)
    {
        this.<丑且专丑丟丌与丘三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 且丞东丑丟业丑丌万()
    {
        return (string)this.<丙上丑世不丐丅丟一>k__BackingField;
    }
    internal void 丏丙丅与世丁丟丏三(string 丙业与丙丗丝不丈东)
    {
        this.<丙上丑世不丐丅丟一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 上丆东丘七丅世业与()
    {
    
    }
    internal void 丅丈丄且丕丝业七丒(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.一丆丞丌丑丌万丏丛 = 0;
        mem[1152921536539836768] = 0;
    }
    internal System.Collections.Generic.List<七丈丗不丞丈丝丙七> 丙丆丞东丆丏丞一不()
    {
        return (System.Collections.Generic.List<七丈丗不丞丈丝丙七>)this.<专上一丑一丐丁丌丙>k__BackingField;
    }
    internal void 上上业上世丝丑万世(System.Collections.Generic.List<七丈丗不丞丈丝丙七> 丙业与丙丗丝不丈东)
    {
        this.<专上一丑一丐丁丌丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 七丈丗不丞丈丝丙七 丘下丏丞丂不三丂七(string 丄丒且丙三丆丟与丏)
    {
        var val_5;
        string val_6;
        var val_7;
        val_6 = 丄丒且丙三丆丟与丏;
        List.Enumerator<T> val_1 = this.<专上一丑一丐丁丌丙>k__BackingField.GetEnumerator();
        label_5:
        if((1868579176 & 1) == 0)
        {
            goto label_2;
        }
        
        val_7 = 0.丐丏七丌丕丗业且上();
        val_5 = val_7.业丐丐三丕一丗丛丁();
        if((val_5.Equals(value:  val_6)) == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_2:
        val_7 = 0;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (七丈丗不丞丈丝丙七);
    }
    internal System.Collections.Generic.List<string> 上丞东丌丐世与业丕()
    {
        return (System.Collections.Generic.List<System.String>)this._invites;
    }
    internal void 丘丛三丞丈丙丁专世(System.Collections.Generic.List<string> 丙业与丙丗丝不丈东)
    {
        this._invites = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<丅下丙一东丄丕丛下> 上丟下丌丞业丞专丄()
    {
        return (System.Collections.Generic.List<丅下丙一东丄丕丛下>)this._requests;
    }
    internal void 丂丄万专丁丙丞丈丞(System.Collections.Generic.List<丅下丙一东丄丕丛下> 丙业与丙丗丝不丈东)
    {
        this._requests = 丙业与丙丗丝不丈东;
    }
    internal bool 丞万丞七东万上东丗()
    {
        return (bool)this.<丏丟上业七丅丘且丁>k__BackingField;
    }
    internal void 丑丌丞丞与丆丂不丘(bool 丙业与丙丗丝不丈东)
    {
        this.<丏丟上业七丅丘且丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丒丄东丌一丑丘丆丈()
    {
        return (string)this._logoHash;
    }
    internal void 丏三上丗丘万丟丝三(string 丙业与丙丗丝不丈东)
    {
        this._logoHash = 丙业与丙丗丝不丈东;
    }
    internal string 东丝丈三专丟丌丄丝()
    {
        return (string)this._logo;
    }
    internal void 丑丛丟丗专丈丄专丞(string 丙业与丙丗丝不丈东)
    {
        if((System.String.op_Equality(a:  this._logo, b:  丙业与丙丗丝不丈东)) == true)
        {
                return;
        }
        
        this._logo = 丙业与丙丗丝不丈东;
        this.专业丆东丙丗上与丅 = 0;
    }
    internal UnityEngine.Texture2D 世丐专丂世丄世丂丌()
    {
        var val_5;
        UnityEngine.Texture2D val_6;
        if(this._logo != null)
        {
                if(this.专业丆东丙丗上与丅 == 0)
        {
                val_5 = null;
            val_5 = null;
            new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  与丂丏丛丞丞丒丟丄.下丒丗丘下且丕丟不, textureFormat:  5, mipChain:  false);
            bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  System.Convert.FromBase64String(s:  this._logo));
            new UnityEngine.Texture2D().filterMode = 0;
            this.专业丆东丙丗上与丅 = new UnityEngine.Texture2D();
        }
        
            val_6 = this.专业丆东丙丗上与丅;
            return (UnityEngine.Texture2D)val_6;
        }
        
        val_6 = 0;
        return (UnityEngine.Texture2D)val_6;
    }
    internal int 业不且丟丆下丏丌丒()
    {
    
    }
    internal void 丁丐七丘且丗丘业七(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this._clanWarScores = 0;
        mem[1152921536541870232] = 0;
    }
    internal int 丘丗丏丁丂丑一丌丙()
    {
    
    }
    internal void 专丙丌丙丁三丕三丅(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this._minimumRank = 0;
        mem[1152921536542094256] = 0;
    }
    internal bool 七东丏不与与丗丂丅()
    {
        return (bool)this.<丁丂丛丞且丁丛不丄>k__BackingField;
    }
    internal void 且丅丘东业丑丗三业(bool 丙业与丙丗丝不丈东)
    {
        this.<丁丂丛丞且丁丛不丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 丞丂丘丒丟丞丑下丄.丏丆丘丌且丒丏丄丏 不业丙丒丂丞下丆丙()
    {
        return (丏丆丘丌且丒丏丄丏)this._type;
    }
    internal void 东丝丕专丒丏三三与(丞丂丘丒丟丞丑下丄.丏丆丘丌且丒丏丄丏 丙业与丙丗丝不丈东)
    {
        this._type = 丙业与丙丗丝不丈东;
    }
    internal string 丆不与丕世丏三丅一()
    {
        return (string)this._slogan;
    }
    internal void 丗丑且丙上丂丅三上(string 丙业与丙丗丝不丈东)
    {
        this._slogan = 丙业与丙丗丝不丈东;
    }
    internal int 丛且丅丂不丟丆万丁()
    {
        return (int)this._siegesWon;
    }
    internal void 丗世丟丟丄与七业丞(int 丙业与丙丗丝不丈东)
    {
        this._siegesWon = 丙业与丙丗丝不丈东;
    }
    internal int 丟业丅世丟丗丄丞万()
    {
        return (int)this._version;
    }
    internal void 上上与不丈与丄下与(int 丙业与丙丗丝不丈东)
    {
        this._version = System.Math.Max(val1:  1, val2:  丙业与丙丗丝不丈东);
    }
    internal string 东丙上东业丆不丟丘()
    {
        return (string)this._name;
    }
    internal void 丌丏上丏东且丄丑丌(string 丙业与丙丗丝不丈东)
    {
        this._name = 丙业与丙丗丝不丈东;
    }
    internal string 丐丒且世丑丘丒上丒()
    {
        return (string)this._leaderName;
    }
    internal void 与不丟丁丂丆丑丆丁(string 丙业与丙丗丝不丈东)
    {
        this._leaderName = 丙业与丙丗丝不丈东;
    }
    internal string 业丐丐三丕一丗丛丁()
    {
        return (string)this._id;
    }
    internal void 下东丄丄丟丞东丁丅(string 丙业与丙丗丝不丈东)
    {
        this._id = 丙业与丙丗丝不丈东;
        bool val_2 = System.Int32.TryParse(s:  丙业与丙丗丝不丈东, result: out  this.业丆万丆专丗一丟丏);
    }
    internal int 丁丈丞一专下丛丕三()
    {
        return (int)this.业丆万丆专丗一丟丏;
    }
    internal void 上丈万上丏丒丐丈专(int 丙业与丙丗丝不丈东)
    {
        this.业丆万丆专丗一丟丏 = 丙业与丙丗丝不丈东;
    }
    internal string 丁丏丌丟丂丌一七与()
    {
        return (string)this._creatorId;
    }
    internal void 一且丙丒一下丒丏丈(string 丙业与丙丗丝不丈东)
    {
        this._creatorId = 丙业与丙丗丝不丈东;
    }
    internal int 东万丂丙业与丆东丐()
    {
    
    }
    internal void 丛丙丄万三丙丂下丑(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.万上一三丑上丏丅丑 = 0;
        mem[1152921536544656776] = 0;
    }
    internal int 上丒一丄不三专丕丛()
    {
    
    }
    internal void 东丌下七丝丛一丕丞(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.上丐丏下丛一专三东 = 0;
        mem[1152921536544880792] = 0;
    }
    internal int 七不世与一丛丐丕丛()
    {
    
    }
    internal void 丏丁丘专丑万丗丕丅(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.上三丈丕与丕丌丐丌 = 0;
        mem[1152921536545104808] = 0;
    }
    internal int 丑丒一下丏丌丞丅万()
    {
    
    }
    internal void 万且丕丒且下丌丛丘(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.业丅上与丙丕下丏丌 = 0;
        mem[1152921536545328824] = 0;
    }
    internal bool 丗丅与三不万一丟丐()
    {
        var val_4;
        var val_5;
        val_4 = this;
        if(PixelTime.丏丑丒丏万丏不丆丆() != false)
        {
                val_4 = this._promotionEndTime;
            var val_3 = (PixelTime.丙三丝下丛丈丌丟下() < (val_4 << )) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    internal int 丑丟丛丂丂东不不上()
    {
    
    }
    internal void 丁丄丅丐丙丏丄丆丌(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this._promotionEndTime = 0;
        mem[1152921536545664608] = 0;
    }
    internal System.Collections.Generic.List<SquareFieldCellData> 丌丂专不丁七一丙丗()
    {
        return (System.Collections.Generic.List<SquareFieldCellData>)this.<下世不上丏下丏丗七>k__BackingField;
    }
    internal void 万丒丙丁世上丌丕不(System.Collections.Generic.List<SquareFieldCellData> 丙业与丙丗丝不丈东)
    {
        this.<下世不上丏下丏丗七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<FortFieldItemInfo> 丟与且丙七丙丞下丏()
    {
        return (System.Collections.Generic.List<FortFieldItemInfo>)this.<丈丞三丒丑不丆丝业>k__BackingField;
    }
    internal void 丘丙丂专丙丟丆专与(System.Collections.Generic.List<FortFieldItemInfo> 丙业与丙丗丝不丈东)
    {
        this.<丈丞三丒丑不丆丝业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<ClanTankEquipInfo> 丒丗不丙业丟丄丏丂()
    {
        return (System.Collections.Generic.List<ClanTankEquipInfo>)this.<不丗与丆业丗下业且>k__BackingField;
    }
    internal void 上东丟丆丗丙丆东丏(System.Collections.Generic.List<ClanTankEquipInfo> 丙业与丙丗丝不丈东)
    {
        this.<不丗与丆业丗下业且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<七丈丗不丞丈丝丙七> 丐丂丄丏下七与一丌()
    {
        return (System.Collections.Generic.List<七丈丗不丞丈丝丙七>)this._members;
    }
    internal void 下丄丏东专丒万丞丛(System.Collections.Generic.List<七丈丗不丞丈丝丙七> 丙业与丙丗丝不丈东)
    {
        this._members = 丙业与丙丗丝不丈东;
    }
    internal int 丁丈丕丆下丙丏业世()
    {
        if(this.不一一丙丘专丟丌丌 > 0)
        {
                return (int)this.不一一丙丘专丟丌丌;
        }
        
        if(this._members != null)
        {
                return this._members.Count;
        }
        
        return this._members.Count;
    }
    internal int 一一上丄一专世丕丈()
    {
        var val_2;
        System.Func<七丈丗不丞丈丝丙七, System.Boolean> val_4;
        if(this.上丞三七业世且丆世 > 0)
        {
                return (int)this.上丞三七业世且丆世;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = 丞丂丘丒丟丞丑下丄.<>c.<>9__173_0;
        if(val_4 != null)
        {
                return System.Linq.Enumerable.Count<七丈丗不丞丈丝丙七>(source:  this._members, predicate:  System.Func<七丈丗不丞丈丝丙七, System.Boolean> val_1 = null);
        }
        
        val_4 = val_1;
        val_1 = new System.Func<七丈丗不丞丈丝丙七, System.Boolean>(object:  丞丂丘丒丟丞丑下丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丞丂丘丒丟丞丑下丄.<>c::丟专丂丙丛丑丅丆丑(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
        丞丂丘丒丟丞丑下丄.<>c.<>9__173_0 = val_4;
        return System.Linq.Enumerable.Count<七丈丗不丞丈丝丙七>(source:  this._members, predicate:  val_1);
    }
    internal System.Collections.Generic.List<string> 业丌丂丑上七丄一且()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_2 = this._members.GetEnumerator();
        label_5:
        if((1875375848 & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.Add(item:  0.丐丏七丌丕丗业且上().业丐丐三丕一丗丛丁());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal bool 丕一下丒丝世下丘万(string 丞丅上丏丂且下丅与)
    {
        var val_5;
        List.Enumerator<T> val_1 = this._members.GetEnumerator();
        label_5:
        if((1875520632 & 1) == 0)
        {
            goto label_2;
        }
        
        if((0.丐丏七丌丕丗业且上().业丐丐三丕一丗丛丁().Equals(value:  丞丅上丏丂且下丅与)) == false)
        {
            goto label_5;
        }
        
        val_5 = 1;
        goto label_6;
        label_2:
        val_5 = 0;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    internal int 下上东丟丟世世且丄(string 丛上丅丑东丞丄不丁)
    {
        object val_6;
        var val_7;
        丞丂丘丒丟丞丑下丄.丏丂一丗丐丅丈业丄 val_1 = null;
        val_6 = val_1;
        val_1 = new 丞丂丘丒丟丞丑下丄.丏丂一丗丐丅丈业丄();
        .丛上丅丑东丞丄不丁 = 丛上丅丑东丞丄不丁;
        val_7 = this._members;
        if(val_7.Count == 0)
        {
                return (int)val_7.三七丆丑丙丆丘丛丆();
        }
        
        System.Predicate<七丈丗不丞丈丝丙七> val_3 = new System.Predicate<七丈丗不丞丈丝丙七>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.丏丂一丗丐丅丈业丄::丐丈下世丂丛丈与丒(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
        val_6 = this._members.Find(match:  null);
        val_7 = val_6;
        return (int)val_7.三七丆丑丙丆丘丛丆();
    }
    internal int 丝丟丘丌丐丘丘万丛(string 丛上丅丑东丞丄不丁)
    {
        object val_6;
        var val_7;
        丞丂丘丒丟丞丑下丄.丕世丐业世世丕丗丝 val_1 = null;
        val_6 = val_1;
        val_1 = new 丞丂丘丒丟丞丑下丄.丕世丐业世世丕丗丝();
        .丛上丅丑东丞丄不丁 = 丛上丅丑东丞丄不丁;
        val_7 = this._members;
        if(val_7.Count == 0)
        {
                return (int)val_7.丏丐世上东丙七丆丗();
        }
        
        System.Predicate<七丈丗不丞丈丝丙七> val_3 = new System.Predicate<七丈丗不丞丈丝丙七>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.丕世丐业世世丕丗丝::三业丑且一丘七丆丏(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
        val_6 = this._members.Find(match:  null);
        val_7 = val_6;
        return (int)val_7.丏丐世上东丙七丆丗();
    }
    internal int 丝万下丌丄丟专丂世(string 丛上丅丑东丞丄不丁)
    {
        object val_6;
        var val_7;
        丞丂丘丒丟丞丑下丄.不世丐专东丛专丑业 val_1 = null;
        val_6 = val_1;
        val_1 = new 丞丂丘丒丟丞丑下丄.不世丐专东丛专丑业();
        .丛上丅丑东丞丄不丁 = 丛上丅丑东丞丄不丁;
        val_7 = this._members;
        if(val_7.Count == 0)
        {
                return (int)val_7.不丕丒丁丈丅丏三丌();
        }
        
        System.Predicate<七丈丗不丞丈丝丙七> val_3 = new System.Predicate<七丈丗不丞丈丝丙七>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.不世丐专东丛专丑业::一且东世东丑丁不与(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
        val_6 = this._members.Find(match:  null);
        val_7 = val_6;
        return (int)val_7.不丕丒丁丈丅丏三丌();
    }
    internal bool 丛丛上丕丁丁七一不(string 丄丒且丙三丆丟与丏)
    {
        if(this._creatorId == null)
        {
                return (bool)this._creatorId;
        }
        
        return this._creatorId.Equals(value:  丄丒且丙三丆丟与丏);
    }
    internal 七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 三丕三下世丈丙与丈(string 丄丒且丙三丆丟与丏)
    {
        .丄丒且丙三丆丟与丏 = 丄丒且丙三丆丟与丏;
        七丈丗不丞丈丝丙七 val_3 = System.Linq.Enumerable.FirstOrDefault<七丈丗不丞丈丝丙七>(source:  this.<专上一丑一丐丁丌丙>k__BackingField, predicate:  new System.Func<七丈丗不丞丈丝丙七, System.Boolean>(object:  new 丞丂丘丒丟丞丑下丄.七丒丁不丑下丕且丆(), method:  System.Boolean 丞丂丘丒丟丞丑下丄.七丒丁不丑下丕且丆::丈与上丕丅上丁丟丙(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑)));
        if(val_3 == null)
        {
                return 0;
        }
        
        return val_3.丙丐丅丕丗丁丅丁丐();
    }
    internal bool 专丄与丁丗丗丙业丙()
    {
        return (bool)(this._members.Count == this.丄丑丙万丌丂一丄丙) ? 1 : 0;
    }
    internal bool 丆不丄丈与丈丌丟且()
    {
        return (bool)(this.一一上丄一专世丕丈() == this.丏一丄丆丙业丛丝下) ? 1 : 0;
    }
    internal void 丙世不世三丁东专丏(七丈丗不丞丈丝丙七 丛上丅丑东丞丄不丁)
    {
        if(this.专丄与丁丗丗丙业丙() != false)
        {
                return;
        }
        
        this._members.Add(item:  丛上丅丑东丞丄不丁);
    }
    internal void 且丞丒丛丅且万丘丑(string 丛上丅丑东丞丄不丁)
    {
        七丈丗不丞丈丝丙七 val_8;
        七丈丗不丞丈丝丙七 val_9;
        丞丂丘丒丟丞丑下丄.丝上丗丄丐东业上专 val_1 = new 丞丂丘丒丟丞丑下丄.丝上丗丄丐东业上专();
        .丛上丅丑东丞丄不丁 = 丛上丅丑东丞丄不丁;
        val_8 = System.Linq.Enumerable.FirstOrDefault<七丈丗不丞丈丝丙七>(source:  this._members, predicate:  new System.Func<七丈丗不丞丈丝丙七, System.Boolean>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.丝上丗丄丐东业上专::业丝丈与丅丝丞东不(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑)));
        if(val_1 != null)
        {
                val_9 = val_1;
            .上与丄丌丛七与丘丈 = val_8;
        }
        else
        {
                val_9 = 24;
            mem[24] = val_8;
        }
        
        if(val_9 == 0)
        {
                return;
        }
        
        if(val_1 == null)
        {
            goto label_5;
        }
        
        if(this._members != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        bool val_4 = this._members.Remove(item:  val_9);
        val_8 = this.<专上一丑一丐丁丌丙>k__BackingField;
        int val_6 = val_8.FindIndex(match:  new System.Predicate<七丈丗不丞丈丝丙七>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.丝上丗丄丐东业上专::与丈专丘东一丏丙丅(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑)));
        if((val_6 >> 31) == 0)
        {
            goto label_8;
        }
        
        return;
        label_5:
        if(this._members != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_8:
        this.<专上一丑一丐丁丌丙>k__BackingField.RemoveAt(index:  val_6);
    }
    internal bool 丌下丑丆东丈东丛丗(PGCompany.万丛下丐与丅与丅专 下丅丙一丂丗丅丝七)
    {
        PlaceableItemSettings val_8;
        var val_9;
        val_8 = 下丅丙一丂丗丅丝七;
        丞丂丘丒丟丞丑下丄.世丞丈丈万上不丂丙 val_1 = new 丞丂丘丒丟丞丑下丄.世丞丈丈万上不丂丙();
        if(val_8 == null)
        {
            goto label_3;
        }
        
        val_8 = val_8.丈丏专三世七丒丘丑();
        if(val_1 == null)
        {
            goto label_2;
        }
        
        .业世丟丐丘丐专与不 = val_8;
        if(val_8 == null)
        {
            goto label_3;
        }
        
        label_7:
        val_8 = this.<不丗与丆业丗下业且>k__BackingField;
        if((System.Linq.Enumerable.Any<ClanTankEquipInfo>(source:  val_8, predicate:  new System.Func<ClanTankEquipInfo, System.Boolean>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.世丞丈丈万上不丂丙::与东丈丒丘丙且七丑(ClanTankEquipInfo 三丟东丕丄丄下下丑)))) != true)
        {
                val_8 = this.<下世不上丏下丏丗七>k__BackingField;
            if((System.Linq.Enumerable.Any<SquareFieldCellData>(source:  val_8, predicate:  new System.Func<SquareFieldCellData, System.Boolean>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.世丞丈丈万上不丂丙::与上丛丘丆专丝七上(SquareFieldCellData 三丟东丕丄丄下下丑)))) == false)
        {
                return System.Linq.Enumerable.Any<FortFieldItemInfo>(source:  this.<丈丞三丒丑不丆丝业>k__BackingField, predicate:  new System.Func<FortFieldItemInfo, System.Boolean>(object:  val_1, method:  System.Boolean 丞丂丘丒丟丞丑下丄.世丞丈丈万上不丂丙::与万下丒丘东丂丕丆(FortFieldItemInfo 三丟东丕丄丄下下丑)));
        }
        
        }
        
        val_9 = 1;
        return (bool)val_9;
        label_2:
        mem[16] = val_8;
        val_8 = mem[16];
        if(val_8 != 0)
        {
            goto label_7;
        }
        
        label_3:
        val_9 = 0;
        return (bool)val_9;
    }
    internal static string 丂丒丏丞丝丞且丙丁(一一万丒与专丙丁丛 丅丅下丟丑专下与一)
    {
        if(丅丅下丟丑专下与一 <= 7)
        {
                var val_5 = 106019344 + (丅丅下丟丑专下与一) << 2;
            val_5 = val_5 + 106019344;
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "Couldn\'t get division name");
            return (string)System.String.alignConst;
        }
    
    }
    internal int 丐一丌丄业丌三丁世(string 丛上丅丑东丞丄不丁)
    {
        七丈丗不丞丈丝丙七 val_1 = this.丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  丛上丅丑东丞丄不丁);
        if(val_1 == null)
        {
                return (int)val_1;
        }
        
        return val_1.丛专丘业与丐东丐丂();
    }
    internal int 且丂丒东万丁上丁丏(string 丛上丅丑东丞丄不丁)
    {
        var val_4;
        if((PixelTime.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
        {
                val_4 = PixelTime.丝丗专上三不丄丑丑() - (this.丐一丌丄业丌三丁世(丛上丅丑东丞丄不丁:  丛上丅丑东丞丄不丁));
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }

}
