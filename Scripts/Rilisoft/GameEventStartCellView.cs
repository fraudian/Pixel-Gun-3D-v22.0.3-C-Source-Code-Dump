using UnityEngine;

namespace Rilisoft
{
    internal class GameEventStartCellView : GameEventFakeCellView
    {
        // Fields
        private UnityEngine.GameObject _selectedIndicator;
        
        // Methods
        protected override void 丕丕业七丙七丅丈丄()
        {
            UnityEngine.GameObject val_6 = this._selectedIndicator;
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6 = this._selectedIndicator;
            System.Nullable<丙丟与丐三丐万万丆> val_2 = this.CurrentState;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  ((val_2.HasValue.丙东专丂世丈丏丁丂() == 1) ? 1 : 0) &);
        }
        public GameEventStartCellView()
        {
        
        }
    
    }

}
