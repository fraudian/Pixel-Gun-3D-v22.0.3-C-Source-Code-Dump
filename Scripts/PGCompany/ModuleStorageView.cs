using UnityEngine;

namespace PGCompany
{
    internal class ModuleStorageView : MonoBehaviour
    {
        // Fields
        private UIGrid _grid;
        private PGCompany.ModuleSlotView _slotView;
        private bool _hideEmptySlotView;
        private PGCompany.丗丟丅七东丄丙丟上 丂丐丗专丞与丄丕万;
        private System.Collections.Generic.List<PGCompany.ModuleSlotView> 三丝一丙上丞专丏丌;
        
        // Properties
        internal PGCompany.丗丟丅七东丄丙丟上 丗丟丅七东丄丙丟上 { get; }
        internal System.Collections.Generic.List<PGCompany.ModuleSlotView> 且一丕世丕丂丝三业 { get; }
        
        // Methods
        internal PGCompany.丗丟丅七东丄丙丟上 丅万万丈世业业丗世()
        {
            return (PGCompany.丗丟丅七东丄丙丟上)this.丂丐丗专丞与丄丕万;
        }
        internal System.Collections.Generic.List<PGCompany.ModuleSlotView> 丏丈丝丌丗东不丌丙()
        {
            return (System.Collections.Generic.List<PGCompany.ModuleSlotView>)this.三丝一丙上丞专丏丌;
        }
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._slotView, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丅七东丄丙丟上 丑专丆丟丟丐丆一丕)
        {
            if(丑专丆丟丟丐丆一丕 == null)
            {
                    return;
            }
            
            this.丂丐丗专丞与丄丕万 = 丑专丆丟丟丐丆一丕;
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_17;
            var val_19;
            PGCompany.丏丂一丗丙世丏丐三 val_20;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = this.丂丐丗专丞与丄丕万.丏丝丄丄丗丟丙不丆();
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ModuleSlotView>(专下丐丒丈万丗丟丝:  this.三丝一丙上丞专丏丌, 专丑业丁丗丏丌不丛:  this._slotView.gameObject, 丈东丘丏与丌东东下:  this._grid.transform, 与业丄丂丂丆下上丞:  -315565904, 丏东下下一丗专下丏:  0);
            val_17 = null;
            val_17 = null;
            if((ModuleStorageView.<>c.<>9__11_0) == null)
            {
                goto label_8;
            }
            
            label_33:
            this.三丝一丙上丞专丏丌.ForEach(action:  ModuleStorageView.<>c.<>9__11_0);
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_4 = this.丂丐丗专丞与丄丕万.丆丟且丗丒不丄七丌();
            val_19 = 0;
            goto label_12;
            label_28:
            if(val_19 < val_4.Count)
            {
                    val_20 = val_4.Item[0];
            }
            else
            {
                    val_20 = 0;
            }
            
            this.三丝一丙上丞专丏丌.Item[0].丈且东丑丂且万丒丅(丕上业丕丘上丘七一:  val_20);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.三丝一丙上丞专丏丌.Item[0], 丏业丟一东丂东丘丛:  ((val_20 != 0) ? 1 : 0) | ((this._hideEmptySlotView == false) ? 1 : 0));
            if(val_20 != 0)
            {
                    if((this.丂丐丗专丞与丄丕万.专一三世与丌与丐丑().Contains(item:  val_20)) != false)
            {
                    this.三丝一丙上丞专丏丌.Item[0].一东上下丆丌丁丐丙();
            }
            
            }
            
            val_19 = 1;
            label_12:
            Rilisoft.丝丑丂丛万丐丈丘且 val_15 = this.丂丐丗专丞与丄丕万.丏丝丄丄丗丟丙不丆();
            if(val_19 < )
            {
                goto label_28;
            }
            
            this._grid.repositionNow = true;
            return;
            label_8:
            ModuleStorageView.<>c.<>9__11_0 = new System.Action<PGCompany.ModuleSlotView>(object:  ModuleStorageView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ModuleStorageView.<>c::万丄专且一丈丌上丌(PGCompany.ModuleSlotView 三丟东丕丄丄下下丑));
            if(this.三丝一丙上丞专丏丌 != null)
            {
                goto label_33;
            }
            
            goto label_33;
        }
        public ModuleStorageView()
        {
            this.三丝一丙上丞专丏丌 = new System.Collections.Generic.List<PGCompany.ModuleSlotView>();
        }
    
    }

}
