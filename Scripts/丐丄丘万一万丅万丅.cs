using UnityEngine;
public class 丐丄丘万一万丅万丅
{
    // Methods
    internal static 丏下丒东丅丏丌一丛 业业业丈丙上业丗丞(System.Collections.Generic.Dictionary<string, object> 三且丑东与丝丛丐丏)
    {
        string val_29;
        string val_30;
        string val_31;
        bool val_32;
        string val_33;
        string val_34;
        var val_35;
        世且业丝专七丒丒与 val_36;
        string val_37;
        string val_38;
        var val_39;
        val_29 = 三且丑东与丝丛丐丏;
        if(val_29 == null)
        {
            goto label_1;
        }
        
        if((val_29.Item["quest_type"] != null) && (null != null))
        {
                val_30 = 0;
        }
        
        if((System.String.op_Equality(a:  val_30, b:  "finish_match")) == false)
        {
            goto label_4;
        }
        
        val_31 = val_29.Item["map"];
        if((val_31 != null) && (null != null))
        {
                val_31 = 0;
        }
        
        val_32 = System.Convert.ToBoolean(value:  val_29.Item["should_win"]);
        val_33 = val_29.Item["questId"];
        val_34 = val_29.Item["descr_lkey"];
        val_29 = val_29.Item["teacher_emotion"];
        val_35 = null;
        val_36 = new 世且业丝专七丒丒与();
        if((val_33 != null) && (null != val_35))
        {
                val_35 = null;
            val_33 = 0;
        }
        
        if((val_34 != null) && (null != val_35))
        {
                val_35 = null;
            val_34 = 0;
        }
        
        if((val_29 != null) && (null != val_35))
        {
                val_29 = 0;
        }
        
        val_36 = new 世且业丝专七丒丒与(丞丅上丏丂且下丅与:  val_33, 丆丕下丄万丞丁世丛:  val_34, 丑丞丐丐不不与丘业:  val_29, 七丆丂丂下丈且丟世:  val_31, 一丑丗三一丛一丄业:  System.Convert.ToInt32(value:  val_29.Item["count_matches"]), 且丘与丑且丟与丐世:  val_32, 且丒丛与丞世丙丕丌:  System.Convert.ToInt32(value:  val_29.Item["place"]));
        return (丏下丒东丅丏丌一丛)val_36;
        label_1:
        val_36 = 0;
        return (丏下丒东丅丏丌一丛)val_36;
        label_4:
        if((val_29.Item["quest_type"] != null) && (null != null))
        {
                val_37 = 0;
        }
        
        val_36 = 0;
        if((System.String.op_Equality(a:  val_37, b:  "kill_enemies")) == false)
        {
                return (丏下丒东丅丏丌一丛)val_36;
        }
        
        val_31 = System.Convert.ToInt32(value:  val_29.Item["num_kills"]);
        val_32 = System.Convert.ToBoolean(value:  val_29.Item["is_headshot"]);
        val_38 = val_29.Item["questId"];
        val_33 = val_29.Item["descr_lkey"];
        val_29 = val_29.Item["teacher_emotion"];
        val_39 = null;
        val_36 = new 业业丏业业丛丘丄丌();
        if((val_38 != null) && (null != val_39))
        {
                val_39 = null;
            val_38 = 0;
        }
        
        if((val_33 != null) && (null != val_39))
        {
                val_39 = null;
            val_33 = 0;
        }
        
        if((val_29 != null) && (null != val_39))
        {
                val_29 = 0;
        }
        
        val_36 = new 业业丏业业丛丘丄丌(丞丅上丏丂且下丅与:  val_38, 丆丕下丄万丞丁世丛:  val_33, 丑丞丐丐不不与丘业:  val_29, 丙上一丁上专丙丐丒:  val_31, 世不丑不东与东丌丆:  System.Convert.ToInt32(value:  val_29.Item["kills_in_seriya"]), 丝丏丅丗丈丁丁万丛:  val_32);
        return (丏下丒东丅丏丌一丛)val_36;
    }
    public 丐丄丘万一万丅万丅()
    {
    
    }

}
