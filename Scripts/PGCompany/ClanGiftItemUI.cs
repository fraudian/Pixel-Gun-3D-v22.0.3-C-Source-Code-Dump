using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanGiftItemUI : PGBehaviour
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        private UILabel _playerName;
        private PGCompany.GiftSystem.丏下丙丂万且一丑丛 <丟世丘丟不世东七三>k__BackingField;
        
        // Properties
        internal PGCompany.GiftSystem.丏下丙丂万且一丑丛 丏下丙丂万且一丑丛 { get; set; }
        
        // Methods
        internal PGCompany.GiftSystem.丏下丙丂万且一丑丛 丗万丒丒丟与丄丏七()
        {
            return (PGCompany.GiftSystem.丏下丙丂万且一丑丛)this.<丟世丘丟不世东七三>k__BackingField;
        }
        private void 不东丞丑不丅丘丗丐(PGCompany.GiftSystem.丏下丙丂万且一丑丛 丙业与丙丗丝不丈东)
        {
            this.<丟世丘丟不世东七三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 下与丞三丅丛丄七丕(PGCompany.GiftSystem.丏下丙丂万且一丑丛 丄丒丞专丐丌东丒业)
        {
            this.<丟世丘丟不世东七三>k__BackingField = 丄丒丞专丐丌东丒业;
            this.丝一丅丆三东丂丞七();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.GiftSystem.丏下丙丂万且一丑丛 丄丒丞专丐丌东丒业)
        {
            this.<丟世丘丟不世东七三>k__BackingField = 丄丒丞专丐丌东丒业;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._playerName, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8461")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8461")) + " " + 丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  this.<丟世丘丟不世东七三>k__BackingField.丕不业丟丕丘万世三())(丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  this.<丟世丘丟不世东七三>k__BackingField.丕不业丟丕丘万世三())));
            this._itemView.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.<丟世丘丟不世东七三>k__BackingField.丒丑丛丂丟丑丝丘丐()));
        }
        public ClanGiftItemUI()
        {
        
        }
    
    }

}
