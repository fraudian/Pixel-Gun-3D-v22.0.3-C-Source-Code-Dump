using UnityEngine;

namespace PGCompany
{
    internal class 丕丗东七丄七下丝丟
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.丝丗丁丞丒且丙丑丙, System.Type> 丙丒七丂世丈上丂丒;
        
        // Methods
        internal static PGCompany.丕丟万东丐丕世丄丑 下丙丗丟丂下丏不丟(PGCompany.StorePromotionPurchaseSettings 与不丕丆丈不丙丟丛, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            PGCompany.丝丗丁丞丒且丙丑丙 val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = 且丘丏丁丑与丙与丁;
            val_9 = null;
            val_9 = null;
            if((PGCompany.丕丗东七丄七下丝丟.丙丒七丂世丈上丂丒.ContainsKey(key:  val_8.不业丙丒丂丞下丆丙())) != false)
            {
                    val_10 = null;
                val_10 = null;
                val_8 = val_8.不业丙丒丂丞下丆丙();
                object val_5 = System.Activator.CreateInstance(type:  PGCompany.丕丗东七丄七下丝丟.丙丒七丂世丈上丂丒.Item[val_8]);
                if(val_5 == null)
            {
                    return (PGCompany.丕丟万东丐丕世丄丑)val_11;
            }
            
                var val_6 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (PGCompany.丕丟万东丐丕世丄丑.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_5) : 0;
                return (PGCompany.丕丟万东丐丕世丄丑)val_11;
            }
            
            PGCompany.丝丗丁丞丒且丙丑丙 val_7 = val_8.不业丙丒丂丞下丆丙();
            val_11 = 0;
            return (PGCompany.丕丟万东丐丕世丄丑)val_11;
        }
        public 丕丗东七丄七下丝丟()
        {
        
        }
        private static 丕丗东七丄七下丝丟()
        {
            System.Collections.Generic.Dictionary<PGCompany.丝丗丁丞丒且丙丑丙, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丝丗丁丞丒且丙丑丙, System.Type>();
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.丕丗东七丄七下丝丟.丙丒七丂世丈上丂丒 = val_1;
        }
    
    }

}
