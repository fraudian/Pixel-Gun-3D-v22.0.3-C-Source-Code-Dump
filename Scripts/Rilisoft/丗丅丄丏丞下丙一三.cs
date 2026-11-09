using UnityEngine;

namespace Rilisoft
{
    internal static class 丗丅丄丏丞下丙一三
    {
        // Fields
        internal static readonly string 丁业世丅丌丛上下与;
        internal static readonly string 丅下丞丗下丒专丅丒;
        internal static readonly string 三上一世与且万丙七;
        internal static readonly string 丞一丟丟东丄丗七丐;
        internal static readonly string 丛丟丗七丈专下下且;
        internal static readonly string 丗一东丏一丌专专丛;
        
        // Methods
        internal static System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Rilisoft.LobbyItemPlayerInfo 丒丝三业丄丞丘业丆, Progress.丐丌丞丐丆丗三下丅 与丄不丌一世东丁丙)
        {
            var val_12;
            string val_13;
            var val_14;
            string val_15;
            var val_16;
            var val_17;
            string val_18;
            var val_19;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            int val_2 = 万丑丙丛不丑且且丄.丗丁七与万丘三与丅(丞丅上丏丂且下丅与:  丒丝三业丄丞丘业丆.InfoId);
            val_12 = null;
            val_12 = null;
            val_13 = Rilisoft.丗丅丄丏丞下丙一三.丁业世丅丌丛上下与;
            val_1.Add(key:  val_13, value:  val_2);
            if((与丄不丌一世东丁丙.东丏丐专万丁与一丞(上丛丛丞且东且丄丘:  val_2)) != false)
            {
                    val_14 = null;
                val_14 = null;
                val_13 = Rilisoft.丗丅丄丏丞下丙一三.丅下丞丗下丒专丅丒;
                val_1.Add(key:  val_13, value:  与丄不丌一世东丁丙.丘与丗丏一且丁丞丂(上丛丛丞且东且丄丘:  val_2));
            }
            
            if(丒丝三业丄丞丘业丆.IsEquiped == false)
            {
                goto label_13;
            }
            
            val_13 = 1152921504618561536;
            val_15 = Rilisoft.丗丅丄丏丞下丙一三.丗一东丏一丌专专丛;
            val_1.Add(key:  val_15, value:  System.Convert.ToInt32(value:  true));
            if(丒丝三业丄丞丘业丆.IsCraftedAndNotShown == false)
            {
                    return val_1;
            }
            
            val_16 = 1;
            val_17 = null;
            val_18 = Rilisoft.丗丅丄丏丞下丙一三.丛丟丗七丈专下下且;
            goto label_28;
            label_13:
            if(丒丝三业丄丞丘业丆.IsCrafted == false)
            {
                goto label_24;
            }
            
            val_16 = 1;
            val_17 = null;
            val_18 = Rilisoft.丗丅丄丏丞下丙一三.丞一丟丟东丄丗七丐;
            label_28:
            int val_6 = System.Convert.ToInt32(value:  true);
            val_15 = val_6;
            label_34:
            val_1.Add(key:  val_18, value:  val_6);
            return val_1;
            label_24:
            if(丒丝三业丄丞丘业丆.CraftStartedTime < 1)
            {
                    return val_1;
            }
            
            val_19 = null;
            val_19 = null;
            int val_8 = 丒丝三业丄丞丘业丆.CraftStartedTime;
            if(val_1 != null)
            {
                goto label_34;
            }
            
            goto label_34;
        }
        internal static Rilisoft.LobbyItemPlayerInfo 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄, Progress.丐丌丞丐丆丗三下丅 与丄不丌一世东丁丙)
        {
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            string val_34;
            var val_35;
            var val_36;
            bool val_37;
            var val_38;
            var val_39;
            bool val_40;
            bool val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            Rilisoft.LobbyItemPlayerInfo val_1 = new Rilisoft.LobbyItemPlayerInfo();
            val_28 = null;
            val_28 = null;
            bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  Rilisoft.丗丅丄丏丞下丙一三.丁业世丅丌丛上下与, 丙业与丙丗丝不丈东: out  0);
            .InfoId = 万丑丙丛不丑且且丄.专一上不三丒上七丏(上丛丛丞且东且丄丘:  0);
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丗丅丄丏丞下丙一三.丅下丞丗下丒专丅丒)) != false)
            {
                    val_29 = null;
                val_29 = null;
                bool val_8 = 与丄不丌一世东丁丙.丝丂丕东专世丅丝丁(上丛丛丞且东且丄丘:  0, 丂三丟丂丈丐丆丗丟:  System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item[Rilisoft.丗丅丄丏丞下丙一三.丅下丞丗下丒专丅丒]), 丞不丌丘三丐丘东东:  true);
            }
            
            val_30 = null;
            val_30 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丗丅丄丏丞下丙一三.丗一东丏一丌专专丛)) != true)
            {
                    val_31 = null;
                val_31 = null;
                if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丗丅丄丏丞下丙一三.丛丟丗七丈专下下且)) != true)
            {
                    val_32 = null;
                val_32 = null;
                if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丗丅丄丏丞下丙一三.丞一丟丟东丄丗七丐)) != false)
            {
                    val_33 = null;
                val_33 = null;
                val_34 = Rilisoft.丗丅丄丏丞下丙一三.三上一世与且万丙七;
                if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  val_34)) != false)
            {
                    .IsCrafted = true;
                return val_1;
            }
            
            }
            
            }
            
            }
            
            val_35 = null;
            val_35 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丗丅丄丏丞下丙一三.丗一东丏一丌专专丛)) != false)
            {
                    val_36 = null;
                val_36 = null;
                val_37 = System.Convert.ToBoolean(value:  一丐丗丁丞丆丅丟丄.Item[Rilisoft.丗丅丄丏丞下丙一三.丗一东丏一丌专专丛]);
            }
            else
            {
                    val_37 = false;
            }
            
            .IsEquiped = val_37;
            val_38 = null;
            val_38 = null;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丗丅丄丏丞下丙一三.丛丟丗七丈专下下且)) != false)
            {
                    val_39 = null;
                val_39 = null;
                val_40 = System.Convert.ToBoolean(value:  一丐丗丁丞丆丅丟丄.Item[Rilisoft.丗丅丄丏丞下丙一三.丛丟丗七丈专下下且]);
            }
            else
            {
                    val_40 = false;
            }
            
            .IsCraftedAndNotShown = val_40;
            if((Rilisoft.LobbyItemPlayerInfo)[1152921543075207248].IsEquiped != false)
            {
                    val_41 = 1;
            }
            else
            {
                    val_42 = null;
                val_42 = null;
                if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  Rilisoft.丗丅丄丏丞下丙一三.丞一丟丟东丄丗七丐)) != false)
            {
                    val_43 = null;
                val_43 = null;
                val_41 = System.Convert.ToBoolean(value:  一丐丗丁丞丆丅丟丄.Item[Rilisoft.丗丅丄丏丞下丙一三.丞一丟丟东丄丗七丐]);
            }
            else
            {
                    val_41 = false;
            }
            
            }
            
            .IsCrafted = val_41;
            val_44 = null;
            val_44 = null;
            val_34 = Rilisoft.丗丅丄丏丞下丙一三.三上一世与且万丙七;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  val_34)) != false)
            {
                    val_45 = null;
                val_45 = null;
                val_34 = Rilisoft.丗丅丄丏丞下丙一三.三上一世与且万丙七;
                val_46 = System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item[val_34]);
            }
            else
            {
                    val_46 = 0;
            }
            
            val_1.CraftStartedTime = 0;
            return val_1;
        }
        private static 丗丅丄丏丞下丙一三()
        {
            Rilisoft.丗丅丄丏丞下丙一三.丁业世丅丌丛上下与 = "i";
            Rilisoft.丗丅丄丏丞下丙一三.丅下丞丗下丒专丅丒 = "b";
            Rilisoft.丗丅丄丏丞下丙一三.三上一世与且万丙七 = "t";
            Rilisoft.丗丅丄丏丞下丙一三.丞一丟丟东丄丗七丐 = "c";
            Rilisoft.丗丅丄丏丞下丙一三.丛丟丗七丈专下下且 = "r";
            Rilisoft.丗丅丄丏丞下丙一三.丗一东丏一丌专专丛 = "e";
        }
    
    }

}
