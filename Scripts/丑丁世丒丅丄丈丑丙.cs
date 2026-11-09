using UnityEngine;
internal static class 丑丁世丒丅丄丈丑丙
{
    // Properties
    private static PGCompany.ClanCommonData 丁丒丆专丘东下下丗 { get; }
    
    // Methods
    private static PGCompany.ClanCommonData 丅三与下不三丛丌丘()
    {
        PGCompany.丛七世丟丐丒丁丕丆 val_1 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世();
        if(val_1 == null)
        {
                return (PGCompany.ClanCommonData)val_1;
        }
        
        return val_1.万丑世丗丐丞下丟丄();
    }
    internal static int 丒丛丌与丗万一丘专(丑丁世丒丅丄丈丑丙.丒丏一世丆世世不丌 丅专与丒丈丗丒丘丌)
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_6;
        var val_7;
        int val_4 = 0;
        if(丑丁世丒丅丄丈丑丙.丅三与下不三丛丌丘() == null)
        {
                return (int)val_7;
        }
        
        if(val_1.ClanTimeRestrictions != null)
        {
                PGCompany.ClanCommonData val_2 = 丑丁世丒丅丄丈丑丙.丅三与下不三丛丌丘();
            val_6 = val_2.ClanTimeRestrictions;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            bool val_5 = val_6.TryGetValue(key:  丅专与丒丈丗丒丘丌.ToString(), value: out  val_4);
            val_7 = val_4;
            return (int)val_7;
        }
        
        val_7 = 0;
        return (int)val_7;
    }
    internal static int 业专丆丗专丐上万丑(string 丁七丙丄丈上丈丘丌)
    {
        var val_5;
        int val_3 = 0;
        if(丑丁世丒丅丄丈丑丙.丅三与下不三丛丌丘() == null)
        {
                return (int)val_5;
        }
        
        if(val_1.ClanTimeRestrictions != null)
        {
                PGCompany.ClanCommonData val_2 = 丑丁世丒丅丄丈丑丙.丅三与下不三丛丌丘();
            bool val_4 = val_2.ClanTimeRestrictions.TryGetValue(key:  丁七丙丄丈上丈丘丌, value: out  val_3);
            val_5 = val_3;
            return (int)val_5;
        }
        
        val_5 = 0;
        return (int)val_5;
    }
    internal static int 七与丑下丅万丗不丞(丑丁世丒丅丄丈丑丙.丒丏一世丆世世不丌 丅专与丒丈丗丒丘丌)
    {
        System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)丑丁世丒丅丄丈丑丙.丒丛丌与丗万一丘专(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌));
        return (int)val_2._ticks.Days;
    }
    internal static int 三万丑丏丅业丂丞东(string 丁七丙丄丈上丈丘丌)
    {
        System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)丑丁世丒丅丄丈丑丙.业专丆丗专丐上万丑(丁七丙丄丈上丈丘丌:  丁七丙丄丈上丈丘丌));
        return (int)val_2._ticks.Days;
    }
    internal static void 丄丄丝丕专丝一丑三(string 丄丒下业一不丈丝丘, int 丆丛且丘万三丟不丐)
    {
        if(丆丛且丘万三丟不丐 >= 2)
        {
                丄丒下业一不丈丝丘 = System.String.alignConst;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  108, 丙业与丙丗丝不丈东:  丄丒下业一不丈丝丘);
    }

}
