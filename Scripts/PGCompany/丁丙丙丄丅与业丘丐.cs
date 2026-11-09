using UnityEngine;

namespace PGCompany
{
    internal sealed class 丁丙丙丄丅与业丘丐 : 丕丘一丐丕上不万丁
    {
        // Fields
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 与三下东不丛丂丞丌;
        private PGCompany.与丂丈三三东丕七丕.世丕上丞与业丂丞丞 <丙丑业丑业丝东与一>k__BackingField;
        private ItemRarity <丂业丏且世专下丕三>k__BackingField;
        private int <丁丄丒东东下丘丗上>k__BackingField;
        
        // Properties
        internal PGCompany.与丂丈三三东丕七丕.世丕上丞与业丂丞丞 世丕上丞与业丂丞丞 { get; set; }
        internal ItemRarity 万丗丏东且万专丕丁 { get; set; }
        internal int 不上丟丏七丕不丑业 { get; set; }
        
        // Methods
        internal PGCompany.与丂丈三三东丕七丕.世丕上丞与业丂丞丞 丕丌丐丙丑丙丌世下()
        {
            return (世丕上丞与业丂丞丞)this.<丙丑业丑业丝东与一>k__BackingField;
        }
        private void 世丈业三丝丁一丐不(PGCompany.与丂丈三三东丕七丕.世丕上丞与业丂丞丞 丙业与丙丗丝不丈东)
        {
            this.<丙丑业丑业丝东与一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal ItemRarity 丙万丂与丗专丏三丁()
        {
            return (ItemRarity)this.<丂业丏且世专下丕三>k__BackingField;
        }
        private void 上东万丅丈专丒丈丏(ItemRarity 丙业与丙丗丝不丈东)
        {
            this.<丂业丏且世专下丕三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丆丞且丗丏丈丛丛下()
        {
            return (int)this.<丁丄丒东东下丘丗上>k__BackingField;
        }
        private void 下丟不与三丝七与丕(int 丙业与丙丗丝不丈东)
        {
            this.<丁丄丒东东下丘丗上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public 丁丙丙丄丅与业丘丐(int 丞世不丒下上上丝丑, PGCompany.与丂丈三三东丕七丕.丟不丒专丈丌丘丈专 丁丅丈丌丟世丗丗丟, PGCompany.世丞上丏丗不丛上东 丙业丞丑七丗下丟丌, PGCompany.与丂丈三三东丕七丕.世丕上丞与业丂丞丞 丒专上万丂七专七丛, ItemRarity 东东世丝业丝一丂丄, int 与丙专丆万丟专七丞, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 万三丄业丂丕丆丝丑)
        {
            this.与三下东不丛丂丞丌 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            this.<丙丑业丑业丝东与一>k__BackingField = 丒专上万丂七专七丛;
            this.<丂业丏且世专下丕三>k__BackingField = 东东世丝业丝一丂丄;
            this.<丁丄丒东东下丘丗上>k__BackingField = 与丙专丆万丟专七丞;
            this.与三下东不丛丂丞丌 = 万三丄业丂丕丆丝丑;
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 0;
        }
        protected override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄东且丂一上丈与丈()
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = PGCompany.七丂专七丆丗不丌专.丄东且丂一上丈与丈(丒专上万丂七专七丛:  this.<丙丑业丑业丝东与一>k__BackingField, 丈下丑丆上丏丗丈专:  this.<丂业丏且世专下丕三>k__BackingField, 与丙专丆万丟专七丞:  this.<丁丄丒东东下丘丗上>k__BackingField);
            val_1.AddRange(collection:  this.与三下东不丛丂丞丌);
            return val_1;
        }
        internal override bool 丈七专与丈丝一专丁()
        {
            return true;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0} ItemType={1} ItemRarity={2}", arg0:  this.ToString(), arg1:  this.<丙丑业丑业丝东与一>k__BackingField, arg2:  this.<丂业丏且世专下丕三>k__BackingField);
        }
    
    }

}
