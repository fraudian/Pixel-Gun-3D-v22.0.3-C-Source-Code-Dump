using UnityEngine;

namespace PGCompany
{
    internal class ModuleInStoredView : MonoBehaviour
    {
        // Fields
        private PGCompany.ModuleSlotView _moduleSlotView;
        private UnityEngine.GameObject _disableContainer;
        private UILabel _disableLabelWeight;
        private UILabel _disableLabelJustExist;
        private UILabel _disableLabelHasElemental;
        private UnityEngine.GameObject _emptyContainer;
        private UnityEngine.GameObject _notEmptyContainer;
        private PGCompany.丗丟丅七东丄丙丟上 专上丒丄丛七丑三丛;
        private PGCompany.丏丂一丗丙世丏丐三 丙丄七万三丁丆丅丅;
        
        // Properties
        internal PGCompany.ModuleSlotView 丕丂不七丟三丈七丄 { get; }
        
        // Methods
        internal PGCompany.ModuleSlotView 且丆丟丌丈丞与业丒()
        {
            return (PGCompany.ModuleSlotView)this._moduleSlotView;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丅七东丄丙丟上 世丝七与丝丒丐业下, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            this.专上丒丄丛七丑三丛 = 世丝七与丝丒丐业下;
            this.丙丄七万三丁丆丅丅 = 丕上业丕丘上丘七一;
            this._moduleSlotView.丈且东丑丂且万丒丅(丕上业丕丘上丘七一:  丕上业丕丘上丘七一);
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            int val_1 = this.专上丒丄丛七丑三丛.丁专一丈丝丈丕七三(丕上业丕丘上丘七一:  this.丙丄七万三丁丆丅丅);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._disableContainer, 丏业丟一东丂东丘丛:  (val_1 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._disableLabelWeight, 丏业丟一东丂东丘丛:  (val_1 == 4) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._disableLabelJustExist, 丏业丟一东丂东丘丛:  (val_1 == 2) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._disableLabelHasElemental, 丏业丟一东丂东丘丛:  (val_1 == 6) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._emptyContainer, 丏业丟一东丂东丘丛:  (this.丙丄七万三丁丆丅丅 == 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notEmptyContainer, 丏业丟一东丂东丘丛:  (this.丙丄七万三丁丆丅丅 != 0) ? 1 : 0);
        }
        public ModuleInStoredView()
        {
        
        }
    
    }

}
