using UnityEngine;

namespace PGCompany
{
    internal static class 丁东丌世与丕东丆上
    {
        // Fields
        private static string[] 丅下丏丁丆丗丙下下;
        private static readonly System.Collections.Generic.Dictionary<PGCompany.专丙不不丟万丏一丘, Progress.与丄东丄丘丐丙丅业> 万丑下东上且丟三丞;
        internal static PGCompany.三东丏不丗世丅丌丄 丘下丂上世丗世丘丞;
        internal const int 丒丁业且下与丄丞丌 = 99999;
        
        // Properties
        internal static string 丈七不丑丏丟丘丏丑 { get; }
        internal static string 三七丅丗丛丒丑丂丐 { get; }
        internal static string 丁万丟世世世丈东丗 { get; }
        internal static string 上三丒丛丝丈丄丑七 { get; }
        internal static int 丘丄世丂上三丁丅丂 { get; }
        internal static int 东丒丏丛专丕上丘丛 { get; }
        internal static int 丘丈一丄丘不世丄丗 { get; }
        internal static int 上丙丌丅丒丟丘丛丈 { get; }
        internal static int 专丈且丒丆丙丟一丈 { get; }
        
        // Methods
        internal static string 丛不丝丆与不丌与七()
        {
            return PGCompany.丁东丌世与丕东丆上.丒上且丐丝丁丙丘丆(丑丅世丐丒丏丐三丅:  0);
        }
        internal static string 丈丝丘丑丞丗丐丒丆()
        {
            return PGCompany.丁东丌世与丕东丆上.丒上且丐丝丁丙丘丆(丑丅世丐丒丏丐三丅:  1);
        }
        internal static string 丟三万不丁丝七丘丗()
        {
            return PGCompany.丁东丌世与丕东丆上.丒上且丐丝丁丙丘丆(丑丅世丐丒丏丐三丅:  2);
        }
        internal static string 丆世上丆丌不世且丄()
        {
            return PGCompany.丁东丌世与丕东丆上.丒上且丐丝丁丙丘丆(丑丅世丐丒丏丐三丅:  3);
        }
        internal static int 丗专丝万上丑下丛一()
        {
            return 120;
        }
        internal static int 万丏丌丑下上丑一下()
        {
            return 180;
        }
        internal static int 七丏丐专丈下与世丏()
        {
            return 180;
        }
        internal static int 丒丂丆丟丛丙且丕丁()
        {
            return 180;
        }
        internal static int 专一不且丄丅万丗业()
        {
            return 180;
        }
        private static string 丒上且丐丝丁丙丘丆(int 丑丅世丐丒丏丐三丅)
        {
            int val_14;
            var val_15;
            var val_16;
            System.Char[] val_17;
            var val_18;
            string val_19;
            var val_20;
            var val_21;
            val_14 = 丑丅世丐丒丏丐三丅;
            val_15 = null;
            val_15 = null;
            if((ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世() == null) || (val_1.丞上世三一七专万丟 == null))
            {
                goto label_31;
            }
            
            val_16 = 0;
            goto label_7;
            label_26:
            if(val_1.丞上世三一七专万丟.Item[0] != null)
            {
                    ExpOpenSystem.丅一丐丌与丄上三丗 val_3 = val_1.丞上世三一七专万丟.Item[0];
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3.Tag)) != true)
            {
                    ExpOpenSystem.丅一丐丌与丄上三丗 val_5 = val_1.丞上世三一七专万丟.Item[0];
                char[] val_6 = new char[1];
                val_17 = val_6;
                val_18 = ".";
                if("." == null)
            {
                    val_18 = ".";
            }
            
                val_17[0] = Chars[0];
                System.String[] val_8 = val_5.Tag.Split(separator:  val_6);
                if(((val_8 != null) && (val_8.Length >= 2)) && ((System.String.op_Inequality(a:  val_8[0], b:  "map")) != true))
            {
                    val_17 = val_8.Length;
                var val_15 = -4294967296;
                val_15 = val_15 + ((val_8.Length) << 32);
                val_15 = val_15 >> 32;
                val_19 = val_8[val_15];
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_19)) != true)
            {
                    int val_16 = val_14;
                if(val_16 == 0)
            {
                    return (string)val_19;
            }
            
                val_16 = val_16 - 1;
            }
            
            }
            
            }
            
            }
            
            val_16 = 1;
            label_7:
            if(val_16 < val_1.丞上世三一七专万丟.Count)
            {
                goto label_26;
            }
            
            if((val_14 & 2147483648) == 0)
            {
                    val_16 = 1152921505641934848;
                val_20 = null;
                val_20 = null;
                if((PGCompany.丁东丌世与丕东丆上.丒丁业且下与丄丞丌 + 24) > val_14)
            {
                    val_21 = null;
                val_21 = null;
                int val_12 = PGCompany.丁东丌世与丕东丆上.丒丁业且下与丄丞丌 + (((long)(int)(丑丅世丐丒丏丐三丅)) << 3);
                val_19 = mem[(PGCompany.丁东丌世与丕东丆上.丒丁业且下与丄丞丌 + ((long)(int)(丑丅世丐丒丏丐三丅)) << 3) + 32];
                val_19 = (PGCompany.丁东丌世与丕东丆上.丒丁业且下与丄丞丌 + ((long)(int)(丑丅世丐丒丏丐三丅)) << 3) + 32;
                return (string)val_19;
            }
            
            }
            
            label_31:
            val_19 = PGCompany.丁东丌世与丕东丆上.丒丁业且下与丄丞丌 + 32;
            return (string)val_19;
        }
        internal static bool 丆与丑世下丅下丒不(out bool 东专丈丅丙丐丒与丌)
        {
            bool val_32;
            var val_33;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  20)) == false)
            {
                goto label_32;
            }
            
            }
            
            if((((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  20)) == false) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  120)) == true)) || ((System.String.Equals(a:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), b:  PGCompany.丁东丌世与丕东丆上.丛不丝丆与不丌与七(), comparisonType:  5)) == false))
            {
                goto label_11;
            }
            
            val_32 = 0;
            goto label_12;
            label_11:
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  20)) != false)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  120)) == false)
            {
                goto label_32;
            }
            
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) != false)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  64)) == false)
            {
                goto label_32;
            }
            
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  164)) != false)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  108)) == false)
            {
                goto label_32;
            }
            
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  108)) != false)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  52)) == false)
            {
                goto label_32;
            }
            
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  52)) != false)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  152)) == false)
            {
                goto label_32;
            }
            
            }
            
            val_32 = 0;
            val_33 = 0;
            goto label_33;
            label_32:
            val_32 = true;
            label_12:
            val_33 = 1;
            label_33:
            东专丈丅丙丐丒与丌 = val_32;
            return (bool)val_33;
        }
        internal static bool 丂世一丞丗与丂丐且(PGCompany.专丙不不丟万丏一丘 丞丅上丏丂且下丅与)
        {
            Progress.丐丒丞丅丝丅丑与丘 val_1 = Progress.七七世万专丕丁上业.专一丑万丙专丂丞一();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  丞丅上丏丂且下丅与);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  丞丅上丏丂且下丅与);
        }
        internal static bool 丂万丄与世丌丑东丞(PGCompany.专丙不不丟万丏一丘 不七丆万丁一丞七下)
        {
            PGCompany.专丙不不丟万丏一丘 val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = 不七丆万丁一丞七下;
            if(val_12 == 2300)
            {
                    return PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁();
            }
            
            if(val_12 == 1100)
            {
                    if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  1)) != false)
            {
                    val_12 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
                var val_5 = ((val_12.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  1)) > 0) ? 1 : 0;
                return (bool)val_13;
            }
            
            }
            
            val_14 = null;
            val_14 = null;
            if((PGCompany.丁东丌世与丕东丆上.万丑下东上且丟三丞.ContainsKey(key:  val_12)) != false)
            {
                    val_15 = null;
                val_15 = null;
                val_12 = null;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  PGCompany.丁东丌世与丕东丆上.万丑下东上且丟三丞.Item[val_12]));
                var val_10 = (null != 0) ? 1 : 0;
                return (bool)val_13;
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        internal static string 丁且丅丕专与丅且丄(string 丟丘不丒上丐丗与丅)
        {
            return (string)((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  8)) != true) ? "gift" : 丟丘不丒上丐丗与丅;
        }
        internal static PGCompany.三东丏不丗世丅丌丄 七东且东丕丟三下丘(PGCompany.三东丏不丗世丅丌丄 丘丅丝东丏丄丛丛与)
        {
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  8)) == false)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)丘丅丝东丏丄丛丛与;
            }
            
            PGCompany.丌三上丈丗丏丆万丆 val_5 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().下丗一丆丄万丟丕丂(不七丆万丁一丞七下:  8).丏丘下丞丘不丑万丏();
            丘丅丝东丏丄丛丛与 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_5.StepsSettings.ItemsParams);
            return (PGCompany.三东丏不丗世丅丌丄)丘丅丝东丏丄丛丛与;
        }
        internal static System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 东丆与且丝且丕丝丕(System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 丒丝丟丑丙丄且专且)
        {
            System.Collections.Generic.IEnumerable<T> val_14;
            var val_15;
            var val_16;
            PGCompany.三东丏不丗世丅丌丄 val_17;
            var val_18;
            var val_19;
            val_14 = 丒丝丟丑丙丄且专且;
            val_15 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_15.丘东丐业丅上东丏下(不七丆万丁一丞七下:  208)) == false)
            {
                    return (System.Collections.Generic.List<Rilisoft.GameEventItemContainer>)val_14;
            }
            
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_3 = null;
            val_15 = val_3;
            val_3 = new System.Collections.Generic.List<Rilisoft.GameEventItemContainer>();
            val_3.AddRange(collection:  val_14);
            PGCompany.丌三上丈丗丏丆万丆 val_6 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().下丗一丆丄万丟丕丂(不七丆万丁一丞七下:  208).丏丘下丞丘不丑万丏();
            val_16 = null;
            val_16 = null;
            val_17 = PGCompany.丁东丌世与丕东丆上.丘下丂上世丗世丘丞;
            if((val_17 != null) && (val_17.丕丐一丙专丛丒丑万() != false))
            {
                    val_18 = null;
            }
            else
            {
                    val_18 = null;
                val_18 = null;
                PGCompany.丁东丌世与丕东丆上.丘下丂上世丗世丘丞 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.三东丏不丗世丅丌丄>(丑东与丅丐丅丂丞业:  val_6.StepsSettings.ItemsParams);
            }
            
            val_18 = null;
            if(PGCompany.丁东丌世与丕东丆上.丘下丂上世丗世丘丞 != null)
            {
                    val_14 = val_15;
                if(PGCompany.丁东丌世与丕东丆上.丘下丂上世丗世丘丞.丕丐一丙专丛丒丑万() == false)
            {
                    return (System.Collections.Generic.List<Rilisoft.GameEventItemContainer>)val_14;
            }
            
                Rilisoft.GameEventItemData val_10 = new Rilisoft.GameEventItemData();
                val_19 = null;
                val_19 = null;
                if(val_10 == null)
            {
                    val_19 = null;
            }
            
                .ItemParams = PGCompany.丁东丌世与丕东丆上.丘下丂上世丗世丘丞;
                .PresettedCount = PGCompany.丁东丌世与丕东丆上.丘下丂上世丗世丘丞.丂丁丏一丙丛业且丌();
                Rilisoft.GameEventItemContainerData val_12 = null;
                val_17 = val_12;
                val_12 = new Rilisoft.GameEventItemContainerData();
                if(val_17 != null)
            {
                    .ContainerId = 99999;
                .DropCategory = 10;
            }
            else
            {
                    mem[16] = 99999;
                mem[24] = 10;
            }
            
                (Rilisoft.GameEventItemContainerData)[1152921556078002160].Items.Add(item:  val_10);
                val_3.Add(item:  new Rilisoft.GameEventItemContainer(一丐丗丁丞丆丅丟丄:  val_12));
            }
            
            val_14 = val_15;
            return (System.Collections.Generic.List<Rilisoft.GameEventItemContainer>)val_14;
        }
        internal static int 万东丆一丘丛一丁不(int 丐东业丕丕丂丗丅丙, System.Nullable<Rilisoft.丛且世丐丆上七业丁.FreeSpin.七专丁东丘丈丄丐丐> 丁丅丈丌丟世丗丗丟)
        {
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丘东丐业丅上东丏下(不七丆万丁一丞七下:  208)) != false)
            {
                    return 0;
            }
            
            Rilisoft.三一丈七且丄与丝东 val_3 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_3 != null)
            {
                    return val_3.丝丌丙丝万下万丅丒(丐东业丕丕丂丗丅丙:  丐东业丕丕丂丗丅丙, 丁丅丈丌丟世丗丗丟:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = 丁丅丈丌丟世丗丗丟.HasValue});
            }
            
            return val_3.丝丌丙丝万下万丅丒(丐东业丕丕丂丗丅丙:  丐东业丕丕丂丗丅丙, 丁丅丈丌丟世丗丗丟:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = 丁丅丈丌丟世丗丗丟.HasValue});
        }
        internal static bool 与丆丁丞与丄丕丂丅(int 丐东业丕丕丂丗丅丙, System.Nullable<Rilisoft.丛且世丐丆上七业丁.FreeSpin.七专丁东丘丈丄丐丐> 丁丅丈丌丟世丗丗丟)
        {
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丘东丐业丅上东丏下(不七丆万丁一丞七下:  208)) != false)
            {
                    return false;
            }
            
            Rilisoft.三一丈七且丄与丝东 val_3 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_3 != null)
            {
                    return val_3.业不丕丐丐不专丏且(丐东业丕丕丂丗丅丙:  丐东业丕丕丂丗丅丙, 丁丅丈丌丟世丗丗丟:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = 丁丅丈丌丟世丗丗丟.HasValue});
            }
            
            return val_3.业不丕丐丐不专丏且(丐东业丕丕丂丗丅丙:  丐东业丕丕丂丗丅丙, 丁丅丈丌丟世丗丗丟:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = 丁丅丈丌丟世丗丗丟.HasValue});
        }
        internal static void 丕丞专丘业三世一丘(ref int 一七东丑丘世丑丙不, ref int 丛丏丟万世丐丒丛丁, ref int 丈上下与丌丘丅丙丒)
        {
            PGCompany.丁东丌世与丕东丆上.丕丞专丘业三世一丘(三下丒三专丑丗丁丕: ref  new 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false});
            if(((-68103336) & 1) != 0)
            {
                    一七东丑丘世丑丙不 = -68103336;
            }
            
            if(((-68103336) & 1) != 0)
            {
                    丛丏丟万世丐丒丛丁 = 丆丒丘丐下丞丛上丈();
            }
            
            if(((-68103336) & 1) == 0)
            {
                    return;
            }
            
            丈上下与丌丘丅丙丒 = -68103336;
        }
        internal static void 丕丞专丘业三世一丘(ref 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 三下丒三专丑丗丁丕)
        {
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  20)) == false)
            {
                goto label_13;
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  120)) == false)
            {
                goto label_11;
            }
            
            if((((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  64)) == false) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  108)) == false)) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  52)) == false))
            {
                goto label_13;
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  152)) != false)
            {
                    return;
            }
            
            label_11:
            label_13:
            1152921556078564512 = ???;
            goto label_13;
        }
        internal static void 业丈丏丘不丈一丘丛(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丑上与且丏专万丝专)
        {
            var val_5;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_16;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  208)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = 丑上与且丏专万丝专.GetEnumerator();
            label_18:
            if(((-67744272) & 1) == 0)
            {
                goto label_4;
            }
            
            val_16 = val_5.丐丏七丌丕丗业且上();
            if((((val_16.ContainsKey(key:  "Type")) == false) || ((System.String.op_Inequality(a:  val_16.Item["Type"], b:  "gameEvent")) == true)) || ((val_16.ContainsKey(key:  "ID")) == false))
            {
                goto label_18;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_13 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(丟丟丄专上丟丁丐丝:  val_16.Item["ID"]);
            if((val_13 == null) || (val_13.不业丙丒丂丞下丆丙() != 100))
            {
                goto label_18;
            }
            
            goto label_19;
            label_4:
            val_16 = 0;
            label_19:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丑上与且丏专万丝专.Clear();
            if(val_16 == 0)
            {
                    return;
            }
            
            丑上与且丏专万丝专.Add(item:  val_16 = 0);
        }
        internal static bool 丞一上丌丏下丛丅丁()
        {
            var val_7;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  20)) != true)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  120)) == false)
            {
                goto label_3;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
            label_3:
            val_7 = (~(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  64))) & 1;
            return (bool)val_7;
        }
        internal static bool 上丘丈专丝丞与丏丐()
        {
            string val_13;
            var val_14;
            var val_16;
            var val_18;
            var val_19;
            val_13 = 东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗();
            if((System.String.op_Inequality(a:  val_13, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == false)
            {
                goto label_21;
            }
            
            val_13 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丞丞丟专七丛丟丝丟();
            val_14 = null;
            val_14 = null;
            if((丁东丌世与丕东丆上.<>c.<>9__35_0) == null)
            {
                goto label_7;
            }
            
            label_26:
            if((val_13.Exists(match:  丁东丌世与丕东丆上.<>c.<>9__35_0)) == true)
            {
                goto label_9;
            }
            
            val_16 = null;
            val_13 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丞丞丟专七丛丟丝丟();
            val_16 = null;
            if((丁东丌世与丕东丆上.<>c.<>9__35_1) == null)
            {
                goto label_13;
            }
            
            label_30:
            if((val_13.Exists(match:  丁东丌世与丕东丆上.<>c.<>9__35_1)) == false)
            {
                goto label_21;
            }
            
            val_18 = null;
            val_18 = null;
            val_13 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_13 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_13 == 0)
            {
                goto label_21;
            }
            
            label_9:
            val_19 = 0;
            return (bool)val_19;
            label_21:
            val_19 = 1;
            return (bool)val_19;
            label_7:
            丁东丌世与丕东丆上.<>c.<>9__35_0 = new System.Predicate<PGCompany.丕丒丒丞丛丐东与下>(object:  丁东丌世与丕东丆上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁东丌世与丕东丆上.<>c::丘丌丌丈且丏三上东(PGCompany.丕丒丒丞丛丐东与下 三丟东丕丄丄下下丑));
            if(val_13 != null)
            {
                goto label_26;
            }
            
            goto label_26;
            label_13:
            丁东丌世与丕东丆上.<>c.<>9__35_1 = new System.Predicate<PGCompany.丕丒丒丞丛丐东与下>(object:  丁东丌世与丕东丆上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁东丌世与丕东丆上.<>c::丁丟丝一且丞丙丗丂(PGCompany.丕丒丒丞丛丐东与下 三丟东丕丄丄下下丑));
            if(val_13 != null)
            {
                goto label_30;
            }
            
            goto label_30;
        }
        internal static bool 丆业业丙丅丂丂丗东()
        {
            bool val_2 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220);
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
        internal static bool 丁丒丟上东下世丑丛()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
        }
        internal static bool 一丘且丑丟丒丗丐丏()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
        }
        internal static bool 丗丗丗丝丏丂丁丕下()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  176);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  176);
        }
        internal static bool 且丏下丂专丞不丂丞()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
        }
        internal static bool 丙一丏东万七丐业丕()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
        }
        internal static void 万丏丘三丞丝万丁丙(ref double 丂三丟丂丈丐丆丗丟)
        {
            float val_14;
            double val_15;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  20)) == false)
            {
                goto label_2;
            }
            
            val_14 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            val_15 = 120;
            goto label_7;
            label_2:
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  120)) != true)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  64)) != true)
            {
                    if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  108)) == false)
            {
                goto label_13;
            }
            
            }
            
            }
            
            label_22:
            val_14 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            val_15 = 180;
            label_7:
            val_15 = val_14 + val_15;
            丂三丟丂丈丐丆丗丟 = val_15;
            return;
            label_13:
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  52)) == false)
            {
                    return;
            }
            
            if(GameConnect.丛下丆三丌七丐丙且() == true)
            {
                goto label_22;
            }
        
        }
        internal static bool 丑丞丙丕丛丏丅丁七()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_18;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  108)) != false)
            {
                    val_14 = (~(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  52))) & 1;
            }
            else
            {
                    val_14 = 0;
            }
            
            val_15 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丞丞丟专七丛丟丝丟();
            val_16 = null;
            val_16 = null;
            if((丁东丌世与丕东丆上.<>c.<>9__43_0) == null)
            {
                goto label_8;
            }
            
            label_15:
            bool val_8 = val_15.Exists(match:  丁东丌世与丕东丆上.<>c.<>9__43_0);
            val_8 = val_14 | val_8;
            if(val_8 == false)
            {
                goto label_10;
            }
            
            val_18 = 0;
            goto label_11;
            label_8:
            丁东丌世与丕东丆上.<>c.<>9__43_0 = new System.Predicate<PGCompany.丕丒丒丞丛丐东与下>(object:  丁东丌世与丕东丆上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁东丌世与丕东丆上.<>c::一丕丆丂丑丂东丁三(PGCompany.丕丒丒丞丛丐东与下 三丟东丕丄丄下下丑));
            if(val_15 != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_10:
            val_15 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            bool val_11 = val_15.丟丂下七且七东丛丞(不七丆万丁一丞七下:  52);
            val_18 = val_11 ^ 1;
            label_11:
            val_11 = val_18;
            return (bool)val_11;
        }
        internal static bool 丝丟三且一丝下丞丕()
        {
            var val_25;
            UnityEngine.Object val_26;
            var val_27;
            var val_29;
            var val_30;
            var val_31;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  108)) != false)
            {
                    val_25 = (~(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  52))) & 1;
            }
            else
            {
                    val_25 = 0;
            }
            
            val_26 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丞丞丟专七丛丟丝丟();
            val_27 = null;
            val_27 = null;
            if((丁东丌世与丕东丆上.<>c.<>9__44_0) == null)
            {
                goto label_8;
            }
            
            label_15:
            bool val_8 = val_26.Exists(match:  丁东丌世与丕东丆上.<>c.<>9__44_0);
            val_8 = val_25 | val_8;
            if(val_8 == false)
            {
                goto label_10;
            }
            
            val_29 = 1;
            return (bool)val_29;
            label_8:
            丁东丌世与丕东丆上.<>c.<>9__44_0 = new System.Predicate<PGCompany.丕丒丒丞丛丐东与下>(object:  丁东丌世与丕东丆上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁东丌世与丕东丆上.<>c::丁丞下丗丕下丘专丅(PGCompany.丕丒丒丞丛丐东与下 三丟东丕丄丄下下丑));
            if(val_26 != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_10:
            if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() != false)
            {
                    val_30 = (~PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁()) & 1;
            }
            else
            {
                    val_30 = 0;
            }
            
            if((PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() != false) && (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙() != null))
            {
                    val_31 = val_14.三与上七业丟丞丙丛.丈丐丞丐上丑且丕万();
            }
            else
            {
                    val_31 = 0;
            }
            
            val_26 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_26.丟丂下七且七东丛丞(不七丆万丁一丞七下:  152)) != false)
            {
                    val_26 = Initializer.丑七不且上丗丁一世();
                if(val_26 != 0)
            {
                    if((PixelTime.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
            {
                    var val_22 = ((val_31 | val_30) != 0) ? 1 : 0;
                return (bool)val_29;
            }
            
            }
            
            }
            
            val_29 = 0;
            return (bool)val_29;
        }
        internal static bool 丗不上丒丙七丆丏东()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
        }
        internal static bool 东丙不丛世丅丂丐世()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丆丂丄丌丝丅上业丒();
            }
            
            return val_1.丆丂丄丌丝丅上业丒();
        }
        internal static bool 丛丈丂丝丁丘不丁东()
        {
            bool val_2 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  164);
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
        internal static bool 丑丅不一不七丒业业()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  52);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  52);
        }
        internal static bool 七上丁丕东丝丈丆丙()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  164);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  164);
        }
        internal static bool 丗一一丂万业一丛丗(System.Collections.Generic.Dictionary<string, object> 丂丈丗丄不丅丅丙丒)
        {
            var val_14;
            var val_15;
            val_14 = 丂丈丗丄不丅丅丙丒;
            object val_5 = 0;
            object val_8 = 0;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  8)) != false)
            {
                    val_15 = 1;
                if(val_14 == null)
            {
                    return (bool)val_15;
            }
            
                if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  108)) == true)
            {
                    return (bool)val_15;
            }
            
                if(((((val_14.TryGetValue(key:  "Type", value: out  val_5)) != false) && (val_5 != 0)) && (1179403647 == null)) && ((System.String.op_Inequality(a:  val_5, b:  "offer")) != true))
            {
                    if(((val_14.TryGetValue(key:  "offer-module", value: out  val_8)) != false) && (val_8 != 0))
            {
                    if(1179403647 == null)
            {
                goto label_12;
            }
            
            }
            
            }
            
                val_15 = 1;
                return (bool)val_15;
            }
            
            val_15 = 0;
            return (bool)val_15;
            label_12:
            System.Nullable<T> val_11 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<OfferModule>(下业七不丑丂丏丟东:  (1179403647 == null) ? (val_8) : 0, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-65430768) & 1) == 0)
            {
                    return (bool)val_15;
            }
            
            var val_13 = (val_11.HasValue.丙东专丂世丈丏丁丂() != 130) ? 1 : 0;
            return (bool)val_15;
        }
        internal static bool 三丘世东一丌上一与()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  108);
        }
        internal static void 丛专丁世丐丑丐丌丂(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, ref int 丛且丞与丕业下丏丞, in bool 世丆丏七且业下丅专)
        {
            if(上且丗一丏丏万丅丌 != 20)
            {
                    return;
            }
            
            丛且丞与丕业下丏丞 = 1;
        }
        internal static bool 丕丆万一丅丄业世丌()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
        }
        internal static bool 丛不丆丕且丗丏丑丒()
        {
            if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
            {
                    return false;
            }
            
            PGCompany.丗三万丁三丗上专丟 val_2 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_2 != null)
            {
                    return val_2.丟丂下七且七东丛丞(不七丆万丁一丞七下:  152);
            }
            
            return val_2.丟丂下七且七东丛丞(不七丆万丁一丞七下:  152);
        }
        internal static bool 丅世专业下不丞丝七()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  20);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  20);
        }
        internal static bool 丈万丅不丗七丛上与()
        {
            string val_7;
            var val_8;
            var val_9;
            UnityEngine.Transform val_10;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  120)) == false)
            {
                goto label_2;
            }
            
            val_7 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_7.丟丂下七且七东丛丞(不七丆万丁一丞七下:  64)) == false)
            {
                goto label_4;
            }
            
            val_8 = 0;
            return (bool)val_8;
            label_2:
            val_7 = PGCompany.丁东丌世与丕东丆上.丈丝丘丑丞丗丐丒丆();
            val_9 = null;
            val_9 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟 != null) && (null != 0))
            {
                    val_10 = transform;
            }
            else
            {
                    val_10 = 0;
            }
            
            上丐丛丗丑三万丘专.丒丟丐丞丘丂专丘丙(丞丁丑丏丄丏七丂不:  val_7, 丈东丘丏与丌东东下:  val_10, 丂丛丑东不丅丈一东:  2);
            goto label_13;
            label_4:
            上丐丛丗丑三万丘专.丛丄丆一且丏丂下丆();
            label_13:
            val_8 = 1;
            return (bool)val_8;
        }
        internal static bool 丟丟丙业与丒业丆三()
        {
            bool val_2 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  164);
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
        private static 丁东丌世与丕东丆上()
        {
            string[] val_1 = new string[4];
            val_1[0] = "NuclearCity";
            val_1[1] = "Paradise";
            val_1[2] = "Pool";
            val_1[3] = "shipped";
            PGCompany.丁东丌世与丕东丆上.丒丁业且下与丄丞丌 = val_1;
            PGCompany.丁东丌世与丕东丆上.万丑下东上且丟三丞 = new System.Collections.Generic.Dictionary<PGCompany.专丙不不丟万丏一丘, Progress.与丄东丄丘丐丙丅业>();
        }
    
    }

}
