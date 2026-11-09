using UnityEngine;
internal sealed class OfferwallController.下丝丒东丟丂一七世 : OfferwallController.业世下丐丕丘上下三
{
    // Fields
    private static readonly PGCompany.OfferwallController.下丝丒东丟丂一七世 丙丐业世丗丘丈丕下;
    private string 丅丌丅三丟七丗且丌;
    
    // Properties
    internal static PGCompany.OfferwallController.下丝丒东丟丂一七世 丏丈七万丈丗下世万 { get; }
    internal string 丕下业丈下世七丒业 { get; }
    
    // Methods
    internal OfferwallController.下丝丒东丟丂一七世(string 丁丂丕与丁丒丕丟丞)
    {
        this = new System.Object();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == true)
        {
            goto label_3;
        }
        
        if(丁丂丕与丁丒丕丟丞 == null)
        {
            goto label_4;
        }
        
        label_12:
        label_14:
        this.丅丌丅三丟七丗且丌 = 丁丂丕与丁丒丕丟丞;
        return;
        label_3:
        object[] val_3 = new object[1];
        val_3[0] = 丁丂丕与丁丒丕丟丞;
        UnityEngine.Debug.LogFormat(format:  "[IdleState.ctor] reason: {0}", args:  val_3);
        if(丁丂丕与丁丒丕丟丞 != null)
        {
            goto label_12;
        }
        
        label_4:
        if(this != null)
        {
            goto label_14;
        }
        
        goto label_14;
    }
    internal static PGCompany.OfferwallController.下丝丒东丟丂一七世 丑下丗万丈丄丏一丞()
    {
        null = null;
        return (OfferwallController.下丝丒东丟丂一七世)OfferwallController.下丝丒东丟丂一七世.丙丐业世丗丘丈丕下;
    }
    internal string 丐丝且专丛丞丞丄业()
    {
        return (string)this.丅丌丅三丟七丗且丌;
    }
    internal bool 三丅东一万丐东上丏(string 丁丂丕与丁丒丕丟丞)
    {
        string val_4;
        var val_5;
        val_4 = 丁丂丕与丁丒丕丟丞;
        if((System.String.Equals(a:  this.丅丌丅三丟七丗且丌, b:  val_4, comparisonType:  4)) != false)
        {
                val_5 = 0;
            return (bool)val_5;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_3 = new object[1];
            val_3[0] = val_4;
            UnityEngine.Debug.LogFormat(format:  "[IdleState.set_Reason] reason: {0}", args:  val_3);
        }
        
        if(val_4 == null)
        {
                val_4 = System.String.alignConst;
        }
        
        val_5 = 1;
        this.丅丌丅三丟七丗且丌 = val_4;
        return (bool)val_5;
    }
    private static OfferwallController.下丝丒东丟丂一七世()
    {
        OfferwallController.下丝丒东丟丂一七世.丙丐业世丗丘丈丕下 = new OfferwallController.下丝丒东丟丂一七世(丁丂丕与丁丒丕丟丞:  "Initial");
    }

}
