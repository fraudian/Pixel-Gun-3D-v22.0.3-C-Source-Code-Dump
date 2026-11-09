using UnityEngine;

namespace PGCompany
{
    internal static class 上三世丝丕专丂丟丌
    {
        // Fields
        private static readonly float 丅丝不丁丁丑不丏专;
        internal static readonly string 丝万丄专与丙丙东丑;
        internal static readonly string 东丟丄丛一上不丛万;
        internal static readonly string 不丗丄丗七世丞世丕;
        
        // Methods
        internal static bool 丒丏丕七世丞丞且丞()
        {
            var val_22;
            PGCompany.ClanMiniBuffConfig val_23;
            PGCompany.三东丏不丗世丅丌丄 val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            val_22 = null;
            val_22 = null;
            if((Progress.七七世万专丕丁上业.业丌丌丈丑不丕业丅().丕丕丛丝丘丐三丒不(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.丝万丄专与丙丙东丑)) != false)
            {
                    return PGCompany.上三世丝丕专丂丟丌.丛丐上丙丁且世丁丝();
            }
            
            if(PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().世丈丁业丛上丘丗丐() != null)
            {
                    val_23 = val_4.ClanMiniBuffConfig;
            }
            else
            {
                    val_23 = 0;
            }
            
            val_24 = 1152921525544440992;
            val_25 = 0;
            if((val_23 == 0) || ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.与七世丝上丗丄丌丗()) == false))
            {
                goto label_46;
            }
            
            int val_8 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丅丙丛万不且一丟();
            if((val_8 < 1) || (val_8 > val_23.PromotionClanLootBoxTimeUntilEnd))
            {
                goto label_25;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_11 = null;
            val_24 = val_11;
            val_11 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  "clan_lootbox_point_buff");
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_11, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
            {
                goto label_25;
            }
            
            val_26 = null;
            if(PGCompany.上三世丝丕专丂丟丌.世下不丝上东丄丅丅() == false)
            {
                goto label_25;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  228);
            val_27 = null;
            val_27 = null;
            val_24 = PGCompany.上三世丝丕专丂丟丌.丝万丄专与丙丙东丑;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万丘丁丝七丅专丏与(下上丐丆丝丟丝丒不:  val_24, 丐丅一丘丟丄丑三丏:  new System.Nullable<System.Int32>() {HasValue = false});
            if((专且丝丄丙丗丈不丞.丆与丏丞丟丙丁丒不(万丁世丌丁丌丆万丟:  val_23.PromotionClanLootBoxChance)) != false)
            {
                    val_28 = null;
                val_28 = null;
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万丘丁丝七丅专丏与(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.东丟丄丛一上不丛万, 丐丅一丘丟丄丑三丏:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            val_23 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_23.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            val_25 = null;
            bool val_20 = PGCompany.上三世丝丕专丂丟丌.丛丐上丙丁且世丁丝();
            goto label_46;
            label_25:
            val_25 = 0;
            label_46:
            val_25 = val_25 & 1;
            return (bool)val_25;
        }
        private static bool 丛丐上丙丁且世丁丝()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = Progress.七七世万专丕丁上业.业丌丌丈丑不丕业丅();
            val_7 = null;
            val_7 = null;
            if((val_6.丕丕丛丝丘丐三丒不(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.东丟丄丛一上不丛万)) != false)
            {
                    val_8 = null;
                val_6 = Progress.七七世万专丕丁上业.业丌丌丈丑不丕业丅();
                val_8 = null;
                val_9 = (val_6.丕丕丛丝丘丐三丒不(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.不丗丄丗七世丞世丕)) ^ 1;
                return (bool)val_9 & 1;
            }
            
            val_9 = 0;
            return (bool)val_9 & 1;
        }
        internal static bool 丏丞丕不且七丌万丙()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((Progress.七七世万专丕丁上业.业丌丌丈丑不丕业丅().丕丕丛丝丘丐三丒不(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.东丟丄丛一上不丛万)) == false)
            {
                    return false;
            }
            
            PGCompany.专万丏丁丐丐丞丕丈 val_3 = Progress.七七世万专丕丁上业.业丌丌丈丑不丕业丅();
            val_5 = null;
            val_5 = null;
            if(val_3 != null)
            {
                    return val_3.丕丕丛丝丘丐三丒不(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.不丗丄丗七世丞世丕);
            }
            
            return val_3.丕丕丛丝丘丐三丒不(下上丐丆丝丟丝丒不:  PGCompany.上三世丝丕专丂丟丌.不丗丄丗七世丞世丕);
        }
        internal static bool 丗上世丗丒丌丗上丅()
        {
            return (bool)((PGCompany.上三世丝丕专丂丟丌.丗丌业世丁且一丄与(丟上丂专丁下上丏三:  false)) < 0) ? 1 : 0;
        }
        internal static bool 世下不丝上东丄丅丅()
        {
            var val_4 = 0;
            if((PGCompany.上三世丝丕专丂丟丌.丗丌业世丁且一丄与(丟上丂专丁下上丏三:  false)) >= 0)
            {
                    return (bool)((PGCompany.上三世丝丕专丂丟丌.丗丌业世丁且一丄与(丟上丂专丁下上丏三:  true)) >= 1f) ? 1 : 0;
            }
            
            return (bool)((PGCompany.上三世丝丕专丂丟丌.丗丌业世丁且一丄与(丟上丂专丁下上丏三:  true)) >= 1f) ? 1 : 0;
        }
        internal static int 上丈丂专七专东丈专(bool 丟上丂专丁下上丏三 = False)
        {
            var val_18;
            System.Predicate<PGCompany.东丑丆丗丏丐丟下丄> val_20;
            var val_21;
            var val_22;
            var val_23;
            System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_2 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.不丁万丗丐下丗东丂();
            val_18 = null;
            val_18 = null;
            val_20 = 上三世丝丕专丂丟丌.<>c.<>9__9_0;
            if(val_20 == null)
            {
                goto label_4;
            }
            
            label_24:
            PGCompany.东丑丆丗丏丐丟下丄 val_3 = val_2.Find(match:  val_20);
            if(val_3 == null)
            {
                    return (int)val_21;
            }
            
            val_20 = val_3;
            if(val_20.业东丅东丌上丗丑不() != 8015)
            {
                goto label_8;
            }
            
            val_20 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = false});
            if(val_3.三丘丆丅丝丙一丑与() != null)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            val_22 = 0;
            label_12:
            val_23 = val_22.丂万丞与丈丙丅丝七();
            if(丟上丂专丁下上丏三 != false)
            {
                    float val_17 = (float)val_23;
                val_17 = PGCompany.上三世丝丕专丂丟丌.三丈丈与丂不三七丑() * val_17;
                val_23 = UnityEngine.Mathf.CeilToInt(f:  val_17);
            }
            
            float val_18 = (float)val_23;
            val_18 = ((float)val_20 / (float)val_3.丂丁丏一丙丛业且丌()) * val_18;
            val_21 = 0;
            int val_15 = UnityEngine.Mathf.FloorToInt(f:  val_18);
            return (int)val_21;
            label_4:
            上三世丝丕专丂丟丌.<>c.<>9__9_0 = new System.Predicate<PGCompany.东丑丆丗丏丐丟下丄>(object:  上三世丝丕专丂丟丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 上三世丝丕专丂丟丌.<>c::丘且丟丞万丆万万东(PGCompany.东丑丆丗丏丐丟下丄 三丟东丕丄丄下下丑));
            if(val_2 != null)
            {
                goto label_24;
            }
            
            goto label_24;
            label_8:
            val_21 = 0;
            return (int)val_21;
        }
        internal static int 上七丛丈七七上丑且()
        {
            var val_13;
            var val_15;
            var val_16;
            System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_2 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.不丁万丗丐下丗东丂();
            val_13 = null;
            val_13 = null;
            if((上三世丝丕专丂丟丌.<>c.<>9__10_0) == null)
            {
                goto label_4;
            }
            
            label_17:
            val_16 = val_2.Find(match:  上三世丝丕专丂丟丌.<>c.<>9__10_0);
            if(val_16 == null)
            {
                    return (int)val_15;
            }
            
            if(val_16.业东丅东丌上丗丑不() != 9015)
            {
                goto label_8;
            }
            
            val_16 = val_16.丂丁丏一丙丛业且丌();
            val_15 = 0;
            int val_10 = UnityEngine.Mathf.Max(a:  0, b:  val_16 - (PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  55), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})));
            return (int)val_15;
            label_4:
            上三世丝丕专丂丟丌.<>c.<>9__10_0 = new System.Predicate<PGCompany.东丑丆丗丏丐丟下丄>(object:  上三世丝丕专丂丟丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 上三世丝丕专丂丟丌.<>c::丅业丞三一七东丕丙(PGCompany.东丑丆丗丏丐丟下丄 三丟东丕丄丄下下丑));
            if(val_2 != null)
            {
                goto label_17;
            }
            
            goto label_17;
            label_8:
            val_15 = 0;
            return (int)val_15;
        }
        internal static float 丗丌业世丁且一丄与(bool 丟上丂专丁下上丏三 = False)
        {
            var val_4 = null;
            int val_1 = PGCompany.上三世丝丕专丂丟丌.上七丛丈七七上丑且();
            if(val_1 == 0)
            {
                    return 1f;
            }
            
            float val_4 = (float)val_1;
            val_4 = ((float)PGCompany.上三世丝丕专丂丟丌.上丈丂专七专东丈专(丟上丂专丁下上丏三:  丟上丂专丁下上丏三)) / val_4;
            return UnityEngine.Mathf.Max(a:  0f, b:  val_4);
        }
        internal static float 三丈丈与丂不三七丑()
        {
            var val_8;
            float val_9;
            var val_10;
            val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.上丙业丕丟与七专丁 val_2 = val_8.一丌世丑丄东丞丘三<PGCompany.上丙业丕丟与七专丁>(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  "clan_lootbox_point_buff");
            val_9 = 1f;
            if(val_2 == null)
            {
                    return (float)val_9;
            }
            
            val_8 = val_2.世丙万丞上与一丌丅();
            val_10 = null;
            val_10 = null;
            if((上三世丝丕专丂丟丌.<>c.<>9__12_0) == null)
            {
                goto label_5;
            }
            
            label_11:
            PGCompany.三丏不丆丈且丐东与 val_4 = val_8.Find(match:  上三世丝丕专丂丟丌.<>c.<>9__12_0);
            if(val_4 == null)
            {
                    return (float)val_9;
            }
            
            float val_7 = 100f;
            val_7 = (float)val_4.世三丞丅丑丌丈丈一() / val_7;
            val_9 = val_7 + 1f;
            return (float)val_9;
            label_5:
            上三世丝丕专丂丟丌.<>c.<>9__12_0 = new System.Predicate<PGCompany.三丏不丆丈且丐东与>(object:  上三世丝丕专丂丟丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 上三世丝丕专丂丟丌.<>c::东下丅丆丗丌万一丙(PGCompany.三丏不丆丈且丐东与 七丏丄丅丌业与且丙));
            if(val_8 != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        private static 上三世丝丕专丂丟丌()
        {
            PGCompany.上三世丝丕专丂丟丌.丅丝不丁丁丑不丏专 = 0.4f;
            PGCompany.上三世丝丕专丂丟丌.丝万丄专与丙丙东丑 = "cplbpb_c";
            PGCompany.上三世丝丕专丂丟丌.东丟丄丛一上不丛万 = "cplbpb_nw";
            PGCompany.上三世丝丕专丂丟丌.不丗丄丗七世丞世丕 = "cplbpb_a";
        }
    
    }

}
