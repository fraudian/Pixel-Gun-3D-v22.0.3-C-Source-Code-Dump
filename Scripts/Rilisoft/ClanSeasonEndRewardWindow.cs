using UnityEngine;

namespace Rilisoft
{
    public class ClanSeasonEndRewardWindow : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UILabel _rewardDescriptionLabel;
        private System.Action 丛丄业丘不丆丄三丞;
        
        // Properties
        public bool 东且世与一东丂一丆 { get; }
        
        // Methods
        public bool get___InterfaceEnabled()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void ShowWindow()
        {
        
        }
        public void HideWindow()
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            if(this.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            this.丛丄业丘不丆丄三丞.Invoke();
        }
        public void add_OnHide(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921542397724888);
        
        }
        public void remove_OnHide(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921542397861464);
        
        }
        public void U_Hide()
        {
            this.HideWindow();
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
        public ClanSeasonEndRewardWindow()
        {
        
        }
    
    }

}
