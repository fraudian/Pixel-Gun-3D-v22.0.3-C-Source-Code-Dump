using UnityEngine;

namespace Rilisoft
{
    internal class ScrollOfferPackDrawer : BaseScrollOfferPackDrawer, 丄与且丈丘丄三丗丐
    {
        // Fields
        private Rilisoft.ScrollOfferPackItemExtendedView _itemExtendedView;
        
        // Properties
        public override int 下丄丈不与世丐业专 { get; }
        
        // Methods
        public override int get_Id()
        {
            return 2;
        }
        protected override void Awake()
        {
            this.Awake();
            this.gameObject.SetActive(value:  false);
        }
        protected override void 丈丁丏七丞丑丛东上(Rilisoft.BaseOfferItemCellView 丈丗与丞一上且上上, Rilisoft.BaseOfferItemCellView 专丂丕丗丗东世丞下)
        {
            if(专丂丕丗丗东世丞下 != 0)
            {
                    0 = 专丂丕丗丗东世丞下.Item;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemExtendedView.gameObject, 丏业丟一东丂东丘丛:  (0 != 0) ? 1 : 0);
            this._itemExtendedView.SetItem(与业下丟丛万丗丑丆:  0);
        }
        public ScrollOfferPackDrawer()
        {
        
        }
    
    }

}
