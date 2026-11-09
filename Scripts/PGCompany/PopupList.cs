using UnityEngine;

namespace PGCompany
{
    public class PopupList : PGBehaviour
    {
        // Fields
        private UIButton _openCloseButton;
        private System.Collections.Generic.List<UnityEngine.GameObject> _openedStateObjects;
        private System.Collections.Generic.List<UnityEngine.GameObject> _closedStateObjects;
        private UnityEngine.GameObject _gridItemExample;
        private UIGrid _itemsGrid;
        private UILabel _headerLabel;
        private bool 丛专下丞丛丆丙且一;
        private PGCompany.丂丈丘三丒丈不专丘 丆丗丟与丏丁且丒丕;
        private readonly System.Collections.Generic.List<PGCompany.丂丈丘三丒丈不专丘> 丛不丞丂七丞世丁丏;
        private readonly System.Collections.Generic.List<UnityEngine.GameObject> 七丕丌丘丄业世丙一;
        internal System.Action 一万丈丝丈下丘万丙;
        internal System.Action 丄丑上丕丂丈丘丙七;
        private System.Action<PGCompany.丂丈丘三丒丈不专丘> 上一一丙丄丛丁丆丑;
        
        // Properties
        internal bool 万下且丏丗下与丂丗 { get; }
        internal PGCompany.丂丈丘三丒丈不专丘 专一丟丆专丟一世一 { get; }
        
        // Methods
        internal void 下丅东丏不丒丐上东(System.Action<PGCompany.丂丈丘三丒丈不专丘> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.上一一丙丄丛丁丆丑, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上一一丙丄丛丁丆丑 != 1152921553932097096);
        
        }
        internal void 上丟丘不丘丝丅丞业(System.Action<PGCompany.丂丈丘三丒丈不专丘> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.上一一丙丄丛丁丆丑, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上一一丙丄丛丁丆丑 != 1152921553932233672);
        
        }
        internal bool 丗丙丐下丏丝丁丘三()
        {
            return (bool)this.丛专下丞丛丆丙且一;
        }
        internal PGCompany.丂丈丘三丒丈不专丘 丕丟丐丈丐丄丌三丐()
        {
            return (PGCompany.丂丈丘三丒丈不专丘)this.丆丗丟与丏丁且丒丕;
        }
        public void AddItemWithValue(string 丙业与丙丗丝不丈东)
        {
            var val_6;
            UnityEngine.GameObject val_2 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this._itemsGrid.gameObject, 丑且不丕与专丄业丙:  this._gridItemExample);
            val_6 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
            PGCompany.丂丈丘三丒丈不专丘 val_3 = val_2.GetComponent<PGCompany.丂丈丘三丒丈不专丘>();
            if(val_3 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = 4;
                val_3.SetStringValue(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            }
            
            this.丛不丞丂七丞世丁丏.Add(item:  val_3);
            this.七丕丌丘丄业世丙一.Add(item:  val_2);
            if(this.丛不丞丂七丞世丁丏.Count != 1)
            {
                    return;
            }
            
            this.丆且丟丙丅丞万丄丗(下丅丙一丂丗丅丝七:  val_3);
        }
        public void Clear()
        {
            var val_2;
            this.丛不丞丂七丞世丁丏.Clear();
            val_2 = null;
            val_2 = null;
            if((PopupList.<>c.<>9__20_0) == null)
            {
                goto label_4;
            }
            
            label_10:
            this.七丕丌丘丄业世丙一.ForEach(action:  PopupList.<>c.<>9__20_0);
            this.七丕丌丘丄业世丙一.Clear();
            return;
            label_4:
            PopupList.<>c.<>9__20_0 = new System.Action<UnityEngine.GameObject>(object:  PopupList.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PopupList.<>c::与三丏丄丒不且丗丄(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            if(this.七丕丌丘丄业世丙一 != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        public void SelectItemWithValue(string 丙业与丙丗丝不丈东)
        {
            string val_5;
            System.Collections.Generic.List<PGCompany.丂丈丘三丒丈不专丘> val_6;
            val_5 = 丙业与丙丗丝不丈东;
            val_6 = this.丛不丞丂七丞世丁丏;
            List.Enumerator<T> val_1 = val_6.GetEnumerator();
            label_8:
            if((2081442712 & 1) == 0)
            {
                goto label_2;
            }
            
            val_6 = 0.丐丏七丌丕丗业且上();
            var val_6 = 0;
            val_6 = val_6 + 1;
            if((System.String.op_Equality(a:  val_6.GetStringValue(), b:  val_5)) == false)
            {
                goto label_8;
            }
            
            this.丄丄丁业丕丁丐丄与(下丅丙一丂丗丅丝七:  val_6);
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void Open()
        {
            var val_2;
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._openedStateObjects, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._closedStateObjects, 丏业丟一东丂东丘丛:  false);
            this.丛专下丞丛丆丙且一 = true;
            val_2 = null;
            val_2 = null;
            if((PopupList.<>c.<>9__22_0) == null)
            {
                goto label_6;
            }
            
            label_12:
            this.丛不丞丂七丞世丁丏.ForEach(action:  PopupList.<>c.<>9__22_0);
            if(this.一万丈丝丈下丘万丙 == null)
            {
                    return;
            }
            
            this.一万丈丝丈下丘万丙.Invoke();
            return;
            label_6:
            PopupList.<>c.<>9__22_0 = new System.Action<PGCompany.丂丈丘三丒丈不专丘>(object:  PopupList.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PopupList.<>c::世世丛东丌业丈且丝(PGCompany.丂丈丘三丒丈不专丘 三丟东丕丄丄下下丑));
            if(this.丛不丞丂七丞世丁丏 != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
        public void Close()
        {
            this.下且一不丘一丆与丐();
            if(this.丄丑上丕丂丈丘丙七 == null)
            {
                    return;
            }
            
            this.丄丑上丕丂丈丘丙七.Invoke();
        }
        public void U_OpenClose()
        {
            if(this.丛专下丞丛丆丙且一 != false)
            {
                    this.Close();
                return;
            }
            
            this.Open();
        }
        public void U_ItemClick(PGCompany.丂丈丘三丒丈不专丘 下丅丙一丂丗丅丝七)
        {
            this.丆且丟丙丅丞万丄丗(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
            this.下且一不丘一丆与丐();
        }
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gridItemExample, 丏业丟一东丂东丘丛:  false);
        }
        private void OnEnable()
        {
            this.下且一不丘一丆与丐();
        }
        private void 丆且丟丙丅丞万丄丗(PGCompany.丂丈丘三丒丈不专丘 下丅丙一丂丗丅丝七)
        {
            this.丄丄丁业丕丁丐丄与(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
            if(this.上一一丙丄丛丁丆丑 == null)
            {
                    return;
            }
            
            this.上一一丙丄丛丁丆丑.Invoke(obj:  下丅丙一丂丗丅丝七);
        }
        private void 丁万丑七丆一丂丅丝(PGCompany.丂丈丘三丒丈不专丘 下丅丙一丂丗丅丝七)
        {
            this.丄丄丁业丕丁丐丄与(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        }
        private void 丄丄丁业丕丁丐丄与(PGCompany.丂丈丘三丒丈不专丘 下丅丙一丂丗丅丝七)
        {
            UILabel val_2;
            int val_4;
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            val_2 = this._headerLabel;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = 下丅丙一丂丗丅丝七.GetReadableValue();
            if(val_4 == null)
            {
                    val_4 = System.String.alignConst;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_2, 丕丗丘丑丛与丑业丒:  val_4);
            this.丆丗丟与丏丁且丒丕 = 下丅丙一丂丗丅丝七;
        }
        private void 下且一不丘一丆与丐()
        {
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._openedStateObjects, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._closedStateObjects, 丏业丟一东丂东丘丛:  true);
            this.丛专下丞丛丆丙且一 = false;
        }
        public PopupList()
        {
            this.丛不丞丂七丞世丁丏 = new System.Collections.Generic.List<PGCompany.丂丈丘三丒丈不专丘>();
            this.七丕丌丘丄业世丙一 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
    
    }

}
