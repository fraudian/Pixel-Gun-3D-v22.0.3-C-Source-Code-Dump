using UnityEngine;

namespace PGCompany.BM
{
    internal static class 上丁东专丏丐与丕丐
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.BM.世业丈丑七丁东上东, PGCompany.BM.丏丈丁与丑一丝下丒> 丁丈丆丒丙丟丅世丗;
        private static readonly PGCompany.BM.丏丈丁与丑一丝下丒 丛丒丞一丘万丒专与;
        
        // Methods
        internal static PGCompany.BM.丏丈丁与丑一丝下丒 丟丁丈三丄丆丆丄丈(PGCompany.BM.丁七上一三丁上丑丑 丌丝万上丅丒一丈丘)
        {
            PGCompany.BM.世业丈丑七丁东上东 val_3;
            var val_4;
            var val_5;
            PGCompany.BM.丏丈丁与丑一丝下丒 val_6;
            var val_7;
            var val_8;
            val_3 = 丌丝万上丅丒一丈丘;
            val_4 = null;
            if(丌丝万上丅丒一丈丘._id <= 3)
            {
                    val_5 = null;
                val_6 = PGCompany.BM.上丁东专丏丐与丕丐.丛丒丞一丘万丒专与;
                return (PGCompany.BM.丏丈丁与丑一丝下丒)val_6;
            }
            
            val_7 = null;
            if((PGCompany.BM.上丁东专丏丐与丕丐.丁丈丆丒丙丟丅世丗.ContainsKey(key:  丌丝万上丅丒一丈丘._slotType)) != false)
            {
                    val_8 = null;
                val_8 = null;
                val_3 = 丌丝万上丅丒一丈丘._slotType;
                PGCompany.BM.丏丈丁与丑一丝下丒 val_2 = PGCompany.BM.上丁东专丏丐与丕丐.丁丈丆丒丙丟丅世丗.Item[val_3];
                return (PGCompany.BM.丏丈丁与丑一丝下丒)val_6;
            }
            
            val_6 = 0;
            return (PGCompany.BM.丏丈丁与丑一丝下丒)val_6;
        }
        private static 上丁东专丏丐与丕丐()
        {
            System.Collections.Generic.Dictionary<PGCompany.BM.世业丈丑七丁东上东, PGCompany.BM.丏丈丁与丑一丝下丒> val_1 = new System.Collections.Generic.Dictionary<PGCompany.BM.世业丈丑七丁东上东, PGCompany.BM.丏丈丁与丑一丝下丒>();
            val_1.Add(key:  1, value:  new PGCompany.BM.一上三上一丈丘与丘());
            val_1.Add(key:  2, value:  new PGCompany.BM.一上三上一丈丘与丘());
            val_1.Add(key:  3, value:  new PGCompany.BM.业丏丗丒丄丐三丁东());
            PGCompany.BM.上丁东专丏丐与丕丐.丁丈丆丒丙丟丅世丗 = val_1;
            PGCompany.BM.上丁东专丏丐与丕丐.丛丒丞一丘万丒专与 = new PGCompany.BM.丛丟不丑丒丑丈东丂();
        }
    
    }

}
