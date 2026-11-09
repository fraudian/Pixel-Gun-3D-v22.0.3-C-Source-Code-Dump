using UnityEngine;

namespace Rilisoft
{
    public sealed class ButtonHandler : PGBehaviour
    {
        // Fields
        public bool isEnable;
        public bool noSound;
        private UnityEngine.AudioClip customSound;
        private System.EventHandler 丅丕丌丛万丂丈七与;
        private System.EventHandler 专丛丆丁一丏丝丒专;
        private System.Action<bool> 丝世丆丏丙丂东丐丕;
        
        // Properties
        public bool 丝上丙丌上丏丅丅丏 { get; }
        
        // Methods
        public bool get_HasClickedHandlers()
        {
            return (bool)(this.丅丕丌丛万丂丈七与 != 0) ? 1 : 0;
        }
        public void add_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921542353080712);
        
        }
        public void remove_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921542353217288);
        
        }
        public void add_OutUnPress(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.专丛丆丁一丏丝丒专, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专丛丆丁一丏丝丒专 != 1152921542353353872);
        
        }
        public void remove_OutUnPress(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.专丛丆丁一丏丝丒专, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专丛丆丁一丏丝丒专 != 1152921542353490448);
        
        }
        public void add_OnPressed(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丝世丆丏丙丂东丐丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝世丆丏丙丂东丐丕 != 1152921542353627032);
        
        }
        public void remove_OnPressed(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丝世丆丏丙丂东丐丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝世丆丏丙丂东丐丕 != 1152921542353763608);
        
        }
        private void OnClick()
        {
            var val_5;
            if(this.isEnable == false)
            {
                    return;
            }
            
            if(this.noSound == false)
            {
                goto label_2;
            }
            
            label_19:
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  System.EventArgs.Empty);
            return;
            label_2:
            if(this.customSound == 0)
            {
                goto label_8;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                goto label_19;
            }
            
            UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.customSound);
            goto label_19;
            label_8:
            if(ButtonClickSound.丆丕丝丒不丙且丐丗 == 0)
            {
                goto label_19;
            }
            
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            goto label_19;
        }
        public void DoClick()
        {
            if(this.isEnable == false)
            {
                    return;
            }
            
            this.OnClick();
        }
        public void ForcedClick()
        {
            this.isEnable = true;
            this.OnClick();
        }
        public void ClearEvents()
        {
            this.丅丕丌丛万丂丈七与 = 0;
        }
        private void OnPress(bool 丆丟专丑丁丒丁上丙)
        {
            UnityEngine.GameObject val_4;
            var val_5;
            var val_6;
            if(丆丟专丑丁丒丁上丙 != true)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = mem[UICamera.currentTouch + 72];
                val_4 = UICamera.currentTouch.上丞丕专丈业丁世专;
                if(val_4 != this.gameObject)
            {
                    val_4 = this.专丛丆丁一丏丝丒专;
                if(val_4 != null)
            {
                    val_6 = null;
                val_6 = null;
                val_4.Invoke(sender:  this, e:  System.EventArgs.Empty);
            }
            
            }
            
            }
            
            if(this.丝世丆丏丙丂东丐丕 == null)
            {
                    return;
            }
            
            this.丝世丆丏丙丂东丐丕.Invoke(obj:  丆丟专丑丁丒丁上丙);
        }
        internal void 丅丁丝丁丈丛丐且丑(bool 丆丛丆丞下丅丂且丝)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UIButton>())) != false)
            {
                    bool val_3 = 丆丛丆丞下丅丂且丝;
            }
            
            UnityEngine.Collider val_4 = this.GetComponent<UnityEngine.Collider>();
            if((UnityEngine.Object.op_Implicit(exists:  val_4)) != false)
            {
                    val_4.enabled = 丆丛丆丞下丅丂且丝;
            }
            
            this.isEnable = 丆丛丆丞下丅丂且丝;
        }
        public ButtonHandler()
        {
            this.isEnable = true;
        }
    
    }

}
