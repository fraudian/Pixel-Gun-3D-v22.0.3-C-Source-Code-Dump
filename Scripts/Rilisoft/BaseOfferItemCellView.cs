using UnityEngine;

namespace Rilisoft
{
    public abstract class BaseOfferItemCellView : MonoBehaviour
    {
        // Fields
        private Rilisoft.OfferItem _item;
        private System.Action<Rilisoft.BaseOfferItemCellView> 不丁丟且业丙不丞且;
        private bool <丝专丘不丌丟东丗丝>k__BackingField;
        
        // Properties
        public Rilisoft.OfferItem 不下下丞三一丘丗丐 { get; }
        protected abstract Rilisoft.ButtonHandler 东丐业丘丝丙丆丛丁 { get; }
        public bool 丟七一丏丈丒丘丝世 { get; set; }
        
        // Methods
        public Rilisoft.OfferItem get_Item()
        {
            return (Rilisoft.OfferItem)this._item;
        }
        protected abstract Rilisoft.ButtonHandler 丗一丂丏业丅丟丟丞(); // 0
        public bool get_IsSelected()
        {
            return (bool)this.<丝专丘不丌丟东丗丝>k__BackingField;
        }
        protected void 丂丄上且且丕业业丘(bool 丙业与丙丗丝不丈东)
        {
            this.<丝专丘不丌丟东丗丝>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual void Set(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, System.Action<Rilisoft.BaseOfferItemCellView> 万且丆丈万下不东七)
        {
            this._item = 下丅丙一丂丗丅丝七;
            this.不丁丟且业丙不丞且 = 万且丆丈万下不东七;
        }
        protected virtual void Awake()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.BaseOfferItemCellView::且七丙丞丅丒东丑东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.BaseOfferItemCellView::且七丙丞丅丒东丑东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 且七丙丞丅丒东丑东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.OnClick();
        }
        private void OnClick()
        {
            if(this.不丁丟且业丙不丞且 == null)
            {
                    return;
            }
            
            this.不丁丟且业丙不丞且.Invoke(obj:  this);
        }
        public virtual void SetSelected(bool 丞丈丌且东丆丅丗万)
        {
            this.<丝专丘不丌丟东丗丝>k__BackingField = 丞丈丌且东丆丅丗万;
        }
        protected virtual void Update()
        {
        
        }
        protected BaseOfferItemCellView()
        {
        
        }
    
    }

}
