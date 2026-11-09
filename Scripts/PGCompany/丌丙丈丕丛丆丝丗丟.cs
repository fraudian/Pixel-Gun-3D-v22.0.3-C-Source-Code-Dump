using UnityEngine;

namespace PGCompany
{
    internal sealed class 丌丙丈丕丛丆丝丗丟 : 丗丟丄丈东丝丕丄世
    {
        // Fields
        private System.Lazy<丟丄七万东与上丒丟> 丝丞丈不且丂丕万不;
        
        // Properties
        internal 丟丄七万东与上丒丟 一下丑丏且且七业丁 { get; }
        internal override CategoryNames 七丌丌丏丗东丕且丅 { get; }
        internal int 丄不丟万丛丒东丝三 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal string 丄业丟专丆七上丒丌 { get; }
        
        // Methods
        internal 丟丄七万东与上丒丟 丐上下三丑丈丑丄丟()
        {
            if(this.丝丞丈不且丂丕万不 != null)
            {
                    return this.丝丞丈不且丂丕万不.Value;
            }
            
            return this.丝丞丈不且丂丕万不.Value;
        }
        internal override CategoryNames 丒万丕七专不丏丞丌()
        {
            丟丄七万东与上丒丟 val_1 = this.丐上下三丑丈丑丄丟();
            if(val_1 == null)
            {
                    return 9990000;
            }
            
            return val_1.丒万丕七专不丏丞丌();
        }
        internal int 丈丒丟下丂丒东与丑()
        {
            丟丄七万东与上丒丟 val_1 = this.丐上下三丑丈丑丄丟();
            if(val_1 == null)
            {
                    return 2147483647;
            }
            
            return val_1.丈丒丟下丂丒东与丑();
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            丟丄七万东与上丒丟 val_1 = this.丐上下三丑丈丑丄丟();
            if(val_1 == null)
            {
                    return (ItemRarity)val_1;
            }
            
            return val_1.七东与丄丕丁丛世三();
        }
        internal string 丂丈世丞东专且丁丌()
        {
            int val_3;
            丟丄七万东与上丒丟 val_1 = this.丐上下三丑丈丑丄丟();
            if(val_1 != null)
            {
                    if(val_1.业上丙丞丐丄丆丅七() != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        public 丌丙丈丕丛丆丝丗丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.丝丞丈不且丂丕万不 = new System.Lazy<丟丄七万东与上丒丟>(valueFactory:  new System.Func<丟丄七万东与上丒丟>(object:  this, method:  丟丄七万东与上丒丟 PGCompany.丌丙丈丕丛丆丝丗丟::世东一上丐下丘丁与()));
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return 丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  this.丂丈世丞东专且丁丌());
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            return 丛且丗丌丏下七下丈.丛七丕丌丌丕丗七丟(丞一丁业丄一一业且:  this.丂丈世丞东专且丁丌());
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 丛且丗丌丏下七下丈.三丗一丄不丆不丏三(丞一丁业丄一一业且:  this.丂丈世丞东专且丁丌());
        }
        internal bool 世上万一丌一上丐上()
        {
            return 丛且丗丌丏下七下丈.世上万一丌一上丐上(丞一丁业丄一一业且:  this.丂丈世丞东专且丁丌());
        }
        internal int 丘东三丈丞丆丈丒丞()
        {
            return 丛且丗丌丏下七下丈.丘东三丈丞丆丈丒丞(丞一丁业丄一一业且:  this.丂丈世丞东专且丁丌());
        }
        internal override 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            int val_2 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七());
            丈丞丕丘丕丗与上一 val_4 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  val_2, 丞一丁业丄一一业且:  this.业上丙丞丐丄丆丅七(), 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            if(val_4 == null)
            {
                    return 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  val_2, 丛丐且下丂丏丁专丌:  this.业上丙丞丐丄丆丅七(), 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            }
            
            return val_4;
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            string val_7;
            PGCompany.三东丏不丗世丅丌丄 val_1 = this.丑丐丙丄丅世世丑丒();
            if(val_1 != null)
            {
                    val_7 = val_1.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_7 = 0;
            }
            
            int val_3 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_7);
            if((val_3 & 2147483648) != 0)
            {
                    return (string)this.丐丞丐丝下上上丐丂();
            }
            
            if((丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "CategoryName_{0}", arg0:  val_3))) != null)
            {
                    return (string)this.丐丞丐丝下上上丐丂();
            }
            
            return (string)this.丐丞丐丝下上上丐丂();
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丌丙丈丕丛丆丝丗丟(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private 丟丄七万东与上丒丟 世东一上丐下丘丁与()
        {
            string val_7;
            var val_8;
            val_7 = this;
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this.业上丙丞丐丄丆丅七())) != false)
            {
                    val_7 = this.业上丙丞丐丄丆丅七();
                丟丄七万东与上丒丟 val_6 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[val_7];
                return (丟丄七万东与上丒丟)val_8;
            }
            
            val_8 = 0;
            return (丟丄七万东与上丒丟)val_8;
        }
    
    }

}
