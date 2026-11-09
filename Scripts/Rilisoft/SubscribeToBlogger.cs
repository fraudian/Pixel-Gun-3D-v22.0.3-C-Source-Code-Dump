using UnityEngine;

namespace Rilisoft
{
    internal class SubscribeToBlogger : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.丛且世丐丆上七业丁>
    {
        // Fields
        private static Rilisoft.SubscribeToBlogger <不丁丄七丛不丆丁丕>k__BackingField;
        private string bName;
        private string bUrl;
        private Rilisoft.SubscribeToBloggerBanner 下专丐丅丆丏三丂丅;
        private Rilisoft.PriceView _reward;
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        internal static Rilisoft.SubscribeToBlogger 丆丕丝丒不丙且丐丗 { get; set; }
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        internal static Rilisoft.SubscribeToBlogger 丑七不且上丗丁一世()
        {
            return (Rilisoft.SubscribeToBlogger)Rilisoft.SubscribeToBlogger.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.SubscribeToBlogger 丙业与丙丗丝不丈东)
        {
            Rilisoft.SubscribeToBlogger.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.丛且世丐丆上七业丁 get_Context()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            UnityEngine.Debug.LogError(message:  "ERROR!  Call setup with SubscribeToBloggerBanner!!!");
            this.Setup(与且专丈不万东一万:  与且专丈不万东一万, 丈丁丅丈丌三丕七丗:  0);
        }
        public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万, Rilisoft.SubscribeToBloggerBanner 丈丁丅丈丌三丕七丗)
        {
            this.下专丐丅丆丏三丂丅 = 丈丁丅丈丌三丕七丗;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            if(与且专丈不万东一万 == null)
            {
                    return;
            }
            
            if(与且专丈不万东一万.丟丗一丟丒丄丄丆丂() != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._reward, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._reward, 丏业丟一东丂东丘丛:  true);
            Rilisoft.GameEventData val_2 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁专丗万三上丟三丆();
            if(val_2.BloggerReward == null)
            {
                    return;
            }
            
            Rilisoft.GameEventData val_3 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁专丗万三上丟三丆();
            this._reward.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_3.BloggerReward, 万丐丁三且下丞丈丌:  0);
        }
        public void SubscribeButtonClick()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丗一丟丒丄丄丆丂()) != false)
            {
                    Rilisoft.一丟专且三万丞丁丂.丐丈丂丟专与与七丝(且东东世丏丒丑丆丑:  this.bName);
                UnityEngine.Application.OpenURL(url:  this.bUrl);
                return;
            }
            
            if(this.下专丐丅丆丏三丂丅 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.下专丐丅丆丏三丂丅, 丏业丟一东丂东丘丛:  true);
            this.下专丐丅丆丏三丂丅.Setup(与且专丈不万东一万:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        public void Subscribe()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丗一丟丒丄丄丆丂()) != true)
            {
                    Rilisoft.GameEventData val_2 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁专丗万三上丟三丆();
                if(val_2.BloggerReward != null)
            {
                    if(val_2.BloggerReward.丟丂丞不专丆万丒世() >= 1)
            {
                    BankController.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_2.BloggerReward.东与三丌丅三丒丏业(), 丌丒丝东丌下丕丁丅:  val_2.BloggerReward.丟丂丞不专丆万丒世(), 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  32, 丟世且丕丂丁万丒万:  0);
                this.<丅丝丌丝丁丏丙东丞>k__BackingField.丘丌不与丌丌不专丒(丙业与丙丗丝不丈东:  true);
            }
            
            }
            
                this.Setup(与且专丈不万东一万:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丈丁丅丈丌三丕七丗:  this.下专丐丅丆丏三丂丅);
            }
            
            Rilisoft.一丟专且三万丞丁丂.丐丈丂丟专与与七丝(且东东世丏丒丑丆丑:  this.bName);
            UnityEngine.Application.OpenURL(url:  this.bUrl);
        }
        private void OnEnable()
        {
            Rilisoft.SubscribeToBlogger.<不丁丄七丛不丆丁丕>k__BackingField = this;
        }
        private void OnDisable()
        {
            Rilisoft.SubscribeToBlogger.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        private void OnDestroy()
        {
            Rilisoft.SubscribeToBlogger.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        public SubscribeToBlogger()
        {
            this.bName = "Bigbst4tz2";
            this.bUrl = "https://www.youtube.com/user/Bigbst4tz2?sub_confirmation=1";
        }
    
    }

}
