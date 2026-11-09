using UnityEngine;

namespace Rilisoft
{
    internal class Scroll3dDotView : BaseOfferItemCellView
    {
        // Fields
        private UnityEngine.GameObject _selectedIndicator;
        
        // Properties
        protected override Rilisoft.ButtonHandler 东丐业丘丝丙丆丛丁 { get; }
        
        // Methods
        protected override Rilisoft.ButtonHandler 丗一丂丏业丅丟丟丞()
        {
            return 0;
        }
        public override void SetSelected(bool 丞丈丌且东丆丅丗万)
        {
            丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
            this.SetSelected(丞丈丌且东丆丅丗万:  丞丈丌且东丆丅丗万);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectedIndicator, 丏业丟一东丂东丘丛:  this.IsSelected);
        }
        public Scroll3dDotView()
        {
        
        }
    
    }

}
