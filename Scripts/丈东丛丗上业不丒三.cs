using UnityEngine;
internal static class 丈东丛丗上业不丒三
{
    // Fields
    private static Rilisoft.PrefabHandler 三丞下丅丟丘东世上;
    private static Rilisoft.PrefabHandler 丗与丅且丑丙丝丈丙;
    private static Rilisoft.专丕丝丏丒一一万丏<ContextMenuBase> 丒丁丗东专丟丒丒上;
    private static Rilisoft.专丕丝丏丒一一万丏<ContextMenuBase> 丛七丟丑下丂丟上万;
    internal static System.Collections.Generic.HashSet<string> 与三丙且丙丄东三丆;
    
    // Properties
    internal static ContextMenuBase 丒业丑丕丒丘丑丕丂 { get; }
    internal static ContextMenuBase 丟上丐三丘丙丞丙且 { get; }
    internal static int 丌丂丛专丅丈丛丂丁 { get; }
    
    // Methods
    private static 丈东丛丗上业不丒三()
    {
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        if(val_1 != null)
        {
                bool val_2 = val_1.Add(item:  "OnScroll");
        }
        else
        {
                bool val_3 = val_1.Add(item:  "OnScroll");
        }
        
        bool val_4 = val_1.Add(item:  "OnPressure");
        if(val_1 != null)
        {
                bool val_5 = val_1.Add(item:  "OnClick");
        }
        else
        {
                bool val_6 = val_1.Add(item:  "OnClick");
        }
        
        bool val_7 = val_1.Add(item:  "OnKey");
        bool val_8 = val_1.Add(item:  "OnPress");
        丈东丛丗上业不丒三.与三丙且丙丄东三丆 = val_1;
        丈东丛丗上业不丒三.三丞下丅丟丘东世上 = new Rilisoft.PrefabHandler();
        mem[1152921539424170920] = "Assets/Resources/NguiWindows/Clan/Clan_popup.prefab";
        丈东丛丗上业不丒三.丗与丅且丑丙丝丈丙 = new Rilisoft.PrefabHandler();
        mem[1152921539424175016] = "Assets/Resources/NguiWindows/Clan/LastGame_popup.prefab";
    }
    internal static ContextMenuBase 丁丌丒三三丛丞丂万()
    {
        var val_3 = null;
        if(丈东丛丗上业不丒三.丒丁丗东专丟丒丒上 == null)
        {
                Rilisoft.专丕丝丏丒一一万丏<ContextMenuBase> val_2 = new Rilisoft.专丕丝丏丒一一万丏<ContextMenuBase>(丆万丕丏与丈与丒丗:  丈东丛丗上业不丒三.__il2cppRuntimeField_static_fields.ResourcePath, 丆丏七丟不丒与七专:  0);
            val_3 = null;
            丈东丛丗上业不丒三.丒丁丗东专丟丒丒上 = val_2;
        }
        
        val_3 = null;
        if(丈东丛丗上业不丒三.丒丁丗东专丟丒丒上 != null)
        {
                return val_2.世三丞丅丑丌丈丈一();
        }
        
        return val_2.世三丞丅丑丌丈丈一();
    }
    internal static ContextMenuBase 丁丟丆与丈丆丌丑且()
    {
        var val_3 = null;
        if(丈东丛丗上业不丒三.丛七丟丑下丂丟上万 == null)
        {
                Rilisoft.专丕丝丏丒一一万丏<ContextMenuBase> val_2 = new Rilisoft.专丕丝丏丒一一万丏<ContextMenuBase>(丆万丕丏与丈与丒丗:  丈东丛丗上业不丒三.丗与丅且丑丙丝丈丙.ResourcePath, 丆丏七丟不丒与七专:  0);
            val_3 = null;
            丈东丛丗上业不丒三.丛七丟丑下丂丟上万 = val_2;
        }
        
        val_3 = null;
        if(丈东丛丗上业不丒三.丛七丟丑下丂丟上万 != null)
        {
                return val_2.世三丞丅丑丌丈丈一();
        }
        
        return val_2.世三丞丅丑丌丈丈一();
    }
    internal static int 丌丟三三丘丛一专一()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_10 = null;
        val_10 = null;
        if(丈东丛丗上业不丒三.丒丁丗东专丟丒丒上 != null)
        {
                val_9 = 丈东丛丗上业不丒三.丁丌丒三三丛丞丂万().gameObject;
            val_10 = null;
            val_11 = val_9.activeSelf;
        }
        else
        {
                val_11 = 0;
        }
        
        val_10 = null;
        if(丈东丛丗上业不丒三.丛七丟丑下丂丟上万 != null)
        {
                val_9 = 丈东丛丗上业不丒三.丁丟丆与丈丆丌丑且().gameObject;
            val_12 = val_9.activeSelf;
            return (int)val_12 + val_11;
        }
        
        val_12 = 0;
        return (int)val_12 + val_11;
    }
    internal static void 丒专上丁且丑丙丗世()
    {
        ContextMenuBase val_1 = 丈东丛丗上业不丒三.丁丌丒三三丛丞丂万();
        if(丈东丛丗上业不丒三.丁丟丆与丈丆丌丑且() == null)
        {
            
        }
    
    }

}
