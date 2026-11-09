using UnityEngine;
internal class 丌且万一上丄丒丑七
{
    // Fields
    private static System.Collections.Generic.Dictionary<丙丟七丁世丌上丟丏, System.Type> 世丂上丌丞且丁七丏;
    
    // Methods
    public static 丆丘丆丞丙下丆丟丅 下丙丗丟丂下丏不丟(丙丟七丁世丌上丟丏 丕丛不一丛三下丄下, System.Action 丟丘丙丄丅万丏与丗, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = 专丒丌丆下丐丞丟丞;
        val_6 = null;
        val_6 = null;
        if((丌且万一上丄丒丑七.世丂上丌丞且丁七丏.ContainsKey(key:  丕丛不一丛三下丄下)) == false)
        {
            goto label_4;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = System.Activator.CreateInstance(type:  丌且万一上丄丒丑七.世丂上丌丞且丁七丏.Item[丕丛不一丛三下丄下]);
        if(val_8 == null)
        {
            goto label_10;
        }
        
        return (丆丘丆丞丙下丆丟丅)val_8;
        label_4:
        val_5 = System.String.Format(format:  "TypeSpawnDungeonTask {0} does\'t have implementation!", arg0:  丕丛不一丛三下丄下);
        UnityEngine.Debug.LogError(message:  val_5);
        val_8 = 0;
        return (丆丘丆丞丙下丆丟丅)val_8;
        label_10:
    }
    public 丌且万一上丄丒丑七()
    {
    
    }
    private static 丌且万一上丄丒丑七()
    {
        System.Collections.Generic.Dictionary<丙丟七丁世丌上丟丏, System.Type> val_1 = new System.Collections.Generic.Dictionary<丙丟七丁世丌上丟丏, System.Type>();
        val_1.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_1.Add(key:  5, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        丌且万一上丄丒丑七.世丂上丌丞且丁七丏 = val_1;
    }

}
