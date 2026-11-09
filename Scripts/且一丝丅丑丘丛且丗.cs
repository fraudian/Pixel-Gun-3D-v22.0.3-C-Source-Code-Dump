using UnityEngine;
internal static class 且一丝丅丑丘丛且丗
{
    // Fields
    private static System.Collections.Generic.Dictionary<丘专丑丁丟丞丝丈丂, System.Type> 世丂上丌丞且丁七丏;
    
    // Methods
    public static BaseTriggerAlternativeAttack 下丙丗丟丂下丏不丟(丘专丑丁丟丞丝丈丂 丘世丐不丈丐丟上业, object[] 专丒丌丆下丐丞丟丞)
    {
        丘专丑丁丟丞丝丈丂 val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丘世丐不丈丐丟上业;
        val_7 = null;
        val_7 = null;
        if((且一丝丅丑丘丛且丗.世丂上丌丞且丁七丏.ContainsKey(key:  val_6)) != false)
        {
                val_8 = null;
            val_8 = null;
            object val_3 = System.Activator.CreateInstance(type:  且一丝丅丑丘丛且丗.世丂上丌丞且丁七丏.Item[val_6]);
            if(val_3 == null)
        {
                return (BaseTriggerAlternativeAttack)val_9;
        }
        
            var val_4 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (BaseTriggerAlternativeAttack.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            return (BaseTriggerAlternativeAttack)val_9;
        }
        
        val_6 = System.String.Format(format:  "TriggerTypeAlternativeAttack {0} does\'t have implementation!", arg0:  val_6);
        UnityEngine.Debug.LogError(message:  val_6);
        val_9 = 0;
        return (BaseTriggerAlternativeAttack)val_9;
    }
    private static 且一丝丅丑丘丛且丗()
    {
        System.Collections.Generic.Dictionary<丘专丑丁丟丞丝丈丂, System.Type> val_1 = new System.Collections.Generic.Dictionary<丘专丑丁丟丞丝丈丂, System.Type>();
        val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        且一丝丅丑丘丛且丗.世丂上丌丞且丁七丏 = val_1;
    }

}
