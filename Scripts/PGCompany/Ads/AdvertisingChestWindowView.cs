using UnityEngine;

namespace PGCompany.Ads
{
    internal sealed class AdvertisingChestWindowView : MonoBehaviour
    {
        // Fields
        internal UILabel headerLabel;
        internal UILabel subtitleLabel;
        internal UnityEngine.GameObject bottomContainer;
        internal UILabel allRewardsCollectedLabel;
        internal UILabel cooldownLabel;
        internal UILabel readyToWatchLabel;
        internal UIScrollView scrollView;
        internal ScrollViewHelper scrollViewHelper;
        internal UIGrid grid;
        internal UnityEngine.GameObject stateContainer;
        internal UnityEngine.GameObject waitNode;
        internal UnityEngine.GameObject failedNode;
        internal UnityEngine.GameObject watchingNode;
        internal UIButton watchButton;
        internal ExecuteOnEnable animationOnButton;
        internal ItemRewardListView itemRewardListView;
        internal UnityEngine.AudioClip chestClicked;
        internal UnityEngine.AudioClip newRewardAvailable;
        internal UnityEngine.AudioClip timerCompleted;
        private System.Action 丑丄七上丅业丌丘世;
        private System.Action 业丝下专丛世丏与丗;
        private System.Action 东万上丘丄丒且上丈;
        private System.Action 一丂丒丁丛七东七一;
        
        // Properties
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        internal System.Action 丞丒丈丛业专丒丏且 { set; }
        internal System.Action 不丅丑丝丑与丁上专 { set; }
        internal System.Action 丏丂丙一业一一不专 { set; }
        internal System.Action 丌东丘专上上丈丟丁 { set; }
        
        // Methods
        private static bool 世丈且业丆丑丏丐一()
        {
            return Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝();
        }
        internal void 丅三丏三丅世世丏下(System.Action 丙业与丙丗丝不丈东)
        {
            this.丑丄七上丅业丌丘世 = 丙业与丙丗丝不丈东;
        }
        internal void 世丅丌丆丆与东丏丑(System.Action 丙业与丙丗丝不丈东)
        {
            this.业丝下专丛世丏与丗 = 丙业与丙丗丝不丈东;
        }
        internal void 丑东三丁东丐丅上丐(System.Action 丙业与丙丗丝不丈东)
        {
            this.东万上丘丄丒且上丈 = 丙业与丙丗丝不丈东;
        }
        internal void 下上三业上万丛丌丐(System.Action 丙业与丙丗丝不丈东)
        {
            this.一丂丒丁丛七东七一 = 丙业与丙丗丝不丈东;
        }
        public void HandleCloseClicked()
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AdvertisingChestWindowView.HandleCloseClicked]");
            }
            
            if(this.丑丄七上丅业丌丘世 == null)
            {
                    return;
            }
            
            this.丑丄七上丅业丌丘世.Invoke();
        }
        public void HandleWatchClicked()
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AdvertisingChestWindowView.HandleWatchClicked]");
            }
            
            if(this.业丝下专丛世丏与丗 == null)
            {
                    return;
            }
            
            this.业丝下专丛世丏与丗.Invoke();
        }
        internal bool 一丙且万丝丛丕丑丑(UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
        {
            var val_3;
            if(丆与丈丏丟七丁东丛 != null)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  丆与丈丏丟七丁东丛);
                val_3 = 1;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        private void OnDestroy()
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AdvertisingChestWindowView.OnDestroy]");
            }
            
            if(this.东万上丘丄丒且上丈 == null)
            {
                    return;
            }
            
            this.东万上丘丄丒且上丈.Invoke();
        }
        private void OnDisable()
        {
            var val_4;
            ScrollViewHelper val_5;
            var val_6;
            ScrollViewHelper val_7;
            val_5 = this;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AdvertisingChestWindowView.OnDisable]");
            }
            
            if(this.一丂丒丁丛七东七一 != null)
            {
                    this.一丂丒丁丛七东七一.Invoke();
            }
            
            val_6 = 0;
            val_7 = this.scrollViewHelper;
            if(val_7 != 0)
            {
                    val_5 = this.scrollViewHelper;
                val_5.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            }
            
            val_5.丐丂丗东不丑丂世丟();
            if(0 == 1)
            {
                goto label_9;
            }
            
            if((val_6 == 0) || (70 == 70))
            {
                goto label_11;
            }
            
            label_12:
            val_4 = ???;
            val_6 = ???;
            val_5 = ???;
            val_7 = ???;
            label_9:
            if(val_6 != 0)
            {
                goto label_12;
            }
            
            label_11:
            var val_3 = val_4 - 48;
        }
        private void 丐丂丗东不丑丂世丟()
        {
            var val_5;
            Rilisoft.ItemViewer val_1 = 0;
            if((Rilisoft.ItemViewer.万不一一七世丂不不(丆丏万丐丕丒丌东丐: out  val_1)) == false)
            {
                    return;
            }
            
            val_5 = val_1.gameObject;
            if(val_5.activeSelf == false)
            {
                    return;
            }
            
            val_5 = val_1;
        }
        public AdvertisingChestWindowView()
        {
        
        }
    
    }

}
