using UnityEngine;
public static class 丅丄丑丂一丏丈丆丕
{
    // Methods
    public static void 专三七丞丂三丏丄东(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, int 下七丒丝丛丂丟一下)
    {
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_1.set_Item(key:  "score", value:  下七丒丝丛丂丟一下);
        专丞上七七且丝七丗.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    public static void 三丅七专丌丆万三丑(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, int 不且丘丏三万上丏丁)
    {
        ExitGames.Client.Photon.Hashtable val_3 = new ExitGames.Client.Photon.Hashtable();
        val_3.set_Item(key:  "score", value:  (丅丄丑丂一丏丈丆丕.丛丗七三丄丑丂丗丁(专丞上七七且丝七丗:  专丞上七七且丝七丗)) + 不且丘丏三万上丏丁);
        专丞上七七且丝七丗.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_3, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    public static int 丛丗七三丄丑丂丗丁(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_4;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().TryGetValue(key:  "score", value: out  0)) != false)
        {
                val_4 = 1179403647;
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }

}
