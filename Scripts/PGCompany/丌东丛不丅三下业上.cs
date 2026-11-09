using UnityEngine;

namespace PGCompany
{
    internal static class 丌东丛不丅三下业上
    {
        // Fields
        private static System.Collections.Generic.List<丙且上东下丏丏丟下> 三丞丒丘三万丙业与;
        
        // Methods
        private static PGCompany.上丕丈丞一丟丟丛丂 丙一东下丐业丂上丗(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
        {
            var val_12;
            string val_13;
            var val_14;
            val_12 = 一业一丕丅下业世与;
            val_13 = val_12.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛();
            System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_4 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丐丕业丙丗业丏丛且(下丅丙一丂丗丅丝七:  val_13);
            if(val_4.Count < 1)
            {
                goto label_5;
            }
            
            HashSet.Enumerator<T> val_6 = val_4.GetEnumerator();
            val_14 = 0;
            goto label_9;
            label_10:
            val_13 = 0.丐丏七丌丕丗业且上();
            if(val_13.不业丙丒丂丞下丆丙() < 5)
            {
                    val_14 = mem[106031776 + (val_8) << 2];
                val_14 = 106031776 + (val_8) << 2;
            }
            
            label_9:
            if(((-790082520) & 1) != 0)
            {
                goto label_10;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (PGCompany.上丕丈丞一丟丟丛丂)(val_12.业不东丞丘且且一丟() != true) ? 6 : 0;
            label_5:
            val_12 = val_12.丐上下三丑丈丑丄丟();
            return (PGCompany.上丕丈丞一丟丟丛丂)(val_12.业不东丞丘且且一丟() != true) ? 6 : 0;
        }
        internal static PGCompany.上丕丈丞一丟丟丛丂 丌不丂丙丂丝丌丅丈(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
        {
            PGCompany.丟丝东丈丐丙三下丛 val_8;
            CategoryNames val_9;
            val_8 = 一业一丕丅下业世与;
            丌东丛不丅三下业上.丝丂下丂丐丄丁丑丄 val_1 = new 丌东丛不丅三下业上.丝丂下丂丐丄丁丑丄();
            if(val_1 != null)
            {
                    val_9 = val_1;
                .一业一丕丅下业世与 = val_8;
            }
            else
            {
                    val_9 = 16;
                mem[16] = val_8;
                val_8 = mem[16];
            }
            
            if((PGCompany.丌东丛不丅三下业上.丙一东下丐业丂上丗(一业一丕丅下业世与:  val_8)) != 0)
            {
                    return (PGCompany.上丕丈丞一丟丟丛丂)((上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(万丞丛东丑丑丅一业:  System.Collections.Generic.List<CategoryNames> val_3 = new System.Collections.Generic.List<CategoryNames>(), 丙丑丄与丅丐一不东:  true).Exists(match:  System.Predicate<丙且上东下丏丏丟下> val_5 = static_value_081D9E68)) != true) ? 7 : 0;
            }
            
            if(val_3 != null)
            {
                    val_3.Add(item:  val_9);
            }
            else
            {
                    val_3.Add(item:  val_9);
            }
            
            val_3.Add(item:  88);
            val_5 = new System.Predicate<丙且上东下丏丏丟下>(object:  val_1, method:  System.Boolean 丌东丛不丅三下业上.丝丂下丂丐丄丁丑丄::不丏丘丐丑上丅七不(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
            return (PGCompany.上丕丈丞一丟丟丛丂)((上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(万丞丛东丑丑丅一业:  val_3, 丙丑丄与丅丐一不东:  true).Exists(match:  val_5)) != true) ? 7 : 0;
        }
        internal static void 丌三丗丞一丐丆丅万()
        {
            var val_3;
            System.Collections.Generic.List<CategoryNames> val_1 = new System.Collections.Generic.List<CategoryNames>();
            if(val_1 != null)
            {
                    val_1.Add(item:  0);
                val_1.Add(item:  1);
                val_1.Add(item:  2);
                val_1.Add(item:  3);
                val_1.Add(item:  4);
                val_1.Add(item:  5);
            }
            else
            {
                    val_1.Add(item:  0);
                val_1.Add(item:  1);
                val_1.Add(item:  2);
                val_1.Add(item:  3);
                val_1.Add(item:  4);
                val_1.Add(item:  5);
            }
            
            val_1.Add(item:  88);
            val_3 = null;
            val_3 = null;
            PGCompany.丌东丛不丅三下业上.三丞丒丘三万丙业与 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(万丞丛东丑丑丅一业:  val_1, 丙丑丄与丅丐一不东:  true);
        }
        internal static PGCompany.上丕丈丞一丟丟丛丂 不与与丈丝丌丑丒丞(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
        {
            PGCompany.丟丝东丈丐丙三下丛 val_6;
            var val_8;
            val_6 = 一业一丕丅下业世与;
            丌东丛不丅三下业上.世丞丒丅一专丌丐丏 val_1 = new 丌东丛不丅三下业上.世丞丒丅一专丌丐丏();
            if(val_1 != null)
            {
                    .一业一丕丅下业世与 = val_6;
            }
            else
            {
                    mem[16] = val_6;
                val_6 = mem[16];
            }
            
            if((PGCompany.丌东丛不丅三下业上.丙一东下丐业丂上丗(一业一丕丅下业世与:  val_6)) != 0)
            {
                    return (PGCompany.上丕丈丞一丟丟丛丂)((PGCompany.丌东丛不丅三下业上.三丞丒丘三万丙业与.Exists(match:  System.Predicate<丙且上东下丏丏丟下> val_3 = static_value_081D9E68)) != true) ? 7 : 0;
            }
            
            val_8 = null;
            val_8 = null;
            val_3 = new System.Predicate<丙且上东下丏丏丟下>(object:  val_1, method:  System.Boolean 丌东丛不丅三下业上.世丞丒丅一专丌丐丏::世丈丂东丙不丄丛丟(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
            return (PGCompany.上丕丈丞一丟丟丛丂)((PGCompany.丌东丛不丅三下业上.三丞丒丘三万丙业与.Exists(match:  val_3)) != true) ? 7 : 0;
        }
        private static 丌东丛不丅三下业上()
        {
            PGCompany.丌东丛不丅三下业上.三丞丒丘三万丙业与 = new System.Collections.Generic.List<丙且上东下丏丏丟下>();
        }
    
    }

}
