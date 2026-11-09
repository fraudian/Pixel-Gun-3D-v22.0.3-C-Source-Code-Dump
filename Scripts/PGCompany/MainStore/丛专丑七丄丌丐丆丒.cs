using UnityEngine;

namespace PGCompany.MainStore
{
    internal static class 丛专丑七丄丌丐丆丒
    {
        // Fields
        internal static readonly System.Collections.Generic.Dictionary<string, PGCompany.MainStore.上与丐万上业丕丐丐> 上七上丝丕丙三世万;
        
        // Methods
        internal static PGCompany.MainStore.上与丐万上业丕丐丐 丞专丕且一东丁一丙(string 不下丙丘丈下下丏一)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            if((PGCompany.MainStore.丛专丑七丄丌丐丆丒.上七上丝丕丙三世万.ContainsKey(key:  不下丙丘丈下下丏一)) != false)
            {
                    val_4 = null;
                val_4 = null;
                PGCompany.MainStore.上与丐万上业丕丐丐 val_2 = PGCompany.MainStore.丛专丑七丄丌丐丆丒.上七上丝丕丙三世万.Item[不下丙丘丈下下丏一];
                return (PGCompany.MainStore.上与丐万上业丕丐丐)val_5;
            }
            
            val_5 = 0;
            return (PGCompany.MainStore.上与丐万上业丕丐丐)val_5;
        }
        private static 丛专丑七丄丌丐丆丒()
        {
            System.Collections.Generic.Dictionary<System.String, PGCompany.MainStore.上与丐万上业丕丐丐> val_1 = new System.Collections.Generic.Dictionary<System.String, PGCompany.MainStore.上与丐万上业丕丐丐>();
            .丗丄不不丒丕丕丛丑 = "Default";
            val_1.Add(key:  "Default", value:  new PGCompany.MainStore.丕丅丌丅丈一东业不());
            .丗丄不不丒丕丕丛丑 = "Clan";
            val_1.Add(key:  "Clan", value:  new PGCompany.MainStore.丕丅丌丅丈一东业不());
            .丗丄不不丒丕丕丛丑 = "PixelPass";
            val_1.Add(key:  "PixelPass", value:  new PGCompany.MainStore.丕丅丌丅丈一东业不());
            val_1.Add(key:  "ShopCompetition", value:  new PGCompany.MainStore.万一丁丒丕丅七七下(丛丐且下丂丏丁专丌:  "ShopCompetition"));
            PGCompany.MainStore.丛专丑七丄丌丐丆丒.上七上丝丕丙三世万 = val_1;
        }
    
    }

}
