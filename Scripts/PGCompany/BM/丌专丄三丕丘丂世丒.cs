using UnityEngine;

namespace PGCompany.BM
{
    internal static class 丌专丄三丕丘丂世丒
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.BM.丒万丗丏一丝丅丌世.下丆丆且丟丏东丐且, PGCompany.BM.丏丙丙丏不专丁丁丏> 不世不丌丗丝丟丆丅;
        private static readonly PGCompany.BM.丏丙丙丏不专丁丁丏 丕丄丈不丟丝丅丈丅;
        private static readonly PGCompany.BM.丏丙丙丏不专丁丁丏 丐丒丄丛丅丌丞丛丂;
        
        // Methods
        internal static bool 七丆丟丗丕丆丐丕丅(PGCompany.BM.丒万丗丏一丝丅丌世 专丌万丘且三不下丙, ref System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 专丂丕丗丗东世丞下)
        {
            System.Collections.Generic.Dictionary<下丆丆且丟丏东丐且, PGCompany.BM.丏丙丙丏不专丁丁丏> val_4;
            var val_5;
            var val_6;
            PGCompany.BM.丏丙丙丏不专丁丁丏 val_7;
            var val_8;
            var val_9;
            var val_10;
            if(专丌万丘且三不下丙 == null)
            {
                    return false;
            }
            
            val_5 = null;
            if((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  专丌万丘且三不下丙._itemIndex)) == null)
            {
                goto label_2;
            }
            
            val_6 = null;
            val_7 = PGCompany.BM.丌专丄三丕丘丂世丒.丕丄丈不丟丝丅丈丅;
            if(val_7 != null)
            {
                goto mem[282584257677031];
            }
            
            goto label_10;
            label_2:
            val_8 = null;
            val_4 = PGCompany.BM.丌专丄三丕丘丂世丒.不世不丌丗丝丟丆丅;
            if((val_4.ContainsKey(key:  专丌万丘且三不下丙._overrideType)) != false)
            {
                    val_9 = null;
                val_9 = null;
                val_4 = PGCompany.BM.丌专丄三丕丘丂世丒.不世不丌丗丝丟丆丅;
                if(val_4.Item[专丌万丘且三不下丙._overrideType] != null)
            {
                goto mem[282584257677031];
            }
            
            }
            
            label_10:
            val_10 = null;
            val_10 = null;
            val_7 = PGCompany.BM.丌专丄三丕丘丂世丒.丐丒丄丛丅丌丞丛丂;
            if(val_7 == null)
            {
                    val_7 = 0;
            }
        
        }
        private static 丌专丄三丕丘丂世丒()
        {
            System.Collections.Generic.Dictionary<下丆丆且丟丏东丐且, PGCompany.BM.丏丙丙丏不专丁丁丏> val_1 = new System.Collections.Generic.Dictionary<下丆丆且丟丏东丐且, PGCompany.BM.丏丙丙丏不专丁丁丏>();
            val_1.Add(key:  0, value:  new PGCompany.BM.丒丁丙业丆丒丗丂专());
            val_1.Add(key:  1, value:  new PGCompany.BM.专丘丝丟七世七丛丕());
            val_1.Add(key:  3, value:  new PGCompany.BM.与丕丒丝丁不上丁丆());
            val_1.Add(key:  2, value:  new PGCompany.BM.丝东丞且丂业不下丏());
            val_1.Add(key:  4, value:  new PGCompany.BM.专丁世上丒一且丘丈());
            PGCompany.BM.丌专丄三丕丘丂世丒.不世不丌丗丝丟丆丅 = val_1;
            PGCompany.BM.丌专丄三丕丘丂世丒.丕丄丈不丟丝丅丈丅 = new PGCompany.BM.丛且专不且丛与不万();
            PGCompany.BM.丌专丄三丕丘丂世丒.丐丒丄丛丅丌丞丛丂 = new PGCompany.BM.丒丁丙业丆丒丗丂专();
        }
    
    }

}
