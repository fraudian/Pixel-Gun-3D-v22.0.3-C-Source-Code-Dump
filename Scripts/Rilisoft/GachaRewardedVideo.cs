using UnityEngine;

namespace Rilisoft
{
    internal sealed class GachaRewardedVideo : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.GachaRewardedVideo.丒且万不丌丁丂丒丟> 丗下丘世三七一专丕;
        public UnityEngine.GameObject windowBlocker;
        private System.EventHandler<Rilisoft.与丞专七丙专下丅且> 与丌三丕七东丆丞丑;
        private System.EventHandler 丟且丙与丄东上与丝;
        private System.EventHandler 丁上丂万丄七丞丅三;
        private UnityEngine.GameObject waitingPanel;
        private UnityEngine.GameObject watchingPanel;
        private UnityEngine.GameObject failurePanel;
        private UnityEngine.GameObject simulateButton;
        private UITexture loadingSpinner;
        
        // Methods
        private GachaRewardedVideo()
        {
            this.丗下丘世三七一专丕 = new GachaRewardedVideo.丏丈七万丈丗下世万(丈丐上东丁丟万丁丆:  this);
        }
        public void add_EnterIdle(System.EventHandler<Rilisoft.与丞专七丙专下丅且> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.与丌三丕七东丆丞丑, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丌三丕七东丆丞丑 != 1152921542220985504);
        
        }
        public void remove_EnterIdle(System.EventHandler<Rilisoft.与丞专七丙专下丅且> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.与丌三丕七东丆丞丑, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丌三丕七东丆丞丑 != 1152921542221122080);
        
        }
        public void add_ExitIdle(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丟且丙与丄东上与丝, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丟且丙与丄东上与丝 != 1152921542221258664);
        
        }
        public void remove_ExitIdle(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丟且丙与丄东上与丝, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丟且丙与丄东上与丝 != 1152921542221395240);
        
        }
        public void add_AdWatchedSuccessfully(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丁上丂万丄七丞丅三, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁上丂万丄七丞丅三 != 1152921542221531824);
        
        }
        public void remove_AdWatchedSuccessfully(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丁上丂万丄七丞丅三, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁上丂万丄七丞丅三 != 1152921542221668400);
        
        }
        public void OnCloseFailurePanel()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  4);
        }
        public void OnCloseWatchingPanel()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  4);
        }
        public void OnSimulateButtonClicked()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  3);
        }
        public void OnWatchButtonClicked()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  3);
        }
        private void Awake()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  1);
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.GachaRewardedVideo::七丕东丘丑丞三丏丑()), 与且专丈不万东一万:  this.GetType());
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
            this.丐丆七且丞丏下三丙 = 0;
        }
        private void Update()
        {
            if(this.windowBlocker == 0)
            {
                goto label_3;
            }
            
            if(this.waitingPanel.activeInHierarchy != true)
            {
                    if(this.watchingPanel.activeInHierarchy == false)
            {
                goto label_7;
            }
            
            }
            
            if(this.windowBlocker != null)
            {
                goto label_10;
            }
            
            label_11:
            label_10:
            this.windowBlocker.SetActive(value:  true);
            label_3:
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  2);
            return;
            label_7:
            UnityEngine.GameObject val_5 = this.failurePanel;
            val_5 = val_5.activeInHierarchy;
            if(this.windowBlocker != null)
            {
                goto label_10;
            }
            
            goto label_11;
        }
        private void 七丕东丘丑丞三丏丑()
        {
            if(this.丗下丘世三七一专丕 != null)
            {
                    this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  4);
                return;
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.GachaRewardedVideo::OnCloseFailurePanel()), 与且专丈不万东一万:  this.GetType());
        }
        private void 东东七丕世业丞丌世(Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
        {
            if(this.与丌三丕七东丆丞丑 == null)
            {
                    return;
            }
            
            this.与丌三丕七东丆丞丑.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 丐丁丕丆丌丂丅丙丏(System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.丟且丙与丄东上与丝 == null)
            {
                    return;
            }
            
            this.丟且丙与丄东上与丝.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 东丈丕丁七与上丕三(System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.丁上丂万丄七丞丅三 == null)
            {
                    return;
            }
            
            this.丁上丂万丄七丞丅三.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 丝丂七丑不东业东丛(Rilisoft.GachaRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
        {
            if(this.丗下丘世三七一专丕 == null)
            {
                    return;
            }
            
            this.丗下丘世三七一专丕 = this.丗下丘世三七一专丕;
            this = this.丗下丘世三七一专丕;
            if(this == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.Dispose();
        }
        private static void 丈丐丐丂丑丅丟与丁(string 丄丙下丝丛丒七丂丘)
        {
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            object[] val_4 = new object[2];
            val_4[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_4[1] = 丄丙下丝丛丒七丂丘;
            UnityEngine.Debug.LogFormat(format:  (UnityEngine.Application.isEditor != true) ? "<color=cyan>[{0}] {1}</color>" : "[{0}] {1}", args:  val_4);
        }
    
    }

}
