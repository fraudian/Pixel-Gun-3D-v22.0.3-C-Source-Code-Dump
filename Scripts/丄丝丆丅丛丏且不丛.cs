using UnityEngine;
public static class 丄丝丆丅丛丏且不丛
{
    // Methods
    public static PunTeams.丅一丏丐丕丕丌丝专 丈下丁丄丆丟丏丁专(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_4;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().TryGetValue(key:  "team", value: out  0)) != false)
        {
                val_4 = 127;
            return (丅一丏丐丕丕丌丝专)val_4;
        }
        
        val_4 = 0;
        return (丅一丏丐丕丕丌丝专)val_4;
    }
    public static void 与东丏与丅业丕丆丗(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, PunTeams.丅一丏丐丕丕丌丝专 七一丞丈万丛下丘上)
    {
        与丅丕丈丘东丝世丟 val_7 = 专丞上七七且丝七丗;
        if(丅丒丗丑丒丙丛不丆.七丛丏丐丁三丈丑专() != false)
        {
                if(((丄丝丆丅丛丏且不丛.丈下丁丄丆丟丏丁专(专丞上七七且丝七丗:  val_7 = 专丞上七七且丝七丗)) & 255) == 七一丞丈万丛下丘上)
        {
                return;
        }
        
            ExitGames.Client.Photon.Hashtable val_4 = new ExitGames.Client.Photon.Hashtable();
            val_4.Add(key:  "team", value:  七一丞丈万丛下丘上);
            val_7.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_4, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            return;
        }
        
        val_7 = System.String.Format(format:  "JoinTeam was called in state: {0}. Not connectedAndReady.", arg0:  丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌());
        UnityEngine.Debug.LogWarning(message:  val_7);
    }

}
