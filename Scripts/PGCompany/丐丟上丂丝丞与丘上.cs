using UnityEngine;

namespace PGCompany
{
    internal static class 丐丟上丂丝丞与丘上
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.丆一丁丏三万丑东不, System.Type> 世丂上丌丞且丁七丏;
        internal static System.Collections.Generic.Dictionary<PGCompany.专丟专世丅丂丁且专, PGCompany.丌与世世丆丄丞丌世> 丝丆万丅丗丄业上丕;
        
        // Methods
        internal static PGCompany.丌与世世丆丄丞丌世 下丙丗丟丂下丏不丟(PGCompany.StorePromotionPurchaseSettings 与不丕丆丈不丙丟丛, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            PGCompany.东丑丆丗丏丐丟下丄 val_11;
            var val_12;
            var val_13;
            var val_14;
            PGCompany.专丟专世丅丂丁且专 val_15;
            var val_16;
            var val_17;
            val_11 = 且丘丏丁丑与丙与丁;
            val_12 = null;
            val_12 = null;
            if((PGCompany.丐丟上丂丝丞与丘上.世丂上丌丞且丁七丏.ContainsKey(key:  与不丕丆丈不丙丟丛.Type)) != false)
            {
                    val_13 = null;
                val_13 = null;
                object val_3 = System.Activator.CreateInstance(type:  PGCompany.丐丟上丂丝丞与丘上.世丂上丌丞且丁七丏.Item[与不丕丆丈不丙丟丛.Type]);
                mem[32] = 与不丕丆丈不丙丟丛;
                val_14 = 0;
                mem[24] = val_11;
                val_15 = val_11.七丈丒丒下下且万与();
                if((PGCompany.丐丟上丂丝丞与丘上.丝丆万丅丗丄业上丕.ContainsKey(key:  val_15)) != false)
            {
                    val_16 = null;
                val_16 = null;
                PGCompany.丌与世世丆丄丞丌世 val_7 = PGCompany.丐丟上丂丝丞与丘上.丝丆万丅丗丄业上丕.Item[val_11.七丈丒丒下下且万与()];
                val_15 = val_11.七丈丒丒下下且万与();
                bool val_9 = PGCompany.丐丟上丂丝丞与丘上.丝丆万丅丗丄业上丕.Remove(key:  val_15);
            }
            
                val_17 = null;
                val_17 = null;
                val_11 = val_11.七丈丒丒下下且万与();
                PGCompany.丐丟上丂丝丞与丘上.丝丆万丅丗丄业上丕.set_Item(key:  val_11, value:  0);
                return (PGCompany.丌与世世丆丄丞丌世)val_14;
            }
            
            val_14 = 0;
            return (PGCompany.丌与世世丆丄丞丌世)val_14;
        }
        private static 丐丟上丂丝丞与丘上()
        {
            System.Collections.Generic.Dictionary<PGCompany.丆一丁丏三万丑东不, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丆一丁丏三万丑东不, System.Type>();
            val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  5, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  6, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  7, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  8, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  10, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  12, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  13, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  15, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  14, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  16, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  18, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  19, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  21, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  20, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  22, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  23, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  25, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  24, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  27, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.丐丟上丂丝丞与丘上.世丂上丌丞且丁七丏 = val_1;
            PGCompany.丐丟上丂丝丞与丘上.丝丆万丅丗丄业上丕 = new System.Collections.Generic.Dictionary<PGCompany.专丟专世丅丂丁且专, PGCompany.丌与世世丆丄丞丌世>();
        }
    
    }

}
