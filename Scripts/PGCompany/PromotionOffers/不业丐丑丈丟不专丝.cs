using UnityEngine;

namespace PGCompany.PromotionOffers
{
    internal class 不业丐丑丈丟不专丝
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.丅丘丒丒丒丌丅三丏, System.Type> 丏一丁与丂丗丞与专;
        
        // Methods
        internal static PGCompany.PromotionOffersGenerators.丟丅丞丂丂世丄丐东 丗丘上一不下丙与万(PGCompany.丅丘丒丒丒丌丅三丏 丐丅丒专丛丏上与业)
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            if((PGCompany.PromotionOffers.不业丐丑丈丟不专丝.丏一丁与丂丗丞与专.ContainsKey(key:  丐丅丒专丛丏上与业)) != false)
            {
                    val_7 = null;
                val_7 = null;
                object val_3 = System.Activator.CreateInstance(type:  PGCompany.PromotionOffers.不业丐丑丈丟不专丝.丏一丁与丂丗丞与专.Item[丐丅丒专丛丏上与业]);
                if(val_3 == null)
            {
                    return (PGCompany.PromotionOffersGenerators.丟丅丞丂丂世丄丐东)val_8;
            }
            
                var val_4 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (PGCompany.PromotionOffersGenerators.丟丅丞丂丂世丄丐东.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
                return (PGCompany.PromotionOffersGenerators.丟丅丞丂丂世丄丐东)val_8;
            }
            
            if(丐丅丒专丛丏上与业 != 0)
            {
                    丆丟丟三丗东一丆三.丅丟丝丏七业下丟丗(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "Need implement ClanStorePromotionGenerateHandler for {0}", arg0:  丐丅丒专丛丏上与业));
            }
            
            val_8 = 0;
            return (PGCompany.PromotionOffersGenerators.丟丅丞丂丂世丄丐东)val_8;
        }
        public 不业丐丑丈丟不专丝()
        {
        
        }
        private static 不业丐丑丈丟不专丝()
        {
            System.Collections.Generic.Dictionary<PGCompany.丅丘丒丒丒丌丅三丏, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丅丘丒丒丒丌丅三丏, System.Type>();
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.PromotionOffers.不业丐丑丈丟不专丝.丏一丁与丂丗丞与专 = val_1;
        }
    
    }

}
