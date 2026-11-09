using UnityEngine;

namespace PGCompany
{
    internal class 丌不丞丐世丞三丘丌
    {
        // Fields
        internal PGCompany.丘丁丕丈丘且业三丄 Type;
        internal string ItemId;
        internal PGCompany.ClanStoreTab ClanStoreTab;
        internal CategoryNames ItemCategory;
        internal CategoryNames ShopCategory;
        internal Rilisoft.七丕丟丏三丈一丄世 GameMode;
        internal PGCompany.GameModeHub.丕业丞七丄七丒万东 GameModeGroup;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isBrawl;
        internal bool ToBuyWindow;
        internal long 丛与丘业三上丛下东;
        internal PGCompany.EventHub.丄世丌东丏三东丒丂 丄世丌东丏三东丒丂;
        internal bool 业东丞世丏上丈丘丞;
        
        // Properties
        internal bool 丆万一业丂丂万与丁 { get; set; }
        
        // Methods
        internal bool 且下丐丅世丗丁且丄()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isBrawl);
        }
        internal void 与丑丞与丅丈七丗丗(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._isBrawl = val_3;
            mem[1152921555744215216] = val_3.上万三丆专丏丒丗业;
        }
        public 丌不丞丐世丞三丘丌()
        {
            this.ItemCategory = 9990000;
            this.GameMode = 100;
        }
    
    }

}
