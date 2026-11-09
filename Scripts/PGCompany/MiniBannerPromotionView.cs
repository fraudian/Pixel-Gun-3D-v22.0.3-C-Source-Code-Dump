using UnityEngine;

namespace PGCompany
{
    internal sealed class MiniBannerPromotionView : PGBehaviour
    {
        // Fields
        private UILabel _header;
        private PGCompany.TimerUI _timer;
        private UnityEngine.GameObject _timerContainer;
        private UnityEngine.GameObject _presentationContainer;
        private UIWidget _oneItemContainer;
        private UIWidget _twoItemsContainer;
        private UIBasicSprite _bgSprite;
        private UIBasicSprite _bgPattern;
        private PGCompany.StorePromotionConfig 三下丙与且且不万丞;
        private PGCompany.专丟专世丅丂丁且专 下丄丆丗丂专丒与丙;
        private Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丈丅且丈丘丝万丝且;
        private UnityEngine.Color 丕业丐丈七与专丞丈;
        private string 丑丆与专世丂三与丙;
        private UnityEngine.Texture 丒且丄丅丛丏上一丄;
        private bool 丟丆丌丟丂丗丗业丆;
        private UnityEngine.Coroutine 丈三下七东丆丈三丙;
        
        // Methods
        internal bool 丝一丅丆三东丂丞七(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_46;
            var val_47;
            PGCompany.StorePromotionConfig val_48;
            var val_49;
            if((一丐丗丁丞丆丅丟丄 == null) || (一丐丗丁丞丆丅丟丄.Offer == null))
            {
                goto label_2;
            }
            
            if(this.丟丆丌丟丂丗丗业丆 != true)
            {
                    this.丟丆丌丟丂丗丗业丆 = true;
                if(this._bgSprite != 0)
            {
                    UnityEngine.Color val_2 = this._bgSprite.color;
                this.丕业丐丈七与专丞丈 = val_2;
                mem[1152921555974416688] = val_2.g;
                mem[1152921555974416692] = val_2.b;
                mem[1152921555974416696] = val_2.a;
            }
            
                if(this._header != 0)
            {
                    this.丑丆与专世丂三与丙 = this._header.text;
            }
            
                val_46 = this._bgPattern;
                val_47 = 0;
                if(val_46 != 0)
            {
                    val_46 = this._bgPattern;
                this.丒且丄丅丛丏上一丄 = val_46;
            }
            
            }
            
            if(一丐丗丁丞丆丅丟丄.OfferModule != 170)
            {
                goto label_16;
            }
            
            val_47 = 世七专下业丂丈丛丙 Rilisoft.丗下丙丅且丐丞丙世::下不丛上丏且东一丏<世七专下业丂丈丛丙>(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丗与丟上上丑专世丗);
            val_46 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<世七专下业丂丈丛丙>(丗与丟上上丑专世丗:  170);
            if(val_46 != null)
            {
                    val_47 = 0;
                PGCompany.StorePromotionConfig val_9 = val_46.万丂丌三丗三丟丈业(丞丅上丏丂且下丅与:  一丐丗丁丞丆丅丟丄.Offer.丏不丁丛丕丒丏丆丂());
            }
            
            val_49 = this;
            this.三下丙与且且不万丞 = val_9;
            if(val_9 != null)
            {
                goto label_22;
            }
            
            return (bool)val_48;
            label_2:
            val_48 = 0;
            return (bool)val_48;
            label_16:
            val_49 = this;
            val_48 = this.三下丙与且且不万丞;
            if(val_48 == null)
            {
                    return (bool)val_48;
            }
            
            label_22:
            val_46 = this.下丄丆丗丂专丒与丙;
            var val_47 = 0;
            val_47 = val_47 + 1;
            val_47 = 0;
            if((val_48.Identificator.Equals(other:  ???)) != false)
            {
                    if(一丐丗丁丞丆丅丟丄.OfferModule == this.丈丅且丈丘丝万丝且)
            {
                goto label_32;
            }
            
            }
            
            val_46 = this.三下丙与且且不万丞;
            this.下丄丆丗丂专丒与丙 = val_46.Identificator;
            this.丈丅且丈丘丝万丝且 = 一丐丗丁丞丆丅丟丄.OfferModule;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._presentationContainer, 丏业丟一东丂东丘丛:  false);
            PGCompany.StorePromotionSettings val_14 = this.三下丙与且且不万丞.Settings;
            if(val_14.PresentationTime >= 1)
            {
                    PGCompany.StorePromotionSettings val_15 = this.三下丙与且且不万丞.Settings;
                if(val_15.StartTime >= 1)
            {
                    PGCompany.StorePromotionSettings val_16 = this.三下丙与且且不万丞.Settings;
                val_46 = 1152921505243639808;
                if(val_16.PresentationTime < PixelTime.丙丅丅业丟丁世丁丗())
            {
                    PGCompany.StorePromotionSettings val_18 = this.三下丙与且且不万丞.Settings;
                if(val_18.StartTime >= PixelTime.丙丅丅业丟丁世丁丗())
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._presentationContainer, 丏业丟一东丂东丘丛:  true);
            }
            
            }
            
            }
            
            }
            
            PGCompany.StorePromotionSettings val_20 = this.三下丙与且且不万丞.Settings;
            if(val_20.StartTime >= 1)
            {
                    PGCompany.StorePromotionSettings val_21 = this.三下丙与且且不万丞.Settings;
                if(val_21.EndTime >= 1)
            {
                    PGCompany.StorePromotionSettings val_22 = this.三下丙与且且不万丞.Settings;
                val_46 = 1152921505243639808;
                if(val_22.StartTime < PixelTime.丙丅丅业丟丁世丁丗())
            {
                    PGCompany.StorePromotionSettings val_24 = this.三下丙与且且不万丞.Settings;
                if(val_24.EndTime >= PixelTime.丙丅丅业丟丁世丁丗())
            {
                    PGCompany.StorePromotionSettings val_26 = this.三下丙与且且不万丞.Settings;
                Rilisoft.丝丑丂丛万丐丈丘且 val_48 = val_26.EndTime;
                val_46 = PixelTime.丙丅丅业丟丁世丁丗();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerContainer, 丏业丟一东丂东丘丛:  true);
                if(this._timer != 0)
            {
                    val_48 = val_48 - val_46;
                this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_48, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            }
            
            }
            
            }
            
            }
            
            }
            
            if(this._header == 0)
            {
                goto label_82;
            }
            
            PGCompany.StorePromotionSettings val_30 = this.三下丙与且且不万丞.Settings;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_30.TitleLocKey)) == false)
            {
                goto label_87;
            }
            
            val_46 = this.丑丆与专世丂三与丙;
            if(this._header != null)
            {
                goto label_117;
            }
            
            label_118:
            label_117:
            this._header.text = val_46;
            label_82:
            if(this._bgSprite == 0)
            {
                goto label_91;
            }
            
            val_46 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().丏丑丛丘丕丛丆丗丝(一丗与一专丙丙丅丄:  this.三下丙与且且不万丞.Identificator);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_46)) == false)
            {
                goto label_96;
            }
            
            if(this._bgSprite != null)
            {
                goto label_121;
            }
            
            label_122:
            label_121:
            this._bgSprite.color = new UnityEngine.Color() {r = this.丕业丐丈七与专丞丈, g = V9.16B, b = V10.16B, a = V11.16B};
            label_91:
            if(this._bgPattern == 0)
            {
                goto label_100;
            }
            
            string val_40 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().丅丙丑丛专一丟丐丈(一丗与一专丙丙丅丄:  this.三下丙与且且不万丞.Identificator);
            if((val_40 == null) || ((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_40)) == 0))
            {
                goto label_106;
            }
            
            val_46 = this._bgPattern;
            if(val_46 != null)
            {
                goto label_108;
            }
            
            goto label_108;
            label_106:
            val_46 = this.丒且丄丅丛丏上一丄;
            label_108:
            label_100:
            if(this.丈三下七东丆丈三丙 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丈三下七东丆丈三丙);
            }
            
            this.丈三下七东丆丈三丙 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.下丏丈世专丝丐上丒());
            label_32:
            val_48 = 1;
            return (bool)val_48;
            label_87:
            string val_45 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_30.TitleLocKey);
            if(this._header != null)
            {
                goto label_117;
            }
            
            goto label_118;
            label_96:
            UnityEngine.Color val_46 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  val_46);
            if(this._bgSprite != null)
            {
                goto label_121;
            }
            
            goto label_122;
        }
        private void Start()
        {
        
        }
        private void OnDestroy()
        {
            if(this.丈三下七东丆丈三丙 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丈三下七东丆丈三丙);
            this.丈三下七东丆丈三丙 = 0;
        }
        private System.Collections.IEnumerator 下丏丈世专丝丐上丒()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new MiniBannerPromotionView.丐丑三与且丕丛丂丏();
        }
        public MiniBannerPromotionView()
        {
        
        }
    
    }

}
