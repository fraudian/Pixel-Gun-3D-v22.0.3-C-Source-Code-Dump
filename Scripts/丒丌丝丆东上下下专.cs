using UnityEngine;
internal class 丂与业丕丐专东东上.丒丌丝丆东上下下专 : IEquatable<Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专>, IComparable<Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专>
{
    // Fields
    internal readonly string UniqueId;
    private int <一万丂丟不丛丟下世>k__BackingField;
    private int <七专万丆上丝三丏丏>k__BackingField;
    private int <丅丝专一下丑丙一与>k__BackingField;
    private PGCompany.三东丏不丗世丅丌丄 <丑七不丛一丁世丏业>k__BackingField;
    private string <三丆专丟七东丆专世>k__BackingField;
    private int <丑上丙丈丒上丟丙丒>k__BackingField;
    
    // Properties
    internal int ItemIndex { get; set; }
    internal int FromLevel { get; set; }
    internal int ToLevel { get; set; }
    internal PGCompany.三东丏不丗世丅丌丄 Price { get; set; }
    internal string ClanId { get; set; }
    internal int Seconds { get; set; }
    
    // Methods
    internal int 丝一丙丘专七丕不上()
    {
        return (int)this.<一万丂丟不丛丟下世>k__BackingField;
    }
    internal void 丂丙丗丗三与丌丙世(int 丙业与丙丗丝不丈东)
    {
        this.<一万丂丟不丛丟下世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丝一且不与丁不丐丏()
    {
        return (int)this.<七专万丆上丝三丏丏>k__BackingField;
    }
    internal void 丐丌丏不丏丅下丞下(int 丙业与丙丗丝不丈东)
    {
        this.<七专万丆上丝三丏丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 不丘东业三上丒世丝()
    {
        return (int)this.<丅丝专一下丑丙一与>k__BackingField;
    }
    internal void 丟丙丄丁丌七七丞丆(int 丙业与丙丗丝不丈东)
    {
        this.<丅丝专一下丑丙一与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.三东丏不丗世丅丌丄 丟丂丞不专丆万丒世()
    {
        return (PGCompany.三东丏不丗世丅丌丄)this.<丑七不丛一丁世丏业>k__BackingField;
    }
    internal void 三专丞丝与丐万丆七(PGCompany.三东丏不丗世丅丌丄 丙业与丙丗丝不丈东)
    {
        this.<丑七不丛一丁世丏业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丁丏业丄丏丞丟万且()
    {
        return (string)this.<三丆专丟七东丆专世>k__BackingField;
    }
    internal void 丙丘下三丆丘下丐丙(string 丙业与丙丗丝不丈东)
    {
        this.<三丆专丟七东丆专世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丙丑丁专一专世万丕()
    {
        return (int)this.<丑上丙丈丒上丟丙丒>k__BackingField;
    }
    internal void 丅丁业不且上业丘且(int 丙业与丙丗丝不丈东)
    {
        this.<丑上丙丈丒上丟丙丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 丂与业丕丐专东东上.丒丌丝丆东上下下专()
    {
        this.UniqueId = PGCompany.丏丘专丂丙世丘丂世.三丄丅丄丌丈丈丑下();
    }
    private 丂与业丕丐专东东上.丒丌丝丆东上下下专(string 丙下不丏丅丅专丂丗)
    {
        this.UniqueId = 丙下不丏丅丅专丂丗;
    }
    internal System.Collections.Generic.Dictionary<string, object> 丏东丐丗丘下专丅上()
    {
        object val_4;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.set_Item(key:  "id", value:  this.UniqueId);
        val_1.set_Item(key:  "i", value:  this.<一万丂丟不丛丟下世>k__BackingField);
        val_1.set_Item(key:  "f", value:  this.<七专万丆上丝三丏丏>k__BackingField);
        val_4 = this.<丅丝专一下丑丙一与>k__BackingField;
        val_1.set_Item(key:  "t", value:  this.<丅丝专一下丑丙一与>k__BackingField);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_4 = 0;
        val_1.set_Item(key:  "p", value:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.<丑七不丛一丁世丏业>k__BackingField));
        val_1.set_Item(key:  "c", value:  this.<三丆专丟七东丆专世>k__BackingField);
        val_1.set_Item(key:  "s", value:  this.<丑上丙丈丒上丟丙丒>k__BackingField);
        return val_1;
    }
    internal static Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 丅东东下丆不丟一三(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
    {
        System.Collections.Generic.IDictionary<System.String, System.Object> val_17;
        var val_18;
        var val_20;
        val_17 = 一丐丗丁丞丆丅丟丄;
        int val_3 = 0;
        string val_1 = 0;
        int val_6 = 0;
        string val_10 = 0;
        int val_12 = 0;
        if(val_17 == null)
        {
                return (丒丌丝丆东上下下专)val_17;
        }
        
        bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_17, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_1);
        bool val_4 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_17, 下上丐丆丝丟丝丒不:  "i", 丙业与丙丗丝不丈东: out  val_3);
        bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_17, 下上丐丆丝丟丝丒不:  "f", 丙业与丙丗丝不丈东: out  val_3);
        bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_17, 下上丐丆丝丟丝丒不:  "t", 丙业与丙丗丝不丈东: out  val_6);
        bool val_9 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_17, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  0);
        bool val_11 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_17, 下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东: out  val_10);
        bool val_13 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_17, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  val_12);
        丂与业丕丐专东东上.丒丌丝丆东上下下专 val_14 = null;
        val_17 = val_14;
        val_14 = new 丂与业丕丐专东东上.丒丌丝丆东上下下专();
        .UniqueId = val_1;
        if(val_17 != null)
        {
                .<一万丂丟不丛丟下世>k__BackingField = 0;
            .<七专万丆上丝三丏丏>k__BackingField = 0;
            val_18 = val_6;
        }
        else
        {
                mem[24] = 0;
            .<七专万丆上丝三丏丏>k__BackingField = 0;
            val_18 = val_6;
        }
        
        .<丅丝专一下丑丙一与>k__BackingField = 0;
        DataSystem.丈且丈上不下且丝丒 val_15 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_17 != null)
        {
                .<丑七不丛一丁世丏业>k__BackingField = val_15;
            .<三丆专丟七东丆专世>k__BackingField = val_10;
            val_20 = val_12;
        }
        else
        {
                mem[40] = val_15;
            mem[48] = val_10;
            val_20 = val_12;
        }
        
        .<丑上丙丈丒上丟丙丒>k__BackingField = 0;
        return (丒丌丝丆东上下下专)val_17;
    }
    public bool Equals(Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 丘丛丏丘丝七世七丅)
    {
        if(丘丛丏丘丝七世七丅 == null)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  this.UniqueId, b:  丘丛丏丘丝七世七丅.UniqueId);
    }
    public int CompareTo(Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 丘丛丏丘丝七世七丅)
    {
        if(丘丛丏丘丝七世七丅 != null)
        {
                return System.String.Compare(strA:  this.UniqueId, strB:  丘丛丏丘丝七世七丅.UniqueId, comparisonType:  2);
        }
        
        return System.String.Compare(strA:  this.UniqueId, strB:  丘丛丏丘丝七世七丅.UniqueId, comparisonType:  2);
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
        if(万且万且丑丗且丌丆 == null)
        {
                return false;
        }
        
        return false;
    }
    public override int GetHashCode()
    {
        if(this.UniqueId == null)
        {
            
        }
    
    }

}
