using UnityEngine;

namespace Rilisoft
{
    public class GameEventMiniGameChectButtonView : MonoBehaviour, 七丌且丛万与丞世丁<Rilisoft.与专丒丞丐一丒丂东, Rilisoft.GameEventMiniGameChectButtonView.丝下丐丁专丂丈业一>, 万丟丞不世丛七一专<Rilisoft.GameEventMiniGameChectButtonView>
    {
        // Fields
        private Rilisoft.GameEventMiniGameChectButtonView.丝下丐丁专丂丈业一 世丝丞七丅丝丄与三;
        private Rilisoft.与专丒丞丐一丒丂东 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Action<Rilisoft.GameEventMiniGameChectButtonView> 丅丕丌丛万丂丈七与;
        private UIBasicSprite _texture;
        private UILabel _name;
        private Rilisoft.PriceView _spinPrice;
        private UnityEngine.GameObject _default;
        private UnityEngine.GameObject _ready;
        private UnityEngine.GameObject _done;
        private UILabel _detailsCountLabel;
        private UnityEngine.GameObject _spinAvailable;
        
        // Properties
        public Rilisoft.与专丒丞丐一丒丂东 丄丄一丐东丐丝丗七 { get; set; }
        public Rilisoft.GameEventMiniGameChectButtonView.丝下丐丁专丂丈业一 丌且丝丘丌丕东丒与 { get; set; }
        
        // Methods
        public Rilisoft.与专丒丞丐一丒丂东 get_Context()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.GameEventMiniGameChectButtonView.丝下丐丁专丂丈业一 get_Parameter()
        {
            return (丝下丐丁专丂丈业一)this.世丝丞七丅丝丄与三;
        }
        public void set_Parameter(Rilisoft.GameEventMiniGameChectButtonView.丝下丐丁专丂丈业一 丙业与丙丗丝不丈东)
        {
            this.世丝丞七丅丝丄与三 = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.与专丒丞丐一丒丂东 与且专丈不万东一万, Rilisoft.GameEventMiniGameChectButtonView.丝下丐丁专丂丈业一 丆且丁丒丒丆丁三丆)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.世丝丞七丅丝丄与三 = 丆且丁丒丒丆丁三丆;
            this.丝一丅丆三东丂丞七();
        }
        public void add_Clicked(System.Action<Rilisoft.GameEventMiniGameChectButtonView> 丙业与丙丗丝不丈东)
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
            while(this.丅丕丌丛万丂丈七与 != 1152921542761869544);
        
        }
        public void remove_Clicked(System.Action<Rilisoft.GameEventMiniGameChectButtonView> 丙业与丙丗丝不丈东)
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
            while(this.丅丕丌丛万丂丈七与 != 1152921542762006120);
        
        }
        private void OnEnable()
        {
            BankController.丕丝丌丅七丌三万丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventMiniGameChectButtonView::丈丝世丗丝与丞丗丅(int 万且万且丑丗且丌丆)));
        }
        private void OnDisable()
        {
            BankController.丘与丗丆专丘丞丂丞(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventMiniGameChectButtonView::丈丝世丗丝与丞丗丅(int 万且万且丑丗且丌丆)));
        }
        private void 丈丝世丗丝与丞丗丅(int 万且万且丑丗且丌丆)
        {
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            UnityEngine.GameObject val_17;
            丝下丐丁专丂丈业一 val_18;
            val_17 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            UnityEngine.Texture val_1 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.东七丗丝丟丈下世丛();
            this._name.text = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丕丗丙丞丛丞丁专丁();
            val_18 = this.世丝丞七丅丝丄与三;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._default, 丏业丟一东丂东丘丛:  (val_18 == 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._ready, 丏业丟一东丂东丘丛:  (this.世丝丞七丅丝丄与三 == 1) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._done, 丏业丟一东丂东丘丛:  (this.世丝丞七丅丝丄与三 == 2) ? 1 : 0);
            if(this._spinPrice != 0)
            {
                    val_18 = this.世丝丞七丅丝丄与三;
                UnityEngine.GameObject val_7 = this._spinPrice.gameObject;
                if(val_18 != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  false);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
                val_18 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
                this._spinPrice.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_18, 万丐丁三且下丞丈丌:  0);
            }
            
            }
            
            if(this._detailsCountLabel != 0)
            {
                    val_18 = this._detailsCountLabel;
                val_18.text = System.String.Format(format:  "{0}/{1}", arg0:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丑专丐丐丏丆东丘万(), arg1:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.东丂七不丄丑丄丆七());
            }
            
            if(this._spinAvailable == 0)
            {
                    return;
            }
            
            val_17 = this._spinAvailable;
            val_18 = BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅东丄丛上丁丐万丏());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世()) <= val_18) ? 1 : 0);
        }
        public void U_Click()
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        public void U_ShowInfo()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            this = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().transform;
            Rilisoft.ItemViewer val_4 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this, 丕丁下丌不万丅丞丛:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅三专且丈一丝丂丏(), 丅三丟世下丞丝丙万:  1, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        }
        public GameEventMiniGameChectButtonView()
        {
        
        }
    
    }

}
