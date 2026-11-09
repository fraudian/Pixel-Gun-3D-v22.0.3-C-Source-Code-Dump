using UnityEngine;
public class 丙且上东下丏丏丟下 : IEquatable<丙且上东下丏丏丟下>
{
    // Fields
    private 丕丑丙丑丙东丌丘丕 <丝丅丌七不七万丑丙>k__BackingField;
    internal PGCompany.丏丅丂东丐东七丂丙 丅丝不万丑丁丙东丅;
    private int <丒丒丏一下业丁丌丗>k__BackingField;
    private int <丟一东一业丘丙丝丆>k__BackingField;
    private int <世丈丕丗下丏丞不丁>k__BackingField;
    private string <上七东下丏不丕丐丑>k__BackingField;
    public string 丞一丁业丄一一业且;
    public int 丞丒三东丏丗七丁丏;
    private CategoryNames <丄上丞不三与一丅丒>k__BackingField;
    
    // Properties
    internal 丕丑丙丑丙东丌丘丕 丅万丗上三不丙丆丒 { get; set; }
    internal static int 丒丟七丞上丟丝丛与 { get; }
    internal int 丈丘丝一丗下丈丐不 { get; set; }
    internal int 丒上丂三丙丒丘世丂 { get; set; }
    internal int 一丆丈三三七专三丗 { get; set; }
    public string 万不三丗丕上丌与专 { get; }
    public string 下丄丈不与世丐业专 { get; set; }
    public CategoryNames 七丌丌丏丗东丕且丅 { get; set; }
    
    // Methods
    internal 丕丑丙丑丙东丌丘丕 丒专丘丙丌业丑丛三()
    {
        return (丕丑丙丑丙东丌丘丕)this.<丝丅丌七不七万丑丙>k__BackingField;
    }
    internal void 七丝下丈不不三丌专(丕丑丙丑丙东丌丘丕 丙业与丙丗丝不丈东)
    {
        this.<丝丅丌七不七万丑丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static int 丅丈丌丙丛丆丌丂丆()
    {
        return 215;
    }
    internal int 丄专丝上上业丘丞丂()
    {
        return (int)this.<丒丒丏一下业丁丌丗>k__BackingField;
    }
    internal void 与丐丘丌丁丗丞丄丑(int 丙业与丙丗丝不丈东)
    {
        this.<丒丒丏一下业丁丌丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丅世且与丏丆下丝丒()
    {
        return (int)this.<丟一东一业丘丙丝丆>k__BackingField;
    }
    internal void 丅丟业下与丏专万且(int 丙业与丙丗丝不丈东)
    {
        this.<丟一东一业丘丙丝丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丝七丘丏丂丂丏上且()
    {
        return (int)this.<世丈丕丗下丏丞不丁>k__BackingField;
    }
    internal void 丄七丙丙丝东丆丄下(int 丙业与丙丗丝不丈东)
    {
        this.<世丈丕丗下丏丞不丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string 三与丛丑且丐丈业丌()
    {
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<上七东下丏不丕丐丑>k__BackingField);
        if(val_1 == null)
        {
                return "";
        }
        
        return val_1.三与丛丑且丐丈业丌();
    }
    public bool 丕丙丆丐丗丙丆丐丅()
    {
        if((this.<丄上丞不三与一丅丒>k__BackingField) == 220000)
        {
                return true;
        }
        
        if((this.<丄上丞不三与一丅丒>k__BackingField) != 230000)
        {
                return (bool)(((this.<丄上丞不三与一丅丒>k__BackingField) == 240000) ? 1 : 0) | (((this.<丄上丞不三与一丅丒>k__BackingField) == 250000) ? 1 : 0);
        }
        
        return true;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "[ShopItem: Id={0}, Category={1}]", arg0:  this.<上七东下丏不丕丐丑>k__BackingField, arg1:  this.<丄上丞不三与一丅丒>k__BackingField);
    }
    public 丙且上东下丏丏丟下(string 丞丅上丏丂且下丅与, CategoryNames 七丆丒与丗丌丄且丂)
    {
        CategoryNames val_6 = 七丆丒与丗丌丄且丂;
        this.丞丒三东丏丗七丁丏 = 0;
        this.丞一丁业丄一一业且 = "";
        this.<丄上丞不三与一丅丒>k__BackingField = val_6;
        this.<上七东下丏不丕丐丑>k__BackingField = 丞丅上丏丂且下丅与;
        this.丞一丁业丄一一业且 = 丞丅上丏丂且下丅与;
        if((丞丅上丏丂且下丅与.IndexOf(value:  '|')) == 1)
        {
                return;
        }
        
        char[] val_2 = new char[1];
        val_6 = val_2;
        val_6[0] = 124;
        System.String[] val_3 = this.<上七东下丏不丕丐丑>k__BackingField.Split(separator:  val_2);
        if(val_3.Length < 2)
        {
                return;
        }
        
        this.丞一丁业丄一一业且 = val_3[0];
        bool val_5 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_3[1], 丙业与丙丗丝不丈东: out  0);
        this.丞丒三东丏丗七丁丏 = 0;
    }
    public string 业上丙丞丐丄丆丅七()
    {
        return (string)this.<上七东下丏不丕丐丑>k__BackingField;
    }
    private void 丒丞东丈丁丄丑丅且(string 丙业与丙丗丝不丈东)
    {
        this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public CategoryNames 丒万丕七专不丏丞丌()
    {
        return (CategoryNames)this.<丄上丞不三与一丅丒>k__BackingField;
    }
    private void 与丘丑丒丅丕丞七丈(CategoryNames 丙业与丙丗丝不丈东)
    {
        this.<丄上丞不三与一丅丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool Equals(丙且上东下丏丏丟下 丘丛丏丘丝七世七丅)
    {
        string val_3;
        var val_4;
        var val_5;
        val_4 = 丘丛丏丘丝七世七丅;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        if(this == val_4)
        {
            goto label_2;
        }
        
        val_3 = this.<上七东下丏不丕丐丑>k__BackingField;
        if((val_3.Equals(value:  丘丛丏丘丝七世七丅.<上七东下丏不丕丐丑>k__BackingField)) != false)
        {
                val_4 = this.<丄上丞不三与一丅丒>k__BackingField;
            val_5 = this.<丄上丞不三与一丅丒>k__BackingField.Equals(obj:  丘丛丏丘丝七世七丅.<丄上丞不三与一丅丒>k__BackingField);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_5 & 1;
        }
        
        label_4:
        val_5 = 0;
        return (bool)val_5 & 1;
        label_2:
        val_5 = 1;
        return (bool)val_5 & 1;
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
        var val_2 = 0;
        val_2 = val_2 & 1;
        return (bool)val_2;
    }
    public override int GetHashCode()
    {
        var val_2;
        if((this.<上七东下丏不丕丐丑>k__BackingField) != null)
        {
                val_2 = this.<上七东下丏不丕丐丑>k__BackingField;
        }
        else
        {
                val_2 = 0;
        }
        
        int val_1 = this.<丄上丞不三与一丅丒>k__BackingField.丙东专丂世丈丏丁丂();
        val_1 = val_1 ^ val_2;
        return (int)val_1;
    }
    public 丙且上东下丏丏丟下 丕东丞业丗三丅丗万()
    {
        return (丙且上东下丏丏丟下)new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.<上七东下丏不丕丐丑>k__BackingField, 七丆丒与丗丌丄且丂:  this.<丄上丞不三与一丅丒>k__BackingField);
    }

}
