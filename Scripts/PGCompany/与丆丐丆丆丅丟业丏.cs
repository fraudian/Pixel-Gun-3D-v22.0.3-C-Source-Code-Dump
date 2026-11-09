using UnityEngine;

namespace PGCompany
{
    internal sealed class 与丆丐丆丆丅丟业丏 : 丗丟丄丈东丝丕丄世
    {
        // Fields
        private System.Lazy<PGCompany.丐万丟丈丂丕丞东业> 丄专丛与七丅业三世;
        
        // Properties
        internal PGCompany.丐万丟丈丂丕丞东业 与丈丙丑丈世丆丛丁 { get; }
        
        // Methods
        internal PGCompany.丐万丟丈丂丕丞东业 丝万业三丘丂业丒丒()
        {
            if(this.丄专丛与七丅业三世 != null)
            {
                    return this.丄专丛与七丅业三世.Value;
            }
            
            return this.丄专丛与七丅业三世.Value;
        }
        public 与丆丐丆丆丅丟业丏(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            var val_3;
            System.Func<PGCompany.丐万丟丈丂丕丞东业> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 与丆丐丆丆丅丟业丏.<>c.<>9__3_0;
            if(val_5 == null)
            {
                    System.Func<PGCompany.丐万丟丈丂丕丞东业> val_1 = null;
                val_5 = val_1;
                val_1 = new System.Func<PGCompany.丐万丟丈丂丕丞东业>(object:  与丆丐丆丆丅丟业丏.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.丐万丟丈丂丕丞东业 与丆丐丆丆丅丟业丏.<>c::世丒三专丞丒丘丌下());
                与丆丐丆丆丅丟业丏.<>c.<>9__3_0 = val_5;
            }
            
            this.丄专丛与七丅业三世 = new System.Lazy<PGCompany.丐万丟丈丂丕丞东业>(valueFactory:  val_1);
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.与丆丐丆丆丅丟业丏(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
