using UnityEngine;

namespace Rilisoft
{
    public class ClanChestUnlockWindow : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑
    {
        // Fields
        private UIBasicSprite _chestTexture;
        private UnityEngine.GameObject _coinObject;
        private UnityEngine.GameObject _gemObject;
        private System.Collections.Generic.List<UILabel> _headerLabels;
        private UILabel _priceLabel;
        private UITable _priceTable;
        private bool 一且丁世丏丄丌一丟;
        private System.Action<bool> 丛丄业丘不丆丄三丞;
        
        // Properties
        private UIBasicSprite 丐世丛东丈丒东不丒 { get; }
        public bool 东且世与一东丂一丆 { get; }
        
        // Methods
        private UIBasicSprite 丁丗丝丂与七与丙丂()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._chestTexture);
            this._chestTexture = val_1;
            return val_1;
        }
        public bool get___InterfaceEnabled()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void HideWindow()
        {
            if(this.__InterfaceEnabled == false)
            {
                    return;
            }
            
            if(this.丛丄业丘不丆丄三丞 != null)
            {
                    this.丛丄业丘不丆丄三丞.Invoke(obj:  this.一且丁世丏丄丌一丟);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void ShowWindow()
        {
            if(this.__InterfaceEnabled != false)
            {
                    return;
            }
            
            this.一且丁世丏丄丌一丟 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        public void add_OnHide(System.Action<bool> 丙业与丙丗丝不丈东)
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
            while(this.丛丄业丘不丆丄三丞 != 1152921542376727648);
        
        }
        public void remove_OnHide(System.Action<bool> 丙业与丙丗丝不丈东)
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
            while(this.丛丄业丘不丆丄三丞 != 1152921542376864224);
        
        }
        public void Set(世不丁七七丘业专丅 丐下丝丘丑丟丟丗丌)
        {
            var val_11;
            System.Collections.Generic.List<UILabel> val_12;
            var val_13;
            val_11 = this;
            if(丐下丝丘丑丟丟丗丌 == null)
            {
                    return;
            }
            
            UIBasicSprite val_1 = this.丁丗丝丂与七与丙丂();
            if(this._headerLabels != null)
            {
                    .丕不丝丙三丕丗丅丌 = System.String.alignConst;
                val_12 = this._headerLabels;
                val_12.ForEach(action:  new System.Action<UILabel>(object:  new ClanChestUnlockWindow.丞丆丌万丛不且七丐(), method:  System.Void ClanChestUnlockWindow.丞丆丌万丛不且七丐::万丛丙丘下丂丟丈丑(UILabel 丐三丞七丝丅不万丛)));
            }
            
            this._priceTable.repositionNow = true;
            val_11 = ???;
            val_13 = ???;
            goto typeof(UITable).__il2cppRuntimeField_1A8;
        }
        public void U_Confirm()
        {
            this.一且丁世丏丄丌一丟 = true;
            this.HideWindow();
        }
        public void U_Dismiss()
        {
            this.一且丁世丏丄丌一丟 = false;
            this.HideWindow();
        }
        public ClanChestUnlockWindow()
        {
        
        }
    
    }

}
