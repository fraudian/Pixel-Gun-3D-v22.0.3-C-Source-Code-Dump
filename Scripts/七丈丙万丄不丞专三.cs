using UnityEngine;
public class 七丈丙万丄不丞专三
{
    // Fields
    private CustomAuthenticationType 丕丝下丕丟丈丄东丛;
    private string <世丌丅业业七丞丏东>k__BackingField;
    private object <专丘万丑丟丞丞丙丏>k__BackingField;
    private string <丆东世万万丑丐丈专>k__BackingField;
    private string <业丞丄丂丄下丞三世>k__BackingField;
    
    // Properties
    public CustomAuthenticationType 东丏不丌万与丄丌且 { get; set; }
    public string 丙丐丟不丄三下丆与 { get; set; }
    public object 三丂丞万上丛丛丈专 { get; set; }
    public string 万丙万丆世且专世丕 { get; set; }
    public string 丒丁丙丞丆丟丑业丈 { get; set; }
    
    // Methods
    public CustomAuthenticationType 丝丞丗世丅东万丘且()
    {
        return (CustomAuthenticationType)this.丕丝下丕丟丈丄东丛;
    }
    public void 丟丈丞丗下三业丐丘(CustomAuthenticationType 丙业与丙丗丝不丈东)
    {
        this.丕丝下丕丟丈丄东丛 = 丙业与丙丗丝不丈东;
    }
    public string 丄万不丁丈丗上业丞()
    {
        return (string)this.<世丌丅业业七丞丏东>k__BackingField;
    }
    public void 且丁丙世丐下丈业丞(string 丙业与丙丗丝不丈东)
    {
        this.<世丌丅业业七丞丏东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public object 丝丆丒丏丆丄丐丟丒()
    {
        return (object)this.<专丘万丑丟丞丞丙丏>k__BackingField;
    }
    private void 丛丑丟上丗丗丗万业(object 丙业与丙丗丝不丈东)
    {
        this.<专丘万丑丟丞丞丙丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string 丄丗丅丕上丆丛丆丂()
    {
        return (string)this.<丆东世万万丑丐丈专>k__BackingField;
    }
    public void 丕业丘丐丐丅丛丟丒(string 丙业与丙丗丝不丈东)
    {
        this.<丆东世万万丑丐丈专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string 丞丈业东专丅丆与七()
    {
        return (string)this.<业丞丄丂丄下丞三世>k__BackingField;
    }
    public void 下丂丏丝上丏与丁丆(string 丙业与丙丗丝不丈东)
    {
        this.<业丞丄丂丄下丞三世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public 七丈丙万丄不丞专三()
    {
        this.丕丝下丕丟丈丄东丛 = 255;
    }
    public 七丈丙万丄不丞专三(string 万丄丅丝三丈丆世丟)
    {
        this.丕丝下丕丟丈丄东丛 = 255;
        this.<业丞丄丂丄下丞三世>k__BackingField = 万丄丅丝三丈丆世丟;
    }
    public virtual void 与下东上丐丗丒上七(string 丌下业东与下丅丞七)
    {
        this.<专丘万丑丟丞丞丙丏>k__BackingField = ((System.String.IsNullOrEmpty(value:  丌下业东与下丅丞七)) != true) ? 0 : 丌下业东与下丅丞七;
    }
    public virtual void 与下东上丐丗丒上七(byte[] 丐东丟丅且丆不上丕)
    {
        this.<专丘万丑丟丞丞丙丏>k__BackingField = 丐东丟丅且丆不上丕;
    }
    public virtual void 与下东上丐丗丒上七(System.Collections.Generic.Dictionary<string, object> 丒丐丈下丛丛丒丈丏)
    {
        this.<专丘万丑丟丞丞丙丏>k__BackingField = 丒丐丈下丛丛丒丈丏;
    }
    public virtual void 不丆丁七丏丏丏丁丘(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
    {
        object[] val_3 = new object[4];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if((this.<世丌丅业业七丞丏东>k__BackingField) != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if((this.<世丌丅业业七丞丏东>k__BackingField) == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = this.<世丌丅业业七丞丏东>k__BackingField;
        val_3[1] = ((System.String.IsNullOrEmpty(value:  this.<世丌丅业业七丞丏东>k__BackingField)) != true) ? "" : "&";
        val_3[2] = System.Uri.EscapeDataString(stringToEscape:  下上丐丆丝丟丝丒不);
        val_3[3] = System.Uri.EscapeDataString(stringToEscape:  丙业与丙丗丝不丈东);
        this.<世丌丅业业七丞丏东>k__BackingField = System.String.Format(format:  "{0}{1}{2}={3}", args:  val_3);
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", arg0:  this.<业丞丄丂丄下丞三世>k__BackingField, arg1:  this.<世丌丅业业七丞丏东>k__BackingField, arg2:  ((this.<丆东世万万丑丐丈专>k__BackingField) != null) ? 1 : 0);
    }

}
