using UnityEngine;

namespace PGCompany
{
    internal static class 三丙丅丅七丘丒丗丂
    {
        // Fields
        private const string 丛业丐丈三丏丘世丆 = "SelfClearedProgress.IdsKey";
        private static readonly System.Collections.Generic.HashSet<string> 三丌丐下业丂丄丌与;
        
        // Methods
        private static 三丙丅丅七丘丒丗丂()
        {
            PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与 = new System.Collections.Generic.HashSet<System.String>();
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "SelfClearedProgress.IdsKey")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "SelfClearedProgress.IdsKey", 下下丏一丙不丘丌丞:  "[]");
            }
            
            PGCompany.三丙丅丅七丘丒丗丂.Load();
        }
        private static void Load()
        {
            var val_4;
            var val_6;
            val_4 = null;
            val_4 = null;
            PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与.Clear();
            DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            string val_2 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "SelfClearedProgress.IdsKey");
            var val_4 = 0;
            val_4 = val_4 + 1;
            if(val_1 == null)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与.UnionWith(other:  val_1);
        }
        private static void 丂且不业丂专丛丆东()
        {
            var val_3 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "SelfClearedProgress.IdsKey", 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与));
        }
        internal static void 业丏丗丐丂业东丂丗(string 丞丅上丏丂且下丅与)
        {
            null = null;
            bool val_1 = PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与.Add(item:  丞丅上丏丂且下丅与);
            PGCompany.三丙丅丅七丘丒丗丂.丂且不业丂专丛丆东();
        }
        internal static void Remove(string 丞丅上丏丂且下丅与)
        {
            if(((4 & 2) != 0) && (1883 == 0))
            {
                    86394 = null;
            }
            
            bool val_1 = PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与.Remove(item:  丞丅上丏丂且下丅与);
            PGCompany.三丙丅丅七丘丒丗丂.丂且不业丂专丛丆东();
        }
        internal static bool 丟不下下且业丛丄丏(string 丞丅上丏丂且下丅与)
        {
            null = null;
            if(PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与 != null)
            {
                    return PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与.Contains(item:  丞丅上丏丂且下丅与);
            }
            
            return PGCompany.三丙丅丅七丘丒丗丂.三丌丐下业丂丄丌与.Contains(item:  丞丅上丏丂且下丅与);
        }
    
    }

}
