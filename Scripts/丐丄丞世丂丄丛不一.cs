using UnityEngine;
internal static class 丐丄丞世丂丄丛不一
{
    // Fields
    internal const string 与万上丐丗丙丌东丆 = "feature.taskbook";
    internal const string 世业丂丂丙下不丈三 = "feature.pets";
    internal const string 一专丟业上丒与丆丏 = "feature.gallery";
    internal const string 与丁业丌业丟与丑丂 = "feature.battlepass";
    internal const string 丅丄七丄丆上丂丄七 = "feature.pixelpass";
    internal const string 一专与丕丌丁丙丙万 = "feature.friends";
    internal const string 东丘丐丈丙世丝丒业 = "feature.squad";
    internal const string 丞与不七丗丙丌丛东 = "feature.clans";
    internal const string 东世下丆丅丐丌丅丆 = "feature.trader";
    internal const string 丕丟丒万不业丟业丅 = "feature.tournament";
    internal const string 丌三且三丈丙丑与上 = "feature.craft";
    internal const string 丆万丙专与丆与丗丂 = "feature.mailbox";
    internal const string 丞与丕丏丌丈丘七业 = "feature.piggy";
    internal const string 丅丒丝万丟丝丛与且 = "feature.modules";
    internal const string 丄丄不丗丛丁世丛万 = "feature.threechests";
    internal const string 丒世丞丈丗东丝世不 = "feature.roulette";
    internal const string 丗丙丁丙丝丕丏东丒 = "feature.private";
    internal const string 丄与丗与上丕丁不丐 = "feature.loadout";
    internal const string 一丑下丏丒万不丘丛 = "feature.thirdloadout";
    internal const string 丏丞丞丑上不不丌丕 = "feature.eggsdelivery";
    internal const string 丄万丏丑不三丁三丆 = "feature.adschest";
    internal const string 丂丈丗丂且一丛丒丆 = "feature.misc";
    internal const string 丞一丒丕丅且丁丄万 = "feature.subscription20";
    internal const string 丅丈丁专丆丄不丌丌 = "feature.brawl";
    internal const string 丈一七与丞上丆丂上 = "gamemode";
    internal const string 业丘丈下七丆丕东且 = "map";
    
    // Methods
    internal static string 丛丙丄丄万丟丌下上(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        string[] val_1 = new string[2];
        val_1[0] = "gamemode";
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_1[1] = 上且丗一丏丏万丅丌.ToString();
        return (string)TagSystem.专与丈上丅上丘东万.丅丌丕三丞且世且丗(三万丟丁万丄一三丛:  val_1).ToLower();
    }
    internal static string 丛丙丄丄万丟丌下上(string 上且丗一丏丏万丅丌)
    {
        string[] val_1 = new string[2];
        val_1[0] = "gamemode";
        val_1[1] = 上且丗一丏丏万丅丌;
        string val_2 = TagSystem.专与丈上丅上丘东万.丅丌丕三丞且世且丗(三万丟丁万丄一三丛:  val_1);
        if(val_2 != null)
        {
                return val_2.ToLower();
        }
        
        return val_2.ToLower();
    }
    internal static string 丙丏上丙丙丘上且丁(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, SceneInfo 东下丌丝且七丛丘丒, bool 丁丏丗且上丗下与下 = False)
    {
        var val_4;
        Rilisoft.七丕丟丏三丈一丄世 val_5;
        if(东下丌丝且七丛丘丒 == 0)
        {
                return 丐丄丞世丂丄丛不一.丛丙丄丄万丟丌下上(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌);
        }
        
        if(上且丗一丏丏万丅丌 == 20)
        {
                val_4 = 丁丏丗且上丗下与下;
            val_5 = 20;
            return 丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  val_5 = 上且丗一丏丏万丅丌, 专万丟三世业丙丈且:  东下丌丝且七丛丘丒.丙且上丒不下丑下丞(), 丁丏丗且上丗下与下:  false);
        }
        
        val_4 = 0;
        return 丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  val_5, 专万丟三世业丙丈且:  东下丌丝且七丛丘丒.丙且上丒不下丑下丞(), 丁丏丗且上丗下与下:  false);
    }
    internal static string 丙丏上丙丙丘上且丁(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 专万丟三世业丙丈且, bool 丁丏丗且上丗下与下 = False)
    {
        System.String[] val_7;
        System.String[] val_8;
        string val_9;
        val_7 = 丁丏丗且上丗下与下;
        string[] val_1 = new string[3];
        val_8 = val_1;
        val_8[0] = "map";
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_8[1] = 上且丗一丏丏万丅丌.ToString();
        val_8[2] = 专万丟三世业丙丈且;
        val_9 = TagSystem.专与丈上丅上丘东万.丅丌丕三丞且世且丗(三万丟丁万丄一三丛:  val_1);
        if(val_7 == false)
        {
                return (string)val_9.ToLower();
        }
        
        string[] val_4 = new string[1];
        val_7 = val_4;
        val_8 = "squad";
        val_7[0] = val_8;
        val_9 = TagSystem.专与丈上丅上丘东万.世一丂丌丛且丝一丘(丆万一不丌且东丐丐:  val_9, 三万丟丁万丄一三丛:  val_4);
        return (string)val_9.ToLower();
    }
    internal static string 丘不下世丑且丘一丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 专万丟三世业丙丈且, string 丒万丟丅丌丝丟下下)
    {
        string[] val_1 = new string[2];
        string val_2 = 丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 专万丟三世业丙丈且:  专万丟三世业丙丈且, 丁丏丗且上丗下与下:  false);
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = 丒万丟丅丌丝丟下下;
        string val_3 = TagSystem.专与丈上丅上丘东万.丅丌丕三丞且世且丗(三万丟丁万丄一三丛:  val_1);
        if(val_3 != null)
        {
                return val_3.ToLower();
        }
        
        return val_3.ToLower();
    }
    internal static bool 世丕丕丗丗下丕丆世(string 丆万一不丌且东丐丐)
    {
        return 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(东丐丐丝业三丅丅丆:  ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丑且丁不丅丅上东东(丆万一不丌且东丐丐:  丆万一不丌且东丐丐));
    }
    internal static bool 世丕丕丗丗下丕丆世(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        return 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丛丙丄丄万丟丌下上(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌));
    }
    internal static bool 世丕丕丗丗下丕丆世(ExpOpenSystem.丅一丐丌与丄上三丗 东丐丐丝业三丅丅丆)
    {
        if(东丐丐丝业三丅丅丆 == null)
        {
                return (bool)东丐丐丝业三丅丅丆;
        }
        
        return 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  东丐丐丝业三丅丅丆.Progress);
    }
    internal static bool 世丕丕丗丗下丕丆世(int 上丕丈丞丌丘丅不与)
    {
        return (bool)(ExperienceController.丂丂下丑且下丌丝东() >= 上丕丈丞丌丘丅不与) ? 1 : 0;
    }
    internal static int 丒与丆三丟三丈丄丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        return 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丛丙丄丄万丟丌下上(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌));
    }
    internal static int 丒与丆三丟三丈丄丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, SceneInfo 东下丌丝且七丛丘丒)
    {
        return 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒, 丁丏丗且上丗下与下:  false));
    }
    internal static int 丒与丆三丟三丈丄丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, SceneInfo 东下丌丝且七丛丘丒, bool 丁丏丗且上丗下与下)
    {
        return 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒, 丁丏丗且上丗下与下:  丁丏丗且上丗下与下));
    }
    internal static int 丒与丆三丟三丈丄丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 专万丟三世业丙丈且)
    {
        return 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 专万丟三世业丙丈且:  专万丟三世业丙丈且, 丁丏丗且上丗下与下:  false));
    }
    internal static int 丒与丆三丟三丈丄丄(string 丆万一不丌且东丐丐)
    {
        string val_7 = 丆万一不丌且东丐丐;
        if((ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丑且丁不丅丅上东东(丆万一不丌且东丐丐:  val_7 = 丆万一不丌且东丐丐)) == null)
        {
                return 2147483647;
        }
        
        val_7 = ???;
        return 2147483647;
    }
    internal static int 三丛丕丆一丆丆业丂(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        return 丐丄丞世丂丄丛不一.三丛丕丆一丆丆业丂(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丛丙丄丄万丟丌下上(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌));
    }
    internal static int 三丛丕丆一丆丆业丂(string 丆万一不丌且东丐丐)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_5;
        if((ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丑且丁不丅丅上东东(丆万一不丌且东丐丐:  丆万一不丌且东丐丐)) != null)
        {
                val_5 = val_2.Progress;
        }
        
        System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_3 = 丐丄丞世丂丄丛不一.七三世丂丛丙丅七业(上丕丈丞丌丘丅不与:  val_5);
        return (int)val_3.Value.GetHashCode();
    }
    internal static int 东丁七丝丝东万丐下(int 丈丘丝一丗下丈丐不)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = 0;
        val_4 = 0;
        goto label_1;
        label_9:
        if(val_3 >= 91667)
        {
                return (int)val_4;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = (ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  0)) + val_4;
        val_3 = 1;
        label_1:
        val_6 = null;
        val_6 = null;
        int val_2 = ExperienceController.上业丆丘丟丐且丘丝.丛丄三万丁丙丐丞丂();
        if(val_3 < 丈丘丝一丗下丈丐不)
        {
            goto label_9;
        }
        
        return (int)val_4;
    }
    internal static System.Collections.Generic.KeyValuePair<int, int> 七三世丂丛丙丅七业(int 上丕丈丞丌丘丅不与)
    {
        int val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = 上丕丈丞丌丘丅不与;
        val_6 = 0;
        val_7 = 0;
        goto label_1;
        label_12:
        val_8 = null;
        val_8 = null;
        if(val_5 < (ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  137113600)))
        {
            goto label_5;
        }
        
        val_9 = null;
        val_9 = null;
        val_5 = val_5 - (ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  137113600));
        val_6 = 137113601;
        val_7 = 137113600;
        label_1:
        val_10 = null;
        val_10 = null;
        if(val_6 < ExperienceController.上业丆丘丟丐且丘丝.丛丄三万丁丙丐丞丂())
        {
            goto label_12;
        }
        
        goto label_13;
        label_5:
        val_7 = 137113600;
        label_13:
        DiscreteVector2 val_4 = new DiscreteVector2(三丟东丕丄丄下下丑:  137113600, 丒丒丄丁且丄丆丂丌:  val_5);
        return (System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>)val_4._x;
    }
    internal static int 东丁七丝丝东万丐下(System.Collections.Generic.KeyValuePair<int, int> 东丒丕丐万丏丄丄下)
    {
        return (int)1152921525886574312 + (丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  东丒丕丐万丏丄丄下.Value.GetHashCode()));
    }
    internal static string 丑与丏且丅丄丙丑与(string 丐丁不丆丘丂丐丈丆)
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = 丐丁不丆丘丂丐丈丆;
        val_11 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) == true)
        {
                return (string)val_11;
        }
        
        PGCompany.东丑丒丗一丞下丙丙<T> val_3 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
        val_12 = 0;
        val_11 = 0;
        if((TagSystem.专与丈上丅上丘东万.下业下上丞且业上不(丆万一不丌且东丐丐:  val_10, 专丂丕丗丗东世丞下: ref  val_3)) == false)
        {
            goto label_18;
        }
        
        val_12 = 0;
        bool val_6 = val_3.Item[0].Equals(value:  "feature");
        if(val_3 == 0)
        {
            goto label_12;
        }
        
        if(val_6 == false)
        {
            goto label_13;
        }
        
        label_17:
        if(val_3.Count < 2)
        {
            goto label_14;
        }
        
        val_12 = public System.String System.Collections.Generic.List<System.String>::get_Item(int index);
        val_13 = 1;
        goto label_16;
        label_12:
        if(val_6 == true)
        {
            goto label_17;
        }
        
        label_13:
        val_12 = public System.String System.Collections.Generic.List<System.String>::get_Item(int index);
        val_13 = 0;
        label_16:
        val_11 = val_3.Item[0];
        goto label_18;
        label_14:
        val_11 = 0;
        label_18:
        PGCompany.东丑丒丗一丞下丙丙<T> val_9 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
        val_10 = val_3;
        return (string)val_11;
    }

}
