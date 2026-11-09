using UnityEngine;
public static class 专业下丏丂丞丝丝东
{
    // Fields
    public static readonly string 丝三万丑丁专丂上丂;
    public static readonly string 丈业不丑丕丒丄丁世;
    public static readonly string 丄丕东业丘丌业三丒;
    
    // Methods
    public static void 丐七丕丞丒丁上世丅(世丁与丕丗丟丒丆上 丛下丄业丈东丆一丄, int 丁丕上丕与丟丌丛上, bool 丄一丅丌丗业下丄不 = False)
    {
        string val_4;
        var val_5;
        var val_6;
        val_4 = 丄一丅丌丗业下丄不;
        if(丛下丄业丈东丆一丄 == null)
        {
                return;
        }
        
        if(丛下丄业丈东丆一丄.丑丗三丛丛丆丟丌丆() == null)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_5 = null;
        val_5 = null;
        val_2.set_Item(key:  专业下丏丂丞丝丝东.丝三万丑丁专丂上丂, value:  丁丕上丕与丟丌丛上);
        if(val_4 != false)
        {
                val_6 = null;
            val_6 = null;
            val_4 = 专业下丏丂丞丝丝东.丈业不丑丕丒丄丁世;
            val_2.set_Item(key:  val_4, value:  丅丒丗丑丒丙丛不丆.一丛丘专七丄丗丝丕());
        }
        
        丛下丄业丈东丆一丄.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    public static int 下上丒丛七不丛一不(丞丘丒一上与丕丒且 丛下丄业丈东丆一丄)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丛下丄业丈东丆一丄;
        if(val_6 != null)
        {
                if(val_6.丑丗三丛丛丆丟丌丆() == null)
        {
                return (int)val_7;
        }
        
            val_8 = null;
            val_8 = null;
            if((val_6.丑丗三丛丛丆丟丌丆().ContainsKey(key:  专业下丏丂丞丝丝东.丝三万丑丁专丂上丂)) != false)
        {
                val_9 = null;
            val_6 = val_6.丑丗三丛丛丆丟丌丆();
            val_9 = null;
            object val_5 = val_6.Item[专业下丏丂丞丝丝东.丝三万丑丁专丂上丂];
            return (int)val_7;
        }
        
        }
        
        val_7 = 0;
        return (int)val_7;
    }
    public static int 丄丞丒丂丙丈世丒丝(丞丘丒一上与丕丒且 丛下丄业丈东丆一丄)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丛下丄业丈东丆一丄;
        if(val_6 != null)
        {
                if(val_6.丑丗三丛丛丆丟丌丆() == null)
        {
                return (int)val_7;
        }
        
            val_8 = null;
            val_8 = null;
            if((val_6.丑丗三丛丛丆丟丌丆().ContainsKey(key:  专业下丏丂丞丝丝东.丈业不丑丕丒丄丁世)) != false)
        {
                val_9 = null;
            val_6 = val_6.丑丗三丛丛丆丟丌丆();
            val_9 = null;
            object val_5 = val_6.Item[专业下丏丂丞丝丝东.丈业不丑丕丒丄丁世];
            return (int)val_7;
        }
        
        }
        
        val_7 = 0;
        return (int)val_7;
    }
    public static int 丕丘七与万不丂下丄(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_9;
        var val_10;
        string val_11;
        var val_12;
        var val_13;
        val_9 = 专丞上七七且丝七丗;
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 == null)
        {
                return (int)val_10;
        }
        
        if(val_1.丑丗三丛丛丆丟丌丆() == null)
        {
                return (int)val_10;
        }
        
        val_11 = val_1.丑丗三丛丛丆丟丌丆();
        val_12 = null;
        val_12 = null;
        if((val_11.ContainsKey(key:  专业下丏丂丞丝丝东.丝三万丑丁专丂上丂)) != false)
        {
                val_13 = null;
            val_13 = null;
            val_11 = 专业下丏丂丞丝丝东.丄丕东业丘丌业三丒;
            val_9 = val_11 + val_9.业丐丐三丕一丗丛丁();
            object val_8 = val_1.丑丗三丛丛丆丟丌丆().Item[val_9];
            return (int)val_10;
        }
        
        val_10 = 0;
        return (int)val_10;
    }
    public static void 丘丈丈上丗丛丛东丟(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, int 丁丕上丕与丟丌丛上)
    {
        int val_6;
        ExitGames.Client.Photon.Hashtable val_7;
        var val_8;
        val_6 = 丁丕上丕与丟丌丛上;
        val_7 = 专丞上七七且丝七丗;
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 == null)
        {
                return;
        }
        
        if(val_1.丑丗三丛丛丆丟丌丆() == null)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        ExitGames.Client.Photon.Hashtable val_5 = null;
        val_7 = val_5;
        val_5 = new ExitGames.Client.Photon.Hashtable();
        val_6 = val_6;
        val_5.set_Item(key:  专业下丏丂丞丝丝东.丄丕东业丘丌业三丒 + val_7.业丐丐三丕一丗丛丁(), value:  val_6);
        val_1.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_5, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private static 专业下丏丂丞丝丝东()
    {
        专业下丏丂丞丝丝东.丝三万丑丁专丂上丂 = "Turn";
        专业下丏丂丞丝丝东.丈业不丑丕丒丄丁世 = "TStart";
        专业下丏丂丞丝丝东.丄丕东业丘丌业三丒 = "FToA";
    }

}
