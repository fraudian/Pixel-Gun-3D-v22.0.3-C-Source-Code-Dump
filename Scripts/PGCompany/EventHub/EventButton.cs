using UnityEngine;

namespace PGCompany.EventHub
{
    public sealed class EventButton : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _mainState;
        private UnityEngine.GameObject _activeState;
        private UnityEngine.GameObject _disabledState;
        private UITextureMasked[] _textures;
        private UILabel _timerUntilEventStart;
        private UILabel[] _eventName;
        private PGCompany.EventHub.业丝下专丗且上丆万 丁丘丄丕下专东七不;
        private PGCompany.EventHub.丅丝丙与丑七不丛世 丁且且丒丞丅万丟东;
        private PGCompany.EventHub.丄世丌东丏三东丒丂 <丆丅丂丕丕丆丁丌万>k__BackingField;
        
        // Properties
        internal PGCompany.EventHub.丄世丌东丏三东丒丂 业丝丄不丞丝上丁与 { get; set; }
        
        // Methods
        internal PGCompany.EventHub.丄世丌东丏三东丒丂 丒丑丕丄丘与丗丕不()
        {
            return (PGCompany.EventHub.丄世丌东丏三东丒丂)this.<丆丅丂丕丕丆丁丌万>k__BackingField;
        }
        internal void 丟丝东丝一丈丆下丝(PGCompany.EventHub.丄世丌东丏三东丒丂 丙业与丙丗丝不丈东)
        {
            this.<丆丅丂丕丕丆丁丌万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.EventHub.业丝下专丗且上丆万 一丐丗丁丞丆丅丟丄, PGCompany.EventHub.丁七丑丝丂丄丅丏丑 丘世丌七丝七丑一丁, PGCompany.EventHub.丅丝丙与丑七不丛世 丂丒丁丑东丑丁丕丑)
        {
            string val_1;
            var val_2;
            UnityEngine.Texture val_3;
            val_1 = 丘世丌七丝七丑一丁;
            this.丁丘丄丕下专东七不 = 一丐丗丁丞丆丅丟丄;
            this.丁且且丒丞丅万丟东 = 丂丒丁丑东丑丁丕丑;
            val_2 = 0;
            goto label_1;
            label_9:
            if(val_1 != null)
            {
                    val_3 = val_1;
            }
            else
            {
                    val_3 = 0;
            }
            
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._textures[0], 与万丆丛丒万丝丙丑:  val_3);
            val_2 = 1;
            label_1:
            if(val_2 < this._textures.Length)
            {
                goto label_9;
            }
            
            this.丝丂丕东专世丅丝丁();
            if(val_1 != null)
            {
                    val_1 = val_1;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._eventName, 丕丗丘丑丛与丑业丒:  val_1);
        }
        private void 丝丂丕东专世丅丝丁()
        {
            UILabel val_9;
            string val_11;
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                goto label_3;
            }
            
            if(this.丁丘丄丕下专东七不 == null)
            {
                goto label_4;
            }
            
            if(this.丁丘丄丕下专东七不.丁丟丘世下丟万丙丕() == false)
            {
                goto label_5;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUntilEventStart, 丏业丟一东丂东丘丛:  true);
            int val_3 = this.丁丘丄丕下专东七不.与且七一丟丆上丙一();
            val_9 = this._timerUntilEventStart;
            string val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9890")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9890")) + " " + this.专世上丐丛丗丂丘丝(丙专业丞不丁一专丙:  1)(this.专世上丐丛丗丂丘丝(丙专业丞不丁一专丙:  1));
            goto label_11;
            label_3:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUntilEventStart, 丏业丟一东丂东丘丛:  false);
            return;
            label_4:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUntilEventStart, 丏业丟一东丂东丘丛:  true);
            val_9 = this._timerUntilEventStart;
            val_11 = "Key_4357";
            goto label_18;
            label_5:
            if(this.丁丘丄丕下专东七不.丐丄东丛东丛丕丘且() == false)
            {
                goto label_20;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUntilEventStart, 丏业丟一东丂东丘丛:  true);
            val_9 = this._timerUntilEventStart;
            val_11 = "Key_9889";
            label_18:
            label_11:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_9, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11));
            return;
            label_20:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUntilEventStart, 丏业丟一东丂东丘丛:  false);
            0.丈丟专丌丁丟万丟丁(三丈丞丘上丒丘丈万:  this);
        }
        private string 专世上丐丛丗丂丘丝(int 丙专业丞不丁一专丙)
        {
            string val_12;
            System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)this.丁丘丄丕下专东七不.与且七一丟丆上丙一());
            if(val_2._ticks.Days >= 1)
            {
                    val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6526");
                int val_5 = val_2._ticks.Days;
                return (string)System.String.Format(format:  val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6528"), arg0:  val_2._ticks.Minutes);
            }
            
            if(val_2._ticks.Hours >= 1)
            {
                    val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6527");
                int val_8 = val_2._ticks.Hours;
                return (string)System.String.Format(format:  val_12, arg0:  val_2._ticks.Minutes);
            }
            
            return (string)System.String.Format(format:  val_12, arg0:  val_2._ticks.Minutes);
        }
        internal bool 七丌丌东丄七上业丛()
        {
            return (bool)(this.丁丘丄丕下专东七不 == 0) ? 1 : 0;
        }
        private void Update()
        {
            if(this._activeState.activeSelf == false)
            {
                    return;
            }
            
            this.丝丂丕东专世丅丝丁();
        }
        public EventButton()
        {
        
        }
    
    }

}
