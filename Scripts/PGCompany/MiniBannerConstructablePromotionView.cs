using UnityEngine;

namespace PGCompany
{
    internal sealed class MiniBannerConstructablePromotionView : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _holder;
        private UnityEngine.GameObject _timerContainer;
        private UnityEngine.GameObject _presentationContainer;
        private PGCompany.TimerUI _timer;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            int val_22;
            Rilisoft.业丙丘丆东丈丕丂丄 val_23;
            UnityEngine.GameObject val_24;
            val_22 = this;
            if(一丐丗丁丞丆丅丟丄 != null)
            {
                    val_23 = 一丐丗丁丞丆丅丟丄.Offer;
            }
            else
            {
                    val_23 = 0;
            }
            
            val_24 = this._holder;
            if(val_23 != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  true);
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  一丐丗丁丞丆丅丟丄.Offer.业上丙丞丐丄丆丅七(), 丙业与丙丗丝不丈东: out  0)) == false)
            {
                    return;
            }
            
                val_24 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世();
                PGCompany.世丞上丏丗不丛上东 val_5 = val_24.上丑下专丄下丟丏丆(丞世不丒下上上丝丑:  0);
                if(val_5 == null)
            {
                    return;
            }
            
                val_24 = this._timerContainer;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._presentationContainer, 丏业丟一东丂东丘丛:  false);
                if((val_5.不七丝丏丑丑与七丈() >= 1) && (val_5.上丟丄与丁三丌丘专() >= 1))
            {
                    val_24 = val_5.不七丝丏丑丑与七丈();
                if(val_24 < PixelTime.丙丅丅业丟丁世丁丗())
            {
                    val_24 = val_5.上丟丄与丁三丌丘专();
                if(val_24 >= PixelTime.丙丅丅业丟丁世丁丗())
            {
                    val_24 = this._presentationContainer;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  true);
            }
            
            }
            
            }
            
                if(val_5.上丟丄与丁三丌丘专() < 1)
            {
                    return;
            }
            
                if(val_5.下丒丗丄丌丘不丑丘() < 1)
            {
                    return;
            }
            
                val_24 = val_5.上丟丄与丁三丌丘专();
                if(val_24 >= PixelTime.丙丅丅业丟丁世丁丗())
            {
                    return;
            }
            
                val_24 = val_5.下丒丗丄丌丘不丑丘();
                if(val_24 < PixelTime.丙丅丅业丟丁世丁丗())
            {
                    return;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerContainer, 丏业丟一东丂东丘丛:  true);
                val_24 = PixelTime.丙丅丅业丟丁世丁丗();
                if(this._timer == 0)
            {
                    return;
            }
            
                val_22 = val_5.下丒丗丄丌丘不丑丘() - val_24;
                this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_22, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  false);
        }
        public MiniBannerConstructablePromotionView()
        {
        
        }
    
    }

}
