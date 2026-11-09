using UnityEngine;

namespace Rilisoft
{
    internal struct 丅丌丌丐丘丕丟丏丝 : IEquatable<Rilisoft.丅丌丌丐丘丕丟丏丝>
    {
        // Fields
        private long 七丄不丐丗三丝丑一;
        private readonly long 丑丒丄下丁丐专丄丞;
        
        // Properties
        internal long 不丑一丙东丙丆丁七 { get; set; }
        
        // Methods
        public static Rilisoft.丅丌丌丐丘丕丟丏丝 万丒丌丕万丏不丈世(long 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_1 = (long)val_1 ^ 丙业与丙丗丝不丈东;
            return new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_1, 丑丒丄下丁丐专丄丞 = (long)val_1};
        }
        internal long 世三丞丅丑丌丈丈一()
        {
            return (long)X8 ^ X9;
        }
        internal void 丙丏不三丗三丙丈与(long 丙业与丙丗丝不丈东)
        {
            mem[1152921543533860000] = X8 ^ 丙业与丙丗丝不丈东;
        }
        internal 丅丌丌丐丘丕丟丏丝(long 丝丂丘丄丅且三丌三)
        {
            mem[1152921543533972000] = 丝丂丘丄丅且三丌三;
            mem[1152921543533972008] = 丝丂丘丄丅且三丌三;
        }
        internal 丅丌丌丐丘丕丟丏丝(long 丝丂丘丄丅且三丌三, long 与丏七丞三与丐丆业)
        {
            mem[1152921543534084000] = 与丏七丞三与丐丆业 ^ 丝丂丘丄丅且三丌三;
            mem[1152921543534084008] = 丝丂丘丄丅且三丌三;
        }
        internal static Rilisoft.丅丌丌丐丘丕丟丏丝 东丝七业丄丑丒世七(long 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_1 = (long)val_1 ^ 丙业与丙丗丝不丈东;
            return new Rilisoft.丅丌丌丐丘丕丟丏丝() {七丄不丐丗三丝丑一 = val_1, 丑丒丄下丁丐专丄丞 = (long)val_1};
        }
        public override int GetHashCode()
        {
            return (int)X8 ^ X9.GetHashCode();
        }
        public bool Equals(Rilisoft.丅丌丌丐丘丕丟丏丝 丘丛丏丘丝七世七丅)
        {
            return (bool)(X8 ^ X9 == 丘丛丏丘丝七世七丅.七丄不丐丗三丝丑一 ^ 丘丛丏丘丝七世七丅.丑丒丄下丁丐专丄丞) ? 1 : 0;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            return false;
        }
        public override string ToString()
        {
            return (string)X8 ^ X9.ToString();
        }
    
    }

}
