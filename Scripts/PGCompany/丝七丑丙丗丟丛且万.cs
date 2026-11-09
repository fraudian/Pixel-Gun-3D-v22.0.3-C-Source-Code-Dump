using UnityEngine;

namespace PGCompany
{
    internal sealed class 丝七丑丙丗丟丛且万 : 东丞丄丌丙丙丕下丛
    {
        // Methods
        internal override PGCompany.丗丟丄丈东丝丕丄世 丒丅丙丄丞丟下丏业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            int val_14 = 丈丄不七三万丄丁不.业东丅东丌上丗丑不();
            PGCompany.丗丑丕丕不丄丘丒丆 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丗丑丕丕不丄丘丒丆>(丞世不丒下上上丝丑:  val_14 = 丈丄不七三万丄丁不.业东丅东丌上丗丑不());
            if(val_3 == null)
            {
                    return 0;
            }
            
            if(val_3.三丐丗万丗三丄丒丄() == null)
            {
                    return 0;
            }
            
            val_14 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_14.丞丗丑丈一丅丗丌丟() == null)
            {
                    return 0;
            }
            
            val_14 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东万丕丗丅万丄丘丙();
            int val_12 = val_14.一且丞七丟丌三且且(丛丑丅丞丝丈丘丆三:  val_3.三丐丗万丗三丄丒丄().业东丅东丌上丗丑不());
            if(val_12 < 1)
            {
                    return 0;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_13 = 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            val_13.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_12);
            return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_13);
        }
        internal override System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 万丞万丘丈下东上丘(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            var val_11;
            var val_20;
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            val_20 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_20.丞丗丑丈一丅丗丌丟() == null)
            {
                    return val_1;
            }
            
            val_20 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东万丕丗丅万丄丘丙().上丞丏丏三丒丕世丂().Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_9 = val_20.GetEnumerator();
            label_16:
            if(((-452549520) & 1) == 0)
            {
                goto label_8;
            }
            
            PGCompany.丏丌丝丕丐七丈且丒 val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丏丌丝丕丐七丈且丒>(丞世不丒下上上丝丑:  val_11.丐丏七丌丕丗业且上().业东丅东丌上丗丑不());
            if((val_15 == null) || (val_15.丞万丒丌丈东丄业下() == null))
            {
                goto label_16;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_18 = val_15.丞万丒丌丈东丄业下().丑丐丙丄丅世世丑丒();
            if(this == null)
            {
                goto label_16;
            }
            
            val_1.Add(item:  this);
            goto label_16;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丕丌丟三丝丕一三丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            var val_52;
            Rilisoft.OfferItemType val_53;
            var val_54;
            var val_55;
            var val_56;
            val_52 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_52.丞丗丑丈一丅丗丌丟() == null)
            {
                    return 0;
            }
            
            val_52 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(丈丄不七三万丄丁不 != null)
            {
                    val_53 = 丈丄不七三万丄丁不.不业丙丒丂丞下丆丙();
            }
            else
            {
                    val_53 = 0.不业丙丒丂丞下丆丙();
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_7 = val_52.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_53, 丞丅上丏丂且下丅与:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
            if(val_7 == null)
            {
                    return 0;
            }
            
            val_52 = (null == null) ? (val_7) : 0;
            if(null != null)
            {
                    return 0;
            }
            
            if(val_52.三丐丗万丗三丄丒丄() == null)
            {
                    return 0;
            }
            
            if(val_52.三丐丗万丗三丄丒丄().丁丟丈丌丑丅丞世丏() == false)
            {
                    return 0;
            }
            
            val_54 = null;
            val_54 = null;
            if(val_52 == 丐丏七丈且丌丄三丏.丒丛丗东与丕专丄丄)
            {
                goto label_16;
            }
            
            if(this == null)
            {
                goto label_17;
            }
            
            val_55 = this;
            if(丈丄不七三万丄丁不 != null)
            {
                goto label_20;
            }
            
            goto label_19;
            label_17:
            val_55 = 0;
            if(丈丄不七三万丄丁不 != null)
            {
                goto label_20;
            }
            
            label_19:
            label_20:
            丈丄不七三万丄丁不.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Clamp(value:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), min:  0, max:  val_52 - val_55));
            label_16:
            if(丈丄不七三万丄丁不.丂丁丏一丙丛业且丌() < 1)
            {
                    return 0;
            }
            
            if((PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丌上专业丆丆下专丂(丛丑丅丞丝丈丘丆三:  val_52.三丐丗万丗三丄丒丄().业东丅东丌上丗丑不())) == true)
            {
                    return 0;
            }
            
            int val_20 = val_52.三丐丗万丗三丄丒丄().丌与一丏丏丌不不丒();
            int val_21 = 丈丄不七三万丄丁不.丂丁丏一丙丛业且丌();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  239);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专一丄丌丗丂丆丛丈(丄丒下业一不丈丝丘:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丁丈丞一专下丛丕三(), 丛丑丅丞丝丈丘丆三:  val_52.三丐丗万丗三丄丒丄().业东丅东丌上丗丑不(), 丌丒丝东丌下丕丁丅:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), 丅丘东一丛一丁万且:  丝一三下丕且丅丟世.七东丗丌丒丗且丒业(), 丑一丁七不下业丁丕:  val_52.三丐丗万丗三丄丒丄().丏丈丁专专丘丒丂丂(), 业上丞丐万三丒丘上:  val_52.三丐丗万丗三丄丒丄().万丙东丙丐丕专丈丕());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            PGCompany.丁丏丝上丘丝丒丞丒 val_39 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东万丕丗丅万丄丘丙();
            PGCompany.丕专丝与丐上丂东世 val_42 = val_39.与丂丁丕丈丑丂业丁(丛丑丅丞丝丈丘丆三:  val_52.三丐丗万丗三丄丒丄().业东丅东丌上丗丑不());
            val_56 = 丈丄不七三万丄丁不.丂丁丏一丙丛业且丌();
            val_42.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_56 + val_42.丂丁丏一丙丛业且丌());
            if(val_20 <= val_21)
            {
                    int val_46 = val_42.丈一下下丞世三丑丄();
                val_56 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  (val_20 <= val_21) ? 1 : 0);
                if(val_42 != null)
            {
                    val_42.东丒万业丌丂丌且丕(丙业与丙丗丝不丈东:  val_56 + val_46);
            }
            else
            {
                    0.东丒万业丌丂丌且丕(丙业与丙丗丝不丈东:  val_56 + val_46);
            }
            
                val_42.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
            }
            
            val_42.东七丏丗丘丛丙上丘 = true;
            val_42.丗丌丌丈丑丂三丌丕(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.丈不丄丛丛丘东丁丙(), 丌丒丝东丌下丕丁丅:  丝一三下丕且丅丟世.七东丗丌丒丗且丒业());
            val_39.丁东丗下上与且丌业(上丝丕丘丄一丏不丙:  val_42);
            if(丈丄不七三万丄丁不 != null)
            {
                    return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            }
            
            return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
        }
        internal override void 下且上丛丞一东不不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丆丈丘东丆丕三丞东 不丁丟专专专丒上丝)
        {
        
        }
        internal override bool 三东不丌世丄丄七丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            return true;
        }
        public 丝七丑丙丗丟丛且万()
        {
            val_1 = new System.Object();
        }
    
    }

}
