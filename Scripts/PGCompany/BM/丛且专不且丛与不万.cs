using UnityEngine;

namespace PGCompany.BM
{
    internal class 丛且专不且丛与不万 : 丏丙丙丏不专丁丁丏
    {
        // Methods
        internal override bool 七丆丟丗丕丆丐丕丅(PGCompany.BM.丒万丗丏一丝丅丌世 专丌万丘且三不下丙, ref System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 专丂丕丗丗东世丞下)
        {
            System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏> val_6;
            PGCompany.BM.丒万丗丏一丝丅丌世 val_2 = PGCompany.BM.丟丌丅丞下丏丕不丞.丑七不且上丗丁一世().三丟丌丂丐丙丅丗七();
            if(val_2 != null)
            {
                    val_2._rarity = 专丌万丘且三不下丙._rarity;
            }
            else
            {
                    mem[32] = 专丌万丘且三不下丙._rarity;
            }
            
            val_2._overrideType = 0;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  专丌万丘且三不下丙.weight);
            val_2.weight = val_3;
            mem2[0] = val_3.上万三丆专丏丒丗业;
            val_2._forSlotType = 专丌万丘且三不下丙._forSlotType;
            val_2._currencies = System.Linq.Enumerable.ToList<PGCompany.三丌上丁一丟丐丟丈>(source:  专丌万丘且三不下丙._currencies);
            PGCompany.三东丏不丗世丅丌丄 val_5 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  专丌万丘且三不下丙._itemIndex);
            if(val_2 != null)
            {
                    val_2.丘丕丈下东一丑上丗(丙业与丙丗丝不丈东:  val_5);
                val_6 = 专丌万丘且三不下丙._reals;
            }
            else
            {
                    0.丘丕丈下东一丑上丗(丙业与丙丗丝不丈东:  val_5);
                val_6 = 专丌万丘且三不下丙._reals;
            }
            
            val_2._reals = val_6;
            专丂丕丗丗东世丞下.Add(item:  专丌万丘且三不下丙);
            return true;
        }
        public 丛且专不且丛与不万()
        {
            val_1 = new System.Object();
        }
    
    }

}
