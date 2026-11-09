using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class CurrencySpecificWatchPanel : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _damageLabel;
        private UILabel _labelProgressNum;
        private UISprite _progressBarFon;
        private UISprite _progressBarHP;
        private UISprite _progressBarOldHP;
        private UIButton searchButton;
        private System.EventHandler ClosePressed;
        private System.EventHandler WatchPressed;
        private UILabel watchHeader;
        private UILabel watchTimer;
        private UIButton watchButton;
        private UILabel _rewardLabel;
        
        // Properties
        internal UILabel WatchHeader { get; }
        internal UILabel WatchTimer { get; }
        internal UIButton WatchButton { get; }
        internal UILabel RewardLabel { get; }
        
        // Methods
        internal UILabel get_WatchHeader()
        {
            return (UILabel)this.watchHeader;
        }
        internal UILabel get_WatchTimer()
        {
            return (UILabel)this.watchTimer;
        }
        internal UIButton get_WatchButton()
        {
            return (UIButton)this.watchButton;
        }
        internal UILabel get_RewardLabel()
        {
            return (UILabel)this._rewardLabel;
        }
        internal void 万三丆万丑丐丏丞一(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ClosePressed, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ClosePressed != 1152921542541129464);
        
        }
        internal void 丈且丛丟丐七丟丗丝(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ClosePressed, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ClosePressed != 1152921542541266040);
        
        }
        internal void 三一丈世丟三专专丄(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WatchPressed, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WatchPressed != 1152921542541402624);
        
        }
        internal void 丏丆丗丆丝与丛上丈(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WatchPressed, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WatchPressed != 1152921542541539200);
        
        }
        public void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.上丛丏世专丈东丑丁());
            this.丗丟丟丘万丁丞丅下();
        }
        private void OnDisable()
        {
            this.StopCoroutine(routine:  this.上丛丏世专丈东丑丁());
        }
        public void OnGetRewardOpen()
        {
            Rilisoft.ZombieGameView.且丕丈丙丛不业丂丗().万三丆万丑丐丏丞一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.CurrencySpecificWatchPanel::丟专丗丗业专丄丙东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            Rilisoft.ZombieGameView.且丕丈丙丛不业丂丗().GetReward();
            this.gameObject.SetActive(value:  false);
        }
        private void 丟专丗丗业专丄丙东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            Rilisoft.ZombieGameView.且丕丈丙丛不业丂丗().丈且丛丟丐七丟丗丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.CurrencySpecificWatchPanel::丟专丗丗业专丄丙东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.gameObject.SetActive(value:  true);
        }
        private System.Collections.IEnumerator 上丛丏世专丈东丑丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new CurrencySpecificWatchPanel.不且业丗下丆丅丞丒();
        }
        private void 丗丟丟丘万丁丞丅下()
        {
            if(ZombiKillController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            1152921504848912384 = this.searchButton;
            if(1152921504848912384 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.searchButton, 丏业丟一东丂东丘丛:  (ZombiKillController.丑七不且上丗丁一世().GetCurrentZombieHP() < 1) ? 1 : 0);
        }
        public void OnClose()
        {
            var val_1;
            if(this.ClosePressed == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.ClosePressed.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        public void OnWatch()
        {
            var val_1;
            if(this.WatchPressed == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.WatchPressed.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        public CurrencySpecificWatchPanel()
        {
        
        }
    
    }

}
