using UnityEngine;

namespace PGCompany
{
    internal static class 丗三三万世丏与丁专
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.丆一丁丏三万丑东不, System.Type> 世丂上丌丞且丁七丏;
        
        // Methods
        internal static PGCompany.丟丌丛丁丑与丙世丟 下丙丗丟丂下丏不丟(PGCompany.StorePromotionPurchaseSettings 与不丕丆丈不丙丟丛, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            var val_4;
            System.Collections.Generic.Dictionary<PGCompany.丆一丁丏三万丑东不, System.Type> val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = PGCompany.丗三三万世丏与丁专.世丂上丌丞且丁七丏;
            if((val_5.ContainsKey(key:  与不丕丆丈不丙丟丛.Type)) != false)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = PGCompany.丗三三万世丏与丁专.世丂上丌丞且丁七丏;
                if((System.Activator.CreateInstance(type:  val_5.Item[与不丕丆丈不丙丟丛.Type])) == null)
            {
                    return (PGCompany.丟丌丛丁丑与丙世丟)val_7;
            }
            
            }
            
            val_7 = 0;
            return (PGCompany.丟丌丛丁丑与丙世丟)val_7;
        }
        private static 丗三三万世丏与丁专()
        {
            System.Collections.Generic.Dictionary<PGCompany.丆一丁丏三万丑东不, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丆一丁丏三万丑东不, System.Type>();
            val_1.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  6, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  15, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.丗三三万世丏与丁专.世丂上丌丞且丁七丏 = val_1;
        }
    
    }

}
