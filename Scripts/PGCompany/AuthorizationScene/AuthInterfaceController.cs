using UnityEngine;

namespace PGCompany.AuthorizationScene
{
    internal class AuthInterfaceController : MonoBehaviour
    {
        // Fields
        private AuthSceneState <丒一七丙万业上且三>k__BackingField;
        internal UnityEngine.Transform UpdateBannerPoint;
        private UITexture _background;
        private UnityEngine.Texture _comicBackground;
        private UnityEngine.Texture _defaultBackground;
        private PGCompany.AuthorizationScene.AccountBlockedWindow _bannedGO;
        private UnityEngine.GameObject _reconnectWindow;
        private UnityEngine.GameObject _reconnectOrOfflineWindow;
        private UnityEngine.GameObject _reconnectOrOfflineWindowSocket;
        private System.Collections.Generic.List<UnityEngine.GameObject> _offlineButtonsForRealtimeDisabling;
        private string _inactiveButtonSpriteName;
        private System.Collections.Generic.List<string> 不丏丈丞丌业丄上丐;
        private System.Action 丆且丛丗一丐东万专;
        private System.Action 专丈丙丝且丒丆丙下;
        private System.Action 下丞七丟业丑丆丆丂;
        private System.Action 世下丐丞丌丑丄丁丒;
        
        // Properties
        internal AuthSceneState 丙丟与丐三丐万万丆 { get; set; }
        
        // Methods
        internal AuthSceneState 丄丙丂丝丄丌丗丂丅()
        {
            return (AuthSceneState)this.<丒一七丙万业上且三>k__BackingField;
        }
        private void 丌七丗东三丏东丅丕(AuthSceneState 丙业与丙丗丝不丈东)
        {
            this.<丒一七丙万业上且三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 且东丈与与东业丗丏(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丆且丛丗一丐东万专, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆且丛丗一丐东万专 != 1152921560204277896);
        
        }
        internal void 丘下东下万与丞丁丙(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丆且丛丗一丐东万专, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆且丛丗一丐东万专 != 1152921560204414472);
        
        }
        internal void 丁七丈丂丌丕世万三(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.专丈丙丝且丒丆丙下, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专丈丙丝且丒丆丙下 != 1152921560204551056);
        
        }
        internal void 丄丗丌丞丂且丒丐丅(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.专丈丙丝且丒丆丙下, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专丈丙丝且丒丆丙下 != 1152921560204687632);
        
        }
        internal void 丏丘东专世丛丝不不(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.下丞七丟业丑丆丆丂, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下丞七丟业丑丆丆丂 != 1152921560204824216);
        
        }
        internal void 三上世丁丌丈丑一万(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.下丞七丟业丑丆丆丂, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下丞七丟业丑丆丆丂 != 1152921560204960792);
        
        }
        internal void 丒且丒丏专业三丂七(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.世下丐丞丌丑丄丁丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.世下丐丞丌丑丄丁丒 != 1152921560205097376);
        
        }
        internal void 丑丙丟丁丂丙丁丛下(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.世下丐丞丌丑丄丁丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.世下丐丞丌丑丄丁丒 != 1152921560205233952);
        
        }
        private void Awake()
        {
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
            {
                goto label_2;
            }
            
            if(Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂() == 0)
            {
                goto label_7;
            }
            
            UnityEngine.Texture2D val_5 = Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂();
            goto label_10;
            label_2:
            UnityEngine.Texture val_7 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Switcher.丌三丟丈东丑七丑上(丑丅世丐丒丏丐三丅:  3));
            label_10:
            if(this._background != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            ActivityIndicator.丞丂一丝三丄专丆一(丝丘专世丏三丝下丐:  0);
            return;
            label_7:
            if(this._background != null)
            {
                goto label_16;
            }
            
            goto label_17;
        }
        internal void 且丙丗丙丅丑丕丞丞(AuthSceneState 丏业丟一东丂东丘丛)
        {
            this.<丒一七丙万业上且三>k__BackingField = 丏业丟一东丂东丘丛;
            this.丞丝丗丗丏丏丏丄丄();
        }
        private void 丞丝丗丗丏丏丏丄丄()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._bannedGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._reconnectWindow, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._reconnectOrOfflineWindow, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._reconnectOrOfflineWindowSocket, 丏业丟一东丂东丘丛:  false);
            AuthSceneState val_1 = this.<丒一七丙万业上且三>k__BackingField;
            if(val_1 > 16)
            {
                    return;
            }
            
            val_1 = 1 << val_1;
            val_1 = val_1 & 101592;
            if(val_1 == 0)
            {
                    return;
            }
            
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
            ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  false);
            ActivityIndicator.不丌世万丌丘丘丒上 + 80.SetActive(value:  false);
        }
        internal void 世专丙世三上业丏丑(int 丘丐且丅与丑丛丒丄)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._bannedGO, 丏业丟一东丂东丘丛:  true);
            this._bannedGO.丄与丕丌业丝丌丅三 = 丘丐且丅与丑丛丒丄;
            this._bannedGO.丌东一丅丌丕丕丞丟 = new System.Action(object:  this, method:  System.Void PGCompany.AuthorizationScene.AuthInterfaceController::丏东七丞丛世一世丛());
            this._bannedGO.丗下丕丕丂世丙与不 = new System.Action(object:  this, method:  System.Void PGCompany.AuthorizationScene.AuthInterfaceController::与丑丂一且三且丐世());
        }
        internal void 丄丘丗丞丟丘丒丗业(PGCompany.AuthorizationScene.AuthInterfaceController.世丂七上丄丑万丗一 世丁丙世丄一万丆三)
        {
            var val_5;
            UnityEngine.GameObject val_6;
            if(世丁丙世丄一万丆三 != 2)
            {
                    val_5 = null;
                val_6 = this._reconnectOrOfflineWindow;
            }
            else
            {
                    val_5 = null;
                val_6 = this._reconnectOrOfflineWindowSocket;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
            if(OfflineModController.丂丁丌丘丗丅专专丛() != false)
            {
                    this.丙丅丙丟三七丞丈丆();
            }
            else
            {
                    this.丂业丄丝丑丑丙三一();
            }
            
            if(this._reconnectOrOfflineWindow.activeSelf != true)
            {
                    if(this._reconnectOrOfflineWindowSocket.activeSelf == false)
            {
                goto label_13;
            }
            
            }
            
            if(GamepadCursorController.丆丕丝丒不丙且丐丗 != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
            return;
            label_13:
            UnityEngine.GameObject val_5 = this._reconnectOrOfflineWindow;
            val_5 = val_5.activeSelf;
            if(GamepadCursorController.丆丕丝丒不丙且丐丗 != null)
            {
                goto label_16;
            }
            
            goto label_17;
        }
        internal void 业万万丕丒且下一丑()
        {
            GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._reconnectWindow, 丏业丟一东丂东丘丛:  true);
        }
        public void OnGoOfflineClick()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  23);
            if(this.丆且丛丗一丐东万专 == null)
            {
                    return;
            }
            
            this.丆且丛丗一丐东万专.Invoke();
        }
        public void OnReconnectClick()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  23);
            if(this.专丈丙丝且丒丆丙下 == null)
            {
                    return;
            }
            
            this.专丈丙丝且丒丆丙下.Invoke();
        }
        private void 与丑丂一且三且丐世()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            if(this.下丞七丟业丑丆丆丂 == null)
            {
                    return;
            }
            
            this.下丞七丟业丑丆丆丂.Invoke();
        }
        private void 丏东七丞丛世一世丛()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            if(this.世下丐丞丌丑丄丁丒 == null)
            {
                    return;
            }
            
            this.世下丐丞丌丑丄丁丒.Invoke();
        }
        private void 丙丅丙丟三七丞丈丆()
        {
            var val_3;
            this.一上丙丈且丂丏丕一();
            List.Enumerator<T> val_1 = this._offlineButtonsForRealtimeDisabling.GetEnumerator();
            goto label_2;
            label_14:
            string val_4 = val_3.丐丏七丌丕丗业且上();
            UISprite val_5 = val_4.GetComponent<UISprite>();
            if(val_5 != 0)
            {
                    val_5.spriteName = this.不丏丈丞丌业丄上丐.Item[0];
            }
            
            UIButton val_8 = val_4.GetComponent<UIButton>();
            if(val_8 != 0)
            {
                    val_8.enabled = true;
            }
            
            label_2:
            if(((-234699856) & 1) != 0)
            {
                goto label_14;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丂业丄丝丑丑丙三一()
        {
            var val_3;
            this.一上丙丈且丂丏丕一();
            List.Enumerator<T> val_1 = this._offlineButtonsForRealtimeDisabling.GetEnumerator();
            label_13:
            if(((-234542800) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            UISprite val_5 = val_4.GetComponent<UISprite>();
            if(val_5 != 0)
            {
                    val_5.spriteName = this._inactiveButtonSpriteName;
            }
            
            UIButton val_7 = val_4.GetComponent<UIButton>();
            if(val_7 == 0)
            {
                goto label_13;
            }
            
            val_7.enabled = false;
            goto label_13;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 一上丙丈且丂丏丕一()
        {
            if(this.不丏丈丞丌业丄上丐 != null)
            {
                    return;
            }
            
            this.不丏丈丞丌业丄上丐 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_2 = this._offlineButtonsForRealtimeDisabling.GetEnumerator();
            label_10:
            if(((-234381624) & 1) == 0)
            {
                goto label_3;
            }
            
            UISprite val_4 = 0.丐丏七丌丕丗业且上().GetComponent<UISprite>();
            if(val_4 == 0)
            {
                goto label_10;
            }
            
            this.不丏丈丞丌业丄上丐.Add(item:  val_4.spriteName);
            goto label_10;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public AuthInterfaceController()
        {
        
        }
    
    }

}
