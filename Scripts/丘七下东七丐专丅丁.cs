using UnityEngine;
internal sealed class 丘七下东七丐专丅丁 : StringEnumConverter
{
    // Methods
    public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
    {
        var val_7;
        bool val_8;
        var val_9;
        val_8 = 丙业与丙丗丝不丈东;
        val_9 = 业专丘专七丕丟丅与;
        if(mem[137134651] == false)
        {
            goto label_0;
        }
        
        if(val_9 == null)
        {
            goto label_1;
        }
        
        label_4:
        if(val_8 == null)
        {
            goto val_9 + 632;
        }
        
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_8);
        val_8 = ???;
        val_9 = ???;
        val_7 = ???;
        goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_2C8;
        label_0:
        mem2[0] = 1;
        if(val_9 != 0)
        {
            goto label_4;
        }
        
        label_1:
        if(val_8 != 0)
        {
            goto label_5;
        }
        
        goto val_9 + 632;
    }
    public 丘七下东七丐专丅丁()
    {
    
    }

}
