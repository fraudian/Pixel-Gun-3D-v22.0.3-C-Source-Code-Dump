using UnityEngine;
public class 丞丞万丄丈业丆丙万
{
    // Fields
    private string <七世专丙丝丒丒丟丁>k__BackingField;
    private int <丅不业与七丅丆一丞>k__BackingField;
    private string <丞不丗丙丐丙七上不>k__BackingField;
    private System.Collections.Generic.Dictionary<string, object> <七丗丟丄丅且丐丟东>k__BackingField;
    
    // Properties
    public string 专丕与丒丗丁丘专丟 { get; set; }
    public int 丐丗上七下丅丕万且 { get; set; }
    public string 一不专丙丈丆专上丌 { get; set; }
    public System.Collections.Generic.Dictionary<string, object> 丄丗丒专丆与丈上丁 { get; set; }
    
    // Methods
    public string 东丙上东业丆不丟丘()
    {
        return (string)this.<七世专丙丝丒丒丟丁>k__BackingField;
    }
    private void 丌丏上丏东且丄丑丌(string 丙业与丙丗丝不丈东)
    {
        this.<七世专丙丝丒丒丟丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int 丕丁业丙东丂业丈丑()
    {
        return (int)this.<丅不业与七丅丆一丞>k__BackingField;
    }
    private void 丕丙丝丗丟丐丌丕丆(int 丙业与丙丗丝不丈东)
    {
        this.<丅不业与七丅丆一丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string 丌丆丝丕七丙丁丁丌()
    {
        return (string)this.<丞不丗丙丐丙七上不>k__BackingField;
    }
    private void 丐丏丆丙丅丙丞上丑(string 丙业与丙丗丝不丈东)
    {
        this.<丞不丗丙丐丙七上不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public System.Collections.Generic.Dictionary<string, object> 丘一一丆业丂丘丒世()
    {
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.<七丗丟丄丅且丐丟东>k__BackingField;
    }
    private void 万专三专业丌丈丌且(System.Collections.Generic.Dictionary<string, object> 丙业与丙丗丝不丈东)
    {
        this.<七丗丟丄丅且丐丟东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public 丞丞万丄丈业丆丙万(ExitGames.Client.Photon.OperationResponse 丑与丂丌世丕丆一丗)
    {
        var val_9;
        int val_10;
        var val_11;
        var val_12;
        object val_1 = 0;
        bool val_2 = 丑与丂丌世丕丆一丗.Parameters.TryGetValue(key:  209, value: out  val_1);
        val_9 = val_1;
        this.<七世专丙丝丒丒丟丁>k__BackingField = (1179403647 == null) ? (val_9) : 0;
        bool val_4 = 丑与丂丌世丕丆一丗.Parameters.TryGetValue(key:  207, value: out  val_1);
        if(val_1 != 0)
        {
                val_10 = 127;
        }
        else
        {
                val_10 = 0;
        }
        
        this.<丅不业与七丅丆一丞>k__BackingField = val_10;
        bool val_5 = 丑与丂丌世丕丆一丗.Parameters.TryGetValue(key:  208, value: out  val_1);
        val_11 = val_1;
        if(val_11 != 0)
        {
                val_11 = 0;
        }
        
        this.<七丗丟丄丅且丐丟东>k__BackingField = ;
        bool val_7 = 丑与丂丌世丕丆一丗.Parameters.TryGetValue(key:  206, value: out  val_1);
        val_12 = val_1;
        this.<丞不丗丙丐丙七上不>k__BackingField = (1179403647 == null) ? (val_12) : 0;
    }
    public string 丛丈丆与专丕丏丐丄()
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if((this.<七世专丙丝丒丒丟丁>k__BackingField) != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if((this.<七世专丙丝丒丒丟丁>k__BackingField) == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.<七世专丙丝丒丒丟丁>k__BackingField;
        val_1[1] = ExitGames.Client.Photon.SupportClass.DictionaryToString(dictionary:  this.<七丗丟丄丅且丐丟东>k__BackingField);
        val_1[2] = this.<丅不业与七丅丆一丞>k__BackingField;
        val_1[3] = this.<丞不丗丙丐丙七上不>k__BackingField;
        return (string)System.String.Format(format:  "{0}={2}: {1} \"{3}\"", args:  val_1);
    }

}
