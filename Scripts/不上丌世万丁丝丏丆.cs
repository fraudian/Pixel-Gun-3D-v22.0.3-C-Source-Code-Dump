using UnityEngine;
internal class 不上丌世万丁丝丏丆 : IDisposable
{
    // Fields
    private DiscreteVector2 丆丗丂丑丙丛丟业丘;
    private ClanWarMap 万与下与丁丌丛七与;
    private UnityEngine.GameObject 业丌丛丛丞丆丕三丙;
    private static readonly int 丅专丟丆丑三与专丑;
    private PGCompany.ClanWarTile <丕丌上与万丞丌丝专>k__BackingField;
    private PGCompany.ClanWarCellHeader 丏丄丂一丆不丐丞丝;
    private static UnityEngine.GameObject 丟丂丟丁丈丒丐丙七;
    private ClanWarCellFlag 丝丄丛专丙丞一业上;
    private UnityEngine.GameObject 七丒万三丕上丙丗丕;
    
    // Properties
    internal DiscreteVector2 丅上丌丕世丝丒丙世 { get; }
    internal UnityEngine.Vector3 丐丈丅专丅一丟不万 { get; }
    internal ClanWarMap 一万丞丏丕丆丁丟上 { get; }
    internal PGCompany.丁下丒丕丆下丂丆丌 丗下丅万丈上上丝丝 { get; }
    internal PGCompany.丒且专三三丄丙丞丞 不丆丟与丙丏业丛丗 { get; }
    internal PGCompany.ClanWarMapCellConfig 一七且丗不丑丝且三 { get; }
    internal PGCompany.丝丂丒专丞与丙丏一 丟不丒专丈丌丘丈专 { get; }
    internal string 丈丟丏七丘丂丒丗世 { get; }
    internal int 丒丘丝丝世与丞与丒 { get; }
    internal bool 专丕丝七专丒丘丟与 { get; }
    internal bool 丝丈丄万丐丕丟东丄 { get; }
    internal PGCompany.世丐下丕专东丘丏且 万下世三丘丏丑上三 { get; }
    internal PGCompany.世丐下丕专东丘丏且 万丕丘丛丞丂丆七丌 { get; }
    internal int 丅七丐三与丌丞丝丝 { get; }
    internal float 丟丅丏丄丂丁丈七丙 { get; }
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 下丈丛与丄且丝万万 { get; }
    internal bool 与丆与丂丄丞丒丏丑 { get; }
    internal bool 丆丑三丛丑丐丏且丗 { get; }
    internal PGCompany.ClanWarTile 下业丂丒下丑三丕万 { get; set; }
    public 丛与三东七专下丗丗 丌业不丕丐下业丒丘 { get; }
    
    // Methods
    internal DiscreteVector2 丞丑丟下丘三下专不()
    {
        return new DiscreteVector2() {_x = this.丆丗丂丑丙丛丟业丘, _y = this.丆丗丂丑丙丛丟业丘};
    }
    internal UnityEngine.Vector3 丄丒丕万七丂万世一()
    {
        if((this.<丕丌上与万丞丌丝专>k__BackingField) == 0)
        {
                return UnityEngine.Vector3.zero;
        }
        
        UnityEngine.Transform val_2 = this.<丕丌上与万丞丌丝专>k__BackingField.transform;
        if(val_2 != null)
        {
                return val_2.position;
        }
        
        return val_2.position;
    }
    internal ClanWarMap 业丈与下丏三丟一且()
    {
        return (ClanWarMap)this.万与下与丁丌丛七与;
    }
    internal PGCompany.丁下丒丕丆下丂丆丌 丑丂丅丐业丘下东丘()
    {
        PGCompany.ClanWarController val_1 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_1 != null)
        {
                return val_1.三丈下丗丐丝丅丑丑(专丘丏丅且丆万东丈:  new DiscreteVector2() {_x = this.丆丗丂丑丙丛丟业丘, _y = this.丆丗丂丑丙丛丟业丘});
        }
        
        return val_1.三丈下丗丐丝丅丑丑(专丘丏丅且丆万东丈:  new DiscreteVector2() {_x = this.丆丗丂丑丙丛丟业丘, _y = this.丆丗丂丑丙丛丟业丘});
    }
    internal PGCompany.丒且专三三丄丙丞丞 业丑丁丆丕丆丂丅万()
    {
        PGCompany.丁下丒丕丆下丂丆丌 val_1 = this.丑丂丅丐业丘下东丘();
        if(val_1 == null)
        {
                return (PGCompany.丒且专三三丄丙丞丞)val_1;
        }
        
        return val_1.丏丞丌丁丄东丛下丑();
    }
    internal PGCompany.ClanWarMapCellConfig 世丈丁业丛上丘丗丐()
    {
        PGCompany.丁下丒丕丆下丂丆丌 val_1 = this.丑丂丅丐业丘下东丘();
        if(val_1 == null)
        {
                return (PGCompany.ClanWarMapCellConfig)val_1;
        }
        
        return val_1.世丈丁业丛上丘丗丐();
    }
    internal PGCompany.丝丂丒专丞与丙丏一 丗丐东丑丕丞丅丞东()
    {
        PGCompany.丝丂丒专丞与丙丏一 val_2;
        if(this.世丈丁业丛上丘丗丐() == null)
        {
                return val_2;
        }
        
        val_2 = val_1.Type;
        return val_2;
    }
    internal string 丙丗丏丂业且不东丞()
    {
        int val_3;
        PGCompany.丁下丒丕丆下丂丆丌 val_1 = this.丑丂丅丐业丘下东丘();
        if(val_1 != null)
        {
                if(val_1.下丁丙一丄丈不不丁() != null)
        {
                return (string)val_3;
        }
        
        }
        
        val_3 = System.String.alignConst;
        return (string)val_3;
    }
    internal int 丛丆东上上丗丗业丕()
    {
        PGCompany.ClanWarMapCellConfig val_1 = this.世丈丁业丛上丘丗丐();
        if(val_1 == null)
        {
                return 0;
        }
        
        return val_1.NumClan;
    }
    internal bool 丛七且专丗丒丟丞丈()
    {
        bool val_3 = System.String.IsNullOrEmpty(value:  this.丑丂丅丐业丘下东丘().下丁丙一丄丈不不丁());
        val_3 = (~val_3) & 1;
        return (bool)val_3;
    }
    internal bool 丂丝三不丅丙丄三丑()
    {
        PGCompany.丒且专三三丄丙丞丞 val_1 = this.业丑丁丆丕丆丂丅万();
        if(val_1 == null)
        {
                return (bool)val_1;
        }
        
        return System.String.op_Equality(a:  this.丑丂丅丐业丘下东丘().下丁丙一丄丈不不丁(), b:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛());
    }
    internal PGCompany.世丐下丕专东丘丏且 下三下东业丘且丟业()
    {
        PGCompany.丁下丒丕丆下丂丆丌 val_1 = this.丑丂丅丐业丘下东丘();
        if(val_1 == null)
        {
                return (PGCompany.世丐下丕专东丘丏且)val_1;
        }
        
        return val_1.下三下东业丘且丟业();
    }
    internal PGCompany.世丐下丕专东丘丏且 业丝丙下七下七下专()
    {
        if(this.下三下东业丘且丟业() == null)
        {
                return 0;
        }
        
        if(this.下三下东业丘且丟业().丈丐丞丐上丑且丕万() == false)
        {
                return 0;
        }
        
        return this.下三下东业丘且丟业();
    }
    internal int 丒丝丄丆东丘三上丝()
    {
        PGCompany.丁下丒丕丆下丂丆丌 val_1 = this.丑丂丅丐业丘下东丘();
        if(val_1 == null)
        {
                return (int)val_1;
        }
        
        PGCompany.丁下丒丕丆下丂丆丌 val_2 = this.丑丂丅丐业丘下东丘();
        if(val_2 != null)
        {
                return val_2.丒丝丄丆东丘三上丝();
        }
        
        return val_2.丒丝丄丆东丘三上丝();
    }
    internal float 下丕丘丟三丞丘上万()
    {
        if(this.丑丂丅丐业丘下东丘() == null)
        {
                return 0f;
        }
        
        PGCompany.丁下丒丕丆下丂丆丌 val_2 = this.丑丂丅丐业丘下东丘();
        if(val_2 != null)
        {
                return val_2.下丕丘丟三丞丘上万();
        }
        
        return val_2.下丕丘丟三丞丘上万();
    }
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丑丗丗一三上万丈丑()
    {
        if(this.丑丂丅丐业丘下东丘() != null)
        {
                return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_1.下丈丛与丄且丝万万;
        }
        
        return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_1.下丈丛与丄且丝万万;
    }
    internal bool 丆世丆东三专东东三()
    {
        return (bool)(this.万与下与丁丌丛七与.丆丆丘且丑丅丝丟丙() == this) ? 1 : 0;
    }
    internal bool 丝三丅专丙七丘丁丐()
    {
        return (bool)(this.万与下与丁丌丛七与.丅上丝万丐七丝专丑() == this) ? 1 : 0;
    }
    internal PGCompany.ClanWarTile 丑丕丞三三世丑丅丝()
    {
        return (PGCompany.ClanWarTile)this.<丕丌上与万丞丌丝专>k__BackingField;
    }
    private void 万丂万不下丙丈上丂(PGCompany.ClanWarTile 丙业与丙丗丝不丈东)
    {
        this.<丕丌上与万丞丌丝专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丈且东丑丂且万丒丅(ClanWarMap 三专丈丘一专丞不且, DiscreteVector2 丗丒且世丆专丄三专)
    {
        this.丆丗丂丑丙丛丟业丘 = 丗丒且世丆专丄三专;
        this.万与下与丁丌丛七与 = 三专丈丘一专丞不且;
    }
    internal void 业不不且丐且与不与()
    {
        var val_10;
        var val_41;
        PGCompany.ClanWarTile val_42;
        var val_43;
        var val_44;
        PGCompany.ClanWarCellHeader val_45;
        if(this.丑丂丅丐业丘下东丘() == null)
        {
            goto label_1;
        }
        
        if(((this.世丈丁业丛上丘丗丐() == null) || (val_2.Type != 2)) || (this.世丈丁业丛上丘丗丐().NumClan > 0))
        {
            goto label_24;
        }
        
        List.Enumerator<T> val_8 = 丝丙一上业丁且丄不.业丗丕丌丏丁丗丁万(下业丕七东丌丝下且:  new DiscreteVector2() {_x = this.丆丗丂丑丙丛丟业丘, _y = this.丆丗丂丑丙丛丟业丘}, 且丛上丕业丂丒与一:  1).GetEnumerator();
        label_11:
        if((2116450048 & 1) == 0)
        {
            goto label_8;
        }
        
        new 不上丌世万丁丝丏丆.丕丘丅三丛丘专世一() = new System.Object();
        .丗丒且世丆专丄三专 = val_10.丐丏七丌丕丗业且上();
        System.Func<PGCompany.ClanWarMapCellConfig, System.Boolean> val_13 = new System.Func<PGCompany.ClanWarMapCellConfig, System.Boolean>(object:  new 不上丌世万丁丝丏丆.丕丘丅三丛丘专世一(), method:  System.Boolean 不上丌世万丁丝丏丆.丕丘丅三丛丘专世一::丑不丁丝下上丝世丐(PGCompany.ClanWarMapCellConfig 丁丂专业丁丅丅丈丙));
        PGCompany.ClanWarMapCellConfig val_14 = System.Linq.Enumerable.FirstOrDefault<PGCompany.ClanWarMapCellConfig>(source:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.万不与丐丐丝丒下业(), predicate:  null);
        if((val_14 == null) || (val_14.NumClan < 1))
        {
            goto label_11;
        }
        
        int val_16 = val_14.NumClan;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        goto label_24;
        label_1:
        UnityEngine.Debug.LogError(message:  "cellInstance is null");
        return;
        label_24:
        val_41 = 0;
        if((this.<丕丌上与万丞丌丝专>k__BackingField) == 0)
        {
                val_42 = 1152921505157271552;
            val_43 = null;
            val_43 = null;
            if(不上丌世万丁丝丏丆.丟丂丟丁丈丒丐丙七 == 0)
        {
                return;
        }
        
            val_44 = null;
            val_44 = null;
            UnityEngine.GameObject val_19 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  不上丌世万丁丝丏丆.丟丂丟丁丈丒丐丙七);
            if(val_19 == 0)
        {
                return;
        }
        
            val_42 = val_19.GetComponent<PGCompany.ClanWarTile>();
            this.<丕丌上与万丞丌丝专>k__BackingField = val_42;
            val_41 = 0;
            if(val_42 == 0)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_19);
            return;
        }
        
        }
        
        this.<丕丌上与万丞丌丝专>k__BackingField.Setup(业丒丝丗与丐丛丟丏:  new DiscreteVector2() {_x = this.丆丗丂丑丙丛丟业丘, _y = this.丆丗丂丑丙丛丟业丘}, 上丘万且丁丏下丂与:  0f);
        val_42 = this.万与下与丁丌丛七与.丙丆丅丐丝丄与七丒();
        val_42.丄丞丗丁丏丐丟专丐(丝丝丕丐丘业三丅丕:  this.<丕丌上与万丞丌丝专>k__BackingField);
        this.<丕丌上与万丞丌丝专>k__BackingField.一且丝丟丂丗丌丆丗(丞丈丌且东丆丅丗万:  false);
        this.<丕丌上与万丞丌丝专>k__BackingField.gameObject.GetComponent<TweenScale>().enabled = false;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.one;
        this.<丕丌上与万丞丌丝专>k__BackingField.transform.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
        if(this.丆世丆东三专东东三() != false)
        {
                if(this.业丌丛丛丞丆丕三丙 == 0)
        {
                this.<丕丌上与万丞丌丝专>k__BackingField.一且丝丟丂丗丌丆丗(丞丈丌且东丆丅丗万:  true);
        }
        
        }
        
        if(this.与丑丗丒世三一东丅() == false)
        {
            goto label_66;
        }
        
        val_42 = 1152921505158602752;
        if(ClanWarUI.丑七不且上丗丁一世() == 0)
        {
            goto label_66;
        }
        
        if(this.丏丄丂一丆不丐丞丝 != 0)
        {
            goto label_69;
        }
        
        val_42 = ClanWarUI.丑七不且上丗丁一世();
        val_45 = val_42.丞且丞丄丗专业丘丁<PGCompany.ClanWarCellHeader>(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans\\War\\Prefabs\\cw-field-cell-header"));
        this.丏丄丂一丆不丐丞丝 = val_45;
        goto label_73;
        label_66:
        if(this.丏丄丂一丆不丐丞丝 == 0)
        {
            goto label_83;
        }
        
        val_42 = ClanWarUI.丑七不且上丗丁一世();
        val_42.丁丛不与七东下一丛<PGCompany.ClanWarCellHeader>(下丛丘专丌丟且与丒:  this.丏丄丂一丆不丐丞丝);
        this.丏丄丂一丆不丐丞丝 = 0;
        goto label_83;
        label_69:
        val_45 = this.丏丄丂一丆不丐丞丝;
        label_73:
        if(val_45 != 0)
        {
                this.丏丄丂一丆不丐丞丝.Setup(与且专丈不万东一万:  this);
        }
        
        label_83:
        this.丂丂专丝丐丈业丝丆();
        this.丝丐东丕不丁三丐丙();
        this.三丘世丕东丟丛丄丗();
    }
    private bool 与丑丗丒世三一东丅()
    {
        var val_14;
        var val_15;
        val_14 = this;
        if(this.世丈丁业丛上丘丗丐() == null)
        {
                return (bool)val_15;
        }
        
        if(val_1.Type == 3)
        {
            goto label_2;
        }
        
        if(val_1.Type == 2)
        {
            goto label_3;
        }
        
        if(val_1.Type != 1)
        {
            goto label_11;
        }
        
        if(this.业丝丙下七下七下专() == null)
        {
                return (bool)val_15;
        }
        
        val_14 = this.业丝丙下七下七下专();
        var val_5 = (val_14.且丆丟业丞丕丑上且() > 0) ? 1 : 0;
        return (bool)val_15;
        label_2:
        val_14 = this.丛丆东上上丗丗业丕();
        int val_7 = PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂();
        goto label_10;
        label_3:
        if(this.丛七且专丗丒丟丞丈() == false)
        {
            goto label_11;
        }
        
        if(this.丂丕丘丌专丗丞丘丘() == null)
        {
                return (bool)val_15;
        }
        
        label_10:
        var val_13 = (this.丂丕丘丌专丗丞丘丘().丂丘业丐丕三上七且().Item[0] == val_14) ? 1 : 0;
        return (bool)val_15;
        label_11:
        val_15 = 0;
        return (bool)val_15;
    }
    internal static UnityEngine.Material 专丙与七与三丝丏丈(string 丈丂丙丟且丅与万且)
    {
        return UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Clans\\War\\Materials\\" + 丈丂丙丟且丅与万且);
    }
    private UnityEngine.Texture 不丌下丐丂丗丌丑丈(string 下丕不世丕丄丐丑万)
    {
        return UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "Clans\\War\\Materials\\" + 下丕不世丕丄丐丑万);
    }
    private void 万丁业万丈丆且丆丟()
    {
        if(this.业丌丛丛丞丆丕三丙 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.业丌丛丛丞丆丕三丙);
        this.业丌丛丛丞丆丕三丙 = 0;
    }
    public void Dispose()
    {
        var val_7;
        this.丅且上丕丕丅丙三丈();
        this.万丁业万丈丆且丆丟();
        if(this.万与下与丁丌丛七与 != 0)
        {
                if(this.万与下与丁丌丛七与.丙丆丅丐丝丄与七丒() != 0)
        {
                val_7 = this.万与下与丁丌丛七与.丙丆丅丐丝丄与七丒();
            val_7.丛丑且丁丁丆一丏不(业丒丝丗与丐丛丟丏:  new DiscreteVector2() {_x = this.丆丗丂丑丙丛丟业丘, _y = this.丆丗丂丑丙丛丟业丘});
            this.<丕丌上与万丞丌丝专>k__BackingField = 0;
        }
        
        }
        
        if(this.丏丄丂一丆不丐丞丝 == 0)
        {
                return;
        }
        
        val_7 = ClanWarUI.丑七不且上丗丁一世();
        val_7.丁丛不与七东下一丛<PGCompany.ClanWarCellHeader>(下丛丘专丌丟且与丒:  this.丏丄丂一丆不丐丞丝);
        this.丏丄丂一丆不丐丞丝 = 0;
    }
    public 丛与三东七专下丗丗 丂丕丘丌专丗丞丘丘()
    {
        var val_8;
        PGCompany.丝丂丒专丞与丙丏一 val_9;
        var val_10;
        val_8 = this;
        if(this.世丈丁业丛上丘丗丐() != null)
        {
                val_9 = val_1.Type;
        }
        else
        {
                val_9 = 0;
        }
        
        string val_3 = val_9 + "-"("-") + this.丛丆东上上丗丗业丕();
        if((this.万与下与丁丌丛七与.不丆丁与丐丝丐丆丞().ContainsKey(key:  val_3)) != false)
        {
                val_8 = this.万与下与丁丌丛七与.不丆丁与丐丝丐丆丞();
            丛与三东七专下丗丗 val_7 = val_8.Item[val_3];
            return (丛与三东七专下丗丗)val_10;
        }
        
        val_10 = 0;
        return (丛与三东七专下丗丗)val_10;
    }
    public void 丝丐东丕不丁三丐丙()
    {
        if(this.丂丕丘丌专丗丞丘丘() == null)
        {
                return;
        }
        
        List.Enumerator<T> val_4 = this.丂丕丘丌专丗丞丘丘().丂丘业丐丕三上七且().GetEnumerator();
        label_7:
        if((2117664328 & 1) == 0)
        {
            goto label_4;
        }
        
        0.丐丏七丌丕丗业且上().七丗且丄业丄不丙丟(丛丗七丅下丞丗且丐:  this.丂丕丘丌专丗丞丘丘().丆世丆东三专东东三());
        goto label_7;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void 七丗且丄业丄不丙丟(bool 丛丗七丅下丞丗且丐)
    {
        var val_4;
        var val_5;
        if(丛丗七丅下丞丗且丐 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.业丌丛丛丞丆丕三丙, 丏业丟一东丂东丘丛:  false);
            if((UnityEngine.Object.op_Implicit(exists:  this.<丕丌上与万丞丌丝专>k__BackingField)) != false)
        {
                this.<丕丌上与万丞丌丝专>k__BackingField.一且丝丟丂丗丌丆丗(丞丈丌且东丆丅丗万:  false);
        }
        
            val_4 = this.丂丕丘丌专丗丞丘丘();
            val_5 = 1;
        }
        else
        {
                val_4 = this.丂丕丘丌专丗丞丘丘();
            val_5 = 0;
        }
        
        val_4.丅一丁上上世丄三丏(丝三丄专丗丞丄丄丌:  false);
    }
    public override string ToString()
    {
        PGCompany.丝丂丒专丞与丙丏一 val_5;
        object[] val_1 = new object[6];
        val_1[0] = " ";
        val_1[1] = this.丆丗丂丑丙丛丟业丘;
        val_1[2] = " num: ";
        val_1[3] = this.丛丆东上上丗丗业丕();
        val_1[4] = " type: ";
        if(this.世丈丁业丛上丘丗丐() != null)
        {
                val_5 = val_3.Type;
        }
        else
        {
                val_5 = 0;
        }
        
        val_1[5] = val_5;
        return (string)+val_1;
    }
    public void 三丘世丕东丟丛丄丗()
    {
        if(this.丑丂丅丐业丘下东丘() == null)
        {
                return;
        }
        
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐丘丅丑一丄专丞上(丝丌不东丕丒与丒丅:  this.丑丂丅丐业丘下东丘().业上丙丞丐丄丆丅七())) == false)
        {
            goto label_4;
        }
        
        if(this.丂丝三不丅丙丄三丑() == false)
        {
            goto label_5;
        }
        
        Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丕丁丁丟丒业丄七一(丝丌不东丕丒与丒丅:  this.丑丂丅丐业丘下东丘().业上丙丞丐丄丆丅七());
        return;
        label_4:
        this.丅且上丕丕丅丙三丈();
        return;
        label_5:
        this.专丛丆东专丝丕丗业();
    }
    private void 专丛丆东专丝丕丗业()
    {
        if(this.丝丄丛专丙丞一业上 == 0)
        {
                ClanWarCellFlag val_2 = this.万与下与丁丌丛七与.cellFlagsPool.Get<ClanWarCellFlag>();
            this.丝丄丛专丙丞一业上 = val_2;
            if(val_2 != 0)
        {
                this.丝丄丛专丙丞一业上.丈且东丑丂且万丒丅(丌丝万上丅丒一丈丘:  this);
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝丄丛专丙丞一业上, 丏业丟一东丂东丘丛:  true);
    }
    private void 丅且上丕丕丅丙三丈()
    {
        this.万与下与丁丌丛七与.cellFlagsPool.Return(万且万且丑丗且丌丆:  this.丝丄丛专丙丞一业上);
        this.丝丄丛专丙丞一业上 = 0;
    }
    private void 丂丂专丝丐丈业丝丆()
    {
        if(this.下三下东业丘且丟业() == null)
        {
                return;
        }
        
        PGCompany.GameTaskActionSettings val_4 = this.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_4.Type != 52)
        {
                return;
        }
        
        if(this.七丒万三丕上丙丗丕 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans/War/Prefabs/cw-cell-task-captureSilverMine"), parent:  this.万与下与丁丌丛七与.transform);
        this.七丒万三丕上丙丗丕 = val_8;
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_8.transform);
        UnityEngine.Vector3 val_11 = this.丄丒丕万七丂万世一();
        this.七丒万三丕上丙丗丕.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    public 不上丌世万丁丝丏丆()
    {
    
    }
    private static 不上丌世万丁丝丏丆()
    {
        不上丌世万丁丝丏丆.丅专丟丆丑三与专丑 = UnityEngine.Shader.PropertyToID(name:  "_Color");
        不上丌世万丁丝丏丆.丟丂丟丁丈丒丐丙七 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans\\War\\Prefabs\\cw-tile-hex-faced");
    }

}
