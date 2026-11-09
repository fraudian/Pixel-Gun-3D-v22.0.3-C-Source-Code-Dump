using UnityEngine;
public class 丒丆业丄东丏三丆丟
{
    // Fields
    private const string 丏丗上丌丑丝丟丝丟 = "error_code";
    private const string 丑丌一丈丁一丂专丁 = "error_description";
    private const string 丝下专丏丒丑丐不一 = "instanceId";
    private const string 与丗上不丞世丂七丂 = "placement";
    
    // Methods
    public static 丒丁丐丆丁丐丙且上 丌丕万七丂丐业丅丟(object 丞不且丁丂丏丈丆东)
    {
        string val_11;
        var val_12;
        string val_13;
        if(丞不且丁丂丏丈丆东 == null)
        {
            goto label_1;
        }
        
        if(丞不且丁丂丏丈丆东 == null)
        {
            goto label_15;
        }
        
        var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丞不且丁丂丏丈丆东 : 0;
        goto label_16;
        label_1:
        if(丞不且丁丂丏丈丆东 != null)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        label_15:
        val_11 = 0;
        label_16:
        丒丁丐丆丁丐丙且上 val_2 = null;
        val_12 = val_2;
        val_13 = "";
        val_2 = new 丒丁丐丆丁丐丙且上();
        .专丏不丏东丏丈丆上 = 0;
        .丞丟丂丄下万丈万东 = val_13;
        if(val_11 == 0)
        {
                return (丒丁丐丆丁丐丙且上)val_12;
        }
        
        if(val_11.Count < 1)
        {
                return (丒丁丐丆丁丐丙且上)val_12;
        }
        
        val_13 = System.Convert.ToInt32(value:  val_11.Item["error_code"]);
        val_11 = val_11.Item["error_description"];
        丒丁丐丆丁丐丙且上 val_7 = null;
        val_12 = val_7;
        val_7 = new 丒丁丐丆丁丐丙且上();
        .专丏不丏东丏丈丆上 = val_13;
        .丞丟丂丄下万丈万东 = val_11;
        return (丒丁丐丆丁丐丙且上)val_12;
        label_6:
        if((System.String.IsNullOrEmpty(value:  丞不且丁丂丏丈丆东)) == true)
        {
            goto label_16;
        }
        
        object val_9 = IronSourceJSON.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丞不且丁丂丏丈丆东);
        if(val_9 == null)
        {
            goto label_15;
        }
        
        var val_10 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_9) : 0;
        goto label_16;
    }
    public static 业世丒下丁东丂丏七 丞丄丕与丕丈丐丟丝(object 七丑世七丄丙丒七丆)
    {
        object val_8 = 七丑世七丄丙丒七丆;
        if(val_8 == null)
        {
            goto label_1;
        }
        
        if(val_8 == null)
        {
                return (业世丒下丁东丂丏七)val_8;
        }
        
        label_14:
        if(val_8.Count < 1)
        {
            goto label_5;
        }
        
        业世丒下丁东丂丏七 val_6 = null;
        val_8 = val_6;
        val_6 = new 业世丒下丁东丂丏七(三七一丁上且丐丝丌:  val_8.Item["placement_name"], 丏七丙不丁丁丒丒丗:  val_8.Item["placement_reward_name"], 丒专丘丗专丝三丛丘:  System.Convert.ToInt32(value:  val_8.Item["placement_reward_amount"]));
        return (业世丒下丁东丂丏七)val_8;
        label_1:
        if(val_8 == null)
        {
                return (业世丒下丁东丂丏七)val_8;
        }
        
        if(null == null)
        {
            goto label_13;
        }
        
        label_5:
        val_8 = 0;
        return (业世丒下丁东丂丏七)val_8;
        label_13:
        if((IronSourceJSON.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_8 = 七丑世七丄丙丒七丆)) != null)
        {
            goto label_14;
        }
        
        return (业世丒下丁东丂丏七)val_8;
    }
    public 丒丆业丄东丏三丆丟()
    {
    
    }

}
