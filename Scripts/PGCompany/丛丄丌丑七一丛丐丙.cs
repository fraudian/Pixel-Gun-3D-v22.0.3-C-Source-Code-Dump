using UnityEngine;

namespace PGCompany
{
    internal sealed class 丛丄丌丑七一丛丐丙 : 东丞丄丌丙丙丕下丛
    {
        // Methods
        internal override PGCompany.丗丟丄丈东丝丕丄世 丒丅丙丄丞丟下丏业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            Rilisoft.OfferItemType val_17;
            var val_18;
            var val_19;
            if(丈丄不七三万丄丁不 != null)
            {
                    val_17 = 丈丄不七三万丄丁不.不业丙丒丂丞下丆丙();
            }
            else
            {
                    val_17 = 0.不业丙丒丂丞下丆丙();
            }
            
            val_19 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_17, 丞丅上丏丂且下丅与:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
            if(val_19 == null)
            {
                    return (PGCompany.丗丟丄丈东丝丕丄世)val_18;
            }
            
            if(null != null)
            {
                    val_18 = 0;
                return (PGCompany.丗丟丄丈东丝丕丄世)val_18;
            }
            
            val_17 = val_19.业上丙丞丐丄丆丅七();
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  val_17)) == null)
            {
                    return (PGCompany.丗丟丄丈东丝丕丄世)val_18;
            }
            
            val_17 = val_19.业上丙丞丐丄丆丅七();
            PGCompany.三东丏不丗世丅丌丄 val_11 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_17, 丞世不丒下上上丝丑:  val_19.业东丅东丌上丗丑不());
            val_11.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  1);
            PGCompany.丟丝东丈丐丙三下丛 val_12 = null;
            val_19 = val_12;
            val_12 = new PGCompany.丟丝东丈丐丙三下丛(丈丄不七三万丄丁不:  val_11);
            if(val_12.丐上下三丑丈丑丄丟().业不东丞丘且且一丟() != false)
            {
                    val_18 = 0;
                if(val_12.丐上下三丑丈丑丄丟().丝专丕丒一丌下丑丌() == false)
            {
                    return (PGCompany.丗丟丄丈东丝丕丄世)val_18;
            }
            
            }
            
            val_18 = val_19;
            return (PGCompany.丗丟丄丈东丝丕丄世)val_18;
        }
        internal override System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 万丞万丘丈下东上丘(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            var val_9;
            var val_17 = 0;
            if(丁丅丈丌丟世丗丗丟 != 10)
            {
                    return (System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>)val_17;
            }
            
            if(丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙() == null)
            {
                goto label_4;
            }
            
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_2 = null;
            val_17 = val_2;
            val_2 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            PGCompany.东丑丒丗一丞下丙丙<T> val_5 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            bool val_6 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().上且万东丑与丐丘下(丁丅丈丌丟世丗丗丟:  10, 东且丁丆丛丁丏丘且: ref  val_5);
            List.Enumerator<T> val_7 = val_5.GetEnumerator();
            label_18:
            if(((-430892864) & 1) == 0)
            {
                goto label_12;
            }
            
            int val_10 = val_9.丙东专丂世丈丏丁丂();
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_10)) == null)
            {
                goto label_18;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_10);
            new PGCompany.丟丝东丈丐丙三下丛() = new PGCompany.丟丝东丈丐丙三下丛(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄());
            val_2.Add(item:  new PGCompany.丟丝东丈丐丙三下丛());
            goto label_18;
            label_4:
            val_17 = 0;
            return (System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>)val_17;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.东丑丒丗一丞下丙丙<T> val_15 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            return (System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>)val_17;
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丕丌丟三丝丕一三丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丞东丌丛下丙专丘丐(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(val_2 == null)
            {
                    return 0;
            }
            
            if(null != null)
            {
                    return 0;
            }
            
            丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  val_2, 丞一丁业丄一一业且:  val_2.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛(), 七丝下七下丗三且丟:  0, 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  false, 丝丗不东丙不三丄专:  false, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  0, 不丐丅丁丂七丐丘丛:  268435467);
            if(11 == 0)
            {
                    return val_2.丑丐丙丄丅世世丑丒();
            }
            
            1152921555715832544 = val_2.业上丙丞丐丄丆丅七();
            丆丞丐三与丞专丈丌.丁上丟上不丘七不万(丞一丁业丄一一业且:  1152921555715832544, 丁丅丈丌丟世丗丗丟:  2);
            return val_2.丑丐丙丄丅世世丑丒();
        }
        internal override void 下且上丛丞一东不不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丆丈丘东丆丕三丞东 不丁丟专专专丒上丝)
        {
        
        }
        internal override bool 三东不丌世丄丄七丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            return false;
        }
        public 丛丄丌丑七一丛丐丙()
        {
        
        }
    
    }

}
