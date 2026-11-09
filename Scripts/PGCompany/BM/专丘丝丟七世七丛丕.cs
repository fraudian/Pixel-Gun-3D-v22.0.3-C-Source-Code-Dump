using UnityEngine;

namespace PGCompany.BM
{
    internal class 专丘丝丟七世七丛丕 : 丏丙丙丏不专丁丁丏
    {
        // Methods
        internal override bool 七丆丟丗丕丆丐丕丅(PGCompany.BM.丒万丗丏一丝丅丌世 专丌万丘且三不下丙, ref System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 专丂丕丗丗东世丞下)
        {
            var val_5;
            System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_31;
            int val_32;
            int val_33;
            if((专丌万丘且三不下丙 == null) || (专丌万丘且三不下丙._overrideType != 1))
            {
                    return false;
            }
            
            PGCompany.BM.丟丌丅丞下丏丕不丞 val_1 = PGCompany.BM.丟丌丅丞下丏丕不丞.丑七不且上丗丁一世();
            val_31 = val_1.丛丈三丙不三下丗丁;
            if(val_31 == null)
            {
                    return false;
            }
            
            if((System.Linq.Enumerable.Any<三丅丁丗丗丝丂万且>(source:  val_31)) == false)
            {
                    return false;
            }
            
            List.Enumerator<T> val_3 = val_31.GetEnumerator();
            label_41:
            if((108570544 & 1) == 0)
            {
                goto label_8;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if(val_6 != 专丌万丘且三不下丙._rarity)
            {
                goto label_41;
            }
            
            decimal val_9 = Rilisoft.Offers.丁且丕专万丈丒丏丗.东丙上丛丗丆丈业丕(万丐丏丐丒万不丟三:  Rilisoft.下丐丒一丝丈丝三丞.下丐丙七丑万且丕不(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_6.与不丞丑七丘丁丂丛(), 丌丒丝东丌下丕丁丅:  1), 世丈三丐丞一丒丛不:  1);
            val_32 = val_9.flags;
            val_33 = val_9.lo;
            new 丕丑丙丑丙东丌丘丕() = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_6.七丙丛与万且专三三(), 丏丆丐丑专与丄丘丞:  val_6);
            丈丞丕丘丕丗与上一 val_13 = BalanceController.丅下业丞三七丒七丂(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(), 丝三丛且丘不丌丙下:  val_6.三与丛丑且丐丈业丌(), 丐丏上业丈丂与万丞:  true);
            if(val_13 == null)
            {
                goto label_17;
            }
            
            if(val_13.丟丂丞不专丆万丒世() < 1)
            {
                goto label_18;
            }
            
            decimal val_15 = Rilisoft.Offers.丁且丕专万丈丒丏丗.东丙上丛丗丆丈业丕(万丐丏丐丒万不丟三:  val_13, 世丈三丐丞一丒丛不:  1);
            decimal val_16 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_32, hi = val_9.hi, lo = val_33, mid = val_9.mid}, d2:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid});
            val_32 = val_16.flags;
            val_33 = val_16.lo;
            goto label_23;
            label_17:
            label_23:
            label_18:
            int val_17 = Rilisoft.Offers.丁且丕专万丈丒丏丗.丈不万七不丘与专丂(七丛下丘丁丌丅丗丟:  new System.Decimal() {flags = val_32, hi = val_9.hi, lo = val_33, mid = val_9.mid}, 下丏与下七丄一下七:  0, 丏丅东丙东业三丈丗:  0);
            if(val_17 < 1)
            {
                goto label_41;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_6.业东丅东丌上丗丑不());
            if((new PGCompany.三东丏不丗世丅丌丄().丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  1).丕丐一丙专丛丒丑万()) == false)
            {
                goto label_41;
            }
            
            PGCompany.BM.丒万丗丏一丝丅丌世 val_23 = PGCompany.BM.丟丌丅丞下丏丕不丞.丑七不且上丗丁一世().三丟丌丂丐丙丅丗七();
            if(val_23 != null)
            {
                    val_23._rarity = 专丌万丘且三不下丙._rarity;
            }
            else
            {
                    mem[32] = 专丌万丘且三不下丙._rarity;
            }
            
            val_23._overrideType = 0;
            Rilisoft.丝丑丂丛万丐丈丘且 val_24 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  专丌万丘且三不下丙.weight);
            val_23.weight = val_24;
            mem2[0] = val_24.上万三丆专丏丒丗业;
            val_23._forSlotType = 专丌万丘且三不下丙._forSlotType;
            val_23._currencies = System.Linq.Enumerable.ToList<PGCompany.三丌上丁一丟丐丟丈>(source:  专丌万丘且三不下丙._currencies);
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_6.业东丅东丌上丗丑不());
            val_23.丘丕丈下东一丑上丗(丙业与丙丗丝不丈东:  new PGCompany.三东丏不丗世丅丌丄());
            System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏> val_28 = new System.Collections.Generic.Dictionary<System.Int32, 丝丆丁丒丌丂上丑丏>();
            new 丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏() = new System.Object();
            decimal val_30 = System.Decimal.op_Implicit(value:  专丌万丘且三不下丙.weight);
            if(new 丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏() != null)
            {
                    ._chance = val_30;
                mem[1152921560550126552] = val_30.lo;
                mem[1152921560550126556] = val_30.mid;
            }
            else
            {
                    mem[16] = val_30.flags;
                mem[20] = val_30.hi;
                mem[24] = val_30.lo;
                mem[28] = val_30.mid;
            }
            
            ._count = 1;
            null.Add(key:  val_17, value:  new 丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏());
            val_23._reals = null;
            专丂丕丗丗东世丞下.Add(item:  val_23);
            goto label_41;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return false;
        }
        public 专丘丝丟七世七丛丕()
        {
            val_1 = new System.Object();
        }
    
    }

}
