using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class OfferwallWatchPanel : MonoBehaviour
    {
        // Fields
        private System.EventHandler ClosePressed;
        private System.EventHandler WatchPressed;
        private UILabel _watchHeader;
        private UILabel _watchTimer;
        private UIButton _watchButton;
        private UILabel _rewardGemsLabel;
        private UILabel _rewardCoinsLabel;
        
        // Properties
        internal UILabel WatchHeader { get; }
        internal UILabel WatchTimer { get; }
        internal UIButton WatchButton { get; }
        internal UILabel RewardGemsLabel { get; }
        internal UILabel RewardCoinsLabel { get; }
        
        // Methods
        internal UILabel get_WatchHeader()
        {
            return (UILabel)this._watchHeader;
        }
        internal UILabel get_WatchTimer()
        {
            return (UILabel)this._watchTimer;
        }
        internal UIButton get_WatchButton()
        {
            return (UIButton)this._watchButton;
        }
        internal UILabel get_RewardGemsLabel()
        {
            return (UILabel)this._rewardGemsLabel;
        }
        internal UILabel get_RewardCoinsLabel()
        {
            return (UILabel)this._rewardCoinsLabel;
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
            while(this.ClosePressed != 1152921543305315368);
        
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
            while(this.ClosePressed != 1152921543305451944);
        
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
            while(this.WatchPressed != 1152921543305588528);
        
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
            while(this.WatchPressed != 1152921543305725104);
        
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
            if(this.WatchPressed != null)
            {
                    val_1 = null;
                val_1 = null;
                this.WatchPressed.Invoke(sender:  this, e:  System.EventArgs.Empty);
            }
            
            this.OnClose();
        }
        public OfferwallWatchPanel()
        {
        
        }
    
    }

}
