using UnityEngine;

namespace PGCompany
{
    internal static class 丒丑丘丏丐丅不丝丁
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, System.Type> 丏一丁与丂丗丞与专;
        
        // Methods
        internal static PGCompany.一丞且丑丁丆一世三 丗丘上一不下丙与万(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if((PGCompany.丒丑丘丏丐丅不丝丁.丏一丁与丂丗丞与专.ContainsKey(key:  丐丅丒专丛丏上与业)) != false)
            {
                    val_6 = null;
                val_6 = null;
                if((System.Activator.CreateInstance(type:  PGCompany.丒丑丘丏丐丅不丝丁.丏一丁与丂丗丞与专.Item[丐丅丒专丛丏上与业])) == null)
            {
                    return (PGCompany.一丞且丑丁丆一世三)val_7;
            }
            
            }
            
            val_7 = 0;
            return (PGCompany.一丞且丑丁丆一世三)val_7;
        }
        private static 丒丑丘丏丐丅不丝丁()
        {
            System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, System.Type>();
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  6, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.丒丑丘丏丐丅不丝丁.丏一丁与丂丗丞与专 = val_1;
        }
    
    }

}
