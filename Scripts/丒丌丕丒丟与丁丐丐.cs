using UnityEngine;
internal sealed class 丒丌丕丒丟与丁丐丐
{
    // Fields
    private string <与丅万万丁丒丞丘丟>k__BackingField;
    private System.Collections.Generic.List<string> <上一丌丒丘丒丑丐丑>k__BackingField;
    private System.Collections.Generic.List<int> <丑丟专不丞三下丘丌>k__BackingField;
    
    // Properties
    internal string 丟丕且不与一七与丘 { get; set; }
    internal System.Collections.Generic.List<string> 下三丈下丄万丑丐七 { get; set; }
    internal System.Collections.Generic.List<int> 丏且万上世万一且丙 { get; set; }
    
    // Methods
    internal string 业丄丆业丗下与下丙()
    {
        return (string)this.<与丅万万丁丒丞丘丟>k__BackingField;
    }
    private void 一三业且丈丟上东上(string 丙业与丙丗丝不丈东)
    {
        this.<与丅万万丁丒丞丘丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<string> 丏一一丏丗丝丗丂专()
    {
        return (System.Collections.Generic.List<System.String>)this.<上一丌丒丘丒丑丐丑>k__BackingField;
    }
    private void 丆专丁下丕丟丑丆丂(System.Collections.Generic.List<string> 丙业与丙丗丝不丈东)
    {
        this.<上一丌丒丘丒丑丐丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<int> 丙丏丛丐世万丑丄且()
    {
        return (System.Collections.Generic.List<System.Int32>)this.<丑丟专不丞三下丘丌>k__BackingField;
    }
    private void 丅丄丈丝不丄丈丝东(System.Collections.Generic.List<int> 丙业与丙丗丝不丈东)
    {
        this.<丑丟专不丞三下丘丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public 丒丌丕丒丟与丁丐丐(PGCompany.DataObjects.丄丙与丟东丄不世且.下丕业丄丄丁丑丗一 上世丏丁世丟世丆业)
    {
        if(上世丏丁世丟世丆业 != null)
        {
                this.<与丅万万丁丒丞丘丟>k__BackingField = 上世丏丁世丟世丆业.charPresetID;
            this.<上一丌丒丘丒丑丐丑>k__BackingField = 上世丏丁世丟世丆业.charList;
        }
        else
        {
                this.<与丅万万丁丒丞丘丟>k__BackingField = 11993091;
            this.<上一丌丒丘丒丑丐丑>k__BackingField = 28563616;
        }
        
        this.<丑丟专不丞三下丘丌>k__BackingField = 上世丏丁世丟世丆业.charLimit;
    }
    internal int 丂一丌丘丙与丗丙丅(string 七丛业丘丕与丝不丝)
    {
        if((this.<上一丌丒丘丒丑丐丑>k__BackingField) == null)
        {
                return 0;
        }
        
        if((this.<丑丟专不丞三下丘丌>k__BackingField) == null)
        {
                return 0;
        }
        
        if((this.<上一丌丒丘丒丑丐丑>k__BackingField.Contains(item:  七丛业丘丕与丝不丝)) == false)
        {
                return 0;
        }
        
        int val_2 = this.<上一丌丒丘丒丑丐丑>k__BackingField.IndexOf(item:  七丛业丘丕与丝不丝);
        if(val_2 >= (this.<丑丟专不丞三下丘丌>k__BackingField.Count))
        {
                return 0;
        }
        
        if((this.<丑丟专不丞三下丘丌>k__BackingField) != null)
        {
                return this.<丑丟专不丞三下丘丌>k__BackingField.Item[val_2];
        }
        
        return this.<丑丟专不丞三下丘丌>k__BackingField.Item[val_2];
    }

}
