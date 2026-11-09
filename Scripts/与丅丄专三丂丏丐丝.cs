using UnityEngine;
internal sealed class 与丅丄专三丂丏丐丝
{
    // Fields
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Type> 世丂上丌丞且丁七丏;
    
    // Methods
    public static 丒东丂万与不七丘丑 下丙丗丟丂下丏不丟(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 上且丗一丏丏万丅丌;
        val_7 = null;
        val_7 = null;
        if((与丅丄专三丂丏丐丝.世丂上丌丞且丁七丏.ContainsKey(key:  val_6)) != false)
        {
                val_8 = null;
            val_8 = null;
            object val_3 = System.Activator.CreateInstance(type:  与丅丄专三丂丏丐丝.世丂上丌丞且丁七丏.Item[val_6]);
            if(val_3 == null)
        {
                return (丒东丂万与不七丘丑)val_9;
        }
        
            var val_4 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (丒东丂万与不七丘丑.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            return (丒东丂万与不七丘丑)val_9;
        }
        
        val_6 = System.String.Format(format:  "BaseTeamCounter {0} does\'t have implementation!", arg0:  val_6);
        UnityEngine.Debug.LogError(message:  val_6);
        val_9 = 0;
        return (丒东丂万与不七丘丑)val_9;
    }
    public 与丅丄专三丂丏丐丝()
    {
    
    }
    private static 与丅丄专三丂丏丐丝()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Type> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Type>();
        val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  5, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  8, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  16, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  19, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  33, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  36, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        与丅丄专三丂丏丐丝.世丂上丌丞且丁七丏 = val_1;
    }

}
