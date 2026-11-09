using UnityEngine;

namespace PGCompany.BM
{
    internal class 丟丌丅丞下丏丕不丞
    {
        // Fields
        internal static System.Lazy<PGCompany.BM.丟丌丅丞下丏丕不丞> 丝业丆丁业三丈丟东;
        internal System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丛丈三丙不三下丗丁;
        private readonly System.Collections.Generic.HashSet<string> 万丟丛丐上万丞丟不;
        private readonly System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 上丙与丒丞三且三丗;
        
        // Properties
        internal static PGCompany.BM.丟丌丅丞下丏丕不丞 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.BM.丟丌丅丞下丏丕不丞 丑七不且上丗丁一世()
        {
            null = null;
            if(PGCompany.BM.丟丌丅丞下丏丕不丞.丝业丆丁业三丈丟东 != null)
            {
                    return PGCompany.BM.丟丌丅丞下丏丕不丞.丝业丆丁业三丈丟东.Value;
            }
            
            return PGCompany.BM.丟丌丅丞下丏丕不丞.丝业丆丁业三丈丟东.Value;
        }
        private 丟丌丅丞下丏丕不丞()
        {
            this.丛丈三丙不三下丗丁 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
            this.万丟丛丐上万丞丟不 = new System.Collections.Generic.HashSet<System.String>();
            this.上丙与丒丞三且三丗 = new System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世>();
        }
        internal bool 丘丌七丈丟不世丈丆(PGCompany.三东丏不丗世丅丌丄 与丛丗丈七专上丕丏)
        {
            if(与丛丗丈七专上丕丏 == null)
            {
                    return false;
            }
            
            if(与丛丗丈七专上丕丏.业上丙丞丐丄丆丅七() == null)
            {
                    return false;
            }
            
            if(this.万丟丛丐上万丞丟不 != null)
            {
                    return this.万丟丛丐上万丞丟不.Contains(item:  与丛丗丈七专上丕丏.业上丙丞丐丄丆丅七());
            }
            
            return this.万丟丛丐上万丞丟不.Contains(item:  与丛丗丈七专上丕丏.业上丙丞丐丄丆丅七());
        }
        internal void 丞七下不丐丄三世丒()
        {
            this.万丟丛丐上万丞丟不.Clear();
            PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().下丐丟专丗丅丘不丕(且丙丕丒丕丅世一丏:  this.万丟丛丐上万丞丟不, 丁丅丈丌丟世丗丗丟:  new System.Nullable<PGCompany.GameplayLoop.GameplayLoopType>() {HasValue = false});
            this.丛丈三丙不三下丗丁 = 上丑三丁丄丛丁万丑.丘不一丆丅丙上丈且();
        }
        internal PGCompany.BM.丒万丗丏一丝丅丌世 三丟丌丂丐丙丅丗七()
        {
            PGCompany.BM.丒万丗丏一丝丅丌世 val_5;
            if((System.Linq.Enumerable.Any<PGCompany.BM.丒万丗丏一丝丅丌世>(source:  this.上丙与丒丞三且三丗)) != false)
            {
                    val_5 = this.上丙与丒丞三且三丗.Item[0];
                bool val_3 = this.上丙与丒丞三且三丗.Remove(item:  val_5);
                return (PGCompany.BM.丒万丗丏一丝丅丌世)val_5;
            }
            
            PGCompany.BM.丒万丗丏一丝丅丌世 val_4 = null;
            val_5 = val_4;
            val_4 = new PGCompany.BM.丒万丗丏一丝丅丌世();
            return (PGCompany.BM.丒万丗丏一丝丅丌世)val_5;
        }
        internal void 丁丛与丅世丌且三上(PGCompany.BM.丒万丗丏一丝丅丌世 丒专丑丒丁丞三丆业)
        {
            if(丒专丑丒丁丞三丆业 == null)
            {
                    return;
            }
            
            if((this.上丙与丒丞三且三丗.Contains(item:  丒专丑丒丁丞三丆业)) != false)
            {
                    return;
            }
            
            this.上丙与丒丞三且三丗.Add(item:  丒专丑丒丁丞三丆业);
        }
        private static 丟丌丅丞下丏丕不丞()
        {
            null = null;
            PGCompany.BM.丟丌丅丞下丏丕不丞.丝业丆丁业三丈丟东 = new System.Lazy<PGCompany.BM.丟丌丅丞下丏丕不丞>(valueFactory:  new System.Func<PGCompany.BM.丟丌丅丞下丏丕不丞>(object:  丟丌丅丞下丏丕不丞.<>c.<>9, method:  PGCompany.BM.丟丌丅丞下丏丕不丞 丟丌丅丞下丏丕不丞.<>c::丈丕丝丁且丆丞七七()));
        }
    
    }

}
