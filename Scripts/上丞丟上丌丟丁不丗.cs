using UnityEngine;
internal sealed class 上丞丟上丌丟丁不丗
{
    // Methods
    internal static LobbyButton.丕丌专丙世业业丑丝 丈丛七丐丏丘丕下丕(LobbyButton.丈七丄丟丞丝丟丂丗 上且丁万丝世三丄丂)
    {
        if(上且丁万丝世三丄丂 == 2)
        {
                return 上丞丟上丌丟丁不丗.丘丄七七业不丛丌丆();
        }
        
        if(上且丁万丝世三丄丂 == 3)
        {
                return 上丞丟上丌丟丁不丗.东丞丌丄东丄丘专丒();
        }
        
        if(上且丁万丝世三丄丂 == 4)
        {
                return 上丞丟上丌丟丁不丗.世且业丆七丂丁不东();
        }
        
        return (丕丌专丙世业业丑丝)((上丞丟上丌丟丁不丗.专且丝丞丂丕丒丐七(上且丁万丝世三丄丂:  上且丁万丝世三丄丂)) != true) ? 3 : (0 + 1);
    }
    public static string 丌丈丛丁世下丁丅丆(LobbyButton.丈七丄丟丞丝丟丂丗 上且丁万丝世三丄丂)
    {
        var val_3;
        if(上且丁万丝世三丄丂 > 18)
        {
                if(上且丁万丝世三丄丂 != 24)
        {
                return (string)(上且丁万丝世三丄丂 == 25) ? "feature.pixelpass" : "";
        }
        
            val_3 = "feature.craft";
            return (string)(上且丁万丝世三丄丂 == 25) ? "feature.pixelpass" : "";
        }
        
        if((上且丁万丝世三丄丂 - 3) > 7)
        {
                return (string)(上且丁万丝世三丄丂 == 25) ? "feature.pixelpass" : "";
        }
        
        var val_3 = 106027168 + ((上且丁万丝世三丄丂 - 3)) << 2;
        val_3 = val_3 + 106027168;
        goto (106027168 + ((上且丁万丝世三丄丂 - 3)) << 2 + 106027168);
    }
    public static int 世丟专丟丝七丅丐不(LobbyButton.丈七丄丟丞丝丟丂丗 上且丁万丝世三丄丂)
    {
        int val_2 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  上丞丟上丌丟丁不丗.丌丈丛丁世下丁丅丆(上且丁万丝世三丄丂:  上且丁万丝世三丄丂));
        return (int)(val_2 == 2147483647) ? 0 : (val_2);
    }
    public static int 世丟专丟丝七丅丐不(string 世丞世上万业丆丙丂)
    {
        int val_1 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  世丞世上万业丆丙丂);
        return (int)(val_1 == 2147483647) ? 0 : (val_1);
    }
    public static bool 专且丝丞丂丕丒丐七(LobbyButton.丈七丄丟丞丝丟丂丗 上且丁万丝世三丄丂)
    {
        int val_2 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  上丞丟上丌丟丁不丗.丌丈丛丁世下丁丅丆(上且丁万丝世三丄丂:  上且丁万丝世三丄丂));
        bool val_4 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  (val_2 == 2147483647) ? 0 : (val_2));
        val_4 = (~val_4) & 1;
        return (bool)val_4;
    }
    private static LobbyButton.丕丌专丙世业业丑丝 世且业丆七丂丁不东()
    {
        var val_12;
        var val_13;
        if((上丞丟上丌丟丁不丗.专且丝丞丂丕丒丐七(上且丁万丝世三丄丂:  4)) != false)
        {
                val_13 = 3;
            return (丕丌专丙世业业丑丝)val_13;
        }
        
        val_12 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        if(((val_12.丂三丞下专一下丛万(且下丕七丙丗丄不七:  100)) == null) || (PixelTime.丝业丁丌丘东丏世与() == false))
        {
            goto label_9;
        }
        
        val_12 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        if((val_12.丞上丌丌丕丘专丒丕(且下丕七丙丗丄不七:  100)) > 0)
        {
            goto label_13;
        }
        
        val_12 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        if((val_12.丌下丘上东与下丌丐(且下丕七丙丗丄不七:  100)) == false)
        {
            goto label_17;
        }
        
        label_13:
        val_13 = 1;
        return (丕丌专丙世业业丑丝)val_13;
        label_9:
        val_13 = 4;
        return (丕丌专丙世业业丑丝)val_13;
        label_17:
        var val_11 = (((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂且丕丒丟一上专上(且下丕七丙丗丄不七:  100)) & true) != 0) ? (1 + 1) : 1;
        return (丕丌专丙世业业丑丝)val_13;
    }
    private static LobbyButton.丕丌专丙世业业丑丝 东丞丌丄东丄丘专丒()
    {
        var val_14;
        var val_15;
        val_14 = 3;
        if((上丞丟上丌丟丁不丗.专且丝丞丂丕丒丐七(上且丁万丝世三丄丂:  3)) == true)
        {
                return (丕丌专丙世业业丑丝)val_14;
        }
        
        val_15 = 200;
        if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  200)) != null)
        {
            goto label_5;
        }
        
        val_15 = 300;
        if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  44)) == null)
        {
            goto label_12;
        }
        
        label_5:
        if(PixelTime.丝业丁丌丘东丏世与() != false)
        {
                if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丞上丌丌丕丘专丒丕(且下丕七丙丗丄不七:  44)) <= 0)
        {
                if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌下丘上东与下丌丐(且下丕七丙丗丄不七:  44)) == false)
        {
            goto label_20;
        }
        
        }
        
            val_14 = 1;
            return (丕丌专丙世业业丑丝)val_14;
        }
        
        label_12:
        val_14 = 4;
        return (丕丌专丙世业业丑丝)val_14;
        label_20:
        var val_13 = (((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂且丕丒丟一上专上(且下丕七丙丗丄不七:  44)) & true) != 0) ? (1 + 1) : 1;
        return (丕丌专丙世业业丑丝)val_14;
    }
    private static LobbyButton.丕丌专丙世业业丑丝 丘丄七七业不丛丌丆()
    {
        var val_4;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
                return (丕丌专丙世业业丑丝)(PGCompany.丁东丌世与丕东丆上.丟丟丙业与丒业丆三() != true) ? 3 : (0 + 1);
        }
        
        val_4 = 3;
        return (丕丌专丙世业业丑丝)(PGCompany.丁东丌世与丕东丆上.丟丟丙业与丒业丆三() != true) ? 3 : (0 + 1);
    }
    public 上丞丟上丌丟丁不丗()
    {
    
    }

}
