using UnityEngine;

namespace PGCompany
{
    internal class 七下丐丂丙丑东专丂 : 丆丒丏不丄丝世丁专
    {
        // Fields
        private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三;
        
        // Properties
        internal int 丅丞且丅不丙丗丕丏 { get; }
        
        // Methods
        internal 七下丐丂丙丑东专丂(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.上业丟世三与七七三 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        }
        internal int 万上三丅丝丒丆丙丕()
        {
            return this.丂丁丏一丙丛业且丌();
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4053");
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4087");
        }
        internal override string 东且丏丆万与东丙万()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10640");
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/VIP_universal2");
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 且业上丞丄丁专不丙()
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = this.上业丟世三与七七三;
            val_2.Clear();
            PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().下业丅丏一上丛不丕(专丂丕丗丗东世丞下: ref  val_2);
            return val_2;
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.七下丐丂丙丑东专丂(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
