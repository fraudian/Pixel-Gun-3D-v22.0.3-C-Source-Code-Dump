using UnityEngine;
public class 与丅丕丈丘东丝世丟 : IComparable<与丅丕丈丘东丝世丟>, IComparable<int>, IEquatable<与丅丕丈丘东丝世丟>, IEquatable<int>
{
    // Fields
    private int 七上丕丕丗丙丛丂丕;
    private string 丗业业不上丁丂且丈;
    private string <业丞丄丂丄下丞三世>k__BackingField;
    public readonly bool 不丐七丌下丗丈丒丅;
    private bool <丟万三万丆不业上丈>k__BackingField;
    private ExitGames.Client.Photon.Hashtable <丏业丂万上丕丛丘丞>k__BackingField;
    public object 专丗且丐丛且丕丝丕;
    
    // Properties
    public int 丁业世丅丌丛上下与 { get; }
    public string 不与丏上丐七丄专且 { get; set; }
    public string 丒丁丙丞丆丟丑业丈 { get; set; }
    public bool 丞丘上丁丞丛丐丈丆 { get; }
    public bool 丞丞丈丌且业丘丑三 { get; set; }
    public ExitGames.Client.Photon.Hashtable 丌丆三上丏丁丞丌丙 { get; set; }
    public ExitGames.Client.Photon.Hashtable 丘不丅丟丟专七丂丁 { get; }
    public string 丒丘丏上丙丟丑丕丈 { get; set; }
    public string 万丄丅丝三丈丆世丟 { get; set; }
    public bool 丒丘三丁丄丘丅丂三 { get; }
    public bool 与三一丁与丈丙丒丛 { get; }
    public bool 一丞丗丘专业丘丁丝 { get; set; }
    public ExitGames.Client.Photon.Hashtable 三与丞不七业丗丟丙 { get; set; }
    public ExitGames.Client.Photon.Hashtable 丘丕丐不与丑丅丝一 { get; }
    
    // Methods
    public int 业丐丐三丕一丗丛丁()
    {
        return (int)this.七上丕丕丗丙丛丂丕;
    }
    public string 丁下不丛下且丌专丈()
    {
        return (string)this.丗业业不上丁丂且丈;
    }
    public void 丆丅丛丁丗丄丒丄丅(string 丙业与丙丗丝不丈东)
    {
        if(this.不丐七丌下丗丈丒丅 == false)
        {
            goto label_1;
        }
        
        if((System.String.IsNullOrEmpty(value:  丙业与丙丗丝不丈东)) == true)
        {
                return;
        }
        
        if((丙业与丙丗丝不丈东.Equals(value:  this.丗业业不上丁丂且丈)) == false)
        {
            goto label_4;
        }
        
        return;
        label_1:
        UnityEngine.Debug.LogError(message:  "Error: Cannot change the name of a remote player!");
        return;
        label_4:
        this.丗业业不上丁丂且丈 = 丙业与丙丗丝不丈东;
        丅丒丗丑丒丙丛不丆.丅丗业与万且不丐丈(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string 丞丈业东专丅丆与七()
    {
        return (string)this.<业丞丄丂丄下丞三世>k__BackingField;
    }
    internal void 下丂丏丝上丏与丁丆(string 丙业与丙丗丝不丈东)
    {
        this.<业丞丄丂丄下丞三世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool 丕丁丁丂丟下丞丕丙()
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        return (bool)((static_value_081D9CF0 + 184 + 16.丘下下不丈丈丙丝七()) == this.七上丕丕丗丙丛丂丕) ? 1 : 0;
    }
    public bool 丘丅丞丆七下三丘丄()
    {
        return (bool)this.<丟万三万丆不业上丈>k__BackingField;
    }
    public void 七丒丁丏丏与丌丐世(bool 丙业与丙丗丝不丈东)
    {
        this.<丟万三万丆不业上丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public ExitGames.Client.Photon.Hashtable 丑丗三丛丛丆丟丌丆()
    {
        return (ExitGames.Client.Photon.Hashtable)this.<丏业丂万上丕丛丘丞>k__BackingField;
    }
    internal void 上丙丄三丈万丌世丐(ExitGames.Client.Photon.Hashtable 丙业与丙丗丝不丈东)
    {
        this.<丏业丂万上丕丛丘丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public ExitGames.Client.Photon.Hashtable 丑丑丛业丝世万丗丐()
    {
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        万上丈专丐专丞丛丛.丝丅丌丁丒丟三丏上(丞下万上三丘上与专:  val_1, 丆丟丏丗下丘丌丛一:  this.<丏业丂万上丕丛丘丞>k__BackingField);
        val_1.set_Item(key:  255, value:  this.丗业业不上丁丂且丈);
        return val_1;
    }
    public 与丅丕丈丘东丝世丟(bool 丒丘三丁丄丘丅丂三, int 七上丕丕丗丙丛丂丕, string 丒丘丏上丙丟丑丕丈)
    {
        this.七上丕丕丗丙丛丂丕 = 0;
        this.丗业业不上丁丂且丈 = "";
        val_1 = new System.Object();
        this.<丏业丂万上丕丛丘丞>k__BackingField = new ExitGames.Client.Photon.Hashtable();
        this.七上丕丕丗丙丛丂丕 = 七上丕丕丗丙丛丂丕;
        this.不丐七丌下丗丈丒丅 = 丒丘三丁丄丘丅丂三;
        this.丗业业不上丁丂且丈 = val_1;
    }
    protected internal 与丅丕丈丘东丝世丟(bool 丒丘三丁丄丘丅丂三, int 七上丕丕丗丙丛丂丕, ExitGames.Client.Photon.Hashtable 丙丑丆上不丒上丕丛)
    {
        this.七上丕丕丗丙丛丂丕 = 0;
        this.丗业业不上丁丂且丈 = "";
        val_1 = new System.Object();
        this.<丏业丂万上丕丛丘丞>k__BackingField = new ExitGames.Client.Photon.Hashtable();
        this.不丐七丌下丗丈丒丅 = 丒丘三丁丄丘丅丂三;
        this.七上丕丕丗丙丛丂丕 = 七上丕丕丗丙丛丂丕;
        this.丘丐丕丒丏三丆丒丏(丙丑丆上不丒上丕丛:  ExitGames.Client.Photon.Hashtable val_1 = 丙丑丆上不丒上丕丛);
    }
    public override bool Equals(object 七丏丄丅丌业与且丙)
    {
        if(七丏丄丅丌业与且丙 == null)
        {
                return false;
        }
        
        var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (与丅丕丈丘东丝世丟.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 七丏丄丅丌业与且丙 : 0;
        return false;
    }
    public override int GetHashCode()
    {
        return (int)this.七上丕丕丗丙丛丂丕;
    }
    internal void 丌丆丄丑上一丘丞丐(int 七丘丏与万丂与丂专)
    {
        if(this.不丐七丌下丗丈丒丅 != false)
        {
                this.七上丕丕丗丙丛丂丕 = 七丘丏与万丂与丂专;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "ERROR You should never change PhotonPlayer IDs!");
    }
    internal void 丘丐丕丒丏三丆丒丏(ExitGames.Client.Photon.Hashtable 丙丑丆上不丒上丕丛)
    {
        ExitGames.Client.Photon.Hashtable val_9;
        string val_10;
        string val_11;
        if(丙丑丆上不丒上丕丛 == null)
        {
                return;
        }
        
        if(丙丑丆上不丒上丕丛.Count == 0)
        {
                return;
        }
        
        val_9 = this.<丏业丂万上丕丛丘丞>k__BackingField;
        if((val_9.Equals(obj:  丙丑丆上不丒上丕丛)) == true)
        {
                return;
        }
        
        if((丙丑丆上不丒上丕丛.ContainsKey(key:  255)) != false)
        {
                if((丙丑丆上不丒上丕丛.Item[255] != null) && (null != null))
        {
                val_10 = 0;
        }
        
            this.丗业业不上丁丂且丈 = val_10;
        }
        
        if((丙丑丆上不丒上丕丛.ContainsKey(key:  253)) != false)
        {
                if((丙丑丆上不丒上丕丛.Item[253] != null) && (null != null))
        {
                val_11 = 0;
        }
        
            this.<业丞丄丂丄下丞三世>k__BackingField = val_11;
        }
        
        if((丙丑丆上不丒上丕丛.ContainsKey(key:  254)) != false)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙丑丆上不丒上丕丛.Item[254]);
            this.<丟万三万丆不业上丈>k__BackingField = null;
        }
        
        val_9 = this.<丏业丂万上丕丛丘丞>k__BackingField;
        万上丈专丐专丞丛丛.丗不三三丁丕七且上(丞下万上三丘上与专:  val_9, 丆丟丏丗下丘丌丛一:  丙丑丆上不丒上丕丛);
        万上丈专丐专丞丛丛.东三丝丑七丘丝丌万(专丑业丁丗丏丌不丛:  this.<丏业丂万上丕丛丘丞>k__BackingField);
    }
    public void 丑丆专东一不丙丗丘(ExitGames.Client.Photon.Hashtable 下丌丂丗丒下与丞丈, ExitGames.Client.Photon.Hashtable 丒不一专上专丌丈东, bool 丅丞丏丈且专丆不丟 = False)
    {
        ExitGames.Client.Photon.Hashtable val_10;
        System.Collections.IDictionary val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = 下丌丂丗丒下与丞丈;
        if(val_11 == null)
        {
                return;
        }
        
        val_10 = 1152921505104715776;
        val_11 = 万上丈专丐专丞丛丛.万丈丏丁上下丁丕业(专丑业丁丗丏丌不丛:  val_11);
        ExitGames.Client.Photon.Hashtable val_2 = 万上丈专丐专丞丛丛.万丈丏丁上下丁丕业(专丑业丁丗丏丌不丛:  丒不一专上专丌丈东);
        if(val_2 != null)
        {
                var val_4 = (val_2.Count == 0) ? 1 : 0;
        }
        else
        {
                val_12 = 1;
        }
        
        if(this.七上丕丕丗丙丛丂丕 < 1)
        {
            goto label_6;
        }
        
        val_13 = (~丅丒丗丑丒丙丛不丆.丒丌且丞丙下三丙下()) & 1;
        if(val_12 != 0)
        {
            goto label_9;
        }
        
        label_15:
        if(val_13 == 0)
        {
            goto label_10;
        }
        
        label_18:
        val_14 = static_value_081D9CF0;
        val_14 = static_value_081D9CF0;
        val_10 = mem[static_value_081D9CF0 + 184 + 16];
        val_10 = static_value_081D9CF0 + 184 + 16;
        bool val_7 = val_10.丁一三七丐三三丌丞(丙丈三丁世丄丝东世:  this.七上丕丕丗丙丛丂丕, 世丞丒丒丏丆丁丛业:  val_11, 丄七丝丐丟丘业丈丅:  val_2, 丅丞丏丈且专丆不丟:  丅丞丏丈且专丆不丟);
        val_15 = 0;
        goto label_14;
        label_6:
        val_13 = 0;
        if(val_12 == 0)
        {
            goto label_15;
        }
        
        label_9:
        val_10 = this.<丏业丂万上丕丛丘丞>k__BackingField;
        万上丈专丐专丞丛丛.丝丅丌丁丒丟三丏上(丞下万上三丘上与专:  val_10, 丆丟丏丗下丘丌丛一:  val_11);
        万上丈专丐专丞丛丛.东三丝丑七丘丝丌万(专丑业丁丗丏丌不丛:  this.<丏业丂万上丕丛丘丞>k__BackingField);
        if(val_13 != 0)
        {
            goto label_18;
        }
        
        label_10:
        val_15 = 1;
        label_14:
        val_15 = val_15 | val_12;
        if(val_15 == 0)
        {
                return;
        }
        
        this.丘丐丕丒丏三丆丒丏(丙丑丆上不丒上丕丛:  val_11);
        object[] val_8 = new object[2];
        val_8[0] = this;
        val_8[1] = val_11;
        丈一丟丝丕下东专一.丝且丞丆丅丕丛一丘(东专下专丐专上丂上:  21, 丗丟上上丒丐丗丞丙:  val_8);
    }
    public static 与丅丕丈丘东丝世丟 丕丒与丘丏下丁业丕(int 丁业世丅丌丛上下与)
    {
        var val_1;
        var val_2;
        val_1 = static_value_081D9CF0;
        val_1 = static_value_081D9CF0;
        val_2 = mem[static_value_081D9CF0 + 184 + 16];
        val_2 = static_value_081D9CF0 + 184 + 16;
        val_2 = mem[static_value_081D9CF0 + 184 + 16];
        val_2 = static_value_081D9CF0 + 184 + 16;
        val_2 = 0;
        return val_2.丙丘一且丈丟丝上业(丑丅世丐丒丏丐三丅:  丁业世丅丌丛上下与);
    }
    public 与丅丕丈丘东丝世丟 丐下下丅与上东丙丑(int 丞丅上丏丂且下丅与)
    {
        return 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  丞丅上丏丂且下丅与);
    }
    public 与丅丕丈丘东丝世丟 丙丛丌上丑丗丌业丌()
    {
        return this.丏丙不丗丐丆丝丌丗(丄丙一丝丛丌丕丘丐:  this.七上丕丕丗丙丛丂丕);
    }
    public 与丅丕丈丘东丝世丟 丏丙不丗丐丆丝丌丗(与丅丕丈丘东丝世丟 丄丁丟丟上丘与万不)
    {
        if(丄丁丟丟上丘与万不 == null)
        {
                return 0;
        }
        
        return this.丏丙不丗丐丆丝丌丗(丄丙一丝丛丌丕丘丐:  丄丁丟丟上丘与万不.七上丕丕丗丙丛丂丕);
    }
    public 与丅丕丈丘东丝世丟 丏丙不丗丐丆丝丌丗(int 丄丙一丝丛丌丕丘丐)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_8 = 1152921505107111936;
        val_9 = static_value_081D9CF0;
        val_9 = static_value_081D9CF0;
        val_10 = mem[static_value_081D9CF0 + 184 + 16];
        val_10 = static_value_081D9CF0 + 184 + 16;
        val_10 = mem[static_value_081D9CF0 + 184 + 16];
        val_10 = static_value_081D9CF0 + 184 + 16;
        val_11 = static_value_081D9CF0;
        val_11 = static_value_081D9CF0;
        if((static_value_081D9CF0 + 184 + 16 + 424.Count) < 2)
        {
                return 0;
        }
        
        val_12 = static_value_081D9CF0;
        val_12 = static_value_081D9CF0;
        val_7 = mem[static_value_081D9CF0 + 184 + 16 + 424];
        val_7 = static_value_081D9CF0 + 184 + 16 + 424;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = val_7.Keys.GetEnumerator();
        val_8 = 2147483647;
        val_13 = 丄丙一丝丛丌丕丘丐;
        goto label_20;
        label_21:
        int val_4 = 0.丙东专丂世丈丏丁丂();
        if(val_4 >= val_13)
        {
                var val_5 = (val_4 > val_8) ? (val_4) : (val_8);
        }
        else
        {
                val_13 = val_4;
        }
        
        label_20:
        if((899767592 & 1) != 0)
        {
            goto label_21;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_8 == 2147483647)
        {
                val_14 = W22;
        }
        else
        {
                val_14 = val_8;
        }
        
        与丅丕丈丘东丝世丟 val_6 = Item[1152921505107111936];
        return 0;
    }
    public int CompareTo(与丅丕丈丘东丝世丟 丘丛丏丘丝七世七丅)
    {
        var val_1;
        if(丘丛丏丘丝七世七丅 != null)
        {
                return (int)val_1;
        }
        
        val_1 = 0;
        return (int)val_1;
    }
    public int CompareTo(int 丘丛丏丘丝七世七丅)
    {
        return 900008044;
    }
    public bool Equals(与丅丕丈丘东丝世丟 丘丛丏丘丝七世七丅)
    {
        var val_2;
        if(丘丛丏丘丝七世七丅 != null)
        {
                bool val_1 = this.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 丘丛丏丘丝七世七丅});
        }
        else
        {
                val_2 = 0;
        }
        
        val_2 = val_2 & 1;
        return (bool)val_2;
    }
    public bool Equals(int 丘丛丏丘丝七世七丅)
    {
        return (bool)this.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 丘丛丏丘丝七世七丅});
    }
    public override string ToString()
    {
        if((System.String.IsNullOrEmpty(value:  this.丗业业不上丁丂且丈)) == false)
        {
                return System.String.Format(format:  "\'{0}\'{1}{2}", arg0:  this.丗业业不上丁丂且丈, arg1:  ((this.<丟万三万丆不业上丈>k__BackingField) == true) ? " (inactive)" : " ", arg2:  (this.丕丁丁丂丟下丞丕丙() != true) ? "(master)" : "");
        }
        
        return (string)System.String.Format(format:  "#{0:00}{1}{2}", arg0:  this.七上丕丕丗丙丛丂丕, arg1:  ((this.<丟万三万丆不业上丈>k__BackingField) == true) ? " (inactive)" : " ", arg2:  (this.丕丁丁丂丟下丞丕丙() != true) ? "(master)" : "");
    }
    public string 丛丈丆与专丕丏丐丄()
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.七上丕丕丗丙丛丂丕 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.七上丕丕丗丙丛丂丕 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.七上丕丕丗丙丛丂丕;
        val_1[1] = this.丗业业不上丁丂且丈;
        val_1[2] = ((this.<丟万三万丆不业上丈>k__BackingField) == true) ? " (inactive)" : "";
        val_1[3] = 万上丈专丐专丞丛丛.丛丈丆与专丕丏丐丄(丈丆上丅丘世专丑丕:  this.<丏业丂万上丕丛丘丞>k__BackingField);
        return (string)System.String.Format(format:  "#{0:00} \'{1}\'{2} {3}", args:  val_1);
    }
    public string 丙丆丌丝丛丏丝丕业()
    {
        return (string)this.丗业业不上丁丂且丈;
    }
    public void 七丕丙丟下与丂世丏(string 丙业与丙丗丝不丈东)
    {
        this.丆丅丛丁丗丄丒丄丅(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string 不上丗丞丟丗业丙丆()
    {
        return (string)this.<业丞丄丂丄下丞三世>k__BackingField;
    }
    internal void 下丂丁丞丐丘丒丘丟(string 丙业与丙丗丝不丈东)
    {
        this.<业丞丄丂丄下丞三世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool 丆丈且丞丟丗丘上丁()
    {
        return (bool)this.不丐七丌下丗丈丒丅;
    }
    public bool 丘丌丄丗专世专万东()
    {
        return this.丕丁丁丂丟下丞丕丙();
    }
    public bool 万丏一丙一丑丕不丐()
    {
        return (bool)this.<丟万三万丆不业上丈>k__BackingField;
    }
    public void 世丒丐上三丈丌世丐(bool 丙业与丙丗丝不丈东)
    {
        this.<丟万三万丆不业上丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public ExitGames.Client.Photon.Hashtable 丂丂丁丕专丂丏与丌()
    {
        return (ExitGames.Client.Photon.Hashtable)this.<丏业丂万上丕丛丘丞>k__BackingField;
    }
    internal void 且丆专七上专丝丝丌(ExitGames.Client.Photon.Hashtable 丙业与丙丗丝不丈东)
    {
        this.<丏业丂万上丕丛丘丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public ExitGames.Client.Photon.Hashtable 丗丏丗丐丆丐丛丅丘()
    {
        return this.丑丑丛业丝世万丗丐();
    }

}
