using UnityEngine;

namespace PGCompany
{
    internal class 丁业丝丂丘世丅专且 : IEqualityComparer<PGCompany.万丌专丌丗丂业丆且>
    {
        // Methods
        public bool Equals(PGCompany.万丌专丌丗丂业丆且 三丟东丕丄丄下下丑, PGCompany.万丌专丌丗丂业丆且 丒丒丄丁且丄丆丂丌)
        {
            if(三丟东丕丄丄下下丑.下丄丈不与世丐业专 != 丒丒丄丁且丄丆丂丌.下丄丈不与世丐业专)
            {
                    return false;
            }
            
            if(三丟东丕丄丄下下丑.业东丝丙丒丟与三万 != 丒丒丄丁且丄丆丂丌.业东丝丙丒丟与三万)
            {
                    return false;
            }
            
            if(三丟东丕丄丄下下丑.丂东丐丟一专三与专 != 丒丒丄丁且丄丆丂丌.丂东丐丟一专三与专)
            {
                    return false;
            }
            
            if((-1947285952) != (-1947277712))
            {
                    return false;
            }
            
            if(268435467 != 268435467)
            {
                    return false;
            }
            
            if(三丟东丕丄丄下下丑.丟丐丏不丏丌丐且一 != 丒丒丄丁且丄丆丂丌.丟丐丏不丏丌丐且一)
            {
                    return false;
            }
            
            return (bool)(三丟东丕丄丄下下丑.丄丟丕丅东丂丏专丘 == 丒丒丄丁且丄丆丂丌.丄丟丕丅东丂丏专丘) ? 1 : 0;
        }
        public int GetHashCode(PGCompany.万丌专丌丗丂业丆且 三且丑东与丝丛丐丏)
        {
            int val_7 = 三且丑东与丝丛丐丏.丄丟丕丅东丂丏专丘.GetHashCode();
            var val_9 = 6;
            int val_8 = 三且丑东与丝丛丐丏.业东丝丙丒丟与三万.GetHashCode() + (三且丑东与丝丛丐丏.下丄丈不与世丐业专.GetHashCode() * val_9);
            val_8 = 三且丑东与丝丛丐丏.丂东丐丟一专三与专.GetHashCode() + (val_8 * val_9);
            val_8 = (-1947149360.丙东专丂世丈丏丁丂()) + (val_8 * val_9);
            val_8 = 三且丑东与丝丛丐丏.丗丄丐丈丛丛三丗丏.丙东专丂世丈丏丁丂() + (val_8 * val_9);
            val_8 = 三且丑东与丝丛丐丏.丟丐丏不丏丌丐且一.GetHashCode() + (val_8 * val_9);
            val_9 = val_7 + (val_8 * val_9);
            val_7 = val_9 + 11757312;
            return (int)val_7;
        }
        public 丁业丝丂丘世丅专且()
        {
        
        }
    
    }

}
