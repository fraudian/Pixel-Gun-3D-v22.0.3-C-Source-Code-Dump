using UnityEngine;

namespace Rilisoft
{
    internal class SubscribeToBloggerBanner : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.丛且世丐丆上七业丁>
    {
        // Fields
        private Rilisoft.PriceView _reward;
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
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
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            if(与且专丈不万东一万 == null)
            {
                    return;
            }
            
            Rilisoft.GameEventData val_1 = 与且专丈不万东一万.丁专丗万三上丟三丆();
            this._reward.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_1.BloggerReward, 万丐丁三且下丞丈丌:  0);
        }
        public void Subscribe()
        {
            this.Hide();
            if((Rilisoft.SubscribeToBlogger.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            Rilisoft.SubscribeToBlogger.<不丁丄七丛不丆丁丕>k__BackingField.Subscribe();
        }
        private void OnEnable()
        {
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.SubscribeToBloggerBanner::Hide()), 与且专丈不万东一万:  0);
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        private void OnDestroy()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        public void Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public SubscribeToBloggerBanner()
        {
        
        }
    
    }

}
