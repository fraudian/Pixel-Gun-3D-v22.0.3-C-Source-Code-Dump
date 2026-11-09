using UnityEngine;
internal class BotHpIndicator.不且丅丙上丕与丂下
{
    // Fields
    private readonly System.Func<float> 丏丆世七一三丏丈七;
    private readonly System.Func<float> 七丘万丝丑专东丐丆;
    
    // Properties
    public float 三丄丗世丌丂丗丞东 { get; }
    public float 丘丄丅上丘丛丑专不 { get; }
    
    // Methods
    public BotHpIndicator.不且丅丙上丕与丂下(System.Func<float> 丑丆三丑丒丌丌丁丟, System.Func<float> 不丛丄丕丑专三七业)
    {
        System.Func<System.Single> val_3;
        System.Func<System.Single> val_4;
        var val_5;
        var val_7;
        val_3 = 不丛丄丕丑专三七业;
        val_4 = 丑丆三丑丒丌丌丁丟;
        if(val_4 != null)
        {
            goto label_1;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = BotHpIndicator.不且丅丙上丕与丂下.<>c.<>9__2_0;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        label_1:
        if(this != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        this.七丘万丝丑专东丐丆 = val_4;
        if(val_3 == null)
        {
                val_7 = null;
            val_7 = null;
            val_3 = BotHpIndicator.不且丅丙上丕与丂下.<>c.<>9__2_1;
            if(val_3 == null)
        {
                System.Func<System.Single> val_1 = null;
            val_3 = val_1;
            val_1 = new System.Func<System.Single>(object:  BotHpIndicator.不且丅丙上丕与丂下.<>c.__il2cppRuntimeField_static_fields, method:  System.Single BotHpIndicator.不且丅丙上丕与丂下.<>c::丝丙丅丘丂丈下业三());
            BotHpIndicator.不且丅丙上丕与丂下.<>c.<>9__2_1 = val_3;
        }
        
        }
        
        this.丏丆世七一三丏丈七 = val_3;
        return;
        label_4:
        BotHpIndicator.不且丅丙上丕与丂下.<>c.<>9__2_0 = new System.Func<System.Single>(object:  BotHpIndicator.不且丅丙上丕与丂下.<>c.__il2cppRuntimeField_static_fields, method:  System.Single BotHpIndicator.不且丅丙上丕与丂下.<>c::业丏丒丌丌东丕丐业());
        if(this != null)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    public float 三丏丟不丆丅丞不丛()
    {
        if(this.七丘万丝丑专东丐丆 != null)
        {
                return this.七丘万丝丑专东丐丆.Invoke();
        }
        
        return this.七丘万丝丑专东丐丆.Invoke();
    }
    public float 与丏丛与世万丙丁三()
    {
        if(this.丏丆世七一三丏丈七 != null)
        {
                return this.丏丆世七一三丏丈七.Invoke();
        }
        
        return this.丏丆世七一三丏丈七.Invoke();
    }

}
