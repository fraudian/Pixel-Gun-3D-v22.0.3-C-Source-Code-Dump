using UnityEngine;

namespace Rilisoft
{
    public class GameEventChestLapView : MonoBehaviour, 七丌且丛万与丞世丁<Rilisoft.与专丒丞丐一丒丂东, int>
    {
        // Fields
        private int 世丝丞七丅丝丄与三;
        private Rilisoft.与专丒丞丐一丒丂东 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private Rilisoft.GameEventSetItemView _itemView;
        private UITexture _progressIndicator;
        private UnityEngine.GameObject _completeIndicator;
        
        // Properties
        public Rilisoft.与专丒丞丐一丒丂东 丄丄一丐东丐丝丗七 { get; set; }
        public int 丌且丝丘丌丕东丒与 { get; set; }
        
        // Methods
        public Rilisoft.与专丒丞丐一丒丂东 get_Context()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public int get_Parameter()
        {
            return (int)this.世丝丞七丅丝丄与三;
        }
        public void set_Parameter(int 丙业与丙丗丝不丈东)
        {
            this.世丝丞七丅丝丄与三 = 丙业与丙丗丝不丈东;
            this.丝一丅丆三东丂丞七();
        }
        public void Setup(Rilisoft.与专丒丞丐一丒丂东 与且专丈不万东一万, int 丆且丁丒丒丆丁三丆)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.世丝丞七丅丝丄与三 = 丆且丁丒丒丆丁三丆;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(this._itemView != 0)
            {
                    int val_10 = this.世丝丞七丅丝丄与三;
                val_10 = val_10 + 1;
                if(val_10 > ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.专丝东丘一丐丛丂丛()) - 1))
            {
                    Rilisoft.GameEventItem val_4 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.下丅下下专丒业丝一();
            }
            else
            {
                    Rilisoft.GameEventItem val_5 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.且丗丌一万一丁丐不(丒丝丆一丏专且丌丝:  val_10);
            }
            
            }
            
            float val_6 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丗丏上丞丐丞丛丒丄(丒丝丆一丏专且丌丝:  this.世丝丞七丅丝丄与三);
            if(this._progressIndicator != 0)
            {
                    this._progressIndicator.fillAmount = val_6;
            }
            
            if(this._completeIndicator == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._completeIndicator, 丏业丟一东丂东丘丛:  (val_6 >= 1f) ? 1 : 0);
        }
        private void OnEnable()
        {
            if(this._itemView == 0)
            {
                    return;
            }
            
            this._itemView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventChestLapView::丗丂丄不丂丟专下东(Rilisoft.GameEventSetItemView 丑丂不下丁丄与万丏)));
            this._itemView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventChestLapView::丗丂丄不丂丟专下东(Rilisoft.GameEventSetItemView 丑丂不下丁丄与万丏)));
        }
        private void OnDisable()
        {
            this._itemView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventChestLapView::丗丂丄不丂丟专下东(Rilisoft.GameEventSetItemView 丑丂不下丁丄与万丏)));
        }
        private void 丗丂丄不丂丟专下东(Rilisoft.GameEventSetItemView 丑丂不下丁丄与万丏)
        {
            if(丑丂不下丁丄与万丏.Context == null)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            Rilisoft.GameEventItem val_5 = 丑丂不下丁丄与万丏.Context;
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
            {
                
            }
        
        }
        public GameEventChestLapView()
        {
        
        }
    
    }

}
